' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:29
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
	''' <summary>Entity class which represents the entity 'TipoMoneda'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class TipoMonedaEntity 
#Else
	<Serializable()> _
	Public Class TipoMonedaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorDetalle As Boolean
		Private _ordenCompra As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompra, _alreadyFetchedOrdenCompra As Boolean
		Private _ordenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
		Private _alwaysFetchOrdenCompraDetalle, _alreadyFetchedOrdenCompraDetalle As Boolean
		Private _cuenta As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuenta, _alreadyFetchedCuenta As Boolean
		Private _tipoCambio As Integralab.ORM.CollectionClasses.TipoCambioCollection
		Private _alwaysFetchTipoCambio, _alreadyFetchedTipoCambio As Boolean
		Private _cotizacionServicio As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
		Private _alwaysFetchCotizacionServicio, _alreadyFetchedCotizacionServicio As Boolean
		Private _ordenServicio As Integralab.ORM.CollectionClasses.OrdenServicioCollection
		Private _alwaysFetchOrdenServicio, _alreadyFetchedOrdenServicio As Boolean
		Private _productoCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedorCollectionViaOrdenCompra As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaOrdenCompra, _alreadyFetchedProveedorCollectionViaOrdenCompra As Boolean
		Private _productoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _cotizacionCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _ordenCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _solicitudProductoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _bancosCollectionViaCuenta As Integralab.ORM.CollectionClasses.BancosCollection
		Private _alwaysFetchBancosCollectionViaCuenta, _alreadyFetchedBancosCollectionViaCuenta As Boolean
		Private _cuentaContableCollectionViaCuenta As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaCuenta, _alreadyFetchedCuentaContableCollectionViaCuenta As Boolean
		Private _proveedorCollectionViaCotizacionServicio As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCotizacionServicio, _alreadyFetchedProveedorCollectionViaCotizacionServicio As Boolean
		Private _proveedorCollectionViaOrdenServicio As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaOrdenServicio, _alreadyFetchedProveedorCollectionViaOrdenServicio As Boolean



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
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <param name="validator">The custom validator Object for this TipoMonedaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorDetalle")
			_ordenCompra = CType(info.GetValue("_ordenCompra", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompra")
			_alreadyFetchedOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompra")
			_ordenCompraDetalle = CType(info.GetValue("_ordenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)), Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)
			_alwaysFetchOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraDetalle")
			_cuenta = CType(info.GetValue("_cuenta", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuenta = info.GetBoolean("_alwaysFetchCuenta")
			_alreadyFetchedCuenta = info.GetBoolean("_alreadyFetchedCuenta")
			_tipoCambio = CType(info.GetValue("_tipoCambio", GetType(Integralab.ORM.CollectionClasses.TipoCambioCollection)), Integralab.ORM.CollectionClasses.TipoCambioCollection)
			_alwaysFetchTipoCambio = info.GetBoolean("_alwaysFetchTipoCambio")
			_alreadyFetchedTipoCambio = info.GetBoolean("_alreadyFetchedTipoCambio")
			_cotizacionServicio = CType(info.GetValue("_cotizacionServicio", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioCollection)
			_alwaysFetchCotizacionServicio = info.GetBoolean("_alwaysFetchCotizacionServicio")
			_alreadyFetchedCotizacionServicio = info.GetBoolean("_alreadyFetchedCotizacionServicio")
			_ordenServicio = CType(info.GetValue("_ordenServicio", GetType(Integralab.ORM.CollectionClasses.OrdenServicioCollection)), Integralab.ORM.CollectionClasses.OrdenServicioCollection)
			_alwaysFetchOrdenServicio = info.GetBoolean("_alwaysFetchOrdenServicio")
			_alreadyFetchedOrdenServicio = info.GetBoolean("_alreadyFetchedOrdenServicio")
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedorCollectionViaOrdenCompra = CType(info.GetValue("_proveedorCollectionViaOrdenCompra", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaOrdenCompra = info.GetBoolean("_alwaysFetchProveedorCollectionViaOrdenCompra")
			_alreadyFetchedProveedorCollectionViaOrdenCompra = info.GetBoolean("_alreadyFetchedProveedorCollectionViaOrdenCompra")
			_productoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_productoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle")
			_cotizacionCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle")
			_ordenCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_ordenCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle")
			_solicitudProductoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_solicitudProductoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle")
			_bancosCollectionViaCuenta = CType(info.GetValue("_bancosCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.BancosCollection)), Integralab.ORM.CollectionClasses.BancosCollection)
			_alwaysFetchBancosCollectionViaCuenta = info.GetBoolean("_alwaysFetchBancosCollectionViaCuenta")
			_alreadyFetchedBancosCollectionViaCuenta = info.GetBoolean("_alreadyFetchedBancosCollectionViaCuenta")
			_cuentaContableCollectionViaCuenta = CType(info.GetValue("_cuentaContableCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaCuenta = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaCuenta")
			_alreadyFetchedCuentaContableCollectionViaCuenta = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaCuenta")
			_proveedorCollectionViaCotizacionServicio = CType(info.GetValue("_proveedorCollectionViaCotizacionServicio", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCotizacionServicio = info.GetBoolean("_alwaysFetchProveedorCollectionViaCotizacionServicio")
			_alreadyFetchedProveedorCollectionViaCotizacionServicio = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCotizacionServicio")
			_proveedorCollectionViaOrdenServicio = CType(info.GetValue("_proveedorCollectionViaOrdenServicio", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaOrdenServicio = info.GetBoolean("_alwaysFetchProveedorCollectionViaOrdenServicio")
			_alreadyFetchedProveedorCollectionViaOrdenServicio = info.GetBoolean("_alreadyFetchedProveedorCollectionViaOrdenServicio")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedOrdenCompra = (_ordenCompra.Count > 0)
			_alreadyFetchedOrdenCompraDetalle = (_ordenCompraDetalle.Count > 0)
			_alreadyFetchedCuenta = (_cuenta.Count > 0)
			_alreadyFetchedTipoCambio = (_tipoCambio.Count > 0)
			_alreadyFetchedCotizacionServicio = (_cotizacionServicio.Count > 0)
			_alreadyFetchedOrdenServicio = (_ordenServicio.Count > 0)
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = (_productoCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = (_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaOrdenCompra = (_proveedorCollectionViaOrdenCompra.Count > 0)
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = (_productoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = (_cotizacionCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = (_ordenCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = (_solicitudProductoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedBancosCollectionViaCuenta = (_bancosCollectionViaCuenta.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaCuenta = (_cuentaContableCollectionViaCuenta.Count > 0)
			_alreadyFetchedProveedorCollectionViaCotizacionServicio = (_proveedorCollectionViaCotizacionServicio.Count > 0)
			_alreadyFetchedProveedorCollectionViaOrdenServicio = (_proveedorCollectionViaOrdenServicio.Count > 0)


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
			info.AddValue("_mcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_ordenCompra", _ordenCompra)
			info.AddValue("_alwaysFetchOrdenCompra", _alwaysFetchOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompra", _alreadyFetchedOrdenCompra)
			info.AddValue("_ordenCompraDetalle", _ordenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraDetalle", _alwaysFetchOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraDetalle", _alreadyFetchedOrdenCompraDetalle)
			info.AddValue("_cuenta", _cuenta)
			info.AddValue("_alwaysFetchCuenta", _alwaysFetchCuenta)
			info.AddValue("_alreadyFetchedCuenta", _alreadyFetchedCuenta)
			info.AddValue("_tipoCambio", _tipoCambio)
			info.AddValue("_alwaysFetchTipoCambio", _alwaysFetchTipoCambio)
			info.AddValue("_alreadyFetchedTipoCambio", _alreadyFetchedTipoCambio)
			info.AddValue("_cotizacionServicio", _cotizacionServicio)
			info.AddValue("_alwaysFetchCotizacionServicio", _alwaysFetchCotizacionServicio)
			info.AddValue("_alreadyFetchedCotizacionServicio", _alreadyFetchedCotizacionServicio)
			info.AddValue("_ordenServicio", _ordenServicio)
			info.AddValue("_alwaysFetchOrdenServicio", _alwaysFetchOrdenServicio)
			info.AddValue("_alreadyFetchedOrdenServicio", _alreadyFetchedOrdenServicio)
			info.AddValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", _productoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedorCollectionViaOrdenCompra", _proveedorCollectionViaOrdenCompra)
			info.AddValue("_alwaysFetchProveedorCollectionViaOrdenCompra", _alwaysFetchProveedorCollectionViaOrdenCompra)
			info.AddValue("_alreadyFetchedProveedorCollectionViaOrdenCompra", _alreadyFetchedProveedorCollectionViaOrdenCompra)
			info.AddValue("_productoCollectionViaOrdenCompraDetalle", _productoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaOrdenCompraDetalle", _alwaysFetchProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", _cotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle", _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_ordenCompraCollectionViaOrdenCompraDetalle", _ordenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle", _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_solicitudProductoCollectionViaOrdenCompraDetalle", _solicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle", _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_bancosCollectionViaCuenta", _bancosCollectionViaCuenta)
			info.AddValue("_alwaysFetchBancosCollectionViaCuenta", _alwaysFetchBancosCollectionViaCuenta)
			info.AddValue("_alreadyFetchedBancosCollectionViaCuenta", _alreadyFetchedBancosCollectionViaCuenta)
			info.AddValue("_cuentaContableCollectionViaCuenta", _cuentaContableCollectionViaCuenta)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaCuenta", _alwaysFetchCuentaContableCollectionViaCuenta)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaCuenta", _alreadyFetchedCuentaContableCollectionViaCuenta)
			info.AddValue("_proveedorCollectionViaCotizacionServicio", _proveedorCollectionViaCotizacionServicio)
			info.AddValue("_alwaysFetchProveedorCollectionViaCotizacionServicio", _alwaysFetchProveedorCollectionViaCotizacionServicio)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCotizacionServicio", _alreadyFetchedProveedorCollectionViaCotizacionServicio)
			info.AddValue("_proveedorCollectionViaOrdenServicio", _proveedorCollectionViaOrdenServicio)
			info.AddValue("_alwaysFetchProveedorCollectionViaOrdenServicio", _alwaysFetchProveedorCollectionViaOrdenServicio)
			info.AddValue("_alreadyFetchedProveedorCollectionViaOrdenServicio", _alreadyFetchedProveedorCollectionViaOrdenServicio)


			
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

				Case "McomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorDetalleEntity))
					End If
				Case "OrdenCompra"
					_alreadyFetchedOrdenCompra = True
					If Not entity Is Nothing Then
						Me.OrdenCompra.Add(CType(entity, OrdenCompraEntity))
					End If
				Case "OrdenCompraDetalle"
					_alreadyFetchedOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.OrdenCompraDetalle.Add(CType(entity, OrdenCompraDetalleEntity))
					End If
				Case "Cuenta"
					_alreadyFetchedCuenta = True
					If Not entity Is Nothing Then
						Me.Cuenta.Add(CType(entity, CuentaEntity))
					End If
				Case "TipoCambio"
					_alreadyFetchedTipoCambio = True
					If Not entity Is Nothing Then
						Me.TipoCambio.Add(CType(entity, TipoCambioEntity))
					End If
				Case "CotizacionServicio"
					_alreadyFetchedCotizacionServicio = True
					If Not entity Is Nothing Then
						Me.CotizacionServicio.Add(CType(entity, CotizacionServicioEntity))
					End If
				Case "OrdenServicio"
					_alreadyFetchedOrdenServicio = True
					If Not entity Is Nothing Then
						Me.OrdenServicio.Add(CType(entity, OrdenServicioEntity))
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
				Case "McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraEntity))
					End If
				Case "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorEntity))
					End If
				Case "ProveedorCollectionViaOrdenCompra"
					_alreadyFetchedProveedorCollectionViaOrdenCompra = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaOrdenCompra.Add(CType(entity, ProveedorEntity))
					End If
				Case "ProductoCollectionViaOrdenCompraDetalle"
					_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaOrdenCompraDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "CotizacionCompraCollectionViaOrdenCompraDetalle"
					_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionCompraCollectionViaOrdenCompraDetalle.Add(CType(entity, McomCotizacionCompraEntity))
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
				Case "BancosCollectionViaCuenta"
					_alreadyFetchedBancosCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.BancosCollectionViaCuenta.Add(CType(entity, BancosEntity))
					End If
				Case "CuentaContableCollectionViaCuenta"
					_alreadyFetchedCuentaContableCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaCuenta.Add(CType(entity, CuentaContableEntity))
					End If
				Case "ProveedorCollectionViaCotizacionServicio"
					_alreadyFetchedProveedorCollectionViaCotizacionServicio = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCotizacionServicio.Add(CType(entity, ProveedorEntity))
					End If
				Case "ProveedorCollectionViaOrdenServicio"
					_alreadyFetchedProveedorCollectionViaOrdenServicio = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaOrdenServicio.Add(CType(entity, ProveedorEntity))
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

				Case "McomCotizacionCompraProveedorDetalle"
					_mcomCotizacionCompraProveedorDetalle.Add(CType(relatedEntity, McomCotizacionCompraProveedorDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompra"
					_ordenCompra.Add(CType(relatedEntity, OrdenCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					_ordenCompraDetalle.Add(CType(relatedEntity, OrdenCompraDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cuenta"
					_cuenta.Add(CType(relatedEntity, CuentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoCambio"
					_tipoCambio.Add(CType(relatedEntity, TipoCambioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionServicio"
					_cotizacionServicio.Add(CType(relatedEntity, CotizacionServicioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenServicio"
					_ordenServicio.Add(CType(relatedEntity, OrdenServicioEntity))
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

				Case "McomCotizacionCompraProveedorDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedorDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_ordenCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					MyBase.PerformRelatedEntityRemoval(_ordenCompraDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cuenta"
					MyBase.PerformRelatedEntityRemoval(_cuenta, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoCambio"
					MyBase.PerformRelatedEntityRemoval(_tipoCambio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionServicio"
					MyBase.PerformRelatedEntityRemoval(_cotizacionServicio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenServicio"
					MyBase.PerformRelatedEntityRemoval(_ordenServicio, relatedEntity, signalRelatedEntityManyToOne)
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



			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mcomCotizacionCompraProveedorDetalle)
			toReturn.Add(_ordenCompra)
			toReturn.Add(_ordenCompraDetalle)
			toReturn.Add(_cuenta)
			toReturn.Add(_tipoCambio)
			toReturn.Add(_cotizacionServicio)
			toReturn.Add(_ordenServicio)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As TipoMonedaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As TipoMonedaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_mcomCotizacionCompraProveedorDetalle.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, _ordenCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, _ordenCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			If ( Not _alreadyFetchedOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompra)
					End If
				End If
				_ordenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompra.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_ordenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompra = True
			End If
			Return _ordenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompra'. These settings will be taken into account
		''' when the property OrdenCompra is requested or GetMultiOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompra.SortClauses=sortClauses
			_ordenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_ordenCompraDetalle.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuenta Or forceFetch Or _alwaysFetchCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuenta)
					End If
				End If
				_cuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuenta.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_cuenta.SuppressClearInGetMulti = False
				_alreadyFetchedCuenta = True
			End If
			Return _cuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cuenta'. These settings will be taken into account
		''' when the property Cuenta is requested or GetMultiCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuenta.SortClauses=sortClauses
			_cuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'TipoCambioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoCambioEntity'</returns>
		Public Function GetMultiTipoCambio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoCambioCollection
			Return GetMultiTipoCambio(forceFetch, _tipoCambio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoCambioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiTipoCambio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoCambioCollection
			Return GetMultiTipoCambio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoCambioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'TipoCambioEntity'</returns>
		Public Function GetMultiTipoCambio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.TipoCambioCollection
			Return GetMultiTipoCambio(forceFetch, _tipoCambio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoCambioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoCambio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.TipoCambioCollection
			If ( Not _alreadyFetchedTipoCambio Or forceFetch Or _alwaysFetchTipoCambio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoCambio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoCambio)
					End If
				End If
				_tipoCambio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoCambio.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoCambio.GetMultiManyToOne(Me, Filter)
				_tipoCambio.SuppressClearInGetMulti = False
				_alreadyFetchedTipoCambio = True
			End If
			Return _tipoCambio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoCambio'. These settings will be taken into account
		''' when the property TipoCambio is requested or GetMultiTipoCambio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoCambio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoCambio.SortClauses=sortClauses
			_tipoCambio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioEntity'</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, _cotizacionServicio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioEntity'</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, _cotizacionServicio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			If ( Not _alreadyFetchedCotizacionServicio Or forceFetch Or _alwaysFetchCotizacionServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionServicio)
					End If
				End If
				_cotizacionServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionServicio.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cotizacionServicio.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionServicio = True
			End If
			Return _cotizacionServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionServicio'. These settings will be taken into account
		''' when the property CotizacionServicio is requested or GetMultiCotizacionServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionServicio.SortClauses=sortClauses
			_cotizacionServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioEntity'</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, _ordenServicio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioEntity'</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, _ordenServicio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			If ( Not _alreadyFetchedOrdenServicio Or forceFetch Or _alwaysFetchOrdenServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenServicio)
					End If
				End If
				_ordenServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenServicio.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_ordenServicio.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenServicio = True
			End If
			Return _ordenServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenServicio'. These settings will be taken into account
		''' when the property OrdenServicio is requested or GetMultiOrdenServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenServicio.SortClauses=sortClauses
			_ordenServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaOrdenCompra(forceFetch, _proveedorCollectionViaOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaOrdenCompra Or forceFetch Or _alwaysFetchProveedorCollectionViaOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraEntityUsingIdMoneda, "__TipoMonedaEntity__", "OrdenCompra_", JoinHint.None)
				relations.Add(OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor, "OrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaOrdenCompra.GetMulti(Filter, relations)
				_proveedorCollectionViaOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaOrdenCompra = True
			End If
			Return _proveedorCollectionViaOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaOrdenCompra'. These settings will be taken into account
		''' when the property ProveedorCollectionViaOrdenCompra is requested or GetMultiProveedorCollectionViaOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaOrdenCompra.SortClauses=sortClauses
			_proveedorCollectionViaOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BancosEntity'</returns>
		Public Function GetMultiBancosCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BancosCollection
			Return GetMultiBancosCollectionViaCuenta(forceFetch, _bancosCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBancosCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BancosCollection
			If ( Not _alreadyFetchedBancosCollectionViaCuenta Or forceFetch Or _alwaysFetchBancosCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _bancosCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_bancosCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, "__TipoMonedaEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_bancosCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_bancosCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_bancosCollectionViaCuenta.GetMulti(Filter, relations)
				_bancosCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedBancosCollectionViaCuenta = True
			End If
			Return _bancosCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BancosCollectionViaCuenta'. These settings will be taken into account
		''' when the property BancosCollectionViaCuenta is requested or GetMultiBancosCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBancosCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_bancosCollectionViaCuenta.SortClauses=sortClauses
			_bancosCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaCuenta(forceFetch, _cuentaContableCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaCuenta Or forceFetch Or _alwaysFetchCuentaContableCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, "__TipoMonedaEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaCuenta.GetMulti(Filter, relations)
				_cuentaContableCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaCuenta = True
			End If
			Return _cuentaContableCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaCuenta'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaCuenta is requested or GetMultiCuentaContableCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaCuenta.SortClauses=sortClauses
			_cuentaContableCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCotizacionServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCotizacionServicio(forceFetch, _proveedorCollectionViaCotizacionServicio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCotizacionServicio Or forceFetch Or _alwaysFetchProveedorCollectionViaCotizacionServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCotizacionServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCotizacionServicio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.CotizacionServicioEntityUsingTipoMonedaId, "__TipoMonedaEntity__", "CotizacionServicio_", JoinHint.None)
				relations.Add(CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId, "CotizacionServicio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaCotizacionServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCotizacionServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCotizacionServicio.GetMulti(Filter, relations)
				_proveedorCollectionViaCotizacionServicio.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCotizacionServicio = True
			End If
			Return _proveedorCollectionViaCotizacionServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCotizacionServicio'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCotizacionServicio is requested or GetMultiProveedorCollectionViaCotizacionServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCotizacionServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCotizacionServicio.SortClauses=sortClauses
			_proveedorCollectionViaCotizacionServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaOrdenServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaOrdenServicio(forceFetch, _proveedorCollectionViaOrdenServicio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaOrdenServicio Or forceFetch Or _alwaysFetchProveedorCollectionViaOrdenServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaOrdenServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaOrdenServicio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMonedaEntity.Relations.OrdenServicioEntityUsingMonedaId, "__TipoMonedaEntity__", "OrdenServicio_", JoinHint.None)
				relations.Add(OrdenServicioEntity.Relations.ProveedorEntityUsingProveedorId, "OrdenServicio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMonedaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaOrdenServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaOrdenServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaOrdenServicio.GetMulti(Filter, relations)
				_proveedorCollectionViaOrdenServicio.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaOrdenServicio = True
			End If
			Return _proveedorCollectionViaOrdenServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaOrdenServicio'. These settings will be taken into account
		''' when the property ProveedorCollectionViaOrdenServicio is requested or GetMultiProveedorCollectionViaOrdenServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaOrdenServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaOrdenServicio.SortClauses=sortClauses
			_proveedorCollectionViaOrdenServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(TipoMonedaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, TipoMonedaFieldIndex)












					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompra.ActiveContext = MyBase.ActiveContext
			_ordenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_cuenta.ActiveContext = MyBase.ActiveContext
			_tipoCambio.ActiveContext = MyBase.ActiveContext
			_cotizacionServicio.ActiveContext = MyBase.ActiveContext
			_ordenServicio.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaOrdenCompra.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_bancosCollectionViaCuenta.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaCuenta.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCotizacionServicio.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaOrdenServicio.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As TipoMonedaDAO = CType(CreateDAOInstance(), TipoMonedaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As TipoMonedaDAO = CType(CreateDAOInstance(), TipoMonedaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As TipoMonedaDAO = CType(CreateDAOInstance(), TipoMonedaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this TipoMonedaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.TipoMonedaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <param name="validator">The validator Object for this TipoMonedaEntity</param>
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
			_mcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(New McomCotizacionCompraProveedorDetalleEntityFactory())
			_mcomCotizacionCompraProveedorDetalle.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = False
			_ordenCompra = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_ordenCompra.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchOrdenCompra = False
			_alreadyFetchedOrdenCompra = False
			_ordenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(New OrdenCompraDetalleEntityFactory())
			_ordenCompraDetalle.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraDetalle = False
			_cuenta = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_cuenta.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchCuenta = False
			_alreadyFetchedCuenta = False
			_tipoCambio = New Integralab.ORM.CollectionClasses.TipoCambioCollection(New TipoCambioEntityFactory())
			_tipoCambio.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchTipoCambio = False
			_alreadyFetchedTipoCambio = False
			_cotizacionServicio = New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(New CotizacionServicioEntityFactory())
			_cotizacionServicio.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchCotizacionServicio = False
			_alreadyFetchedCotizacionServicio = False
			_ordenServicio = New Integralab.ORM.CollectionClasses.OrdenServicioCollection(New OrdenServicioEntityFactory())
			_ordenServicio.SetContainingEntityInfo(Me, "TipoMoneda")
			_alwaysFetchOrdenServicio = False
			_alreadyFetchedOrdenServicio = False
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_mcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedorCollectionViaOrdenCompra = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaOrdenCompra = False
			_alreadyFetchedProveedorCollectionViaOrdenCompra = False
			_productoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = False
			_cotizacionCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_ordenCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = False
			_solicitudProductoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_bancosCollectionViaCuenta = New Integralab.ORM.CollectionClasses.BancosCollection(New BancosEntityFactory())
			_alwaysFetchBancosCollectionViaCuenta = False
			_alreadyFetchedBancosCollectionViaCuenta = False
			_cuentaContableCollectionViaCuenta = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaCuenta = False
			_alreadyFetchedCuentaContableCollectionViaCuenta = False
			_proveedorCollectionViaCotizacionServicio = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCotizacionServicio = False
			_alreadyFetchedProveedorCollectionViaCotizacionServicio = False
			_proveedorCollectionViaOrdenServicio = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaOrdenServicio = False
			_alreadyFetchedProveedorCollectionViaOrdenServicio = False


			
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

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MonedaLocal", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for TipoMoneda which data should be fetched into this TipoMoneda Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(TipoMonedaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateTipoMonedaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New TipoMonedaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As TipoMonedaRelations
			Get	
				Return New TipoMonedaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedorDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "Cuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoCambio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoCambio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoCambioCollection(), _
					TipoMonedaEntity.Relations.TipoCambioEntityUsingTipomonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.TipoCambioEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoCambio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(), _
					TipoMonedaEntity.Relations.CotizacionServicioEntityUsingTipoMonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenServicioCollection(), _
					TipoMonedaEntity.Relations.OrdenServicioEntityUsingMonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.OrdenServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					TipoMonedaEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, relations, "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, relations, "OrdenCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					TipoMonedaEntity.Relations.OrdenCompraDetalleEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBancosCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, relations, "BancosCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.CuentaContableEntityUsingCuentacontableId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					TipoMonedaEntity.Relations.CuentaEntityUsingTipomonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCotizacionServicio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.CotizacionServicioEntityUsingTipoMonedaId, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					TipoMonedaEntity.Relations.CotizacionServicioEntityUsingTipoMonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCotizacionServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaOrdenServicio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMonedaEntity.Relations.OrdenServicioEntityUsingMonedaId, "__TipoMonedaEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenServicioEntity.Relations.ProveedorEntityUsingProveedorId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					TipoMonedaEntity.Relations.OrdenServicioEntityUsingMonedaId, _
					CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaOrdenServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "TipoMonedaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return TipoMonedaEntity.CustomProperties
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
				Return TipoMonedaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMIdTipoMoneda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMDescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMIdCodUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMIdCodUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MonedaLocal property of the Entity TipoMoneda<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenTiposMoneda"."TMMonedaLocal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MonedaLocal]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMonedaFieldIndex.MonedaLocal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoMonedaFieldIndex.MonedaLocal, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompra]() As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Get
				Return GetMultiOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompra. When set to true, OrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompra = value
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
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cuenta]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cuenta. When set to true, Cuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuenta As Boolean
			Get
				Return _alwaysFetchCuenta
			End Get
			Set
				_alwaysFetchCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoCambioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoCambio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoCambio]() As Integralab.ORM.CollectionClasses.TipoCambioCollection
			Get
				Return GetMultiTipoCambio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoCambio. When set to true, TipoCambio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoCambio is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoCambio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoCambio As Boolean
			Get
				Return _alwaysFetchTipoCambio
			End Get
			Set
				_alwaysFetchTipoCambio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionServicio]() As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Get
				Return GetMultiCotizacionServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionServicio. When set to true, CotizacionServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionServicio As Boolean
			Get
				Return _alwaysFetchCotizacionServicio
			End Get
			Set
				_alwaysFetchCotizacionServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenServicio]() As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Get
				Return GetMultiOrdenServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenServicio. When set to true, OrdenServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenServicio As Boolean
			Get
				Return _alwaysFetchOrdenServicio
			End Get
			Set
				_alwaysFetchOrdenServicio = value
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
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = value
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaOrdenCompra]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaOrdenCompra. When set to true, ProveedorCollectionViaOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaOrdenCompra As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaOrdenCompra
			End Get
			Set
				_alwaysFetchProveedorCollectionViaOrdenCompra = value
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
	
		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBancosCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BancosCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.BancosCollection
			Get
				Return GetMultiBancosCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BancosCollectionViaCuenta. When set to true, BancosCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BancosCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiBancosCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBancosCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchBancosCollectionViaCuenta
			End Get
			Set
				_alwaysFetchBancosCollectionViaCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaCuenta. When set to true, CuentaContableCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaCuenta
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCotizacionServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCotizacionServicio]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCotizacionServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCotizacionServicio. When set to true, ProveedorCollectionViaCotizacionServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCotizacionServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCotizacionServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCotizacionServicio As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCotizacionServicio
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCotizacionServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaOrdenServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaOrdenServicio]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaOrdenServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaOrdenServicio. When set to true, ProveedorCollectionViaOrdenServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaOrdenServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaOrdenServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaOrdenServicio As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaOrdenServicio
			End Get
			Set
				_alwaysFetchProveedorCollectionViaOrdenServicio = value
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
				Return CInt(Integralab.ORM.EntityType.TipoMonedaEntity)
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
