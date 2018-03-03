' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:34
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
	''' <summary>Entity class which represents the entity 'McomCotizacionCompra'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McomCotizacionCompraEntity 
#Else
	<Serializable()> _
	Public Class McomCotizacionCompraEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mcomCotizacionCompraProveedor As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedor, _alreadyFetchedMcomCotizacionCompraProveedor As Boolean
		Private _mcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorDetalle As Boolean
		Private _ordenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
		Private _alwaysFetchOrdenCompraDetalle, _alreadyFetchedOrdenCompraDetalle As Boolean
		Private _proveedorCollectionViaMcomCotizacionCompraProveedor As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor, _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor As Boolean
		Private _productoCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _productoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _tipoMonedaCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle, _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle As Boolean
		Private _ordenCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _solicitudProductoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle As Boolean
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
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		Public Sub New(idCotizacion As System.Int32)

			InitClassFetch(idCotizacion, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCotizacion As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCotizacion, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="validator">The custom validator Object for this McomCotizacionCompraEntity</param>
		Public Sub New(idCotizacion As System.Int32, validator As IValidator)

			InitClassFetch(idCotizacion, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mcomCotizacionCompraProveedor = CType(info.GetValue("_mcomCotizacionCompraProveedor", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedor = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedor")
			_alreadyFetchedMcomCotizacionCompraProveedor = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedor")
			_mcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorDetalle")
			_ordenCompraDetalle = CType(info.GetValue("_ordenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)), Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)
			_alwaysFetchOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraDetalle")
			_proveedorCollectionViaMcomCotizacionCompraProveedor = CType(info.GetValue("_proveedorCollectionViaMcomCotizacionCompraProveedor", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor = info.GetBoolean("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor")
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor = info.GetBoolean("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor")
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_productoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_productoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle")
			_tipoMonedaCollectionViaOrdenCompraDetalle = CType(info.GetValue("_tipoMonedaCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle")
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle")
			_ordenCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_ordenCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle")
			_solicitudProductoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_solicitudProductoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle")
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
			_alreadyFetchedMcomCotizacionCompraProveedor = (_mcomCotizacionCompraProveedor.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedOrdenCompraDetalle = (_ordenCompraDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor = (_proveedorCollectionViaMcomCotizacionCompraProveedor.Count > 0)
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = (_productoCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = (_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = (_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = (_productoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = (_tipoMonedaCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = (_ordenCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = (_solicitudProductoCollectionViaOrdenCompraDetalle.Count > 0)
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
			info.AddValue("_mcomCotizacionCompraProveedor", _mcomCotizacionCompraProveedor)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedor", _alwaysFetchMcomCotizacionCompraProveedor)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedor", _alreadyFetchedMcomCotizacionCompraProveedor)
			info.AddValue("_mcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_ordenCompraDetalle", _ordenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraDetalle", _alwaysFetchOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraDetalle", _alreadyFetchedOrdenCompraDetalle)
			info.AddValue("_proveedorCollectionViaMcomCotizacionCompraProveedor", _proveedorCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor", _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor", _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", _productoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_productoCollectionViaOrdenCompraDetalle", _productoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaOrdenCompraDetalle", _alwaysFetchProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_tipoMonedaCollectionViaOrdenCompraDetalle", _tipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle", _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle", _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_ordenCompraCollectionViaOrdenCompraDetalle", _ordenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle", _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_solicitudProductoCollectionViaOrdenCompraDetalle", _solicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle", _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle)
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
				Case "McomCotizacionCompraProveedor"
					_alreadyFetchedMcomCotizacionCompraProveedor = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedor.Add(CType(entity, McomCotizacionCompraProveedorEntity))
					End If
				Case "McomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorDetalleEntity))
					End If
				Case "OrdenCompraDetalle"
					_alreadyFetchedOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.OrdenCompraDetalle.Add(CType(entity, OrdenCompraDetalleEntity))
					End If
				Case "ProveedorCollectionViaMcomCotizacionCompraProveedor"
					_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaMcomCotizacionCompraProveedor.Add(CType(entity, ProveedorEntity))
					End If
				Case "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, SolicitudProductoDetalleEntity))
					End If
				Case "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, ProveedorEntity))
					End If
				Case "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorEntity))
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
				Case "OrdenCompraCollectionViaOrdenCompraDetalle"
					_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.OrdenCompraCollectionViaOrdenCompraDetalle.Add(CType(entity, OrdenCompraEntity))
					End If
				Case "SolicitudProductoCollectionViaOrdenCompraDetalle"
					_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoCollectionViaOrdenCompraDetalle.Add(CType(entity, SolicitudProductoEntity))
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
				Case "McomCotizacionCompraProveedor"
					_mcomCotizacionCompraProveedor.Add(CType(relatedEntity, McomCotizacionCompraProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					_mcomCotizacionCompraProveedorDetalle.Add(CType(relatedEntity, McomCotizacionCompraProveedorDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					_ordenCompraDetalle.Add(CType(relatedEntity, OrdenCompraDetalleEntity))
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
				Case "McomCotizacionCompraProveedor"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedorDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					MyBase.PerformRelatedEntityRemoval(_ordenCompraDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_mcomCotizacionCompraProveedor)
			toReturn.Add(_mcomCotizacionCompraProveedorDetalle)
			toReturn.Add(_ordenCompraDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32) As Boolean
			Return FetchUsingPK(idCotizacion, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCotizacion, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCotizacion, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCotizacion, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McomCotizacionCompraFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McomCotizacionCompraFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Return GetMultiMcomCotizacionCompraProveedor(forceFetch, _mcomCotizacionCompraProveedor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomCotizacionCompraProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Return GetMultiMcomCotizacionCompraProveedor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Return GetMultiMcomCotizacionCompraProveedor(forceFetch, _mcomCotizacionCompraProveedor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomCotizacionCompraProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			If ( Not _alreadyFetchedMcomCotizacionCompraProveedor Or forceFetch Or _alwaysFetchMcomCotizacionCompraProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomCotizacionCompraProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomCotizacionCompraProveedor)
					End If
				End If
				_mcomCotizacionCompraProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomCotizacionCompraProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomCotizacionCompraProveedor.GetMultiManyToOne(Nothing, Me, Filter)
				_mcomCotizacionCompraProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedMcomCotizacionCompraProveedor = True
			End If
			Return _mcomCotizacionCompraProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomCotizacionCompraProveedor'. These settings will be taken into account
		''' when the property McomCotizacionCompraProveedor is requested or GetMultiMcomCotizacionCompraProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomCotizacionCompraProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomCotizacionCompraProveedor.SortClauses=sortClauses
			_mcomCotizacionCompraProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorDetalleEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorDetalleEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			If ( Not _alreadyFetchedMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomCotizacionCompraProveedorDetalle)
					End If
				End If
				_mcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomCotizacionCompraProveedorDetalle.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_mcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _mcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property McomCotizacionCompraProveedorDetalle is requested or GetMultiMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_mcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
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
				_ordenCompraDetalle.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor(forceFetch, _proveedorCollectionViaMcomCotizacionCompraProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor Or forceFetch Or _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaMcomCotizacionCompraProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaMcomCotizacionCompraProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedor_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_proveedorCollectionViaMcomCotizacionCompraProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaMcomCotizacionCompraProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaMcomCotizacionCompraProveedor.GetMulti(Filter, relations)
				_proveedorCollectionViaMcomCotizacionCompraProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor = True
			End If
			Return _proveedorCollectionViaMcomCotizacionCompraProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaMcomCotizacionCompraProveedor'. These settings will be taken into account
		''' when the property ProveedorCollectionViaMcomCotizacionCompraProveedor is requested or GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaMcomCotizacionCompraProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaMcomCotizacionCompraProveedor.SortClauses=sortClauses
			_proveedorCollectionViaMcomCotizacionCompraProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _productoCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _productoCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoDetalleEntity'</returns>
		Public Function GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Return GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			If ( Not _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Return GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			If ( Not _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
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
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
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

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompraCollectionViaOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompraCollectionViaOrdenCompraDetalle(forceFetch, _ordenCompraCollectionViaOrdenCompraDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompraCollectionViaOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			If ( Not _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle Or forceFetch Or _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompraCollectionViaOrdenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompraCollectionViaOrdenCompraDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				_ordenCompraCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompraCollectionViaOrdenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompraCollectionViaOrdenCompraDetalle.GetMulti(Filter, relations)
				_ordenCompraCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = True
			End If
			Return _ordenCompraCollectionViaOrdenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompraCollectionViaOrdenCompraDetalle'. These settings will be taken into account
		''' when the property OrdenCompraCollectionViaOrdenCompraDetalle is requested or GetMultiOrdenCompraCollectionViaOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompraCollectionViaOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompraCollectionViaOrdenCompraDetalle.SortClauses=sortClauses
			_ordenCompraCollectionViaOrdenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraEntity.Relations.SucursalEntityUsingIdSucursal) Then
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(McomCotizacionCompraFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McomCotizacionCompraFieldIndex)


					Case McomCotizacionCompraFieldIndex.IdSucursal
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
			_mcomCotizacionCompraProveedor.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaMcomCotizacionCompraProveedor.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
		If Not _sucursal Is Nothing Then
				_sucursal.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McomCotizacionCompraDAO = CType(CreateDAOInstance(), McomCotizacionCompraDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McomCotizacionCompraDAO = CType(CreateDAOInstance(), McomCotizacionCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McomCotizacionCompraDAO = CType(CreateDAOInstance(), McomCotizacionCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McomCotizacionCompraEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McomCotizacionCompraEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="validator">The validator Object for this McomCotizacionCompraEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCotizacion As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCotizacion, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mcomCotizacionCompraProveedor = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_mcomCotizacionCompraProveedor.SetContainingEntityInfo(Me, "CotizacionCompra")
			_alwaysFetchMcomCotizacionCompraProveedor = False
			_alreadyFetchedMcomCotizacionCompraProveedor = False
			_mcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(New McomCotizacionCompraProveedorDetalleEntityFactory())
			_mcomCotizacionCompraProveedorDetalle.SetContainingEntityInfo(Me, "CotizacionCompra")
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = False
			_ordenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(New OrdenCompraDetalleEntityFactory())
			_ordenCompraDetalle.SetContainingEntityInfo(Me, "CotizacionCompra")
			_alwaysFetchOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraDetalle = False
			_proveedorCollectionViaMcomCotizacionCompraProveedor = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor = False
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedor = False
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_productoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = False
			_tipoMonedaCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = False
			_ordenCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = False
			_solicitudProductoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = False
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

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _sucursal</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSucursal(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", McomCotizacionCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, signalRelatedEntity, "CotizacionCompra", resetFKFields, New Integer() { CInt(McomCotizacionCompraFieldIndex.IdSucursal) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", McomCotizacionCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, _alreadyFetchedSucursal, New String() {  } )
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
		''' <param name="idCotizacion">PK value for McomCotizacionCompra which data should be fetched into this McomCotizacionCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCotizacion As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McomCotizacionCompraFieldIndex.IdCotizacion)).ForcedCurrentValueWrite(idCotizacion)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcomCotizacionCompraDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McomCotizacionCompraEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McomCotizacionCompraRelations
			Get	
				Return New McomCotizacionCompraRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedorDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(), _
					McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaMcomCotizacionCompraProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaMcomCotizacionCompraProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, relations, "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, relations, "OrdenCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, "__McomCotizacionCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					McomCotizacionCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					McomCotizacionCompraEntity.Relations.SucursalEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McomCotizacionCompraEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McomCotizacionCompraEntity.CustomProperties
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
				Return McomCotizacionCompraEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCotizacion property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."IdCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdCotizacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.IdCotizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.IdCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioCotizacion property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."FolioCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioCotizacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.FolioCotizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.FolioCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdSucursal property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."IdSucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdSucursal]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.IdSucursal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.IdSucursal, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McomCotizacionCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompra"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomCotizacionCompraProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomCotizacionCompraProveedor]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Get
				Return GetMultiMcomCotizacionCompraProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraProveedor. When set to true, McomCotizacionCompraProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomCotizacionCompraProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraProveedor As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraProveedor
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Get
				Return GetMultiMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraProveedorDetalle. When set to true, McomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraProveedorDetalle = value
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
	
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaMcomCotizacionCompraProveedor]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaMcomCotizacionCompraProveedor. When set to true, ProveedorCollectionViaMcomCotizacionCompraProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaMcomCotizacionCompraProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaMcomCotizacionCompraProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor
			End Get
			Set
				_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Get
				Return GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
			Get
				Return GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = value
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
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompraCollectionViaOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompraCollectionViaOrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Get
				Return GetMultiOrdenCompraCollectionViaOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompraCollectionViaOrdenCompraDetalle. When set to true, OrdenCompraCollectionViaOrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompraCollectionViaOrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompraCollectionViaOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = value
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
							_sucursal.UnsetRelatedEntity(Me, "CotizacionCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CotizacionCompra")
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
				Return CInt(Integralab.ORM.EntityType.McomCotizacionCompraEntity)
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
