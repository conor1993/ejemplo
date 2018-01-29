' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 10:43:41
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
	''' <summary>Entity class which represents the entity 'InventarioMovimientoAlmacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class InventarioMovimientoAlmacenEntity 
#Else
	<Serializable()> _
	Public Class InventarioMovimientoAlmacenEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMedi As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMedi, _alreadyFetchedAplicMedi As Boolean
		Private _aplicMedi_ As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMedi_, _alreadyFetchedAplicMedi_ As Boolean
		Private _cabAplFor As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplFor, _alreadyFetchedCabAplFor As Boolean
		Private _cabAplFor_ As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplFor_, _alreadyFetchedCabAplFor_ As Boolean
		Private _cabPrepForm As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm, _alreadyFetchedCabPrepForm As Boolean
		Private _cabPrepForm_ As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm_, _alreadyFetchedCabPrepForm_ As Boolean
		Private _cabPrepForm__ As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm__, _alreadyFetchedCabPrepForm__ As Boolean
		Private _cabPrepForm___ As Integralab.ORM.CollectionClasses.CabPrepFormCollection
		Private _alwaysFetchCabPrepForm___, _alreadyFetchedCabPrepForm___ As Boolean
		Private _cabProMed As Integralab.ORM.CollectionClasses.CabProMedCollection
		Private _alwaysFetchCabProMed, _alreadyFetchedCabProMed As Boolean
		Private _inventarioMovimientosAlmacenDetalles As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection
		Private _alwaysFetchInventarioMovimientosAlmacenDetalles, _alreadyFetchedInventarioMovimientosAlmacenDetalles As Boolean
		Private _minvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntrada, _alreadyFetchedMinvTransferenciaAlmacenEntrada As Boolean
		Private _minvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntrada_, _alreadyFetchedMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _minvTransferenciaAlmacenSalida As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalida, _alreadyFetchedMinvTransferenciaAlmacenSalida As Boolean
		Private _minvTransferenciaAlmacenSalida_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalida_, _alreadyFetchedMinvTransferenciaAlmacenSalida_ As Boolean
		Private _almacenCollectionViaAplicMedi As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaAplicMedi, _alreadyFetchedAlmacenCollectionViaAplicMedi As Boolean
		Private _almacenCollectionViaAplicMedi_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaAplicMedi_, _alreadyFetchedAlmacenCollectionViaAplicMedi_ As Boolean
		Private _almacenCollectionViaCabAplFor As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabAplFor, _alreadyFetchedAlmacenCollectionViaCabAplFor As Boolean
		Private _almacenCollectionViaCabAplFor_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabAplFor_, _alreadyFetchedAlmacenCollectionViaCabAplFor_ As Boolean
		Private _almacenCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm, _alreadyFetchedAlmacenCollectionViaCabPrepForm As Boolean
		Private _almacenCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm_, _alreadyFetchedAlmacenCollectionViaCabPrepForm_ As Boolean
		Private _almacenCollectionViaCabPrepForm__ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm__, _alreadyFetchedAlmacenCollectionViaCabPrepForm__ As Boolean
		Private _almacenCollectionViaCabPrepForm___ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabPrepForm___, _alreadyFetchedAlmacenCollectionViaCabPrepForm___ As Boolean
		Private _productoCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm, _alreadyFetchedProductoCollectionViaCabPrepForm As Boolean
		Private _productoCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm_, _alreadyFetchedProductoCollectionViaCabPrepForm_ As Boolean
		Private _productoCollectionViaCabPrepForm__ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm__, _alreadyFetchedProductoCollectionViaCabPrepForm__ As Boolean
		Private _productoCollectionViaCabPrepForm___ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm___, _alreadyFetchedProductoCollectionViaCabPrepForm___ As Boolean
		Private _productoCollectionViaCabPrepForm____ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm____, _alreadyFetchedProductoCollectionViaCabPrepForm____ As Boolean
		Private _productoCollectionViaCabPrepForm_____ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm_____, _alreadyFetchedProductoCollectionViaCabPrepForm_____ As Boolean
		Private _productoCollectionViaCabPrepForm______ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm______, _alreadyFetchedProductoCollectionViaCabPrepForm______ As Boolean
		Private _productoCollectionViaCabPrepForm_______ As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaCabPrepForm_______, _alreadyFetchedProductoCollectionViaCabPrepForm_______ As Boolean
		Private _plazaCollectionViaCabPrepForm As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm, _alreadyFetchedPlazaCollectionViaCabPrepForm As Boolean
		Private _plazaCollectionViaCabPrepForm_ As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm_, _alreadyFetchedPlazaCollectionViaCabPrepForm_ As Boolean
		Private _plazaCollectionViaCabPrepForm__ As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm__, _alreadyFetchedPlazaCollectionViaCabPrepForm__ As Boolean
		Private _plazaCollectionViaCabPrepForm___ As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCabPrepForm___, _alreadyFetchedPlazaCollectionViaCabPrepForm___ As Boolean
		Private _almacenCollectionViaCabProMed As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaCabProMed, _alreadyFetchedAlmacenCollectionViaCabProMed As Boolean
		Private _almacenCollectionViaInventarioMovimientoAlmacenDetalles As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles, _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles As Boolean
		Private _productoCollectionViainventarioMovimientosAlmacenDetalles As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles, _alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Boolean
		Private _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenSalida As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenSalida_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenSalida__ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenSalida___ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _tipoMovimientoAlmacen As TipoMovimientoAlmacenEntity
		Private _alwaysFetchTipoMovimientoAlmacen, _alreadyFetchedTipoMovimientoAlmacen, _tipoMovimientoAlmacenReturnsNewIfNotFound As Boolean


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
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String)

			InitClassFetch(almacenId, folioMovimiento, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(almacenId, folioMovimiento, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="validator">The custom validator Object for this InventarioMovimientoAlmacenEntity</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String, validator As IValidator)

			InitClassFetch(almacenId, folioMovimiento, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_aplicMedi = CType(info.GetValue("_aplicMedi", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMedi = info.GetBoolean("_alwaysFetchAplicMedi")
			_alreadyFetchedAplicMedi = info.GetBoolean("_alreadyFetchedAplicMedi")
			_aplicMedi_ = CType(info.GetValue("_aplicMedi_", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMedi_ = info.GetBoolean("_alwaysFetchAplicMedi_")
			_alreadyFetchedAplicMedi_ = info.GetBoolean("_alreadyFetchedAplicMedi_")
			_cabAplFor = CType(info.GetValue("_cabAplFor", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplFor = info.GetBoolean("_alwaysFetchCabAplFor")
			_alreadyFetchedCabAplFor = info.GetBoolean("_alreadyFetchedCabAplFor")
			_cabAplFor_ = CType(info.GetValue("_cabAplFor_", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplFor_ = info.GetBoolean("_alwaysFetchCabAplFor_")
			_alreadyFetchedCabAplFor_ = info.GetBoolean("_alreadyFetchedCabAplFor_")
			_cabPrepForm = CType(info.GetValue("_cabPrepForm", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm = info.GetBoolean("_alwaysFetchCabPrepForm")
			_alreadyFetchedCabPrepForm = info.GetBoolean("_alreadyFetchedCabPrepForm")
			_cabPrepForm_ = CType(info.GetValue("_cabPrepForm_", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm_ = info.GetBoolean("_alwaysFetchCabPrepForm_")
			_alreadyFetchedCabPrepForm_ = info.GetBoolean("_alreadyFetchedCabPrepForm_")
			_cabPrepForm__ = CType(info.GetValue("_cabPrepForm__", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm__ = info.GetBoolean("_alwaysFetchCabPrepForm__")
			_alreadyFetchedCabPrepForm__ = info.GetBoolean("_alreadyFetchedCabPrepForm__")
			_cabPrepForm___ = CType(info.GetValue("_cabPrepForm___", GetType(Integralab.ORM.CollectionClasses.CabPrepFormCollection)), Integralab.ORM.CollectionClasses.CabPrepFormCollection)
			_alwaysFetchCabPrepForm___ = info.GetBoolean("_alwaysFetchCabPrepForm___")
			_alreadyFetchedCabPrepForm___ = info.GetBoolean("_alreadyFetchedCabPrepForm___")
			_cabProMed = CType(info.GetValue("_cabProMed", GetType(Integralab.ORM.CollectionClasses.CabProMedCollection)), Integralab.ORM.CollectionClasses.CabProMedCollection)
			_alwaysFetchCabProMed = info.GetBoolean("_alwaysFetchCabProMed")
			_alreadyFetchedCabProMed = info.GetBoolean("_alreadyFetchedCabProMed")
			_inventarioMovimientosAlmacenDetalles = CType(info.GetValue("_inventarioMovimientosAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection)
			_alwaysFetchInventarioMovimientosAlmacenDetalles = info.GetBoolean("_alwaysFetchInventarioMovimientosAlmacenDetalles")
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = info.GetBoolean("_alreadyFetchedInventarioMovimientosAlmacenDetalles")
			_minvTransferenciaAlmacenEntrada = CType(info.GetValue("_minvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntrada")
			_minvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_minvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntrada_")
			_minvTransferenciaAlmacenSalida = CType(info.GetValue("_minvTransferenciaAlmacenSalida", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalida = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalida")
			_alreadyFetchedMinvTransferenciaAlmacenSalida = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalida")
			_minvTransferenciaAlmacenSalida_ = CType(info.GetValue("_minvTransferenciaAlmacenSalida_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalida_")
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalida_")
			_almacenCollectionViaAplicMedi = CType(info.GetValue("_almacenCollectionViaAplicMedi", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaAplicMedi = info.GetBoolean("_alwaysFetchAlmacenCollectionViaAplicMedi")
			_alreadyFetchedAlmacenCollectionViaAplicMedi = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaAplicMedi")
			_almacenCollectionViaAplicMedi_ = CType(info.GetValue("_almacenCollectionViaAplicMedi_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaAplicMedi_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaAplicMedi_")
			_alreadyFetchedAlmacenCollectionViaAplicMedi_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaAplicMedi_")
			_almacenCollectionViaCabAplFor = CType(info.GetValue("_almacenCollectionViaCabAplFor", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabAplFor = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabAplFor")
			_alreadyFetchedAlmacenCollectionViaCabAplFor = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabAplFor")
			_almacenCollectionViaCabAplFor_ = CType(info.GetValue("_almacenCollectionViaCabAplFor_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabAplFor_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabAplFor_")
			_alreadyFetchedAlmacenCollectionViaCabAplFor_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabAplFor_")
			_almacenCollectionViaCabPrepForm = CType(info.GetValue("_almacenCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm")
			_almacenCollectionViaCabPrepForm_ = CType(info.GetValue("_almacenCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm_")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm_")
			_almacenCollectionViaCabPrepForm__ = CType(info.GetValue("_almacenCollectionViaCabPrepForm__", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm__ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm__")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm__ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm__")
			_almacenCollectionViaCabPrepForm___ = CType(info.GetValue("_almacenCollectionViaCabPrepForm___", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabPrepForm___ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabPrepForm___")
			_alreadyFetchedAlmacenCollectionViaCabPrepForm___ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabPrepForm___")
			_productoCollectionViaCabPrepForm = CType(info.GetValue("_productoCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm")
			_alreadyFetchedProductoCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm")
			_productoCollectionViaCabPrepForm_ = CType(info.GetValue("_productoCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm_")
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm_")
			_productoCollectionViaCabPrepForm__ = CType(info.GetValue("_productoCollectionViaCabPrepForm__", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm__ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm__")
			_alreadyFetchedProductoCollectionViaCabPrepForm__ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm__")
			_productoCollectionViaCabPrepForm___ = CType(info.GetValue("_productoCollectionViaCabPrepForm___", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm___ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm___")
			_alreadyFetchedProductoCollectionViaCabPrepForm___ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm___")
			_productoCollectionViaCabPrepForm____ = CType(info.GetValue("_productoCollectionViaCabPrepForm____", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm____ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm____")
			_alreadyFetchedProductoCollectionViaCabPrepForm____ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm____")
			_productoCollectionViaCabPrepForm_____ = CType(info.GetValue("_productoCollectionViaCabPrepForm_____", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm_____ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm_____")
			_alreadyFetchedProductoCollectionViaCabPrepForm_____ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm_____")
			_productoCollectionViaCabPrepForm______ = CType(info.GetValue("_productoCollectionViaCabPrepForm______", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm______ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm______")
			_alreadyFetchedProductoCollectionViaCabPrepForm______ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm______")
			_productoCollectionViaCabPrepForm_______ = CType(info.GetValue("_productoCollectionViaCabPrepForm_______", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaCabPrepForm_______ = info.GetBoolean("_alwaysFetchProductoCollectionViaCabPrepForm_______")
			_alreadyFetchedProductoCollectionViaCabPrepForm_______ = info.GetBoolean("_alreadyFetchedProductoCollectionViaCabPrepForm_______")
			_plazaCollectionViaCabPrepForm = CType(info.GetValue("_plazaCollectionViaCabPrepForm", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm")
			_alreadyFetchedPlazaCollectionViaCabPrepForm = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm")
			_plazaCollectionViaCabPrepForm_ = CType(info.GetValue("_plazaCollectionViaCabPrepForm_", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm_ = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm_")
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm_")
			_plazaCollectionViaCabPrepForm__ = CType(info.GetValue("_plazaCollectionViaCabPrepForm__", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm__ = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm__")
			_alreadyFetchedPlazaCollectionViaCabPrepForm__ = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm__")
			_plazaCollectionViaCabPrepForm___ = CType(info.GetValue("_plazaCollectionViaCabPrepForm___", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCabPrepForm___ = info.GetBoolean("_alwaysFetchPlazaCollectionViaCabPrepForm___")
			_alreadyFetchedPlazaCollectionViaCabPrepForm___ = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCabPrepForm___")
			_almacenCollectionViaCabProMed = CType(info.GetValue("_almacenCollectionViaCabProMed", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaCabProMed = info.GetBoolean("_alwaysFetchAlmacenCollectionViaCabProMed")
			_alreadyFetchedAlmacenCollectionViaCabProMed = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaCabProMed")
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles = CType(info.GetValue("_almacenCollectionViaInventarioMovimientoAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles")
			_productoCollectionViainventarioMovimientosAlmacenDetalles = CType(info.GetValue("_productoCollectionViainventarioMovimientosAlmacenDetalles", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles = info.GetBoolean("_alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles")
			_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles = info.GetBoolean("_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada__ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada__", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada___ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada___", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___")
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada")
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_")
			_almacenCollectionViaMinvTransferenciaAlmacenSalida = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida")
			_almacenCollectionViaMinvTransferenciaAlmacenSalida_ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_")
			_almacenCollectionViaMinvTransferenciaAlmacenSalida__ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida__", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__")
			_almacenCollectionViaMinvTransferenciaAlmacenSalida___ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida___", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_tipoMovimientoAlmacen = CType(info.GetValue("_tipoMovimientoAlmacen", GetType(TipoMovimientoAlmacenEntity)), TipoMovimientoAlmacenEntity)
			If Not _tipoMovimientoAlmacen Is Nothing Then
				AddHandler _tipoMovimientoAlmacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoMovimientoAlmacenReturnsNewIfNotFound = info.GetBoolean("_tipoMovimientoAlmacenReturnsNewIfNotFound")
			_alwaysFetchTipoMovimientoAlmacen = info.GetBoolean("_alwaysFetchTipoMovimientoAlmacen")
			_alreadyFetchedTipoMovimientoAlmacen = info.GetBoolean("_alreadyFetchedTipoMovimientoAlmacen")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMedi = (_aplicMedi.Count > 0)
			_alreadyFetchedAplicMedi_ = (_aplicMedi_.Count > 0)
			_alreadyFetchedCabAplFor = (_cabAplFor.Count > 0)
			_alreadyFetchedCabAplFor_ = (_cabAplFor_.Count > 0)
			_alreadyFetchedCabPrepForm = (_cabPrepForm.Count > 0)
			_alreadyFetchedCabPrepForm_ = (_cabPrepForm_.Count > 0)
			_alreadyFetchedCabPrepForm__ = (_cabPrepForm__.Count > 0)
			_alreadyFetchedCabPrepForm___ = (_cabPrepForm___.Count > 0)
			_alreadyFetchedCabProMed = (_cabProMed.Count > 0)
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = (_inventarioMovimientosAlmacenDetalles.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = (_minvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = (_minvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalida = (_minvTransferenciaAlmacenSalida.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = (_minvTransferenciaAlmacenSalida_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaAplicMedi = (_almacenCollectionViaAplicMedi.Count > 0)
			_alreadyFetchedAlmacenCollectionViaAplicMedi_ = (_almacenCollectionViaAplicMedi_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabAplFor = (_almacenCollectionViaCabAplFor.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabAplFor_ = (_almacenCollectionViaCabAplFor_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = (_almacenCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = (_almacenCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm__ = (_almacenCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabPrepForm___ = (_almacenCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm = (_productoCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = (_productoCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm__ = (_productoCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm___ = (_productoCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm____ = (_productoCollectionViaCabPrepForm____.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm_____ = (_productoCollectionViaCabPrepForm_____.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm______ = (_productoCollectionViaCabPrepForm______.Count > 0)
			_alreadyFetchedProductoCollectionViaCabPrepForm_______ = (_productoCollectionViaCabPrepForm_______.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm = (_plazaCollectionViaCabPrepForm.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = (_plazaCollectionViaCabPrepForm_.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm__ = (_plazaCollectionViaCabPrepForm__.Count > 0)
			_alreadyFetchedPlazaCollectionViaCabPrepForm___ = (_plazaCollectionViaCabPrepForm___.Count > 0)
			_alreadyFetchedAlmacenCollectionViaCabProMed = (_almacenCollectionViaCabProMed.Count > 0)
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = (_almacenCollectionViaInventarioMovimientoAlmacenDetalles.Count > 0)
			_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles = (_productoCollectionViainventarioMovimientosAlmacenDetalles.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = (_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = (_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida = (_almacenCollectionViaMinvTransferenciaAlmacenSalida.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = (_almacenCollectionViaMinvTransferenciaAlmacenSalida_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = (_almacenCollectionViaMinvTransferenciaAlmacenSalida__.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = (_almacenCollectionViaMinvTransferenciaAlmacenSalida___.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedTipoMovimientoAlmacen = Not(_tipoMovimientoAlmacen Is Nothing)

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
			info.AddValue("_aplicMedi", _aplicMedi)
			info.AddValue("_alwaysFetchAplicMedi", _alwaysFetchAplicMedi)
			info.AddValue("_alreadyFetchedAplicMedi", _alreadyFetchedAplicMedi)
			info.AddValue("_aplicMedi_", _aplicMedi_)
			info.AddValue("_alwaysFetchAplicMedi_", _alwaysFetchAplicMedi_)
			info.AddValue("_alreadyFetchedAplicMedi_", _alreadyFetchedAplicMedi_)
			info.AddValue("_cabAplFor", _cabAplFor)
			info.AddValue("_alwaysFetchCabAplFor", _alwaysFetchCabAplFor)
			info.AddValue("_alreadyFetchedCabAplFor", _alreadyFetchedCabAplFor)
			info.AddValue("_cabAplFor_", _cabAplFor_)
			info.AddValue("_alwaysFetchCabAplFor_", _alwaysFetchCabAplFor_)
			info.AddValue("_alreadyFetchedCabAplFor_", _alreadyFetchedCabAplFor_)
			info.AddValue("_cabPrepForm", _cabPrepForm)
			info.AddValue("_alwaysFetchCabPrepForm", _alwaysFetchCabPrepForm)
			info.AddValue("_alreadyFetchedCabPrepForm", _alreadyFetchedCabPrepForm)
			info.AddValue("_cabPrepForm_", _cabPrepForm_)
			info.AddValue("_alwaysFetchCabPrepForm_", _alwaysFetchCabPrepForm_)
			info.AddValue("_alreadyFetchedCabPrepForm_", _alreadyFetchedCabPrepForm_)
			info.AddValue("_cabPrepForm__", _cabPrepForm__)
			info.AddValue("_alwaysFetchCabPrepForm__", _alwaysFetchCabPrepForm__)
			info.AddValue("_alreadyFetchedCabPrepForm__", _alreadyFetchedCabPrepForm__)
			info.AddValue("_cabPrepForm___", _cabPrepForm___)
			info.AddValue("_alwaysFetchCabPrepForm___", _alwaysFetchCabPrepForm___)
			info.AddValue("_alreadyFetchedCabPrepForm___", _alreadyFetchedCabPrepForm___)
			info.AddValue("_cabProMed", _cabProMed)
			info.AddValue("_alwaysFetchCabProMed", _alwaysFetchCabProMed)
			info.AddValue("_alreadyFetchedCabProMed", _alreadyFetchedCabProMed)
			info.AddValue("_inventarioMovimientosAlmacenDetalles", _inventarioMovimientosAlmacenDetalles)
			info.AddValue("_alwaysFetchInventarioMovimientosAlmacenDetalles", _alwaysFetchInventarioMovimientosAlmacenDetalles)
			info.AddValue("_alreadyFetchedInventarioMovimientosAlmacenDetalles", _alreadyFetchedInventarioMovimientosAlmacenDetalles)
			info.AddValue("_minvTransferenciaAlmacenEntrada", _minvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntrada", _alwaysFetchMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntrada", _alreadyFetchedMinvTransferenciaAlmacenEntrada)
			info.AddValue("_minvTransferenciaAlmacenEntrada_", _minvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntrada_", _alwaysFetchMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntrada_", _alreadyFetchedMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_minvTransferenciaAlmacenSalida", _minvTransferenciaAlmacenSalida)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalida", _alwaysFetchMinvTransferenciaAlmacenSalida)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalida", _alreadyFetchedMinvTransferenciaAlmacenSalida)
			info.AddValue("_minvTransferenciaAlmacenSalida_", _minvTransferenciaAlmacenSalida_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalida_", _alwaysFetchMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalida_", _alreadyFetchedMinvTransferenciaAlmacenSalida_)
			info.AddValue("_almacenCollectionViaAplicMedi", _almacenCollectionViaAplicMedi)
			info.AddValue("_alwaysFetchAlmacenCollectionViaAplicMedi", _alwaysFetchAlmacenCollectionViaAplicMedi)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaAplicMedi", _alreadyFetchedAlmacenCollectionViaAplicMedi)
			info.AddValue("_almacenCollectionViaAplicMedi_", _almacenCollectionViaAplicMedi_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaAplicMedi_", _alwaysFetchAlmacenCollectionViaAplicMedi_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaAplicMedi_", _alreadyFetchedAlmacenCollectionViaAplicMedi_)
			info.AddValue("_almacenCollectionViaCabAplFor", _almacenCollectionViaCabAplFor)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabAplFor", _alwaysFetchAlmacenCollectionViaCabAplFor)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabAplFor", _alreadyFetchedAlmacenCollectionViaCabAplFor)
			info.AddValue("_almacenCollectionViaCabAplFor_", _almacenCollectionViaCabAplFor_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabAplFor_", _alwaysFetchAlmacenCollectionViaCabAplFor_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabAplFor_", _alreadyFetchedAlmacenCollectionViaCabAplFor_)
			info.AddValue("_almacenCollectionViaCabPrepForm", _almacenCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm", _alwaysFetchAlmacenCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm", _alreadyFetchedAlmacenCollectionViaCabPrepForm)
			info.AddValue("_almacenCollectionViaCabPrepForm_", _almacenCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm_", _alwaysFetchAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm_", _alreadyFetchedAlmacenCollectionViaCabPrepForm_)
			info.AddValue("_almacenCollectionViaCabPrepForm__", _almacenCollectionViaCabPrepForm__)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm__", _alwaysFetchAlmacenCollectionViaCabPrepForm__)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm__", _alreadyFetchedAlmacenCollectionViaCabPrepForm__)
			info.AddValue("_almacenCollectionViaCabPrepForm___", _almacenCollectionViaCabPrepForm___)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabPrepForm___", _alwaysFetchAlmacenCollectionViaCabPrepForm___)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabPrepForm___", _alreadyFetchedAlmacenCollectionViaCabPrepForm___)
			info.AddValue("_productoCollectionViaCabPrepForm", _productoCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm", _alwaysFetchProductoCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm", _alreadyFetchedProductoCollectionViaCabPrepForm)
			info.AddValue("_productoCollectionViaCabPrepForm_", _productoCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm_", _alwaysFetchProductoCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm_", _alreadyFetchedProductoCollectionViaCabPrepForm_)
			info.AddValue("_productoCollectionViaCabPrepForm__", _productoCollectionViaCabPrepForm__)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm__", _alwaysFetchProductoCollectionViaCabPrepForm__)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm__", _alreadyFetchedProductoCollectionViaCabPrepForm__)
			info.AddValue("_productoCollectionViaCabPrepForm___", _productoCollectionViaCabPrepForm___)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm___", _alwaysFetchProductoCollectionViaCabPrepForm___)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm___", _alreadyFetchedProductoCollectionViaCabPrepForm___)
			info.AddValue("_productoCollectionViaCabPrepForm____", _productoCollectionViaCabPrepForm____)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm____", _alwaysFetchProductoCollectionViaCabPrepForm____)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm____", _alreadyFetchedProductoCollectionViaCabPrepForm____)
			info.AddValue("_productoCollectionViaCabPrepForm_____", _productoCollectionViaCabPrepForm_____)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm_____", _alwaysFetchProductoCollectionViaCabPrepForm_____)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm_____", _alreadyFetchedProductoCollectionViaCabPrepForm_____)
			info.AddValue("_productoCollectionViaCabPrepForm______", _productoCollectionViaCabPrepForm______)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm______", _alwaysFetchProductoCollectionViaCabPrepForm______)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm______", _alreadyFetchedProductoCollectionViaCabPrepForm______)
			info.AddValue("_productoCollectionViaCabPrepForm_______", _productoCollectionViaCabPrepForm_______)
			info.AddValue("_alwaysFetchProductoCollectionViaCabPrepForm_______", _alwaysFetchProductoCollectionViaCabPrepForm_______)
			info.AddValue("_alreadyFetchedProductoCollectionViaCabPrepForm_______", _alreadyFetchedProductoCollectionViaCabPrepForm_______)
			info.AddValue("_plazaCollectionViaCabPrepForm", _plazaCollectionViaCabPrepForm)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm", _alwaysFetchPlazaCollectionViaCabPrepForm)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm", _alreadyFetchedPlazaCollectionViaCabPrepForm)
			info.AddValue("_plazaCollectionViaCabPrepForm_", _plazaCollectionViaCabPrepForm_)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm_", _alwaysFetchPlazaCollectionViaCabPrepForm_)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm_", _alreadyFetchedPlazaCollectionViaCabPrepForm_)
			info.AddValue("_plazaCollectionViaCabPrepForm__", _plazaCollectionViaCabPrepForm__)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm__", _alwaysFetchPlazaCollectionViaCabPrepForm__)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm__", _alreadyFetchedPlazaCollectionViaCabPrepForm__)
			info.AddValue("_plazaCollectionViaCabPrepForm___", _plazaCollectionViaCabPrepForm___)
			info.AddValue("_alwaysFetchPlazaCollectionViaCabPrepForm___", _alwaysFetchPlazaCollectionViaCabPrepForm___)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCabPrepForm___", _alreadyFetchedPlazaCollectionViaCabPrepForm___)
			info.AddValue("_almacenCollectionViaCabProMed", _almacenCollectionViaCabProMed)
			info.AddValue("_alwaysFetchAlmacenCollectionViaCabProMed", _alwaysFetchAlmacenCollectionViaCabProMed)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaCabProMed", _alreadyFetchedAlmacenCollectionViaCabProMed)
			info.AddValue("_almacenCollectionViaInventarioMovimientoAlmacenDetalles", _almacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles", _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles)
			info.AddValue("_productoCollectionViainventarioMovimientosAlmacenDetalles", _productoCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles", _alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles", _alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada", _almacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada_", _almacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada__", _almacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada___", _almacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___)
			info.AddValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida", _almacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida_", _almacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida__", _almacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenSalida___", _almacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_tipoMovimientoAlmacen", _tipoMovimientoAlmacen)
			info.AddValue("_tipoMovimientoAlmacenReturnsNewIfNotFound", _tipoMovimientoAlmacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoMovimientoAlmacen", _alwaysFetchTipoMovimientoAlmacen)
			info.AddValue("_alreadyFetchedTipoMovimientoAlmacen", _alreadyFetchedTipoMovimientoAlmacen)

			
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
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case "TipoMovimientoAlmacen"
					_alreadyFetchedTipoMovimientoAlmacen = True
					Me.TipoMovimientoAlmacen = CType(entity, TipoMovimientoAlmacenEntity)
				Case "AplicMedi"
					_alreadyFetchedAplicMedi = True
					If Not entity Is Nothing Then
						Me.AplicMedi.Add(CType(entity, AplicMediEntity))
					End If
				Case "AplicMedi_"
					_alreadyFetchedAplicMedi_ = True
					If Not entity Is Nothing Then
						Me.AplicMedi_.Add(CType(entity, AplicMediEntity))
					End If
				Case "CabAplFor"
					_alreadyFetchedCabAplFor = True
					If Not entity Is Nothing Then
						Me.CabAplFor.Add(CType(entity, CabAplForEntity))
					End If
				Case "CabAplFor_"
					_alreadyFetchedCabAplFor_ = True
					If Not entity Is Nothing Then
						Me.CabAplFor_.Add(CType(entity, CabAplForEntity))
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
				Case "CabPrepForm__"
					_alreadyFetchedCabPrepForm__ = True
					If Not entity Is Nothing Then
						Me.CabPrepForm__.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "CabPrepForm___"
					_alreadyFetchedCabPrepForm___ = True
					If Not entity Is Nothing Then
						Me.CabPrepForm___.Add(CType(entity, CabPrepFormEntity))
					End If
				Case "CabProMed"
					_alreadyFetchedCabProMed = True
					If Not entity Is Nothing Then
						Me.CabProMed.Add(CType(entity, CabProMedEntity))
					End If
				Case "InventarioMovimientosAlmacenDetalles"
					_alreadyFetchedInventarioMovimientosAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientosAlmacenDetalles.Add(CType(entity, InventarioMovimientoAlmacenDetallesEntity))
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
				Case "AlmacenCollectionViaAplicMedi"
					_alreadyFetchedAlmacenCollectionViaAplicMedi = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaAplicMedi.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaAplicMedi_"
					_alreadyFetchedAlmacenCollectionViaAplicMedi_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaAplicMedi_.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaCabAplFor"
					_alreadyFetchedAlmacenCollectionViaCabAplFor = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabAplFor.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaCabAplFor_"
					_alreadyFetchedAlmacenCollectionViaCabAplFor_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabAplFor_.Add(CType(entity, AlmacenEntity))
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
				Case "AlmacenCollectionViaCabPrepForm__"
					_alreadyFetchedAlmacenCollectionViaCabPrepForm__ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabPrepForm__.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaCabPrepForm___"
					_alreadyFetchedAlmacenCollectionViaCabPrepForm___ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabPrepForm___.Add(CType(entity, AlmacenEntity))
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
				Case "ProductoCollectionViaCabPrepForm__"
					_alreadyFetchedProductoCollectionViaCabPrepForm__ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm__.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm___"
					_alreadyFetchedProductoCollectionViaCabPrepForm___ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm___.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm____"
					_alreadyFetchedProductoCollectionViaCabPrepForm____ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm____.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm_____"
					_alreadyFetchedProductoCollectionViaCabPrepForm_____ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm_____.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm______"
					_alreadyFetchedProductoCollectionViaCabPrepForm______ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm______.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaCabPrepForm_______"
					_alreadyFetchedProductoCollectionViaCabPrepForm_______ = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaCabPrepForm_______.Add(CType(entity, ProductoEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm"
					_alreadyFetchedPlazaCollectionViaCabPrepForm = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm.Add(CType(entity, PlazaEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm_"
					_alreadyFetchedPlazaCollectionViaCabPrepForm_ = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm_.Add(CType(entity, PlazaEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm__"
					_alreadyFetchedPlazaCollectionViaCabPrepForm__ = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm__.Add(CType(entity, PlazaEntity))
					End If
				Case "PlazaCollectionViaCabPrepForm___"
					_alreadyFetchedPlazaCollectionViaCabPrepForm___ = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCabPrepForm___.Add(CType(entity, PlazaEntity))
					End If
				Case "AlmacenCollectionViaCabProMed"
					_alreadyFetchedAlmacenCollectionViaCabProMed = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaCabProMed.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaInventarioMovimientoAlmacenDetalles"
					_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaInventarioMovimientoAlmacenDetalles.Add(CType(entity, AlmacenEntity))
					End If
				Case "ProductoCollectionViainventarioMovimientosAlmacenDetalles"
					_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViainventarioMovimientosAlmacenDetalles.Add(CType(entity, ProductoEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___.Add(CType(entity, AlmacenEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, MinvTransferenciaAlmacenSalidaEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenSalida"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenSalida.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenSalida_"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenSalida_.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenSalida__"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenSalida__.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenSalida___"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenSalida___.Add(CType(entity, AlmacenEntity))
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
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoMovimientoAlmacen"
					SetupSyncTipoMovimientoAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMedi"
					_aplicMedi.Add(CType(relatedEntity, AplicMediEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMedi_"
					_aplicMedi_.Add(CType(relatedEntity, AplicMediEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabAplFor"
					_cabAplFor.Add(CType(relatedEntity, CabAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabAplFor_"
					_cabAplFor_.Add(CType(relatedEntity, CabAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm"
					_cabPrepForm.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm_"
					_cabPrepForm_.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm__"
					_cabPrepForm__.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabPrepForm___"
					_cabPrepForm___.Add(CType(relatedEntity, CabPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabProMed"
					_cabProMed.Add(CType(relatedEntity, CabProMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientosAlmacenDetalles"
					_inventarioMovimientosAlmacenDetalles.Add(CType(relatedEntity, InventarioMovimientoAlmacenDetallesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					_minvTransferenciaAlmacenEntrada.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada_"
					_minvTransferenciaAlmacenEntrada_.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida"
					_minvTransferenciaAlmacenSalida.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida_"
					_minvTransferenciaAlmacenSalida_.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaEntity))
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
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoMovimientoAlmacen"
					DesetupSyncTipoMovimientoAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMedi"
					MyBase.PerformRelatedEntityRemoval(_aplicMedi, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMedi_"
					MyBase.PerformRelatedEntityRemoval(_aplicMedi_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabAplFor"
					MyBase.PerformRelatedEntityRemoval(_cabAplFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabAplFor_"
					MyBase.PerformRelatedEntityRemoval(_cabAplFor_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm_"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm__"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm__, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabPrepForm___"
					MyBase.PerformRelatedEntityRemoval(_cabPrepForm___, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabProMed"
					MyBase.PerformRelatedEntityRemoval(_cabProMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientosAlmacenDetalles"
					MyBase.PerformRelatedEntityRemoval(_inventarioMovimientosAlmacenDetalles, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntrada, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada_"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntrada_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalida, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalida_"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalida_, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
			End If
			If Not _tipoMovimientoAlmacen Is Nothing Then
				toReturn.Add(_tipoMovimientoAlmacen)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_aplicMedi)
			toReturn.Add(_aplicMedi_)
			toReturn.Add(_cabAplFor)
			toReturn.Add(_cabAplFor_)
			toReturn.Add(_cabPrepForm)
			toReturn.Add(_cabPrepForm_)
			toReturn.Add(_cabPrepForm__)
			toReturn.Add(_cabPrepForm___)
			toReturn.Add(_cabProMed)
			toReturn.Add(_inventarioMovimientosAlmacenDetalles)
			toReturn.Add(_minvTransferenciaAlmacenEntrada)
			toReturn.Add(_minvTransferenciaAlmacenEntrada_)
			toReturn.Add(_minvTransferenciaAlmacenSalida)
			toReturn.Add(_minvTransferenciaAlmacenSalida_)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String) As Boolean
			Return FetchUsingPK(almacenId, folioMovimiento, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(almacenId, folioMovimiento, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(almacenId, folioMovimiento, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.AlmacenId, Me.FolioMovimiento, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As InventarioMovimientoAlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As InventarioMovimientoAlmacenFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_aplicMedi.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMedi_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi_(forceFetch, _aplicMedi_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAplicMedi_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AplicMediEntity'</returns>
		Public Function GetMultiAplicMedi_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediCollection
			Return GetMultiAplicMedi_(forceFetch, _aplicMedi_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAplicMedi_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AplicMediCollection
			If ( Not _alreadyFetchedAplicMedi_ Or forceFetch Or _alwaysFetchAplicMedi_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _aplicMedi_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_aplicMedi_)
					End If
				End If
				_aplicMedi_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_aplicMedi_.EntityFactoryToUse = entityFactoryToUse
				End If
				_aplicMedi_.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_aplicMedi_.SuppressClearInGetMulti = False
				_alreadyFetchedAplicMedi_ = True
			End If
			Return _aplicMedi_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AplicMedi_'. These settings will be taken into account
		''' when the property AplicMedi_ is requested or GetMultiAplicMedi_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAplicMedi_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_aplicMedi_.SortClauses=sortClauses
			_aplicMedi_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_cabAplFor.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabAplForEntity'</returns>
		Public Function GetMultiCabAplFor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor_(forceFetch, _cabAplFor_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabAplFor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabAplForEntity'</returns>
		Public Function GetMultiCabAplFor_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabAplForCollection
			Return GetMultiCabAplFor_(forceFetch, _cabAplFor_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabAplFor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabAplForCollection
			If ( Not _alreadyFetchedCabAplFor_ Or forceFetch Or _alwaysFetchCabAplFor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabAplFor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabAplFor_)
					End If
				End If
				_cabAplFor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabAplFor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabAplFor_.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cabAplFor_.SuppressClearInGetMulti = False
				_alreadyFetchedCabAplFor_ = True
			End If
			Return _cabAplFor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabAplFor_'. These settings will be taken into account
		''' when the property CabAplFor_ is requested or GetMultiCabAplFor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabAplFor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabAplFor_.SortClauses=sortClauses
			_cabAplFor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_cabPrepForm.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Nothing, Nothing, Nothing, Filter)
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
				_cabPrepForm_.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm__(forceFetch, _cabPrepForm__.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm__(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm__(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm__(forceFetch, _cabPrepForm__.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepForm__ Or forceFetch Or _alwaysFetchCabPrepForm__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepForm__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepForm__)
					End If
				End If
				_cabPrepForm__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepForm__.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepForm__.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_cabPrepForm__.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepForm__ = True
			End If
			Return _cabPrepForm__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepForm__'. These settings will be taken into account
		''' when the property CabPrepForm__ is requested or GetMultiCabPrepForm__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepForm__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepForm__.SortClauses=sortClauses
			_cabPrepForm__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm___(forceFetch, _cabPrepForm___.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm___(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabPrepFormEntity'</returns>
		Public Function GetMultiCabPrepForm___(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Return GetMultiCabPrepForm___(forceFetch, _cabPrepForm___.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			If ( Not _alreadyFetchedCabPrepForm___ Or forceFetch Or _alwaysFetchCabPrepForm___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabPrepForm___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabPrepForm___)
					End If
				End If
				_cabPrepForm___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabPrepForm___.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabPrepForm___.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_cabPrepForm___.SuppressClearInGetMulti = False
				_alreadyFetchedCabPrepForm___ = True
			End If
			Return _cabPrepForm___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabPrepForm___'. These settings will be taken into account
		''' when the property CabPrepForm___ is requested or GetMultiCabPrepForm___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabPrepForm___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabPrepForm___.SortClauses=sortClauses
			_cabPrepForm___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_cabProMed.GetMultiManyToOne(Nothing, Me, Filter)
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
				_inventarioMovimientosAlmacenDetalles.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
				_minvTransferenciaAlmacenEntrada.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
				_minvTransferenciaAlmacenEntrada_.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
				_minvTransferenciaAlmacenSalida.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
				_minvTransferenciaAlmacenSalida_.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaAplicMedi(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaAplicMedi(forceFetch, _almacenCollectionViaAplicMedi.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaAplicMedi(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaAplicMedi Or forceFetch Or _alwaysFetchAlmacenCollectionViaAplicMedi) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaAplicMedi.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaAplicMedi)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacen, "__InventarioMovimientoAlmacenEntity__", "AplicMedi_", JoinHint.None)
				relations.Add(AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen, "AplicMedi_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaAplicMedi.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaAplicMedi.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaAplicMedi.GetMulti(Filter, relations)
				_almacenCollectionViaAplicMedi.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaAplicMedi = True
			End If
			Return _almacenCollectionViaAplicMedi
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaAplicMedi'. These settings will be taken into account
		''' when the property AlmacenCollectionViaAplicMedi is requested or GetMultiAlmacenCollectionViaAplicMedi is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaAplicMedi(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaAplicMedi.SortClauses=sortClauses
			_almacenCollectionViaAplicMedi.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaAplicMedi_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaAplicMedi_(forceFetch, _almacenCollectionViaAplicMedi_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaAplicMedi_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaAplicMedi_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaAplicMedi_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaAplicMedi_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaAplicMedi_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", "AplicMedi_", JoinHint.None)
				relations.Add(AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen, "AplicMedi_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaAplicMedi_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaAplicMedi_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaAplicMedi_.GetMulti(Filter, relations)
				_almacenCollectionViaAplicMedi_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaAplicMedi_ = True
			End If
			Return _almacenCollectionViaAplicMedi_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaAplicMedi_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaAplicMedi_ is requested or GetMultiAlmacenCollectionViaAplicMedi_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaAplicMedi_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaAplicMedi_.SortClauses=sortClauses
			_almacenCollectionViaAplicMedi_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabAplFor(forceFetch, _almacenCollectionViaCabAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabAplFor Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacen, "__InventarioMovimientoAlmacenEntity__", "CabAplFor_", JoinHint.None)
				relations.Add(CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen, "CabAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaCabAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabAplFor.GetMulti(Filter, relations)
				_almacenCollectionViaCabAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabAplFor = True
			End If
			Return _almacenCollectionViaCabAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabAplFor'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabAplFor is requested or GetMultiAlmacenCollectionViaCabAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabAplFor.SortClauses=sortClauses
			_almacenCollectionViaCabAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabAplFor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabAplFor_(forceFetch, _almacenCollectionViaCabAplFor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabAplFor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabAplFor_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabAplFor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabAplFor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabAplFor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", "CabAplFor_", JoinHint.None)
				relations.Add(CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen, "CabAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaCabAplFor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabAplFor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabAplFor_.GetMulti(Filter, relations)
				_almacenCollectionViaCabAplFor_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabAplFor_ = True
			End If
			Return _almacenCollectionViaCabAplFor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabAplFor_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabAplFor_ is requested or GetMultiAlmacenCollectionViaCabAplFor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabAplFor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabAplFor_.SortClauses=sortClauses
			_almacenCollectionViaCabAplFor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabPrepForm__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabPrepForm__(forceFetch, _almacenCollectionViaCabPrepForm__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabPrepForm__ Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabPrepForm__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabPrepForm__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabPrepForm__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaCabPrepForm__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabPrepForm__.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabPrepForm__.GetMulti(Filter, relations)
				_almacenCollectionViaCabPrepForm__.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabPrepForm__ = True
			End If
			Return _almacenCollectionViaCabPrepForm__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabPrepForm__'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabPrepForm__ is requested or GetMultiAlmacenCollectionViaCabPrepForm__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabPrepForm__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabPrepForm__.SortClauses=sortClauses
			_almacenCollectionViaCabPrepForm__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabPrepForm___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabPrepForm___(forceFetch, _almacenCollectionViaCabPrepForm___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabPrepForm___ Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabPrepForm___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabPrepForm___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabPrepForm___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaCabPrepForm___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabPrepForm___.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabPrepForm___.GetMulti(Filter, relations)
				_almacenCollectionViaCabPrepForm___.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabPrepForm___ = True
			End If
			Return _almacenCollectionViaCabPrepForm___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabPrepForm___'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabPrepForm___ is requested or GetMultiAlmacenCollectionViaCabPrepForm___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabPrepForm___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabPrepForm___.SortClauses=sortClauses
			_almacenCollectionViaCabPrepForm___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm__(forceFetch, _productoCollectionViaCabPrepForm__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm__ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm__.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm__.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm__.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm__ = True
			End If
			Return _productoCollectionViaCabPrepForm__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm__'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm__ is requested or GetMultiProductoCollectionViaCabPrepForm__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm__.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm___(forceFetch, _productoCollectionViaCabPrepForm___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm___ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm___.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm___.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm___.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm___ = True
			End If
			Return _productoCollectionViaCabPrepForm___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm___'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm___ is requested or GetMultiProductoCollectionViaCabPrepForm___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm___.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm____(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm____(forceFetch, _productoCollectionViaCabPrepForm____.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm____(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm____ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm____) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm____.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm____)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm____.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm____.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm____.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm____.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm____ = True
			End If
			Return _productoCollectionViaCabPrepForm____
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm____'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm____ is requested or GetMultiProductoCollectionViaCabPrepForm____ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm____(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm____.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm_____(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm_____(forceFetch, _productoCollectionViaCabPrepForm_____.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm_____(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm_____ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm_____) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm_____.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm_____)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm_____.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm_____.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm_____.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm_____.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm_____ = True
			End If
			Return _productoCollectionViaCabPrepForm_____
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm_____'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm_____ is requested or GetMultiProductoCollectionViaCabPrepForm_____ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm_____(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm_____.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm______(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm______(forceFetch, _productoCollectionViaCabPrepForm______.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm______(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm______ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm______) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm______.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm______)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm______.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm______.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm______.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm______.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm______ = True
			End If
			Return _productoCollectionViaCabPrepForm______
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm______'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm______ is requested or GetMultiProductoCollectionViaCabPrepForm______ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm______(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm______.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaCabPrepForm_______(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaCabPrepForm_______(forceFetch, _productoCollectionViaCabPrepForm_______.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaCabPrepForm_______(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaCabPrepForm_______ Or forceFetch Or _alwaysFetchProductoCollectionViaCabPrepForm_______) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaCabPrepForm_______.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaCabPrepForm_______)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaCabPrepForm_______.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaCabPrepForm_______.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaCabPrepForm_______.GetMulti(Filter, relations)
				_productoCollectionViaCabPrepForm_______.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaCabPrepForm_______ = True
			End If
			Return _productoCollectionViaCabPrepForm_______
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaCabPrepForm_______'. These settings will be taken into account
		''' when the property ProductoCollectionViaCabPrepForm_______ is requested or GetMultiProductoCollectionViaCabPrepForm_______ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaCabPrepForm_______(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaCabPrepForm_______.SortClauses=sortClauses
			_productoCollectionViaCabPrepForm_______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaCabPrepForm__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaCabPrepForm__(forceFetch, _plazaCollectionViaCabPrepForm__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaCabPrepForm__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaCabPrepForm__ Or forceFetch Or _alwaysFetchPlazaCollectionViaCabPrepForm__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaCabPrepForm__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaCabPrepForm__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_plazaCollectionViaCabPrepForm__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaCabPrepForm__.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaCabPrepForm__.GetMulti(Filter, relations)
				_plazaCollectionViaCabPrepForm__.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaCabPrepForm__ = True
			End If
			Return _plazaCollectionViaCabPrepForm__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaCabPrepForm__'. These settings will be taken into account
		''' when the property PlazaCollectionViaCabPrepForm__ is requested or GetMultiPlazaCollectionViaCabPrepForm__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaCabPrepForm__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaCabPrepForm__.SortClauses=sortClauses
			_plazaCollectionViaCabPrepForm__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaCabPrepForm___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaCabPrepForm___(forceFetch, _plazaCollectionViaCabPrepForm___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaCabPrepForm___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaCabPrepForm___ Or forceFetch Or _alwaysFetchPlazaCollectionViaCabPrepForm___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaCabPrepForm___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaCabPrepForm___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", "CabPrepForm_", JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "CabPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_plazaCollectionViaCabPrepForm___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaCabPrepForm___.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaCabPrepForm___.GetMulti(Filter, relations)
				_plazaCollectionViaCabPrepForm___.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaCabPrepForm___ = True
			End If
			Return _plazaCollectionViaCabPrepForm___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaCabPrepForm___'. These settings will be taken into account
		''' when the property PlazaCollectionViaCabPrepForm___ is requested or GetMultiPlazaCollectionViaCabPrepForm___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaCabPrepForm___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaCabPrepForm___.SortClauses=sortClauses
			_plazaCollectionViaCabPrepForm___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaCabProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaCabProMed(forceFetch, _almacenCollectionViaCabProMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaCabProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaCabProMed Or forceFetch Or _alwaysFetchAlmacenCollectionViaCabProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaCabProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaCabProMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabProMedEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, "__InventarioMovimientoAlmacenEntity__", "CabProMed_", JoinHint.None)
				relations.Add(CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen, "CabProMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaCabProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaCabProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaCabProMed.GetMulti(Filter, relations)
				_almacenCollectionViaCabProMed.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaCabProMed = True
			End If
			Return _almacenCollectionViaCabProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaCabProMed'. These settings will be taken into account
		''' when the property AlmacenCollectionViaCabProMed is requested or GetMultiAlmacenCollectionViaCabProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaCabProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaCabProMed.SortClauses=sortClauses
			_almacenCollectionViaCabProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.AlmacenEntityUsingAlmacenId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles(forceFetch, _productoCollectionViainventarioMovimientosAlmacenDetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles Or forceFetch Or _alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViainventarioMovimientosAlmacenDetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViainventarioMovimientosAlmacenDetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", "InventarioMovimientoAlmacenDetalles_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId, "InventarioMovimientoAlmacenDetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViainventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViainventarioMovimientosAlmacenDetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViainventarioMovimientosAlmacenDetalles.GetMulti(Filter, relations)
				_productoCollectionViainventarioMovimientosAlmacenDetalles.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles = True
			End If
			Return _productoCollectionViainventarioMovimientosAlmacenDetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViainventarioMovimientosAlmacenDetalles'. These settings will be taken into account
		''' when the property ProductoCollectionViainventarioMovimientosAlmacenDetalles is requested or GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViainventarioMovimientosAlmacenDetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViainventarioMovimientosAlmacenDetalles.SortClauses=sortClauses
			_productoCollectionViainventarioMovimientosAlmacenDetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
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

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenSalida.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenSalida.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenSalida)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenSalida.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenSalida.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenSalida.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenSalida.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenSalida
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenSalida'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenSalida is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenSalida(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenSalida.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenSalida.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenSalida_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenSalida_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenSalida_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenSalida_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenSalida_.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenSalida_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenSalida_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenSalida_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenSalida_.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenSalida_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenSalida__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenSalida__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenSalida__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenSalida__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenSalida__.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenSalida__.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenSalida__.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenSalida__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenSalida__'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenSalida__.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenSalida__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenSalida___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenSalida___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenSalida___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "__InventarioMovimientoAlmacenEntity__", "MinvTransferenciaAlmacenSalida_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenSalida_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvTransferenciaAlmacenSalida___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenSalida___.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenSalida___.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenSalida___.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenSalida___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenSalida___'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenSalida___.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenSalida___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen() As AlmacenEntity
			Return GetSingleAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId) Then
					fetchResult = newEntity.FetchUsingPK(Me.AlmacenId)
				End If
				If Not _almacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Almacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.Almacen = newEntity
					_alreadyFetchedAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacen
		End Function
	
		''' <summary>Retrieves the related entity of type 'TipoMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMovimientoAlmacen() As TipoMovimientoAlmacenEntity
			Return GetSingleTipoMovimientoAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMovimientoAlmacen(forceFetch As Boolean) As TipoMovimientoAlmacenEntity
			If ( Not _alreadyFetchedTipoMovimientoAlmacen Or forceFetch Or _alwaysFetchTipoMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoMovimientoId.GetValueOrDefault())
				End If
				If Not _tipoMovimientoAlmacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoMovimientoAlmacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoMovimientoAlmacenEntity)
					End If
					Me.TipoMovimientoAlmacen = newEntity
					_alreadyFetchedTipoMovimientoAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoMovimientoAlmacen
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(InventarioMovimientoAlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, InventarioMovimientoAlmacenFieldIndex)
					Case InventarioMovimientoAlmacenFieldIndex.AlmacenId
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False


					Case InventarioMovimientoAlmacenFieldIndex.TipoMovimientoId
						DesetupSyncTipoMovimientoAlmacen(True, False)
						_alreadyFetchedTipoMovimientoAlmacen = False










					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_aplicMedi.ActiveContext = MyBase.ActiveContext
			_aplicMedi_.ActiveContext = MyBase.ActiveContext
			_cabAplFor.ActiveContext = MyBase.ActiveContext
			_cabAplFor_.ActiveContext = MyBase.ActiveContext
			_cabPrepForm.ActiveContext = MyBase.ActiveContext
			_cabPrepForm_.ActiveContext = MyBase.ActiveContext
			_cabPrepForm__.ActiveContext = MyBase.ActiveContext
			_cabPrepForm___.ActiveContext = MyBase.ActiveContext
			_cabProMed.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientosAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalida.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalida_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaAplicMedi.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaAplicMedi_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabAplFor.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabAplFor_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm____.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm_____.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm______.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaCabPrepForm_______.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm_.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm__.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCabPrepForm___.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaCabProMed.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_productoCollectionViainventarioMovimientosAlmacenDetalles.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada__.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada___.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenSalida.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenSalida_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenSalida__.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenSalida___.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoMovimientoAlmacen Is Nothing Then
				_tipoMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As InventarioMovimientoAlmacenDAO = CType(CreateDAOInstance(), InventarioMovimientoAlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As InventarioMovimientoAlmacenDAO = CType(CreateDAOInstance(), InventarioMovimientoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As InventarioMovimientoAlmacenDAO = CType(CreateDAOInstance(), InventarioMovimientoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this InventarioMovimientoAlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="validator">The validator Object for this InventarioMovimientoAlmacenEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(almacenId As System.Int32, folioMovimiento As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(almacenId, folioMovimiento, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_aplicMedi = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_aplicMedi.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen")
			_alwaysFetchAplicMedi = False
			_alreadyFetchedAplicMedi = False
			_aplicMedi_ = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_aplicMedi_.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen_")
			_alwaysFetchAplicMedi_ = False
			_alreadyFetchedAplicMedi_ = False
			_cabAplFor = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_cabAplFor.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen")
			_alwaysFetchCabAplFor = False
			_alreadyFetchedCabAplFor = False
			_cabAplFor_ = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_cabAplFor_.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen_")
			_alwaysFetchCabAplFor_ = False
			_alreadyFetchedCabAplFor_ = False
			_cabPrepForm = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm.SetContainingEntityInfo(Me, "MovimientoAlmacenEntradaMezcla")
			_alwaysFetchCabPrepForm = False
			_alreadyFetchedCabPrepForm = False
			_cabPrepForm_ = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm_.SetContainingEntityInfo(Me, "MovimientoAlmacenCancelacionEntradaMezcla")
			_alwaysFetchCabPrepForm_ = False
			_alreadyFetchedCabPrepForm_ = False
			_cabPrepForm__ = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm__.SetContainingEntityInfo(Me, "MovimientoAlmacenSalidaIngrediente")
			_alwaysFetchCabPrepForm__ = False
			_alreadyFetchedCabPrepForm__ = False
			_cabPrepForm___ = New Integralab.ORM.CollectionClasses.CabPrepFormCollection(New CabPrepFormEntityFactory())
			_cabPrepForm___.SetContainingEntityInfo(Me, "MovimientoAlmacenCancelacionSalidaIngrediente")
			_alwaysFetchCabPrepForm___ = False
			_alreadyFetchedCabPrepForm___ = False
			_cabProMed = New Integralab.ORM.CollectionClasses.CabProMedCollection(New CabProMedEntityFactory())
			_cabProMed.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen")
			_alwaysFetchCabProMed = False
			_alreadyFetchedCabProMed = False
			_inventarioMovimientosAlmacenDetalles = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(New InventarioMovimientoAlmacenDetallesEntityFactory())
			_inventarioMovimientosAlmacenDetalles.SetContainingEntityInfo(Me, "InventarioMovimientosAlmacen")
			_alwaysFetchInventarioMovimientosAlmacenDetalles = False
			_alreadyFetchedInventarioMovimientosAlmacenDetalles = False
			_minvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_minvTransferenciaAlmacenEntrada.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen")
			_alwaysFetchMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = False
			_minvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_minvTransferenciaAlmacenEntrada_.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen_")
			_alwaysFetchMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedMinvTransferenciaAlmacenEntrada_ = False
			_minvTransferenciaAlmacenSalida = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_minvTransferenciaAlmacenSalida.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen")
			_alwaysFetchMinvTransferenciaAlmacenSalida = False
			_alreadyFetchedMinvTransferenciaAlmacenSalida = False
			_minvTransferenciaAlmacenSalida_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_minvTransferenciaAlmacenSalida_.SetContainingEntityInfo(Me, "InventarioMovimientoAlmacen_")
			_alwaysFetchMinvTransferenciaAlmacenSalida_ = False
			_alreadyFetchedMinvTransferenciaAlmacenSalida_ = False
			_almacenCollectionViaAplicMedi = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaAplicMedi = False
			_alreadyFetchedAlmacenCollectionViaAplicMedi = False
			_almacenCollectionViaAplicMedi_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaAplicMedi_ = False
			_alreadyFetchedAlmacenCollectionViaAplicMedi_ = False
			_almacenCollectionViaCabAplFor = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabAplFor = False
			_alreadyFetchedAlmacenCollectionViaCabAplFor = False
			_almacenCollectionViaCabAplFor_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabAplFor_ = False
			_alreadyFetchedAlmacenCollectionViaCabAplFor_ = False
			_almacenCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm = False
			_almacenCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm_ = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm_ = False
			_almacenCollectionViaCabPrepForm__ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm__ = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm__ = False
			_almacenCollectionViaCabPrepForm___ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabPrepForm___ = False
			_alreadyFetchedAlmacenCollectionViaCabPrepForm___ = False
			_productoCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm = False
			_alreadyFetchedProductoCollectionViaCabPrepForm = False
			_productoCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm_ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm_ = False
			_productoCollectionViaCabPrepForm__ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm__ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm__ = False
			_productoCollectionViaCabPrepForm___ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm___ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm___ = False
			_productoCollectionViaCabPrepForm____ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm____ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm____ = False
			_productoCollectionViaCabPrepForm_____ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm_____ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm_____ = False
			_productoCollectionViaCabPrepForm______ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm______ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm______ = False
			_productoCollectionViaCabPrepForm_______ = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaCabPrepForm_______ = False
			_alreadyFetchedProductoCollectionViaCabPrepForm_______ = False
			_plazaCollectionViaCabPrepForm = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm = False
			_plazaCollectionViaCabPrepForm_ = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm_ = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm_ = False
			_plazaCollectionViaCabPrepForm__ = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm__ = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm__ = False
			_plazaCollectionViaCabPrepForm___ = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCabPrepForm___ = False
			_alreadyFetchedPlazaCollectionViaCabPrepForm___ = False
			_almacenCollectionViaCabProMed = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaCabProMed = False
			_alreadyFetchedAlmacenCollectionViaCabProMed = False
			_almacenCollectionViaInventarioMovimientoAlmacenDetalles = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacenDetalles = False
			_productoCollectionViainventarioMovimientosAlmacenDetalles = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles = False
			_alreadyFetchedProductoCollectionViainventarioMovimientosAlmacenDetalles = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada__ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada___ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = False
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada = False
			_minvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(New MinvTransferenciaAlmacenSalidaEntityFactory())
			_alwaysFetchMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_almacenCollectionViaMinvTransferenciaAlmacenSalida = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida = False
			_almacenCollectionViaMinvTransferenciaAlmacenSalida_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = False
			_almacenCollectionViaMinvTransferenciaAlmacenSalida__ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = False
			_almacenCollectionViaMinvTransferenciaAlmacenSalida___ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_tipoMovimientoAlmacen = Nothing
			_tipoMovimientoAlmacenReturnsNewIfNotFound = True
			_alwaysFetchTipoMovimientoAlmacen = False
			_alreadyFetchedTipoMovimientoAlmacen = False

			
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

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoMovimientoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EstatusContabilizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PolizaContabilidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Entrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, True, signalRelatedEntity, "InventarioMovimientoAlmacen", resetFKFields, New Integer() { CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, True, _alreadyFetchedAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _tipoMovimientoAlmacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoMovimientoAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMovimientoAlmacen, AddressOf OnTipoMovimientoAlmacenPropertyChanged, "TipoMovimientoAlmacen", InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, True, signalRelatedEntity, "InventarioMovimientoAlmacen", resetFKFields, New Integer() { CInt(InventarioMovimientoAlmacenFieldIndex.TipoMovimientoId) } )
			_tipoMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncTipoMovimientoAlmacen(True, True)
			_tipoMovimientoAlmacen = CType(relatedEntity, TipoMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMovimientoAlmacen, AddressOf OnTipoMovimientoAlmacenPropertyChanged, "TipoMovimientoAlmacen", InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, True, _alreadyFetchedTipoMovimientoAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoMovimientoAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="almacenId">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="folioMovimiento">PK value for InventarioMovimientoAlmacen which data should be fetched into this InventarioMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.AlmacenId)).ForcedCurrentValueWrite(almacenId)
				MyBase.Fields(CInt(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento)).ForcedCurrentValueWrite(folioMovimiento)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateInventarioMovimientoAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New InventarioMovimientoAlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As InventarioMovimientoAlmacenRelations
			Get	
				Return New InventarioMovimientoAlmacenRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMedi() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMedi_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMedi_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "CabAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplFor_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "CabAplFor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm__() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabPrepForm___() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabPrepFormCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "CabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabProMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabProMedCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabProMedEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), 0, Nothing, Nothing, Nothing, "CabProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacenDetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientosAlmacenDetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenDetallesCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenDetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientosAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalida_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalida_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaAplicMedi() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacen, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaAplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaAplicMedi_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.AplicMediEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaAplicMedi_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacen, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabAplFor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabAplForEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabAplFor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm____() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm_____() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm______() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaCabPrepForm_______() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaCabPrepForm_______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCabPrepForm___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabPrepFormEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCabPrepForm___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaCabProMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.CabProMedEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.CabProMedEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaCabProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaInventarioMovimientoAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaInventarioMovimientoAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViainventarioMovimientosAlmacenDetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenDetallesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenDetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViainventarioMovimientosAlmacenDetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, relations, "MinvTransferenciaAlmacenSalidaCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenSalida() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenSalida_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenSalida_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenSalida__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimiento, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenSalida__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenSalida___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, "__InventarioMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenSalida___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(), _
					InventarioMovimientoAlmacenEntity.Relations.TipoMovimientoAlmacenEntityUsingTipoMovimientoId, _
					CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "InventarioMovimientoAlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return InventarioMovimientoAlmacenEntity.CustomProperties
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
				Return InventarioMovimientoAlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The AlmacenId property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."AlmacenId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimiento property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."FolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FechaMovimiento, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoMovimientoId property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."TipoMovimientoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoMovimientoId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.TipoMovimientoId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.TipoMovimientoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Origen property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."Origen"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Origen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Origen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Origen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Referencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioId property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."UsuarioId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.UsuarioId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.UsuarioId, Integer), value)
			End Set
		End Property
	
		''' <summary>The EstatusContabilizado property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."EstatusContabilizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EstatusContabilizado]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.EstatusContabilizado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.EstatusContabilizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The PolizaContabilidad property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."PolizaContabilidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PolizaContabilidad]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.PolizaContabilidad, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.PolizaContabilidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Entrega property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."Entrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Entrega]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Entrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Entrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibe property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."Recibe"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Recibe]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Recibe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Recibe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity InventarioMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacen"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(InventarioMovimientoAlmacenFieldIndex.Observaciones, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'AplicMediEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAplicMedi_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AplicMedi_]() As Integralab.ORM.CollectionClasses.AplicMediCollection
			Get
				Return GetMultiAplicMedi_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMedi_. When set to true, AplicMedi_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMedi_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAplicMedi_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMedi_ As Boolean
			Get
				Return _alwaysFetchAplicMedi_
			End Get
			Set
				_alwaysFetchAplicMedi_ = value
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
	
		''' <summary>Retrieves all related entities of type 'CabAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabAplFor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabAplFor_]() As Integralab.ORM.CollectionClasses.CabAplForCollection
			Get
				Return GetMultiCabAplFor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabAplFor_. When set to true, CabAplFor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabAplFor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabAplFor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabAplFor_ As Boolean
			Get
				Return _alwaysFetchCabAplFor_
			End Get
			Set
				_alwaysFetchCabAplFor_ = value
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
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepForm__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepForm__]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepForm__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepForm__. When set to true, CabPrepForm__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepForm__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepForm__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepForm__ As Boolean
			Get
				Return _alwaysFetchCabPrepForm__
			End Get
			Set
				_alwaysFetchCabPrepForm__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabPrepForm___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabPrepForm___]() As Integralab.ORM.CollectionClasses.CabPrepFormCollection
			Get
				Return GetMultiCabPrepForm___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabPrepForm___. When set to true, CabPrepForm___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabPrepForm___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabPrepForm___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabPrepForm___ As Boolean
			Get
				Return _alwaysFetchCabPrepForm___
			End Get
			Set
				_alwaysFetchCabPrepForm___ = value
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
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaAplicMedi()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaAplicMedi]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaAplicMedi(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaAplicMedi. When set to true, AlmacenCollectionViaAplicMedi is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaAplicMedi is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaAplicMedi(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaAplicMedi As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaAplicMedi
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaAplicMedi = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaAplicMedi_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaAplicMedi_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaAplicMedi_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaAplicMedi_. When set to true, AlmacenCollectionViaAplicMedi_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaAplicMedi_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaAplicMedi_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaAplicMedi_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaAplicMedi_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaAplicMedi_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabAplFor]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabAplFor. When set to true, AlmacenCollectionViaCabAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabAplFor As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabAplFor
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabAplFor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabAplFor_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabAplFor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabAplFor_. When set to true, AlmacenCollectionViaCabAplFor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabAplFor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabAplFor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabAplFor_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabAplFor_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabAplFor_ = value
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabPrepForm__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabPrepForm__]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabPrepForm__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabPrepForm__. When set to true, AlmacenCollectionViaCabPrepForm__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabPrepForm__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabPrepForm__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabPrepForm__ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabPrepForm__
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabPrepForm__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabPrepForm___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabPrepForm___]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabPrepForm___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabPrepForm___. When set to true, AlmacenCollectionViaCabPrepForm___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabPrepForm___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabPrepForm___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabPrepForm___ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabPrepForm___
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabPrepForm___ = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm__]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm__. When set to true, ProductoCollectionViaCabPrepForm__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm__ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm__
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm___]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm___. When set to true, ProductoCollectionViaCabPrepForm___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm___ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm___
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm____()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm____]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm____(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm____. When set to true, ProductoCollectionViaCabPrepForm____ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm____ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm____(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm____ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm____
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm____ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm_____()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm_____]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm_____(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm_____. When set to true, ProductoCollectionViaCabPrepForm_____ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm_____ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm_____(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm_____ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm_____
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm_____ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm______()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm______]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm______(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm______. When set to true, ProductoCollectionViaCabPrepForm______ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm______ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm______(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm______ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm______
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm______ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaCabPrepForm_______()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaCabPrepForm_______]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaCabPrepForm_______(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaCabPrepForm_______. When set to true, ProductoCollectionViaCabPrepForm_______ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaCabPrepForm_______ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaCabPrepForm_______(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaCabPrepForm_______ As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaCabPrepForm_______
			End Get
			Set
				_alwaysFetchProductoCollectionViaCabPrepForm_______ = value
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
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaCabPrepForm__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaCabPrepForm__]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaCabPrepForm__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaCabPrepForm__. When set to true, PlazaCollectionViaCabPrepForm__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaCabPrepForm__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaCabPrepForm__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaCabPrepForm__ As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaCabPrepForm__
			End Get
			Set
				_alwaysFetchPlazaCollectionViaCabPrepForm__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaCabPrepForm___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaCabPrepForm___]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaCabPrepForm___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaCabPrepForm___. When set to true, PlazaCollectionViaCabPrepForm___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaCabPrepForm___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaCabPrepForm___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaCabPrepForm___ As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaCabPrepForm___
			End Get
			Set
				_alwaysFetchPlazaCollectionViaCabPrepForm___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaCabProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaCabProMed]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaCabProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaCabProMed. When set to true, AlmacenCollectionViaCabProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaCabProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaCabProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaCabProMed As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaCabProMed
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaCabProMed = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViainventarioMovimientosAlmacenDetalles]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViainventarioMovimientosAlmacenDetalles. When set to true, ProductoCollectionViainventarioMovimientosAlmacenDetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViainventarioMovimientosAlmacenDetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViainventarioMovimientosAlmacenDetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles As Boolean
			Get
				Return _alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles
			End Get
			Set
				_alwaysFetchProductoCollectionViainventarioMovimientosAlmacenDetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada___ = value
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
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenSalida]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenSalida. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenSalida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenSalida is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenSalida_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenSalida_. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenSalida_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenSalida__]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenSalida__. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenSalida__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenSalida___]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenSalida___. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenSalida___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenSalida___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenSalida___ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Almacen]() As AlmacenEntity
			Get
				Return GetSingleAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _almacen Is Nothing Then
							_almacen.UnsetRelatedEntity(Me, "InventarioMovimientoAlmacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "InventarioMovimientoAlmacen")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen. When set to true, Almacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacen
			End Get
			Set
				_alwaysFetchAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Almacen is not found
		''' in the database. When set to true, Almacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _almacenReturnsNewIfNotFound
			End Get
			Set
				_almacenReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'TipoMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoMovimientoAlmacen]() As TipoMovimientoAlmacenEntity
			Get
				Return GetSingleTipoMovimientoAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoMovimientoAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _tipoMovimientoAlmacen Is Nothing Then
							_tipoMovimientoAlmacen.UnsetRelatedEntity(Me, "InventarioMovimientoAlmacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "InventarioMovimientoAlmacen")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMovimientoAlmacen. When set to true, TipoMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchTipoMovimientoAlmacen
			End Get
			Set
				_alwaysFetchTipoMovimientoAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoMovimientoAlmacen is not found
		''' in the database. When set to true, TipoMovimientoAlmacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoMovimientoAlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _tipoMovimientoAlmacenReturnsNewIfNotFound
			End Get
			Set
				_tipoMovimientoAlmacenReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity)
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
