' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:39
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
	''' <summary>Entity class which represents the entity 'Producto'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ProductoEntity 
#Else
	<Serializable()> _
	Public Class ProductoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMediDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDet, _alreadyFetchedAplicMediDet As Boolean
		Private _aplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
		Private _alwaysFetchAplicMediDetDet, _alreadyFetchedAplicMediDetDet As Boolean
		Private _cabPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm, _alreadyFetchedCabPrepForm As Boolean
		Private _cabPrepForm_ As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm_, _alreadyFetchedCabPrepForm_ As Boolean
		Private _detAlimentos As Integralab.ORM.CollectionClasses.DetAlimentosCollection
		Private _alwaysFetchDetAlimentos, _alreadyFetchedDetAlimentos As Boolean
		Private _detalleKitPv As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
		Private _alwaysFetchDetalleKitPv, _alreadyFetchedDetalleKitPv As Boolean
		Private _detalleKitPv_ As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
		Private _alwaysFetchDetalleKitPv_, _alreadyFetchedDetalleKitPv_ As Boolean
		Private _detAplFor As Integralab.ORM.CollectionClasses.DetAplForCollection
		Private _alwaysFetchDetAplFor, _alreadyFetchedDetAplFor As Boolean
		Private _detDproMed As Integralab.ORM.CollectionClasses.DetDproMedCollection
		Private _alwaysFetchDetDproMed, _alreadyFetchedDetDproMed As Boolean
		Private _detPrepForm As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepForm, _alreadyFetchedDetPrepForm As Boolean
		Private _detPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
		Private _alwaysFetchDetPrepFormLote, _alreadyFetchedDetPrepFormLote As Boolean
		Private _detProMed As Integralab.ORM.CollectionClasses.DetProMedCollection
		Private _alwaysFetchDetProMed, _alreadyFetchedDetProMed As Boolean
		Private _invHistorialPv As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
		Private _alwaysFetchInvHistorialPv, _alreadyFetchedInvHistorialPv As Boolean
		Private _costoProductoProveedor As Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection
		Private _alwaysFetchCostoProductoProveedor, _alreadyFetchedCostoProductoProveedor As Boolean
		Private _productoCostoIndirecto As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
		Private _alwaysFetchProductoCostoIndirecto, _alreadyFetchedProductoCostoIndirecto As Boolean
		Private _productoMezcla As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
		Private _alwaysFetchProductoMezcla, _alreadyFetchedProductoMezcla As Boolean
		Private _productoMezcla_ As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
		Private _alwaysFetchProductoMezcla_, _alreadyFetchedProductoMezcla_ As Boolean
		Private _listaPrecioDetalle As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
		Private _alwaysFetchListaPrecioDetalle, _alreadyFetchedListaPrecioDetalle As Boolean
		Private _mcecatLotesCabFor As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
		Private _alwaysFetchMcecatLotesCabFor, _alreadyFetchedMcecatLotesCabFor As Boolean
		Private _mcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorDetalle As Boolean
		Private _ordenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
		Private _alwaysFetchOrdenCompraDetalle, _alreadyFetchedOrdenCompraDetalle As Boolean
		Private _mcomPresupuestoDetalle As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
		Private _alwaysFetchMcomPresupuestoDetalle, _alreadyFetchedMcomPresupuestoDetalle As Boolean
		Private _mcomRecepcionOrdenCompraDet As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
		Private _alwaysFetchMcomRecepcionOrdenCompraDet, _alreadyFetchedMcomRecepcionOrdenCompraDet As Boolean
		Private _solicitudProductoDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalle, _alreadyFetchedSolicitudProductoDetalle As Boolean
		Private _inventarioAlmacen As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
		Private _alwaysFetchInventarioAlmacen, _alreadyFetchedInventarioAlmacen As Boolean
		Private _inventarioAlmacenLotes As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
		Private _alwaysFetchInventarioAlmacenLotes, _alreadyFetchedInventarioAlmacenLotes As Boolean
		Private _inventarioMovimientosAlmacenDetalles As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
		Private _alwaysFetchInventarioMovimientosAlmacenDetalles, _alreadyFetchedInventarioMovimientosAlmacenDetalles As Boolean
		Private _minvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
		Private _alwaysFetchMinvMovimientosAlmacenPvdetalles, _alreadyFetchedMinvMovimientosAlmacenPvdetalles As Boolean
		Private _minvTransferenciaAlmacenEntradaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle, _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle As Boolean
		Private _minvTransferenciaAlmacenSalidaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle, _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle As Boolean
		Private _mventaNotaVentaDetalle As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
		Private _alwaysFetchMventaNotaVentaDetalle, _alreadyFetchedMventaNotaVentaDetalle As Boolean
		Private _usrAlmInvFisico As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
		Private _alwaysFetchUsrAlmInvFisico, _alreadyFetchedUsrAlmInvFisico As Boolean
		Private _usrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
		Private _alwaysFetchUsrProdRecepcionDetalle, _alreadyFetchedUsrProdRecepcionDetalle As Boolean
		Private _aplicMediCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDet, _alreadyFetchedAplicMediCollectionViaAplicMediDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet As Boolean
		Private _aplicMediCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediCollectionViaAplicMediDetDet As Boolean
		Private _aplicMediDetCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
		Private _almacenCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm, _alreadyFetchedAlmacenCollectionViaCabPrepForm As Boolean
		Private _almacenCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm_, _alreadyFetchedAlmacenCollectionViaCabPrepForm_ As Boolean
		Private _plazaCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm, _alreadyFetchedPlazaCollectionViaCabPrepForm As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm__ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm___ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ As Boolean
		Private _plazaCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm_, _alreadyFetchedPlazaCollectionViaCabPrepForm_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm____ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm_____ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm______ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm_______ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ As Boolean
		Private _catNutrientesCollectionViaDetAlimentos As Integralab.ORM.CollectionClasses.CatNutrientesCollection
		Private _alwaysFetchCatNutrientesCollectionViaDetAlimentos, _alreadyFetchedCatNutrientesCollectionViaDetAlimentos As Boolean
		Private _cabAplForCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplForCollectionViaDetAplFor, _alreadyFetchedCabAplForCollectionViaDetAplFor As Boolean
		Private _mcecatCorralesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor, _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor As Boolean
		Private _mcecatLotesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaDetAplFor, _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor As Boolean
		Private _cabProMedCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.CabProMedCollection
		Private _alwaysFetchCabProMedCollectionViaDetDproMed, _alreadyFetchedCabProMedCollectionViaDetDproMed As Boolean
		Private _detProMedCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.DetProMedCollection
		Private _alwaysFetchDetProMedCollectionViaDetDproMed, _alreadyFetchedDetProMedCollectionViaDetDproMed As Boolean
		Private _mcecatLotesCabCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaDetDproMed, _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed As Boolean
		Private _cabPrepFormCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepFormCollectionViaDetPrepForm, _alreadyFetchedCabPrepFormCollectionViaDetPrepForm As Boolean
		Private _plazaCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaDetPrepForm, _alreadyFetchedPlazaCollectionViaDetPrepForm As Boolean
		Private _cabPrepFormCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote, _alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote As Boolean
		Private _detPrepFormCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote, _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote As Boolean
		Private _plazaCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaDetPrepFormLote, _alreadyFetchedPlazaCollectionViaDetPrepFormLote As Boolean
		Private _cabProMedCollectionViaDetProMed As Integralab.ORM.CollectionClasses.CabProMedCollection
		Private _alwaysFetchCabProMedCollectionViaDetProMed, _alreadyFetchedCabProMedCollectionViaDetProMed As Boolean
		Private _almacenCollectionViaInvHistorialPv As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaInvHistorialPv, _alreadyFetchedAlmacenCollectionViaInvHistorialPv As Boolean
		Private _proveedorCollectionViaCostoProductoProveedor As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCostoProductoProveedor, _alreadyFetchedProveedorCollectionViaCostoProductoProveedor As Boolean
		Private _costoIndirectoCollectionViaProductoCostoIndirecto As Integralab.ORM.CollectionClasses.CostoIndirectoCollection
		Private _alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto, _alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto As Boolean
		Private _listaPrecioCollectionViaListaPrecioDetalle As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecioCollectionViaListaPrecioDetalle, _alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle As Boolean
		Private _mcecatLotesCabCollectionViaMcecatLotesCabFor As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor, _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor As Boolean
		Private _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle, _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle As Boolean
		Private _cotizacionCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _ordenCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _solicitudProductoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _mcomPresupuestoCollectionViaMcomPresupuestoDetalle As Integralab.ORM.CollectionClasses.PresupuestoCollection
		Private _alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle, _alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle As Boolean
		Private _solicitudProductoCollectionViaSolicitudProductoDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle, _alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle As Boolean
		Private _almacenCollectionViaInventarioAlmacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaInventarioAlmacen, _alreadyFetchedAlmacenCollectionViaInventarioAlmacen As Boolean
		Private _almacenCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes, _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes As Boolean
		Private _inventarioAlmacenCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
		Private _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes, _alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes As Boolean
		Private _almacenCollectionViaInventarioMovimientoAlmacenDetalles As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles, _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
		Private _inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles, _alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles As Boolean
		Private _almacenCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
		Private _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle, _alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Boolean
		Private _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle, _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Boolean
		Private _mventaNotasVentaCollectionViaMventaNotaVentaDetalle As Integralab.ORM.CollectionClasses.NotaVentaCollection
		Private _alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle, _alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle As Boolean
		Private _almacenCollectionViaUsrAlmInvFisico As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaUsrAlmInvFisico, _alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _recepcionGanadoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
		Private _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _linea As LineaEntity
		Private _alwaysFetchLinea, _alreadyFetchedLinea, _lineaReturnsNewIfNotFound As Boolean
		Private _presentacion As PresentacionEntity
		Private _alwaysFetchPresentacion, _alreadyFetchedPresentacion, _presentacionReturnsNewIfNotFound As Boolean
		Private _tipoProducto As TipoProductoEntity
		Private _alwaysFetchTipoProducto, _alreadyFetchedTipoProducto, _tipoProductoReturnsNewIfNotFound As Boolean
		Private _unidadMedida As UnidadMedidaEntity
		Private _alwaysFetchUnidadMedida, _alreadyFetchedUnidadMedida, _unidadMedidaReturnsNewIfNotFound As Boolean
		Private _marca As MarcaEntity
		Private _alwaysFetchMarca, _alreadyFetchedMarca, _marcaReturnsNewIfNotFound As Boolean
		Private _cabMediReim As CabMediReimEntity
		Private _alwaysFetchCabMediReim, _alreadyFetchedCabMediReim, _cabMediReimReturnsNewIfNotFound As Boolean
		Private _cabMediTrab As CabMediTrabEntity
		Private _alwaysFetchCabMediTrab, _alreadyFetchedCabMediTrab, _cabMediTrabReturnsNewIfNotFound As Boolean
		Private _costoProducto As CostoProductoEntity
		Private _alwaysFetchCostoProducto, _alreadyFetchedCostoProducto, _costoProductoReturnsNewIfNotFound As Boolean

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
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <param name="validator">The custom validator Object for this ProductoEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_aplicMediDet = CType(info.GetValue("_aplicMediDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetCollection)
			_alwaysFetchAplicMediDet = info.GetBoolean("_alwaysFetchAplicMediDet")
			_alreadyFetchedAplicMediDet = info.GetBoolean("_alreadyFetchedAplicMediDet")
			_aplicMediDetDet = CType(info.GetValue("_aplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetDetCollection)
			_alwaysFetchAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetDet")
			_alreadyFetchedAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetDet")
			_cabPrepForm = CType(info.GetValue("_cabPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm = info.GetBoolean("_alwaysFetchCabPrepForm")
			_alreadyFetchedCabPrepForm = info.GetBoolean("_alreadyFetchedCabPrepForm")
			_cabPrepForm_ = CType(info.GetValue("_cabPrepForm_", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm_ = info.GetBoolean("_alwaysFetchCabPrepForm_")
			_alreadyFetchedCabPrepForm_ = info.GetBoolean("_alreadyFetchedCabPrepForm_")
			_detAlimentos = CType(info.GetValue("_detAlimentos", GetType(Integralab.ORM.CollectionClasses.DetAlimentosCollection)), Integralab.ORM.CollectionClasses.DetAlimentosCollection)
			_alwaysFetchDetAlimentos = info.GetBoolean("_alwaysFetchDetAlimentos")
			_alreadyFetchedDetAlimentos = info.GetBoolean("_alreadyFetchedDetAlimentos")
			_detalleKitPv = CType(info.GetValue("_detalleKitPv", GetType(Integralab.ORM.CollectionClasses.DetalleKitPvCollection)), Integralab.ORM.CollectionClasses.DetalleKitPvCollection)
			_alwaysFetchDetalleKitPv = info.GetBoolean("_alwaysFetchDetalleKitPv")
			_alreadyFetchedDetalleKitPv = info.GetBoolean("_alreadyFetchedDetalleKitPv")
			_detalleKitPv_ = CType(info.GetValue("_detalleKitPv_", GetType(Integralab.ORM.CollectionClasses.DetalleKitPvCollection)), Integralab.ORM.CollectionClasses.DetalleKitPvCollection)
			_alwaysFetchDetalleKitPv_ = info.GetBoolean("_alwaysFetchDetalleKitPv_")
			_alreadyFetchedDetalleKitPv_ = info.GetBoolean("_alreadyFetchedDetalleKitPv_")
			_detAplFor = CType(info.GetValue("_detAplFor", GetType(Integralab.ORM.CollectionClasses.DetAplForCollection)), Integralab.ORM.CollectionClasses.DetAplForCollection)
			_alwaysFetchDetAplFor = info.GetBoolean("_alwaysFetchDetAplFor")
			_alreadyFetchedDetAplFor = info.GetBoolean("_alreadyFetchedDetAplFor")
			_detDproMed = CType(info.GetValue("_detDproMed", GetType(Integralab.ORM.CollectionClasses.DetDproMedCollection)), Integralab.ORM.CollectionClasses.DetDproMedCollection)
			_alwaysFetchDetDproMed = info.GetBoolean("_alwaysFetchDetDproMed")
			_alreadyFetchedDetDproMed = info.GetBoolean("_alreadyFetchedDetDproMed")
			_detPrepForm = CType(info.GetValue("_detPrepForm", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepForm = info.GetBoolean("_alwaysFetchDetPrepForm")
			_alreadyFetchedDetPrepForm = info.GetBoolean("_alreadyFetchedDetPrepForm")
			_detPrepFormLote = CType(info.GetValue("_detPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)), Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)
			_alwaysFetchDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormLote")
			_alreadyFetchedDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormLote")
			_detProMed = CType(info.GetValue("_detProMed", GetType(Integralab.ORM.CollectionClasses.DetProMedCollection)), Integralab.ORM.CollectionClasses.DetProMedCollection)
			_alwaysFetchDetProMed = info.GetBoolean("_alwaysFetchDetProMed")
			_alreadyFetchedDetProMed = info.GetBoolean("_alreadyFetchedDetProMed")
			_invHistorialPv = CType(info.GetValue("_invHistorialPv", GetType(Integralab.ORM.CollectionClasses.InvHistorialPvCollection)), Integralab.ORM.CollectionClasses.InvHistorialPvCollection)
			_alwaysFetchInvHistorialPv = info.GetBoolean("_alwaysFetchInvHistorialPv")
			_alreadyFetchedInvHistorialPv = info.GetBoolean("_alreadyFetchedInvHistorialPv")
			_costoProductoProveedor = CType(info.GetValue("_costoProductoProveedor", GetType(Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection)), Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection)
			_alwaysFetchCostoProductoProveedor = info.GetBoolean("_alwaysFetchCostoProductoProveedor")
			_alreadyFetchedCostoProductoProveedor = info.GetBoolean("_alreadyFetchedCostoProductoProveedor")
			_productoCostoIndirecto = CType(info.GetValue("_productoCostoIndirecto", GetType(Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection)), Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection)
			_alwaysFetchProductoCostoIndirecto = info.GetBoolean("_alwaysFetchProductoCostoIndirecto")
			_alreadyFetchedProductoCostoIndirecto = info.GetBoolean("_alreadyFetchedProductoCostoIndirecto")
			_productoMezcla = CType(info.GetValue("_productoMezcla", GetType(Integralab.ORM.CollectionClasses.ProductoMezclaCollection)), Integralab.ORM.CollectionClasses.ProductoMezclaCollection)
			_alwaysFetchProductoMezcla = info.GetBoolean("_alwaysFetchProductoMezcla")
			_alreadyFetchedProductoMezcla = info.GetBoolean("_alreadyFetchedProductoMezcla")
			_productoMezcla_ = CType(info.GetValue("_productoMezcla_", GetType(Integralab.ORM.CollectionClasses.ProductoMezclaCollection)), Integralab.ORM.CollectionClasses.ProductoMezclaCollection)
			_alwaysFetchProductoMezcla_ = info.GetBoolean("_alwaysFetchProductoMezcla_")
			_alreadyFetchedProductoMezcla_ = info.GetBoolean("_alreadyFetchedProductoMezcla_")
			_listaPrecioDetalle = CType(info.GetValue("_listaPrecioDetalle", GetType(Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection)), Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection)
			_alwaysFetchListaPrecioDetalle = info.GetBoolean("_alwaysFetchListaPrecioDetalle")
			_alreadyFetchedListaPrecioDetalle = info.GetBoolean("_alreadyFetchedListaPrecioDetalle")
			_mcecatLotesCabFor = CType(info.GetValue("_mcecatLotesCabFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabForCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabForCollection)
			_alwaysFetchMcecatLotesCabFor = info.GetBoolean("_alwaysFetchMcecatLotesCabFor")
			_alreadyFetchedMcecatLotesCabFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabFor")
			_mcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorDetalle")
			_ordenCompraDetalle = CType(info.GetValue("_ordenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)), Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)
			_alwaysFetchOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraDetalle")
			_mcomPresupuestoDetalle = CType(info.GetValue("_mcomPresupuestoDetalle", GetType(Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection)), Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection)
			_alwaysFetchMcomPresupuestoDetalle = info.GetBoolean("_alwaysFetchMcomPresupuestoDetalle")
			_alreadyFetchedMcomPresupuestoDetalle = info.GetBoolean("_alreadyFetchedMcomPresupuestoDetalle")
			_mcomRecepcionOrdenCompraDet = CType(info.GetValue("_mcomRecepcionOrdenCompraDet", GetType(Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection)), Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection)
			_alwaysFetchMcomRecepcionOrdenCompraDet = info.GetBoolean("_alwaysFetchMcomRecepcionOrdenCompraDet")
			_alreadyFetchedMcomRecepcionOrdenCompraDet = info.GetBoolean("_alreadyFetchedMcomRecepcionOrdenCompraDet")
			_solicitudProductoDetalle = CType(info.GetValue("_solicitudProductoDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalle")
			_alreadyFetchedSolicitudProductoDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalle")
			_inventarioAlmacen = CType(info.GetValue("_inventarioAlmacen", GetType(Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)
			_alwaysFetchInventarioAlmacen = info.GetBoolean("_alwaysFetchInventarioAlmacen")
			_alreadyFetchedInventarioAlmacen = info.GetBoolean("_alreadyFetchedInventarioAlmacen")
			_inventarioAlmacenLotes = CType(info.GetValue("_inventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)), Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)
			_alwaysFetchInventarioAlmacenLotes = info.GetBoolean("_alwaysFetchInventarioAlmacenLotes")
			_alreadyFetchedInventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedInventarioAlmacenLotes")
			_inventarioMovimientosAlmacenDetalles = CType(info.GetValue("_inventarioMovimientosAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)
			_alwaysFetchInventarioMovimientosAlmacenDetalles = info.GetBoolean("_alwaysFetchInventarioMovimientosAlmacenDetalles")
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = info.GetBoolean("_alreadyFetchedInventarioMovimientosAlmacenDetalles")
			_minvMovimientosAlmacenPvdetalles = CType(info.GetValue("_minvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPvdetalles")
			_minvTransferenciaAlmacenEntradaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenEntradaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle")
			_minvTransferenciaAlmacenSalidaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenSalidaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle")
			_mventaNotaVentaDetalle = CType(info.GetValue("_mventaNotaVentaDetalle", GetType(Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection)), Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection)
			_alwaysFetchMventaNotaVentaDetalle = info.GetBoolean("_alwaysFetchMventaNotaVentaDetalle")
			_alreadyFetchedMventaNotaVentaDetalle = info.GetBoolean("_alreadyFetchedMventaNotaVentaDetalle")
			_usrAlmInvFisico = CType(info.GetValue("_usrAlmInvFisico", GetType(Integralab.ORM.CollectionClasses.InventarioFisicoCollection)), Integralab.ORM.CollectionClasses.InventarioFisicoCollection)
			_alwaysFetchUsrAlmInvFisico = info.GetBoolean("_alwaysFetchUsrAlmInvFisico")
			_alreadyFetchedUsrAlmInvFisico = info.GetBoolean("_alreadyFetchedUsrAlmInvFisico")
			_usrProdRecepcionDetalle = CType(info.GetValue("_usrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)
			_alwaysFetchUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchUsrProdRecepcionDetalle")
			_alreadyFetchedUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedUsrProdRecepcionDetalle")
			_aplicMediCollectionViaAplicMediDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDet")
			_mcecatCorralesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet")
			_mcecatLotesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet")
			_aplicMediCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet")
			_aplicMediDetCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediDetCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetCollection)
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet")
			_mcecatCorralesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet")
			_mcecatLotesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet")
			_almacenCollectionViaCabPrepForm = CType(info.GetValue("_almacenCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm")
			_almacenCollectionViaCabPrepForm_ = CType(info.GetValue("_almacenCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm_")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm_")
			_plazaCollectionViaCabPrepForm = CType(info.GetValue("_plazaCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm")
			_alreadyFetchedPlazaCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm__", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm___", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___")
			_plazaCollectionViaCabPrepForm_ = CType(info.GetValue("_plazaCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm_")
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm_")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm____ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm____", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm______ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm______", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______")
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______")
			_catNutrientesCollectionViaDetAlimentos = CType(info.GetValue("_catNutrientesCollectionViaDetAlimentos", GetType(Integralab.ORM.CollectionClasses.CatNutrientesCollection)), Integralab.ORM.CollectionClasses.CatNutrientesCollection)
			_alwaysFetchCatNutrientesCollectionViaDetAlimentos = info.GetBoolean("_alwaysFetchCatNutrientesCollectionViaDetAlimentos")
			_alreadyFetchedCatNutrientesCollectionViaDetAlimentos = info.GetBoolean("_alreadyFetchedCatNutrientesCollectionViaDetAlimentos")
			_cabAplForCollectionViaDetAplFor = CType(info.GetValue("_cabAplForCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplForCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchCabAplForCollectionViaDetAplFor")
			_alreadyFetchedCabAplForCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedCabAplForCollectionViaDetAplFor")
			_mcecatCorralesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatCorralesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor")
			_mcecatLotesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatLotesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor")
			_cabProMedCollectionViaDetDproMed = CType(info.GetValue("_cabProMedCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.CabProMedCollection)), Integralab.ORM.CollectionClasses.CabProMedCollection)
			_alwaysFetchCabProMedCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchCabProMedCollectionViaDetDproMed")
			_alreadyFetchedCabProMedCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedCabProMedCollectionViaDetDproMed")
			_detProMedCollectionViaDetDproMed = CType(info.GetValue("_detProMedCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.DetProMedCollection)), Integralab.ORM.CollectionClasses.DetProMedCollection)
			_alwaysFetchDetProMedCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchDetProMedCollectionViaDetDproMed")
			_alreadyFetchedDetProMedCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedDetProMedCollectionViaDetDproMed")
			_mcecatLotesCabCollectionViaDetDproMed = CType(info.GetValue("_mcecatLotesCabCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaDetDproMed")
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed")
			_cabPrepFormCollectionViaDetPrepForm = CType(info.GetValue("_cabPrepFormCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepFormCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchCabPrepFormCollectionViaDetPrepForm")
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedCabPrepFormCollectionViaDetPrepForm")
			_plazaCollectionViaDetPrepForm = CType(info.GetValue("_plazaCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchPlazaCollectionViaDetPrepForm")
			_alreadyFetchedPlazaCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedPlazaCollectionViaDetPrepForm")
			_cabPrepFormCollectionViaDetPrepFormLote = CType(info.GetValue("_cabPrepFormCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote")
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote")
			_detPrepFormCollectionViaDetPrepFormLote = CType(info.GetValue("_detPrepFormCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote")
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote")
			_plazaCollectionViaDetPrepFormLote = CType(info.GetValue("_plazaCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchPlazaCollectionViaDetPrepFormLote")
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedPlazaCollectionViaDetPrepFormLote")
			_cabProMedCollectionViaDetProMed = CType(info.GetValue("_cabProMedCollectionViaDetProMed", GetType(Integralab.ORM.CollectionClasses.CabProMedCollection)), Integralab.ORM.CollectionClasses.CabProMedCollection)
			_alwaysFetchCabProMedCollectionViaDetProMed = info.GetBoolean("_alwaysFetchCabProMedCollectionViaDetProMed")
			_alreadyFetchedCabProMedCollectionViaDetProMed = info.GetBoolean("_alreadyFetchedCabProMedCollectionViaDetProMed")
			_almacenCollectionViaInvHistorialPv = CType(info.GetValue("_almacenCollectionViaInvHistorialPv", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaInvHistorialPv = info.GetBoolean("_alwaysFetchAlmacenCollectionViaInvHistorialPv")
			_alreadyFetchedAlmacenCollectionViaInvHistorialPv = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaInvHistorialPv")
			_proveedorCollectionViaCostoProductoProveedor = CType(info.GetValue("_proveedorCollectionViaCostoProductoProveedor", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCostoProductoProveedor = info.GetBoolean("_alwaysFetchProveedorCollectionViaCostoProductoProveedor")
			_alreadyFetchedProveedorCollectionViaCostoProductoProveedor = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCostoProductoProveedor")
			_costoIndirectoCollectionViaProductoCostoIndirecto = CType(info.GetValue("_costoIndirectoCollectionViaProductoCostoIndirecto", GetType(Integralab.ORM.CollectionClasses.CostoIndirectoCollection)), Integralab.ORM.CollectionClasses.CostoIndirectoCollection)
			_alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto = info.GetBoolean("_alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto")
			_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto = info.GetBoolean("_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto")
			_listaPrecioCollectionViaListaPrecioDetalle = CType(info.GetValue("_listaPrecioCollectionViaListaPrecioDetalle", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecioCollectionViaListaPrecioDetalle = info.GetBoolean("_alwaysFetchListaPrecioCollectionViaListaPrecioDetalle")
			_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle = info.GetBoolean("_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle")
			_mcecatLotesCabCollectionViaMcecatLotesCabFor = CType(info.GetValue("_mcecatLotesCabCollectionViaMcecatLotesCabFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor")
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor")
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection)
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaOrdenCompraDetalle = CType(info.GetValue("_tipoMonedaCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle")
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle")
			_cotizacionCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle")
			_ordenCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_ordenCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle")
			_solicitudProductoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_solicitudProductoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle")
			_mcomPresupuestoCollectionViaMcomPresupuestoDetalle = CType(info.GetValue("_mcomPresupuestoCollectionViaMcomPresupuestoDetalle", GetType(Integralab.ORM.CollectionClasses.PresupuestoCollection)), Integralab.ORM.CollectionClasses.PresupuestoCollection)
			_alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle = info.GetBoolean("_alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle")
			_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle = info.GetBoolean("_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle")
			_solicitudProductoCollectionViaSolicitudProductoDetalle = CType(info.GetValue("_solicitudProductoCollectionViaSolicitudProductoDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle")
			_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle")
			_almacenCollectionViaInventarioAlmacen = CType(info.GetValue("_almacenCollectionViaInventarioAlmacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaInventarioAlmacen = info.GetBoolean("_alwaysFetchAlmacenCollectionViaInventarioAlmacen")
			_alreadyFetchedAlmacenCollectionViaInventarioAlmacen = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaInventarioAlmacen")
			_almacenCollectionViainventarioAlmacenLotes = CType(info.GetValue("_almacenCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes")
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes")
			_inventarioAlmacenCollectionViainventarioAlmacenLotes = CType(info.GetValue("_inventarioAlmacenCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)
			_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes")
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes")
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles = CType(info.GetValue("_almacenCollectionViaInventarioMovimientoAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = CType(info.GetValue("_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = info.GetBoolean("_alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles")
			_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = info.GetBoolean("_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles")
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_almacenCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles")
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)
			_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles")
			_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle")
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle")
			_mventaNotasVentaCollectionViaMventaNotaVentaDetalle = CType(info.GetValue("_mventaNotasVentaCollectionViaMventaNotaVentaDetalle", GetType(Integralab.ORM.CollectionClasses.NotaVentaCollection)), Integralab.ORM.CollectionClasses.NotaVentaCollection)
			_alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle = info.GetBoolean("_alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle")
			_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle = info.GetBoolean("_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle")
			_almacenCollectionViaUsrAlmInvFisico = CType(info.GetValue("_almacenCollectionViaUsrAlmInvFisico", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaUsrAlmInvFisico = info.GetBoolean("_alwaysFetchAlmacenCollectionViaUsrAlmInvFisico")
			_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico")
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_recepcionGanadoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)), Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle")
			_linea = CType(info.GetValue("_linea", GetType(LineaEntity)), LineaEntity)
			If Not _linea Is Nothing Then
				AddHandler _linea.AfterSave, AddressOf OnEntityAfterSave
			End If
			_lineaReturnsNewIfNotFound = info.GetBoolean("_lineaReturnsNewIfNotFound")
			_alwaysFetchLinea = info.GetBoolean("_alwaysFetchLinea")
			_alreadyFetchedLinea = info.GetBoolean("_alreadyFetchedLinea")
			_presentacion = CType(info.GetValue("_presentacion", GetType(PresentacionEntity)), PresentacionEntity)
			If Not _presentacion Is Nothing Then
				AddHandler _presentacion.AfterSave, AddressOf OnEntityAfterSave
			End If
			_presentacionReturnsNewIfNotFound = info.GetBoolean("_presentacionReturnsNewIfNotFound")
			_alwaysFetchPresentacion = info.GetBoolean("_alwaysFetchPresentacion")
			_alreadyFetchedPresentacion = info.GetBoolean("_alreadyFetchedPresentacion")
			_tipoProducto = CType(info.GetValue("_tipoProducto", GetType(TipoProductoEntity)), TipoProductoEntity)
			If Not _tipoProducto Is Nothing Then
				AddHandler _tipoProducto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoProductoReturnsNewIfNotFound = info.GetBoolean("_tipoProductoReturnsNewIfNotFound")
			_alwaysFetchTipoProducto = info.GetBoolean("_alwaysFetchTipoProducto")
			_alreadyFetchedTipoProducto = info.GetBoolean("_alreadyFetchedTipoProducto")
			_unidadMedida = CType(info.GetValue("_unidadMedida", GetType(UnidadMedidaEntity)), UnidadMedidaEntity)
			If Not _unidadMedida Is Nothing Then
				AddHandler _unidadMedida.AfterSave, AddressOf OnEntityAfterSave
			End If
			_unidadMedidaReturnsNewIfNotFound = info.GetBoolean("_unidadMedidaReturnsNewIfNotFound")
			_alwaysFetchUnidadMedida = info.GetBoolean("_alwaysFetchUnidadMedida")
			_alreadyFetchedUnidadMedida = info.GetBoolean("_alreadyFetchedUnidadMedida")
			_marca = CType(info.GetValue("_marca", GetType(MarcaEntity)), MarcaEntity)
			If Not _marca Is Nothing Then
				AddHandler _marca.AfterSave, AddressOf OnEntityAfterSave
			End If
			_marcaReturnsNewIfNotFound = info.GetBoolean("_marcaReturnsNewIfNotFound")
			_alwaysFetchMarca = info.GetBoolean("_alwaysFetchMarca")
			_alreadyFetchedMarca = info.GetBoolean("_alreadyFetchedMarca")
			_cabMediReim = CType(info.GetValue("_cabMediReim", GetType(CabMediReimEntity)), CabMediReimEntity)
			If Not _cabMediReim Is Nothing Then
				' rewire event handler.
				AddHandler _cabMediReim.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabMediReimReturnsNewIfNotFound = info.GetBoolean("_cabMediReimReturnsNewIfNotFound")
			_alwaysFetchCabMediReim = info.GetBoolean("_alwaysFetchCabMediReim")
			_alreadyFetchedCabMediReim = info.GetBoolean("_alreadyFetchedCabMediReim")
			_cabMediTrab = CType(info.GetValue("_cabMediTrab", GetType(CabMediTrabEntity)), CabMediTrabEntity)
			If Not _cabMediTrab Is Nothing Then
				' rewire event handler.
				AddHandler _cabMediTrab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabMediTrabReturnsNewIfNotFound = info.GetBoolean("_cabMediTrabReturnsNewIfNotFound")
			_alwaysFetchCabMediTrab = info.GetBoolean("_alwaysFetchCabMediTrab")
			_alreadyFetchedCabMediTrab = info.GetBoolean("_alreadyFetchedCabMediTrab")
			_costoProducto = CType(info.GetValue("_costoProducto", GetType(CostoProductoEntity)), CostoProductoEntity)
			If Not _costoProducto Is Nothing Then
				' rewire event handler.
				AddHandler _costoProducto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_costoProductoReturnsNewIfNotFound = info.GetBoolean("_costoProductoReturnsNewIfNotFound")
			_alwaysFetchCostoProducto = info.GetBoolean("_alwaysFetchCostoProducto")
			_alreadyFetchedCostoProducto = info.GetBoolean("_alreadyFetchedCostoProducto")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMediDet = (_aplicMediDet.Count > 0)
			_alreadyFetchedAplicMediDetDet = (_aplicMediDetDet.Count > 0)
			_alreadyFetchedCabPrepForm = (_cabPrepForm.Count > 0)
			_alreadyFetchedCabPrepForm_ = (_cabPrepForm_.Count > 0)
			_alreadyFetchedDetAlimentos = (_detAlimentos.Count > 0)
			_alreadyFetchedDetalleKitPv = (_detalleKitPv.Count > 0)
			_alreadyFetchedDetalleKitPv_ = (_detalleKitPv_.Count > 0)
			_alreadyFetchedDetAplFor = (_detAplFor.Count > 0)
			_alreadyFetchedDetDproMed = (_detDproMed.Count > 0)
			_alreadyFetchedDetPrepForm = (_detPrepForm.Count > 0)
			_alreadyFetchedDetPrepFormLote = (_detPrepFormLote.Count > 0)
			_alreadyFetchedDetProMed = (_detProMed.Count > 0)
			_alreadyFetchedInvHistorialPv = (_invHistorialPv.Count > 0)
			_alreadyFetchedCostoProductoProveedor = (_costoProductoProveedor.Count > 0)
			_alreadyFetchedProductoCostoIndirecto = (_productoCostoIndirecto.Count > 0)
			_alreadyFetchedProductoMezcla = (_productoMezcla.Count > 0)
			_alreadyFetchedProductoMezcla_ = (_productoMezcla_.Count > 0)
			_alreadyFetchedListaPrecioDetalle = (_listaPrecioDetalle.Count > 0)
			_alreadyFetchedMcecatLotesCabFor = (_mcecatLotesCabFor.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedOrdenCompraDetalle = (_ordenCompraDetalle.Count > 0)
			_alreadyFetchedMcomPresupuestoDetalle = (_mcomPresupuestoDetalle.Count > 0)
			_alreadyFetchedMcomRecepcionOrdenCompraDet = (_mcomRecepcionOrdenCompraDet.Count > 0)
			_alreadyFetchedSolicitudProductoDetalle = (_solicitudProductoDetalle.Count > 0)
			_alreadyFetchedInventarioAlmacen = (_inventarioAlmacen.Count > 0)
			_alreadyFetchedInventarioAlmacenLotes = (_inventarioAlmacenLotes.Count > 0)
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = (_inventarioMovimientosAlmacenDetalles.Count > 0)
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = (_minvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = (_minvTransferenciaAlmacenEntradaDetalle.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = (_minvTransferenciaAlmacenSalidaDetalle.Count > 0)
			_alreadyFetchedMventaNotaVentaDetalle = (_mventaNotaVentaDetalle.Count > 0)
			_alreadyFetchedUsrAlmInvFisico = (_usrAlmInvFisico.Count > 0)
			_alreadyFetchedUsrProdRecepcionDetalle = (_usrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = (_aplicMediCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = (_mcecatCorralesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = (_mcecatLotesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = (_aplicMediCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = (_aplicMediDetCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = (_mcecatCorralesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = (_mcecatLotesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = (_almacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = (_almacenCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm = (_plazaCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = (_plazaCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.Count > 0)
			_alreadyFetchedCatNutrientesCollectionViaDetAlimentos = (_catNutrientesCollectionViaDetAlimentos.Count > 0)
			_alreadyFetchedCabAplForCollectionViaDetAplFor = (_cabAplForCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = (_mcecatCorralesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = (_mcecatLotesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedCabProMedCollectionViaDetDproMed = (_cabProMedCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedDetProMedCollectionViaDetDproMed = (_detProMedCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = (_mcecatLotesCabCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = (_cabPrepFormCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedPlazaCollectionViaDetPrepForm = (_plazaCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = (_cabPrepFormCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = (_detPrepFormCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = (_plazaCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedCabProMedCollectionViaDetProMed = (_cabProMedCollectionViaDetProMed.Count > 0)
			_alreadyFetchedAlmacenCollectionViaInvHistorialPv = (_almacenCollectionViaInvHistorialPv.Count > 0)
			_alreadyFetchedProveedorCollectionViaCostoProductoProveedor = (_proveedorCollectionViaCostoProductoProveedor.Count > 0)
			_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto = (_costoIndirectoCollectionViaProductoCostoIndirecto.Count > 0)
			_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle = (_listaPrecioCollectionViaListaPrecioDetalle.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor = (_mcecatLotesCabCollectionViaMcecatLotesCabFor.Count > 0)
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = (_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = (_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = (_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = (_tipoMonedaCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = (_cotizacionCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = (_ordenCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = (_solicitudProductoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle = (_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle = (_solicitudProductoCollectionViaSolicitudProductoDetalle.Count > 0)
			_alreadyFetchedAlmacenCollectionViaInventarioAlmacen = (_almacenCollectionViaInventarioAlmacen.Count > 0)
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = (_almacenCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = (_inventarioAlmacenCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = (_almacenCollectionViaInventarioMovimientoAlmacenDetalles.Count > 0)
			_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = (_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = (_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = (_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = (_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = (_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.Count > 0)
			_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle = (_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.Count > 0)
			_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico = (_almacenCollectionViaUsrAlmInvFisico.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = (_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = (_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedLinea = Not(_linea Is Nothing)
			_alreadyFetchedPresentacion = Not(_presentacion Is Nothing)
			_alreadyFetchedTipoProducto = Not(_tipoProducto Is Nothing)
			_alreadyFetchedUnidadMedida = Not(_unidadMedida Is Nothing)
			_alreadyFetchedMarca = Not(_marca Is Nothing)
			_alreadyFetchedCabMediReim = Not(_cabMediReim Is Nothing)
			_alreadyFetchedCabMediTrab = Not(_cabMediTrab Is Nothing)
			_alreadyFetchedCostoProducto = Not(_costoProducto Is Nothing)
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
			info.AddValue("_aplicMediDet", _aplicMediDet)
			info.AddValue("_alwaysFetchAplicMediDet", _alwaysFetchAplicMediDet)
			info.AddValue("_alreadyFetchedAplicMediDet", _alreadyFetchedAplicMediDet)
			info.AddValue("_aplicMediDetDet", _aplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetDet", _alwaysFetchAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetDet", _alreadyFetchedAplicMediDetDet)
			info.AddValue("_cabPrepForm", _cabPrepForm)
			info.AddValue("_alwaysFetchCabPrepForm", _alwaysFetchCabPrepForm)
			info.AddValue("_alreadyFetchedCabPrepForm", _alreadyFetchedCabPrepForm)
			info.AddValue("_cabPrepForm_", _cabPrepForm_)
			info.AddValue("_alwaysFetchCabPrepForm_", _alwaysFetchCabPrepForm_)
			info.AddValue("_alreadyFetchedCabPrepForm_", _alreadyFetchedCabPrepForm_)
			info.AddValue("_detAlimentos", _detAlimentos)
			info.AddValue("_alwaysFetchDetAlimentos", _alwaysFetchDetAlimentos)
			info.AddValue("_alreadyFetchedDetAlimentos", _alreadyFetchedDetAlimentos)
			info.AddValue("_detalleKitPv", _detalleKitPv)
			info.AddValue("_alwaysFetchDetalleKitPv", _alwaysFetchDetalleKitPv)
			info.AddValue("_alreadyFetchedDetalleKitPv", _alreadyFetchedDetalleKitPv)
			info.AddValue("_detalleKitPv_", _detalleKitPv_)
			info.AddValue("_alwaysFetchDetalleKitPv_", _alwaysFetchDetalleKitPv_)
			info.AddValue("_alreadyFetchedDetalleKitPv_", _alreadyFetchedDetalleKitPv_)
			info.AddValue("_detAplFor", _detAplFor)
			info.AddValue("_alwaysFetchDetAplFor", _alwaysFetchDetAplFor)
			info.AddValue("_alreadyFetchedDetAplFor", _alreadyFetchedDetAplFor)
			info.AddValue("_detDproMed", _detDproMed)
			info.AddValue("_alwaysFetchDetDproMed", _alwaysFetchDetDproMed)
			info.AddValue("_alreadyFetchedDetDproMed", _alreadyFetchedDetDproMed)
			info.AddValue("_detPrepForm", _detPrepForm)
			info.AddValue("_alwaysFetchDetPrepForm", _alwaysFetchDetPrepForm)
			info.AddValue("_alreadyFetchedDetPrepForm", _alreadyFetchedDetPrepForm)
			info.AddValue("_detPrepFormLote", _detPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormLote", _alwaysFetchDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormLote", _alreadyFetchedDetPrepFormLote)
			info.AddValue("_detProMed", _detProMed)
			info.AddValue("_alwaysFetchDetProMed", _alwaysFetchDetProMed)
			info.AddValue("_alreadyFetchedDetProMed", _alreadyFetchedDetProMed)
			info.AddValue("_invHistorialPv", _invHistorialPv)
			info.AddValue("_alwaysFetchInvHistorialPv", _alwaysFetchInvHistorialPv)
			info.AddValue("_alreadyFetchedInvHistorialPv", _alreadyFetchedInvHistorialPv)
			info.AddValue("_costoProductoProveedor", _costoProductoProveedor)
			info.AddValue("_alwaysFetchCostoProductoProveedor", _alwaysFetchCostoProductoProveedor)
			info.AddValue("_alreadyFetchedCostoProductoProveedor", _alreadyFetchedCostoProductoProveedor)
			info.AddValue("_productoCostoIndirecto", _productoCostoIndirecto)
			info.AddValue("_alwaysFetchProductoCostoIndirecto", _alwaysFetchProductoCostoIndirecto)
			info.AddValue("_alreadyFetchedProductoCostoIndirecto", _alreadyFetchedProductoCostoIndirecto)
			info.AddValue("_productoMezcla", _productoMezcla)
			info.AddValue("_alwaysFetchProductoMezcla", _alwaysFetchProductoMezcla)
			info.AddValue("_alreadyFetchedProductoMezcla", _alreadyFetchedProductoMezcla)
			info.AddValue("_productoMezcla_", _productoMezcla_)
			info.AddValue("_alwaysFetchProductoMezcla_", _alwaysFetchProductoMezcla_)
			info.AddValue("_alreadyFetchedProductoMezcla_", _alreadyFetchedProductoMezcla_)
			info.AddValue("_listaPrecioDetalle", _listaPrecioDetalle)
			info.AddValue("_alwaysFetchListaPrecioDetalle", _alwaysFetchListaPrecioDetalle)
			info.AddValue("_alreadyFetchedListaPrecioDetalle", _alreadyFetchedListaPrecioDetalle)
			info.AddValue("_mcecatLotesCabFor", _mcecatLotesCabFor)
			info.AddValue("_alwaysFetchMcecatLotesCabFor", _alwaysFetchMcecatLotesCabFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabFor", _alreadyFetchedMcecatLotesCabFor)
			info.AddValue("_mcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_ordenCompraDetalle", _ordenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraDetalle", _alwaysFetchOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraDetalle", _alreadyFetchedOrdenCompraDetalle)
			info.AddValue("_mcomPresupuestoDetalle", _mcomPresupuestoDetalle)
			info.AddValue("_alwaysFetchMcomPresupuestoDetalle", _alwaysFetchMcomPresupuestoDetalle)
			info.AddValue("_alreadyFetchedMcomPresupuestoDetalle", _alreadyFetchedMcomPresupuestoDetalle)
			info.AddValue("_mcomRecepcionOrdenCompraDet", _mcomRecepcionOrdenCompraDet)
			info.AddValue("_alwaysFetchMcomRecepcionOrdenCompraDet", _alwaysFetchMcomRecepcionOrdenCompraDet)
			info.AddValue("_alreadyFetchedMcomRecepcionOrdenCompraDet", _alreadyFetchedMcomRecepcionOrdenCompraDet)
			info.AddValue("_solicitudProductoDetalle", _solicitudProductoDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalle", _alwaysFetchSolicitudProductoDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalle", _alreadyFetchedSolicitudProductoDetalle)
			info.AddValue("_inventarioAlmacen", _inventarioAlmacen)
			info.AddValue("_alwaysFetchInventarioAlmacen", _alwaysFetchInventarioAlmacen)
			info.AddValue("_alreadyFetchedInventarioAlmacen", _alreadyFetchedInventarioAlmacen)
			info.AddValue("_inventarioAlmacenLotes", _inventarioAlmacenLotes)
			info.AddValue("_alwaysFetchInventarioAlmacenLotes", _alwaysFetchInventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedInventarioAlmacenLotes", _alreadyFetchedInventarioAlmacenLotes)
			info.AddValue("_inventarioMovimientosAlmacenDetalles", _inventarioMovimientosAlmacenDetalles)
			info.AddValue("_alwaysFetchInventarioMovimientosAlmacenDetalles", _alwaysFetchInventarioMovimientosAlmacenDetalles)
			info.AddValue("_alreadyFetchedInventarioMovimientosAlmacenDetalles", _alreadyFetchedInventarioMovimientosAlmacenDetalles)
			info.AddValue("_minvMovimientosAlmacenPvdetalles", _minvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPvdetalles", _alwaysFetchMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPvdetalles", _alreadyFetchedMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_minvTransferenciaAlmacenEntradaDetalle", _minvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle", _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle", _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_minvTransferenciaAlmacenSalidaDetalle", _minvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle", _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle", _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_mventaNotaVentaDetalle", _mventaNotaVentaDetalle)
			info.AddValue("_alwaysFetchMventaNotaVentaDetalle", _alwaysFetchMventaNotaVentaDetalle)
			info.AddValue("_alreadyFetchedMventaNotaVentaDetalle", _alreadyFetchedMventaNotaVentaDetalle)
			info.AddValue("_usrAlmInvFisico", _usrAlmInvFisico)
			info.AddValue("_alwaysFetchUsrAlmInvFisico", _alwaysFetchUsrAlmInvFisico)
			info.AddValue("_alreadyFetchedUsrAlmInvFisico", _alreadyFetchedUsrAlmInvFisico)
			info.AddValue("_usrProdRecepcionDetalle", _usrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchUsrProdRecepcionDetalle", _alwaysFetchUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedUsrProdRecepcionDetalle", _alreadyFetchedUsrProdRecepcionDetalle)
			info.AddValue("_aplicMediCollectionViaAplicMediDet", _aplicMediCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDet", _alwaysFetchAplicMediCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDet", _alreadyFetchedAplicMediCollectionViaAplicMediDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDet", _mcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDet", _mcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_aplicMediCollectionViaAplicMediDetDet", _aplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDetDet", _alwaysFetchAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_aplicMediDetCollectionViaAplicMediDetDet", _aplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet", _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", _mcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDetDet", _mcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_almacenCollectionViaCabPrepForm", _almacenCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm", _alwaysFetchAlmacenCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm", _alreadyFetchedAlmacenCollectionViaCabPrepForm)
			info.AddValue("_almacenCollectionViaCabPrepForm_", _almacenCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm_", _alwaysFetchAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm_", _alreadyFetchedAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_plazaCollectionViaCabPrepForm", _plazaCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm", _alwaysFetchPlazaCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm", _alreadyFetchedPlazaCollectionViaCabPrepForm)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm", _inventarioMovimientoAlmacenCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_", _inventarioMovimientoAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm__", _inventarioMovimientoAlmacenCollectionViaCabPrepForm__)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm___", _inventarioMovimientoAlmacenCollectionViaCabPrepForm___)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___)
			info.AddValue("_plazaCollectionViaCabPrepForm_", _plazaCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm_", _alwaysFetchPlazaCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm_", _alreadyFetchedPlazaCollectionViaCabPrepForm_)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm____", _inventarioMovimientoAlmacenCollectionViaCabPrepForm____)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____", _inventarioMovimientoAlmacenCollectionViaCabPrepForm_____)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm______", _inventarioMovimientoAlmacenCollectionViaCabPrepForm______)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______", _inventarioMovimientoAlmacenCollectionViaCabPrepForm_______)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______)
			info.AddValue("_catNutrientesCollectionViaDetAlimentos", _catNutrientesCollectionViaDetAlimentos)
			info.AddValue("_alwaysFetchCatNutrientesCollectionViaDetAlimentos", _alwaysFetchCatNutrientesCollectionViaDetAlimentos)
			info.AddValue("_alreadyFetchedCatNutrientesCollectionViaDetAlimentos", _alreadyFetchedCatNutrientesCollectionViaDetAlimentos)
			info.AddValue("_cabAplForCollectionViaDetAplFor", _cabAplForCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchCabAplForCollectionViaDetAplFor", _alwaysFetchCabAplForCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedCabAplForCollectionViaDetAplFor", _alreadyFetchedCabAplForCollectionViaDetAplFor)
			info.AddValue("_mcecatCorralesCabCollectionViaDetAplFor", _mcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor", _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor", _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_mcecatLotesCabCollectionViaDetAplFor", _mcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor", _alwaysFetchMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor", _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_cabProMedCollectionViaDetDproMed", _cabProMedCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchCabProMedCollectionViaDetDproMed", _alwaysFetchCabProMedCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedCabProMedCollectionViaDetDproMed", _alreadyFetchedCabProMedCollectionViaDetDproMed)
			info.AddValue("_detProMedCollectionViaDetDproMed", _detProMedCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchDetProMedCollectionViaDetDproMed", _alwaysFetchDetProMedCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedDetProMedCollectionViaDetDproMed", _alreadyFetchedDetProMedCollectionViaDetDproMed)
			info.AddValue("_mcecatLotesCabCollectionViaDetDproMed", _mcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaDetDproMed", _alwaysFetchMcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed", _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_cabPrepFormCollectionViaDetPrepForm", _cabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchCabPrepFormCollectionViaDetPrepForm", _alwaysFetchCabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedCabPrepFormCollectionViaDetPrepForm", _alreadyFetchedCabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_plazaCollectionViaDetPrepForm", _plazaCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchPlazaCollectionViaDetPrepForm", _alwaysFetchPlazaCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedPlazaCollectionViaDetPrepForm", _alreadyFetchedPlazaCollectionViaDetPrepForm)
			info.AddValue("_cabPrepFormCollectionViaDetPrepFormLote", _cabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote", _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote", _alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_detPrepFormCollectionViaDetPrepFormLote", _detPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote", _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote", _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_plazaCollectionViaDetPrepFormLote", _plazaCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchPlazaCollectionViaDetPrepFormLote", _alwaysFetchPlazaCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedPlazaCollectionViaDetPrepFormLote", _alreadyFetchedPlazaCollectionViaDetPrepFormLote)
			info.AddValue("_cabProMedCollectionViaDetProMed", _cabProMedCollectionViaDetProMed)
			info.AddValue("_alwaysFetchCabProMedCollectionViaDetProMed", _alwaysFetchCabProMedCollectionViaDetProMed)
			info.AddValue("_alreadyFetchedCabProMedCollectionViaDetProMed", _alreadyFetchedCabProMedCollectionViaDetProMed)
			info.AddValue("_almacenCollectionViaInvHistorialPv", _almacenCollectionViaInvHistorialPv)
			info.AddValue("_alwaysFetchAlmacenCollectionViaInvHistorialPv", _alwaysFetchAlmacenCollectionViaInvHistorialPv)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaInvHistorialPv", _alreadyFetchedAlmacenCollectionViaInvHistorialPv)
			info.AddValue("_proveedorCollectionViaCostoProductoProveedor", _proveedorCollectionViaCostoProductoProveedor)
			info.AddValue("_alwaysFetchProveedorCollectionViaCostoProductoProveedor", _alwaysFetchProveedorCollectionViaCostoProductoProveedor)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCostoProductoProveedor", _alreadyFetchedProveedorCollectionViaCostoProductoProveedor)
			info.AddValue("_costoIndirectoCollectionViaProductoCostoIndirecto", _costoIndirectoCollectionViaProductoCostoIndirecto)
			info.AddValue("_alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto", _alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto)
			info.AddValue("_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto", _alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto)
			info.AddValue("_listaPrecioCollectionViaListaPrecioDetalle", _listaPrecioCollectionViaListaPrecioDetalle)
			info.AddValue("_alwaysFetchListaPrecioCollectionViaListaPrecioDetalle", _alwaysFetchListaPrecioCollectionViaListaPrecioDetalle)
			info.AddValue("_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle", _alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle)
			info.AddValue("_mcecatLotesCabCollectionViaMcecatLotesCabFor", _mcecatLotesCabCollectionViaMcecatLotesCabFor)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor", _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor", _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor)
			info.AddValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaOrdenCompraDetalle", _tipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle", _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle", _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", _cotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle", _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_ordenCompraCollectionViaOrdenCompraDetalle", _ordenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle", _alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_solicitudProductoCollectionViaOrdenCompraDetalle", _solicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle", _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_mcomPresupuestoCollectionViaMcomPresupuestoDetalle", _mcomPresupuestoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle", _alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle", _alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_solicitudProductoCollectionViaSolicitudProductoDetalle", _solicitudProductoCollectionViaSolicitudProductoDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle", _alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle", _alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle)
			info.AddValue("_almacenCollectionViaInventarioAlmacen", _almacenCollectionViaInventarioAlmacen)
			info.AddValue("_alwaysFetchAlmacenCollectionViaInventarioAlmacen", _alwaysFetchAlmacenCollectionViaInventarioAlmacen)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaInventarioAlmacen", _alreadyFetchedAlmacenCollectionViaInventarioAlmacen)
			info.AddValue("_almacenCollectionViainventarioAlmacenLotes", _almacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes", _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes", _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_inventarioAlmacenCollectionViainventarioAlmacenLotes", _inventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes", _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes", _alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_almacenCollectionViaInventarioMovimientoAlmacenDetalles", _almacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles", _inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles", _alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles", _alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_almacenCollectionViaMinvMovimientosAlmacenPvdetalles", _almacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_mventaNotasVentaCollectionViaMventaNotaVentaDetalle", _mventaNotasVentaCollectionViaMventaNotaVentaDetalle)
			info.AddValue("_alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle", _alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle)
			info.AddValue("_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle", _alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle)
			info.AddValue("_almacenCollectionViaUsrAlmInvFisico", _almacenCollectionViaUsrAlmInvFisico)
			info.AddValue("_alwaysFetchAlmacenCollectionViaUsrAlmInvFisico", _alwaysFetchAlmacenCollectionViaUsrAlmInvFisico)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico", _alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_recepcionGanadoCollectionViaUsrProdRecepcionDetalle", _recepcionGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_linea", _linea)
			info.AddValue("_lineaReturnsNewIfNotFound", _lineaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchLinea", _alwaysFetchLinea)
			info.AddValue("_alreadyFetchedLinea", _alreadyFetchedLinea)
			info.AddValue("_presentacion", _presentacion)
			info.AddValue("_presentacionReturnsNewIfNotFound", _presentacionReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPresentacion", _alwaysFetchPresentacion)
			info.AddValue("_alreadyFetchedPresentacion", _alreadyFetchedPresentacion)
			info.AddValue("_tipoProducto", _tipoProducto)
			info.AddValue("_tipoProductoReturnsNewIfNotFound", _tipoProductoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoProducto", _alwaysFetchTipoProducto)
			info.AddValue("_alreadyFetchedTipoProducto", _alreadyFetchedTipoProducto)
			info.AddValue("_unidadMedida", _unidadMedida)
			info.AddValue("_unidadMedidaReturnsNewIfNotFound", _unidadMedidaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchUnidadMedida", _alwaysFetchUnidadMedida)
			info.AddValue("_alreadyFetchedUnidadMedida", _alreadyFetchedUnidadMedida)
			info.AddValue("_marca", _marca)
			info.AddValue("_marcaReturnsNewIfNotFound", _marcaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMarca", _alwaysFetchMarca)
			info.AddValue("_alreadyFetchedMarca", _alreadyFetchedMarca)
			info.AddValue("_cabMediReim", _cabMediReim)
			info.AddValue("_cabMediReimReturnsNewIfNotFound", _cabMediReimReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabMediReim", _alwaysFetchCabMediReim)
			info.AddValue("_alreadyFetchedCabMediReim", _alreadyFetchedCabMediReim)
			info.AddValue("_cabMediTrab", _cabMediTrab)
			info.AddValue("_cabMediTrabReturnsNewIfNotFound", _cabMediTrabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabMediTrab", _alwaysFetchCabMediTrab)
			info.AddValue("_alreadyFetchedCabMediTrab", _alreadyFetchedCabMediTrab)
			info.AddValue("_costoProducto", _costoProducto)
			info.AddValue("_costoProductoReturnsNewIfNotFound", _costoProductoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCostoProducto", _alwaysFetchCostoProducto)
			info.AddValue("_alreadyFetchedCostoProducto", _alreadyFetchedCostoProducto)
			
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
				Case "Linea"
					_alreadyFetchedLinea = True
					Me.Linea = CType(entity, LineaEntity)
				Case "Presentacion"
					_alreadyFetchedPresentacion = True
					Me.Presentacion = CType(entity, PresentacionEntity)
				Case "TipoProducto"
					_alreadyFetchedTipoProducto = True
					Me.TipoProducto = CType(entity, TipoProductoEntity)
				Case "UnidadMedida"
					_alreadyFetchedUnidadMedida = True
					Me.UnidadMedida = CType(entity, UnidadMedidaEntity)
				Case "Marca"
					_alreadyFetchedMarca = True
					Me.Marca = CType(entity, MarcaEntity)
				Case "AplicMediDet"
					_alreadyFetchedAplicMediDet = True
					If Not entity Is Nothing Then
						Me.AplicMediDet.Add(CType(entity, AplicMediDetEntity))
					End If
				Case "AplicMediDetDet"
					_alreadyFetchedAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.AplicMediDetDet.Add(CType(entity, AplicMediDetDetEntity))
					End If
				Case "CabPrepForm"
					_alreadyFetchedCabPrepForm = True
					If Not entity Is Nothing Then
						Me.CabPrepForm.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "CabPrepForm_"
					_alreadyFetchedCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.CabPrepForm_.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "DetAlimentos"
					_alreadyFetchedDetAlimentos = True
					If Not entity Is Nothing Then
						Me.DetAlimentos.Add(CType(entity, DetAlimentosEntity))
					End If
				Case "DetalleKitPv"
					_alreadyFetchedDetalleKitPv = True
					If Not entity Is Nothing Then
						Me.DetalleKitPv.Add(CType(entity, DetalleKitPvEntity))
					End If
				Case "DetalleKitPv_"
					_alreadyFetchedDetalleKitPv_ = True
					If Not entity Is Nothing Then
						Me.DetalleKitPv_.Add(CType(entity, DetalleKitPvEntity))
					End If
				Case "DetAplFor"
					_alreadyFetchedDetAplFor = True
					If Not entity Is Nothing Then
						Me.DetAplFor.Add(CType(entity, DetAplForEntity))
					End If
				Case "DetDproMed"
					_alreadyFetchedDetDproMed = True
					If Not entity Is Nothing Then
						Me.DetDproMed.Add(CType(entity, DetDproMedEntity))
					End If
				Case "DetPrepForm"
					_alreadyFetchedDetPrepForm = True
					If Not entity Is Nothing Then
						Me.DetPrepForm.Add(CType(entity, DetPrepFormEntity))
					End If
				Case "DetPrepFormLote"
					_alreadyFetchedDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.DetPrepFormLote.Add(CType(entity, DetPrepFormLoteEntity))
					End If
				Case "DetProMed"
					_alreadyFetchedDetProMed = True
					If Not entity Is Nothing Then
						Me.DetProMed.Add(CType(entity, DetProMedEntity))
					End If
				Case "InvHistorialPv"
					_alreadyFetchedInvHistorialPv = True
					If Not entity Is Nothing Then
						Me.InvHistorialPv.Add(CType(entity, InvHistorialPvEntity))
					End If
				Case "CostoProductoProveedor"
					_alreadyFetchedCostoProductoProveedor = True
					If Not entity Is Nothing Then
						Me.CostoProductoProveedor.Add(CType(entity, CostoProductoProveedorEntity))
					End If
				Case "ProductoCostoIndirecto"
					_alreadyFetchedProductoCostoIndirecto = True
					If Not entity Is Nothing Then
						Me.ProductoCostoIndirecto.Add(CType(entity, ProductoCostoIndirectoEntity))
					End If
				Case "ProductoMezcla"
					_alreadyFetchedProductoMezcla = True
					If Not entity Is Nothing Then
						Me.ProductoMezcla.Add(CType(entity, ProductoMezclaEntity))
					End If
				Case "ProductoMezcla_"
					_alreadyFetchedProductoMezcla_ = True
					If Not entity Is Nothing Then
						Me.ProductoMezcla_.Add(CType(entity, ProductoMezclaEntity))
					End If
				Case "ListaPrecioDetalle"
					_alreadyFetchedListaPrecioDetalle = True
					If Not entity Is Nothing Then
						Me.ListaPrecioDetalle.Add(CType(entity, ListaPrecioDetalleEntity))
					End If
				Case "McecatLotesCabFor"
					_alreadyFetchedMcecatLotesCabFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabFor.Add(CType(entity, McecatLotesCabForEntity))
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
				Case "McomPresupuestoDetalle"
					_alreadyFetchedMcomPresupuestoDetalle = True
					If Not entity Is Nothing Then
						Me.McomPresupuestoDetalle.Add(CType(entity, PresupuestoCompraDetalleEntity))
					End If
				Case "McomRecepcionOrdenCompraDet"
					_alreadyFetchedMcomRecepcionOrdenCompraDet = True
					If Not entity Is Nothing Then
						Me.McomRecepcionOrdenCompraDet.Add(CType(entity, McomRecepcionOrdenCompraDetEntity))
					End If
				Case "SolicitudProductoDetalle"
					_alreadyFetchedSolicitudProductoDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoDetalle.Add(CType(entity, SolicitudProductoDetalleEntity))
					End If
				Case "InventarioAlmacen"
					_alreadyFetchedInventarioAlmacen = True
					If Not entity Is Nothing Then
						Me.InventarioAlmacen.Add(CType(entity, InventarioAlmacenEntity))
					End If
				Case "InventarioAlmacenLotes"
					_alreadyFetchedInventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.InventarioAlmacenLotes.Add(CType(entity, inventarioAlmacenLotesEntity))
					End If
				Case "InventarioMovimientosAlmacenDetalles"
					_alreadyFetchedInventarioMovimientosAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientosAlmacenDetalles.Add(CType(entity, InventarioMovimientoAlmacenDetallesEntity))
					End If
				Case "MinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPvdetalles.Add(CType(entity, MinvMovimientosAlmacenPvdetallesEntity))
					End If
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntradaDetalle.Add(CType(entity, MinvTransferenciaAlmacenEntradaDetalleEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaDetalle.Add(CType(entity, MinvTransferenciaAlmacenSalidaDetalleEntity))
					End If
				Case "MventaNotaVentaDetalle"
					_alreadyFetchedMventaNotaVentaDetalle = True
					If Not entity Is Nothing Then
						Me.MventaNotaVentaDetalle.Add(CType(entity, NotaVentaDetalleEntity))
					End If
				Case "UsrAlmInvFisico"
					_alreadyFetchedUsrAlmInvFisico = True
					If Not entity Is Nothing Then
						Me.UsrAlmInvFisico.Add(CType(entity, InventarioFisicoEntity))
					End If
				Case "UsrProdRecepcionDetalle"
					_alreadyFetchedUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionDetalle.Add(CType(entity, UsrProdRecepcionDetalleEntity))
					End If
				Case "AplicMediCollectionViaAplicMediDet"
					_alreadyFetchedAplicMediCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.AplicMediCollectionViaAplicMediDet.Add(CType(entity, AplicMediEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDet.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "AplicMediCollectionViaAplicMediDetDet"
					_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.AplicMediCollectionViaAplicMediDetDet.Add(CType(entity, AplicMediEntity))
					End If
				Case "AplicMediDetCollectionViaAplicMediDetDet"
					_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.AplicMediDetCollectionViaAplicMediDetDet.Add(CType(entity, AplicMediDetEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "AlmacenCollectionViaCabPrepForm"
					_alreadyFetchedAlmacenCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabPrepForm.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaCabPrepForm_"
					_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabPrepForm_.Add(CType(entity, AlmacenEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm"
					_alreadyFetchedPlazaCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm.Add(CType(entity, PlazaEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm__"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm__.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm___"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm___.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm_"
					_alreadyFetchedPlazaCollectionViaCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm_.Add(CType(entity, PlazaEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm____"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm____.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm_____"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm_____.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm______"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm______.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabPrepForm_______"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabPrepForm_______.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "CatNutrientesCollectionViaDetAlimentos"
					_alreadyFetchedCatNutrientesCollectionViaDetAlimentos = True
					If Not entity Is Nothing Then
						Me.CatNutrientesCollectionViaDetAlimentos.Add(CType(entity, CatNutrientesEntity))
					End If
				Case "CabAplForCollectionViaDetAplFor"
					_alreadyFetchedCabAplForCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.CabAplForCollectionViaDetAplFor.Add(CType(entity, CabAplForEntity))
					End If
				Case "McecatCorralesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaDetAplFor.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaDetAplFor.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "CabProMedCollectionViaDetDproMed"
					_alreadyFetchedCabProMedCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.CabProMedCollectionViaDetDproMed.Add(CType(entity, CabProMedEntity))
					End If
				Case "DetProMedCollectionViaDetDproMed"
					_alreadyFetchedDetProMedCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.DetProMedCollectionViaDetDproMed.Add(CType(entity, DetProMedEntity))
					End If
				Case "McecatLotesCabCollectionViaDetDproMed"
					_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaDetDproMed.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "CabPrepFormCollectionViaDetPrepForm"
					_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.CabPrepFormCollectionViaDetPrepForm.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "PlazaCollectionViaDetPrepForm"
					_alreadyFetchedPlazaCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaDetPrepForm.Add(CType(entity, PlazaEntity))
					End If
				Case "CabPrepFormCollectionViaDetPrepFormLote"
					_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.CabPrepFormCollectionViaDetPrepFormLote.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "DetPrepFormCollectionViaDetPrepFormLote"
					_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.DetPrepFormCollectionViaDetPrepFormLote.Add(CType(entity, DetPrepFormEntity))
					End If
				Case "PlazaCollectionViaDetPrepFormLote"
					_alreadyFetchedPlazaCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaDetPrepFormLote.Add(CType(entity, PlazaEntity))
					End If
				Case "CabProMedCollectionViaDetProMed"
					_alreadyFetchedCabProMedCollectionViaDetProMed = True
					If Not entity Is Nothing Then
						Me.CabProMedCollectionViaDetProMed.Add(CType(entity, CabProMedEntity))
					End If
				Case "AlmacenCollectionViaInvHistorialPv"
					_alreadyFetchedAlmacenCollectionViaInvHistorialPv = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaInvHistorialPv.Add(CType(entity, AlmacenEntity))
					End If
				Case "ProveedorCollectionViaCostoProductoProveedor"
					_alreadyFetchedProveedorCollectionViaCostoProductoProveedor = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCostoProductoProveedor.Add(CType(entity, ProveedorEntity))
					End If
				Case "CostoIndirectoCollectionViaProductoCostoIndirecto"
					_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto = True
					If Not entity Is Nothing Then
						Me.CostoIndirectoCollectionViaProductoCostoIndirecto.Add(CType(entity, CostoIndirectoEntity))
					End If
				Case "ListaPrecioCollectionViaListaPrecioDetalle"
					_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle = True
					If Not entity Is Nothing Then
						Me.ListaPrecioCollectionViaListaPrecioDetalle.Add(CType(entity, ListaPrecioEntity))
					End If
				Case "McecatLotesCabCollectionViaMcecatLotesCabFor"
					_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaMcecatLotesCabFor.Add(CType(entity, McecatLotesCabEntity))
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
				Case "McomPresupuestoCollectionViaMcomPresupuestoDetalle"
					_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle = True
					If Not entity Is Nothing Then
						Me.McomPresupuestoCollectionViaMcomPresupuestoDetalle.Add(CType(entity, PresupuestoEntity))
					End If
				Case "SolicitudProductoCollectionViaSolicitudProductoDetalle"
					_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoCollectionViaSolicitudProductoDetalle.Add(CType(entity, SolicitudProductoEntity))
					End If
				Case "AlmacenCollectionViaInventarioAlmacen"
					_alreadyFetchedAlmacenCollectionViaInventarioAlmacen = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaInventarioAlmacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViainventarioAlmacenLotes"
					_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViainventarioAlmacenLotes.Add(CType(entity, AlmacenEntity))
					End If
				Case "InventarioAlmacenCollectionViainventarioAlmacenLotes"
					_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.InventarioAlmacenCollectionViainventarioAlmacenLotes.Add(CType(entity, InventarioAlmacenEntity))
					End If
				Case "AlmacenCollectionViaInventarioMovimientoAlmacenDetalles"
					_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaInventarioMovimientoAlmacenDetalles.Add(CType(entity, AlmacenEntity))
					End If
				Case "InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles"
					_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, AlmacenEntity))
					End If
				Case "MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, MinvMovimientosAlmacenPvEntity))
					End If
				Case "MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.Add(CType(entity, MinvTransferenciaAlmacenEntradaEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "MventaNotasVentaCollectionViaMventaNotaVentaDetalle"
					_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle = True
					If Not entity Is Nothing Then
						Me.MventaNotasVentaCollectionViaMventaNotaVentaDetalle.Add(CType(entity, NotaVentaEntity))
					End If
				Case "AlmacenCollectionViaUsrAlmInvFisico"
					_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaUsrAlmInvFisico.Add(CType(entity, AlmacenEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "RecepcionGanadoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.RecepcionGanadoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, RecepcionGanadoEntity))
					End If
				Case "CabMediReim"
					_alreadyFetchedCabMediReim = True
					Me.CabMediReim = CType(entity, CabMediReimEntity)
				Case "CabMediTrab"
					_alreadyFetchedCabMediTrab = True
					Me.CabMediTrab = CType(entity, CabMediTrabEntity)
				Case "CostoProducto"
					_alreadyFetchedCostoProducto = True
					Me.CostoProducto = CType(entity, CostoProductoEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Linea"
					SetupSyncLinea(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Presentacion"
					SetupSyncPresentacion(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoProducto"
					SetupSyncTipoProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UnidadMedida"
					SetupSyncUnidadMedida(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Marca"
					SetupSyncMarca(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDet"
					_aplicMediDet.Add(CType(relatedEntity, AplicMediDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					_aplicMediDetDet.Add(CType(relatedEntity, AplicMediDetDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm"
					_cabPrepForm.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm_"
					_cabPrepForm_.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAlimentos"
					_detAlimentos.Add(CType(relatedEntity, DetAlimentosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetalleKitPv"
					_detalleKitPv.Add(CType(relatedEntity, DetalleKitPvEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetalleKitPv_"
					_detalleKitPv_.Add(CType(relatedEntity, DetalleKitPvEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAplFor"
					_detAplFor.Add(CType(relatedEntity, DetAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetDproMed"
					_detDproMed.Add(CType(relatedEntity, DetDproMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepForm"
					_detPrepForm.Add(CType(relatedEntity, DetPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					_detPrepFormLote.Add(CType(relatedEntity, DetPrepFormLoteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetProMed"
					_detProMed.Add(CType(relatedEntity, DetProMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InvHistorialPv"
					_invHistorialPv.Add(CType(relatedEntity, InvHistorialPvEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CostoProductoProveedor"
					_costoProductoProveedor.Add(CType(relatedEntity, CostoProductoProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProductoCostoIndirecto"
					_productoCostoIndirecto.Add(CType(relatedEntity, ProductoCostoIndirectoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProductoMezcla"
					_productoMezcla.Add(CType(relatedEntity, ProductoMezclaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProductoMezcla_"
					_productoMezcla_.Add(CType(relatedEntity, ProductoMezclaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPrecioDetalle"
					_listaPrecioDetalle.Add(CType(relatedEntity, ListaPrecioDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCabFor"
					_mcecatLotesCabFor.Add(CType(relatedEntity, McecatLotesCabForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					_mcomCotizacionCompraProveedorDetalle.Add(CType(relatedEntity, McomCotizacionCompraProveedorDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					_ordenCompraDetalle.Add(CType(relatedEntity, OrdenCompraDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomPresupuestoDetalle"
					_mcomPresupuestoDetalle.Add(CType(relatedEntity, PresupuestoCompraDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomRecepcionOrdenCompraDet"
					_mcomRecepcionOrdenCompraDet.Add(CType(relatedEntity, McomRecepcionOrdenCompraDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SolicitudProductoDetalle"
					_solicitudProductoDetalle.Add(CType(relatedEntity, SolicitudProductoDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioAlmacen"
					_inventarioAlmacen.Add(CType(relatedEntity, InventarioAlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					_inventarioAlmacenLotes.Add(CType(relatedEntity, inventarioAlmacenLotesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientosAlmacenDetalles"
					_inventarioMovimientosAlmacenDetalles.Add(CType(relatedEntity, InventarioMovimientoAlmacenDetallesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					_minvMovimientosAlmacenPvdetalles.Add(CType(relatedEntity, MinvMovimientosAlmacenPvdetallesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					_minvTransferenciaAlmacenEntradaDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					_minvTransferenciaAlmacenSalidaDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MventaNotaVentaDetalle"
					_mventaNotaVentaDetalle.Add(CType(relatedEntity, NotaVentaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrAlmInvFisico"
					_usrAlmInvFisico.Add(CType(relatedEntity, InventarioFisicoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					_usrProdRecepcionDetalle.Add(CType(relatedEntity, UsrProdRecepcionDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabMediReim"
					SetupSyncCabMediReim(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabMediTrab"
					SetupSyncCabMediTrab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CostoProducto"
					SetupSyncCostoProducto(relatedEntity)
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
				Case "Linea"
					DesetupSyncLinea(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Presentacion"
					DesetupSyncPresentacion(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoProducto"
					DesetupSyncTipoProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UnidadMedida"
					DesetupSyncUnidadMedida(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Marca"
					DesetupSyncMarca(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDetDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm_"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAlimentos"
					MyBase.PerformRelatedEntityRemoval(_detAlimentos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetalleKitPv"
					MyBase.PerformRelatedEntityRemoval(_detalleKitPv, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetalleKitPv_"
					MyBase.PerformRelatedEntityRemoval(_detalleKitPv_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAplFor"
					MyBase.PerformRelatedEntityRemoval(_detAplFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetDproMed"
					MyBase.PerformRelatedEntityRemoval(_detDproMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepForm"
					MyBase.PerformRelatedEntityRemoval(_detPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					MyBase.PerformRelatedEntityRemoval(_detPrepFormLote, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetProMed"
					MyBase.PerformRelatedEntityRemoval(_detProMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InvHistorialPv"
					MyBase.PerformRelatedEntityRemoval(_invHistorialPv, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CostoProductoProveedor"
					MyBase.PerformRelatedEntityRemoval(_costoProductoProveedor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProductoCostoIndirecto"
					MyBase.PerformRelatedEntityRemoval(_productoCostoIndirecto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProductoMezcla"
					MyBase.PerformRelatedEntityRemoval(_productoMezcla, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProductoMezcla_"
					MyBase.PerformRelatedEntityRemoval(_productoMezcla_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPrecioDetalle"
					MyBase.PerformRelatedEntityRemoval(_listaPrecioDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCabFor"
					MyBase.PerformRelatedEntityRemoval(_mcecatLotesCabFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedorDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompraDetalle"
					MyBase.PerformRelatedEntityRemoval(_ordenCompraDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomPresupuestoDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomPresupuestoDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomRecepcionOrdenCompraDet"
					MyBase.PerformRelatedEntityRemoval(_mcomRecepcionOrdenCompraDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SolicitudProductoDetalle"
					MyBase.PerformRelatedEntityRemoval(_solicitudProductoDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioAlmacen"
					MyBase.PerformRelatedEntityRemoval(_inventarioAlmacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					MyBase.PerformRelatedEntityRemoval(_inventarioAlmacenLotes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientosAlmacenDetalles"
					MyBase.PerformRelatedEntityRemoval(_inventarioMovimientosAlmacenDetalles, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					MyBase.PerformRelatedEntityRemoval(_minvMovimientosAlmacenPvdetalles, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntradaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalidaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MventaNotaVentaDetalle"
					MyBase.PerformRelatedEntityRemoval(_mventaNotaVentaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrAlmInvFisico"
					MyBase.PerformRelatedEntityRemoval(_usrAlmInvFisico, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabMediReim"
					DesetupSyncCabMediReim(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabMediTrab"
					DesetupSyncCabMediTrab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CostoProducto"
					DesetupSyncCostoProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()

			If Not _cabMediReim Is Nothing Then
				toReturn.Add(_cabMediReim)
			End If


			If Not _cabMediTrab Is Nothing Then
				toReturn.Add(_cabMediTrab)
			End If


			If Not _costoProducto Is Nothing Then
				toReturn.Add(_costoProducto)
			End If


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _linea Is Nothing Then
				toReturn.Add(_linea)
			End If
			If Not _presentacion Is Nothing Then
				toReturn.Add(_presentacion)
			End If
			If Not _tipoProducto Is Nothing Then
				toReturn.Add(_tipoProducto)
			End If
			If Not _unidadMedida Is Nothing Then
				toReturn.Add(_unidadMedida)
			End If
			If Not _marca Is Nothing Then
				toReturn.Add(_marca)
			End If










			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_aplicMediDet)
			toReturn.Add(_aplicMediDetDet)
			toReturn.Add(_cabPrepForm)
			toReturn.Add(_cabPrepForm_)
			toReturn.Add(_detAlimentos)
			toReturn.Add(_detalleKitPv)
			toReturn.Add(_detalleKitPv_)
			toReturn.Add(_detAplFor)
			toReturn.Add(_detDproMed)
			toReturn.Add(_detPrepForm)
			toReturn.Add(_detPrepFormLote)
			toReturn.Add(_detProMed)
			toReturn.Add(_invHistorialPv)
			toReturn.Add(_costoProductoProveedor)
			toReturn.Add(_productoCostoIndirecto)
			toReturn.Add(_productoMezcla)
			toReturn.Add(_productoMezcla_)
			toReturn.Add(_listaPrecioDetalle)
			toReturn.Add(_mcecatLotesCabFor)
			toReturn.Add(_mcomCotizacionCompraProveedorDetalle)
			toReturn.Add(_ordenCompraDetalle)
			toReturn.Add(_mcomPresupuestoDetalle)
			toReturn.Add(_mcomRecepcionOrdenCompraDet)
			toReturn.Add(_solicitudProductoDetalle)
			toReturn.Add(_inventarioAlmacen)
			toReturn.Add(_inventarioAlmacenLotes)
			toReturn.Add(_inventarioMovimientosAlmacenDetalles)
			toReturn.Add(_minvMovimientosAlmacenPvdetalles)
			toReturn.Add(_minvTransferenciaAlmacenEntradaDetalle)
			toReturn.Add(_minvTransferenciaAlmacenSalidaDetalle)
			toReturn.Add(_mventaNotaVentaDetalle)
			toReturn.Add(_usrAlmInvFisico)
			toReturn.Add(_usrProdRecepcionDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ProductoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ProductoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetEntity'</returns>
		Public Function GetMultiAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Return GetMultiAplicMediDet(forceFetch, _aplicMediDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Return GetMultiAplicMediDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetEntity'</returns>
		Public Function GetMultiAplicMediDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Return GetMultiAplicMediDet(forceFetch, _aplicMediDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			If ( Not _alreadyFetchedAplicMediDet Or forceFetch Or _alwaysFetchAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediDet)
					End If
				End If
				_aplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediDet.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_aplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediDet = True
			End If
			Return _aplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediDet'. These settings will be taken into account
		''' when the property AplicMediDet is requested or GetMultiAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediDet.SortClauses=sortClauses
			_aplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetDetEntity'</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, _aplicMediDetDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetDetEntity'</returns>
		Public Function GetMultiAplicMediDetDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Return GetMultiAplicMediDetDet(forceFetch, _aplicMediDetDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			If ( Not _alreadyFetchedAplicMediDetDet Or forceFetch Or _alwaysFetchAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediDetDet)
					End If
				End If
				_aplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediDetDet.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
				_aplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediDetDet = True
			End If
			Return _aplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediDetDet'. These settings will be taken into account
		''' when the property AplicMediDetDet is requested or GetMultiAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediDetDet.SortClauses=sortClauses
			_aplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm(forceFetch, _cabPrepForm.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm(forceFetch, _cabPrepForm.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepForm Or forceFetch Or _alwaysFetchCabPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepForm)
					End If
				End If
				_cabPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepForm.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
				_cabPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepForm = True
			End If
			Return _cabPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepForm'. These settings will be taken into account
		''' when the property CabPrepForm is requested or GetMultiCabPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepForm.SortClauses=sortClauses
			_cabPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm_(forceFetch, _cabPrepForm_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm_(forceFetch, _cabPrepForm_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepForm_ Or forceFetch Or _alwaysFetchCabPrepForm_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepForm_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepForm_)
					End If
				End If
				_cabPrepForm_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepForm_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepForm_.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
				_cabPrepForm_.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepForm_ = True
			End If
			Return _cabPrepForm_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepForm_'. These settings will be taken into account
		''' when the property CabPrepForm_ is requested or GetMultiCabPrepForm_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepForm_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepForm_.SortClauses=sortClauses
			_cabPrepForm_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetAlimentosEntity'</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, _detAlimentos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetAlimentosEntity'</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, _detAlimentos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			If ( Not _alreadyFetchedDetAlimentos Or forceFetch Or _alwaysFetchDetAlimentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detAlimentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detAlimentos)
					End If
				End If
				_detAlimentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detAlimentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_detAlimentos.GetMultiManyToOne(Nothing, Me, Filter)
				_detAlimentos.SuppressClearInGetMulti = False
				_alreadyFetchedDetAlimentos = True
			End If
			Return _detAlimentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetAlimentos'. These settings will be taken into account
		''' when the property DetAlimentos is requested or GetMultiDetAlimentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetAlimentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detAlimentos.SortClauses=sortClauses
			_detAlimentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetalleKitPvEntity'</returns>
		Public Function GetMultiDetalleKitPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv(forceFetch, _detalleKitPv.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetalleKitPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetalleKitPvEntity'</returns>
		Public Function GetMultiDetalleKitPv(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv(forceFetch, _detalleKitPv.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetalleKitPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			If ( Not _alreadyFetchedDetalleKitPv Or forceFetch Or _alwaysFetchDetalleKitPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detalleKitPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detalleKitPv)
					End If
				End If
				_detalleKitPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detalleKitPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_detalleKitPv.GetMultiManyToOne(Me, Nothing, Filter)
				_detalleKitPv.SuppressClearInGetMulti = False
				_alreadyFetchedDetalleKitPv = True
			End If
			Return _detalleKitPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetalleKitPv'. These settings will be taken into account
		''' when the property DetalleKitPv is requested or GetMultiDetalleKitPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetalleKitPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detalleKitPv.SortClauses=sortClauses
			_detalleKitPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetalleKitPvEntity'</returns>
		Public Function GetMultiDetalleKitPv_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv_(forceFetch, _detalleKitPv_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetalleKitPv_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetalleKitPvEntity'</returns>
		Public Function GetMultiDetalleKitPv_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Return GetMultiDetalleKitPv_(forceFetch, _detalleKitPv_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetalleKitPv_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			If ( Not _alreadyFetchedDetalleKitPv_ Or forceFetch Or _alwaysFetchDetalleKitPv_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detalleKitPv_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detalleKitPv_)
					End If
				End If
				_detalleKitPv_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detalleKitPv_.EntityFactoryToUse = entityFactoryToUse
				End If
				_detalleKitPv_.GetMultiManyToOne(Nothing, Me, Filter)
				_detalleKitPv_.SuppressClearInGetMulti = False
				_alreadyFetchedDetalleKitPv_ = True
			End If
			Return _detalleKitPv_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetalleKitPv_'. These settings will be taken into account
		''' when the property DetalleKitPv_ is requested or GetMultiDetalleKitPv_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetalleKitPv_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detalleKitPv_.SortClauses=sortClauses
			_detalleKitPv_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetAplForEntity'</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, _detAplFor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetAplForEntity'</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, _detAplFor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAplForCollection
			If ( Not _alreadyFetchedDetAplFor Or forceFetch Or _alwaysFetchDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detAplFor)
					End If
				End If
				_detAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_detAplFor.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_detAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedDetAplFor = True
			End If
			Return _detAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetAplFor'. These settings will be taken into account
		''' when the property DetAplFor is requested or GetMultiDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detAplFor.SortClauses=sortClauses
			_detAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetDproMedEntity'</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, _detDproMed.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetDproMedEntity'</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, _detDproMed.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			If ( Not _alreadyFetchedDetDproMed Or forceFetch Or _alwaysFetchDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detDproMed)
					End If
				End If
				_detDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detDproMed.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_detDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetDproMed = True
			End If
			Return _detDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetDproMed'. These settings will be taken into account
		''' when the property DetDproMed is requested or GetMultiDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detDproMed.SortClauses=sortClauses
			_detDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, _detPrepForm.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, _detPrepForm.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			If ( Not _alreadyFetchedDetPrepForm Or forceFetch Or _alwaysFetchDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepForm)
					End If
				End If
				_detPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepForm.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_detPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepForm = True
			End If
			Return _detPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepForm'. These settings will be taken into account
		''' when the property DetPrepForm is requested or GetMultiDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepForm.SortClauses=sortClauses
			_detPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormLoteEntity'</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, _detPrepFormLote.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormLoteEntity'</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, _detPrepFormLote.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			If ( Not _alreadyFetchedDetPrepFormLote Or forceFetch Or _alwaysFetchDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepFormLote)
					End If
				End If
				_detPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepFormLote.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_detPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepFormLote = True
			End If
			Return _detPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepFormLote'. These settings will be taken into account
		''' when the property DetPrepFormLote is requested or GetMultiDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepFormLote.SortClauses=sortClauses
			_detPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, _detProMed.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, _detProMed.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetProMedCollection
			If ( Not _alreadyFetchedDetProMed Or forceFetch Or _alwaysFetchDetProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detProMed)
					End If
				End If
				_detProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detProMed.GetMultiManyToOne(Nothing, Me, Filter)
				_detProMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetProMed = True
			End If
			Return _detProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetProMed'. These settings will be taken into account
		''' when the property DetProMed is requested or GetMultiDetProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detProMed.SortClauses=sortClauses
			_detProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'InvHistorialPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InvHistorialPvEntity'</returns>
		Public Function GetMultiInvHistorialPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
			Return GetMultiInvHistorialPv(forceFetch, _invHistorialPv.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InvHistorialPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInvHistorialPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
			Return GetMultiInvHistorialPv(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InvHistorialPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InvHistorialPvEntity'</returns>
		Public Function GetMultiInvHistorialPv(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
			Return GetMultiInvHistorialPv(forceFetch, _invHistorialPv.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InvHistorialPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInvHistorialPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
			If ( Not _alreadyFetchedInvHistorialPv Or forceFetch Or _alwaysFetchInvHistorialPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _invHistorialPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_invHistorialPv)
					End If
				End If
				_invHistorialPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_invHistorialPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_invHistorialPv.GetMultiManyToOne(Nothing, Me, Filter)
				_invHistorialPv.SuppressClearInGetMulti = False
				_alreadyFetchedInvHistorialPv = True
			End If
			Return _invHistorialPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InvHistorialPv'. These settings will be taken into account
		''' when the property InvHistorialPv is requested or GetMultiInvHistorialPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInvHistorialPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_invHistorialPv.SortClauses=sortClauses
			_invHistorialPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_costoProductoProveedor.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ProductoCostoIndirectoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoCostoIndirectoEntity'</returns>
		Public Function GetMultiProductoCostoIndirecto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
			Return GetMultiProductoCostoIndirecto(forceFetch, _productoCostoIndirecto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoCostoIndirectoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProductoCostoIndirecto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
			Return GetMultiProductoCostoIndirecto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoCostoIndirectoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoCostoIndirectoEntity'</returns>
		Public Function GetMultiProductoCostoIndirecto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
			Return GetMultiProductoCostoIndirecto(forceFetch, _productoCostoIndirecto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoCostoIndirectoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCostoIndirecto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
			If ( Not _alreadyFetchedProductoCostoIndirecto Or forceFetch Or _alwaysFetchProductoCostoIndirecto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCostoIndirecto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCostoIndirecto)
					End If
				End If
				_productoCostoIndirecto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCostoIndirecto.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCostoIndirecto.GetMultiManyToOne(Nothing, Me, Filter)
				_productoCostoIndirecto.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCostoIndirecto = True
			End If
			Return _productoCostoIndirecto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCostoIndirecto'. These settings will be taken into account
		''' when the property ProductoCostoIndirecto is requested or GetMultiProductoCostoIndirecto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCostoIndirecto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCostoIndirecto.SortClauses=sortClauses
			_productoCostoIndirecto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoMezclaEntity'</returns>
		Public Function GetMultiProductoMezcla(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla(forceFetch, _productoMezcla.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProductoMezcla(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoMezclaEntity'</returns>
		Public Function GetMultiProductoMezcla(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla(forceFetch, _productoMezcla.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoMezcla(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			If ( Not _alreadyFetchedProductoMezcla Or forceFetch Or _alwaysFetchProductoMezcla) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoMezcla.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoMezcla)
					End If
				End If
				_productoMezcla.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoMezcla.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoMezcla.GetMultiManyToOne(Me, Nothing, Filter)
				_productoMezcla.SuppressClearInGetMulti = False
				_alreadyFetchedProductoMezcla = True
			End If
			Return _productoMezcla
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoMezcla'. These settings will be taken into account
		''' when the property ProductoMezcla is requested or GetMultiProductoMezcla is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoMezcla(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoMezcla.SortClauses=sortClauses
			_productoMezcla.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoMezclaEntity'</returns>
		Public Function GetMultiProductoMezcla_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla_(forceFetch, _productoMezcla_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProductoMezcla_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoMezclaEntity'</returns>
		Public Function GetMultiProductoMezcla_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Return GetMultiProductoMezcla_(forceFetch, _productoMezcla_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoMezcla_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			If ( Not _alreadyFetchedProductoMezcla_ Or forceFetch Or _alwaysFetchProductoMezcla_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoMezcla_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoMezcla_)
					End If
				End If
				_productoMezcla_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoMezcla_.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoMezcla_.GetMultiManyToOne(Nothing, Me, Filter)
				_productoMezcla_.SuppressClearInGetMulti = False
				_alreadyFetchedProductoMezcla_ = True
			End If
			Return _productoMezcla_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoMezcla_'. These settings will be taken into account
		''' when the property ProductoMezcla_ is requested or GetMultiProductoMezcla_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoMezcla_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoMezcla_.SortClauses=sortClauses
			_productoMezcla_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioDetalleEntity'</returns>
		Public Function GetMultiListaPrecioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPrecioDetalle(forceFetch, _listaPrecioDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiListaPrecioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPrecioDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioDetalleEntity'</returns>
		Public Function GetMultiListaPrecioDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPrecioDetalle(forceFetch, _listaPrecioDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			If ( Not _alreadyFetchedListaPrecioDetalle Or forceFetch Or _alwaysFetchListaPrecioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecioDetalle)
					End If
				End If
				_listaPrecioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecioDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_listaPrecioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecioDetalle = True
			End If
			Return _listaPrecioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecioDetalle'. These settings will be taken into account
		''' when the property ListaPrecioDetalle is requested or GetMultiListaPrecioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecioDetalle.SortClauses=sortClauses
			_listaPrecioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabForEntity'</returns>
		Public Function GetMultiMcecatLotesCabFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
			Return GetMultiMcecatLotesCabFor(forceFetch, _mcecatLotesCabFor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcecatLotesCabFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
			Return GetMultiMcecatLotesCabFor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabForEntity'</returns>
		Public Function GetMultiMcecatLotesCabFor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
			Return GetMultiMcecatLotesCabFor(forceFetch, _mcecatLotesCabFor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
			If ( Not _alreadyFetchedMcecatLotesCabFor Or forceFetch Or _alwaysFetchMcecatLotesCabFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabFor)
					End If
				End If
				_mcecatLotesCabFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabFor.GetMultiManyToOne(Me, Nothing, Filter)
				_mcecatLotesCabFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabFor = True
			End If
			Return _mcecatLotesCabFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabFor'. These settings will be taken into account
		''' when the property McecatLotesCabFor is requested or GetMultiMcecatLotesCabFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabFor.SortClauses=sortClauses
			_mcecatLotesCabFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_mcomCotizacionCompraProveedorDetalle.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
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
				_ordenCompraDetalle.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
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
				_mcomPresupuestoDetalle.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomRecepcionOrdenCompraDetEntity'</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, _mcomRecepcionOrdenCompraDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomRecepcionOrdenCompraDetEntity'</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, _mcomRecepcionOrdenCompraDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			If ( Not _alreadyFetchedMcomRecepcionOrdenCompraDet Or forceFetch Or _alwaysFetchMcomRecepcionOrdenCompraDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomRecepcionOrdenCompraDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomRecepcionOrdenCompraDet)
					End If
				End If
				_mcomRecepcionOrdenCompraDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomRecepcionOrdenCompraDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomRecepcionOrdenCompraDet.GetMultiManyToOne(Me, Nothing, Filter)
				_mcomRecepcionOrdenCompraDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcomRecepcionOrdenCompraDet = True
			End If
			Return _mcomRecepcionOrdenCompraDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomRecepcionOrdenCompraDet'. These settings will be taken into account
		''' when the property McomRecepcionOrdenCompraDet is requested or GetMultiMcomRecepcionOrdenCompraDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomRecepcionOrdenCompraDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomRecepcionOrdenCompraDet.SortClauses=sortClauses
			_mcomRecepcionOrdenCompraDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoDetalleEntity'</returns>
		Public Function GetMultiSolicitudProductoDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Return GetMultiSolicitudProductoDetalle(forceFetch, _solicitudProductoDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSolicitudProductoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Return GetMultiSolicitudProductoDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoDetalleEntity'</returns>
		Public Function GetMultiSolicitudProductoDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Return GetMultiSolicitudProductoDetalle(forceFetch, _solicitudProductoDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProductoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			If ( Not _alreadyFetchedSolicitudProductoDetalle Or forceFetch Or _alwaysFetchSolicitudProductoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProductoDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProductoDetalle)
					End If
				End If
				_solicitudProductoDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProductoDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProductoDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_solicitudProductoDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProductoDetalle = True
			End If
			Return _solicitudProductoDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProductoDetalle'. These settings will be taken into account
		''' when the property SolicitudProductoDetalle is requested or GetMultiSolicitudProductoDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProductoDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProductoDetalle.SortClauses=sortClauses
			_solicitudProductoDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioAlmacenEntity'</returns>
		Public Function GetMultiInventarioAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Return GetMultiInventarioAlmacen(forceFetch, _inventarioAlmacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Return GetMultiInventarioAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioAlmacenEntity'</returns>
		Public Function GetMultiInventarioAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Return GetMultiInventarioAlmacen(forceFetch, _inventarioAlmacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			If ( Not _alreadyFetchedInventarioAlmacen Or forceFetch Or _alwaysFetchInventarioAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioAlmacen)
					End If
				End If
				_inventarioAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioAlmacen.GetMultiManyToOne(Nothing, Me, Filter)
				_inventarioAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioAlmacen = True
			End If
			Return _inventarioAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioAlmacen'. These settings will be taken into account
		''' when the property InventarioAlmacen is requested or GetMultiInventarioAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioAlmacen.SortClauses=sortClauses
			_inventarioAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'inventarioAlmacenLotesEntity'</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, _inventarioAlmacenLotes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'inventarioAlmacenLotesEntity'</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, _inventarioAlmacenLotes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			If ( Not _alreadyFetchedInventarioAlmacenLotes Or forceFetch Or _alwaysFetchInventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioAlmacenLotes)
					End If
				End If
				_inventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioAlmacenLotes.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_inventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioAlmacenLotes = True
			End If
			Return _inventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioAlmacenLotes'. These settings will be taken into account
		''' when the property InventarioAlmacenLotes is requested or GetMultiInventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioAlmacenLotes.SortClauses=sortClauses
			_inventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenDetallesEntity'</returns>
		Public Function GetMultiInventarioMovimientosAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientosAlmacenDetalles(forceFetch, _inventarioMovimientosAlmacenDetalles.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioMovimientosAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientosAlmacenDetalles(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenDetallesEntity'</returns>
		Public Function GetMultiInventarioMovimientosAlmacenDetalles(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientosAlmacenDetalles(forceFetch, _inventarioMovimientosAlmacenDetalles.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientosAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			If ( Not _alreadyFetchedInventarioMovimientosAlmacenDetalles Or forceFetch Or _alwaysFetchInventarioMovimientosAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientosAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientosAlmacenDetalles)
					End If
				End If
				_inventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientosAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientosAlmacenDetalles.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_inventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientosAlmacenDetalles = True
			End If
			Return _inventarioMovimientosAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientosAlmacenDetalles'. These settings will be taken into account
		''' when the property InventarioMovimientosAlmacenDetalles is requested or GetMultiInventarioMovimientosAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientosAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientosAlmacenDetalles.SortClauses=sortClauses
			_inventarioMovimientosAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, _minvMovimientosAlmacenPvdetalles.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, _minvMovimientosAlmacenPvdetalles.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			If ( Not _alreadyFetchedMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvMovimientosAlmacenPvdetalles)
					End If
				End If
				_minvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvMovimientosAlmacenPvdetalles.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_minvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _minvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property MinvMovimientosAlmacenPvdetalles is requested or GetMultiMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_minvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntradaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntradaDetalle)
					End If
				End If
				_minvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntradaDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_minvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = True
			End If
			Return _minvTransferenciaAlmacenEntradaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntradaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntradaDetalle is requested or GetMultiMinvTransferenciaAlmacenEntradaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntradaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntradaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntradaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalidaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalidaDetalle)
					End If
				End If
				_minvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalidaDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_minvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = True
			End If
			Return _minvTransferenciaAlmacenSalidaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalidaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalidaDetalle is requested or GetMultiMinvTransferenciaAlmacenSalidaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalidaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalidaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalidaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaVentaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaDetalleEntity'</returns>
		Public Function GetMultiMventaNotaVentaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
			Return GetMultiMventaNotaVentaDetalle(forceFetch, _mventaNotaVentaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMventaNotaVentaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
			Return GetMultiMventaNotaVentaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaDetalleEntity'</returns>
		Public Function GetMultiMventaNotaVentaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
			Return GetMultiMventaNotaVentaDetalle(forceFetch, _mventaNotaVentaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMventaNotaVentaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
			If ( Not _alreadyFetchedMventaNotaVentaDetalle Or forceFetch Or _alwaysFetchMventaNotaVentaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mventaNotaVentaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mventaNotaVentaDetalle)
					End If
				End If
				_mventaNotaVentaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mventaNotaVentaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mventaNotaVentaDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_mventaNotaVentaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMventaNotaVentaDetalle = True
			End If
			Return _mventaNotaVentaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MventaNotaVentaDetalle'. These settings will be taken into account
		''' when the property MventaNotaVentaDetalle is requested or GetMultiMventaNotaVentaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMventaNotaVentaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mventaNotaVentaDetalle.SortClauses=sortClauses
			_mventaNotaVentaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'InventarioFisicoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioFisicoEntity'</returns>
		Public Function GetMultiUsrAlmInvFisico(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
			Return GetMultiUsrAlmInvFisico(forceFetch, _usrAlmInvFisico.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioFisicoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrAlmInvFisico(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
			Return GetMultiUsrAlmInvFisico(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioFisicoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioFisicoEntity'</returns>
		Public Function GetMultiUsrAlmInvFisico(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
			Return GetMultiUsrAlmInvFisico(forceFetch, _usrAlmInvFisico.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioFisicoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrAlmInvFisico(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
			If ( Not _alreadyFetchedUsrAlmInvFisico Or forceFetch Or _alwaysFetchUsrAlmInvFisico) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrAlmInvFisico.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrAlmInvFisico)
					End If
				End If
				_usrAlmInvFisico.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrAlmInvFisico.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrAlmInvFisico.GetMultiManyToOne(Nothing, Me, Filter)
				_usrAlmInvFisico.SuppressClearInGetMulti = False
				_alreadyFetchedUsrAlmInvFisico = True
			End If
			Return _usrAlmInvFisico
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrAlmInvFisico'. These settings will be taken into account
		''' when the property UsrAlmInvFisico is requested or GetMultiUsrAlmInvFisico is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrAlmInvFisico(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrAlmInvFisico.SortClauses=sortClauses
			_usrAlmInvFisico.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionDetalleEntity'</returns>
		Public Function GetMultiUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
			Return GetMultiUsrProdRecepcionDetalle(forceFetch, _usrProdRecepcionDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
			Return GetMultiUsrProdRecepcionDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionDetalleEntity'</returns>
		Public Function GetMultiUsrProdRecepcionDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
			Return GetMultiUsrProdRecepcionDetalle(forceFetch, _usrProdRecepcionDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
			If ( Not _alreadyFetchedUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRecepcionDetalle)
					End If
				End If
				_usrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRecepcionDetalle.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_usrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRecepcionDetalle = True
			End If
			Return _usrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property UsrProdRecepcionDetalle is requested or GetMultiUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRecepcionDetalle.SortClauses=sortClauses
			_usrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMediCollectionViaAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMediCollectionViaAplicMediDet(forceFetch, _aplicMediCollectionViaAplicMediDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediCollectionViaAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediCollection
			If ( Not _alreadyFetchedAplicMediCollectionViaAplicMediDet Or forceFetch Or _alwaysFetchAplicMediCollectionViaAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediCollectionViaAplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediCollectionViaAplicMediDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_aplicMediCollectionViaAplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediCollectionViaAplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediCollectionViaAplicMediDet.GetMulti(Filter, relations)
				_aplicMediCollectionViaAplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediCollectionViaAplicMediDet = True
			End If
			Return _aplicMediCollectionViaAplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediCollectionViaAplicMediDet'. These settings will be taken into account
		''' when the property AplicMediCollectionViaAplicMediDet is requested or GetMultiAplicMediCollectionViaAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediCollectionViaAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediCollectionViaAplicMediDet.SortClauses=sortClauses
			_aplicMediCollectionViaAplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch, _mcecatCorralesCabCollectionViaAplicMediDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaAplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaAplicMediDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatCorralesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaAplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaAplicMediDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = True
			End If
			Return _mcecatCorralesCabCollectionViaAplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaAplicMediDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaAplicMediDet is requested or GetMultiMcecatCorralesCabCollectionViaAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaAplicMediDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaAplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaAplicMediDet(forceFetch, _mcecatLotesCabCollectionViaAplicMediDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaAplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaAplicMediDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatLotesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaAplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaAplicMediDet.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = True
			End If
			Return _mcecatLotesCabCollectionViaAplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaAplicMediDet'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaAplicMediDet is requested or GetMultiMcecatLotesCabCollectionViaAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaAplicMediDet.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaAplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch, _aplicMediCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediCollection
			If ( Not _alreadyFetchedAplicMediCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchAplicMediCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_aplicMediCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_aplicMediCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = True
			End If
			Return _aplicMediCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property AplicMediCollectionViaAplicMediDetDet is requested or GetMultiAplicMediCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_aplicMediCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediDetEntity'</returns>
		Public Function GetMultiAplicMediDetCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Return GetMultiAplicMediDetCollectionViaAplicMediDetDet(forceFetch, _aplicMediDetCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMediDetCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			If ( Not _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMediDetCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMediDetCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_aplicMediDetCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMediDetCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMediDetCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_aplicMediDetCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = True
			End If
			Return _aplicMediDetCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMediDetCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property AplicMediDetCollectionViaAplicMediDetDet is requested or GetMultiAplicMediDetCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMediDetCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMediDetCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_aplicMediDetCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch, _mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
			End If
			Return _mcecatCorralesCabCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaAplicMediDetDet is requested or GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch, _mcecatLotesCabCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatLotesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
			End If
			Return _mcecatLotesCabCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaAplicMediDetDet is requested or GetMultiMcecatLotesCabCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabPrepForm(forceFetch, _almacenCollectionViaCabPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabPrepForm Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaCabPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabPrepForm.GetMulti(Filter, relations)
				_almacenCollectionViaCabPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabPrepForm = True
			End If
			Return _almacenCollectionViaCabPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabPrepForm'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabPrepForm is requested or GetMultiAlmacenCollectionViaCabPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabPrepForm.SortClauses=sortClauses
			_almacenCollectionViaCabPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabPrepForm_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabPrepForm_(forceFetch, _almacenCollectionViaCabPrepForm_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabPrepForm_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabPrepForm_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabPrepForm_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabPrepForm_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaCabPrepForm_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabPrepForm_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabPrepForm_.GetMulti(Filter, relations)
				_almacenCollectionViaCabPrepForm_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = True
			End If
			Return _almacenCollectionViaCabPrepForm_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabPrepForm_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabPrepForm_ is requested or GetMultiAlmacenCollectionViaCabPrepForm_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabPrepForm_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabPrepForm_.SortClauses=sortClauses
			_almacenCollectionViaCabPrepForm_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaCabPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaCabPrepForm(forceFetch, _plazaCollectionViaCabPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaCabPrepForm Or forceFetch Or _alwaysFetchPlazaCollectionViaCabPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaCabPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaCabPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaCabPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaCabPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaCabPrepForm.GetMulti(Filter, relations)
				_plazaCollectionViaCabPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaCabPrepForm = True
			End If
			Return _plazaCollectionViaCabPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaCabPrepForm'. These settings will be taken into account
		''' when the property PlazaCollectionViaCabPrepForm is requested or GetMultiPlazaCollectionViaCabPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaCabPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaCabPrepForm.SortClauses=sortClauses
			_plazaCollectionViaCabPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm__'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm__ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm___'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm___ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaCabPrepForm_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaCabPrepForm_(forceFetch, _plazaCollectionViaCabPrepForm_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaCabPrepForm_ Or forceFetch Or _alwaysFetchPlazaCollectionViaCabPrepForm_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaCabPrepForm_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaCabPrepForm_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaCabPrepForm_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaCabPrepForm_.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaCabPrepForm_.GetMulti(Filter, relations)
				_plazaCollectionViaCabPrepForm_.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaCabPrepForm_ = True
			End If
			Return _plazaCollectionViaCabPrepForm_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaCabPrepForm_'. These settings will be taken into account
		''' when the property PlazaCollectionViaCabPrepForm_ is requested or GetMultiPlazaCollectionViaCabPrepForm_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaCabPrepForm_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaCabPrepForm_.SortClauses=sortClauses
			_plazaCollectionViaCabPrepForm_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm____.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm____.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm____)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm____
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm____'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm____ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm____(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm_____
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm_____'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm_____ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm______.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm______.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm______)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm______
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm______'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm______ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm______(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabPrepForm_______
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabPrepForm_______'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabPrepForm_______ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatNutrientesEntity'</returns>
		Public Function GetMultiCatNutrientesCollectionViaDetAlimentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Return GetMultiCatNutrientesCollectionViaDetAlimentos(forceFetch, _catNutrientesCollectionViaDetAlimentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatNutrientesCollectionViaDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			If ( Not _alreadyFetchedCatNutrientesCollectionViaDetAlimentos Or forceFetch Or _alwaysFetchCatNutrientesCollectionViaDetAlimentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catNutrientesCollectionViaDetAlimentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catNutrientesCollectionViaDetAlimentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetAlimentosEntityUsingCveAlimento, "__ProductoEntity__", "DetAlimentos_", JoinHint.None)
				relations.Add(DetAlimentosEntity.Relations.CatNutrientesEntityUsingCveNutriente, "DetAlimentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_catNutrientesCollectionViaDetAlimentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catNutrientesCollectionViaDetAlimentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_catNutrientesCollectionViaDetAlimentos.GetMulti(Filter, relations)
				_catNutrientesCollectionViaDetAlimentos.SuppressClearInGetMulti = False
				_alreadyFetchedCatNutrientesCollectionViaDetAlimentos = True
			End If
			Return _catNutrientesCollectionViaDetAlimentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatNutrientesCollectionViaDetAlimentos'. These settings will be taken into account
		''' when the property CatNutrientesCollectionViaDetAlimentos is requested or GetMultiCatNutrientesCollectionViaDetAlimentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatNutrientesCollectionViaDetAlimentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catNutrientesCollectionViaDetAlimentos.SortClauses=sortClauses
			_catNutrientesCollectionViaDetAlimentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabAplForEntity'</returns>
		Public Function GetMultiCabAplForCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplForCollectionViaDetAplFor(forceFetch, _cabAplForCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabAplForCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabAplForCollection
			If ( Not _alreadyFetchedCabAplForCollectionViaDetAplFor Or forceFetch Or _alwaysFetchCabAplForCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabAplForCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabAplForCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabAplForCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabAplForCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabAplForCollectionViaDetAplFor.GetMulti(Filter, relations)
				_cabAplForCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedCabAplForCollectionViaDetAplFor = True
			End If
			Return _cabAplForCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabAplForCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property CabAplForCollectionViaDetAplFor is requested or GetMultiCabAplForCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabAplForCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabAplForCollectionViaDetAplFor.SortClauses=sortClauses
			_cabAplForCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch, _mcecatCorralesCabCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatCorralesCabCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaDetAplFor.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = True
			End If
			Return _mcecatCorralesCabCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaDetAplFor is requested or GetMultiMcecatCorralesCabCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaDetAplFor.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch, _mcecatLotesCabCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatLotesCabCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaDetAplFor.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = True
			End If
			Return _mcecatLotesCabCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaDetAplFor is requested or GetMultiMcecatLotesCabCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaDetAplFor.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabProMedEntity'</returns>
		Public Function GetMultiCabProMedCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabProMedCollection
			Return GetMultiCabProMedCollectionViaDetDproMed(forceFetch, _cabProMedCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabProMedCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabProMedCollection
			If ( Not _alreadyFetchedCabProMedCollectionViaDetDproMed Or forceFetch Or _alwaysFetchCabProMedCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabProMedCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabProMedCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabProMedCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabProMedCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabProMedCollectionViaDetDproMed.GetMulti(Filter, relations)
				_cabProMedCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedCabProMedCollectionViaDetDproMed = True
			End If
			Return _cabProMedCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabProMedCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property CabProMedCollectionViaDetDproMed is requested or GetMultiCabProMedCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabProMedCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabProMedCollectionViaDetDproMed.SortClauses=sortClauses
			_cabProMedCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMedCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMedCollectionViaDetDproMed(forceFetch, _detProMedCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetProMedCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetProMedCollection
			If ( Not _alreadyFetchedDetProMedCollectionViaDetDproMed Or forceFetch Or _alwaysFetchDetProMedCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detProMedCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detProMedCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_detProMedCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detProMedCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detProMedCollectionViaDetDproMed.GetMulti(Filter, relations)
				_detProMedCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetProMedCollectionViaDetDproMed = True
			End If
			Return _detProMedCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetProMedCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property DetProMedCollectionViaDetDproMed is requested or GetMultiDetProMedCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetProMedCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detProMedCollectionViaDetDproMed.SortClauses=sortClauses
			_detProMedCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch, _mcecatLotesCabCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.McecatLotesCabEntityUsingIdLote, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatLotesCabCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaDetDproMed.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = True
			End If
			Return _mcecatLotesCabCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaDetDproMed is requested or GetMultiMcecatLotesCabCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaDetDproMed.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepFormCollectionViaDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepFormCollectionViaDetPrepForm(forceFetch, _cabPrepFormCollectionViaDetPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepFormCollectionViaDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepFormCollectionViaDetPrepForm Or forceFetch Or _alwaysFetchCabPrepFormCollectionViaDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepFormCollectionViaDetPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepFormCollectionViaDetPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, "__ProductoEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabPrepFormCollectionViaDetPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepFormCollectionViaDetPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepFormCollectionViaDetPrepForm.GetMulti(Filter, relations)
				_cabPrepFormCollectionViaDetPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = True
			End If
			Return _cabPrepFormCollectionViaDetPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepFormCollectionViaDetPrepForm'. These settings will be taken into account
		''' when the property CabPrepFormCollectionViaDetPrepForm is requested or GetMultiCabPrepFormCollectionViaDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepFormCollectionViaDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepFormCollectionViaDetPrepForm.SortClauses=sortClauses
			_cabPrepFormCollectionViaDetPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaDetPrepForm(forceFetch, _plazaCollectionViaDetPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaDetPrepForm Or forceFetch Or _alwaysFetchPlazaCollectionViaDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaDetPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaDetPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, "__ProductoEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaDetPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaDetPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaDetPrepForm.GetMulti(Filter, relations)
				_plazaCollectionViaDetPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaDetPrepForm = True
			End If
			Return _plazaCollectionViaDetPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaDetPrepForm'. These settings will be taken into account
		''' when the property PlazaCollectionViaDetPrepForm is requested or GetMultiPlazaCollectionViaDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaDetPrepForm.SortClauses=sortClauses
			_plazaCollectionViaDetPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepFormCollectionViaDetPrepFormLote(forceFetch, _cabPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepFormCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepFormCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepFormCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_cabPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = True
			End If
			Return _cabPrepFormCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepFormCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property CabPrepFormCollectionViaDetPrepFormLote is requested or GetMultiCabPrepFormCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepFormCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepFormCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_cabPrepFormCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch, _detPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			If ( Not _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepFormCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepFormCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_detPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepFormCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_detPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = True
			End If
			Return _detPrepFormCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepFormCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property DetPrepFormCollectionViaDetPrepFormLote is requested or GetMultiDetPrepFormCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepFormCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepFormCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_detPrepFormCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch, _plazaCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchPlazaCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.PlazaEntityUsingIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_plazaCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaDetPrepFormLote = True
			End If
			Return _plazaCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property PlazaCollectionViaDetPrepFormLote is requested or GetMultiPlazaCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_plazaCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabProMedEntity'</returns>
		Public Function GetMultiCabProMedCollectionViaDetProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabProMedCollection
			Return GetMultiCabProMedCollectionViaDetProMed(forceFetch, _cabProMedCollectionViaDetProMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabProMedCollectionViaDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabProMedCollection
			If ( Not _alreadyFetchedCabProMedCollectionViaDetProMed Or forceFetch Or _alwaysFetchCabProMedCollectionViaDetProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabProMedCollectionViaDetProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabProMedCollectionViaDetProMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.DetProMedEntityUsingIdMedicamento, "__ProductoEntity__", "DetProMed_", JoinHint.None)
				relations.Add(DetProMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento, "DetProMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabProMedCollectionViaDetProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabProMedCollectionViaDetProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabProMedCollectionViaDetProMed.GetMulti(Filter, relations)
				_cabProMedCollectionViaDetProMed.SuppressClearInGetMulti = False
				_alreadyFetchedCabProMedCollectionViaDetProMed = True
			End If
			Return _cabProMedCollectionViaDetProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabProMedCollectionViaDetProMed'. These settings will be taken into account
		''' when the property CabProMedCollectionViaDetProMed is requested or GetMultiCabProMedCollectionViaDetProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabProMedCollectionViaDetProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabProMedCollectionViaDetProMed.SortClauses=sortClauses
			_cabProMedCollectionViaDetProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaInvHistorialPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaInvHistorialPv(forceFetch, _almacenCollectionViaInvHistorialPv.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaInvHistorialPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaInvHistorialPv Or forceFetch Or _alwaysFetchAlmacenCollectionViaInvHistorialPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaInvHistorialPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaInvHistorialPv)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.InvHistorialPvEntityUsingIdProducto, "__ProductoEntity__", "InvHistorialPv_", JoinHint.None)
				relations.Add(InvHistorialPvEntity.Relations.AlmacenEntityUsingIdAlmacen, "InvHistorialPv_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaInvHistorialPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaInvHistorialPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaInvHistorialPv.GetMulti(Filter, relations)
				_almacenCollectionViaInvHistorialPv.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaInvHistorialPv = True
			End If
			Return _almacenCollectionViaInvHistorialPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaInvHistorialPv'. These settings will be taken into account
		''' when the property AlmacenCollectionViaInvHistorialPv is requested or GetMultiAlmacenCollectionViaInvHistorialPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaInvHistorialPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaInvHistorialPv.SortClauses=sortClauses
			_almacenCollectionViaInvHistorialPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCostoProductoProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCostoProductoProveedor(forceFetch, _proveedorCollectionViaCostoProductoProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCostoProductoProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCostoProductoProveedor Or forceFetch Or _alwaysFetchProveedorCollectionViaCostoProductoProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCostoProductoProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCostoProductoProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.CostoProductoProveedorEntityUsingProducto, "__ProductoEntity__", "CostoProductoProveedor_", JoinHint.None)
				relations.Add(CostoProductoProveedorEntity.Relations.ProveedorEntityUsingProveedor, "CostoProductoProveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaCostoProductoProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCostoProductoProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCostoProductoProveedor.GetMulti(Filter, relations)
				_proveedorCollectionViaCostoProductoProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCostoProductoProveedor = True
			End If
			Return _proveedorCollectionViaCostoProductoProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCostoProductoProveedor'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCostoProductoProveedor is requested or GetMultiProveedorCollectionViaCostoProductoProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCostoProductoProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCostoProductoProveedor.SortClauses=sortClauses
			_proveedorCollectionViaCostoProductoProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CostoIndirectoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CostoIndirectoEntity'</returns>
		Public Function GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CostoIndirectoCollection
			Return GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto(forceFetch, _costoIndirectoCollectionViaProductoCostoIndirecto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CostoIndirectoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CostoIndirectoCollection
			If ( Not _alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto Or forceFetch Or _alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _costoIndirectoCollectionViaProductoCostoIndirecto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_costoIndirectoCollectionViaProductoCostoIndirecto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.ProductoCostoIndirectoEntityUsingCodigoProducto, "__ProductoEntity__", "ProductoCostoIndirecto_", JoinHint.None)
				relations.Add(ProductoCostoIndirectoEntity.Relations.CostoIndirectoEntityUsingCodigoCostoIndirecto, "ProductoCostoIndirecto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_costoIndirectoCollectionViaProductoCostoIndirecto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_costoIndirectoCollectionViaProductoCostoIndirecto.EntityFactoryToUse = entityFactoryToUse
				End If
				_costoIndirectoCollectionViaProductoCostoIndirecto.GetMulti(Filter, relations)
				_costoIndirectoCollectionViaProductoCostoIndirecto.SuppressClearInGetMulti = False
				_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto = True
			End If
			Return _costoIndirectoCollectionViaProductoCostoIndirecto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CostoIndirectoCollectionViaProductoCostoIndirecto'. These settings will be taken into account
		''' when the property CostoIndirectoCollectionViaProductoCostoIndirecto is requested or GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCostoIndirectoCollectionViaProductoCostoIndirecto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_costoIndirectoCollectionViaProductoCostoIndirecto.SortClauses=sortClauses
			_costoIndirectoCollectionViaProductoCostoIndirecto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecioCollectionViaListaPrecioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecioCollectionViaListaPrecioDetalle(forceFetch, _listaPrecioCollectionViaListaPrecioDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecioCollectionViaListaPrecioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle Or forceFetch Or _alwaysFetchListaPrecioCollectionViaListaPrecioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecioCollectionViaListaPrecioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecioCollectionViaListaPrecioDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.ListaPrecioDetalleEntityUsingProducto, "__ProductoEntity__", "ListaPrecioDetalle_", JoinHint.None)
				relations.Add(ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios, "ListaPrecioDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_listaPrecioCollectionViaListaPrecioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecioCollectionViaListaPrecioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecioCollectionViaListaPrecioDetalle.GetMulti(Filter, relations)
				_listaPrecioCollectionViaListaPrecioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle = True
			End If
			Return _listaPrecioCollectionViaListaPrecioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecioCollectionViaListaPrecioDetalle'. These settings will be taken into account
		''' when the property ListaPrecioCollectionViaListaPrecioDetalle is requested or GetMultiListaPrecioCollectionViaListaPrecioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecioCollectionViaListaPrecioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecioCollectionViaListaPrecioDetalle.SortClauses=sortClauses
			_listaPrecioCollectionViaListaPrecioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor(forceFetch, _mcecatLotesCabCollectionViaMcecatLotesCabFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaMcecatLotesCabFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaMcecatLotesCabFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.McecatLotesCabForEntityUsingIdFormula, "__ProductoEntity__", "McecatLotesCabFor_", JoinHint.None)
				relations.Add(McecatLotesCabForEntity.Relations.McecatLotesCabEntityUsingIdLote, "McecatLotesCabFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcecatLotesCabCollectionViaMcecatLotesCabFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaMcecatLotesCabFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaMcecatLotesCabFor.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaMcecatLotesCabFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor = True
			End If
			Return _mcecatLotesCabCollectionViaMcecatLotesCabFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaMcecatLotesCabFor'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaMcecatLotesCabFor is requested or GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaMcecatLotesCabFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaMcecatLotesCabFor.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaMcecatLotesCabFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoEntity'</returns>
		Public Function GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle(forceFetch, _mcomPresupuestoCollectionViaMcomPresupuestoDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			If ( Not _alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle Or forceFetch Or _alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomPresupuestoCollectionViaMcomPresupuestoDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomPresupuestoCollectionViaMcomPresupuestoDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.PresupuestoCompraDetalleEntityUsingProductoId, "__ProductoEntity__", "PresupuestoCompraDetalle_", JoinHint.None)
				relations.Add(PresupuestoCompraDetalleEntity.Relations.PresupuestoEntityUsingPresupuestoId, "PresupuestoCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.GetMulti(Filter, relations)
				_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle = True
			End If
			Return _mcomPresupuestoCollectionViaMcomPresupuestoDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomPresupuestoCollectionViaMcomPresupuestoDetalle'. These settings will be taken into account
		''' when the property McomPresupuestoCollectionViaMcomPresupuestoDetalle is requested or GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomPresupuestoCollectionViaMcomPresupuestoDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.SortClauses=sortClauses
			_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoEntity'</returns>
		Public Function GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Return GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle(forceFetch, _solicitudProductoCollectionViaSolicitudProductoDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			If ( Not _alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle Or forceFetch Or _alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProductoCollectionViaSolicitudProductoDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProductoCollectionViaSolicitudProductoDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.SolicitudProductoDetalleEntityUsingIdProducto, "__ProductoEntity__", "SolicitudProductoDetalle_", JoinHint.None)
				relations.Add(SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, "SolicitudProductoDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_solicitudProductoCollectionViaSolicitudProductoDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProductoCollectionViaSolicitudProductoDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProductoCollectionViaSolicitudProductoDetalle.GetMulti(Filter, relations)
				_solicitudProductoCollectionViaSolicitudProductoDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle = True
			End If
			Return _solicitudProductoCollectionViaSolicitudProductoDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProductoCollectionViaSolicitudProductoDetalle'. These settings will be taken into account
		''' when the property SolicitudProductoCollectionViaSolicitudProductoDetalle is requested or GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProductoCollectionViaSolicitudProductoDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProductoCollectionViaSolicitudProductoDetalle.SortClauses=sortClauses
			_solicitudProductoCollectionViaSolicitudProductoDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaInventarioAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaInventarioAlmacen(forceFetch, _almacenCollectionViaInventarioAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaInventarioAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaInventarioAlmacen Or forceFetch Or _alwaysFetchAlmacenCollectionViaInventarioAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaInventarioAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaInventarioAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.InventarioAlmacenEntityUsingProductoId, "__ProductoEntity__", "InventarioAlmacen_", JoinHint.None)
				relations.Add(InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, "InventarioAlmacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaInventarioAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaInventarioAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaInventarioAlmacen.GetMulti(Filter, relations)
				_almacenCollectionViaInventarioAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaInventarioAlmacen = True
			End If
			Return _almacenCollectionViaInventarioAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaInventarioAlmacen'. These settings will be taken into account
		''' when the property AlmacenCollectionViaInventarioAlmacen is requested or GetMultiAlmacenCollectionViaInventarioAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaInventarioAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaInventarioAlmacen.SortClauses=sortClauses
			_almacenCollectionViaInventarioAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch, _almacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes Or forceFetch Or _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViainventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViainventarioAlmacenLotes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, "__ProductoEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.AlmacenEntityUsingAlmacenId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViainventarioAlmacenLotes.GetMulti(Filter, relations)
				_almacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = True
			End If
			Return _almacenCollectionViainventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViainventarioAlmacenLotes'. These settings will be taken into account
		''' when the property AlmacenCollectionViainventarioAlmacenLotes is requested or GetMultiAlmacenCollectionViainventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViainventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViainventarioAlmacenLotes.SortClauses=sortClauses
			_almacenCollectionViainventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioAlmacenEntity'</returns>
		Public Function GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Return GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes(forceFetch, _inventarioAlmacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			If ( Not _alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes Or forceFetch Or _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioAlmacenCollectionViainventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioAlmacenCollectionViainventarioAlmacenLotes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, "__ProductoEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioAlmacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioAlmacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioAlmacenCollectionViainventarioAlmacenLotes.GetMulti(Filter, relations)
				_inventarioAlmacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = True
			End If
			Return _inventarioAlmacenCollectionViainventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioAlmacenCollectionViainventarioAlmacenLotes'. These settings will be taken into account
		''' when the property InventarioAlmacenCollectionViainventarioAlmacenLotes is requested or GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioAlmacenCollectionViainventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioAlmacenCollectionViainventarioAlmacenLotes.SortClauses=sortClauses
			_inventarioAlmacenCollectionViainventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch, _almacenCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles Or forceFetch Or _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaInventarioMovimientoAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaInventarioMovimientoAlmacenDetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, "__ProductoEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.AlmacenEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaInventarioMovimientoAlmacenDetalles.GetMulti(Filter, relations)
				_almacenCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = True
			End If
			Return _almacenCollectionViaInventarioMovimientoAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaInventarioMovimientoAlmacenDetalles'. These settings will be taken into account
		''' when the property AlmacenCollectionViaInventarioMovimientoAlmacenDetalles is requested or GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles.SortClauses=sortClauses
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(forceFetch, _inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles Or forceFetch Or _alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, "__ProductoEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.GetMulti(Filter, relations)
				_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = True
			End If
			Return _inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles'. These settings will be taken into account
		''' when the property InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles is requested or GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.SortClauses=sortClauses
			_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch, _almacenCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvMovimientosAlmacenPvdetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, "__ProductoEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.GetMulti(Filter, relations)
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _almacenCollectionViaMinvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is requested or GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Return GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch, _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			If ( Not _alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, "__ProductoEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.GetMulti(Filter, relations)
				_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles is requested or GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingIdProducto, "__ProductoEntity__", "MinvTransferenciaAlmacenEntradaDetalle_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaDetalleEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenEntradaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.GetMulti(Filter, relations)
				_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = True
			End If
			Return _minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle is requested or GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingIdProducto, "__ProductoEntity__", "MinvTransferenciaAlmacenSalidaDetalle_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenSalidaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.GetMulti(Filter, relations)
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = True
			End If
			Return _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle is requested or GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle(forceFetch, _mventaNotasVentaCollectionViaMventaNotaVentaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			If ( Not _alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle Or forceFetch Or _alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mventaNotasVentaCollectionViaMventaNotaVentaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mventaNotasVentaCollectionViaMventaNotaVentaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.NotaVentaDetalleEntityUsingProducto, "__ProductoEntity__", "NotaVentaDetalle_", JoinHint.None)
				relations.Add(NotaVentaDetalleEntity.Relations.NotaVentaEntityUsingNotaVenta, "NotaVentaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.GetMulti(Filter, relations)
				_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle = True
			End If
			Return _mventaNotasVentaCollectionViaMventaNotaVentaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MventaNotasVentaCollectionViaMventaNotaVentaDetalle'. These settings will be taken into account
		''' when the property MventaNotasVentaCollectionViaMventaNotaVentaDetalle is requested or GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMventaNotasVentaCollectionViaMventaNotaVentaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.SortClauses=sortClauses
			_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaUsrAlmInvFisico(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaUsrAlmInvFisico(forceFetch, _almacenCollectionViaUsrAlmInvFisico.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaUsrAlmInvFisico(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico Or forceFetch Or _alwaysFetchAlmacenCollectionViaUsrAlmInvFisico) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaUsrAlmInvFisico.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaUsrAlmInvFisico)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.InventarioFisicoEntityUsingProductoId, "__ProductoEntity__", "InventarioFisico_", JoinHint.None)
				relations.Add(InventarioFisicoEntity.Relations.AlmacenEntityUsingAlmacenId, "InventarioFisico_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaUsrAlmInvFisico.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaUsrAlmInvFisico.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaUsrAlmInvFisico.GetMulti(Filter, relations)
				_almacenCollectionViaUsrAlmInvFisico.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico = True
			End If
			Return _almacenCollectionViaUsrAlmInvFisico
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaUsrAlmInvFisico'. These settings will be taken into account
		''' when the property AlmacenCollectionViaUsrAlmInvFisico is requested or GetMultiAlmacenCollectionViaUsrAlmInvFisico is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaUsrAlmInvFisico(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaUsrAlmInvFisico.SortClauses=sortClauses
			_almacenCollectionViaUsrAlmInvFisico.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch, _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__ProductoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle is requested or GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch, _recepcionGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			If ( Not _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionGanadoCollectionViaUsrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionGanadoCollectionViaUsrProdRecepcionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__ProductoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ProductoFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.GetMulti(Filter, relations)
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = True
			End If
			Return _recepcionGanadoCollectionViaUsrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionGanadoCollectionViaUsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is requested or GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SortClauses=sortClauses
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'LineaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'LineaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleLinea() As LineaEntity
			Return GetSingleLinea(False)
		End Function

		''' <summary>Retrieves the related entity of type 'LineaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'LineaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleLinea(forceFetch As Boolean) As LineaEntity
			If ( Not _alreadyFetchedLinea Or forceFetch Or _alwaysFetchLinea) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New LineaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProductoEntity.Relations.LineaEntityUsingPdIdLinea) Then
					fetchResult = newEntity.FetchUsingPK(Me.PdIdLinea)
				End If
				If Not _lineaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Linea = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), LineaEntity)
					End If
					Me.Linea = newEntity
					_alreadyFetchedLinea = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _linea
		End Function
	
		''' <summary>Retrieves the related entity of type 'PresentacionEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PresentacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePresentacion() As PresentacionEntity
			Return GetSinglePresentacion(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PresentacionEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PresentacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePresentacion(forceFetch As Boolean) As PresentacionEntity
			If ( Not _alreadyFetchedPresentacion Or forceFetch Or _alwaysFetchPresentacion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PresentacionEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoPresentacion)
				End If
				If Not _presentacionReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Presentacion = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PresentacionEntity)
					End If
					Me.Presentacion = newEntity
					_alreadyFetchedPresentacion = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _presentacion
		End Function
	
		''' <summary>Retrieves the related entity of type 'TipoProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoProducto() As TipoProductoEntity
			Return GetSingleTipoProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoProducto(forceFetch As Boolean) As TipoProductoEntity
			If ( Not _alreadyFetchedTipoProducto Or forceFetch Or _alwaysFetchTipoProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoTipoProducto)
				End If
				If Not _tipoProductoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoProducto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoProductoEntity)
					End If
					Me.TipoProducto = newEntity
					_alreadyFetchedTipoProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoProducto
		End Function
	
		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida() As UnidadMedidaEntity
			Return GetSingleUnidadMedida(False)
		End Function

		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida(forceFetch As Boolean) As UnidadMedidaEntity
			If ( Not _alreadyFetchedUnidadMedida Or forceFetch Or _alwaysFetchUnidadMedida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New UnidadMedidaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoUnidadMedida)
				End If
				If Not _unidadMedidaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.UnidadMedida = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), UnidadMedidaEntity)
					End If
					Me.UnidadMedida = newEntity
					_alreadyFetchedUnidadMedida = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _unidadMedida
		End Function
	
		''' <summary>Retrieves the related entity of type 'MarcaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MarcaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMarca() As MarcaEntity
			Return GetSingleMarca(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MarcaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MarcaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMarca(forceFetch As Boolean) As MarcaEntity
			If ( Not _alreadyFetchedMarca Or forceFetch Or _alwaysFetchMarca) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MarcaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProductoEntity.Relations.MarcaEntityUsingCodigoMarca) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoMarca)
				End If
				If Not _marcaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Marca = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MarcaEntity)
					End If
					Me.Marca = newEntity
					_alreadyFetchedMarca = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _marca
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'CabMediReimEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'CabMediReimEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMediReim() As CabMediReimEntity
			Return GetSingleCabMediReim(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabMediReimEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabMediReimEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMediReim(forceFetch As Boolean) As CabMediReimEntity
			If ( Not _alreadyFetchedCabMediReim Or forceFetch Or _alwaysFetchCabMediReim) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New CabMediReimEntity()
				Dim relation As IEntityRelation = ProductoEntity.Relations.CabMediReimEntityUsingCveMedi
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
				End If
				If Not _cabMediReimReturnsNewIfNotFound And Not fetchResult Then
					Me.CabMediReim = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabMediReimEntity)
					End If
					Me.CabMediReim = newEntity
					_alreadyFetchedCabMediReim = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabMediReim
		End Function
	
		''' <summary>Retrieves the related entity of type 'CabMediTrabEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'CabMediTrabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMediTrab() As CabMediTrabEntity
			Return GetSingleCabMediTrab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabMediTrabEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabMediTrabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMediTrab(forceFetch As Boolean) As CabMediTrabEntity
			If ( Not _alreadyFetchedCabMediTrab Or forceFetch Or _alwaysFetchCabMediTrab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New CabMediTrabEntity()
				Dim relation As IEntityRelation = ProductoEntity.Relations.CabMediTrabEntityUsingCveMedi
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
				End If
				If Not _cabMediTrabReturnsNewIfNotFound And Not fetchResult Then
					Me.CabMediTrab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabMediTrabEntity)
					End If
					Me.CabMediTrab = newEntity
					_alreadyFetchedCabMediTrab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabMediTrab
		End Function
	
		''' <summary>Retrieves the related entity of type 'CostoProductoEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'CostoProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCostoProducto() As CostoProductoEntity
			Return GetSingleCostoProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CostoProductoEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CostoProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCostoProducto(forceFetch As Boolean) As CostoProductoEntity
			If ( Not _alreadyFetchedCostoProducto Or forceFetch Or _alwaysFetchCostoProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New CostoProductoEntity()
				Dim relation As IEntityRelation = ProductoEntity.Relations.CostoProductoEntityUsingProductoId
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
				End If
				If Not _costoProductoReturnsNewIfNotFound And Not fetchResult Then
					Me.CostoProducto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CostoProductoEntity)
					End If
					Me.CostoProducto = newEntity
					_alreadyFetchedCostoProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _costoProducto
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ProductoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ProductoFieldIndex)



					Case ProductoFieldIndex.PdIdLinea
						DesetupSyncLinea(True, False)
						_alreadyFetchedLinea = False
					Case ProductoFieldIndex.CodigoUnidadMedida
						DesetupSyncUnidadMedida(True, False)
						_alreadyFetchedUnidadMedida = False
					Case ProductoFieldIndex.CodigoMarca
						DesetupSyncMarca(True, False)
						_alreadyFetchedMarca = False
					Case ProductoFieldIndex.CodigoPresentacion
						DesetupSyncPresentacion(True, False)
						_alreadyFetchedPresentacion = False




















					Case ProductoFieldIndex.CodigoTipoProducto
						DesetupSyncTipoProducto(True, False)
						_alreadyFetchedTipoProducto = False












					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_aplicMediDet.ActiveContext = MyBase.ActiveContext
			_aplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_cabPrepForm.ActiveContext = MyBase.ActiveContext
			_cabPrepForm_.ActiveContext = MyBase.ActiveContext
			_detAlimentos.ActiveContext = MyBase.ActiveContext
			_detalleKitPv.ActiveContext = MyBase.ActiveContext
			_detalleKitPv_.ActiveContext = MyBase.ActiveContext
			_detAplFor.ActiveContext = MyBase.ActiveContext
			_detDproMed.ActiveContext = MyBase.ActiveContext
			_detPrepForm.ActiveContext = MyBase.ActiveContext
			_detPrepFormLote.ActiveContext = MyBase.ActiveContext
			_detProMed.ActiveContext = MyBase.ActiveContext
			_invHistorialPv.ActiveContext = MyBase.ActiveContext
			_costoProductoProveedor.ActiveContext = MyBase.ActiveContext
			_productoCostoIndirecto.ActiveContext = MyBase.ActiveContext
			_productoMezcla.ActiveContext = MyBase.ActiveContext
			_productoMezcla_.ActiveContext = MyBase.ActiveContext
			_listaPrecioDetalle.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabFor.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_mcomPresupuestoDetalle.ActiveContext = MyBase.ActiveContext
			_mcomRecepcionOrdenCompraDet.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalle.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacen.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientosAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_minvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntradaDetalle.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaDetalle.ActiveContext = MyBase.ActiveContext
			_mventaNotaVentaDetalle.ActiveContext = MyBase.ActiveContext
			_usrAlmInvFisico.ActiveContext = MyBase.ActiveContext
			_usrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_aplicMediDetCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm____.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm______.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______.ActiveContext = MyBase.ActiveContext
			_catNutrientesCollectionViaDetAlimentos.ActiveContext = MyBase.ActiveContext
			_cabAplForCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_cabProMedCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_detProMedCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_cabPrepFormCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_cabPrepFormCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_detPrepFormCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_cabProMedCollectionViaDetProMed.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaInvHistorialPv.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCostoProductoProveedor.ActiveContext = MyBase.ActiveContext
			_costoIndirectoCollectionViaProductoCostoIndirecto.ActiveContext = MyBase.ActiveContext
			_listaPrecioCollectionViaListaPrecioDetalle.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaMcecatLotesCabFor.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_ordenCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_mcomPresupuestoCollectionViaMcomPresupuestoDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoCollectionViaSolicitudProductoDetalle.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaInventarioAlmacen.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacenCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle.ActiveContext = MyBase.ActiveContext
			_mventaNotasVentaCollectionViaMventaNotaVentaDetalle.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaUsrAlmInvFisico.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
		If Not _linea Is Nothing Then
				_linea.ActiveContext = MyBase.ActiveContext
			End If
		If Not _presentacion Is Nothing Then
				_presentacion.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoProducto Is Nothing Then
				_tipoProducto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _unidadMedida Is Nothing Then
				_unidadMedida.ActiveContext = MyBase.ActiveContext
			End If
		If Not _marca Is Nothing Then
				_marca.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cabMediReim Is Nothing Then
				_cabMediReim.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cabMediTrab Is Nothing Then
				_cabMediTrab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _costoProducto Is Nothing Then
				_costoProducto.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ProductoDAO = CType(CreateDAOInstance(), ProductoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ProductoDAO = CType(CreateDAOInstance(), ProductoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ProductoDAO = CType(CreateDAOInstance(), ProductoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ProductoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProductoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <param name="validator">The validator Object for this ProductoEntity</param>
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
			_aplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_aplicMediDet.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchAplicMediDet = False
			_alreadyFetchedAplicMediDet = False
			_aplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(New AplicMediDetDetEntityFactory())
			_aplicMediDetDet.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchAplicMediDetDet = False
			_alreadyFetchedAplicMediDetDet = False
			_cabPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchCabPrepForm = False
			_alreadyFetchedCabPrepForm = False
			_cabPrepForm_ = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm_.SetContainingEntityInfo(Me, "Envase")
			_alwaysFetchCabPrepForm_ = False
			_alreadyFetchedCabPrepForm_ = False
			_detAlimentos = New Integralab.ORM.CollectionClasses.DetAlimentosCollection(New DetAlimentosEntityFactory())
			_detAlimentos.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetAlimentos = False
			_alreadyFetchedDetAlimentos = False
			_detalleKitPv = New Integralab.ORM.CollectionClasses.DetalleKitPvCollection(New DetalleKitPvEntityFactory())
			_detalleKitPv.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetalleKitPv = False
			_alreadyFetchedDetalleKitPv = False
			_detalleKitPv_ = New Integralab.ORM.CollectionClasses.DetalleKitPvCollection(New DetalleKitPvEntityFactory())
			_detalleKitPv_.SetContainingEntityInfo(Me, "Producto_")
			_alwaysFetchDetalleKitPv_ = False
			_alreadyFetchedDetalleKitPv_ = False
			_detAplFor = New Integralab.ORM.CollectionClasses.DetAplForCollection(New DetAplForEntityFactory())
			_detAplFor.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetAplFor = False
			_alreadyFetchedDetAplFor = False
			_detDproMed = New Integralab.ORM.CollectionClasses.DetDproMedCollection(New DetDproMedEntityFactory())
			_detDproMed.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetDproMed = False
			_alreadyFetchedDetDproMed = False
			_detPrepForm = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_detPrepForm.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetPrepForm = False
			_alreadyFetchedDetPrepForm = False
			_detPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(New DetPrepFormLoteEntityFactory())
			_detPrepFormLote.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetPrepFormLote = False
			_alreadyFetchedDetPrepFormLote = False
			_detProMed = New Integralab.ORM.CollectionClasses.DetProMedCollection(New DetProMedEntityFactory())
			_detProMed.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchDetProMed = False
			_alreadyFetchedDetProMed = False
			_invHistorialPv = New Integralab.ORM.CollectionClasses.InvHistorialPvCollection(New InvHistorialPvEntityFactory())
			_invHistorialPv.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchInvHistorialPv = False
			_alreadyFetchedInvHistorialPv = False
			_costoProductoProveedor = New Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection(New CostoProductoProveedorEntityFactory())
			_costoProductoProveedor.SetContainingEntityInfo(Me, "Producto_")
			_alwaysFetchCostoProductoProveedor = False
			_alreadyFetchedCostoProductoProveedor = False
			_productoCostoIndirecto = New Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection(New ProductoCostoIndirectoEntityFactory())
			_productoCostoIndirecto.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchProductoCostoIndirecto = False
			_alreadyFetchedProductoCostoIndirecto = False
			_productoMezcla = New Integralab.ORM.CollectionClasses.ProductoMezclaCollection(New ProductoMezclaEntityFactory())
			_productoMezcla.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchProductoMezcla = False
			_alreadyFetchedProductoMezcla = False
			_productoMezcla_ = New Integralab.ORM.CollectionClasses.ProductoMezclaCollection(New ProductoMezclaEntityFactory())
			_productoMezcla_.SetContainingEntityInfo(Me, "Producto_")
			_alwaysFetchProductoMezcla_ = False
			_alreadyFetchedProductoMezcla_ = False
			_listaPrecioDetalle = New Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection(New ListaPrecioDetalleEntityFactory())
			_listaPrecioDetalle.SetContainingEntityInfo(Me, "Producto_")
			_alwaysFetchListaPrecioDetalle = False
			_alreadyFetchedListaPrecioDetalle = False
			_mcecatLotesCabFor = New Integralab.ORM.CollectionClasses.McecatLotesCabForCollection(New McecatLotesCabForEntityFactory())
			_mcecatLotesCabFor.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMcecatLotesCabFor = False
			_alreadyFetchedMcecatLotesCabFor = False
			_mcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(New McomCotizacionCompraProveedorDetalleEntityFactory())
			_mcomCotizacionCompraProveedorDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = False
			_ordenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(New OrdenCompraDetalleEntityFactory())
			_ordenCompraDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraDetalle = False
			_mcomPresupuestoDetalle = New Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection(New PresupuestoCompraDetalleEntityFactory())
			_mcomPresupuestoDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMcomPresupuestoDetalle = False
			_alreadyFetchedMcomPresupuestoDetalle = False
			_mcomRecepcionOrdenCompraDet = New Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection(New McomRecepcionOrdenCompraDetEntityFactory())
			_mcomRecepcionOrdenCompraDet.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMcomRecepcionOrdenCompraDet = False
			_alreadyFetchedMcomRecepcionOrdenCompraDet = False
			_solicitudProductoDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_solicitudProductoDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchSolicitudProductoDetalle = False
			_alreadyFetchedSolicitudProductoDetalle = False
			_inventarioAlmacen = New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(New InventarioAlmacenEntityFactory())
			_inventarioAlmacen.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchInventarioAlmacen = False
			_alreadyFetchedInventarioAlmacen = False
			_inventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(New inventarioAlmacenLotesEntityFactory())
			_inventarioAlmacenLotes.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchInventarioAlmacenLotes = False
			_alreadyFetchedInventarioAlmacenLotes = False
			_inventarioMovimientosAlmacenDetalles = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(New InventarioMovimientoAlmacenDetallesEntityFactory())
			_inventarioMovimientosAlmacenDetalles.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchInventarioMovimientosAlmacenDetalles = False
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = False
			_minvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(New MinvMovimientosAlmacenPvdetallesEntityFactory())
			_minvMovimientosAlmacenPvdetalles.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = False
			_minvTransferenciaAlmacenEntradaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection(New MinvTransferenciaAlmacenEntradaDetalleEntityFactory())
			_minvTransferenciaAlmacenEntradaDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = False
			_minvTransferenciaAlmacenSalidaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection(New MinvTransferenciaAlmacenSalidaDetalleEntityFactory())
			_minvTransferenciaAlmacenSalidaDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = False
			_mventaNotaVentaDetalle = New Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection(New NotaVentaDetalleEntityFactory())
			_mventaNotaVentaDetalle.SetContainingEntityInfo(Me, "Producto_")
			_alwaysFetchMventaNotaVentaDetalle = False
			_alreadyFetchedMventaNotaVentaDetalle = False
			_usrAlmInvFisico = New Integralab.ORM.CollectionClasses.InventarioFisicoCollection(New InventarioFisicoEntityFactory())
			_usrAlmInvFisico.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchUsrAlmInvFisico = False
			_alreadyFetchedUsrAlmInvFisico = False
			_usrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(New UsrProdRecepcionDetalleEntityFactory())
			_usrProdRecepcionDetalle.SetContainingEntityInfo(Me, "Producto")
			_alwaysFetchUsrProdRecepcionDetalle = False
			_alreadyFetchedUsrProdRecepcionDetalle = False
			_aplicMediCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = False
			_mcecatCorralesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = False
			_mcecatLotesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = False
			_aplicMediCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = False
			_aplicMediDetCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = False
			_mcecatCorralesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_mcecatLotesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = False
			_almacenCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = False
			_almacenCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm_ = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = False
			_plazaCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = False
			_plazaCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm_ = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm____ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm______ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = False
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = False
			_catNutrientesCollectionViaDetAlimentos = New Integralab.ORM.CollectionClasses.CatNutrientesCollection(New CatNutrientesEntityFactory())
			_alwaysFetchCatNutrientesCollectionViaDetAlimentos = False
			_alreadyFetchedCatNutrientesCollectionViaDetAlimentos = False
			_cabAplForCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_alwaysFetchCabAplForCollectionViaDetAplFor = False
			_alreadyFetchedCabAplForCollectionViaDetAplFor = False
			_mcecatCorralesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = False
			_mcecatLotesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = False
			_cabProMedCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.CabProMedCollection(New CabProMedEntityFactory())
			_alwaysFetchCabProMedCollectionViaDetDproMed = False
			_alreadyFetchedCabProMedCollectionViaDetDproMed = False
			_detProMedCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.DetProMedCollection(New DetProMedEntityFactory())
			_alwaysFetchDetProMedCollectionViaDetDproMed = False
			_alreadyFetchedDetProMedCollectionViaDetDproMed = False
			_mcecatLotesCabCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = False
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = False
			_cabPrepFormCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_alwaysFetchCabPrepFormCollectionViaDetPrepForm = False
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = False
			_plazaCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaDetPrepForm = False
			_alreadyFetchedPlazaCollectionViaDetPrepForm = False
			_cabPrepFormCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote = False
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = False
			_detPrepFormCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = False
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = False
			_plazaCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaDetPrepFormLote = False
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = False
			_cabProMedCollectionViaDetProMed = New Integralab.ORM.CollectionClasses.CabProMedCollection(New CabProMedEntityFactory())
			_alwaysFetchCabProMedCollectionViaDetProMed = False
			_alreadyFetchedCabProMedCollectionViaDetProMed = False
			_almacenCollectionViaInvHistorialPv = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaInvHistorialPv = False
			_alreadyFetchedAlmacenCollectionViaInvHistorialPv = False
			_proveedorCollectionViaCostoProductoProveedor = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCostoProductoProveedor = False
			_alreadyFetchedProveedorCollectionViaCostoProductoProveedor = False
			_costoIndirectoCollectionViaProductoCostoIndirecto = New Integralab.ORM.CollectionClasses.CostoIndirectoCollection(New CostoIndirectoEntityFactory())
			_alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto = False
			_alreadyFetchedCostoIndirectoCollectionViaProductoCostoIndirecto = False
			_listaPrecioCollectionViaListaPrecioDetalle = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_alwaysFetchListaPrecioCollectionViaListaPrecioDetalle = False
			_alreadyFetchedListaPrecioCollectionViaListaPrecioDetalle = False
			_mcecatLotesCabCollectionViaMcecatLotesCabFor = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor = False
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesCabFor = False
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_mcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(New McomCotizacionCompraProveedorEntityFactory())
			_alwaysFetchMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = False
			_cotizacionCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_ordenCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_alwaysFetchOrdenCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraCollectionViaOrdenCompraDetalle = False
			_solicitudProductoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_mcomPresupuestoCollectionViaMcomPresupuestoDetalle = New Integralab.ORM.CollectionClasses.PresupuestoCollection(New PresupuestoEntityFactory())
			_alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle = False
			_alreadyFetchedMcomPresupuestoCollectionViaMcomPresupuestoDetalle = False
			_solicitudProductoCollectionViaSolicitudProductoDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle = False
			_alreadyFetchedSolicitudProductoCollectionViaSolicitudProductoDetalle = False
			_almacenCollectionViaInventarioAlmacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaInventarioAlmacen = False
			_alreadyFetchedAlmacenCollectionViaInventarioAlmacen = False
			_almacenCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = False
			_inventarioAlmacenCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(New InventarioAlmacenEntityFactory())
			_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = False
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_inventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = False
			_alreadyFetchedInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = False
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(New MinvMovimientosAlmacenPvEntityFactory())
			_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_minvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = False
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = False
			_mventaNotasVentaCollectionViaMventaNotaVentaDetalle = New Integralab.ORM.CollectionClasses.NotaVentaCollection(New NotaVentaEntityFactory())
			_alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle = False
			_alreadyFetchedMventaNotasVentaCollectionViaMventaNotaVentaDetalle = False
			_almacenCollectionViaUsrAlmInvFisico = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaUsrAlmInvFisico = False
			_alreadyFetchedAlmacenCollectionViaUsrAlmInvFisico = False
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(New RecepcionGanadoEntityFactory())
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = False
			_linea = Nothing
			_lineaReturnsNewIfNotFound = True
			_alwaysFetchLinea = False
			_alreadyFetchedLinea = False
			_presentacion = Nothing
			_presentacionReturnsNewIfNotFound = True
			_alwaysFetchPresentacion = False
			_alreadyFetchedPresentacion = False
			_tipoProducto = Nothing
			_tipoProductoReturnsNewIfNotFound = True
			_alwaysFetchTipoProducto = False
			_alreadyFetchedTipoProducto = False
			_unidadMedida = Nothing
			_unidadMedidaReturnsNewIfNotFound = True
			_alwaysFetchUnidadMedida = False
			_alreadyFetchedUnidadMedida = False
			_marca = Nothing
			_marcaReturnsNewIfNotFound = True
			_alwaysFetchMarca = False
			_alreadyFetchedMarca = False
			_cabMediReim = Nothing
			_cabMediReimReturnsNewIfNotFound = True
			_alwaysFetchCabMediReim = False
			_alreadyFetchedCabMediReim = False
			_cabMediTrab = Nothing
			_cabMediTrabReturnsNewIfNotFound = True
			_alwaysFetchCabMediTrab = False
			_alreadyFetchedCabMediTrab = False
			_costoProducto = Nothing
			_costoProductoReturnsNewIfNotFound = True
			_alwaysFetchCostoProducto = False
			_alreadyFetchedCostoProducto = False
			
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

			_fieldsCustomProperties.Add("DescrpcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PdIdLinea", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoUnidadMedida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoMarca", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPresentacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeRecibeParcial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeObtieneMermas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeRecibeSinFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeFacturaSinExistencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeManejaPorLotes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ProductoGeneral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsMezcla", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsIngrediente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsMaterialEnvase", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasMinCaducidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
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

			_fieldsCustomProperties.Add("ObservacionBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoRelacionado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoTipoProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PdCaduca", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SeAplicaIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FactorConver", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UltimoCosto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ArtPuntoVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ArtMeat", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PorcIeps", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PdEsKit", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _linea</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncLinea(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _linea, AddressOf OnLineaPropertyChanged, "Linea", ProductoEntity.Relations.LineaEntityUsingPdIdLinea, True, signalRelatedEntity, "Producto", resetFKFields, New Integer() { CInt(ProductoFieldIndex.PdIdLinea) } )
			_linea = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _linea</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncLinea(relatedEntity As IEntity)
			DesetupSyncLinea(True, True)
			_linea = CType(relatedEntity, LineaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _linea, AddressOf OnLineaPropertyChanged, "Linea", ProductoEntity.Relations.LineaEntityUsingPdIdLinea, True, _alreadyFetchedLinea, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnLineaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _presentacion</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPresentacion(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _presentacion, AddressOf OnPresentacionPropertyChanged, "Presentacion", ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion, True, signalRelatedEntity, "Producto", resetFKFields, New Integer() { CInt(ProductoFieldIndex.CodigoPresentacion) } )
			_presentacion = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _presentacion</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPresentacion(relatedEntity As IEntity)
			DesetupSyncPresentacion(True, True)
			_presentacion = CType(relatedEntity, PresentacionEntity)
			MyBase.PerformSetupSyncRelatedEntity( _presentacion, AddressOf OnPresentacionPropertyChanged, "Presentacion", ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion, True, _alreadyFetchedPresentacion, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPresentacionPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _tipoProducto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoProducto, AddressOf OnTipoProductoPropertyChanged, "TipoProducto", ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto, True, signalRelatedEntity, "Producto", resetFKFields, New Integer() { CInt(ProductoFieldIndex.CodigoTipoProducto) } )
			_tipoProducto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoProducto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoProducto(relatedEntity As IEntity)
			DesetupSyncTipoProducto(True, True)
			_tipoProducto = CType(relatedEntity, TipoProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoProducto, AddressOf OnTipoProductoPropertyChanged, "TipoProducto", ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto, True, _alreadyFetchedTipoProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _unidadMedida</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncUnidadMedida(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, True, signalRelatedEntity, "Producto", resetFKFields, New Integer() { CInt(ProductoFieldIndex.CodigoUnidadMedida) } )
			_unidadMedida = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _unidadMedida</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncUnidadMedida(relatedEntity As IEntity)
			DesetupSyncUnidadMedida(True, True)
			_unidadMedida = CType(relatedEntity, UnidadMedidaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, True, _alreadyFetchedUnidadMedida, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnUnidadMedidaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _marca</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMarca(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _marca, AddressOf OnMarcaPropertyChanged, "Marca", ProductoEntity.Relations.MarcaEntityUsingCodigoMarca, True, signalRelatedEntity, "Producto", resetFKFields, New Integer() { CInt(ProductoFieldIndex.CodigoMarca) } )
			_marca = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _marca</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMarca(relatedEntity As IEntity)
			DesetupSyncMarca(True, True)
			_marca = CType(relatedEntity, MarcaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _marca, AddressOf OnMarcaPropertyChanged, "Marca", ProductoEntity.Relations.MarcaEntityUsingCodigoMarca, True, _alreadyFetchedMarca, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMarcaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _cabMediReim</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabMediReim(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabMediReim, AddressOf OnCabMediReimPropertyChanged, "CabMediReim", ProductoEntity.Relations.CabMediReimEntityUsingCveMedi, False, signalRelatedEntity, "Producto", False, New Integer() { CInt(ProductoFieldIndex.Codigo) } )
			_cabMediReim = Nothing
		End Sub

		''' <summary>setups the sync logic for member _cabMediReim</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabMediReim(relatedEntity As IEntity)
			DesetupSyncCabMediReim(True, True)
			_cabMediReim = CType(relatedEntity, CabMediReimEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabMediReim, AddressOf OnCabMediReimPropertyChanged, "CabMediReim", ProductoEntity.Relations.CabMediReimEntityUsingCveMedi, False, _alreadyFetchedCabMediReim, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabMediReimPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cabMediTrab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabMediTrab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabMediTrab, AddressOf OnCabMediTrabPropertyChanged, "CabMediTrab", ProductoEntity.Relations.CabMediTrabEntityUsingCveMedi, False, signalRelatedEntity, "Producto", False, New Integer() { CInt(ProductoFieldIndex.Codigo) } )
			_cabMediTrab = Nothing
		End Sub

		''' <summary>setups the sync logic for member _cabMediTrab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabMediTrab(relatedEntity As IEntity)
			DesetupSyncCabMediTrab(True, True)
			_cabMediTrab = CType(relatedEntity, CabMediTrabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabMediTrab, AddressOf OnCabMediTrabPropertyChanged, "CabMediTrab", ProductoEntity.Relations.CabMediTrabEntityUsingCveMedi, False, _alreadyFetchedCabMediTrab, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabMediTrabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _costoProducto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCostoProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _costoProducto, AddressOf OnCostoProductoPropertyChanged, "CostoProducto", ProductoEntity.Relations.CostoProductoEntityUsingProductoId, False, signalRelatedEntity, "Producto", False, New Integer() { CInt(ProductoFieldIndex.Codigo) } )
			_costoProducto = Nothing
		End Sub

		''' <summary>setups the sync logic for member _costoProducto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCostoProducto(relatedEntity As IEntity)
			DesetupSyncCostoProducto(True, True)
			_costoProducto = CType(relatedEntity, CostoProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _costoProducto, AddressOf OnCostoProductoPropertyChanged, "CostoProducto", ProductoEntity.Relations.CostoProductoEntityUsingProductoId, False, _alreadyFetchedCostoProducto, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCostoProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Producto which data should be fetched into this Producto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ProductoFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateProductoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ProductoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ProductoRelations
			Get	
				Return New ProductoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDetDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(), _
					ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAlimentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAlimentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAlimentosCollection(), _
					ProductoEntity.Relations.DetAlimentosEntityUsingCveAlimento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetAlimentosEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAlimentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetalleKitPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetalleKitPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetalleKitPvCollection(), _
					ProductoEntity.Relations.DetalleKitPvEntityUsingIdKit, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetalleKitPvEntity, Integer), 0, Nothing, Nothing, Nothing, "DetalleKitPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetalleKitPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetalleKitPv_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetalleKitPvCollection(), _
					ProductoEntity.Relations.DetalleKitPvEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetalleKitPvEntity, Integer), 0, Nothing, Nothing, Nothing, "DetalleKitPv_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAplForCollection(), _
					ProductoEntity.Relations.DetAplForEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetDproMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetDproMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetDproMedCollection(), _
					ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetDproMedEntity, Integer), 0, Nothing, Nothing, Nothing, "DetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepFormLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormLote() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(), _
					ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormLoteEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetProMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetProMedCollection(), _
					ProductoEntity.Relations.DetProMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetProMedEntity, Integer), 0, Nothing, Nothing, Nothing, "DetProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InvHistorialPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInvHistorialPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InvHistorialPvCollection(), _
					ProductoEntity.Relations.InvHistorialPvEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InvHistorialPvEntity, Integer), 0, Nothing, Nothing, Nothing, "InvHistorialPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoProductoProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoProductoProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoProductoProveedorCollection(), _
					ProductoEntity.Relations.CostoProductoProveedorEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CostoProductoProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "CostoProductoProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductoCostoIndirecto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCostoIndirecto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection(), _
					ProductoEntity.Relations.ProductoCostoIndirectoEntityUsingCodigoProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoCostoIndirectoEntity, Integer), 0, Nothing, Nothing, Nothing, "ProductoCostoIndirecto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductoMezcla' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoMezcla() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoMezclaCollection(), _
					ProductoEntity.Relations.ProductoMezclaEntityUsingCodigoProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoMezclaEntity, Integer), 0, Nothing, Nothing, Nothing, "ProductoMezcla", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductoMezcla' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoMezcla_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoMezclaCollection(), _
					ProductoEntity.Relations.ProductoMezclaEntityUsingCodigoIngrediente, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoMezclaEntity, Integer), 0, Nothing, Nothing, Nothing, "ProductoMezcla_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecioDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection(), _
					ProductoEntity.Relations.ListaPrecioDetalleEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCabFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabForCollection(), _
					ProductoEntity.Relations.McecatLotesCabForEntityUsingIdFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabForEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCabFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedorDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(), _
					ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PresupuestoCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomPresupuestoDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection(), _
					ProductoEntity.Relations.PresupuestoCompraDetalleEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PresupuestoCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomPresupuestoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomRecepcionOrdenCompraDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomRecepcionOrdenCompraDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection(), _
					ProductoEntity.Relations.McomRecepcionOrdenCompraDetEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McomRecepcionOrdenCompraDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McomRecepcionOrdenCompraDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					ProductoEntity.Relations.SolicitudProductoDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudProductoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(), _
					ProductoEntity.Relations.InventarioAlmacenEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'inventarioAlmacenLotes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(), _
					ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.inventarioAlmacenLotesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacenDetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientosAlmacenDetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(), _
					ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenDetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientosAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPvdetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(), _
					ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntradaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntradaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection(), _
					ProductoEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntradaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalidaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection(), _
					ProductoEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalidaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaVentaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMventaNotaVentaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection(), _
					ProductoEntity.Relations.NotaVentaDetalleEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.NotaVentaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MventaNotaVentaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioFisico' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrAlmInvFisico() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioFisicoCollection(), _
					ProductoEntity.Relations.InventarioFisicoEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioFisicoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrAlmInvFisico", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(), _
					ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					ProductoEntity.Relations.AplicMediDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediDetCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					ProductoEntity.Relations.AplicMediDetDetEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm____() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm_____() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm______() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm_______() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.CabPrepFormEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm_______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatNutrientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatNutrientesCollectionViaDetAlimentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetAlimentosEntityUsingCveAlimento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAlimentosEntity.Relations.CatNutrientesEntityUsingCveNutriente)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatNutrientesCollection(), _
					ProductoEntity.Relations.DetAlimentosEntityUsingCveAlimento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CatNutrientesEntity, Integer), 0, Nothing, Nothing, relations, "CatNutrientesCollectionViaDetAlimentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplForCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					ProductoEntity.Relations.DetAplForEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, relations, "CabAplForCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					ProductoEntity.Relations.DetAplForEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetAplForEntityUsingCveFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					ProductoEntity.Relations.DetAplForEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabProMedCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabProMedCollection(), _
					ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), 0, Nothing, Nothing, relations, "CabProMedCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetProMedCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetProMedCollection(), _
					ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetProMedEntity, Integer), 0, Nothing, Nothing, relations, "DetProMedCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					ProductoEntity.Relations.DetDproMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepFormCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "CabPrepFormCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ProductoEntity.Relations.DetPrepFormEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepFormCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "CabPrepFormCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "DetPrepFormCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ProductoEntity.Relations.DetPrepFormLoteEntityUsingCveProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabProMedCollectionViaDetProMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.DetProMedEntityUsingIdMedicamento, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetProMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabProMedCollection(), _
					ProductoEntity.Relations.DetProMedEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), 0, Nothing, Nothing, relations, "CabProMedCollectionViaDetProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaInvHistorialPv() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.InvHistorialPvEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(InvHistorialPvEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.InvHistorialPvEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaInvHistorialPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCostoProductoProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.CostoProductoProveedorEntityUsingProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(CostoProductoProveedorEntity.Relations.ProveedorEntityUsingProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					ProductoEntity.Relations.CostoProductoProveedorEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCostoProductoProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoIndirecto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoIndirectoCollectionViaProductoCostoIndirecto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.ProductoCostoIndirectoEntityUsingCodigoProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoCostoIndirectoEntity.Relations.CostoIndirectoEntityUsingCodigoCostoIndirecto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoIndirectoCollection(), _
					ProductoEntity.Relations.ProductoCostoIndirectoEntityUsingCodigoProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CostoIndirectoEntity, Integer), 0, Nothing, Nothing, relations, "CostoIndirectoCollectionViaProductoCostoIndirecto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioCollectionViaListaPrecioDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.ListaPrecioDetalleEntityUsingProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					ProductoEntity.Relations.ListaPrecioDetalleEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, relations, "ListaPrecioCollectionViaListaPrecioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaMcecatLotesCabFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McecatLotesCabForEntityUsingIdFormula, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatLotesCabForEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					ProductoEntity.Relations.McecatLotesCabForEntityUsingIdFormula, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaMcecatLotesCabFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					ProductoEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, relations, "McomCotizacionCompraProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, relations, "OrdenCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					ProductoEntity.Relations.OrdenCompraDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presupuesto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomPresupuestoCollectionViaMcomPresupuestoDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.PresupuestoCompraDetalleEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(PresupuestoCompraDetalleEntity.Relations.PresupuestoEntityUsingPresupuestoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresupuestoCollection(), _
					ProductoEntity.Relations.PresupuestoCompraDetalleEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), 0, Nothing, Nothing, relations, "McomPresupuestoCollectionViaMcomPresupuestoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoCollectionViaSolicitudProductoDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.SolicitudProductoDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					ProductoEntity.Relations.SolicitudProductoDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoCollectionViaSolicitudProductoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaInventarioAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.InventarioAlmacenEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.InventarioAlmacenEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaInventarioAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacenCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(), _
					ProductoEntity.Relations.inventarioAlmacenLotesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioAlmacenCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaInventarioMovimientoAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaInventarioMovimientoAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					ProductoEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(), _
					ProductoEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, relations, "MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaDetalleEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferencia)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					ProductoEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferencia)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					ProductoEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMventaNotasVentaCollectionViaMventaNotaVentaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.NotaVentaDetalleEntityUsingProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(NotaVentaDetalleEntity.Relations.NotaVentaEntityUsingNotaVenta)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaVentaCollection(), _
					ProductoEntity.Relations.NotaVentaDetalleEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.NotaVentaEntity, Integer), 0, Nothing, Nothing, relations, "MventaNotasVentaCollectionViaMventaNotaVentaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaUsrAlmInvFisico() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.InventarioFisicoEntityUsingProductoId, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioFisicoEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					ProductoEntity.Relations.InventarioFisicoEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaUsrAlmInvFisico", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanadoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__ProductoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					ProductoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, relations, "RecepcionGanadoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Linea' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathLinea() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.LineaCollection(), _
					ProductoEntity.Relations.LineaEntityUsingPdIdLinea, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.LineaEntity, Integer), 0, Nothing, Nothing, Nothing, "Linea", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presentacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPresentacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresentacionCollection(), _
					ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), 0, Nothing, Nothing, Nothing, "Presentacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoProductoCollection(), _
					ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.TipoProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnidadMedida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUnidadMedida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UnidadMedidaCollection(), _
					ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), 0, Nothing, Nothing, Nothing, "UnidadMedida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Marca' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMarca() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MarcaCollection(), _
					ProductoEntity.Relations.MarcaEntityUsingCodigoMarca, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.MarcaEntity, Integer), 0, Nothing, Nothing, Nothing, "Marca", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMediReim' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMediReim() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMediReimCollection(), _
					ProductoEntity.Relations.CabMediReimEntityUsingCveMedi, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabMediReimEntity, Integer), 0, Nothing, Nothing, Nothing, "CabMediReim", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMediTrab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMediTrab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMediTrabCollection(), _
					ProductoEntity.Relations.CabMediTrabEntityUsingCveMedi, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CabMediTrabEntity, Integer), 0, Nothing, Nothing, Nothing, "CabMediTrab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CostoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCostoProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CostoProductoCollection(), _
					ProductoEntity.Relations.CostoProductoEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.ProductoEntity, Integer), CType(Integralab.ORM.EntityType.CostoProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "CostoProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ProductoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ProductoEntity.CustomProperties
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
				Return ProductoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescrpcionCorta property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdDescrpcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescrpcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.DescrpcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.DescrpcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The PdIdLinea property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdLinea"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PdIdLinea]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.PdIdLinea, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.PdIdLinea, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoUnidadMedida property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdUnidadMedida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoUnidadMedida]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoUnidadMedida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoUnidadMedida, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoMarca property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdMarca"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoMarca]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoMarca, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoMarca, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPresentacion property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdPresentacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPresentacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoPresentacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoPresentacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeFactura property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeFactura]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeRecibeParcial property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeRecibeParcial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeRecibeParcial]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeRecibeParcial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeRecibeParcial, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeObtieneMermas property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeObtieneMermas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeObtieneMermas]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeObtieneMermas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeObtieneMermas, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeRecibeSinFactura property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeRecibeSinFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeRecibeSinFactura]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeRecibeSinFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeRecibeSinFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeFacturaSinExistencia property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeFacturaSinExistencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeFacturaSinExistencia]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeFacturaSinExistencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeFacturaSinExistencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeManejaPorLotes property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeManejaPorLotes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeManejaPorLotes]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeManejaPorLotes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeManejaPorLotes, Integer), value)
			End Set
		End Property
	
		''' <summary>The ProductoGeneral property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdProductoGeneral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ProductoGeneral]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.ProductoGeneral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.ProductoGeneral, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsMezcla property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdMezcla"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsMezcla]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.EsMezcla, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.EsMezcla, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsIngrediente property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIngrediente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsIngrediente]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.EsIngrediente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.EsIngrediente, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsMaterialEnvase property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdMaterialEnvase"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsMaterialEnvase]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.EsMaterialEnvase, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.EsMaterialEnvase, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasMinCaducidad property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdDiasMaxCaducidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasMinCaducidad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.DiasMinCaducidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.DiasMinCaducidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Piezas property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdPiezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Piezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.Piezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.Piezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionBaja property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdObservacionBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.ObservacionBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.ObservacionBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoRelacionado property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdCodigoRelacionado"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodigoRelacionado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoRelacionado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoRelacionado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoTipoProducto property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdTipoProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoTipoProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoTipoProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoTipoProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The PdCaduca property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdCaduca"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PdCaduca]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.PdCaduca, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.PdCaduca, Integer), value)
			End Set
		End Property
	
		''' <summary>The SeAplicaIva property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdSeAplicaIva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SeAplicaIva]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.SeAplicaIva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.SeAplicaIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The FactorConver property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."FactorConver"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FactorConver]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.FactorConver, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.FactorConver, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaCompra property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."FechaUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaCompra]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.FechaUltimaCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.FechaUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadUltimaCompra property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."CantidadUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CantidadUltimaCompra]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CantidadUltimaCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CantidadUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteUltimaCompra property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."ImporteUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteUltimaCompra]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.ImporteUltimaCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.ImporteUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The UltimoCosto property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."UltimoCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UltimoCosto]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.UltimoCosto, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.UltimoCosto, Integer), value)
			End Set
		End Property
	
		''' <summary>The ArtPuntoVenta property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."ArtPuntoVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ArtPuntoVenta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.ArtPuntoVenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.ArtPuntoVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The ArtMeat property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."ArtMeat"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ArtMeat]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.ArtMeat, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.ArtMeat, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoBarra property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."CodigoBarra"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodigoBarra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.CodigoBarra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.CodigoBarra, Integer), value)
			End Set
		End Property
	
		''' <summary>The PorcIeps property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PorcIEPS"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PorcIeps]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.PorcIeps, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.PorcIeps, Integer), value)
			End Set
		End Property
	
		''' <summary>The PdEsKit property of the Entity Producto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProductos"."PdEsKit"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PdEsKit]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProductoFieldIndex.PdEsKit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ProductoFieldIndex.PdEsKit, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediDet]() As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Get
				Return GetMultiAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediDet. When set to true, AplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediDet As Boolean
			Get
				Return _alwaysFetchAplicMediDet
			End Get
			Set
				_alwaysFetchAplicMediDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AplicMediDetDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediDetDet]() As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
			Get
				Return GetMultiAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediDetDet. When set to true, AplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchAplicMediDetDet
			End Get
			Set
				_alwaysFetchAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepForm]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepForm. When set to true, CabPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepForm As Boolean
			Get
				Return _alwaysFetchCabPrepForm
			End Get
			Set
				_alwaysFetchCabPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepForm_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepForm_]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepForm_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepForm_. When set to true, CabPrepForm_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepForm_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepForm_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepForm_ As Boolean
			Get
				Return _alwaysFetchCabPrepForm_
			End Get
			Set
				_alwaysFetchCabPrepForm_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetAlimentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetAlimentos]() As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Get
				Return GetMultiDetAlimentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetAlimentos. When set to true, DetAlimentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetAlimentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetAlimentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetAlimentos As Boolean
			Get
				Return _alwaysFetchDetAlimentos
			End Get
			Set
				_alwaysFetchDetAlimentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetalleKitPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetalleKitPv]() As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Get
				Return GetMultiDetalleKitPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetalleKitPv. When set to true, DetalleKitPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetalleKitPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetalleKitPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetalleKitPv As Boolean
			Get
				Return _alwaysFetchDetalleKitPv
			End Get
			Set
				_alwaysFetchDetalleKitPv = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetalleKitPvEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetalleKitPv_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetalleKitPv_]() As Integralab.ORM.CollectionClasses.DetalleKitPvCollection
			Get
				Return GetMultiDetalleKitPv_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetalleKitPv_. When set to true, DetalleKitPv_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetalleKitPv_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetalleKitPv_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetalleKitPv_ As Boolean
			Get
				Return _alwaysFetchDetalleKitPv_
			End Get
			Set
				_alwaysFetchDetalleKitPv_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetAplFor]() As Integralab.ORM.CollectionClasses.DetAplForCollection
			Get
				Return GetMultiDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetAplFor. When set to true, DetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetAplFor As Boolean
			Get
				Return _alwaysFetchDetAplFor
			End Get
			Set
				_alwaysFetchDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetDproMed]() As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Get
				Return GetMultiDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetDproMed. When set to true, DetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetDproMed As Boolean
			Get
				Return _alwaysFetchDetDproMed
			End Get
			Set
				_alwaysFetchDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepForm]() As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Get
				Return GetMultiDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepForm. When set to true, DetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepForm As Boolean
			Get
				Return _alwaysFetchDetPrepForm
			End Get
			Set
				_alwaysFetchDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepFormLote]() As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Get
				Return GetMultiDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepFormLote. When set to true, DetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchDetPrepFormLote
			End Get
			Set
				_alwaysFetchDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetProMed]() As Integralab.ORM.CollectionClasses.DetProMedCollection
			Get
				Return GetMultiDetProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetProMed. When set to true, DetProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetProMed As Boolean
			Get
				Return _alwaysFetchDetProMed
			End Get
			Set
				_alwaysFetchDetProMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InvHistorialPvEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInvHistorialPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InvHistorialPv]() As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
			Get
				Return GetMultiInvHistorialPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InvHistorialPv. When set to true, InvHistorialPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InvHistorialPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiInvHistorialPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInvHistorialPv As Boolean
			Get
				Return _alwaysFetchInvHistorialPv
			End Get
			Set
				_alwaysFetchInvHistorialPv = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoCostoIndirectoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCostoIndirecto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCostoIndirecto]() As Integralab.ORM.CollectionClasses.ProductoCostoIndirectoCollection
			Get
				Return GetMultiProductoCostoIndirecto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCostoIndirecto. When set to true, ProductoCostoIndirecto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCostoIndirecto is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCostoIndirecto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCostoIndirecto As Boolean
			Get
				Return _alwaysFetchProductoCostoIndirecto
			End Get
			Set
				_alwaysFetchProductoCostoIndirecto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoMezcla()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoMezcla]() As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Get
				Return GetMultiProductoMezcla(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoMezcla. When set to true, ProductoMezcla is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoMezcla is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoMezcla(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoMezcla As Boolean
			Get
				Return _alwaysFetchProductoMezcla
			End Get
			Set
				_alwaysFetchProductoMezcla = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoMezclaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoMezcla_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoMezcla_]() As Integralab.ORM.CollectionClasses.ProductoMezclaCollection
			Get
				Return GetMultiProductoMezcla_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoMezcla_. When set to true, ProductoMezcla_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoMezcla_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoMezcla_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoMezcla_ As Boolean
			Get
				Return _alwaysFetchProductoMezcla_
			End Get
			Set
				_alwaysFetchProductoMezcla_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecioDetalle]() As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Get
				Return GetMultiListaPrecioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioDetalle. When set to true, ListaPrecioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioDetalle As Boolean
			Get
				Return _alwaysFetchListaPrecioDetalle
			End Get
			Set
				_alwaysFetchListaPrecioDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabForEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabFor]() As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
			Get
				Return GetMultiMcecatLotesCabFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabFor. When set to true, McecatLotesCabFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabFor As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabFor
			End Get
			Set
				_alwaysFetchMcecatLotesCabFor = value
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
	
		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomRecepcionOrdenCompraDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomRecepcionOrdenCompraDet]() As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Get
				Return GetMultiMcomRecepcionOrdenCompraDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomRecepcionOrdenCompraDet. When set to true, McomRecepcionOrdenCompraDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomRecepcionOrdenCompraDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomRecepcionOrdenCompraDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomRecepcionOrdenCompraDet As Boolean
			Get
				Return _alwaysFetchMcomRecepcionOrdenCompraDet
			End Get
			Set
				_alwaysFetchMcomRecepcionOrdenCompraDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProductoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProductoDetalle]() As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Get
				Return GetMultiSolicitudProductoDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoDetalle. When set to true, SolicitudProductoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProductoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioAlmacen]() As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Get
				Return GetMultiInventarioAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioAlmacen. When set to true, InventarioAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioAlmacen As Boolean
			Get
				Return _alwaysFetchInventarioAlmacen
			End Get
			Set
				_alwaysFetchInventarioAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Get
				Return GetMultiInventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioAlmacenLotes. When set to true, InventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchInventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchInventarioAlmacenLotes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientosAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientosAlmacenDetalles]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Get
				Return GetMultiInventarioMovimientosAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientosAlmacenDetalles. When set to true, InventarioMovimientosAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientosAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientosAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientosAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchInventarioMovimientosAlmacenDetalles
			End Get
			Set
				_alwaysFetchInventarioMovimientosAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Get
				Return GetMultiMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvMovimientosAlmacenPvdetalles. When set to true, MinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntradaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntradaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntradaDetalle. When set to true, MinvTransferenciaAlmacenEntradaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntradaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntradaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntradaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalidaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalidaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalidaDetalle. When set to true, MinvTransferenciaAlmacenSalidaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalidaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalidaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalidaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaVentaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMventaNotaVentaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MventaNotaVentaDetalle]() As Integralab.ORM.CollectionClasses.NotaVentaDetalleCollection
			Get
				Return GetMultiMventaNotaVentaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MventaNotaVentaDetalle. When set to true, MventaNotaVentaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MventaNotaVentaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMventaNotaVentaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMventaNotaVentaDetalle As Boolean
			Get
				Return _alwaysFetchMventaNotaVentaDetalle
			End Get
			Set
				_alwaysFetchMventaNotaVentaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioFisicoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrAlmInvFisico()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrAlmInvFisico]() As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
			Get
				Return GetMultiUsrAlmInvFisico(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrAlmInvFisico. When set to true, UsrAlmInvFisico is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrAlmInvFisico is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrAlmInvFisico(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrAlmInvFisico As Boolean
			Get
				Return _alwaysFetchUsrAlmInvFisico
			End Get
			Set
				_alwaysFetchUsrAlmInvFisico = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
			Get
				Return GetMultiUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRecepcionDetalle. When set to true, UsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchUsrProdRecepcionDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediCollectionViaAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediCollectionViaAplicMediDet]() As Integralab.ORM.CollectionClasses.AplicMediCollection
			Get
				Return GetMultiAplicMediCollectionViaAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediCollectionViaAplicMediDet. When set to true, AplicMediCollectionViaAplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediCollectionViaAplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediCollectionViaAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediCollectionViaAplicMediDet As Boolean
			Get
				Return _alwaysFetchAplicMediCollectionViaAplicMediDet
			End Get
			Set
				_alwaysFetchAplicMediCollectionViaAplicMediDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaAplicMediDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaAplicMediDet. When set to true, McecatCorralesCabCollectionViaAplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaAplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaAplicMediDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaAplicMediDet]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaAplicMediDet. When set to true, McecatLotesCabCollectionViaAplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaAplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaAplicMediDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.AplicMediCollection
			Get
				Return GetMultiAplicMediCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediCollectionViaAplicMediDetDet. When set to true, AplicMediCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchAplicMediCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchAplicMediCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AplicMediDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMediDetCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMediDetCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.AplicMediDetCollection
			Get
				Return GetMultiAplicMediDetCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediDetCollectionViaAplicMediDetDet. When set to true, AplicMediDetCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediDetCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMediDetCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediDetCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaAplicMediDetDet. When set to true, McecatCorralesCabCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaAplicMediDetDet. When set to true, McecatLotesCabCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabPrepForm]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabPrepForm. When set to true, AlmacenCollectionViaCabPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabPrepForm As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabPrepForm
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabPrepForm_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabPrepForm_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabPrepForm_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabPrepForm_. When set to true, AlmacenCollectionViaCabPrepForm_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabPrepForm_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabPrepForm_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabPrepForm_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabPrepForm_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabPrepForm_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaCabPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaCabPrepForm]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaCabPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaCabPrepForm. When set to true, PlazaCollectionViaCabPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaCabPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaCabPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaCabPrepForm As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaCabPrepForm
			End Get
			Set
				_alwaysFetchPlazaCollectionViaCabPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm_. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm__]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm__. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm___]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm___. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaCabPrepForm_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaCabPrepForm_]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaCabPrepForm_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaCabPrepForm_. When set to true, PlazaCollectionViaCabPrepForm_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaCabPrepForm_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaCabPrepForm_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaCabPrepForm_ As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaCabPrepForm_
			End Get
			Set
				_alwaysFetchPlazaCollectionViaCabPrepForm_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm____]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm____. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm____ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm____ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm____(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm____ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm_____]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm_____. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm_____ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm_____ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_____(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_____ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm______]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm______. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm______ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm______ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm______(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm______ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabPrepForm_______]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabPrepForm_______. When set to true, InventarioMovimientoAlmacenCollectionViaCabPrepForm_______ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabPrepForm_______ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabPrepForm_______(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_______ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatNutrientesCollectionViaDetAlimentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatNutrientesCollectionViaDetAlimentos]() As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Get
				Return GetMultiCatNutrientesCollectionViaDetAlimentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatNutrientesCollectionViaDetAlimentos. When set to true, CatNutrientesCollectionViaDetAlimentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatNutrientesCollectionViaDetAlimentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatNutrientesCollectionViaDetAlimentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatNutrientesCollectionViaDetAlimentos As Boolean
			Get
				Return _alwaysFetchCatNutrientesCollectionViaDetAlimentos
			End Get
			Set
				_alwaysFetchCatNutrientesCollectionViaDetAlimentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabAplForCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabAplForCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.CabAplForCollection
			Get
				Return GetMultiCabAplForCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabAplForCollectionViaDetAplFor. When set to true, CabAplForCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabAplForCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabAplForCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabAplForCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchCabAplForCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchCabAplForCollectionViaDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaDetAplFor. When set to true, McecatCorralesCabCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaDetAplFor. When set to true, McecatLotesCabCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabProMedCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabProMedCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.CabProMedCollection
			Get
				Return GetMultiCabProMedCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabProMedCollectionViaDetDproMed. When set to true, CabProMedCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabProMedCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabProMedCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabProMedCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchCabProMedCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchCabProMedCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetProMedCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetProMedCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.DetProMedCollection
			Get
				Return GetMultiDetProMedCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetProMedCollectionViaDetDproMed. When set to true, DetProMedCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetProMedCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetProMedCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetProMedCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchDetProMedCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchDetProMedCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaDetDproMed. When set to true, McecatLotesCabCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepFormCollectionViaDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepFormCollectionViaDetPrepForm]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepFormCollectionViaDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepFormCollectionViaDetPrepForm. When set to true, CabPrepFormCollectionViaDetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepFormCollectionViaDetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepFormCollectionViaDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepFormCollectionViaDetPrepForm As Boolean
			Get
				Return _alwaysFetchCabPrepFormCollectionViaDetPrepForm
			End Get
			Set
				_alwaysFetchCabPrepFormCollectionViaDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaDetPrepForm]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaDetPrepForm. When set to true, PlazaCollectionViaDetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaDetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaDetPrepForm As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaDetPrepForm
			End Get
			Set
				_alwaysFetchPlazaCollectionViaDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepFormCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepFormCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepFormCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepFormCollectionViaDetPrepFormLote. When set to true, CabPrepFormCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepFormCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepFormCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepFormCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepFormCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepFormCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Get
				Return GetMultiDetPrepFormCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepFormCollectionViaDetPrepFormLote. When set to true, DetPrepFormCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepFormCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepFormCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepFormCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaDetPrepFormLote. When set to true, PlazaCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchPlazaCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabProMedCollectionViaDetProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabProMedCollectionViaDetProMed]() As Integralab.ORM.CollectionClasses.CabProMedCollection
			Get
				Return GetMultiCabProMedCollectionViaDetProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabProMedCollectionViaDetProMed. When set to true, CabProMedCollectionViaDetProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabProMedCollectionViaDetProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabProMedCollectionViaDetProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabProMedCollectionViaDetProMed As Boolean
			Get
				Return _alwaysFetchCabProMedCollectionViaDetProMed
			End Get
			Set
				_alwaysFetchCabProMedCollectionViaDetProMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaInvHistorialPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaInvHistorialPv]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaInvHistorialPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaInvHistorialPv. When set to true, AlmacenCollectionViaInvHistorialPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaInvHistorialPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaInvHistorialPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaInvHistorialPv As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaInvHistorialPv
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaInvHistorialPv = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCostoProductoProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCostoProductoProveedor]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCostoProductoProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCostoProductoProveedor. When set to true, ProveedorCollectionViaCostoProductoProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCostoProductoProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCostoProductoProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCostoProductoProveedor As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCostoProductoProveedor
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCostoProductoProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CostoIndirectoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CostoIndirectoCollectionViaProductoCostoIndirecto]() As Integralab.ORM.CollectionClasses.CostoIndirectoCollection
			Get
				Return GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CostoIndirectoCollectionViaProductoCostoIndirecto. When set to true, CostoIndirectoCollectionViaProductoCostoIndirecto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CostoIndirectoCollectionViaProductoCostoIndirecto is accessed. You can always execute
		''' a forced fetch by calling GetMultiCostoIndirectoCollectionViaProductoCostoIndirecto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto As Boolean
			Get
				Return _alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto
			End Get
			Set
				_alwaysFetchCostoIndirectoCollectionViaProductoCostoIndirecto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecioCollectionViaListaPrecioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecioCollectionViaListaPrecioDetalle]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecioCollectionViaListaPrecioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioCollectionViaListaPrecioDetalle. When set to true, ListaPrecioCollectionViaListaPrecioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioCollectionViaListaPrecioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecioCollectionViaListaPrecioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioCollectionViaListaPrecioDetalle As Boolean
			Get
				Return _alwaysFetchListaPrecioCollectionViaListaPrecioDetalle
			End Get
			Set
				_alwaysFetchListaPrecioCollectionViaListaPrecioDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaMcecatLotesCabFor]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaMcecatLotesCabFor. When set to true, McecatLotesCabCollectionViaMcecatLotesCabFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaMcecatLotesCabFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaMcecatLotesCabFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesCabFor = value
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
	
		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomPresupuestoCollectionViaMcomPresupuestoDetalle]() As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Get
				Return GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomPresupuestoCollectionViaMcomPresupuestoDetalle. When set to true, McomPresupuestoCollectionViaMcomPresupuestoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomPresupuestoCollectionViaMcomPresupuestoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomPresupuestoCollectionViaMcomPresupuestoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle As Boolean
			Get
				Return _alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle
			End Get
			Set
				_alwaysFetchMcomPresupuestoCollectionViaMcomPresupuestoDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProductoCollectionViaSolicitudProductoDetalle]() As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Get
				Return GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoCollectionViaSolicitudProductoDetalle. When set to true, SolicitudProductoCollectionViaSolicitudProductoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoCollectionViaSolicitudProductoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProductoCollectionViaSolicitudProductoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoCollectionViaSolicitudProductoDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaInventarioAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaInventarioAlmacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaInventarioAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaInventarioAlmacen. When set to true, AlmacenCollectionViaInventarioAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaInventarioAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaInventarioAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaInventarioAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaInventarioAlmacen
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaInventarioAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViainventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViainventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViainventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViainventarioAlmacenLotes. When set to true, AlmacenCollectionViainventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViainventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViainventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViainventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioAlmacenCollectionViainventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
			Get
				Return GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioAlmacenCollectionViainventarioAlmacenLotes. When set to true, InventarioAlmacenCollectionViainventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioAlmacenCollectionViainventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioAlmacenCollectionViainventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaInventarioMovimientoAlmacenDetalles]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaInventarioMovimientoAlmacenDetalles. When set to true, AlmacenCollectionViaInventarioMovimientoAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaInventarioMovimientoAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles. When set to true, InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles
			End Get
			Set
				_alwaysFetchInventarioMovimientosAlmacenCollectionViainventarioMovimientosAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles. When set to true, AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Get
				Return GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles. When set to true, MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle. When set to true, MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntradaCollectionViaMinvTransferenciaAlmacenEntradaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle. When set to true, MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenSalidaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MventaNotasVentaCollectionViaMventaNotaVentaDetalle]() As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Get
				Return GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MventaNotasVentaCollectionViaMventaNotaVentaDetalle. When set to true, MventaNotasVentaCollectionViaMventaNotaVentaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MventaNotasVentaCollectionViaMventaNotaVentaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMventaNotasVentaCollectionViaMventaNotaVentaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle As Boolean
			Get
				Return _alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle
			End Get
			Set
				_alwaysFetchMventaNotasVentaCollectionViaMventaNotaVentaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaUsrAlmInvFisico()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaUsrAlmInvFisico]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaUsrAlmInvFisico(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaUsrAlmInvFisico. When set to true, AlmacenCollectionViaUsrAlmInvFisico is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaUsrAlmInvFisico is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaUsrAlmInvFisico(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaUsrAlmInvFisico As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaUsrAlmInvFisico
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaUsrAlmInvFisico = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle. When set to true, McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionGanadoCollectionViaUsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Get
				Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanadoCollectionViaUsrProdRecepcionDetalle. When set to true, RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'LineaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleLinea()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Linea]() As LineaEntity
			Get
				Return GetSingleLinea(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncLinea(value)
				Else
					If value Is Nothing Then
						If Not _linea Is Nothing Then
							_linea.UnsetRelatedEntity(Me, "Producto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Producto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Linea. When set to true, Linea is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Linea is accessed. You can always execute
		''' a forced fetch by calling GetSingleLinea(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchLinea As Boolean
			Get
				Return _alwaysFetchLinea
			End Get
			Set
				_alwaysFetchLinea = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Linea is not found
		''' in the database. When set to true, Linea will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property LineaReturnsNewIfNotFound As Boolean
			Get
				Return _lineaReturnsNewIfNotFound
			End Get
			Set
				_lineaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PresentacionEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePresentacion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Presentacion]() As PresentacionEntity
			Get
				Return GetSinglePresentacion(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPresentacion(value)
				Else
					If value Is Nothing Then
						If Not _presentacion Is Nothing Then
							_presentacion.UnsetRelatedEntity(Me, "Producto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Producto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Presentacion. When set to true, Presentacion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Presentacion is accessed. You can always execute
		''' a forced fetch by calling GetSinglePresentacion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPresentacion As Boolean
			Get
				Return _alwaysFetchPresentacion
			End Get
			Set
				_alwaysFetchPresentacion = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Presentacion is not found
		''' in the database. When set to true, Presentacion will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PresentacionReturnsNewIfNotFound As Boolean
			Get
				Return _presentacionReturnsNewIfNotFound
			End Get
			Set
				_presentacionReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'TipoProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoProducto]() As TipoProductoEntity
			Get
				Return GetSingleTipoProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoProducto(value)
				Else
					If value Is Nothing Then
						If Not _tipoProducto Is Nothing Then
							_tipoProducto.UnsetRelatedEntity(Me, "Producto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Producto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoProducto. When set to true, TipoProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoProducto is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoProducto As Boolean
			Get
				Return _alwaysFetchTipoProducto
			End Get
			Set
				_alwaysFetchTipoProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoProducto is not found
		''' in the database. When set to true, TipoProducto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoProductoReturnsNewIfNotFound As Boolean
			Get
				Return _tipoProductoReturnsNewIfNotFound
			End Get
			Set
				_tipoProductoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'UnidadMedidaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnidadMedida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [UnidadMedida]() As UnidadMedidaEntity
			Get
				Return GetSingleUnidadMedida(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncUnidadMedida(value)
				Else
					If value Is Nothing Then
						If Not _unidadMedida Is Nothing Then
							_unidadMedida.UnsetRelatedEntity(Me, "Producto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Producto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for UnidadMedida. When set to true, UnidadMedida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UnidadMedida is accessed. You can always execute
		''' a forced fetch by calling GetSingleUnidadMedida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUnidadMedida As Boolean
			Get
				Return _alwaysFetchUnidadMedida
			End Get
			Set
				_alwaysFetchUnidadMedida = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property UnidadMedida is not found
		''' in the database. When set to true, UnidadMedida will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property UnidadMedidaReturnsNewIfNotFound As Boolean
			Get
				Return _unidadMedidaReturnsNewIfNotFound
			End Get
			Set
				_unidadMedidaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MarcaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMarca()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Marca]() As MarcaEntity
			Get
				Return GetSingleMarca(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMarca(value)
				Else
					If value Is Nothing Then
						If Not _marca Is Nothing Then
							_marca.UnsetRelatedEntity(Me, "Producto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Producto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Marca. When set to true, Marca is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Marca is accessed. You can always execute
		''' a forced fetch by calling GetSingleMarca(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMarca As Boolean
			Get
				Return _alwaysFetchMarca
			End Get
			Set
				_alwaysFetchMarca = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Marca is not found
		''' in the database. When set to true, Marca will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MarcaReturnsNewIfNotFound As Boolean
			Get
				Return _marcaReturnsNewIfNotFound
			End Get
			Set
				_marcaReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'CabMediReimEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabMediReim()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabMediReim]() As CabMediReimEntity
			Get
				Return GetSingleCabMediReim(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabMediReim(value)
				Else
					If value Is Nothing Then
						DesetupSyncCabMediReim(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "Producto")
						SetupSyncCabMediReim(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMediReim. When set to true, CabMediReim is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMediReim is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabMediReim(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMediReim As Boolean
			Get
				Return _alwaysFetchCabMediReim
			End Get
			Set
				_alwaysFetchCabMediReim = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabMediReim is not found
		''' in the database. When set to true, CabMediReim will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabMediReimReturnsNewIfNotFound As Boolean
			Get
				Return _cabMediReimReturnsNewIfNotFound
			End Get
			Set
				_cabMediReimReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / Sets related entity of type 'CabMediTrabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabMediTrab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabMediTrab]() As CabMediTrabEntity
			Get
				Return GetSingleCabMediTrab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabMediTrab(value)
				Else
					If value Is Nothing Then
						DesetupSyncCabMediTrab(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "Producto")
						SetupSyncCabMediTrab(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMediTrab. When set to true, CabMediTrab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMediTrab is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabMediTrab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMediTrab As Boolean
			Get
				Return _alwaysFetchCabMediTrab
			End Get
			Set
				_alwaysFetchCabMediTrab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabMediTrab is not found
		''' in the database. When set to true, CabMediTrab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabMediTrabReturnsNewIfNotFound As Boolean
			Get
				Return _cabMediTrabReturnsNewIfNotFound
			End Get
			Set
				_cabMediTrabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / Sets related entity of type 'CostoProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCostoProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CostoProducto]() As CostoProductoEntity
			Get
				Return GetSingleCostoProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCostoProducto(value)
				Else
					If value Is Nothing Then
						DesetupSyncCostoProducto(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "Producto")
						SetupSyncCostoProducto(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CostoProducto. When set to true, CostoProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CostoProducto is accessed. You can always execute
		''' a forced fetch by calling GetSingleCostoProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCostoProducto As Boolean
			Get
				Return _alwaysFetchCostoProducto
			End Get
			Set
				_alwaysFetchCostoProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CostoProducto is not found
		''' in the database. When set to true, CostoProducto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CostoProductoReturnsNewIfNotFound As Boolean
			Get
				Return _costoProductoReturnsNewIfNotFound
			End Get
			Set
				_costoProductoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ProductoEntity)
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
