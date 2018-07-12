' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:03
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
	''' <summary>Entity class which represents the entity 'Almacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AlmacenEntity 
#Else
	<Serializable()> _
	Public Class AlmacenEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _almacenesFamilias As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
		Private _alwaysFetchAlmacenesFamilias, _alreadyFetchedAlmacenesFamilias As Boolean
		Private _aplicMedi As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMedi, _alreadyFetchedAplicMedi As Boolean
		Private _cabAplFor As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplFor, _alreadyFetchedCabAplFor As Boolean
		Private _cabPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm, _alreadyFetchedCabPrepForm As Boolean
		Private _cabProMed As Integralab.ORM.CollectionClasses.CabProMedCollection
		Private _alwaysFetchCabProMed, _alreadyFetchedCabProMed As Boolean
		Private _invHistorialPv As Integralab.ORM.CollectionClasses.InvHistorialPvCollection
		Private _alwaysFetchInvHistorialPv, _alreadyFetchedInvHistorialPv As Boolean
		Private _almacen__ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacen__, _alreadyFetchedAlmacen__ As Boolean
		Private _recepcionOrdenCompra As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
		Private _alwaysFetchRecepcionOrdenCompra, _alreadyFetchedRecepcionOrdenCompra As Boolean
		Private _inventarioAlmacen As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
		Private _alwaysFetchInventarioAlmacen, _alreadyFetchedInventarioAlmacen As Boolean
		Private _inventarioAlmacenLotes As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
		Private _alwaysFetchInventarioAlmacenLotes, _alreadyFetchedInventarioAlmacenLotes As Boolean
		Private _inventarioMovimientoAlmacen As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen As Boolean
		Private _inventarioMovimientoAlmacenDetalles As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
		Private _alwaysFetchInventarioMovimientoAlmacenDetalles, _alreadyFetchedInventarioMovimientoAlmacenDetalles As Boolean
		Private _minvMovimientosAlmacenPv As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
		Private _alwaysFetchMinvMovimientosAlmacenPv, _alreadyFetchedMinvMovimientosAlmacenPv As Boolean
		Private _minvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
		Private _alwaysFetchMinvMovimientosAlmacenPvdetalles, _alreadyFetchedMinvMovimientosAlmacenPvdetalles As Boolean
		Private _minvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntrada, _alreadyFetchedMinvTransferenciaAlmacenEntrada As Boolean
		Private _minvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntrada_, _alreadyFetchedMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _minvTransferenciaAlmacenProdDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenProdDetalle, _alreadyFetchedMinvTransferenciaAlmacenProdDetalle As Boolean
		Private _minvTransferenciaAlmacenSalida As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalida, _alreadyFetchedMinvTransferenciaAlmacenSalida As Boolean
		Private _minvTransferenciaAlmacenSalida_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalida_, _alreadyFetchedMinvTransferenciaAlmacenSalida_ As Boolean
		Private _mscinventarioProducto As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
		Private _alwaysFetchMscinventarioProducto, _alreadyFetchedMscinventarioProducto As Boolean
		Private _mscloteCortesDetComparacion As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
		Private _alwaysFetchMscloteCortesDetComparacion, _alreadyFetchedMscloteCortesDetComparacion As Boolean
		Private _mscmovtosAlmacenCab As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCab, _alreadyFetchedMscmovtosAlmacenCab As Boolean
		Private _almacenesSucursal As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
		Private _alwaysFetchAlmacenesSucursal, _alreadyFetchedAlmacenesSucursal As Boolean
		Private _usrAlmInvFisico As Integralab.ORM.CollectionClasses.InventarioFisicoCollection
		Private _alwaysFetchUsrAlmInvFisico, _alreadyFetchedUsrAlmInvFisico As Boolean
		Private _registroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisos, _alreadyFetchedRegistroSacrificiosDecomisos As Boolean
		Private _lineaCollectionViaAlmacenesFamilias As Integralab.ORM.CollectionClasses.LineaCollection
		Private _alwaysFetchLineaCollectionViaAlmacenesFamilias, _alreadyFetchedLineaCollectionViaAlmacenesFamilias As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaAplicMedi As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaAplicMedi_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabAplFor As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaCabAplFor_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ As Boolean
		Private _productoCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm, _alreadyFetchedProductoCollectionViaCabPrepForm As Boolean
		Private _productoCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm_, _alreadyFetchedProductoCollectionViaCabPrepForm_ As Boolean
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
		Private _inventarioMovimientoAlmacenCollectionViaCabProMed As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed As Boolean
		Private _productoCollectionViaInvHistorialPv As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaInvHistorialPv, _alreadyFetchedProductoCollectionViaInvHistorialPv As Boolean
		Private _plazaCollectionViaAlmacen As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaAlmacen, _alreadyFetchedPlazaCollectionViaAlmacen As Boolean
		Private _tipoAlmacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
		Private _alwaysFetchTipoAlmacenCollectionViaAlmacen, _alreadyFetchedTipoAlmacenCollectionViaAlmacen As Boolean
		Private _cuentaContableCollectionViaAlmacen As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaAlmacen, _alreadyFetchedCuentaContableCollectionViaAlmacen As Boolean
		Private _motivoCancelacionCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
		Private _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra, _alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra As Boolean
		Private _ordenCompraCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra, _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra As Boolean
		Private _productoCollectionViaInventarioAlmacen As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaInventarioAlmacen, _alreadyFetchedProductoCollectionViaInventarioAlmacen As Boolean
		Private _productoCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViainventarioAlmacenLotes, _alreadyFetchedProductoCollectionViainventarioAlmacenLotes As Boolean
		Private _inventarioAlmacenCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.InventarioAlmacenCollection
		Private _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes, _alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes As Boolean
		Private _tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
		Private _alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen, _alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen As Boolean
		Private _productoCollectionViaInventarioMovimientoAlmacenDetalles As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles, _alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
		Private _catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv As Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection
		Private _alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv, _alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv As Boolean
		Private _productoCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
		Private _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Boolean
		Private _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection
		Private _alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle, _alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ As Boolean
		Private _tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
		Private _alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab, _alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab As Boolean
		Private _productoCollectionViaUsrAlmInvFisico As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaUsrAlmInvFisico, _alreadyFetchedProductoCollectionViaUsrAlmInvFisico As Boolean
		Private _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos, _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos As Boolean
		Private _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_, _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ As Boolean
		Private _plaza_ As PlazaEntity
		Private _alwaysFetchPlaza_, _alreadyFetchedPlaza_, _plaza_ReturnsNewIfNotFound As Boolean
		Private _almacen_ As AlmacenEntity
		Private _alwaysFetchAlmacen_, _alreadyFetchedAlmacen_, _almacen_ReturnsNewIfNotFound As Boolean
		Private _tipoAlmacen_ As TipoAlmacenEntity
		Private _alwaysFetchTipoAlmacen_, _alreadyFetchedTipoAlmacen_, _tipoAlmacen_ReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean
		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean

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
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		Public Sub New(almacenId As System.Int32)

			InitClassFetch(almacenId, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(almacenId As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(almacenId, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="validator">The custom validator Object for this AlmacenEntity</param>
		Public Sub New(almacenId As System.Int32, validator As IValidator)

			InitClassFetch(almacenId, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_almacenesFamilias = CType(info.GetValue("_almacenesFamilias", GetType(Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection)), Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection)
			_alwaysFetchAlmacenesFamilias = info.GetBoolean("_alwaysFetchAlmacenesFamilias")
			_alreadyFetchedAlmacenesFamilias = info.GetBoolean("_alreadyFetchedAlmacenesFamilias")
			_aplicMedi = CType(info.GetValue("_aplicMedi", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMedi = info.GetBoolean("_alwaysFetchAplicMedi")
			_alreadyFetchedAplicMedi = info.GetBoolean("_alreadyFetchedAplicMedi")
			_cabAplFor = CType(info.GetValue("_cabAplFor", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplFor = info.GetBoolean("_alwaysFetchCabAplFor")
			_alreadyFetchedCabAplFor = info.GetBoolean("_alreadyFetchedCabAplFor")
			_cabPrepForm = CType(info.GetValue("_cabPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm = info.GetBoolean("_alwaysFetchCabPrepForm")
			_alreadyFetchedCabPrepForm = info.GetBoolean("_alreadyFetchedCabPrepForm")
			_cabProMed = CType(info.GetValue("_cabProMed", GetType(Integralab.ORM.CollectionClasses.CabProMedCollection)), Integralab.ORM.CollectionClasses.CabProMedCollection)
			_alwaysFetchCabProMed = info.GetBoolean("_alwaysFetchCabProMed")
			_alreadyFetchedCabProMed = info.GetBoolean("_alreadyFetchedCabProMed")
			_invHistorialPv = CType(info.GetValue("_invHistorialPv", GetType(Integralab.ORM.CollectionClasses.InvHistorialPvCollection)), Integralab.ORM.CollectionClasses.InvHistorialPvCollection)
			_alwaysFetchInvHistorialPv = info.GetBoolean("_alwaysFetchInvHistorialPv")
			_alreadyFetchedInvHistorialPv = info.GetBoolean("_alreadyFetchedInvHistorialPv")
			_almacen__ = CType(info.GetValue("_almacen__", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacen__ = info.GetBoolean("_alwaysFetchAlmacen__")
			_alreadyFetchedAlmacen__ = info.GetBoolean("_alreadyFetchedAlmacen__")
			_recepcionOrdenCompra = CType(info.GetValue("_recepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)), Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)
			_alwaysFetchRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchRecepcionOrdenCompra")
			_alreadyFetchedRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedRecepcionOrdenCompra")
			_inventarioAlmacen = CType(info.GetValue("_inventarioAlmacen", GetType(Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)
			_alwaysFetchInventarioAlmacen = info.GetBoolean("_alwaysFetchInventarioAlmacen")
			_alreadyFetchedInventarioAlmacen = info.GetBoolean("_alreadyFetchedInventarioAlmacen")
			_inventarioAlmacenLotes = CType(info.GetValue("_inventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)), Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)
			_alwaysFetchInventarioAlmacenLotes = info.GetBoolean("_alwaysFetchInventarioAlmacenLotes")
			_alreadyFetchedInventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedInventarioAlmacenLotes")
			_inventarioMovimientoAlmacen = CType(info.GetValue("_inventarioMovimientoAlmacen", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen")
			_alreadyFetchedInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen")
			_inventarioMovimientoAlmacenDetalles = CType(info.GetValue("_inventarioMovimientoAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)
			_alwaysFetchInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenDetalles")
			_alreadyFetchedInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenDetalles")
			_minvMovimientosAlmacenPv = CType(info.GetValue("_minvMovimientosAlmacenPv", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)
			_alwaysFetchMinvMovimientosAlmacenPv = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPv")
			_alreadyFetchedMinvMovimientosAlmacenPv = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPv")
			_minvMovimientosAlmacenPvdetalles = CType(info.GetValue("_minvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPvdetalles")
			_minvTransferenciaAlmacenEntrada = CType(info.GetValue("_minvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntrada")
			_minvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_minvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntrada_")
			_minvTransferenciaAlmacenProdDetalle = CType(info.GetValue("_minvTransferenciaAlmacenProdDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenProdDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenProdDetalle")
			_minvTransferenciaAlmacenSalida = CType(info.GetValue("_minvTransferenciaAlmacenSalida", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalida = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalida")
			_alreadyFetchedMinvTransferenciaAlmacenSalida = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalida")
			_minvTransferenciaAlmacenSalida_ = CType(info.GetValue("_minvTransferenciaAlmacenSalida_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalida_")
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalida_")
			_mscinventarioProducto = CType(info.GetValue("_mscinventarioProducto", GetType(Integralab.ORM.CollectionClasses.MscinventarioProductoCollection)), Integralab.ORM.CollectionClasses.MscinventarioProductoCollection)
			_alwaysFetchMscinventarioProducto = info.GetBoolean("_alwaysFetchMscinventarioProducto")
			_alreadyFetchedMscinventarioProducto = info.GetBoolean("_alreadyFetchedMscinventarioProducto")
			_mscloteCortesDetComparacion = CType(info.GetValue("_mscloteCortesDetComparacion", GetType(Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection)), Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection)
			_alwaysFetchMscloteCortesDetComparacion = info.GetBoolean("_alwaysFetchMscloteCortesDetComparacion")
			_alreadyFetchedMscloteCortesDetComparacion = info.GetBoolean("_alreadyFetchedMscloteCortesDetComparacion")
			_mscmovtosAlmacenCab = CType(info.GetValue("_mscmovtosAlmacenCab", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab")
			_alreadyFetchedMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab")
			_almacenesSucursal = CType(info.GetValue("_almacenesSucursal", GetType(Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection)), Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection)
			_alwaysFetchAlmacenesSucursal = info.GetBoolean("_alwaysFetchAlmacenesSucursal")
			_alreadyFetchedAlmacenesSucursal = info.GetBoolean("_alreadyFetchedAlmacenesSucursal")
			_usrAlmInvFisico = CType(info.GetValue("_usrAlmInvFisico", GetType(Integralab.ORM.CollectionClasses.InventarioFisicoCollection)), Integralab.ORM.CollectionClasses.InventarioFisicoCollection)
			_alwaysFetchUsrAlmInvFisico = info.GetBoolean("_alwaysFetchUsrAlmInvFisico")
			_alreadyFetchedUsrAlmInvFisico = info.GetBoolean("_alreadyFetchedUsrAlmInvFisico")
			_registroSacrificiosDecomisos = CType(info.GetValue("_registroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos")
			_alreadyFetchedRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos")
			_lineaCollectionViaAlmacenesFamilias = CType(info.GetValue("_lineaCollectionViaAlmacenesFamilias", GetType(Integralab.ORM.CollectionClasses.LineaCollection)), Integralab.ORM.CollectionClasses.LineaCollection)
			_alwaysFetchLineaCollectionViaAlmacenesFamilias = info.GetBoolean("_alwaysFetchLineaCollectionViaAlmacenesFamilias")
			_alreadyFetchedLineaCollectionViaAlmacenesFamilias = info.GetBoolean("_alreadyFetchedLineaCollectionViaAlmacenesFamilias")
			_inventarioMovimientoAlmacenCollectionViaAplicMedi = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaAplicMedi", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi")
			_inventarioMovimientoAlmacenCollectionViaAplicMedi_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaAplicMedi_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_")
			_inventarioMovimientoAlmacenCollectionViaCabAplFor = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabAplFor", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor")
			_inventarioMovimientoAlmacenCollectionViaCabAplFor_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabAplFor_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_")
			_productoCollectionViaCabPrepForm = CType(info.GetValue("_productoCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm")
			_alreadyFetchedProductoCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm")
			_productoCollectionViaCabPrepForm_ = CType(info.GetValue("_productoCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm_")
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm_")
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
			_inventarioMovimientoAlmacenCollectionViaCabProMed = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaCabProMed", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed")
			_productoCollectionViaInvHistorialPv = CType(info.GetValue("_productoCollectionViaInvHistorialPv", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaInvHistorialPv = info.GetBoolean("_alwaysFetchProductoCollectionViaInvHistorialPv")
			_alreadyFetchedProductoCollectionViaInvHistorialPv = info.GetBoolean("_alreadyFetchedProductoCollectionViaInvHistorialPv")
			_plazaCollectionViaAlmacen = CType(info.GetValue("_plazaCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaAlmacen = info.GetBoolean("_alwaysFetchPlazaCollectionViaAlmacen")
			_alreadyFetchedPlazaCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedPlazaCollectionViaAlmacen")
			_tipoAlmacenCollectionViaAlmacen = CType(info.GetValue("_tipoAlmacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.TipoAlmacenCollection)), Integralab.ORM.CollectionClasses.TipoAlmacenCollection)
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchTipoAlmacenCollectionViaAlmacen")
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedTipoAlmacenCollectionViaAlmacen")
			_cuentaContableCollectionViaAlmacen = CType(info.GetValue("_cuentaContableCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaAlmacen = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaAlmacen")
			_alreadyFetchedCuentaContableCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaAlmacen")
			_motivoCancelacionCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_motivoCancelacionCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)), Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)
			_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra")
			_ordenCompraCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_ordenCompraCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra")
			_productoCollectionViaInventarioAlmacen = CType(info.GetValue("_productoCollectionViaInventarioAlmacen", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaInventarioAlmacen = info.GetBoolean("_alwaysFetchProductoCollectionViaInventarioAlmacen")
			_alreadyFetchedProductoCollectionViaInventarioAlmacen = info.GetBoolean("_alreadyFetchedProductoCollectionViaInventarioAlmacen")
			_productoCollectionViainventarioAlmacenLotes = CType(info.GetValue("_productoCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchProductoCollectionViainventarioAlmacenLotes")
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedProductoCollectionViainventarioAlmacenLotes")
			_inventarioAlmacenCollectionViainventarioAlmacenLotes = CType(info.GetValue("_inventarioAlmacenCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioAlmacenCollection)
			_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes")
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes")
			_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = CType(info.GetValue("_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen", GetType(Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection)
			_alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen")
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen")
			_productoCollectionViaInventarioMovimientoAlmacenDetalles = CType(info.GetValue("_productoCollectionViaInventarioMovimientoAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles")
			_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles")
			_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = CType(info.GetValue("_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv", GetType(Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection)), Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection)
			_alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = info.GetBoolean("_alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv")
			_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = info.GetBoolean("_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv")
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_productoCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles")
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection)
			_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___")
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_")
			_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = CType(info.GetValue("_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection)
			_alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___")
			_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = CType(info.GetValue("_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab", GetType(Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection)
			_alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab")
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab")
			_productoCollectionViaUsrAlmInvFisico = CType(info.GetValue("_productoCollectionViaUsrAlmInvFisico", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaUsrAlmInvFisico = info.GetBoolean("_alwaysFetchProductoCollectionViaUsrAlmInvFisico")
			_alreadyFetchedProductoCollectionViaUsrAlmInvFisico = info.GetBoolean("_alreadyFetchedProductoCollectionViaUsrAlmInvFisico")
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos")
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_")
			_plaza_ = CType(info.GetValue("_plaza_", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza_ Is Nothing Then
				AddHandler _plaza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plaza_ReturnsNewIfNotFound = info.GetBoolean("_plaza_ReturnsNewIfNotFound")
			_alwaysFetchPlaza_ = info.GetBoolean("_alwaysFetchPlaza_")
			_alreadyFetchedPlaza_ = info.GetBoolean("_alreadyFetchedPlaza_")
			_almacen_ = CType(info.GetValue("_almacen_", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen_ Is Nothing Then
				AddHandler _almacen_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacen_ReturnsNewIfNotFound = info.GetBoolean("_almacen_ReturnsNewIfNotFound")
			_alwaysFetchAlmacen_ = info.GetBoolean("_alwaysFetchAlmacen_")
			_alreadyFetchedAlmacen_ = info.GetBoolean("_alreadyFetchedAlmacen_")
			_tipoAlmacen_ = CType(info.GetValue("_tipoAlmacen_", GetType(TipoAlmacenEntity)), TipoAlmacenEntity)
			If Not _tipoAlmacen_ Is Nothing Then
				AddHandler _tipoAlmacen_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoAlmacen_ReturnsNewIfNotFound = info.GetBoolean("_tipoAlmacen_ReturnsNewIfNotFound")
			_alwaysFetchTipoAlmacen_ = info.GetBoolean("_alwaysFetchTipoAlmacen_")
			_alreadyFetchedTipoAlmacen_ = info.GetBoolean("_alreadyFetchedTipoAlmacen_")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes Is Nothing Then
				' rewire event handler.
				AddHandler _mfacCatClientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientesReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientesReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAlmacenesFamilias = (_almacenesFamilias.Count > 0)
			_alreadyFetchedAplicMedi = (_aplicMedi.Count > 0)
			_alreadyFetchedCabAplFor = (_cabAplFor.Count > 0)
			_alreadyFetchedCabPrepForm = (_cabPrepForm.Count > 0)
			_alreadyFetchedCabProMed = (_cabProMed.Count > 0)
			_alreadyFetchedInvHistorialPv = (_invHistorialPv.Count > 0)
			_alreadyFetchedAlmacen__ = (_almacen__.Count > 0)
			_alreadyFetchedRecepcionOrdenCompra = (_recepcionOrdenCompra.Count > 0)
			_alreadyFetchedInventarioAlmacen = (_inventarioAlmacen.Count > 0)
			_alreadyFetchedInventarioAlmacenLotes = (_inventarioAlmacenLotes.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacen = (_inventarioMovimientoAlmacen.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenDetalles = (_inventarioMovimientoAlmacenDetalles.Count > 0)
			_alreadyFetchedMinvMovimientosAlmacenPv = (_minvMovimientosAlmacenPv.Count > 0)
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = (_minvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = (_minvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = (_minvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = (_minvTransferenciaAlmacenProdDetalle.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalida = (_minvTransferenciaAlmacenSalida.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = (_minvTransferenciaAlmacenSalida_.Count > 0)
			_alreadyFetchedMscinventarioProducto = (_mscinventarioProducto.Count > 0)
			_alreadyFetchedMscloteCortesDetComparacion = (_mscloteCortesDetComparacion.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCab = (_mscmovtosAlmacenCab.Count > 0)
			_alreadyFetchedAlmacenesSucursal = (_almacenesSucursal.Count > 0)
			_alreadyFetchedUsrAlmInvFisico = (_usrAlmInvFisico.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisos = (_registroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedLineaCollectionViaAlmacenesFamilias = (_lineaCollectionViaAlmacenesFamilias.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi = (_inventarioMovimientoAlmacenCollectionViaAplicMedi.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ = (_inventarioMovimientoAlmacenCollectionViaAplicMedi_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor = (_inventarioMovimientoAlmacenCollectionViaCabAplFor.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ = (_inventarioMovimientoAlmacenCollectionViaCabAplFor_.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm = (_productoCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = (_productoCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm = (_plazaCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm_ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm__ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabPrepForm___ = (_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed = (_inventarioMovimientoAlmacenCollectionViaCabProMed.Count > 0)
			_alreadyFetchedProductoCollectionViaInvHistorialPv = (_productoCollectionViaInvHistorialPv.Count > 0)
			_alreadyFetchedPlazaCollectionViaAlmacen = (_plazaCollectionViaAlmacen.Count > 0)
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = (_tipoAlmacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaAlmacen = (_cuentaContableCollectionViaAlmacen.Count > 0)
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = (_motivoCancelacionCollectionViaRecepcionOrdenCompra.Count > 0)
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = (_ordenCompraCollectionViaRecepcionOrdenCompra.Count > 0)
			_alreadyFetchedProductoCollectionViaInventarioAlmacen = (_productoCollectionViaInventarioAlmacen.Count > 0)
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = (_productoCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = (_inventarioAlmacenCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = (_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.Count > 0)
			_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles = (_productoCollectionViaInventarioMovimientoAlmacenDetalles.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = (_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.Count > 0)
			_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = (_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.Count > 0)
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = (_productoCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = (_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = (_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = (_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = (_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.Count > 0)
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = (_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.Count > 0)
			_alreadyFetchedProductoCollectionViaUsrAlmInvFisico = (_productoCollectionViaUsrAlmInvFisico.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = (_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = (_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.Count > 0)
			_alreadyFetchedPlaza_ = Not(_plaza_ Is Nothing)
			_alreadyFetchedAlmacen_ = Not(_almacen_ Is Nothing)
			_alreadyFetchedTipoAlmacen_ = Not(_tipoAlmacen_ Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)
			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)
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
			info.AddValue("_almacenesFamilias", _almacenesFamilias)
			info.AddValue("_alwaysFetchAlmacenesFamilias", _alwaysFetchAlmacenesFamilias)
			info.AddValue("_alreadyFetchedAlmacenesFamilias", _alreadyFetchedAlmacenesFamilias)
			info.AddValue("_aplicMedi", _aplicMedi)
			info.AddValue("_alwaysFetchAplicMedi", _alwaysFetchAplicMedi)
			info.AddValue("_alreadyFetchedAplicMedi", _alreadyFetchedAplicMedi)
			info.AddValue("_cabAplFor", _cabAplFor)
			info.AddValue("_alwaysFetchCabAplFor", _alwaysFetchCabAplFor)
			info.AddValue("_alreadyFetchedCabAplFor", _alreadyFetchedCabAplFor)
			info.AddValue("_cabPrepForm", _cabPrepForm)
			info.AddValue("_alwaysFetchCabPrepForm", _alwaysFetchCabPrepForm)
			info.AddValue("_alreadyFetchedCabPrepForm", _alreadyFetchedCabPrepForm)
			info.AddValue("_cabProMed", _cabProMed)
			info.AddValue("_alwaysFetchCabProMed", _alwaysFetchCabProMed)
			info.AddValue("_alreadyFetchedCabProMed", _alreadyFetchedCabProMed)
			info.AddValue("_invHistorialPv", _invHistorialPv)
			info.AddValue("_alwaysFetchInvHistorialPv", _alwaysFetchInvHistorialPv)
			info.AddValue("_alreadyFetchedInvHistorialPv", _alreadyFetchedInvHistorialPv)
			info.AddValue("_almacen__", _almacen__)
			info.AddValue("_alwaysFetchAlmacen__", _alwaysFetchAlmacen__)
			info.AddValue("_alreadyFetchedAlmacen__", _alreadyFetchedAlmacen__)
			info.AddValue("_recepcionOrdenCompra", _recepcionOrdenCompra)
			info.AddValue("_alwaysFetchRecepcionOrdenCompra", _alwaysFetchRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedRecepcionOrdenCompra", _alreadyFetchedRecepcionOrdenCompra)
			info.AddValue("_inventarioAlmacen", _inventarioAlmacen)
			info.AddValue("_alwaysFetchInventarioAlmacen", _alwaysFetchInventarioAlmacen)
			info.AddValue("_alreadyFetchedInventarioAlmacen", _alreadyFetchedInventarioAlmacen)
			info.AddValue("_inventarioAlmacenLotes", _inventarioAlmacenLotes)
			info.AddValue("_alwaysFetchInventarioAlmacenLotes", _alwaysFetchInventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedInventarioAlmacenLotes", _alreadyFetchedInventarioAlmacenLotes)
			info.AddValue("_inventarioMovimientoAlmacen", _inventarioMovimientoAlmacen)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen", _alwaysFetchInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen", _alreadyFetchedInventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacenDetalles", _inventarioMovimientoAlmacenDetalles)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenDetalles", _alwaysFetchInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenDetalles", _alreadyFetchedInventarioMovimientoAlmacenDetalles)
			info.AddValue("_minvMovimientosAlmacenPv", _minvMovimientosAlmacenPv)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPv", _alwaysFetchMinvMovimientosAlmacenPv)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPv", _alreadyFetchedMinvMovimientosAlmacenPv)
			info.AddValue("_minvMovimientosAlmacenPvdetalles", _minvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPvdetalles", _alwaysFetchMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPvdetalles", _alreadyFetchedMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_minvTransferenciaAlmacenEntrada", _minvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntrada", _alwaysFetchMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntrada", _alreadyFetchedMinvTransferenciaAlmacenEntrada)
			info.AddValue("_minvTransferenciaAlmacenEntrada_", _minvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntrada_", _alwaysFetchMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntrada_", _alreadyFetchedMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_minvTransferenciaAlmacenProdDetalle", _minvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenProdDetalle", _alwaysFetchMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenProdDetalle", _alreadyFetchedMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_minvTransferenciaAlmacenSalida", _minvTransferenciaAlmacenSalida)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalida", _alwaysFetchMinvTransferenciaAlmacenSalida)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalida", _alreadyFetchedMinvTransferenciaAlmacenSalida)
			info.AddValue("_minvTransferenciaAlmacenSalida_", _minvTransferenciaAlmacenSalida_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalida_", _alwaysFetchMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalida_", _alreadyFetchedMinvTransferenciaAlmacenSalida_)
			info.AddValue("_mscinventarioProducto", _mscinventarioProducto)
			info.AddValue("_alwaysFetchMscinventarioProducto", _alwaysFetchMscinventarioProducto)
			info.AddValue("_alreadyFetchedMscinventarioProducto", _alreadyFetchedMscinventarioProducto)
			info.AddValue("_mscloteCortesDetComparacion", _mscloteCortesDetComparacion)
			info.AddValue("_alwaysFetchMscloteCortesDetComparacion", _alwaysFetchMscloteCortesDetComparacion)
			info.AddValue("_alreadyFetchedMscloteCortesDetComparacion", _alreadyFetchedMscloteCortesDetComparacion)
			info.AddValue("_mscmovtosAlmacenCab", _mscmovtosAlmacenCab)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab", _alwaysFetchMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab", _alreadyFetchedMscmovtosAlmacenCab)
			info.AddValue("_almacenesSucursal", _almacenesSucursal)
			info.AddValue("_alwaysFetchAlmacenesSucursal", _alwaysFetchAlmacenesSucursal)
			info.AddValue("_alreadyFetchedAlmacenesSucursal", _alreadyFetchedAlmacenesSucursal)
			info.AddValue("_usrAlmInvFisico", _usrAlmInvFisico)
			info.AddValue("_alwaysFetchUsrAlmInvFisico", _alwaysFetchUsrAlmInvFisico)
			info.AddValue("_alreadyFetchedUsrAlmInvFisico", _alreadyFetchedUsrAlmInvFisico)
			info.AddValue("_registroSacrificiosDecomisos", _registroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos", _alwaysFetchRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos", _alreadyFetchedRegistroSacrificiosDecomisos)
			info.AddValue("_lineaCollectionViaAlmacenesFamilias", _lineaCollectionViaAlmacenesFamilias)
			info.AddValue("_alwaysFetchLineaCollectionViaAlmacenesFamilias", _alwaysFetchLineaCollectionViaAlmacenesFamilias)
			info.AddValue("_alreadyFetchedLineaCollectionViaAlmacenesFamilias", _alreadyFetchedLineaCollectionViaAlmacenesFamilias)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaAplicMedi", _inventarioMovimientoAlmacenCollectionViaAplicMedi)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi", _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaAplicMedi_", _inventarioMovimientoAlmacenCollectionViaAplicMedi_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabAplFor", _inventarioMovimientoAlmacenCollectionViaCabAplFor)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabAplFor_", _inventarioMovimientoAlmacenCollectionViaCabAplFor_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_)
			info.AddValue("_productoCollectionViaCabPrepForm", _productoCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm", _alwaysFetchProductoCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm", _alreadyFetchedProductoCollectionViaCabPrepForm)
			info.AddValue("_productoCollectionViaCabPrepForm_", _productoCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm_", _alwaysFetchProductoCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm_", _alreadyFetchedProductoCollectionViaCabPrepForm_)
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
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaCabProMed", _inventarioMovimientoAlmacenCollectionViaCabProMed)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed", _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed)
			info.AddValue("_productoCollectionViaInvHistorialPv", _productoCollectionViaInvHistorialPv)
			info.AddValue("_alwaysFetchProductoCollectionViaInvHistorialPv", _alwaysFetchProductoCollectionViaInvHistorialPv)
			info.AddValue("_alreadyFetchedProductoCollectionViaInvHistorialPv", _alreadyFetchedProductoCollectionViaInvHistorialPv)
			info.AddValue("_plazaCollectionViaAlmacen", _plazaCollectionViaAlmacen)
			info.AddValue("_alwaysFetchPlazaCollectionViaAlmacen", _alwaysFetchPlazaCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedPlazaCollectionViaAlmacen", _alreadyFetchedPlazaCollectionViaAlmacen)
			info.AddValue("_tipoAlmacenCollectionViaAlmacen", _tipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchTipoAlmacenCollectionViaAlmacen", _alwaysFetchTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedTipoAlmacenCollectionViaAlmacen", _alreadyFetchedTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_cuentaContableCollectionViaAlmacen", _cuentaContableCollectionViaAlmacen)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaAlmacen", _alwaysFetchCuentaContableCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaAlmacen", _alreadyFetchedCuentaContableCollectionViaAlmacen)
			info.AddValue("_motivoCancelacionCollectionViaRecepcionOrdenCompra", _motivoCancelacionCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra", _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra", _alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra)
			info.AddValue("_ordenCompraCollectionViaRecepcionOrdenCompra", _ordenCompraCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra", _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra", _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra)
			info.AddValue("_productoCollectionViaInventarioAlmacen", _productoCollectionViaInventarioAlmacen)
			info.AddValue("_alwaysFetchProductoCollectionViaInventarioAlmacen", _alwaysFetchProductoCollectionViaInventarioAlmacen)
			info.AddValue("_alreadyFetchedProductoCollectionViaInventarioAlmacen", _alreadyFetchedProductoCollectionViaInventarioAlmacen)
			info.AddValue("_productoCollectionViainventarioAlmacenLotes", _productoCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchProductoCollectionViainventarioAlmacenLotes", _alwaysFetchProductoCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedProductoCollectionViainventarioAlmacenLotes", _alreadyFetchedProductoCollectionViainventarioAlmacenLotes)
			info.AddValue("_inventarioAlmacenCollectionViainventarioAlmacenLotes", _inventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes", _alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes", _alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen", _tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen", _alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen", _alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_productoCollectionViaInventarioMovimientoAlmacenDetalles", _productoCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles", _alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles", _alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv", _catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv)
			info.AddValue("_alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv", _alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv)
			info.AddValue("_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv", _alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv)
			info.AddValue("_productoCollectionViaMinvMovimientosAlmacenPvdetalles", _productoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle", _minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle", _alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle", _alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab", _tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab)
			info.AddValue("_alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab", _alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab", _alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab)
			info.AddValue("_productoCollectionViaUsrAlmInvFisico", _productoCollectionViaUsrAlmInvFisico)
			info.AddValue("_alwaysFetchProductoCollectionViaUsrAlmInvFisico", _alwaysFetchProductoCollectionViaUsrAlmInvFisico)
			info.AddValue("_alreadyFetchedProductoCollectionViaUsrAlmInvFisico", _alreadyFetchedProductoCollectionViaUsrAlmInvFisico)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos", _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos", _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos", _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_", _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_", _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_", _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_)
			info.AddValue("_plaza_", _plaza_)
			info.AddValue("_plaza_ReturnsNewIfNotFound", _plaza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza_", _alwaysFetchPlaza_)
			info.AddValue("_alreadyFetchedPlaza_", _alreadyFetchedPlaza_)
			info.AddValue("_almacen_", _almacen_)
			info.AddValue("_almacen_ReturnsNewIfNotFound", _almacen_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen_", _alwaysFetchAlmacen_)
			info.AddValue("_alreadyFetchedAlmacen_", _alreadyFetchedAlmacen_)
			info.AddValue("_tipoAlmacen_", _tipoAlmacen_)
			info.AddValue("_tipoAlmacen_ReturnsNewIfNotFound", _tipoAlmacen_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoAlmacen_", _alwaysFetchTipoAlmacen_)
			info.AddValue("_alreadyFetchedTipoAlmacen_", _alreadyFetchedTipoAlmacen_)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			
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
				Case "Plaza_"
					_alreadyFetchedPlaza_ = True
					Me.Plaza_ = CType(entity, PlazaEntity)
				Case "Almacen_"
					_alreadyFetchedAlmacen_ = True
					Me.Almacen_ = CType(entity, AlmacenEntity)
				Case "TipoAlmacen_"
					_alreadyFetchedTipoAlmacen_ = True
					Me.TipoAlmacen_ = CType(entity, TipoAlmacenEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "AlmacenesFamilias"
					_alreadyFetchedAlmacenesFamilias = True
					If Not entity Is Nothing Then
						Me.AlmacenesFamilias.Add(CType(entity, AlmacenesFamiliasEntity))
					End If
				Case "AplicMedi"
					_alreadyFetchedAplicMedi = True
					If Not entity Is Nothing Then
						Me.AplicMedi.Add(CType(entity, AplicMediEntity))
					End If
				Case "CabAplFor"
					_alreadyFetchedCabAplFor = True
					If Not entity Is Nothing Then
						Me.CabAplFor.Add(CType(entity, CabAplForEntity))
					End If
				Case "CabPrepForm"
					_alreadyFetchedCabPrepForm = True
					If Not entity Is Nothing Then
						Me.CabPrepForm.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "CabProMed"
					_alreadyFetchedCabProMed = True
					If Not entity Is Nothing Then
						Me.CabProMed.Add(CType(entity, CabProMedEntity))
					End If
				Case "InvHistorialPv"
					_alreadyFetchedInvHistorialPv = True
					If Not entity Is Nothing Then
						Me.InvHistorialPv.Add(CType(entity, InvHistorialPvEntity))
					End If
				Case "Almacen__"
					_alreadyFetchedAlmacen__ = True
					If Not entity Is Nothing Then
						Me.Almacen__.Add(CType(entity, AlmacenEntity))
					End If
				Case "RecepcionOrdenCompra"
					_alreadyFetchedRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.RecepcionOrdenCompra.Add(CType(entity, RecepcionOrdenCompraEntity))
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
				Case "InventarioMovimientoAlmacen"
					_alreadyFetchedInventarioMovimientoAlmacen = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacen.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenDetalles"
					_alreadyFetchedInventarioMovimientoAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenDetalles.Add(CType(entity, InventarioMovimientoAlmacenDetallesEntity))
					End If
				Case "MinvMovimientosAlmacenPv"
					_alreadyFetchedMinvMovimientosAlmacenPv = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPv.Add(CType(entity, MinvMovimientosAlmacenPvEntity))
					End If
				Case "MinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPvdetalles.Add(CType(entity, MinvMovimientosAlmacenPvdetallesEntity))
					End If
				Case "MinvTransferenciaAlmacenEntrada"
					_alreadyFetchedMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntrada.Add(CType(entity, MinvTransferenciaAlmacenEntradaEntity))
					End If
				Case "MinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntrada_.Add(CType(entity, MinvTransferenciaAlmacenEntradaEntity))
					End If
				Case "MinvTransferenciaAlmacenProdDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenProdDetalle.Add(CType(entity, MinvTransferenciaAlmacenProdDetalleEntity))
					End If
				Case "MinvTransferenciaAlmacenSalida"
					_alreadyFetchedMinvTransferenciaAlmacenSalida = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalida.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "MinvTransferenciaAlmacenSalida_"
					_alreadyFetchedMinvTransferenciaAlmacenSalida_ = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalida_.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "MscinventarioProducto"
					_alreadyFetchedMscinventarioProducto = True
					If Not entity Is Nothing Then
						Me.MscinventarioProducto.Add(CType(entity, MscinventarioProductoEntity))
					End If
				Case "MscloteCortesDetComparacion"
					_alreadyFetchedMscloteCortesDetComparacion = True
					If Not entity Is Nothing Then
						Me.MscloteCortesDetComparacion.Add(CType(entity, MscloteCortesDetComparacionEntity))
					End If
				Case "MscmovtosAlmacenCab"
					_alreadyFetchedMscmovtosAlmacenCab = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCab.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "AlmacenesSucursal"
					_alreadyFetchedAlmacenesSucursal = True
					If Not entity Is Nothing Then
						Me.AlmacenesSucursal.Add(CType(entity, AlmacenesSucursalEntity))
					End If
				Case "UsrAlmInvFisico"
					_alreadyFetchedUsrAlmInvFisico = True
					If Not entity Is Nothing Then
						Me.UsrAlmInvFisico.Add(CType(entity, InventarioFisicoEntity))
					End If
				Case "RegistroSacrificiosDecomisos"
					_alreadyFetchedRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisos.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "LineaCollectionViaAlmacenesFamilias"
					_alreadyFetchedLineaCollectionViaAlmacenesFamilias = True
					If Not entity Is Nothing Then
						Me.LineaCollectionViaAlmacenesFamilias.Add(CType(entity, LineaEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaAplicMedi"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaAplicMedi.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaAplicMedi_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaAplicMedi_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabAplFor"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabAplFor.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaCabAplFor_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabAplFor_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
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
				Case "InventarioMovimientoAlmacenCollectionViaCabProMed"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaCabProMed.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "ProductoCollectionViaInvHistorialPv"
					_alreadyFetchedProductoCollectionViaInvHistorialPv = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaInvHistorialPv.Add(CType(entity, ProductoEntity))
					End If
				Case "PlazaCollectionViaAlmacen"
					_alreadyFetchedPlazaCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaAlmacen.Add(CType(entity, PlazaEntity))
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
				Case "MotivoCancelacionCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.MotivoCancelacionCollectionViaRecepcionOrdenCompra.Add(CType(entity, MotivoCancelacionEntity))
					End If
				Case "OrdenCompraCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.OrdenCompraCollectionViaRecepcionOrdenCompra.Add(CType(entity, OrdenCompraEntity))
					End If
				Case "ProductoCollectionViaInventarioAlmacen"
					_alreadyFetchedProductoCollectionViaInventarioAlmacen = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaInventarioAlmacen.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViainventarioAlmacenLotes"
					_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViainventarioAlmacenLotes.Add(CType(entity, ProductoEntity))
					End If
				Case "InventarioAlmacenCollectionViainventarioAlmacenLotes"
					_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.InventarioAlmacenCollectionViainventarioAlmacenLotes.Add(CType(entity, InventarioAlmacenEntity))
					End If
				Case "TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen"
					_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = True
					If Not entity Is Nothing Then
						Me.TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.Add(CType(entity, TipoMovimientoAlmacenEntity))
					End If
				Case "ProductoCollectionViaInventarioMovimientoAlmacenDetalles"
					_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaInventarioMovimientoAlmacenDetalles.Add(CType(entity, ProductoEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv"
					_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = True
					If Not entity Is Nothing Then
						Me.CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.Add(CType(entity, CatMovimientosAlmacenPvEntity))
					End If
				Case "ProductoCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, ProductoEntity))
					End If
				Case "MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, MinvMovimientosAlmacenPvEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.Add(CType(entity, MinvTransferenciaAlmacenProdEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab"
					_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = True
					If Not entity Is Nothing Then
						Me.TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.Add(CType(entity, TipoMovimientoAlmacenEntity))
					End If
				Case "ProductoCollectionViaUsrAlmInvFisico"
					_alreadyFetchedProductoCollectionViaUsrAlmInvFisico = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaUsrAlmInvFisico.Add(CType(entity, ProductoEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Plaza_"
					SetupSyncPlaza_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen_"
					SetupSyncAlmacen_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoAlmacen_"
					SetupSyncTipoAlmacen_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AlmacenesFamilias"
					_almacenesFamilias.Add(CType(relatedEntity, AlmacenesFamiliasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMedi"
					_aplicMedi.Add(CType(relatedEntity, AplicMediEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabAplFor"
					_cabAplFor.Add(CType(relatedEntity, CabAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm"
					_cabPrepForm.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabProMed"
					_cabProMed.Add(CType(relatedEntity, CabProMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InvHistorialPv"
					_invHistorialPv.Add(CType(relatedEntity, InvHistorialPvEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen__"
					_almacen__.Add(CType(relatedEntity, AlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					_recepcionOrdenCompra.Add(CType(relatedEntity, RecepcionOrdenCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioAlmacen"
					_inventarioAlmacen.Add(CType(relatedEntity, InventarioAlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					_inventarioAlmacenLotes.Add(CType(relatedEntity, inventarioAlmacenLotesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					_inventarioMovimientoAlmacen.Add(CType(relatedEntity, InventarioMovimientoAlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacenDetalles"
					_inventarioMovimientoAlmacenDetalles.Add(CType(relatedEntity, InventarioMovimientoAlmacenDetallesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPv"
					_minvMovimientosAlmacenPv.Add(CType(relatedEntity, MinvMovimientosAlmacenPvEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					_minvMovimientosAlmacenPvdetalles.Add(CType(relatedEntity, MinvMovimientosAlmacenPvdetallesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					_minvTransferenciaAlmacenEntrada.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada_"
					_minvTransferenciaAlmacenEntrada_.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenProdDetalle"
					_minvTransferenciaAlmacenProdDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenProdDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida"
					_minvTransferenciaAlmacenSalida.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida_"
					_minvTransferenciaAlmacenSalida_.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscinventarioProducto"
					_mscinventarioProducto.Add(CType(relatedEntity, MscinventarioProductoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesDetComparacion"
					_mscloteCortesDetComparacion.Add(CType(relatedEntity, MscloteCortesDetComparacionEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					_mscmovtosAlmacenCab.Add(CType(relatedEntity, MscmovtosAlmacenCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AlmacenesSucursal"
					_almacenesSucursal.Add(CType(relatedEntity, AlmacenesSucursalEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrAlmInvFisico"
					_usrAlmInvFisico.Add(CType(relatedEntity, InventarioFisicoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					_registroSacrificiosDecomisos.Add(CType(relatedEntity, RegistroSacrificiosDecomisosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
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
				Case "Plaza_"
					DesetupSyncPlaza_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen_"
					DesetupSyncAlmacen_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoAlmacen_"
					DesetupSyncTipoAlmacen_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AlmacenesFamilias"
					MyBase.PerformRelatedEntityRemoval(_almacenesFamilias, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMedi"
					MyBase.PerformRelatedEntityRemoval(_aplicMedi, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabAplFor"
					MyBase.PerformRelatedEntityRemoval(_cabAplFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabProMed"
					MyBase.PerformRelatedEntityRemoval(_cabProMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InvHistorialPv"
					MyBase.PerformRelatedEntityRemoval(_invHistorialPv, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen__"
					MyBase.PerformRelatedEntityRemoval(_almacen__, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_recepcionOrdenCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioAlmacen"
					MyBase.PerformRelatedEntityRemoval(_inventarioAlmacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					MyBase.PerformRelatedEntityRemoval(_inventarioAlmacenLotes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					MyBase.PerformRelatedEntityRemoval(_inventarioMovimientoAlmacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacenDetalles"
					MyBase.PerformRelatedEntityRemoval(_inventarioMovimientoAlmacenDetalles, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPv"
					MyBase.PerformRelatedEntityRemoval(_minvMovimientosAlmacenPv, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					MyBase.PerformRelatedEntityRemoval(_minvMovimientosAlmacenPvdetalles, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntrada, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada_"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntrada_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenProdDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenProdDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalida, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida_"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalida_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscinventarioProducto"
					MyBase.PerformRelatedEntityRemoval(_mscinventarioProducto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesDetComparacion"
					MyBase.PerformRelatedEntityRemoval(_mscloteCortesDetComparacion, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					MyBase.PerformRelatedEntityRemoval(_mscmovtosAlmacenCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AlmacenesSucursal"
					MyBase.PerformRelatedEntityRemoval(_almacenesSucursal, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrAlmInvFisico"
					MyBase.PerformRelatedEntityRemoval(_usrAlmInvFisico, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					MyBase.PerformRelatedEntityRemoval(_registroSacrificiosDecomisos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
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
			If Not _plaza_ Is Nothing Then
				toReturn.Add(_plaza_)
			End If
			If Not _almacen_ Is Nothing Then
				toReturn.Add(_almacen_)
			End If
			If Not _tipoAlmacen_ Is Nothing Then
				toReturn.Add(_tipoAlmacen_)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If

			If Not _mfacCatClientes Is Nothing Then
				toReturn.Add(_mfacCatClientes)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_almacenesFamilias)
			toReturn.Add(_aplicMedi)
			toReturn.Add(_cabAplFor)
			toReturn.Add(_cabPrepForm)
			toReturn.Add(_cabProMed)
			toReturn.Add(_invHistorialPv)
			toReturn.Add(_almacen__)
			toReturn.Add(_recepcionOrdenCompra)
			toReturn.Add(_inventarioAlmacen)
			toReturn.Add(_inventarioAlmacenLotes)
			toReturn.Add(_inventarioMovimientoAlmacen)
			toReturn.Add(_inventarioMovimientoAlmacenDetalles)
			toReturn.Add(_minvMovimientosAlmacenPv)
			toReturn.Add(_minvMovimientosAlmacenPvdetalles)
			toReturn.Add(_minvTransferenciaAlmacenEntrada)
			toReturn.Add(_minvTransferenciaAlmacenEntrada_)
			toReturn.Add(_minvTransferenciaAlmacenProdDetalle)
			toReturn.Add(_minvTransferenciaAlmacenSalida)
			toReturn.Add(_minvTransferenciaAlmacenSalida_)
			toReturn.Add(_mscinventarioProducto)
			toReturn.Add(_mscloteCortesDetComparacion)
			toReturn.Add(_mscmovtosAlmacenCab)
			toReturn.Add(_almacenesSucursal)
			toReturn.Add(_usrAlmInvFisico)
			toReturn.Add(_registroSacrificiosDecomisos)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32) As Boolean
			Return FetchUsingPK(almacenId, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(almacenId, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(almacenId, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.AlmacenId, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As AlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As AlmacenFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'AlmacenesFamiliasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenesFamiliasEntity'</returns>
		Public Function GetMultiAlmacenesFamilias(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
			Return GetMultiAlmacenesFamilias(forceFetch, _almacenesFamilias.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesFamiliasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAlmacenesFamilias(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
			Return GetMultiAlmacenesFamilias(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesFamiliasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenesFamiliasEntity'</returns>
		Public Function GetMultiAlmacenesFamilias(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
			Return GetMultiAlmacenesFamilias(forceFetch, _almacenesFamilias.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesFamiliasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenesFamilias(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
			If ( Not _alreadyFetchedAlmacenesFamilias Or forceFetch Or _alwaysFetchAlmacenesFamilias) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenesFamilias.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenesFamilias)
					End If
				End If
				_almacenesFamilias.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenesFamilias.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenesFamilias.GetMultiManyToOne(Me, Nothing, Filter)
				_almacenesFamilias.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenesFamilias = True
			End If
			Return _almacenesFamilias
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenesFamilias'. These settings will be taken into account
		''' when the property AlmacenesFamilias is requested or GetMultiAlmacenesFamilias is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenesFamilias(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenesFamilias.SortClauses=sortClauses
			_almacenesFamilias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMedi(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi(forceFetch, _aplicMedi.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAplicMedi(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMedi(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi(forceFetch, _aplicMedi.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMedi(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediCollection
			If ( Not _alreadyFetchedAplicMedi Or forceFetch Or _alwaysFetchAplicMedi) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMedi.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMedi)
					End If
				End If
				_aplicMedi.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMedi.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMedi.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_aplicMedi.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMedi = True
			End If
			Return _aplicMedi
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMedi'. These settings will be taken into account
		''' when the property AplicMedi is requested or GetMultiAplicMedi is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMedi(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMedi.SortClauses=sortClauses
			_aplicMedi.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabAplForEntity'</returns>
		Public Function GetMultiCabAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor(forceFetch, _cabAplFor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabAplForEntity'</returns>
		Public Function GetMultiCabAplFor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor(forceFetch, _cabAplFor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabAplForCollection
			If ( Not _alreadyFetchedCabAplFor Or forceFetch Or _alwaysFetchCabAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabAplFor)
					End If
				End If
				_cabAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabAplFor.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_cabAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedCabAplFor = True
			End If
			Return _cabAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabAplFor'. These settings will be taken into account
		''' when the property CabAplFor is requested or GetMultiCabAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabAplFor.SortClauses=sortClauses
			_cabAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_cabPrepForm.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabProMedEntity'</returns>
		Public Function GetMultiCabProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabProMedCollection
			Return GetMultiCabProMed(forceFetch, _cabProMed.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabProMedCollection
			Return GetMultiCabProMed(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabProMedEntity'</returns>
		Public Function GetMultiCabProMed(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabProMedCollection
			Return GetMultiCabProMed(forceFetch, _cabProMed.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabProMedCollection
			If ( Not _alreadyFetchedCabProMed Or forceFetch Or _alwaysFetchCabProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabProMed)
					End If
				End If
				_cabProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabProMed.GetMultiManyToOne(Me, Nothing, Filter)
				_cabProMed.SuppressClearInGetMulti = False
				_alreadyFetchedCabProMed = True
			End If
			Return _cabProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabProMed'. These settings will be taken into account
		''' when the property CabProMed is requested or GetMultiCabProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabProMed.SortClauses=sortClauses
			_cabProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_invHistorialPv.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen__(forceFetch, _almacen__.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAlmacen__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen__(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen__(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen__(forceFetch, _almacen__.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacen__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacen__ Or forceFetch Or _alwaysFetchAlmacen__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacen__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacen__)
					End If
				End If
				_almacen__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacen__.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacen__.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_almacen__.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacen__ = True
			End If
			Return _almacen__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Almacen__'. These settings will be taken into account
		''' when the property Almacen__ is requested or GetMultiAlmacen__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacen__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacen__.SortClauses=sortClauses
			_almacen__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_recepcionOrdenCompra.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
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
				_inventarioAlmacen.GetMultiManyToOne(Me, Nothing, Filter)
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
				_inventarioAlmacenLotes.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, _inventarioMovimientoAlmacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, _inventarioMovimientoAlmacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacen)
					End If
				End If
				_inventarioMovimientoAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacen.GetMultiManyToOne(Me, Nothing, Filter)
				_inventarioMovimientoAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacen = True
			End If
			Return _inventarioMovimientoAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacen'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacen is requested or GetMultiInventarioMovimientoAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacen.SortClauses=sortClauses
			_inventarioMovimientoAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenDetallesEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientoAlmacenDetalles(forceFetch, _inventarioMovimientoAlmacenDetalles.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientoAlmacenDetalles(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenDetallesEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Return GetMultiInventarioMovimientoAlmacenDetalles(forceFetch, _inventarioMovimientoAlmacenDetalles.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenDetalles Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenDetalles)
					End If
				End If
				_inventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenDetalles.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_inventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenDetalles = True
			End If
			Return _inventarioMovimientoAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenDetalles'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenDetalles is requested or GetMultiInventarioMovimientoAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenDetalles.SortClauses=sortClauses
			_inventarioMovimientoAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Return GetMultiMinvMovimientosAlmacenPv(forceFetch, _minvMovimientosAlmacenPv.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvMovimientosAlmacenPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Return GetMultiMinvMovimientosAlmacenPv(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPv(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Return GetMultiMinvMovimientosAlmacenPv(forceFetch, _minvMovimientosAlmacenPv.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvMovimientosAlmacenPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			If ( Not _alreadyFetchedMinvMovimientosAlmacenPv Or forceFetch Or _alwaysFetchMinvMovimientosAlmacenPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvMovimientosAlmacenPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvMovimientosAlmacenPv)
					End If
				End If
				_minvMovimientosAlmacenPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvMovimientosAlmacenPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvMovimientosAlmacenPv.GetMultiManyToOne(Nothing, Me, Filter)
				_minvMovimientosAlmacenPv.SuppressClearInGetMulti = False
				_alreadyFetchedMinvMovimientosAlmacenPv = True
			End If
			Return _minvMovimientosAlmacenPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvMovimientosAlmacenPv'. These settings will be taken into account
		''' when the property MinvMovimientosAlmacenPv is requested or GetMultiMinvMovimientosAlmacenPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvMovimientosAlmacenPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvMovimientosAlmacenPv.SortClauses=sortClauses
			_minvMovimientosAlmacenPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_minvMovimientosAlmacenPvdetalles.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, _minvTransferenciaAlmacenEntrada.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, _minvTransferenciaAlmacenEntrada.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntrada)
					End If
				End If
				_minvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntrada.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_minvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntrada = True
			End If
			Return _minvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntrada is requested or GetMultiMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch, _minvTransferenciaAlmacenEntrada_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch, _minvTransferenciaAlmacenEntrada_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntrada_)
					End If
				End If
				_minvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntrada_.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_minvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _minvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntrada_ is requested or GetMultiMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch, _minvTransferenciaAlmacenProdDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch, _minvTransferenciaAlmacenProdDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenProdDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenProdDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenProdDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenProdDetalle)
					End If
				End If
				_minvTransferenciaAlmacenProdDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenProdDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenProdDetalle.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_minvTransferenciaAlmacenProdDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = True
			End If
			Return _minvTransferenciaAlmacenProdDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenProdDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenProdDetalle is requested or GetMultiMinvTransferenciaAlmacenProdDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenProdDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenProdDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenProdDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida(forceFetch, _minvTransferenciaAlmacenSalida.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida(forceFetch, _minvTransferenciaAlmacenSalida.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalida(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalida Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalida.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalida)
					End If
				End If
				_minvTransferenciaAlmacenSalida.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalida.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalida.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_minvTransferenciaAlmacenSalida.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalida = True
			End If
			Return _minvTransferenciaAlmacenSalida
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalida'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalida is requested or GetMultiMinvTransferenciaAlmacenSalida is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalida(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalida.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalida.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida_(forceFetch, _minvTransferenciaAlmacenSalida_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalida_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalida_(forceFetch, _minvTransferenciaAlmacenSalida_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalida_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalida_ Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalida_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalida_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalida_)
					End If
				End If
				_minvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalida_.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalida_.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_minvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalida_ = True
			End If
			Return _minvTransferenciaAlmacenSalida_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalida_'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalida_ is requested or GetMultiMinvTransferenciaAlmacenSalida_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalida_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalida_.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalida_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscinventarioProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscinventarioProductoEntity'</returns>
		Public Function GetMultiMscinventarioProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
			Return GetMultiMscinventarioProducto(forceFetch, _mscinventarioProducto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscinventarioProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscinventarioProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
			Return GetMultiMscinventarioProducto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscinventarioProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscinventarioProductoEntity'</returns>
		Public Function GetMultiMscinventarioProducto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
			Return GetMultiMscinventarioProducto(forceFetch, _mscinventarioProducto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscinventarioProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscinventarioProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
			If ( Not _alreadyFetchedMscinventarioProducto Or forceFetch Or _alwaysFetchMscinventarioProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscinventarioProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscinventarioProducto)
					End If
				End If
				_mscinventarioProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscinventarioProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscinventarioProducto.GetMultiManyToOne(Me, Nothing, Filter)
				_mscinventarioProducto.SuppressClearInGetMulti = False
				_alreadyFetchedMscinventarioProducto = True
			End If
			Return _mscinventarioProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscinventarioProducto'. These settings will be taken into account
		''' when the property MscinventarioProducto is requested or GetMultiMscinventarioProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscinventarioProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscinventarioProducto.SortClauses=sortClauses
			_mscinventarioProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetComparacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetComparacionEntity'</returns>
		Public Function GetMultiMscloteCortesDetComparacion(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
			Return GetMultiMscloteCortesDetComparacion(forceFetch, _mscloteCortesDetComparacion.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetComparacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscloteCortesDetComparacion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
			Return GetMultiMscloteCortesDetComparacion(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetComparacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetComparacionEntity'</returns>
		Public Function GetMultiMscloteCortesDetComparacion(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
			Return GetMultiMscloteCortesDetComparacion(forceFetch, _mscloteCortesDetComparacion.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetComparacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscloteCortesDetComparacion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
			If ( Not _alreadyFetchedMscloteCortesDetComparacion Or forceFetch Or _alwaysFetchMscloteCortesDetComparacion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscloteCortesDetComparacion.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscloteCortesDetComparacion)
					End If
				End If
				_mscloteCortesDetComparacion.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscloteCortesDetComparacion.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscloteCortesDetComparacion.GetMultiManyToOne(Me, Nothing, Filter)
				_mscloteCortesDetComparacion.SuppressClearInGetMulti = False
				_alreadyFetchedMscloteCortesDetComparacion = True
			End If
			Return _mscloteCortesDetComparacion
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscloteCortesDetComparacion'. These settings will be taken into account
		''' when the property MscloteCortesDetComparacion is requested or GetMultiMscloteCortesDetComparacion is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscloteCortesDetComparacion(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscloteCortesDetComparacion.SortClauses=sortClauses
			_mscloteCortesDetComparacion.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, _mscmovtosAlmacenCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, _mscmovtosAlmacenCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCab)
					End If
				End If
				_mscmovtosAlmacenCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCab.GetMultiManyToOne(Me, Nothing, Filter)
				_mscmovtosAlmacenCab.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCab = True
			End If
			Return _mscmovtosAlmacenCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCab'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCab is requested or GetMultiMscmovtosAlmacenCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCab.SortClauses=sortClauses
			_mscmovtosAlmacenCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'AlmacenesSucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenesSucursalEntity'</returns>
		Public Function GetMultiAlmacenesSucursal(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
			Return GetMultiAlmacenesSucursal(forceFetch, _almacenesSucursal.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesSucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAlmacenesSucursal(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
			Return GetMultiAlmacenesSucursal(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesSucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenesSucursalEntity'</returns>
		Public Function GetMultiAlmacenesSucursal(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
			Return GetMultiAlmacenesSucursal(forceFetch, _almacenesSucursal.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenesSucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenesSucursal(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
			If ( Not _alreadyFetchedAlmacenesSucursal Or forceFetch Or _alwaysFetchAlmacenesSucursal) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenesSucursal.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenesSucursal)
					End If
				End If
				_almacenesSucursal.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenesSucursal.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenesSucursal.GetMultiManyToOne(Me, Filter)
				_almacenesSucursal.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenesSucursal = True
			End If
			Return _almacenesSucursal
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenesSucursal'. These settings will be taken into account
		''' when the property AlmacenesSucursal is requested or GetMultiAlmacenesSucursal is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenesSucursal(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenesSucursal.SortClauses=sortClauses
			_almacenesSucursal.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_usrAlmInvFisico.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, _registroSacrificiosDecomisos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, _registroSacrificiosDecomisos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisos Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _registroSacrificiosDecomisos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_registroSacrificiosDecomisos)
					End If
				End If
				_registroSacrificiosDecomisos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_registroSacrificiosDecomisos.EntityFactoryToUse = entityFactoryToUse
				End If
				_registroSacrificiosDecomisos.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_registroSacrificiosDecomisos.SuppressClearInGetMulti = False
				_alreadyFetchedRegistroSacrificiosDecomisos = True
			End If
			Return _registroSacrificiosDecomisos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RegistroSacrificiosDecomisos'. These settings will be taken into account
		''' when the property RegistroSacrificiosDecomisos is requested or GetMultiRegistroSacrificiosDecomisos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRegistroSacrificiosDecomisos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_registroSacrificiosDecomisos.SortClauses=sortClauses
			_registroSacrificiosDecomisos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'LineaEntity'</returns>
		Public Function GetMultiLineaCollectionViaAlmacenesFamilias(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.LineaCollection
			Return GetMultiLineaCollectionViaAlmacenesFamilias(forceFetch, _lineaCollectionViaAlmacenesFamilias.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiLineaCollectionViaAlmacenesFamilias(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.LineaCollection
			If ( Not _alreadyFetchedLineaCollectionViaAlmacenesFamilias Or forceFetch Or _alwaysFetchLineaCollectionViaAlmacenesFamilias) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _lineaCollectionViaAlmacenesFamilias.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_lineaCollectionViaAlmacenesFamilias)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, "__AlmacenEntity__", "AlmacenesFamilias_", JoinHint.None)
				relations.Add(AlmacenesFamiliasEntity.Relations.LineaEntityUsingCodigoLinea, "AlmacenesFamilias_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_lineaCollectionViaAlmacenesFamilias.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_lineaCollectionViaAlmacenesFamilias.EntityFactoryToUse = entityFactoryToUse
				End If
				_lineaCollectionViaAlmacenesFamilias.GetMulti(Filter, relations)
				_lineaCollectionViaAlmacenesFamilias.SuppressClearInGetMulti = False
				_alreadyFetchedLineaCollectionViaAlmacenesFamilias = True
			End If
			Return _lineaCollectionViaAlmacenesFamilias
		End Function

		''' <summary>Sets the collection parameters for the collection for 'LineaCollectionViaAlmacenesFamilias'. These settings will be taken into account
		''' when the property LineaCollectionViaAlmacenesFamilias is requested or GetMultiLineaCollectionViaAlmacenesFamilias is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersLineaCollectionViaAlmacenesFamilias(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_lineaCollectionViaAlmacenesFamilias.SortClauses=sortClauses
			_lineaCollectionViaAlmacenesFamilias.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi(forceFetch, _inventarioMovimientoAlmacenCollectionViaAplicMedi.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaAplicMedi.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaAplicMedi)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "__AlmacenEntity__", "AplicMedi_", JoinHint.None)
				relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "AplicMedi_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaAplicMedi.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaAplicMedi.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaAplicMedi.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaAplicMedi.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaAplicMedi
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaAplicMedi'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaAplicMedi is requested or GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaAplicMedi(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaAplicMedi.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaAplicMedi.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_(forceFetch, _inventarioMovimientoAlmacenCollectionViaAplicMedi_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaAplicMedi_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaAplicMedi_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "__AlmacenEntity__", "AplicMedi_", JoinHint.None)
				relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "AplicMedi_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaAplicMedi_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaAplicMedi_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaAplicMedi_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaAplicMedi_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaAplicMedi_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaAplicMedi_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaAplicMedi_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaAplicMedi_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaAplicMedi_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaAplicMedi_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "__AlmacenEntity__", "CabAplFor_", JoinHint.None)
				relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, "CabAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaCabAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabAplFor.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabAplFor'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabAplFor is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabAplFor.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabAplFor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabAplFor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabAplFor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "__AlmacenEntity__", "CabAplFor_", JoinHint.None)
				relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "CabAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaCabAplFor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabAplFor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabAplFor_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabAplFor_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabAplFor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabAplFor_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabAplFor_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabAplFor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabAplFor_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabAplFor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed(forceFetch, _inventarioMovimientoAlmacenCollectionViaCabProMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaCabProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaCabProMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, "__AlmacenEntity__", "CabProMed_", JoinHint.None)
				relations.Add(CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, "CabProMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaCabProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaCabProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaCabProMed.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaCabProMed.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaCabProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaCabProMed'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaCabProMed is requested or GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaCabProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaCabProMed.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaCabProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaInvHistorialPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaInvHistorialPv(forceFetch, _productoCollectionViaInvHistorialPv.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaInvHistorialPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaInvHistorialPv Or forceFetch Or _alwaysFetchProductoCollectionViaInvHistorialPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaInvHistorialPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaInvHistorialPv)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, "__AlmacenEntity__", "InvHistorialPv_", JoinHint.None)
				relations.Add(InvHistorialPvEntity.Relations.ProductoEntityUsingIdProducto, "InvHistorialPv_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViaInvHistorialPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaInvHistorialPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaInvHistorialPv.GetMulti(Filter, relations)
				_productoCollectionViaInvHistorialPv.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaInvHistorialPv = True
			End If
			Return _productoCollectionViaInvHistorialPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaInvHistorialPv'. These settings will be taken into account
		''' when the property ProductoCollectionViaInvHistorialPv is requested or GetMultiProductoCollectionViaInvHistorialPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaInvHistorialPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaInvHistorialPv.SortClauses=sortClauses
			_productoCollectionViaInvHistorialPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaAlmacen(forceFetch, _plazaCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaAlmacen Or forceFetch Or _alwaysFetchPlazaCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_plazaCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaAlmacen.GetMulti(Filter, relations)
				_plazaCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaAlmacen = True
			End If
			Return _plazaCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaAlmacen'. These settings will be taken into account
		''' when the property PlazaCollectionViaAlmacen is requested or GetMultiPlazaCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaAlmacen.SortClauses=sortClauses
			_plazaCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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
				relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "__AlmacenEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch, _ordenCompraCollectionViaRecepcionOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			If ( Not _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompraCollectionViaRecepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompraCollectionViaRecepcionOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "__AlmacenEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_ordenCompraCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompraCollectionViaRecepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompraCollectionViaRecepcionOrdenCompra.GetMulti(Filter, relations)
				_ordenCompraCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = True
			End If
			Return _ordenCompraCollectionViaRecepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompraCollectionViaRecepcionOrdenCompra'. These settings will be taken into account
		''' when the property OrdenCompraCollectionViaRecepcionOrdenCompra is requested or GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompraCollectionViaRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompraCollectionViaRecepcionOrdenCompra.SortClauses=sortClauses
			_ordenCompraCollectionViaRecepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaInventarioAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaInventarioAlmacen(forceFetch, _productoCollectionViaInventarioAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaInventarioAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaInventarioAlmacen Or forceFetch Or _alwaysFetchProductoCollectionViaInventarioAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaInventarioAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaInventarioAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, "__AlmacenEntity__", "InventarioAlmacen_", JoinHint.None)
				relations.Add(InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, "InventarioAlmacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViaInventarioAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaInventarioAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaInventarioAlmacen.GetMulti(Filter, relations)
				_productoCollectionViaInventarioAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaInventarioAlmacen = True
			End If
			Return _productoCollectionViaInventarioAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaInventarioAlmacen'. These settings will be taken into account
		''' when the property ProductoCollectionViaInventarioAlmacen is requested or GetMultiProductoCollectionViaInventarioAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaInventarioAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaInventarioAlmacen.SortClauses=sortClauses
			_productoCollectionViaInventarioAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch, _productoCollectionViainventarioAlmacenLotes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViainventarioAlmacenLotes Or forceFetch Or _alwaysFetchProductoCollectionViainventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViainventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViainventarioAlmacenLotes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "__AlmacenEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViainventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViainventarioAlmacenLotes.GetMulti(Filter, relations)
				_productoCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = True
			End If
			Return _productoCollectionViainventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViainventarioAlmacenLotes'. These settings will be taken into account
		''' when the property ProductoCollectionViainventarioAlmacenLotes is requested or GetMultiProductoCollectionViainventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViainventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViainventarioAlmacenLotes.SortClauses=sortClauses
			_productoCollectionViainventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "__AlmacenEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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

		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMovimientoAlmacenEntity'</returns>
		Public Function GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			Return GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch, _tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			If ( Not _alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, "__AlmacenEntity__", "InventarioMovimientoAlmacen_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, "InventarioMovimientoAlmacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.GetMulti(Filter, relations)
				_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = True
			End If
			Return _tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen'. These settings will be taken into account
		''' when the property TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen is requested or GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.SortClauses=sortClauses
			_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch, _productoCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles Or forceFetch Or _alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaInventarioMovimientoAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaInventarioMovimientoAlmacenDetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "__AlmacenEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaInventarioMovimientoAlmacenDetalles.GetMulti(Filter, relations)
				_productoCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles = True
			End If
			Return _productoCollectionViaInventarioMovimientoAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaInventarioMovimientoAlmacenDetalles'. These settings will be taken into account
		''' when the property ProductoCollectionViaInventarioMovimientoAlmacenDetalles is requested or GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaInventarioMovimientoAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaInventarioMovimientoAlmacenDetalles.SortClauses=sortClauses
			_productoCollectionViaInventarioMovimientoAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch, _inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "__AlmacenEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles is requested or GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatMovimientosAlmacenPvEntity'</returns>
		Public Function GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection
			Return GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(forceFetch, _catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection
			If ( Not _alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv Or forceFetch Or _alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, "__AlmacenEntity__", "MinvMovimientosAlmacenPv_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, "MinvMovimientosAlmacenPv_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.EntityFactoryToUse = entityFactoryToUse
				End If
				_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.GetMulti(Filter, relations)
				_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.SuppressClearInGetMulti = False
				_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = True
			End If
			Return _catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv'. These settings will be taken into account
		''' when the property CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv is requested or GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.SortClauses=sortClauses
			_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch, _productoCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMinvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMinvMovimientosAlmacenPvdetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "__AlmacenEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.GetMulti(Filter, relations)
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _productoCollectionViaMinvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is requested or GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "__AlmacenEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
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

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch, _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.GetMulti(Filter, relations)
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = True
			End If
			Return _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada is requested or GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch, _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.GetMulti(Filter, relations)
				_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ is requested or GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenProdEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection
			Return GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(forceFetch, _minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenProdDetalle_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenProdDetalleEntity.Relations.MinvTransferenciaAlmacenProdEntityUsingFolioTransferencia, "MinvTransferenciaAlmacenProdDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.GetMulti(Filter, relations)
				_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = True
			End If
			Return _minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle is requested or GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMovimientoAlmacenEntity'</returns>
		Public Function GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			Return GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch, _tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			If ( Not _alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, "__AlmacenEntity__", "MscmovtosAlmacenCab_", JoinHint.None)
				relations.Add(MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, "MscmovtosAlmacenCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.GetMulti(Filter, relations)
				_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = True
			End If
			Return _tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab'. These settings will be taken into account
		''' when the property TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab is requested or GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.SortClauses=sortClauses
			_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaUsrAlmInvFisico(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaUsrAlmInvFisico(forceFetch, _productoCollectionViaUsrAlmInvFisico.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaUsrAlmInvFisico(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaUsrAlmInvFisico Or forceFetch Or _alwaysFetchProductoCollectionViaUsrAlmInvFisico) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaUsrAlmInvFisico.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaUsrAlmInvFisico)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, "__AlmacenEntity__", "InventarioFisico_", JoinHint.None)
				relations.Add(InventarioFisicoEntity.Relations.ProductoEntityUsingProductoId, "InventarioFisico_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_productoCollectionViaUsrAlmInvFisico.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaUsrAlmInvFisico.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaUsrAlmInvFisico.GetMulti(Filter, relations)
				_productoCollectionViaUsrAlmInvFisico.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaUsrAlmInvFisico = True
			End If
			Return _productoCollectionViaUsrAlmInvFisico
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaUsrAlmInvFisico'. These settings will be taken into account
		''' when the property ProductoCollectionViaUsrAlmInvFisico is requested or GetMultiProductoCollectionViaUsrAlmInvFisico is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaUsrAlmInvFisico(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaUsrAlmInvFisico.SortClauses=sortClauses
			_productoCollectionViaUsrAlmInvFisico.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(forceFetch, _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "__AlmacenEntity__", "RegistroSacrificiosDecomisos_", JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos is requested or GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(forceFetch, _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "__AlmacenEntity__", "RegistroSacrificiosDecomisos_", JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ is requested or GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza_() As PlazaEntity
			Return GetSinglePlaza_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza_(forceFetch As Boolean) As PlazaEntity
			If ( Not _alreadyFetchedPlaza_ Or forceFetch Or _alwaysFetchPlaza_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PlazaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AlmacenEntity.Relations.PlazaEntityUsingPlaza) Then
					fetchResult = newEntity.FetchUsingPK(Me.Plaza)
				End If
				If Not _plaza_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Plaza_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PlazaEntity)
					End If
					Me.Plaza_ = newEntity
					_alreadyFetchedPlaza_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _plaza_
		End Function
	
		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen_() As AlmacenEntity
			Return GetSingleAlmacen_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen_(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacen_ Or forceFetch Or _alwaysFetchAlmacen_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AlmacenEntity.Relations.AlmacenEntityUsingAlmacenIdAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.Almacen.GetValueOrDefault())
				End If
				If Not _almacen_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Almacen_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.Almacen_ = newEntity
					_alreadyFetchedAlmacen_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacen_
		End Function
	
		''' <summary>Retrieves the related entity of type 'TipoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoAlmacen_() As TipoAlmacenEntity
			Return GetSingleTipoAlmacen_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoAlmacen_(forceFetch As Boolean) As TipoAlmacenEntity
			If ( Not _alreadyFetchedTipoAlmacen_ Or forceFetch Or _alwaysFetchTipoAlmacen_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoAlmacen.GetValueOrDefault())
				End If
				If Not _tipoAlmacen_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoAlmacen_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoAlmacenEntity)
					End If
					Me.TipoAlmacen_ = newEntity
					_alreadyFetchedTipoAlmacen_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoAlmacen_
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
				If MyBase.CheckIfLazyLoadingShouldOccur(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCuentaContable.GetValueOrDefault())
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
	
	
		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes() As MfacCatClientesEntity
			Return GetSingleMfacCatClientes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes(forceFetch As Boolean) As MfacCatClientesEntity
			If ( Not _alreadyFetchedMfacCatClientes Or forceFetch Or _alwaysFetchMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New MfacCatClientesEntity()
				Dim relation As IEntityRelation = AlmacenEntity.Relations.MfacCatClientesEntityUsingAlmacenId
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.AlmacenId)
				End If
				If Not _mfacCatClientesReturnsNewIfNotFound And Not fetchResult Then
					Me.MfacCatClientes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacCatClientesEntity)
					End If
					Me.MfacCatClientes = newEntity
					_alreadyFetchedMfacCatClientes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacCatClientes
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(AlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, AlmacenFieldIndex)
					Case AlmacenFieldIndex.AlmacenId
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False


					Case AlmacenFieldIndex.TipoAlmacen
						DesetupSyncTipoAlmacen_(True, False)
						_alreadyFetchedTipoAlmacen_ = False
					Case AlmacenFieldIndex.Almacen
						DesetupSyncAlmacen_(True, False)
						_alreadyFetchedAlmacen_ = False





					Case AlmacenFieldIndex.Plaza
						DesetupSyncPlaza_(True, False)
						_alreadyFetchedPlaza_ = False

					Case AlmacenFieldIndex.IdCuentaContable
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False



					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_almacenesFamilias.ActiveContext = MyBase.ActiveContext
			_aplicMedi.ActiveContext = MyBase.ActiveContext
			_cabAplFor.ActiveContext = MyBase.ActiveContext
			_cabPrepForm.ActiveContext = MyBase.ActiveContext
			_cabProMed.ActiveContext = MyBase.ActiveContext
			_invHistorialPv.ActiveContext = MyBase.ActiveContext
			_almacen__.ActiveContext = MyBase.ActiveContext
			_recepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacen.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_minvMovimientosAlmacenPv.ActiveContext = MyBase.ActiveContext
			_minvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenProdDetalle.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalida.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalida_.ActiveContext = MyBase.ActiveContext
			_mscinventarioProducto.ActiveContext = MyBase.ActiveContext
			_mscloteCortesDetComparacion.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			_almacenesSucursal.ActiveContext = MyBase.ActiveContext
			_usrAlmInvFisico.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_lineaCollectionViaAlmacenesFamilias.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaAplicMedi.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaAplicMedi_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabAplFor.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabAplFor_.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaCabProMed.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaInvHistorialPv.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_tipoAlmacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_motivoCancelacionCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_ordenCompraCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaInventarioAlmacen.ActiveContext = MyBase.ActiveContext
			_productoCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_inventarioAlmacenCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaInventarioMovimientoAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___.ActiveContext = MyBase.ActiveContext
			_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaUsrAlmInvFisico.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_.ActiveContext = MyBase.ActiveContext
		If Not _plaza_ Is Nothing Then
				_plaza_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _almacen_ Is Nothing Then
				_almacen_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoAlmacen_ Is Nothing Then
				_tipoAlmacen_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As AlmacenDAO = CType(CreateDAOInstance(), AlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As AlmacenDAO = CType(CreateDAOInstance(), AlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As AlmacenDAO = CType(CreateDAOInstance(), AlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this AlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="validator">The validator Object for this AlmacenEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(almacenId As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(almacenId, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_almacenesFamilias = New Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection(New AlmacenesFamiliasEntityFactory())
			_almacenesFamilias.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchAlmacenesFamilias = False
			_alreadyFetchedAlmacenesFamilias = False
			_aplicMedi = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_aplicMedi.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchAplicMedi = False
			_alreadyFetchedAplicMedi = False
			_cabAplFor = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_cabAplFor.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchCabAplFor = False
			_alreadyFetchedCabAplFor = False
			_cabPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchCabPrepForm = False
			_alreadyFetchedCabPrepForm = False
			_cabProMed = New Integralab.ORM.CollectionClasses.CabProMedCollection(New CabProMedEntityFactory())
			_cabProMed.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchCabProMed = False
			_alreadyFetchedCabProMed = False
			_invHistorialPv = New Integralab.ORM.CollectionClasses.InvHistorialPvCollection(New InvHistorialPvEntityFactory())
			_invHistorialPv.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchInvHistorialPv = False
			_alreadyFetchedInvHistorialPv = False
			_almacen__ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_almacen__.SetContainingEntityInfo(Me, "Almacen_")
			_alwaysFetchAlmacen__ = False
			_alreadyFetchedAlmacen__ = False
			_recepcionOrdenCompra = New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(New RecepcionOrdenCompraEntityFactory())
			_recepcionOrdenCompra.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchRecepcionOrdenCompra = False
			_alreadyFetchedRecepcionOrdenCompra = False
			_inventarioAlmacen = New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(New InventarioAlmacenEntityFactory())
			_inventarioAlmacen.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchInventarioAlmacen = False
			_alreadyFetchedInventarioAlmacen = False
			_inventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(New inventarioAlmacenLotesEntityFactory())
			_inventarioAlmacenLotes.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchInventarioAlmacenLotes = False
			_alreadyFetchedInventarioAlmacenLotes = False
			_inventarioMovimientoAlmacen = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_inventarioMovimientoAlmacen.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchInventarioMovimientoAlmacen = False
			_alreadyFetchedInventarioMovimientoAlmacen = False
			_inventarioMovimientoAlmacenDetalles = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(New InventarioMovimientoAlmacenDetallesEntityFactory())
			_inventarioMovimientoAlmacenDetalles.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchInventarioMovimientoAlmacenDetalles = False
			_alreadyFetchedInventarioMovimientoAlmacenDetalles = False
			_minvMovimientosAlmacenPv = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(New MinvMovimientosAlmacenPvEntityFactory())
			_minvMovimientosAlmacenPv.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMinvMovimientosAlmacenPv = False
			_alreadyFetchedMinvMovimientosAlmacenPv = False
			_minvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(New MinvMovimientosAlmacenPvdetallesEntityFactory())
			_minvMovimientosAlmacenPvdetalles.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = False
			_minvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_minvTransferenciaAlmacenEntrada.SetContainingEntityInfo(Me, "AlmacenDestino")
			_alwaysFetchMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = False
			_minvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_minvTransferenciaAlmacenEntrada_.SetContainingEntityInfo(Me, "AlmacenOrigen")
			_alwaysFetchMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = False
			_minvTransferenciaAlmacenProdDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection(New MinvTransferenciaAlmacenProdDetalleEntityFactory())
			_minvTransferenciaAlmacenProdDetalle.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMinvTransferenciaAlmacenProdDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = False
			_minvTransferenciaAlmacenSalida = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_minvTransferenciaAlmacenSalida.SetContainingEntityInfo(Me, "AlmacenDestino")
			_alwaysFetchMinvTransferenciaAlmacenSalida = False
			_alreadyFetchedMinvTransferenciaAlmacenSalida = False
			_minvTransferenciaAlmacenSalida_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_minvTransferenciaAlmacenSalida_.SetContainingEntityInfo(Me, "AlmacenOrigen")
			_alwaysFetchMinvTransferenciaAlmacenSalida_ = False
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = False
			_mscinventarioProducto = New Integralab.ORM.CollectionClasses.MscinventarioProductoCollection(New MscinventarioProductoEntityFactory())
			_mscinventarioProducto.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMscinventarioProducto = False
			_alreadyFetchedMscinventarioProducto = False
			_mscloteCortesDetComparacion = New Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection(New MscloteCortesDetComparacionEntityFactory())
			_mscloteCortesDetComparacion.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMscloteCortesDetComparacion = False
			_alreadyFetchedMscloteCortesDetComparacion = False
			_mscmovtosAlmacenCab = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_mscmovtosAlmacenCab.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchMscmovtosAlmacenCab = False
			_alreadyFetchedMscmovtosAlmacenCab = False
			_almacenesSucursal = New Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection(New AlmacenesSucursalEntityFactory())
			_almacenesSucursal.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchAlmacenesSucursal = False
			_alreadyFetchedAlmacenesSucursal = False
			_usrAlmInvFisico = New Integralab.ORM.CollectionClasses.InventarioFisicoCollection(New InventarioFisicoEntityFactory())
			_usrAlmInvFisico.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchUsrAlmInvFisico = False
			_alreadyFetchedUsrAlmInvFisico = False
			_registroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_registroSacrificiosDecomisos.SetContainingEntityInfo(Me, "Almacen")
			_alwaysFetchRegistroSacrificiosDecomisos = False
			_alreadyFetchedRegistroSacrificiosDecomisos = False
			_lineaCollectionViaAlmacenesFamilias = New Integralab.ORM.CollectionClasses.LineaCollection(New LineaEntityFactory())
			_alwaysFetchLineaCollectionViaAlmacenesFamilias = False
			_alreadyFetchedLineaCollectionViaAlmacenesFamilias = False
			_inventarioMovimientoAlmacenCollectionViaAplicMedi = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi = False
			_inventarioMovimientoAlmacenCollectionViaAplicMedi_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaAplicMedi_ = False
			_inventarioMovimientoAlmacenCollectionViaCabAplFor = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor = False
			_inventarioMovimientoAlmacenCollectionViaCabAplFor_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabAplFor_ = False
			_productoCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm = False
			_alreadyFetchedProductoCollectionViaCabPrepForm = False
			_productoCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm_ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = False
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
			_inventarioMovimientoAlmacenCollectionViaCabProMed = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaCabProMed = False
			_productoCollectionViaInvHistorialPv = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaInvHistorialPv = False
			_alreadyFetchedProductoCollectionViaInvHistorialPv = False
			_plazaCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaAlmacen = False
			_alreadyFetchedPlazaCollectionViaAlmacen = False
			_tipoAlmacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(New TipoAlmacenEntityFactory())
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = False
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = False
			_cuentaContableCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaAlmacen = False
			_alreadyFetchedCuentaContableCollectionViaAlmacen = False
			_motivoCancelacionCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(New MotivoCancelacionEntityFactory())
			_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = False
			_ordenCompraCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = False
			_productoCollectionViaInventarioAlmacen = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaInventarioAlmacen = False
			_alreadyFetchedProductoCollectionViaInventarioAlmacen = False
			_productoCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = False
			_inventarioAlmacenCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(New InventarioAlmacenEntityFactory())
			_alwaysFetchInventarioAlmacenCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedInventarioAlmacenCollectionViainventarioAlmacenLotes = False
			_tipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(New TipoMovimientoAlmacenEntityFactory())
			_alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = False
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = False
			_productoCollectionViaInventarioMovimientoAlmacenDetalles = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles = False
			_alreadyFetchedProductoCollectionViaInventarioMovimientoAlmacenDetalles = False
			_inventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_catMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = New Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection(New CatMovimientosAlmacenPvEntityFactory())
			_alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = False
			_alreadyFetchedCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = False
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_minvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(New MinvMovimientosAlmacenPvEntityFactory())
			_alwaysFetchMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = False
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_minvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection(New MinvTransferenciaAlmacenProdEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = False
			_tipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(New TipoMovimientoAlmacenEntityFactory())
			_alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = False
			_alreadyFetchedTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = False
			_productoCollectionViaUsrAlmInvFisico = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaUsrAlmInvFisico = False
			_alreadyFetchedProductoCollectionViaUsrAlmInvFisico = False
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = False
			_mscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = False
			_plaza_ = Nothing
			_plaza_ReturnsNewIfNotFound = True
			_alwaysFetchPlaza_ = False
			_alreadyFetchedPlaza_ = False
			_almacen_ = Nothing
			_almacen_ReturnsNewIfNotFound = True
			_alwaysFetchAlmacen_ = False
			_alreadyFetchedAlmacen_ = False
			_tipoAlmacen_ = Nothing
			_tipoAlmacen_ReturnsNewIfNotFound = True
			_alwaysFetchTipoAlmacen_ = False
			_alreadyFetchedTipoAlmacen_ = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Almacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Letra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCuentaContable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Tercero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _plaza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", AlmacenEntity.Relations.PlazaEntityUsingPlaza, True, signalRelatedEntity, "Almacen", resetFKFields, New Integer() { CInt(AlmacenFieldIndex.Plaza) } )
			_plaza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza_(relatedEntity As IEntity)
			DesetupSyncPlaza_(True, True)
			_plaza_ = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", AlmacenEntity.Relations.PlazaEntityUsingPlaza, True, _alreadyFetchedPlaza_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPlaza_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _almacen_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen_, AddressOf OnAlmacen_PropertyChanged, "Almacen_", AlmacenEntity.Relations.AlmacenEntityUsingAlmacenIdAlmacen, True, signalRelatedEntity, "Almacen__", resetFKFields, New Integer() { CInt(AlmacenFieldIndex.Almacen) } )
			_almacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen_(relatedEntity As IEntity)
			DesetupSyncAlmacen_(True, True)
			_almacen_ = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen_, AddressOf OnAlmacen_PropertyChanged, "Almacen_", AlmacenEntity.Relations.AlmacenEntityUsingAlmacenIdAlmacen, True, _alreadyFetchedAlmacen_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacen_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _tipoAlmacen_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoAlmacen_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoAlmacen_, AddressOf OnTipoAlmacen_PropertyChanged, "TipoAlmacen_", AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, True, signalRelatedEntity, "Almacen", resetFKFields, New Integer() { CInt(AlmacenFieldIndex.TipoAlmacen) } )
			_tipoAlmacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoAlmacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoAlmacen_(relatedEntity As IEntity)
			DesetupSyncTipoAlmacen_(True, True)
			_tipoAlmacen_ = CType(relatedEntity, TipoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoAlmacen_, AddressOf OnTipoAlmacen_PropertyChanged, "TipoAlmacen_", AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, True, _alreadyFetchedTipoAlmacen_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoAlmacen_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, signalRelatedEntity, "Almacen", resetFKFields, New Integer() { CInt(AlmacenFieldIndex.IdCuentaContable) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, _alreadyFetchedCuentaContable, New String() {  } )
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

		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", AlmacenEntity.Relations.MfacCatClientesEntityUsingAlmacenId, True, signalRelatedEntity, "Almacen", False, New Integer() { CInt(AlmacenFieldIndex.AlmacenId) } )
			_mfacCatClientes = Nothing
		End Sub

		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", AlmacenEntity.Relations.MfacCatClientesEntityUsingAlmacenId, True, _alreadyFetchedMfacCatClientes, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacCatClientesPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="almacenId">PK value for Almacen which data should be fetched into this Almacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(almacenId As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(AlmacenFieldIndex.AlmacenId)).ForcedCurrentValueWrite(almacenId)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New AlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As AlmacenRelations
			Get	
				Return New AlmacenRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AlmacenesFamilias' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenesFamilias() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection(), _
					AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenesFamiliasEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenesFamilias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMedi() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "CabAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabProMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabProMedCollection(), _
					AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), 0, Nothing, Nothing, Nothing, "CabProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InvHistorialPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInvHistorialPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InvHistorialPvCollection(), _
					AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InvHistorialPvEntity, Integer), 0, Nothing, Nothing, Nothing, "InvHistorialPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen__() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionOrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(), _
					AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(), _
					AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'inventarioAlmacenLotes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(), _
					AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.inventarioAlmacenLotesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacenDetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenDetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(), _
					AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenDetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(), _
					AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvMovimientosAlmacenPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPvdetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(), _
					AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenProdDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenProdDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenProdDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenProdDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalida_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalida_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscinventarioProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscinventarioProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscinventarioProductoCollection(), _
					AlmacenEntity.Relations.MscinventarioProductoEntityUsingIdCodAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscinventarioProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "MscinventarioProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesDetComparacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesDetComparacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection(), _
					AlmacenEntity.Relations.MscloteCortesDetComparacionEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesDetComparacionEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesDetComparacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AlmacenesSucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenesSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection(), _
					AlmacenEntity.Relations.AlmacenesSucursalEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenesSucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenesSucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioFisico' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrAlmInvFisico() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioFisicoCollection(), _
					AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioFisicoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrAlmInvFisico", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Linea' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathLineaCollectionViaAlmacenesFamilias() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenesFamiliasEntity.Relations.LineaEntityUsingCodigoLinea)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.LineaCollection(), _
					AlmacenEntity.Relations.AlmacenesFamiliasEntityUsingCodigoAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.LineaEntity, Integer), 0, Nothing, Nothing, relations, "LineaCollectionViaAlmacenesFamilias", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaAplicMedi() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaAplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaAplicMedi_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.AplicMediEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaAplicMedi_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabAplFor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabAplForEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabAplFor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaCabProMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.CabProMedEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaCabProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaInvHistorialPv() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InvHistorialPvEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.InvHistorialPvEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaInvHistorialPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(), _
					AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "TipoAlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoCancelacionCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(), _
					AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), 0, Nothing, Nothing, relations, "MotivoCancelacionCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					AlmacenEntity.Relations.RecepcionOrdenCompraEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, relations, "OrdenCompraCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaInventarioAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaInventarioAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacenCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.InventarioAlmacenEntityUsingAlmacenIdProductoIdAñoMes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection(), _
					AlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioAlmacenCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaInventarioMovimientoAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaInventarioMovimientoAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.InventarioMovimientoAlmacenEntityUsingAlmacenIdFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection(), _
					AlmacenEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CatMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, relations, "CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(), _
					AlmacenEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, relations, "MinvMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenProd' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenProdDetalleEntity.Relations.MinvTransferenciaAlmacenProdEntityUsingFolioTransferencia)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenProdEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(), _
					AlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaUsrAlmInvFisico() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioFisicoEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AlmacenEntity.Relations.InventarioFisicoEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaUsrAlmInvFisico", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, "__AlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					AlmacenEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdAlmacenProd, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					AlmacenEntity.Relations.PlazaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					AlmacenEntity.Relations.AlmacenEntityUsingAlmacenIdAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(), _
					AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoAlmacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					AlmacenEntity.Relations.MfacCatClientesEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "AlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return AlmacenEntity.CustomProperties
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
				Return AlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The AlmacenId property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."NombreCorto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoAlmacen property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."TipoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoAlmacen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.TipoAlmacen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.TipoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Almacen property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Almacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Almacen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Almacen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Almacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.FechaAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."UsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.UsuarioAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."UsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Plaza property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Plaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Plaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Plaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Plaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Letra property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."letra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Letra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Letra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Letra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCuentaContable property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."IdCuentaContable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCuentaContable]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.IdCuentaContable, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.IdCuentaContable, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoProducto property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."TipoProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoProducto]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.TipoProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.TipoProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Tercero property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."Tercero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Tercero]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.Tercero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.Tercero, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity Almacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatAlmacenes"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AlmacenFieldIndex.IdCliente, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AlmacenFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenesFamiliasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenesFamilias()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenesFamilias]() As Integralab.ORM.CollectionClasses.AlmacenesFamiliasCollection
			Get
				Return GetMultiAlmacenesFamilias(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenesFamilias. When set to true, AlmacenesFamilias is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenesFamilias is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenesFamilias(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenesFamilias As Boolean
			Get
				Return _alwaysFetchAlmacenesFamilias
			End Get
			Set
				_alwaysFetchAlmacenesFamilias = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMedi()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMedi]() As Integralab.ORM.CollectionClasses.AplicMediCollection
			Get
				Return GetMultiAplicMedi(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMedi. When set to true, AplicMedi is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMedi is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMedi(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMedi As Boolean
			Get
				Return _alwaysFetchAplicMedi
			End Get
			Set
				_alwaysFetchAplicMedi = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabAplFor]() As Integralab.ORM.CollectionClasses.CabAplForCollection
			Get
				Return GetMultiCabAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabAplFor. When set to true, CabAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabAplFor As Boolean
			Get
				Return _alwaysFetchCabAplFor
			End Get
			Set
				_alwaysFetchCabAplFor = value
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
	
		''' <summary>Retrieves all related entities of type 'CabProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabProMed]() As Integralab.ORM.CollectionClasses.CabProMedCollection
			Get
				Return GetMultiCabProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabProMed. When set to true, CabProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabProMed As Boolean
			Get
				Return _alwaysFetchCabProMed
			End Get
			Set
				_alwaysFetchCabProMed = value
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacen__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Almacen__]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacen__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen__. When set to true, Almacen__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacen__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen__ As Boolean
			Get
				Return _alwaysFetchAlmacen__
			End Get
			Set
				_alwaysFetchAlmacen__ = value
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
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacen]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen. When set to true, InventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenDetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenDetalles]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenDetalles. When set to true, InventarioMovimientoAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenDetalles
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvMovimientosAlmacenPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvMovimientosAlmacenPv]() As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection
			Get
				Return GetMultiMinvMovimientosAlmacenPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvMovimientosAlmacenPv. When set to true, MinvMovimientosAlmacenPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvMovimientosAlmacenPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvMovimientosAlmacenPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvMovimientosAlmacenPv As Boolean
			Get
				Return _alwaysFetchMinvMovimientosAlmacenPv
			End Get
			Set
				_alwaysFetchMinvMovimientosAlmacenPv = value
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
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntrada. When set to true, MinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntrada_. When set to true, MinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenProdDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenProdDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenProdDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenProdDetalle. When set to true, MinvTransferenciaAlmacenProdDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenProdDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenProdDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenProdDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenProdDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenProdDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalida]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalida(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalida. When set to true, MinvTransferenciaAlmacenSalida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalida is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalida As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalida
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalida = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalida_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalida_]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalida_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalida_. When set to true, MinvTransferenciaAlmacenSalida_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalida_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalida_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalida_ As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalida_
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalida_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscinventarioProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscinventarioProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscinventarioProducto]() As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
			Get
				Return GetMultiMscinventarioProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscinventarioProducto. When set to true, MscinventarioProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscinventarioProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscinventarioProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscinventarioProducto As Boolean
			Get
				Return _alwaysFetchMscinventarioProducto
			End Get
			Set
				_alwaysFetchMscinventarioProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetComparacionEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscloteCortesDetComparacion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscloteCortesDetComparacion]() As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
			Get
				Return GetMultiMscloteCortesDetComparacion(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscloteCortesDetComparacion. When set to true, MscloteCortesDetComparacion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscloteCortesDetComparacion is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscloteCortesDetComparacion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscloteCortesDetComparacion As Boolean
			Get
				Return _alwaysFetchMscloteCortesDetComparacion
			End Get
			Set
				_alwaysFetchMscloteCortesDetComparacion = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCab]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCab. When set to true, MscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenesSucursalEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenesSucursal()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenesSucursal]() As Integralab.ORM.CollectionClasses.AlmacenesSucursalCollection
			Get
				Return GetMultiAlmacenesSucursal(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenesSucursal. When set to true, AlmacenesSucursal is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenesSucursal is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenesSucursal(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenesSucursal As Boolean
			Get
				Return _alwaysFetchAlmacenesSucursal
			End Get
			Set
				_alwaysFetchAlmacenesSucursal = value
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
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRegistroSacrificiosDecomisos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RegistroSacrificiosDecomisos]() As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Get
				Return GetMultiRegistroSacrificiosDecomisos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisos. When set to true, RegistroSacrificiosDecomisos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisos is accessed. You can always execute
		''' a forced fetch by calling GetMultiRegistroSacrificiosDecomisos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisos As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisos
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisos = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLineaCollectionViaAlmacenesFamilias()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [LineaCollectionViaAlmacenesFamilias]() As Integralab.ORM.CollectionClasses.LineaCollection
			Get
				Return GetMultiLineaCollectionViaAlmacenesFamilias(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for LineaCollectionViaAlmacenesFamilias. When set to true, LineaCollectionViaAlmacenesFamilias is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time LineaCollectionViaAlmacenesFamilias is accessed. You can always execute
		''' a forced fetch by calling GetMultiLineaCollectionViaAlmacenesFamilias(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchLineaCollectionViaAlmacenesFamilias As Boolean
			Get
				Return _alwaysFetchLineaCollectionViaAlmacenesFamilias
			End Get
			Set
				_alwaysFetchLineaCollectionViaAlmacenesFamilias = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaAplicMedi]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaAplicMedi. When set to true, InventarioMovimientoAlmacenCollectionViaAplicMedi is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaAplicMedi is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaAplicMedi_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaAplicMedi_. When set to true, InventarioMovimientoAlmacenCollectionViaAplicMedi_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaAplicMedi_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaAplicMedi_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaAplicMedi_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabAplFor]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabAplFor. When set to true, InventarioMovimientoAlmacenCollectionViaCabAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabAplFor_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabAplFor_. When set to true, InventarioMovimientoAlmacenCollectionViaCabAplFor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabAplFor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabAplFor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabAplFor_ = value
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
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaCabProMed]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaCabProMed. When set to true, InventarioMovimientoAlmacenCollectionViaCabProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaCabProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaCabProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaCabProMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaInvHistorialPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaInvHistorialPv]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaInvHistorialPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaInvHistorialPv. When set to true, ProductoCollectionViaInvHistorialPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaInvHistorialPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaInvHistorialPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaInvHistorialPv As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaInvHistorialPv
			End Get
			Set
				_alwaysFetchProductoCollectionViaInvHistorialPv = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaAlmacen. When set to true, PlazaCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchPlazaCollectionViaAlmacen = value
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
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompraCollectionViaRecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Get
				Return GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompraCollectionViaRecepcionOrdenCompra. When set to true, OrdenCompraCollectionViaRecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompraCollectionViaRecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaInventarioAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaInventarioAlmacen]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaInventarioAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaInventarioAlmacen. When set to true, ProductoCollectionViaInventarioAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaInventarioAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaInventarioAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaInventarioAlmacen As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaInventarioAlmacen
			End Get
			Set
				_alwaysFetchProductoCollectionViaInventarioAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViainventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViainventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViainventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViainventarioAlmacenLotes. When set to true, ProductoCollectionViainventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViainventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViainventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViainventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchProductoCollectionViainventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchProductoCollectionViainventarioAlmacenLotes = value
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
	
		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen]() As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			Get
				Return GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen. When set to true, TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchTipoMovimientoAlmacenCollectionViaInventarioMovimientoAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaInventarioMovimientoAlmacenDetalles]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaInventarioMovimientoAlmacenDetalles. When set to true, ProductoCollectionViaInventarioMovimientoAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaInventarioMovimientoAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaInventarioMovimientoAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles
			End Get
			Set
				_alwaysFetchProductoCollectionViaInventarioMovimientoAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles. When set to true, InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatMovimientosAlmacenPvEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv]() As Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection
			Get
				Return GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv. When set to true, CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv As Boolean
			Get
				Return _alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv
			End Get
			Set
				_alwaysFetchCatMovimientosAlmacenPvCollectionViaMinvMovimientosAlmacenPv = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMinvMovimientosAlmacenPvdetalles. When set to true, ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = value
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
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada. When set to true, MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_. When set to true, MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenProdEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle. When set to true, MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenProdCollectionViaMinvTransferenciaAlmacenProdDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab]() As Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection
			Get
				Return GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab. When set to true, TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchTipoMovimientoAlmacenCollectionViaMscmovtosAlmacenCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaUsrAlmInvFisico()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaUsrAlmInvFisico]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaUsrAlmInvFisico(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaUsrAlmInvFisico. When set to true, ProductoCollectionViaUsrAlmInvFisico is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaUsrAlmInvFisico is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaUsrAlmInvFisico(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaUsrAlmInvFisico As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaUsrAlmInvFisico
			End Get
			Set
				_alwaysFetchProductoCollectionViaUsrAlmInvFisico = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos. When set to true, MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_. When set to true, MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaRegistroSacrificiosDecomisos_ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'PlazaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePlaza_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Plaza_]() As PlazaEntity
			Get
				Return GetSinglePlaza_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPlaza_(value)
				Else
					If value Is Nothing Then
						If Not _plaza_ Is Nothing Then
							_plaza_.UnsetRelatedEntity(Me, "Almacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Almacen")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Plaza_. When set to true, Plaza_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Plaza_ is accessed. You can always execute
		''' a forced fetch by calling GetSinglePlaza_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlaza_ As Boolean
			Get
				Return _alwaysFetchPlaza_
			End Get
			Set
				_alwaysFetchPlaza_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Plaza_ is not found
		''' in the database. When set to true, Plaza_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Plaza_ReturnsNewIfNotFound As Boolean
			Get
				Return _plaza_ReturnsNewIfNotFound
			End Get
			Set
				_plaza_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacen_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Almacen_]() As AlmacenEntity
			Get
				Return GetSingleAlmacen_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacen_(value)
				Else
					If value Is Nothing Then
						If Not _almacen_ Is Nothing Then
							_almacen_.UnsetRelatedEntity(Me, "Almacen__")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Almacen__")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen_. When set to true, Almacen_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacen_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen_ As Boolean
			Get
				Return _alwaysFetchAlmacen_
			End Get
			Set
				_alwaysFetchAlmacen_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Almacen_ is not found
		''' in the database. When set to true, Almacen_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Almacen_ReturnsNewIfNotFound As Boolean
			Get
				Return _almacen_ReturnsNewIfNotFound
			End Get
			Set
				_almacen_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'TipoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoAlmacen_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoAlmacen_]() As TipoAlmacenEntity
			Get
				Return GetSingleTipoAlmacen_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoAlmacen_(value)
				Else
					If value Is Nothing Then
						If Not _tipoAlmacen_ Is Nothing Then
							_tipoAlmacen_.UnsetRelatedEntity(Me, "Almacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Almacen")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoAlmacen_. When set to true, TipoAlmacen_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoAlmacen_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoAlmacen_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoAlmacen_ As Boolean
			Get
				Return _alwaysFetchTipoAlmacen_
			End Get
			Set
				_alwaysFetchTipoAlmacen_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoAlmacen_ is not found
		''' in the database. When set to true, TipoAlmacen_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoAlmacen_ReturnsNewIfNotFound As Boolean
			Get
				Return _tipoAlmacen_ReturnsNewIfNotFound
			End Get
			Set
				_tipoAlmacen_ReturnsNewIfNotFound = value
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
							_cuentaContable.UnsetRelatedEntity(Me, "Almacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Almacen")
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
	
	
		''' <summary>Gets / Sets related entity of type 'MfacCatClientesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacCatClientes]() As MfacCatClientesEntity
			Get
				Return GetSingleMfacCatClientes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacCatClientes(value)
				Else
					If value Is Nothing Then
						DesetupSyncMfacCatClientes(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "Almacen")
						SetupSyncMfacCatClientes(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacCatClientes. When set to true, MfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacCatClientes As Boolean
			Get
				Return _alwaysFetchMfacCatClientes
			End Get
			Set
				_alwaysFetchMfacCatClientes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacCatClientes is not found
		''' in the database. When set to true, MfacCatClientes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacCatClientesReturnsNewIfNotFound As Boolean
			Get
				Return _mfacCatClientesReturnsNewIfNotFound
			End Get
			Set
				_mfacCatClientesReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.AlmacenEntity)
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
