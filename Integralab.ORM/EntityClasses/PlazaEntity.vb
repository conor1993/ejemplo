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
	''' <summary>Entity class which represents the entity 'Plaza'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PlazaEntity 
#Else
	<Serializable()> _
	Public Class PlazaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm, _alreadyFetchedCabPrepForm As Boolean
		Private _detPrepForm As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepForm, _alreadyFetchedDetPrepForm As Boolean
		Private _detPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
		Private _alwaysFetchDetPrepFormLote, _alreadyFetchedDetPrepFormLote As Boolean
		Private _almacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen As Boolean
		Private _mcatCentroCostosAlmacen As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
		Private _alwaysFetchMcatCentroCostosAlmacen, _alreadyFetchedMcatCentroCostosAlmacen As Boolean
		Private _comicionista As Integralab.ORM.CollectionClasses.ComicionistaCollection
		Private _alwaysFetchComicionista, _alreadyFetchedComicionista As Boolean
		Private _sucursal As Integralab.ORM.CollectionClasses.SucursalCollection
		Private _alwaysFetchSucursal, _alreadyFetchedSucursal As Boolean
		Private _cliente As Integralab.ORM.CollectionClasses.ClienteCollection
		Private _alwaysFetchCliente, _alreadyFetchedCliente As Boolean
		Private _listaPrecio As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecio, _alreadyFetchedListaPrecio As Boolean
		Private _almacenCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm, _alreadyFetchedAlmacenCollectionViaCabPrepForm As Boolean
		Private _productoCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm, _alreadyFetchedProductoCollectionViaCabPrepForm As Boolean
		Private _productoCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm_, _alreadyFetchedProductoCollectionViaCabPrepForm_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm__ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm__, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabPrepForm___ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabPrepForm___, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ As Boolean
		Private _cabPrepFormCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepFormCollectionViaDetPrepForm, _alreadyFetchedCabPrepFormCollectionViaDetPrepForm As Boolean
		Private _productoCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetPrepForm, _alreadyFetchedProductoCollectionViaDetPrepForm As Boolean
		Private _cabPrepFormCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote, _alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote As Boolean
		Private _detPrepFormCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote, _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote As Boolean
		Private _productoCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetPrepFormLote, _alreadyFetchedProductoCollectionViaDetPrepFormLote As Boolean
		Private _almacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaAlmacen, _alreadyFetchedAlmacenCollectionViaAlmacen As Boolean
		Private _tipoAlmacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
		Private _alwaysFetchTipoAlmacenCollectionViaAlmacen, _alreadyFetchedTipoAlmacenCollectionViaAlmacen As Boolean
		Private _cuentaContableCollectionViaAlmacen As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaAlmacen, _alreadyFetchedCuentaContableCollectionViaAlmacen As Boolean
		Private _cuentaContableCollectionViaMcatCentroCostosAlmacen As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen, _alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen As Boolean
		Private _tipoComicionistaCollectionViaComicionista As Integralab.ORM.CollectionClasses.TipoComicionistaCollection
		Private _alwaysFetchTipoComicionistaCollectionViaComicionista, _alreadyFetchedTipoComicionistaCollectionViaComicionista As Boolean
		Private _cuentaContableCollectionViaComicionista As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaComicionista, _alreadyFetchedCuentaContableCollectionViaComicionista As Boolean
		Private _listaPrecioCollectionViaCliente As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecioCollectionViaCliente, _alreadyFetchedListaPrecioCollectionViaCliente As Boolean
		Private _tipoVentaCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.TipoVentaCollection
		Private _alwaysFetchTipoVentaCollectionViaListaPrecio, _alreadyFetchedTipoVentaCollectionViaListaPrecio As Boolean
		Private _listaPrecioCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecioCollectionViaListaPrecio, _alreadyFetchedListaPrecioCollectionViaListaPrecio As Boolean



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
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <param name="validator">The custom validator Object for this PlazaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabPrepForm = CType(info.GetValue("_cabPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm = info.GetBoolean("_alwaysFetchCabPrepForm")
			_alreadyFetchedCabPrepForm = info.GetBoolean("_alreadyFetchedCabPrepForm")
			_detPrepForm = CType(info.GetValue("_detPrepForm", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepForm = info.GetBoolean("_alwaysFetchDetPrepForm")
			_alreadyFetchedDetPrepForm = info.GetBoolean("_alreadyFetchedDetPrepForm")
			_detPrepFormLote = CType(info.GetValue("_detPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)), Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)
			_alwaysFetchDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormLote")
			_alreadyFetchedDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormLote")
			_almacen = CType(info.GetValue("_almacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_mcatCentroCostosAlmacen = CType(info.GetValue("_mcatCentroCostosAlmacen", GetType(Integralab.ORM.CollectionClasses.McatCentroCostosCollection)), Integralab.ORM.CollectionClasses.McatCentroCostosCollection)
			_alwaysFetchMcatCentroCostosAlmacen = info.GetBoolean("_alwaysFetchMcatCentroCostosAlmacen")
			_alreadyFetchedMcatCentroCostosAlmacen = info.GetBoolean("_alreadyFetchedMcatCentroCostosAlmacen")
			_comicionista = CType(info.GetValue("_comicionista", GetType(Integralab.ORM.CollectionClasses.ComicionistaCollection)), Integralab.ORM.CollectionClasses.ComicionistaCollection)
			_alwaysFetchComicionista = info.GetBoolean("_alwaysFetchComicionista")
			_alreadyFetchedComicionista = info.GetBoolean("_alreadyFetchedComicionista")
			_sucursal = CType(info.GetValue("_sucursal", GetType(Integralab.ORM.CollectionClasses.SucursalCollection)), Integralab.ORM.CollectionClasses.SucursalCollection)
			_alwaysFetchSucursal = info.GetBoolean("_alwaysFetchSucursal")
			_alreadyFetchedSucursal = info.GetBoolean("_alreadyFetchedSucursal")
			_cliente = CType(info.GetValue("_cliente", GetType(Integralab.ORM.CollectionClasses.ClienteCollection)), Integralab.ORM.CollectionClasses.ClienteCollection)
			_alwaysFetchCliente = info.GetBoolean("_alwaysFetchCliente")
			_alreadyFetchedCliente = info.GetBoolean("_alreadyFetchedCliente")
			_listaPrecio = CType(info.GetValue("_listaPrecio", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecio = info.GetBoolean("_alwaysFetchListaPrecio")
			_alreadyFetchedListaPrecio = info.GetBoolean("_alreadyFetchedListaPrecio")
			_almacenCollectionViaCabPrepForm = CType(info.GetValue("_almacenCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm")
			_productoCollectionViaCabPrepForm = CType(info.GetValue("_productoCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm")
			_alreadyFetchedProductoCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm")
			_productoCollectionViaCabPrepForm_ = CType(info.GetValue("_productoCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm_")
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm_")
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
			_cabPrepFormCollectionViaDetPrepForm = CType(info.GetValue("_cabPrepFormCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepFormCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchCabPrepFormCollectionViaDetPrepForm")
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedCabPrepFormCollectionViaDetPrepForm")
			_productoCollectionViaDetPrepForm = CType(info.GetValue("_productoCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchProductoCollectionViaDetPrepForm")
			_alreadyFetchedProductoCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetPrepForm")
			_cabPrepFormCollectionViaDetPrepFormLote = CType(info.GetValue("_cabPrepFormCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote")
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote")
			_detPrepFormCollectionViaDetPrepFormLote = CType(info.GetValue("_detPrepFormCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote")
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote")
			_productoCollectionViaDetPrepFormLote = CType(info.GetValue("_productoCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchProductoCollectionViaDetPrepFormLote")
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetPrepFormLote")
			_almacenCollectionViaAlmacen = CType(info.GetValue("_almacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchAlmacenCollectionViaAlmacen")
			_alreadyFetchedAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaAlmacen")
			_tipoAlmacenCollectionViaAlmacen = CType(info.GetValue("_tipoAlmacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.TipoAlmacenCollection)), Integralab.ORM.CollectionClasses.TipoAlmacenCollection)
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchTipoAlmacenCollectionViaAlmacen")
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedTipoAlmacenCollectionViaAlmacen")
			_cuentaContableCollectionViaAlmacen = CType(info.GetValue("_cuentaContableCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaAlmacen = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaAlmacen")
			_alreadyFetchedCuentaContableCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaAlmacen")
			_cuentaContableCollectionViaMcatCentroCostosAlmacen = CType(info.GetValue("_cuentaContableCollectionViaMcatCentroCostosAlmacen", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen")
			_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen")
			_tipoComicionistaCollectionViaComicionista = CType(info.GetValue("_tipoComicionistaCollectionViaComicionista", GetType(Integralab.ORM.CollectionClasses.TipoComicionistaCollection)), Integralab.ORM.CollectionClasses.TipoComicionistaCollection)
			_alwaysFetchTipoComicionistaCollectionViaComicionista = info.GetBoolean("_alwaysFetchTipoComicionistaCollectionViaComicionista")
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = info.GetBoolean("_alreadyFetchedTipoComicionistaCollectionViaComicionista")
			_cuentaContableCollectionViaComicionista = CType(info.GetValue("_cuentaContableCollectionViaComicionista", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaComicionista = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaComicionista")
			_alreadyFetchedCuentaContableCollectionViaComicionista = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaComicionista")
			_listaPrecioCollectionViaCliente = CType(info.GetValue("_listaPrecioCollectionViaCliente", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecioCollectionViaCliente = info.GetBoolean("_alwaysFetchListaPrecioCollectionViaCliente")
			_alreadyFetchedListaPrecioCollectionViaCliente = info.GetBoolean("_alreadyFetchedListaPrecioCollectionViaCliente")
			_tipoVentaCollectionViaListaPrecio = CType(info.GetValue("_tipoVentaCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.TipoVentaCollection)), Integralab.ORM.CollectionClasses.TipoVentaCollection)
			_alwaysFetchTipoVentaCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchTipoVentaCollectionViaListaPrecio")
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedTipoVentaCollectionViaListaPrecio")
			_listaPrecioCollectionViaListaPrecio = CType(info.GetValue("_listaPrecioCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecioCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchListaPrecioCollectionViaListaPrecio")
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedListaPrecioCollectionViaListaPrecio")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabPrepForm = (_cabPrepForm.Count > 0)
			_alreadyFetchedDetPrepForm = (_detPrepForm.Count > 0)
			_alreadyFetchedDetPrepFormLote = (_detPrepFormLote.Count > 0)
			_alreadyFetchedAlmacen = (_almacen.Count > 0)
			_alreadyFetchedMcatCentroCostosAlmacen = (_mcatCentroCostosAlmacen.Count > 0)
			_alreadyFetchedComicionista = (_comicionista.Count > 0)
			_alreadyFetchedSucursal = (_sucursal.Count > 0)
			_alreadyFetchedCliente = (_cliente.Count > 0)
			_alreadyFetchedListaPrecio = (_listaPrecio.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = (_almacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm = (_productoCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = (_productoCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = (_cabPrepFormCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedProductoCollectionViaDetPrepForm = (_productoCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = (_cabPrepFormCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = (_detPrepFormCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = (_productoCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedAlmacenCollectionViaAlmacen = (_almacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = (_tipoAlmacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaAlmacen = (_cuentaContableCollectionViaAlmacen.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen = (_cuentaContableCollectionViaMcatCentroCostosAlmacen.Count > 0)
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = (_tipoComicionistaCollectionViaComicionista.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaComicionista = (_cuentaContableCollectionViaComicionista.Count > 0)
			_alreadyFetchedListaPrecioCollectionViaCliente = (_listaPrecioCollectionViaCliente.Count > 0)
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = (_tipoVentaCollectionViaListaPrecio.Count > 0)
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = (_listaPrecioCollectionViaListaPrecio.Count > 0)


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
			info.AddValue("_cabPrepForm", _cabPrepForm)
			info.AddValue("_alwaysFetchCabPrepForm", _alwaysFetchCabPrepForm)
			info.AddValue("_alreadyFetchedCabPrepForm", _alreadyFetchedCabPrepForm)
			info.AddValue("_detPrepForm", _detPrepForm)
			info.AddValue("_alwaysFetchDetPrepForm", _alwaysFetchDetPrepForm)
			info.AddValue("_alreadyFetchedDetPrepForm", _alreadyFetchedDetPrepForm)
			info.AddValue("_detPrepFormLote", _detPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormLote", _alwaysFetchDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormLote", _alreadyFetchedDetPrepFormLote)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_mcatCentroCostosAlmacen", _mcatCentroCostosAlmacen)
			info.AddValue("_alwaysFetchMcatCentroCostosAlmacen", _alwaysFetchMcatCentroCostosAlmacen)
			info.AddValue("_alreadyFetchedMcatCentroCostosAlmacen", _alreadyFetchedMcatCentroCostosAlmacen)
			info.AddValue("_comicionista", _comicionista)
			info.AddValue("_alwaysFetchComicionista", _alwaysFetchComicionista)
			info.AddValue("_alreadyFetchedComicionista", _alreadyFetchedComicionista)
			info.AddValue("_sucursal", _sucursal)
			info.AddValue("_alwaysFetchSucursal", _alwaysFetchSucursal)
			info.AddValue("_alreadyFetchedSucursal", _alreadyFetchedSucursal)
			info.AddValue("_cliente", _cliente)
			info.AddValue("_alwaysFetchCliente", _alwaysFetchCliente)
			info.AddValue("_alreadyFetchedCliente", _alreadyFetchedCliente)
			info.AddValue("_listaPrecio", _listaPrecio)
			info.AddValue("_alwaysFetchListaPrecio", _alwaysFetchListaPrecio)
			info.AddValue("_alreadyFetchedListaPrecio", _alreadyFetchedListaPrecio)
			info.AddValue("_almacenCollectionViaCabPrepForm", _almacenCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm", _alwaysFetchAlmacenCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm", _alreadyFetchedAlmacenCollectionViaCabPrepForm)
			info.AddValue("_productoCollectionViaCabPrepForm", _productoCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm", _alwaysFetchProductoCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm", _alreadyFetchedProductoCollectionViaCabPrepForm)
			info.AddValue("_productoCollectionViaCabPrepForm_", _productoCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm_", _alwaysFetchProductoCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm_", _alreadyFetchedProductoCollectionViaCabPrepForm_)
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
			info.AddValue("_cabPrepFormCollectionViaDetPrepForm", _cabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchCabPrepFormCollectionViaDetPrepForm", _alwaysFetchCabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedCabPrepFormCollectionViaDetPrepForm", _alreadyFetchedCabPrepFormCollectionViaDetPrepForm)
			info.AddValue("_productoCollectionViaDetPrepForm", _productoCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchProductoCollectionViaDetPrepForm", _alwaysFetchProductoCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetPrepForm", _alreadyFetchedProductoCollectionViaDetPrepForm)
			info.AddValue("_cabPrepFormCollectionViaDetPrepFormLote", _cabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote", _alwaysFetchCabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote", _alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_detPrepFormCollectionViaDetPrepFormLote", _detPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote", _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote", _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_productoCollectionViaDetPrepFormLote", _productoCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchProductoCollectionViaDetPrepFormLote", _alwaysFetchProductoCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetPrepFormLote", _alreadyFetchedProductoCollectionViaDetPrepFormLote)
			info.AddValue("_almacenCollectionViaAlmacen", _almacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchAlmacenCollectionViaAlmacen", _alwaysFetchAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaAlmacen", _alreadyFetchedAlmacenCollectionViaAlmacen)
			info.AddValue("_tipoAlmacenCollectionViaAlmacen", _tipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchTipoAlmacenCollectionViaAlmacen", _alwaysFetchTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedTipoAlmacenCollectionViaAlmacen", _alreadyFetchedTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_cuentaContableCollectionViaAlmacen", _cuentaContableCollectionViaAlmacen)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaAlmacen", _alwaysFetchCuentaContableCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaAlmacen", _alreadyFetchedCuentaContableCollectionViaAlmacen)
			info.AddValue("_cuentaContableCollectionViaMcatCentroCostosAlmacen", _cuentaContableCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen", _alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen", _alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_tipoComicionistaCollectionViaComicionista", _tipoComicionistaCollectionViaComicionista)
			info.AddValue("_alwaysFetchTipoComicionistaCollectionViaComicionista", _alwaysFetchTipoComicionistaCollectionViaComicionista)
			info.AddValue("_alreadyFetchedTipoComicionistaCollectionViaComicionista", _alreadyFetchedTipoComicionistaCollectionViaComicionista)
			info.AddValue("_cuentaContableCollectionViaComicionista", _cuentaContableCollectionViaComicionista)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaComicionista", _alwaysFetchCuentaContableCollectionViaComicionista)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaComicionista", _alreadyFetchedCuentaContableCollectionViaComicionista)
			info.AddValue("_listaPrecioCollectionViaCliente", _listaPrecioCollectionViaCliente)
			info.AddValue("_alwaysFetchListaPrecioCollectionViaCliente", _alwaysFetchListaPrecioCollectionViaCliente)
			info.AddValue("_alreadyFetchedListaPrecioCollectionViaCliente", _alreadyFetchedListaPrecioCollectionViaCliente)
			info.AddValue("_tipoVentaCollectionViaListaPrecio", _tipoVentaCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchTipoVentaCollectionViaListaPrecio", _alwaysFetchTipoVentaCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedTipoVentaCollectionViaListaPrecio", _alreadyFetchedTipoVentaCollectionViaListaPrecio)
			info.AddValue("_listaPrecioCollectionViaListaPrecio", _listaPrecioCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchListaPrecioCollectionViaListaPrecio", _alwaysFetchListaPrecioCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedListaPrecioCollectionViaListaPrecio", _alreadyFetchedListaPrecioCollectionViaListaPrecio)


			
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

				Case "CabPrepForm"
					_alreadyFetchedCabPrepForm = True
					If Not entity Is Nothing Then
						Me.CabPrepForm.Add(CType(entity, CabPrepFormEntity))
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
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					If Not entity Is Nothing Then
						Me.Almacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "McatCentroCostosAlmacen"
					_alreadyFetchedMcatCentroCostosAlmacen = True
					If Not entity Is Nothing Then
						Me.McatCentroCostosAlmacen.Add(CType(entity, McatCentroCostosEntity))
					End If
				Case "Comicionista"
					_alreadyFetchedComicionista = True
					If Not entity Is Nothing Then
						Me.Comicionista.Add(CType(entity, ComicionistaEntity))
					End If
				Case "Sucursal"
					_alreadyFetchedSucursal = True
					If Not entity Is Nothing Then
						Me.Sucursal.Add(CType(entity, SucursalEntity))
					End If
				Case "Cliente"
					_alreadyFetchedCliente = True
					If Not entity Is Nothing Then
						Me.Cliente.Add(CType(entity, ClienteEntity))
					End If
				Case "ListaPrecio"
					_alreadyFetchedListaPrecio = True
					If Not entity Is Nothing Then
						Me.ListaPrecio.Add(CType(entity, ListaPrecioEntity))
					End If
				Case "AlmacenCollectionViaCabPrepForm"
					_alreadyFetchedAlmacenCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabPrepForm.Add(CType(entity, AlmacenEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm"
					_alreadyFetchedProductoCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm_"
					_alreadyFetchedProductoCollectionViaCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm_.Add(CType(entity, ProductoEntity))
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
				Case "CabPrepFormCollectionViaDetPrepForm"
					_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.CabPrepFormCollectionViaDetPrepForm.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "ProductoCollectionViaDetPrepForm"
					_alreadyFetchedProductoCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetPrepForm.Add(CType(entity, ProductoEntity))
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
				Case "ProductoCollectionViaDetPrepFormLote"
					_alreadyFetchedProductoCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetPrepFormLote.Add(CType(entity, ProductoEntity))
					End If
				Case "AlmacenCollectionViaAlmacen"
					_alreadyFetchedAlmacenCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaAlmacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "TipoAlmacenCollectionViaAlmacen"
					_alreadyFetchedTipoAlmacenCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.TipoAlmacenCollectionViaAlmacen.Add(CType(entity, TipoAlmacenEntity))
					End If
				Case "CuentaContableCollectionViaAlmacen"
					_alreadyFetchedCuentaContableCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaAlmacen.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaContableCollectionViaMcatCentroCostosAlmacen"
					_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaMcatCentroCostosAlmacen.Add(CType(entity, CuentaContableEntity))
					End If
				Case "TipoComicionistaCollectionViaComicionista"
					_alreadyFetchedTipoComicionistaCollectionViaComicionista = True
					If Not entity Is Nothing Then
						Me.TipoComicionistaCollectionViaComicionista.Add(CType(entity, TipoComicionistaEntity))
					End If
				Case "CuentaContableCollectionViaComicionista"
					_alreadyFetchedCuentaContableCollectionViaComicionista = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaComicionista.Add(CType(entity, CuentaContableEntity))
					End If
				Case "ListaPrecioCollectionViaCliente"
					_alreadyFetchedListaPrecioCollectionViaCliente = True
					If Not entity Is Nothing Then
						Me.ListaPrecioCollectionViaCliente.Add(CType(entity, ListaPrecioEntity))
					End If
				Case "TipoVentaCollectionViaListaPrecio"
					_alreadyFetchedTipoVentaCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.TipoVentaCollectionViaListaPrecio.Add(CType(entity, TipoVentaEntity))
					End If
				Case "ListaPrecioCollectionViaListaPrecio"
					_alreadyFetchedListaPrecioCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.ListaPrecioCollectionViaListaPrecio.Add(CType(entity, ListaPrecioEntity))
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

				Case "CabPrepForm"
					_cabPrepForm.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepForm"
					_detPrepForm.Add(CType(relatedEntity, DetPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					_detPrepFormLote.Add(CType(relatedEntity, DetPrepFormLoteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen"
					_almacen.Add(CType(relatedEntity, AlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McatCentroCostosAlmacen"
					_mcatCentroCostosAlmacen.Add(CType(relatedEntity, McatCentroCostosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Comicionista"
					_comicionista.Add(CType(relatedEntity, ComicionistaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Sucursal"
					_sucursal.Add(CType(relatedEntity, SucursalEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cliente"
					_cliente.Add(CType(relatedEntity, ClienteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPrecio"
					_listaPrecio.Add(CType(relatedEntity, ListaPrecioEntity))
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

				Case "CabPrepForm"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepForm"
					MyBase.PerformRelatedEntityRemoval(_detPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					MyBase.PerformRelatedEntityRemoval(_detPrepFormLote, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen"
					MyBase.PerformRelatedEntityRemoval(_almacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McatCentroCostosAlmacen"
					MyBase.PerformRelatedEntityRemoval(_mcatCentroCostosAlmacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Comicionista"
					MyBase.PerformRelatedEntityRemoval(_comicionista, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Sucursal"
					MyBase.PerformRelatedEntityRemoval(_sucursal, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cliente"
					MyBase.PerformRelatedEntityRemoval(_cliente, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPrecio"
					MyBase.PerformRelatedEntityRemoval(_listaPrecio, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_cabPrepForm)
			toReturn.Add(_detPrepForm)
			toReturn.Add(_detPrepFormLote)
			toReturn.Add(_almacen)
			toReturn.Add(_mcatCentroCostosAlmacen)
			toReturn.Add(_comicionista)
			toReturn.Add(_sucursal)
			toReturn.Add(_cliente)
			toReturn.Add(_listaPrecio)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PlazaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PlazaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_cabPrepForm.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Nothing, Nothing, Nothing, Filter)
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
				_detPrepForm.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
				_detPrepFormLote.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, _almacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, _almacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacen)
					End If
				End If
				_almacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacen.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_almacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacen = True
			End If
			Return _almacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Almacen'. These settings will be taken into account
		''' when the property Almacen is requested or GetMultiAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacen.SortClauses=sortClauses
			_almacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McatCentroCostosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McatCentroCostosEntity'</returns>
		Public Function GetMultiMcatCentroCostosAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
			Return GetMultiMcatCentroCostosAlmacen(forceFetch, _mcatCentroCostosAlmacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McatCentroCostosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcatCentroCostosAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
			Return GetMultiMcatCentroCostosAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McatCentroCostosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McatCentroCostosEntity'</returns>
		Public Function GetMultiMcatCentroCostosAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
			Return GetMultiMcatCentroCostosAlmacen(forceFetch, _mcatCentroCostosAlmacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McatCentroCostosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcatCentroCostosAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
			If ( Not _alreadyFetchedMcatCentroCostosAlmacen Or forceFetch Or _alwaysFetchMcatCentroCostosAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcatCentroCostosAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcatCentroCostosAlmacen)
					End If
				End If
				_mcatCentroCostosAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcatCentroCostosAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcatCentroCostosAlmacen.GetMultiManyToOne(Me, Nothing, Filter)
				_mcatCentroCostosAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedMcatCentroCostosAlmacen = True
			End If
			Return _mcatCentroCostosAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McatCentroCostosAlmacen'. These settings will be taken into account
		''' when the property McatCentroCostosAlmacen is requested or GetMultiMcatCentroCostosAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcatCentroCostosAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcatCentroCostosAlmacen.SortClauses=sortClauses
			_mcatCentroCostosAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ComicionistaEntity'</returns>
		Public Function GetMultiComicionista(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Return GetMultiComicionista(forceFetch, _comicionista.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiComicionista(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Return GetMultiComicionista(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ComicionistaEntity'</returns>
		Public Function GetMultiComicionista(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Return GetMultiComicionista(forceFetch, _comicionista.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiComicionista(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			If ( Not _alreadyFetchedComicionista Or forceFetch Or _alwaysFetchComicionista) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _comicionista.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_comicionista)
					End If
				End If
				_comicionista.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_comicionista.EntityFactoryToUse = entityFactoryToUse
				End If
				_comicionista.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_comicionista.SuppressClearInGetMulti = False
				_alreadyFetchedComicionista = True
			End If
			Return _comicionista
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Comicionista'. These settings will be taken into account
		''' when the property Comicionista is requested or GetMultiComicionista is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersComicionista(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_comicionista.SortClauses=sortClauses
			_comicionista.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SucursalEntity'</returns>
		Public Function GetMultiSucursal(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SucursalCollection
			Return GetMultiSucursal(forceFetch, _sucursal.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSucursal(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SucursalCollection
			Return GetMultiSucursal(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SucursalEntity'</returns>
		Public Function GetMultiSucursal(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SucursalCollection
			Return GetMultiSucursal(forceFetch, _sucursal.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSucursal(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SucursalCollection
			If ( Not _alreadyFetchedSucursal Or forceFetch Or _alwaysFetchSucursal) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _sucursal.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_sucursal)
					End If
				End If
				_sucursal.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_sucursal.EntityFactoryToUse = entityFactoryToUse
				End If
				_sucursal.GetMultiManyToOne(Nothing, Me, Filter)
				_sucursal.SuppressClearInGetMulti = False
				_alreadyFetchedSucursal = True
			End If
			Return _sucursal
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Sucursal'. These settings will be taken into account
		''' when the property Sucursal is requested or GetMultiSucursal is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSucursal(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_sucursal.SortClauses=sortClauses
			_sucursal.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ClienteEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ClienteEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ClienteCollection
			If ( Not _alreadyFetchedCliente Or forceFetch Or _alwaysFetchCliente) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cliente.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cliente)
					End If
				End If
				_cliente.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cliente.EntityFactoryToUse = entityFactoryToUse
				End If
				_cliente.GetMultiManyToOne(Me, Nothing, Filter)
				_cliente.SuppressClearInGetMulti = False
				_alreadyFetchedCliente = True
			End If
			Return _cliente
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cliente'. These settings will be taken into account
		''' when the property Cliente is requested or GetMultiCliente is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCliente(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cliente.SortClauses=sortClauses
			_cliente.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, _listaPrecio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, _listaPrecio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecio Or forceFetch Or _alwaysFetchListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecio)
					End If
				End If
				_listaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecio.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_listaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecio = True
			End If
			Return _listaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecio'. These settings will be taken into account
		''' when the property ListaPrecio is requested or GetMultiListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecio.SortClauses=sortClauses
			_listaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm(forceFetch, _productoCollectionViaCabPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaCabPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm = True
			End If
			Return _productoCollectionViaCabPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm is requested or GetMultiProductoCollectionViaCabPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm_(forceFetch, _productoCollectionViaCabPrepForm_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm_ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaCabPrepForm_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm_.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm_.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm_.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm_ = True
			End If
			Return _productoCollectionViaCabPrepForm_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm_'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm_ is requested or GetMultiProductoCollectionViaCabPrepForm_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm_.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetPrepForm(forceFetch, _productoCollectionViaDetPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetPrepForm Or forceFetch Or _alwaysFetchProductoCollectionViaDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, "__PlazaEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.ProductoEntityUsingCveProducto, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaDetPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetPrepForm.GetMulti(Filter, relations)
				_productoCollectionViaDetPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetPrepForm = True
			End If
			Return _productoCollectionViaDetPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetPrepForm'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetPrepForm is requested or GetMultiProductoCollectionViaDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetPrepForm.SortClauses=sortClauses
			_productoCollectionViaDetPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetPrepFormLote(forceFetch, _productoCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchProductoCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.ProductoEntityUsingCveProducto, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_productoCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetPrepFormLote = True
			End If
			Return _productoCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetPrepFormLote is requested or GetMultiProductoCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_productoCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaAlmacen(forceFetch, _almacenCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaAlmacen Or forceFetch Or _alwaysFetchAlmacenCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaAlmacen.GetMulti(Filter, relations)
				_almacenCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaAlmacen = True
			End If
			Return _almacenCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaAlmacen'. These settings will be taken into account
		''' when the property AlmacenCollectionViaAlmacen is requested or GetMultiAlmacenCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaAlmacen.SortClauses=sortClauses
			_almacenCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoAlmacenEntity'</returns>
		Public Function GetMultiTipoAlmacenCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
			Return GetMultiTipoAlmacenCollectionViaAlmacen(forceFetch, _tipoAlmacenCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoAlmacenCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
			If ( Not _alreadyFetchedTipoAlmacenCollectionViaAlmacen Or forceFetch Or _alwaysFetchTipoAlmacenCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoAlmacenCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoAlmacenCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoAlmacenCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoAlmacenCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoAlmacenCollectionViaAlmacen.GetMulti(Filter, relations)
				_tipoAlmacenCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedTipoAlmacenCollectionViaAlmacen = True
			End If
			Return _tipoAlmacenCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoAlmacenCollectionViaAlmacen'. These settings will be taken into account
		''' when the property TipoAlmacenCollectionViaAlmacen is requested or GetMultiTipoAlmacenCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoAlmacenCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoAlmacenCollectionViaAlmacen.SortClauses=sortClauses
			_tipoAlmacenCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaAlmacen(forceFetch, _cuentaContableCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaAlmacen Or forceFetch Or _alwaysFetchCuentaContableCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaAlmacen.GetMulti(Filter, relations)
				_cuentaContableCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaAlmacen = True
			End If
			Return _cuentaContableCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaAlmacen'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaAlmacen is requested or GetMultiCuentaContableCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaAlmacen.SortClauses=sortClauses
			_cuentaContableCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen(forceFetch, _cuentaContableCollectionViaMcatCentroCostosAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen Or forceFetch Or _alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaMcatCentroCostosAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaMcatCentroCostosAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.McatCentroCostosEntityUsingIdPlaza, "__PlazaEntity__", "McatCentroCostos_", JoinHint.None)
				relations.Add(McatCentroCostosEntity.Relations.CuentaContableEntityUsingIdCuentaCont, "McatCentroCostos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaMcatCentroCostosAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaMcatCentroCostosAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaMcatCentroCostosAlmacen.GetMulti(Filter, relations)
				_cuentaContableCollectionViaMcatCentroCostosAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen = True
			End If
			Return _cuentaContableCollectionViaMcatCentroCostosAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaMcatCentroCostosAlmacen'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaMcatCentroCostosAlmacen is requested or GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaMcatCentroCostosAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaMcatCentroCostosAlmacen.SortClauses=sortClauses
			_cuentaContableCollectionViaMcatCentroCostosAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoComicionistaEntity'</returns>
		Public Function GetMultiTipoComicionistaCollectionViaComicionista(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoComicionistaCollection
			Return GetMultiTipoComicionistaCollectionViaComicionista(forceFetch, _tipoComicionistaCollectionViaComicionista.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoComicionistaCollectionViaComicionista(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoComicionistaCollection
			If ( Not _alreadyFetchedTipoComicionistaCollectionViaComicionista Or forceFetch Or _alwaysFetchTipoComicionistaCollectionViaComicionista) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoComicionistaCollectionViaComicionista.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoComicionistaCollectionViaComicionista)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.ComicionistaEntityUsingPlaza, "__PlazaEntity__", "Comicionista_", JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, "Comicionista_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoComicionistaCollectionViaComicionista.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoComicionistaCollectionViaComicionista.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoComicionistaCollectionViaComicionista.GetMulti(Filter, relations)
				_tipoComicionistaCollectionViaComicionista.SuppressClearInGetMulti = False
				_alreadyFetchedTipoComicionistaCollectionViaComicionista = True
			End If
			Return _tipoComicionistaCollectionViaComicionista
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoComicionistaCollectionViaComicionista'. These settings will be taken into account
		''' when the property TipoComicionistaCollectionViaComicionista is requested or GetMultiTipoComicionistaCollectionViaComicionista is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoComicionistaCollectionViaComicionista(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoComicionistaCollectionViaComicionista.SortClauses=sortClauses
			_tipoComicionistaCollectionViaComicionista.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaComicionista(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaComicionista(forceFetch, _cuentaContableCollectionViaComicionista.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaComicionista(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaComicionista Or forceFetch Or _alwaysFetchCuentaContableCollectionViaComicionista) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaComicionista.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaComicionista)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.ComicionistaEntityUsingPlaza, "__PlazaEntity__", "Comicionista_", JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Comicionista_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaComicionista.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaComicionista.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaComicionista.GetMulti(Filter, relations)
				_cuentaContableCollectionViaComicionista.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaComicionista = True
			End If
			Return _cuentaContableCollectionViaComicionista
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaComicionista'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaComicionista is requested or GetMultiCuentaContableCollectionViaComicionista is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaComicionista(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaComicionista.SortClauses=sortClauses
			_cuentaContableCollectionViaComicionista.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecioCollectionViaCliente(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecioCollectionViaCliente(forceFetch, _listaPrecioCollectionViaCliente.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecioCollectionViaCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecioCollectionViaCliente Or forceFetch Or _alwaysFetchListaPrecioCollectionViaCliente) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecioCollectionViaCliente.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecioCollectionViaCliente)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.ClienteEntityUsingCodigoPlaza, "__PlazaEntity__", "Cliente_", JoinHint.None)
				relations.Add(ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios, "Cliente_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_listaPrecioCollectionViaCliente.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecioCollectionViaCliente.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecioCollectionViaCliente.GetMulti(Filter, relations)
				_listaPrecioCollectionViaCliente.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecioCollectionViaCliente = True
			End If
			Return _listaPrecioCollectionViaCliente
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecioCollectionViaCliente'. These settings will be taken into account
		''' when the property ListaPrecioCollectionViaCliente is requested or GetMultiListaPrecioCollectionViaCliente is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecioCollectionViaCliente(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecioCollectionViaCliente.SortClauses=sortClauses
			_listaPrecioCollectionViaCliente.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoVentaEntity'</returns>
		Public Function GetMultiTipoVentaCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoVentaCollection
			Return GetMultiTipoVentaCollectionViaListaPrecio(forceFetch, _tipoVentaCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoVentaCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoVentaCollection
			If ( Not _alreadyFetchedTipoVentaCollectionViaListaPrecio Or forceFetch Or _alwaysFetchTipoVentaCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoVentaCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoVentaCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, "__PlazaEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoVentaCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoVentaCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoVentaCollectionViaListaPrecio.GetMulti(Filter, relations)
				_tipoVentaCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedTipoVentaCollectionViaListaPrecio = True
			End If
			Return _tipoVentaCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoVentaCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property TipoVentaCollectionViaListaPrecio is requested or GetMultiTipoVentaCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoVentaCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoVentaCollectionViaListaPrecio.SortClauses=sortClauses
			_tipoVentaCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecioCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecioCollectionViaListaPrecio(forceFetch, _listaPrecioCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecioCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecioCollectionViaListaPrecio Or forceFetch Or _alwaysFetchListaPrecioCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecioCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecioCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, "__PlazaEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PlazaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_listaPrecioCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecioCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecioCollectionViaListaPrecio.GetMulti(Filter, relations)
				_listaPrecioCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecioCollectionViaListaPrecio = True
			End If
			Return _listaPrecioCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecioCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property ListaPrecioCollectionViaListaPrecio is requested or GetMultiListaPrecioCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecioCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecioCollectionViaListaPrecio.SortClauses=sortClauses
			_listaPrecioCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PlazaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PlazaFieldIndex)











					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabPrepForm.ActiveContext = MyBase.ActiveContext
			_detPrepForm.ActiveContext = MyBase.ActiveContext
			_detPrepFormLote.ActiveContext = MyBase.ActiveContext
			_almacen.ActiveContext = MyBase.ActiveContext
			_mcatCentroCostosAlmacen.ActiveContext = MyBase.ActiveContext
			_comicionista.ActiveContext = MyBase.ActiveContext
			_sucursal.ActiveContext = MyBase.ActiveContext
			_cliente.ActiveContext = MyBase.ActiveContext
			_listaPrecio.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_cabPrepFormCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_cabPrepFormCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_detPrepFormCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_tipoAlmacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaMcatCentroCostosAlmacen.ActiveContext = MyBase.ActiveContext
			_tipoComicionistaCollectionViaComicionista.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaComicionista.ActiveContext = MyBase.ActiveContext
			_listaPrecioCollectionViaCliente.ActiveContext = MyBase.ActiveContext
			_tipoVentaCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext
			_listaPrecioCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PlazaDAO = CType(CreateDAOInstance(), PlazaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PlazaDAO = CType(CreateDAOInstance(), PlazaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PlazaDAO = CType(CreateDAOInstance(), PlazaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PlazaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PlazaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <param name="validator">The validator Object for this PlazaEntity</param>
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
			_cabPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchCabPrepForm = False
			_alreadyFetchedCabPrepForm = False
			_detPrepForm = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_detPrepForm.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchDetPrepForm = False
			_alreadyFetchedDetPrepForm = False
			_detPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(New DetPrepFormLoteEntityFactory())
			_detPrepFormLote.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchDetPrepFormLote = False
			_alreadyFetchedDetPrepFormLote = False
			_almacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_almacen.SetContainingEntityInfo(Me, "Plaza_")
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_mcatCentroCostosAlmacen = New Integralab.ORM.CollectionClasses.McatCentroCostosCollection(New McatCentroCostosEntityFactory())
			_mcatCentroCostosAlmacen.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchMcatCentroCostosAlmacen = False
			_alreadyFetchedMcatCentroCostosAlmacen = False
			_comicionista = New Integralab.ORM.CollectionClasses.ComicionistaCollection(New ComicionistaEntityFactory())
			_comicionista.SetContainingEntityInfo(Me, "Plaza_")
			_alwaysFetchComicionista = False
			_alreadyFetchedComicionista = False
			_sucursal = New Integralab.ORM.CollectionClasses.SucursalCollection(New SucursalEntityFactory())
			_sucursal.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchSucursal = False
			_alreadyFetchedSucursal = False
			_cliente = New Integralab.ORM.CollectionClasses.ClienteCollection(New ClienteEntityFactory())
			_cliente.SetContainingEntityInfo(Me, "Plaza")
			_alwaysFetchCliente = False
			_alreadyFetchedCliente = False
			_listaPrecio = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_listaPrecio.SetContainingEntityInfo(Me, "Plaza_")
			_alwaysFetchListaPrecio = False
			_alreadyFetchedListaPrecio = False
			_almacenCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = False
			_productoCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm = False
			_alreadyFetchedProductoCollectionViaCabPrepForm = False
			_productoCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm_ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = False
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
			_cabPrepFormCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_alwaysFetchCabPrepFormCollectionViaDetPrepForm = False
			_alreadyFetchedCabPrepFormCollectionViaDetPrepForm = False
			_productoCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetPrepForm = False
			_alreadyFetchedProductoCollectionViaDetPrepForm = False
			_cabPrepFormCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_alwaysFetchCabPrepFormCollectionViaDetPrepFormLote = False
			_alreadyFetchedCabPrepFormCollectionViaDetPrepFormLote = False
			_detPrepFormCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = False
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = False
			_productoCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetPrepFormLote = False
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = False
			_almacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaAlmacen = False
			_alreadyFetchedAlmacenCollectionViaAlmacen = False
			_tipoAlmacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(New TipoAlmacenEntityFactory())
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = False
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = False
			_cuentaContableCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaAlmacen = False
			_alreadyFetchedCuentaContableCollectionViaAlmacen = False
			_cuentaContableCollectionViaMcatCentroCostosAlmacen = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen = False
			_alreadyFetchedCuentaContableCollectionViaMcatCentroCostosAlmacen = False
			_tipoComicionistaCollectionViaComicionista = New Integralab.ORM.CollectionClasses.TipoComicionistaCollection(New TipoComicionistaEntityFactory())
			_alwaysFetchTipoComicionistaCollectionViaComicionista = False
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = False
			_cuentaContableCollectionViaComicionista = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaComicionista = False
			_alreadyFetchedCuentaContableCollectionViaComicionista = False
			_listaPrecioCollectionViaCliente = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_alwaysFetchListaPrecioCollectionViaCliente = False
			_alreadyFetchedListaPrecioCollectionViaCliente = False
			_tipoVentaCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.TipoVentaCollection(New TipoVentaEntityFactory())
			_alwaysFetchTipoVentaCollectionViaListaPrecio = False
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = False
			_listaPrecioCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_alwaysFetchListaPrecioCollectionViaListaPrecio = False
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = False


			
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
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Plaza which data should be fetched into this Plaza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PlazaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePlazaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PlazaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PlazaRelations
			Get	
				Return New PlazaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepFormLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormLote() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(), _
					PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormLoteEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					PlazaEntity.Relations.AlmacenEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McatCentroCostos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcatCentroCostosAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McatCentroCostosCollection(), _
					PlazaEntity.Relations.McatCentroCostosEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.McatCentroCostosEntity, Integer), 0, Nothing, Nothing, Nothing, "McatCentroCostosAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathComicionista() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ComicionistaCollection(), _
					PlazaEntity.Relations.ComicionistaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), 0, Nothing, Nothing, Nothing, "Comicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					PlazaEntity.Relations.SucursalEntityUsingCodigoPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cliente' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCliente() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ClienteCollection(), _
					PlazaEntity.Relations.ClienteEntityUsingCodigoPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ClienteEntity, Integer), 0, Nothing, Nothing, Nothing, "Cliente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					PlazaEntity.Relations.CabPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepFormCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "CabPrepFormCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.ProductoEntityUsingCveProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PlazaEntity.Relations.DetPrepFormEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepFormCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.CabPrepFormEntityUsingFolPrepFormIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "CabPrepFormCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "DetPrepFormCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.ProductoEntityUsingCveProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PlazaEntity.Relations.DetPrepFormLoteEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					PlazaEntity.Relations.AlmacenEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(), _
					PlazaEntity.Relations.AlmacenEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "TipoAlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.AlmacenEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					PlazaEntity.Relations.AlmacenEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaMcatCentroCostosAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.McatCentroCostosEntityUsingIdPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(McatCentroCostosEntity.Relations.CuentaContableEntityUsingIdCuentaCont)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					PlazaEntity.Relations.McatCentroCostosEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaMcatCentroCostosAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoComicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoComicionistaCollectionViaComicionista() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.ComicionistaEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoComicionistaCollection(), _
					PlazaEntity.Relations.ComicionistaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.TipoComicionistaEntity, Integer), 0, Nothing, Nothing, relations, "TipoComicionistaCollectionViaComicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaComicionista() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.ComicionistaEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					PlazaEntity.Relations.ComicionistaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaComicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioCollectionViaCliente() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.ClienteEntityUsingCodigoPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					PlazaEntity.Relations.ClienteEntityUsingCodigoPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, relations, "ListaPrecioCollectionViaCliente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoVentaCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoVentaCollection(), _
					PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), 0, Nothing, Nothing, relations, "TipoVentaCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, "__PlazaEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					PlazaEntity.Relations.ListaPrecioEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.PlazaEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, relations, "ListaPrecioCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PlazaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PlazaEntity.CustomProperties
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
				Return PlazaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLIdPlaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLDescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.FechaBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.UsuarioBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.MotivoBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity Plaza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenPlazas"."PLObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PlazaFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PlazaFieldIndex.ObservacionesBaja, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Almacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen. When set to true, Almacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacen
			End Get
			Set
				_alwaysFetchAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McatCentroCostosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcatCentroCostosAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McatCentroCostosAlmacen]() As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
			Get
				Return GetMultiMcatCentroCostosAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McatCentroCostosAlmacen. When set to true, McatCentroCostosAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McatCentroCostosAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcatCentroCostosAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcatCentroCostosAlmacen As Boolean
			Get
				Return _alwaysFetchMcatCentroCostosAlmacen
			End Get
			Set
				_alwaysFetchMcatCentroCostosAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiComicionista()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Comicionista]() As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Get
				Return GetMultiComicionista(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Comicionista. When set to true, Comicionista is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Comicionista is accessed. You can always execute
		''' a forced fetch by calling GetMultiComicionista(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchComicionista As Boolean
			Get
				Return _alwaysFetchComicionista
			End Get
			Set
				_alwaysFetchComicionista = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSucursal()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Sucursal]() As Integralab.ORM.CollectionClasses.SucursalCollection
			Get
				Return GetMultiSucursal(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Sucursal. When set to true, Sucursal is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Sucursal is accessed. You can always execute
		''' a forced fetch by calling GetMultiSucursal(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSucursal As Boolean
			Get
				Return _alwaysFetchSucursal
			End Get
			Set
				_alwaysFetchSucursal = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCliente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cliente]() As Integralab.ORM.CollectionClasses.ClienteCollection
			Get
				Return GetMultiCliente(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cliente. When set to true, Cliente is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cliente is accessed. You can always execute
		''' a forced fetch by calling GetMultiCliente(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCliente As Boolean
			Get
				Return _alwaysFetchCliente
			End Get
			Set
				_alwaysFetchCliente = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecio]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecio. When set to true, ListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecio As Boolean
			Get
				Return _alwaysFetchListaPrecio
			End Get
			Set
				_alwaysFetchListaPrecio = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm. When set to true, ProductoCollectionViaCabPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm_]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm_. When set to true, ProductoCollectionViaCabPrepForm_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm_ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm_
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm_ = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetPrepForm]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetPrepForm. When set to true, ProductoCollectionViaDetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetPrepForm As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetPrepForm
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetPrepForm = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetPrepFormLote. When set to true, ProductoCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaAlmacen. When set to true, AlmacenCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoAlmacenCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoAlmacenCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
			Get
				Return GetMultiTipoAlmacenCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoAlmacenCollectionViaAlmacen. When set to true, TipoAlmacenCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoAlmacenCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoAlmacenCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoAlmacenCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchTipoAlmacenCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchTipoAlmacenCollectionViaAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaAlmacen. When set to true, CuentaContableCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaMcatCentroCostosAlmacen]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaMcatCentroCostosAlmacen. When set to true, CuentaContableCollectionViaMcatCentroCostosAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaMcatCentroCostosAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaMcatCentroCostosAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaMcatCentroCostosAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoComicionistaCollectionViaComicionista()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoComicionistaCollectionViaComicionista]() As Integralab.ORM.CollectionClasses.TipoComicionistaCollection
			Get
				Return GetMultiTipoComicionistaCollectionViaComicionista(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoComicionistaCollectionViaComicionista. When set to true, TipoComicionistaCollectionViaComicionista is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoComicionistaCollectionViaComicionista is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoComicionistaCollectionViaComicionista(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoComicionistaCollectionViaComicionista As Boolean
			Get
				Return _alwaysFetchTipoComicionistaCollectionViaComicionista
			End Get
			Set
				_alwaysFetchTipoComicionistaCollectionViaComicionista = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaComicionista()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaComicionista]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaComicionista(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaComicionista. When set to true, CuentaContableCollectionViaComicionista is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaComicionista is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaComicionista(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaComicionista As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaComicionista
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaComicionista = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecioCollectionViaCliente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecioCollectionViaCliente]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecioCollectionViaCliente(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioCollectionViaCliente. When set to true, ListaPrecioCollectionViaCliente is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioCollectionViaCliente is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecioCollectionViaCliente(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioCollectionViaCliente As Boolean
			Get
				Return _alwaysFetchListaPrecioCollectionViaCliente
			End Get
			Set
				_alwaysFetchListaPrecioCollectionViaCliente = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoVentaCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoVentaCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.TipoVentaCollection
			Get
				Return GetMultiTipoVentaCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoVentaCollectionViaListaPrecio. When set to true, TipoVentaCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoVentaCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoVentaCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoVentaCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchTipoVentaCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchTipoVentaCollectionViaListaPrecio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecioCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecioCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecioCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioCollectionViaListaPrecio. When set to true, ListaPrecioCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecioCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchListaPrecioCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchListaPrecioCollectionViaListaPrecio = value
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
				Return CInt(Integralab.ORM.EntityType.PlazaEntity)
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
