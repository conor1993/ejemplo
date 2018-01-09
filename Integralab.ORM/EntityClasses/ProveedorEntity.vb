' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:19
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
	''' <summary>Entity class which represents the entity 'Proveedor'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ProveedorEntity 
#Else
	<Serializable()> _
	Public Class ProveedorEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom As Boolean
		Private _costoProductoProveedor As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
		Private _alwaysFetchCostoProductoProveedor, _alreadyFetchedCostoProductoProveedor As Boolean
		Private _costoProducto As Integralab.ORM.CollectionClasses.CostoProductoCollection
		Private _alwaysFetchCostoProducto, _alreadyFetchedCostoProducto As Boolean
		Private _costoProducto_ As Integralab.ORM.CollectionClasses.CostoProductoCollection
		Private _alwaysFetchCostoProducto_, _alreadyFetchedCostoProducto_ As Boolean
		Private _mcomCotizacionCompraProveedor As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedor, _alreadyFetchedMcomCotizacionCompraProveedor As Boolean
		Private _mcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorDetalle As Boolean
		Private _ordenCompra As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompra, _alreadyFetchedOrdenCompra As Boolean
		Private _beneficiario_ As Integralab.ORM.CollectionClasses.BeneficiarioCollection
		Private _alwaysFetchBeneficiario_, _alreadyFetchedBeneficiario_ As Boolean
		Private _cotizacionServicio As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
		Private _alwaysFetchCotizacionServicio, _alreadyFetchedCotizacionServicio As Boolean
		Private _ordenServicio As Integralab.ORM.CollectionClasses.OrdenServicioCollection
		Private _alwaysFetchOrdenServicio, _alreadyFetchedOrdenServicio As Boolean
		Private _usrCxpfacturasApagar As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
		Private _alwaysFetchUsrCxpfacturasApagar, _alreadyFetchedUsrCxpfacturasApagar As Boolean
		Private _usrCxpfacturasCab As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
		Private _alwaysFetchUsrCxpfacturasCab, _alreadyFetchedUsrCxpfacturasCab As Boolean
		Private _usrCxppagosProveedores As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
		Private _alwaysFetchUsrCxppagosProveedores, _alreadyFetchedUsrCxppagosProveedores As Boolean
		Private _cabMovGanCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom, _alreadyFetchedCabMovGanCollectionViaCabRegCom As Boolean
		Private _cabMovGanCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom_, _alreadyFetchedCabMovGanCollectionViaCabRegCom_ As Boolean
		Private _catLugaresDeCompraCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom, _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom As Boolean
		Private _mcecatCorralesCabCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom, _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom As Boolean
		Private _mcgcatCompradoresdeGanadoCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom, _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
		Private _productoCollectionViaCostoProductoProveedor As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCostoProductoProveedor, _alreadyFetchedProductoCollectionViaCostoProductoProveedor As Boolean
		Private _cotizacionCompraCollectionViaMcomCotizacionCompraProveedor As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor, _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor As Boolean
		Private _productoCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaOrdenCompra As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaOrdenCompra, _alreadyFetchedTipoMonedaCollectionViaOrdenCompra As Boolean
		Private _tipoMonedaCollectionViaCotizacionServicio As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaCotizacionServicio, _alreadyFetchedTipoMonedaCollectionViaCotizacionServicio As Boolean
		Private _tipoMonedaCollectionViaOrdenServicio As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaOrdenServicio, _alreadyFetchedTipoMonedaCollectionViaOrdenServicio As Boolean
		Private _cuentaCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores, _alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores As Boolean
		Private _polizaCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores, _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores As Boolean
		Private _catLugaresDeCompra As CatLugaresDeCompraEntity
		Private _alwaysFetchCatLugaresDeCompra, _alreadyFetchedCatLugaresDeCompra, _catLugaresDeCompraReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean
		Private _cuentaContable_ As CuentaContableEntity
		Private _alwaysFetchCuentaContable_, _alreadyFetchedCuentaContable_, _cuentaContable_ReturnsNewIfNotFound As Boolean
		Private _proveedorAvanzado As ProveedorAvanzadoEntity
		Private _alwaysFetchProveedorAvanzado, _alreadyFetchedProveedorAvanzado, _proveedorAvanzadoReturnsNewIfNotFound As Boolean

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
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <param name="validator">The custom validator Object for this ProveedorEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_costoProductoProveedor = CType(info.GetValue("_costoProductoProveedor", GetType(Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection)), Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection)
			_alwaysFetchCostoProductoProveedor = info.GetBoolean("_alwaysFetchCostoProductoProveedor")
			_alreadyFetchedCostoProductoProveedor = info.GetBoolean("_alreadyFetchedCostoProductoProveedor")
			_costoProducto = CType(info.GetValue("_costoProducto", GetType(Integralab.ORM.CollectionClasses.CostoProductoCollection)), Integralab.ORM.CollectionClasses.CostoProductoCollection)
			_alwaysFetchCostoProducto = info.GetBoolean("_alwaysFetchCostoProducto")
			_alreadyFetchedCostoProducto = info.GetBoolean("_alreadyFetchedCostoProducto")
			_costoProducto_ = CType(info.GetValue("_costoProducto_", GetType(Integralab.ORM.CollectionClasses.CostoProductoCollection)), Integralab.ORM.CollectionClasses.CostoProductoCollection)
			_alwaysFetchCostoProducto_ = info.GetBoolean("_alwaysFetchCostoProducto_")
			_alreadyFetchedCostoProducto_ = info.GetBoolean("_alreadyFetchedCostoProducto_")
			_mcomCotizacionCompraProveedor = CType(info.GetValue("_mcomCotizacionCompraProveedor", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedor = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedor")
			_alreadyFetchedMcomCotizacionCompraProveedor = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedor")
			_mcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorDetalle")
			_ordenCompra = CType(info.GetValue("_ordenCompra", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompra")
			_alreadyFetchedOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompra")
			_beneficiario_ = CType(info.GetValue("_beneficiario_", GetType(Integralab.ORM.CollectionClasses.BeneficiarioCollection)), Integralab.ORM.CollectionClasses.BeneficiarioCollection)
			_alwaysFetchBeneficiario_ = info.GetBoolean("_alwaysFetchBeneficiario_")
			_alreadyFetchedBeneficiario_ = info.GetBoolean("_alreadyFetchedBeneficiario_")
			_cotizacionServicio = CType(info.GetValue("_cotizacionServicio", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioCollection)
			_alwaysFetchCotizacionServicio = info.GetBoolean("_alwaysFetchCotizacionServicio")
			_alreadyFetchedCotizacionServicio = info.GetBoolean("_alreadyFetchedCotizacionServicio")
			_ordenServicio = CType(info.GetValue("_ordenServicio", GetType(Integralab.ORM.CollectionClasses.OrdenServicioCollection)), Integralab.ORM.CollectionClasses.OrdenServicioCollection)
			_alwaysFetchOrdenServicio = info.GetBoolean("_alwaysFetchOrdenServicio")
			_alreadyFetchedOrdenServicio = info.GetBoolean("_alreadyFetchedOrdenServicio")
			_usrCxpfacturasApagar = CType(info.GetValue("_usrCxpfacturasApagar", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection)
			_alwaysFetchUsrCxpfacturasApagar = info.GetBoolean("_alwaysFetchUsrCxpfacturasApagar")
			_alreadyFetchedUsrCxpfacturasApagar = info.GetBoolean("_alreadyFetchedUsrCxpfacturasApagar")
			_usrCxpfacturasCab = CType(info.GetValue("_usrCxpfacturasCab", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection)
			_alwaysFetchUsrCxpfacturasCab = info.GetBoolean("_alwaysFetchUsrCxpfacturasCab")
			_alreadyFetchedUsrCxpfacturasCab = info.GetBoolean("_alreadyFetchedUsrCxpfacturasCab")
			_usrCxppagosProveedores = CType(info.GetValue("_usrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)), Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)
			_alwaysFetchUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchUsrCxppagosProveedores")
			_alreadyFetchedUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedUsrCxppagosProveedores")
			_cabMovGanCollectionViaCabRegCom = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom")
			_cabMovGanCollectionViaCabRegCom_ = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom_")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom_")
			_catLugaresDeCompraCollectionViaCabRegCom = CType(info.GetValue("_catLugaresDeCompraCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom")
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom")
			_mcecatCorralesCabCollectionViaCabRegCom = CType(info.GetValue("_mcecatCorralesCabCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom")
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom")
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = CType(info.GetValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_productoCollectionViaCostoProductoProveedor = CType(info.GetValue("_productoCollectionViaCostoProductoProveedor", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCostoProductoProveedor = info.GetBoolean("_alwaysFetchProductoCollectionViaCostoProductoProveedor")
			_alreadyFetchedProductoCollectionViaCostoProductoProveedor = info.GetBoolean("_alreadyFetchedProductoCollectionViaCostoProductoProveedor")
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor = CType(info.GetValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor")
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor")
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaOrdenCompra = CType(info.GetValue("_tipoMonedaCollectionViaOrdenCompra", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaOrdenCompra = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaOrdenCompra")
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompra = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaOrdenCompra")
			_tipoMonedaCollectionViaCotizacionServicio = CType(info.GetValue("_tipoMonedaCollectionViaCotizacionServicio", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaCotizacionServicio = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaCotizacionServicio")
			_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio")
			_tipoMonedaCollectionViaOrdenServicio = CType(info.GetValue("_tipoMonedaCollectionViaOrdenServicio", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaOrdenServicio = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaOrdenServicio")
			_alreadyFetchedTipoMonedaCollectionViaOrdenServicio = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaOrdenServicio")
			_cuentaCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_cuentaCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores")
			_polizaCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_polizaCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores")
			_catLugaresDeCompra = CType(info.GetValue("_catLugaresDeCompra", GetType(CatLugaresDeCompraEntity)), CatLugaresDeCompraEntity)
			If Not _catLugaresDeCompra Is Nothing Then
				AddHandler _catLugaresDeCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catLugaresDeCompraReturnsNewIfNotFound = info.GetBoolean("_catLugaresDeCompraReturnsNewIfNotFound")
			_alwaysFetchCatLugaresDeCompra = info.GetBoolean("_alwaysFetchCatLugaresDeCompra")
			_alreadyFetchedCatLugaresDeCompra = info.GetBoolean("_alreadyFetchedCatLugaresDeCompra")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_cuentaContable_ = CType(info.GetValue("_cuentaContable_", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable_ Is Nothing Then
				AddHandler _cuentaContable_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContable_ReturnsNewIfNotFound = info.GetBoolean("_cuentaContable_ReturnsNewIfNotFound")
			_alwaysFetchCuentaContable_ = info.GetBoolean("_alwaysFetchCuentaContable_")
			_alreadyFetchedCuentaContable_ = info.GetBoolean("_alreadyFetchedCuentaContable_")
			_proveedorAvanzado = CType(info.GetValue("_proveedorAvanzado", GetType(ProveedorAvanzadoEntity)), ProveedorAvanzadoEntity)
			If Not _proveedorAvanzado Is Nothing Then
				' rewire event handler.
				AddHandler _proveedorAvanzado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorAvanzadoReturnsNewIfNotFound = info.GetBoolean("_proveedorAvanzadoReturnsNewIfNotFound")
			_alwaysFetchProveedorAvanzado = info.GetBoolean("_alwaysFetchProveedorAvanzado")
			_alreadyFetchedProveedorAvanzado = info.GetBoolean("_alreadyFetchedProveedorAvanzado")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabRegCom = (_cabRegCom.Count > 0)
			_alreadyFetchedCostoProductoProveedor = (_costoProductoProveedor.Count > 0)
			_alreadyFetchedCostoProducto = (_costoProducto.Count > 0)
			_alreadyFetchedCostoProducto_ = (_costoProducto_.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedor = (_mcomCotizacionCompraProveedor.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedOrdenCompra = (_ordenCompra.Count > 0)
			_alreadyFetchedBeneficiario_ = (_beneficiario_.Count > 0)
			_alreadyFetchedCotizacionServicio = (_cotizacionServicio.Count > 0)
			_alreadyFetchedOrdenServicio = (_ordenServicio.Count > 0)
			_alreadyFetchedUsrCxpfacturasApagar = (_usrCxpfacturasApagar.Count > 0)
			_alreadyFetchedUsrCxpfacturasCab = (_usrCxpfacturasCab.Count > 0)
			_alreadyFetchedUsrCxppagosProveedores = (_usrCxppagosProveedores.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = (_cabMovGanCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = (_cabMovGanCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = (_catLugaresDeCompraCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = (_mcecatCorralesCabCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = (_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedProductoCollectionViaCostoProductoProveedor = (_productoCollectionViaCostoProductoProveedor.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = (_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.Count > 0)
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = (_productoCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = (_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = (_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = (_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompra = (_tipoMonedaCollectionViaOrdenCompra.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio = (_tipoMonedaCollectionViaCotizacionServicio.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaOrdenServicio = (_tipoMonedaCollectionViaOrdenServicio.Count > 0)
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = (_cuentaCollectionViaUsrCxppagosProveedores.Count > 0)
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = (_polizaCollectionViaUsrCxppagosProveedores.Count > 0)
			_alreadyFetchedCatLugaresDeCompra = Not(_catLugaresDeCompra Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)
			_alreadyFetchedCuentaContable_ = Not(_cuentaContable_ Is Nothing)
			_alreadyFetchedProveedorAvanzado = Not(_proveedorAvanzado Is Nothing)
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
			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_costoProductoProveedor", _costoProductoProveedor)
			info.AddValue("_alwaysFetchCostoProductoProveedor", _alwaysFetchCostoProductoProveedor)
			info.AddValue("_alreadyFetchedCostoProductoProveedor", _alreadyFetchedCostoProductoProveedor)
			info.AddValue("_costoProducto", _costoProducto)
			info.AddValue("_alwaysFetchCostoProducto", _alwaysFetchCostoProducto)
			info.AddValue("_alreadyFetchedCostoProducto", _alreadyFetchedCostoProducto)
			info.AddValue("_costoProducto_", _costoProducto_)
			info.AddValue("_alwaysFetchCostoProducto_", _alwaysFetchCostoProducto_)
			info.AddValue("_alreadyFetchedCostoProducto_", _alreadyFetchedCostoProducto_)
			info.AddValue("_mcomCotizacionCompraProveedor", _mcomCotizacionCompraProveedor)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedor", _alwaysFetchMcomCotizacionCompraProveedor)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedor", _alreadyFetchedMcomCotizacionCompraProveedor)
			info.AddValue("_mcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_ordenCompra", _ordenCompra)
			info.AddValue("_alwaysFetchOrdenCompra", _alwaysFetchOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompra", _alreadyFetchedOrdenCompra)
			info.AddValue("_beneficiario_", _beneficiario_)
			info.AddValue("_alwaysFetchBeneficiario_", _alwaysFetchBeneficiario_)
			info.AddValue("_alreadyFetchedBeneficiario_", _alreadyFetchedBeneficiario_)
			info.AddValue("_cotizacionServicio", _cotizacionServicio)
			info.AddValue("_alwaysFetchCotizacionServicio", _alwaysFetchCotizacionServicio)
			info.AddValue("_alreadyFetchedCotizacionServicio", _alreadyFetchedCotizacionServicio)
			info.AddValue("_ordenServicio", _ordenServicio)
			info.AddValue("_alwaysFetchOrdenServicio", _alwaysFetchOrdenServicio)
			info.AddValue("_alreadyFetchedOrdenServicio", _alreadyFetchedOrdenServicio)
			info.AddValue("_usrCxpfacturasApagar", _usrCxpfacturasApagar)
			info.AddValue("_alwaysFetchUsrCxpfacturasApagar", _alwaysFetchUsrCxpfacturasApagar)
			info.AddValue("_alreadyFetchedUsrCxpfacturasApagar", _alreadyFetchedUsrCxpfacturasApagar)
			info.AddValue("_usrCxpfacturasCab", _usrCxpfacturasCab)
			info.AddValue("_alwaysFetchUsrCxpfacturasCab", _alwaysFetchUsrCxpfacturasCab)
			info.AddValue("_alreadyFetchedUsrCxpfacturasCab", _alreadyFetchedUsrCxpfacturasCab)
			info.AddValue("_usrCxppagosProveedores", _usrCxppagosProveedores)
			info.AddValue("_alwaysFetchUsrCxppagosProveedores", _alwaysFetchUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedUsrCxppagosProveedores", _alreadyFetchedUsrCxppagosProveedores)
			info.AddValue("_cabMovGanCollectionViaCabRegCom", _cabMovGanCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom", _alwaysFetchCabMovGanCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom", _alreadyFetchedCabMovGanCollectionViaCabRegCom)
			info.AddValue("_cabMovGanCollectionViaCabRegCom_", _cabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom_", _alwaysFetchCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom_", _alreadyFetchedCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_catLugaresDeCompraCollectionViaCabRegCom", _catLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom", _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom", _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_mcecatCorralesCabCollectionViaCabRegCom", _mcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom", _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom", _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", _mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_productoCollectionViaCostoProductoProveedor", _productoCollectionViaCostoProductoProveedor)
			info.AddValue("_alwaysFetchProductoCollectionViaCostoProductoProveedor", _alwaysFetchProductoCollectionViaCostoProductoProveedor)
			info.AddValue("_alreadyFetchedProductoCollectionViaCostoProductoProveedor", _alreadyFetchedProductoCollectionViaCostoProductoProveedor)
			info.AddValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor", _cotizacionCompraCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor", _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor", _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor)
			info.AddValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", _productoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaOrdenCompra", _tipoMonedaCollectionViaOrdenCompra)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaOrdenCompra", _alwaysFetchTipoMonedaCollectionViaOrdenCompra)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaOrdenCompra", _alreadyFetchedTipoMonedaCollectionViaOrdenCompra)
			info.AddValue("_tipoMonedaCollectionViaCotizacionServicio", _tipoMonedaCollectionViaCotizacionServicio)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaCotizacionServicio", _alwaysFetchTipoMonedaCollectionViaCotizacionServicio)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio", _alreadyFetchedTipoMonedaCollectionViaCotizacionServicio)
			info.AddValue("_tipoMonedaCollectionViaOrdenServicio", _tipoMonedaCollectionViaOrdenServicio)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaOrdenServicio", _alwaysFetchTipoMonedaCollectionViaOrdenServicio)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaOrdenServicio", _alreadyFetchedTipoMonedaCollectionViaOrdenServicio)
			info.AddValue("_cuentaCollectionViaUsrCxppagosProveedores", _cuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores", _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores", _alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_polizaCollectionViaUsrCxppagosProveedores", _polizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores", _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores", _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_catLugaresDeCompra", _catLugaresDeCompra)
			info.AddValue("_catLugaresDeCompraReturnsNewIfNotFound", _catLugaresDeCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatLugaresDeCompra", _alwaysFetchCatLugaresDeCompra)
			info.AddValue("_alreadyFetchedCatLugaresDeCompra", _alreadyFetchedCatLugaresDeCompra)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_cuentaContable_", _cuentaContable_)
			info.AddValue("_cuentaContable_ReturnsNewIfNotFound", _cuentaContable_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable_", _alwaysFetchCuentaContable_)
			info.AddValue("_alreadyFetchedCuentaContable_", _alreadyFetchedCuentaContable_)
			info.AddValue("_proveedorAvanzado", _proveedorAvanzado)
			info.AddValue("_proveedorAvanzadoReturnsNewIfNotFound", _proveedorAvanzadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedorAvanzado", _alwaysFetchProveedorAvanzado)
			info.AddValue("_alreadyFetchedProveedorAvanzado", _alreadyFetchedProveedorAvanzado)
			
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
				Case "CatLugaresDeCompra"
					_alreadyFetchedCatLugaresDeCompra = True
					Me.CatLugaresDeCompra = CType(entity, CatLugaresDeCompraEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "CuentaContable_"
					_alreadyFetchedCuentaContable_ = True
					Me.CuentaContable_ = CType(entity, CuentaContableEntity)
				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "CostoProductoProveedor"
					_alreadyFetchedCostoProductoProveedor = True
					If Not entity Is Nothing Then
						Me.CostoProductoProveedor.Add(CType(entity, CostoProductoProveedorEntity))
					End If
				Case "CostoProducto"
					_alreadyFetchedCostoProducto = True
					If Not entity Is Nothing Then
						Me.CostoProducto.Add(CType(entity, CostoProductoEntity))
					End If
				Case "CostoProducto_"
					_alreadyFetchedCostoProducto_ = True
					If Not entity Is Nothing Then
						Me.CostoProducto_.Add(CType(entity, CostoProductoEntity))
					End If
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
				Case "OrdenCompra"
					_alreadyFetchedOrdenCompra = True
					If Not entity Is Nothing Then
						Me.OrdenCompra.Add(CType(entity, OrdenCompraEntity))
					End If
				Case "Beneficiario_"
					_alreadyFetchedBeneficiario_ = True
					If Not entity Is Nothing Then
						Me.Beneficiario_.Add(CType(entity, BeneficiarioEntity))
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
				Case "UsrCxpfacturasApagar"
					_alreadyFetchedUsrCxpfacturasApagar = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasApagar.Add(CType(entity, UsrCxpfacturasApagarEntity))
					End If
				Case "UsrCxpfacturasCab"
					_alreadyFetchedUsrCxpfacturasCab = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasCab.Add(CType(entity, UsrCxpfacturasCabEntity))
					End If
				Case "UsrCxppagosProveedores"
					_alreadyFetchedUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.UsrCxppagosProveedores.Add(CType(entity, UsrCxppagosProveedoresEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom_"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom_.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaCabRegCom"
					_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaCabRegCom.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "McecatCorralesCabCollectionViaCabRegCom"
					_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaCabRegCom.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McgcatCompradoresdeGanadoCollectionViaCabRegCom"
					_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanadoCollectionViaCabRegCom.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
					End If
				Case "ProductoCollectionViaCostoProductoProveedor"
					_alreadyFetchedProductoCollectionViaCostoProductoProveedor = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCostoProductoProveedor.Add(CType(entity, ProductoEntity))
					End If
				Case "CotizacionCompraCollectionViaMcomCotizacionCompraProveedor"
					_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = True
					If Not entity Is Nothing Then
						Me.CotizacionCompraCollectionViaMcomCotizacionCompraProveedor.Add(CType(entity, McomCotizacionCompraEntity))
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
				Case "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraEntity))
					End If
				Case "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorEntity))
					End If
				Case "TipoMonedaCollectionViaOrdenCompra"
					_alreadyFetchedTipoMonedaCollectionViaOrdenCompra = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaOrdenCompra.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "TipoMonedaCollectionViaCotizacionServicio"
					_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaCotizacionServicio.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "TipoMonedaCollectionViaOrdenServicio"
					_alreadyFetchedTipoMonedaCollectionViaOrdenServicio = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaOrdenServicio.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "CuentaCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaUsrCxppagosProveedores.Add(CType(entity, CuentaEntity))
					End If
				Case "PolizaCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaUsrCxppagosProveedores.Add(CType(entity, PolizaEntity))
					End If
				Case "ProveedorAvanzado"
					_alreadyFetchedProveedorAvanzado = True
					Me.ProveedorAvanzado = CType(entity, ProveedorAvanzadoEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CatLugaresDeCompra"
					SetupSyncCatLugaresDeCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable_"
					SetupSyncCuentaContable_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabRegCom"
					_cabRegCom.Add(CType(relatedEntity, CabRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CostoProductoProveedor"
					_costoProductoProveedor.Add(CType(relatedEntity, CostoProductoProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CostoProducto"
					_costoProducto.Add(CType(relatedEntity, CostoProductoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CostoProducto_"
					_costoProducto_.Add(CType(relatedEntity, CostoProductoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedor"
					_mcomCotizacionCompraProveedor.Add(CType(relatedEntity, McomCotizacionCompraProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					_mcomCotizacionCompraProveedorDetalle.Add(CType(relatedEntity, McomCotizacionCompraProveedorDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompra"
					_ordenCompra.Add(CType(relatedEntity, OrdenCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Beneficiario_"
					_beneficiario_.Add(CType(relatedEntity, BeneficiarioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionServicio"
					_cotizacionServicio.Add(CType(relatedEntity, CotizacionServicioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenServicio"
					_ordenServicio.Add(CType(relatedEntity, OrdenServicioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxpfacturasApagar"
					_usrCxpfacturasApagar.Add(CType(relatedEntity, UsrCxpfacturasApagarEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxpfacturasCab"
					_usrCxpfacturasCab.Add(CType(relatedEntity, UsrCxpfacturasCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					_usrCxppagosProveedores.Add(CType(relatedEntity, UsrCxppagosProveedoresEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProveedorAvanzado"
					SetupSyncProveedorAvanzado(relatedEntity)
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
				Case "CatLugaresDeCompra"
					DesetupSyncCatLugaresDeCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable_"
					DesetupSyncCuentaContable_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabRegCom"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CostoProductoProveedor"
					MyBase.PerformRelatedEntityRemoval(_costoProductoProveedor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CostoProducto"
					MyBase.PerformRelatedEntityRemoval(_costoProducto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CostoProducto_"
					MyBase.PerformRelatedEntityRemoval(_costoProducto_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedor"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedorDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_ordenCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Beneficiario_"
					MyBase.PerformRelatedEntityRemoval(_beneficiario_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionServicio"
					MyBase.PerformRelatedEntityRemoval(_cotizacionServicio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenServicio"
					MyBase.PerformRelatedEntityRemoval(_ordenServicio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxpfacturasApagar"
					MyBase.PerformRelatedEntityRemoval(_usrCxpfacturasApagar, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxpfacturasCab"
					MyBase.PerformRelatedEntityRemoval(_usrCxpfacturasCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					MyBase.PerformRelatedEntityRemoval(_usrCxppagosProveedores, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProveedorAvanzado"
					DesetupSyncProveedorAvanzado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()

			If Not _proveedorAvanzado Is Nothing Then
				toReturn.Add(_proveedorAvanzado)
			End If


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _catLugaresDeCompra Is Nothing Then
				toReturn.Add(_catLugaresDeCompra)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If
			If Not _cuentaContable_ Is Nothing Then
				toReturn.Add(_cuentaContable_)
			End If




			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cabRegCom)
			toReturn.Add(_costoProductoProveedor)
			toReturn.Add(_costoProducto)
			toReturn.Add(_costoProducto_)
			toReturn.Add(_mcomCotizacionCompraProveedor)
			toReturn.Add(_mcomCotizacionCompraProveedorDetalle)
			toReturn.Add(_ordenCompra)
			toReturn.Add(_beneficiario_)
			toReturn.Add(_cotizacionServicio)
			toReturn.Add(_ordenServicio)
			toReturn.Add(_usrCxpfacturasApagar)
			toReturn.Add(_usrCxpfacturasCab)
			toReturn.Add(_usrCxppagosProveedores)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ProveedorFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ProveedorFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			If ( Not _alreadyFetchedCabRegCom Or forceFetch Or _alwaysFetchCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabRegCom)
					End If
				End If
				_cabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabRegCom.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Nothing, Filter)
				_cabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabRegCom = True
			End If
			Return _cabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabRegCom'. These settings will be taken into account
		''' when the property CabRegCom is requested or GetMultiCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabRegCom.SortClauses=sortClauses
			_cabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CostoProductoProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoProveedorEntity'</returns>
		Public Function GetMultiCostoProductoProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
			Return GetMultiCostoProductoProveedor(forceFetch, _costoProductoProveedor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCostoProductoProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
			Return GetMultiCostoProductoProveedor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoProveedorEntity'</returns>
		Public Function GetMultiCostoProductoProveedor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
			Return GetMultiCostoProductoProveedor(forceFetch, _costoProductoProveedor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCostoProductoProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
			If ( Not _alreadyFetchedCostoProductoProveedor Or forceFetch Or _alwaysFetchCostoProductoProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _costoProductoProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_costoProductoProveedor)
					End If
				End If
				_costoProductoProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_costoProductoProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_costoProductoProveedor.GetMultiManyToOne(Nothing, Me, Filter)
				_costoProductoProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCostoProductoProveedor = True
			End If
			Return _costoProductoProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CostoProductoProveedor'. These settings will be taken into account
		''' when the property CostoProductoProveedor is requested or GetMultiCostoProductoProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCostoProductoProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_costoProductoProveedor.SortClauses=sortClauses
			_costoProductoProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoEntity'</returns>
		Public Function GetMultiCostoProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto(forceFetch, _costoProducto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCostoProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoEntity'</returns>
		Public Function GetMultiCostoProducto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto(forceFetch, _costoProducto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCostoProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			If ( Not _alreadyFetchedCostoProducto Or forceFetch Or _alwaysFetchCostoProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _costoProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_costoProducto)
					End If
				End If
				_costoProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_costoProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_costoProducto.GetMultiManyToOne(Me, Nothing, Filter)
				_costoProducto.SuppressClearInGetMulti = False
				_alreadyFetchedCostoProducto = True
			End If
			Return _costoProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CostoProducto'. These settings will be taken into account
		''' when the property CostoProducto is requested or GetMultiCostoProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCostoProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_costoProducto.SortClauses=sortClauses
			_costoProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoEntity'</returns>
		Public Function GetMultiCostoProducto_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto_(forceFetch, _costoProducto_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCostoProducto_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CostoProductoEntity'</returns>
		Public Function GetMultiCostoProducto_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Return GetMultiCostoProducto_(forceFetch, _costoProducto_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCostoProducto_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CostoProductoCollection
			If ( Not _alreadyFetchedCostoProducto_ Or forceFetch Or _alwaysFetchCostoProducto_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _costoProducto_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_costoProducto_)
					End If
				End If
				_costoProducto_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_costoProducto_.EntityFactoryToUse = entityFactoryToUse
				End If
				_costoProducto_.GetMultiManyToOne(Nothing, Me, Filter)
				_costoProducto_.SuppressClearInGetMulti = False
				_alreadyFetchedCostoProducto_ = True
			End If
			Return _costoProducto_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CostoProducto_'. These settings will be taken into account
		''' when the property CostoProducto_ is requested or GetMultiCostoProducto_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCostoProducto_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_costoProducto_.SortClauses=sortClauses
			_costoProducto_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
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
				_mcomCotizacionCompraProveedor.GetMultiManyToOne(Me, Nothing, Filter)
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
				_mcomCotizacionCompraProveedorDetalle.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Nothing, Filter)
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
				_ordenCompra.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiario_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiario_(forceFetch, _beneficiario_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiBeneficiario_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiario_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiario_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiario_(forceFetch, _beneficiario_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBeneficiario_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			If ( Not _alreadyFetchedBeneficiario_ Or forceFetch Or _alwaysFetchBeneficiario_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _beneficiario_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_beneficiario_)
					End If
				End If
				_beneficiario_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_beneficiario_.EntityFactoryToUse = entityFactoryToUse
				End If
				_beneficiario_.GetMultiManyToOne(Me, Filter)
				_beneficiario_.SuppressClearInGetMulti = False
				_alreadyFetchedBeneficiario_ = True
			End If
			Return _beneficiario_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Beneficiario_'. These settings will be taken into account
		''' when the property Beneficiario_ is requested or GetMultiBeneficiario_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBeneficiario_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_beneficiario_.SortClauses=sortClauses
			_beneficiario_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_cotizacionServicio.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
				_ordenServicio.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasApagarEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasApagarEntity'</returns>
		Public Function GetMultiUsrCxpfacturasApagar(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
			Return GetMultiUsrCxpfacturasApagar(forceFetch, _usrCxpfacturasApagar.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasApagarEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxpfacturasApagar(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
			Return GetMultiUsrCxpfacturasApagar(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasApagarEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasApagarEntity'</returns>
		Public Function GetMultiUsrCxpfacturasApagar(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
			Return GetMultiUsrCxpfacturasApagar(forceFetch, _usrCxpfacturasApagar.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasApagarEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasApagar(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
			If ( Not _alreadyFetchedUsrCxpfacturasApagar Or forceFetch Or _alwaysFetchUsrCxpfacturasApagar) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasApagar.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasApagar)
					End If
				End If
				_usrCxpfacturasApagar.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasApagar.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasApagar.GetMultiManyToOne(Me, Filter)
				_usrCxpfacturasApagar.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasApagar = True
			End If
			Return _usrCxpfacturasApagar
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasApagar'. These settings will be taken into account
		''' when the property UsrCxpfacturasApagar is requested or GetMultiUsrCxpfacturasApagar is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasApagar(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasApagar.SortClauses=sortClauses
			_usrCxpfacturasApagar.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasCabEntity'</returns>
		Public Function GetMultiUsrCxpfacturasCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Return GetMultiUsrCxpfacturasCab(forceFetch, _usrCxpfacturasCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxpfacturasCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Return GetMultiUsrCxpfacturasCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasCabEntity'</returns>
		Public Function GetMultiUsrCxpfacturasCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Return GetMultiUsrCxpfacturasCab(forceFetch, _usrCxpfacturasCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			If ( Not _alreadyFetchedUsrCxpfacturasCab Or forceFetch Or _alwaysFetchUsrCxpfacturasCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasCab)
					End If
				End If
				_usrCxpfacturasCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasCab.GetMultiManyToOne(Me, Filter)
				_usrCxpfacturasCab.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasCab = True
			End If
			Return _usrCxpfacturasCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasCab'. These settings will be taken into account
		''' when the property UsrCxpfacturasCab is requested or GetMultiUsrCxpfacturasCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasCab.SortClauses=sortClauses
			_usrCxpfacturasCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxppagosProveedoresEntity'</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, _usrCxppagosProveedores.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxppagosProveedoresEntity'</returns>
		Public Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Return GetMultiUsrCxppagosProveedores(forceFetch, _usrCxppagosProveedores.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			If ( Not _alreadyFetchedUsrCxppagosProveedores Or forceFetch Or _alwaysFetchUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxppagosProveedores)
					End If
				End If
				_usrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxppagosProveedores.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_usrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxppagosProveedores = True
			End If
			Return _usrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxppagosProveedores'. These settings will be taken into account
		''' when the property UsrCxppagosProveedores is requested or GetMultiUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxppagosProveedores.SortClauses=sortClauses
			_usrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom(forceFetch, _cabMovGanCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
			End If
			Return _cabMovGanCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom is requested or GetMultiCabMovGanCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch, _cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
			End If
			Return _cabMovGanCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom_ is requested or GetMultiCabMovGanCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom_.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch, _catLugaresDeCompraCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_catLugaresDeCompraCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaCabRegCom.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = True
			End If
			Return _catLugaresDeCompraCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaCabRegCom is requested or GetMultiCatLugaresDeCompraCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaCabRegCom.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch, _mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
			End If
			Return _mcecatCorralesCabCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaCabRegCom is requested or GetMultiMcecatCorralesCabCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaCabRegCom.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCompradoresdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch, _mcgcatCompradoresdeGanadoCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
			End If
			Return _mcgcatCompradoresdeGanadoCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatCompradoresdeGanadoCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McgcatCompradoresdeGanadoCollectionViaCabRegCom is requested or GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatCompradoresdeGanadoCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.SortClauses=sortClauses
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCostoProductoProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCostoProductoProveedor(forceFetch, _productoCollectionViaCostoProductoProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCostoProductoProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCostoProductoProveedor Or forceFetch Or _alwaysFetchProductoCollectionViaCostoProductoProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCostoProductoProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCostoProductoProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, "__ProveedorEntity__", "CostoProductoProveedor_", JoinHint.None)
				relations.Add(CostoProductoProveedorEntity.Relations.ProductoEntityUsingProducto, "CostoProductoProveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaCostoProductoProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCostoProductoProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCostoProductoProveedor.GetMulti(Filter, relations)
				_productoCollectionViaCostoProductoProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCostoProductoProveedor = True
			End If
			Return _productoCollectionViaCostoProductoProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCostoProductoProveedor'. These settings will be taken into account
		''' when the property ProductoCollectionViaCostoProductoProveedor is requested or GetMultiProductoCollectionViaCostoProductoProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCostoProductoProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCostoProductoProveedor.SortClauses=sortClauses
			_productoCollectionViaCostoProductoProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(forceFetch, _cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor Or forceFetch Or _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedor_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.GetMulti(Filter, relations)
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = True
			End If
			Return _cotizacionCompraCollectionViaMcomCotizacionCompraProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionCompraCollectionViaMcomCotizacionCompraProveedor'. These settings will be taken into account
		''' when the property CotizacionCompraCollectionViaMcomCotizacionCompraProveedor is requested or GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.SortClauses=sortClauses
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaOrdenCompra(forceFetch, _tipoMonedaCollectionViaOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaOrdenCompra Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, "__ProveedorEntity__", "OrdenCompra_", JoinHint.None)
				relations.Add(OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoMonedaCollectionViaOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaOrdenCompra.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaOrdenCompra = True
			End If
			Return _tipoMonedaCollectionViaOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaOrdenCompra'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaOrdenCompra is requested or GetMultiTipoMonedaCollectionViaOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaOrdenCompra.SortClauses=sortClauses
			_tipoMonedaCollectionViaOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaCotizacionServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaCotizacionServicio(forceFetch, _tipoMonedaCollectionViaCotizacionServicio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaCotizacionServicio Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaCotizacionServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaCotizacionServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaCotizacionServicio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, "__ProveedorEntity__", "CotizacionServicio_", JoinHint.None)
				relations.Add(CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, "CotizacionServicio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoMonedaCollectionViaCotizacionServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaCotizacionServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaCotizacionServicio.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaCotizacionServicio.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio = True
			End If
			Return _tipoMonedaCollectionViaCotizacionServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaCotizacionServicio'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaCotizacionServicio is requested or GetMultiTipoMonedaCollectionViaCotizacionServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaCotizacionServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaCotizacionServicio.SortClauses=sortClauses
			_tipoMonedaCollectionViaCotizacionServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaOrdenServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaOrdenServicio(forceFetch, _tipoMonedaCollectionViaOrdenServicio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaOrdenServicio Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaOrdenServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaOrdenServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaOrdenServicio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, "__ProveedorEntity__", "OrdenServicio_", JoinHint.None)
				relations.Add(OrdenServicioEntity.Relations.TipoMonedaEntityUsingMonedaId, "OrdenServicio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoMonedaCollectionViaOrdenServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaOrdenServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaOrdenServicio.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaOrdenServicio.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaOrdenServicio = True
			End If
			Return _tipoMonedaCollectionViaOrdenServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaOrdenServicio'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaOrdenServicio is requested or GetMultiTipoMonedaCollectionViaOrdenServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaOrdenServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaOrdenServicio.SortClauses=sortClauses
			_tipoMonedaCollectionViaOrdenServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaUsrCxppagosProveedores(forceFetch, _cuentaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores Or forceFetch Or _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaUsrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaUsrCxppagosProveedores)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "__ProveedorEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaUsrCxppagosProveedores.GetMulti(Filter, relations)
				_cuentaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = True
			End If
			Return _cuentaCollectionViaUsrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaUsrCxppagosProveedores'. These settings will be taken into account
		''' when the property CuentaCollectionViaUsrCxppagosProveedores is requested or GetMultiCuentaCollectionViaUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaUsrCxppagosProveedores.SortClauses=sortClauses
			_cuentaCollectionViaUsrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch, _polizaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores Or forceFetch Or _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaUsrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaUsrCxppagosProveedores)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "__ProveedorEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProveedorFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaUsrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaUsrCxppagosProveedores.GetMulti(Filter, relations)
				_polizaCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = True
			End If
			Return _polizaCollectionViaUsrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaUsrCxppagosProveedores'. These settings will be taken into account
		''' when the property PolizaCollectionViaUsrCxppagosProveedores is requested or GetMultiPolizaCollectionViaUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaUsrCxppagosProveedores.SortClauses=sortClauses
			_polizaCollectionViaUsrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CatLugaresDeCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatLugaresDeCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatLugaresDeCompra() As CatLugaresDeCompraEntity
			Return GetSingleCatLugaresDeCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatLugaresDeCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatLugaresDeCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatLugaresDeCompra(forceFetch As Boolean) As CatLugaresDeCompraEntity
			If ( Not _alreadyFetchedCatLugaresDeCompra Or forceFetch Or _alwaysFetchCatLugaresDeCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatLugaresDeCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdLugarCompra.GetValueOrDefault())
				End If
				If Not _catLugaresDeCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatLugaresDeCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatLugaresDeCompraEntity)
					End If
					Me.CatLugaresDeCompra = newEntity
					_alreadyFetchedCatLugaresDeCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catLugaresDeCompra
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
				If MyBase.CheckIfLazyLoadingShouldOccur(ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentaContId.GetValueOrDefault())
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
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable_() As CuentaContableEntity
			Return GetSingleCuentaContable_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable_(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaContable_ Or forceFetch Or _alwaysFetchCuentaContable_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt) Then
					fetchResult = newEntity.FetchUsingPK(Me.PrCuentaAnt.GetValueOrDefault())
				End If
				If Not _cuentaContable_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaContable_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaContable_ = newEntity
					_alreadyFetchedCuentaContable_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaContable_
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'ProveedorAvanzadoEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorAvanzadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedorAvanzado() As ProveedorAvanzadoEntity
			Return GetSingleProveedorAvanzado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorAvanzadoEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorAvanzadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedorAvanzado(forceFetch As Boolean) As ProveedorAvanzadoEntity
			If ( Not _alreadyFetchedProveedorAvanzado Or forceFetch Or _alwaysFetchProveedorAvanzado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New ProveedorAvanzadoEntity()
				Dim relation As IEntityRelation = ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
				End If
				If Not _proveedorAvanzadoReturnsNewIfNotFound And Not fetchResult Then
					Me.ProveedorAvanzado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorAvanzadoEntity)
					End If
					Me.ProveedorAvanzado = newEntity
					_alreadyFetchedProveedorAvanzado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedorAvanzado
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ProveedorFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ProveedorFieldIndex)



















					Case ProveedorFieldIndex.CuentaContId
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False
					Case ProveedorFieldIndex.PrCuentaAnt
						DesetupSyncCuentaContable_(True, False)
						_alreadyFetchedCuentaContable_ = False









					Case ProveedorFieldIndex.IdLugarCompra
						DesetupSyncCatLugaresDeCompra(True, False)
						_alreadyFetchedCatLugaresDeCompra = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabRegCom.ActiveContext = MyBase.ActiveContext
			_costoProductoProveedor.ActiveContext = MyBase.ActiveContext
			_costoProducto.ActiveContext = MyBase.ActiveContext
			_costoProducto_.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedor.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompra.ActiveContext = MyBase.ActiveContext
			_beneficiario_.ActiveContext = MyBase.ActiveContext
			_cotizacionServicio.ActiveContext = MyBase.ActiveContext
			_ordenServicio.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasApagar.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasCab.ActiveContext = MyBase.ActiveContext
			_usrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCostoProductoProveedor.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaOrdenCompra.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaCotizacionServicio.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaOrdenServicio.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
		If Not _catLugaresDeCompra Is Nothing Then
				_catLugaresDeCompra.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable_ Is Nothing Then
				_cuentaContable_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _proveedorAvanzado Is Nothing Then
				_proveedorAvanzado.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ProveedorDAO = CType(CreateDAOInstance(), ProveedorDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ProveedorDAO = CType(CreateDAOInstance(), ProveedorDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ProveedorDAO = CType(CreateDAOInstance(), ProveedorDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ProveedorEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <param name="validator">The validator Object for this ProveedorEntity</param>
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
			_cabRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_costoProductoProveedor = New Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection(New CostoProductoProveedorEntityFactory())
			_costoProductoProveedor.SetContainingEntityInfo(Me, "Proveedor_")
			_alwaysFetchCostoProductoProveedor = False
			_alreadyFetchedCostoProductoProveedor = False
			_costoProducto = New Integralab.ORM.CollectionClasses.CostoProductoCollection(New CostoProductoEntityFactory())
			_costoProducto.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchCostoProducto = False
			_alreadyFetchedCostoProducto = False
			_costoProducto_ = New Integralab.ORM.CollectionClasses.CostoProductoCollection(New CostoProductoEntityFactory())
			_costoProducto_.SetContainingEntityInfo(Me, "Proveedor_")
			_alwaysFetchCostoProducto_ = False
			_alreadyFetchedCostoProducto_ = False
			_mcomCotizacionCompraProveedor = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_mcomCotizacionCompraProveedor.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchMcomCotizacionCompraProveedor = False
			_alreadyFetchedMcomCotizacionCompraProveedor = False
			_mcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(New McomCotizacionCompraProveedorDetalleEntityFactory())
			_mcomCotizacionCompraProveedorDetalle.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = False
			_ordenCompra = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_ordenCompra.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchOrdenCompra = False
			_alreadyFetchedOrdenCompra = False
			_beneficiario_ = New Integralab.ORM.CollectionClasses.BeneficiarioCollection(New BeneficiarioEntityFactory())
			_beneficiario_.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchBeneficiario_ = False
			_alreadyFetchedBeneficiario_ = False
			_cotizacionServicio = New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(New CotizacionServicioEntityFactory())
			_cotizacionServicio.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchCotizacionServicio = False
			_alreadyFetchedCotizacionServicio = False
			_ordenServicio = New Integralab.ORM.CollectionClasses.OrdenServicioCollection(New OrdenServicioEntityFactory())
			_ordenServicio.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchOrdenServicio = False
			_alreadyFetchedOrdenServicio = False
			_usrCxpfacturasApagar = New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection(New UsrCxpfacturasApagarEntityFactory())
			_usrCxpfacturasApagar.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchUsrCxpfacturasApagar = False
			_alreadyFetchedUsrCxpfacturasApagar = False
			_usrCxpfacturasCab = New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection(New UsrCxpfacturasCabEntityFactory())
			_usrCxpfacturasCab.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchUsrCxpfacturasCab = False
			_alreadyFetchedUsrCxpfacturasCab = False
			_usrCxppagosProveedores = New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(New UsrCxppagosProveedoresEntityFactory())
			_usrCxppagosProveedores.SetContainingEntityInfo(Me, "Proveedor")
			_alwaysFetchUsrCxppagosProveedores = False
			_alreadyFetchedUsrCxppagosProveedores = False
			_cabMovGanCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = False
			_cabMovGanCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = False
			_catLugaresDeCompraCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = False
			_mcecatCorralesCabCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = False
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = False
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_productoCollectionViaCostoProductoProveedor = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCostoProductoProveedor = False
			_alreadyFetchedProductoCollectionViaCostoProductoProveedor = False
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedor = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = False
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = False
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaOrdenCompra = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaOrdenCompra = False
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompra = False
			_tipoMonedaCollectionViaCotizacionServicio = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaCotizacionServicio = False
			_alreadyFetchedTipoMonedaCollectionViaCotizacionServicio = False
			_tipoMonedaCollectionViaOrdenServicio = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaOrdenServicio = False
			_alreadyFetchedTipoMonedaCollectionViaOrdenServicio = False
			_cuentaCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = False
			_polizaCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedPolizaCollectionViaUsrCxppagosProveedores = False
			_catLugaresDeCompra = Nothing
			_catLugaresDeCompraReturnsNewIfNotFound = True
			_alwaysFetchCatLugaresDeCompra = False
			_alreadyFetchedCatLugaresDeCompra = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_cuentaContable_ = Nothing
			_cuentaContable_ReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable_ = False
			_alreadyFetchedCuentaContable_ = False
			_proveedorAvanzado = Nothing
			_proveedorAvanzadoReturnsNewIfNotFound = True
			_alwaysFetchProveedorAvanzado = False
			_alreadyFetchedProveedorAvanzado = False
			
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

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RazonSocial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Beneficiario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contacto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ReprecentanteLegal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrIdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrIdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaContId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrCuentaAnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsdeGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimoPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteUltimoPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComprasAnoActual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComprasAnoAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoActual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLugarCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumComCab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumComKil", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumComCabAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumComKilAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrMeat", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrPuntoVenta", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _catLugaresDeCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatLugaresDeCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catLugaresDeCompra, AddressOf OnCatLugaresDeCompraPropertyChanged, "CatLugaresDeCompra", ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, True, signalRelatedEntity, "Proveedor", resetFKFields, New Integer() { CInt(ProveedorFieldIndex.IdLugarCompra) } )
			_catLugaresDeCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catLugaresDeCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatLugaresDeCompra(relatedEntity As IEntity)
			DesetupSyncCatLugaresDeCompra(True, True)
			_catLugaresDeCompra = CType(relatedEntity, CatLugaresDeCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catLugaresDeCompra, AddressOf OnCatLugaresDeCompraPropertyChanged, "CatLugaresDeCompra", ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, True, _alreadyFetchedCatLugaresDeCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatLugaresDeCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId, True, signalRelatedEntity, "Proveedor", resetFKFields, New Integer() { CInt(ProveedorFieldIndex.CuentaContId) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId, True, _alreadyFetchedCuentaContable, New String() {  } )
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
		''' <summary>Removes the sync logic for member _cuentaContable_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable_, AddressOf OnCuentaContable_PropertyChanged, "CuentaContable_", ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt, True, signalRelatedEntity, "Proveedor_", resetFKFields, New Integer() { CInt(ProveedorFieldIndex.PrCuentaAnt) } )
			_cuentaContable_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable_(relatedEntity As IEntity)
			DesetupSyncCuentaContable_(True, True)
			_cuentaContable_ = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable_, AddressOf OnCuentaContable_PropertyChanged, "CuentaContable_", ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt, True, _alreadyFetchedCuentaContable_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaContable_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _proveedorAvanzado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedorAvanzado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedorAvanzado, AddressOf OnProveedorAvanzadoPropertyChanged, "ProveedorAvanzado", ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo, False, signalRelatedEntity, "Proveedor", False, New Integer() { CInt(ProveedorFieldIndex.Codigo) } )
			_proveedorAvanzado = Nothing
		End Sub

		''' <summary>setups the sync logic for member _proveedorAvanzado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedorAvanzado(relatedEntity As IEntity)
			DesetupSyncProveedorAvanzado(True, True)
			_proveedorAvanzado = CType(relatedEntity, ProveedorAvanzadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedorAvanzado, AddressOf OnProveedorAvanzadoPropertyChanged, "ProveedorAvanzado", ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo, False, _alreadyFetchedProveedorAvanzado, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorAvanzadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Proveedor which data should be fetched into this Proveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ProveedorFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateProveedorDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ProveedorEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ProveedorRelations
			Get	
				Return New ProveedorRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoProductoProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoProductoProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection(), _
					ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CostoProductoProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "CostoProductoProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoProductoCollection(), _
					ProveedorEntity.Relations.CostoProductoEntityUsingUltimoProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CostoProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "CostoProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoProducto_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoProductoCollection(), _
					ProveedorEntity.Relations.CostoProductoEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CostoProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "CostoProducto_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedorDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiario_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					ProveedorEntity.Relations.BeneficiarioEntityUsingCodigoProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, Nothing, "Beneficiario_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(), _
					ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenServicioCollection(), _
					ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.OrdenServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasApagar' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasApagar() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection(), _
					ProveedorEntity.Relations.UsrCxpfacturasApagarEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasApagarEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasApagar", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection(), _
					ProveedorEntity.Relations.UsrCxpfacturasCabEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxppagosProveedores' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(), _
					ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxppagosProveedoresEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanadoCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					ProveedorEntity.Relations.CabRegComEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCompradoresdeGanadoCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCostoProductoProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CostoProductoProveedorEntity.Relations.ProductoEntityUsingProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					ProveedorEntity.Relations.CostoProductoProveedorEntityUsingProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCostoProductoProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaMcomCotizacionCompraProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaMcomCotizacionCompraProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					ProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, relations, "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProveedorEntity.Relations.OrdenCompraEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaCotizacionServicio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProveedorEntity.Relations.CotizacionServicioEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaCotizacionServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaOrdenServicio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenServicioEntity.Relations.TipoMonedaEntityUsingMonedaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProveedorEntity.Relations.OrdenServicioEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaOrdenServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, "__ProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					ProveedorEntity.Relations.UsrCxppagosProveedoresEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CatLugaresDeCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProveedorAvanzado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorAvanzado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorAvanzadoCollection(), _
					ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo, _
					CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorAvanzadoEntity, Integer), 0, Nothing, Nothing, Nothing, "ProveedorAvanzado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ProveedorEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ProveedorEntity.CustomProperties
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
				Return ProveedorEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrRFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The RazonSocial property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrRazSocial"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [RazonSocial]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.RazonSocial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.RazonSocial, Integer), value)
			End Set
		End Property
	
		''' <summary>The Beneficiario property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrBeneficiario"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Beneficiario]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Beneficiario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Beneficiario, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contacto property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrContacto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Contacto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Contacto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Contacto, Integer), value)
			End Set
		End Property
	
		''' <summary>The ReprecentanteLegal property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrRepLegal"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ReprecentanteLegal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ReprecentanteLegal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ReprecentanteLegal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Domicilio property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrDomicilio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Domicilio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Domicilio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Domicilio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrColonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPostal property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrCodPos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPostal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.CodigoPostal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.CodigoPostal, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrIdEstado property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrIdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.PrIdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.PrIdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrIdCiudad property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrIdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.PrIdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.PrIdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPoblacion property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.CodigoPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.CodigoPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaContId property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrCuentaContId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CuentaContId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.CuentaContId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.CuentaContId, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrCuentaAnt property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrCuentaAnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PrCuentaAnt]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.PrCuentaAnt, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.PrCuentaAnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsdeGanado property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."EsdeGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EsdeGanado]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.EsdeGanado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.EsdeGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombre property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Nombre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.Nombre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.Nombre, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaCompra property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."FechaUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaCompra]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.FechaUltimaCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.FechaUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteUltimaCompra property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."ImporteUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteUltimaCompra]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ImporteUltimaCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ImporteUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimoPago property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."FechaUltimoPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimoPago]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.FechaUltimoPago, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.FechaUltimoPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteUltimoPago property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."ImporteUltimoPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteUltimoPago]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ImporteUltimoPago, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ImporteUltimoPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComprasAnoActual property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."ComprasAnoActual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ComprasAnoActual]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ComprasAnoActual, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ComprasAnoActual, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComprasAnoAnterior property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."ComprasAnoAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ComprasAnoAnterior]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.ComprasAnoAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.ComprasAnoAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoActual property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."SaldoActual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SaldoActual]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.SaldoActual, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.SaldoActual, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdLugarCompra property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."IdLugarCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdLugarCompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.IdLugarCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.IdLugarCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumComCab property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."AcumComCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [AcumComCab]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.AcumComCab, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.AcumComCab, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumComKil property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."AcumComKil"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [AcumComKil]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.AcumComKil, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.AcumComKil, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumComCabAnterior property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."AcumComCabAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [AcumComCabAnterior]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.AcumComCabAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.AcumComCabAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumComKilAnterior property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."AcumComKilAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [AcumComKilAnterior]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.AcumComKilAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.AcumComKilAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrMeat property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrMeat"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrMeat]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.PrMeat, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.PrMeat, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrPuntoVenta property of the Entity Proveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedores"."PrPuntoVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrPuntoVenta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorFieldIndex.PrPuntoVenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorFieldIndex.PrPuntoVenta, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabRegCom]() As Integralab.ORM.CollectionClasses.CabRegComCollection
			Get
				Return GetMultiCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegCom. When set to true, CabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegCom As Boolean
			Get
				Return _alwaysFetchCabRegCom
			End Get
			Set
				_alwaysFetchCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CostoProductoProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCostoProductoProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CostoProductoProveedor]() As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
			Get
				Return GetMultiCostoProductoProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CostoProductoProveedor. When set to true, CostoProductoProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CostoProductoProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCostoProductoProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCostoProductoProveedor As Boolean
			Get
				Return _alwaysFetchCostoProductoProveedor
			End Get
			Set
				_alwaysFetchCostoProductoProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCostoProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CostoProducto]() As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Get
				Return GetMultiCostoProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CostoProducto. When set to true, CostoProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CostoProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiCostoProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCostoProducto As Boolean
			Get
				Return _alwaysFetchCostoProducto
			End Get
			Set
				_alwaysFetchCostoProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CostoProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCostoProducto_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CostoProducto_]() As Integralab.ORM.CollectionClasses.CostoProductoCollection
			Get
				Return GetMultiCostoProducto_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CostoProducto_. When set to true, CostoProducto_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CostoProducto_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCostoProducto_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCostoProducto_ As Boolean
			Get
				Return _alwaysFetchCostoProducto_
			End Get
			Set
				_alwaysFetchCostoProducto_ = value
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
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBeneficiario_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Beneficiario_]() As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Get
				Return GetMultiBeneficiario_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Beneficiario_. When set to true, Beneficiario_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Beneficiario_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiBeneficiario_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiario_ As Boolean
			Get
				Return _alwaysFetchBeneficiario_
			End Get
			Set
				_alwaysFetchBeneficiario_ = value
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
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasApagarEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasApagar()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasApagar]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
			Get
				Return GetMultiUsrCxpfacturasApagar(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasApagar. When set to true, UsrCxpfacturasApagar is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasApagar is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasApagar(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasApagar As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasApagar
			End Get
			Set
				_alwaysFetchUsrCxpfacturasApagar = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasCab]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Get
				Return GetMultiUsrCxpfacturasCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasCab. When set to true, UsrCxpfacturasCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasCab As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasCab
			End Get
			Set
				_alwaysFetchUsrCxpfacturasCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrCxppagosProveedoresEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
			Get
				Return GetMultiUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxppagosProveedores. When set to true, UsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchUsrCxppagosProveedores = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom. When set to true, CabMovGanCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom_. When set to true, CabMovGanCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaCabRegCom. When set to true, CatLugaresDeCompraCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaCabRegCom. When set to true, McecatCorralesCabCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatCompradoresdeGanadoCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Get
				Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCompradoresdeGanadoCollectionViaCabRegCom. When set to true, McgcatCompradoresdeGanadoCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCompradoresdeGanadoCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCostoProductoProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCostoProductoProveedor]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCostoProductoProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCostoProductoProveedor. When set to true, ProductoCollectionViaCostoProductoProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCostoProductoProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCostoProductoProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCostoProductoProveedor As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCostoProductoProveedor
			End Get
			Set
				_alwaysFetchProductoCollectionViaCostoProductoProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionCompraCollectionViaMcomCotizacionCompraProveedor]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompraCollectionViaMcomCotizacionCompraProveedor. When set to true, CotizacionCompraCollectionViaMcomCotizacionCompraProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompraCollectionViaMcomCotizacionCompraProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor As Boolean
			Get
				Return _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor
			End Get
			Set
				_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedor = value
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
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = value
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
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaOrdenCompra]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaOrdenCompra. When set to true, TipoMonedaCollectionViaOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaOrdenCompra As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaOrdenCompra
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaCotizacionServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaCotizacionServicio]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaCotizacionServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaCotizacionServicio. When set to true, TipoMonedaCollectionViaCotizacionServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaCotizacionServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaCotizacionServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaCotizacionServicio As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaCotizacionServicio
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaCotizacionServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaOrdenServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaOrdenServicio]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaOrdenServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaOrdenServicio. When set to true, TipoMonedaCollectionViaOrdenServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaOrdenServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaOrdenServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaOrdenServicio As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaOrdenServicio
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaOrdenServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaUsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaUsrCxppagosProveedores. When set to true, CuentaCollectionViaUsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaUsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaUsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaUsrCxppagosProveedores. When set to true, PolizaCollectionViaUsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaUsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchPolizaCollectionViaUsrCxppagosProveedores = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CatLugaresDeCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatLugaresDeCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatLugaresDeCompra]() As CatLugaresDeCompraEntity
			Get
				Return GetSingleCatLugaresDeCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatLugaresDeCompra(value)
				Else
					If value Is Nothing Then
						If Not _catLugaresDeCompra Is Nothing Then
							_catLugaresDeCompra.UnsetRelatedEntity(Me, "Proveedor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Proveedor")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompra. When set to true, CatLugaresDeCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatLugaresDeCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompra As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompra
			End Get
			Set
				_alwaysFetchCatLugaresDeCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatLugaresDeCompra is not found
		''' in the database. When set to true, CatLugaresDeCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatLugaresDeCompraReturnsNewIfNotFound As Boolean
			Get
				Return _catLugaresDeCompraReturnsNewIfNotFound
			End Get
			Set
				_catLugaresDeCompraReturnsNewIfNotFound = value
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
							_cuentaContable.UnsetRelatedEntity(Me, "Proveedor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Proveedor")
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
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaContable_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaContable_]() As CuentaContableEntity
			Get
				Return GetSingleCuentaContable_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaContable_(value)
				Else
					If value Is Nothing Then
						If Not _cuentaContable_ Is Nothing Then
							_cuentaContable_.UnsetRelatedEntity(Me, "Proveedor_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Proveedor_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable_. When set to true, CuentaContable_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaContable_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable_ As Boolean
			Get
				Return _alwaysFetchCuentaContable_
			End Get
			Set
				_alwaysFetchCuentaContable_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaContable_ is not found
		''' in the database. When set to true, CuentaContable_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaContable_ReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaContable_ReturnsNewIfNotFound
			End Get
			Set
				_cuentaContable_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'ProveedorAvanzadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedorAvanzado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [ProveedorAvanzado]() As ProveedorAvanzadoEntity
			Get
				Return GetSingleProveedorAvanzado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedorAvanzado(value)
				Else
					If value Is Nothing Then
						DesetupSyncProveedorAvanzado(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "Proveedor")
						SetupSyncProveedorAvanzado(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorAvanzado. When set to true, ProveedorAvanzado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorAvanzado is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedorAvanzado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorAvanzado As Boolean
			Get
				Return _alwaysFetchProveedorAvanzado
			End Get
			Set
				_alwaysFetchProveedorAvanzado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property ProveedorAvanzado is not found
		''' in the database. When set to true, ProveedorAvanzado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorAvanzadoReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorAvanzadoReturnsNewIfNotFound
			End Get
			Set
				_proveedorAvanzadoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ProveedorEntity)
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
