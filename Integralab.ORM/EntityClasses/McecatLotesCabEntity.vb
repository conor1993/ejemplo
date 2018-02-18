' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:42
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
	''' <summary>Entity class which represents the entity 'McecatLotesCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McecatLotesCabEntity 
#Else
	<Serializable()> _
	Public Class McecatLotesCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMediDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDet, _alreadyFetchedAplicMediDet As Boolean
		Private _aplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
		Private _alwaysFetchAplicMediDetDet, _alreadyFetchedAplicMediDetDet As Boolean
		Private _cierreLote As Integralab.ORM.CollectionClasses.CierreLoteCollection
		Private _alwaysFetchCierreLote, _alreadyFetchedCierreLote As Boolean
		Private _detAplFor As Integralab.ORM.CollectionClasses.DetAplForCollection
		Private _alwaysFetchDetAplFor, _alreadyFetchedDetAplFor As Boolean
		Private _detDproMed As Integralab.ORM.CollectionClasses.DetDproMedCollection
		Private _alwaysFetchDetDproMed, _alreadyFetchedDetDproMed As Boolean
		Private _mcecatLotesCabFor As Integralab.ORM.CollectionClasses.McecatLotesCabForCollection
		Private _alwaysFetchMcecatLotesCabFor, _alreadyFetchedMcecatLotesCabFor As Boolean
		Private _mcecatLotesDet As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
		Private _alwaysFetchMcecatLotesDet, _alreadyFetchedMcecatLotesDet As Boolean
		Private _prorraRec As Integralab.ORM.CollectionClasses.ProrraRecCollection
		Private _alwaysFetchProrraRec, _alreadyFetchedProrraRec As Boolean
		Private _salidaGanadoCab As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab As Boolean
		Private _salidaGanadoDet As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
		Private _alwaysFetchSalidaGanadoDet, _alreadyFetchedSalidaGanadoDet As Boolean
		Private _aplicMediCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDet, _alreadyFetchedAplicMediCollectionViaAplicMediDet As Boolean
		Private _productoCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDet, _alreadyFetchedProductoCollectionViaAplicMediDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet As Boolean
		Private _aplicMediCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediCollectionViaAplicMediDetDet As Boolean
		Private _aplicMediDetCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet As Boolean
		Private _productoCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDetDet, _alreadyFetchedProductoCollectionViaAplicMediDetDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
		Private _cabAplForCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplForCollectionViaDetAplFor, _alreadyFetchedCabAplForCollectionViaDetAplFor As Boolean
		Private _productoCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetAplFor, _alreadyFetchedProductoCollectionViaDetAplFor As Boolean
		Private _mcecatCorralesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor, _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor As Boolean
		Private _cabProMedCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.CabProMedCollection
		Private _alwaysFetchCabProMedCollectionViaDetDproMed, _alreadyFetchedCabProMedCollectionViaDetDproMed As Boolean
		Private _detProMedCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.DetProMedCollection
		Private _alwaysFetchDetProMedCollectionViaDetDproMed, _alreadyFetchedDetProMedCollectionViaDetDproMed As Boolean
		Private _productoCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetDproMed, _alreadyFetchedProductoCollectionViaDetDproMed As Boolean
		Private _productoCollectionViaMcecatLotesCabFor As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcecatLotesCabFor, _alreadyFetchedProductoCollectionViaMcecatLotesCabFor As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaMcecatLotesDet As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet As Boolean
		Private _mcecatCorralesCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaProrraRec, _alreadyFetchedMcecatCorralesCabCollectionViaProrraRec As Boolean
		Private _salidaGanadoCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaProrraRec, _alreadyFetchedSalidaGanadoCabCollectionViaProrraRec As Boolean
		Private _cabMovGanCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab, _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab As Boolean
		Private _mcgcatCausasMuerteCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
		Private _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab, _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab As Boolean
		Private _catRastrosCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab, _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatCorralesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
		Private _polizaCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaSalidaGanadoCab, _alreadyFetchedPolizaCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatLotesDetCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
		Private _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet, _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet As Boolean
		Private _salidaGanadoCabCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet, _alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet As Boolean
		Private _cierreLote_ As CierreLoteEntity
		Private _alwaysFetchCierreLote_, _alreadyFetchedCierreLote_, _cierreLote_ReturnsNewIfNotFound As Boolean
		Private _mcecatCorralesCab As McecatCorralesCabEntity
		Private _alwaysFetchMcecatCorralesCab, _alreadyFetchedMcecatCorralesCab, _mcecatCorralesCabReturnsNewIfNotFound As Boolean
		Private _cierreFicticio As CierreFicticioEntity
		Private _alwaysFetchCierreFicticio, _alreadyFetchedCierreFicticio, _cierreFicticioReturnsNewIfNotFound As Boolean

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
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		Public Sub New(idLote As System.Int32)

			InitClassFetch(idLote, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idLote As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idLote, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="validator">The custom validator Object for this McecatLotesCabEntity</param>
		Public Sub New(idLote As System.Int32, validator As IValidator)

			InitClassFetch(idLote, validator, Nothing)
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
			_cierreLote = CType(info.GetValue("_cierreLote", GetType(Integralab.ORM.CollectionClasses.CierreLoteCollection)), Integralab.ORM.CollectionClasses.CierreLoteCollection)
			_alwaysFetchCierreLote = info.GetBoolean("_alwaysFetchCierreLote")
			_alreadyFetchedCierreLote = info.GetBoolean("_alreadyFetchedCierreLote")
			_detAplFor = CType(info.GetValue("_detAplFor", GetType(Integralab.ORM.CollectionClasses.DetAplForCollection)), Integralab.ORM.CollectionClasses.DetAplForCollection)
			_alwaysFetchDetAplFor = info.GetBoolean("_alwaysFetchDetAplFor")
			_alreadyFetchedDetAplFor = info.GetBoolean("_alreadyFetchedDetAplFor")
			_detDproMed = CType(info.GetValue("_detDproMed", GetType(Integralab.ORM.CollectionClasses.DetDproMedCollection)), Integralab.ORM.CollectionClasses.DetDproMedCollection)
			_alwaysFetchDetDproMed = info.GetBoolean("_alwaysFetchDetDproMed")
			_alreadyFetchedDetDproMed = info.GetBoolean("_alreadyFetchedDetDproMed")
			_mcecatLotesCabFor = CType(info.GetValue("_mcecatLotesCabFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabForCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabForCollection)
			_alwaysFetchMcecatLotesCabFor = info.GetBoolean("_alwaysFetchMcecatLotesCabFor")
			_alreadyFetchedMcecatLotesCabFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabFor")
			_mcecatLotesDet = CType(info.GetValue("_mcecatLotesDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesDetCollection)), Integralab.ORM.CollectionClasses.McecatLotesDetCollection)
			_alwaysFetchMcecatLotesDet = info.GetBoolean("_alwaysFetchMcecatLotesDet")
			_alreadyFetchedMcecatLotesDet = info.GetBoolean("_alreadyFetchedMcecatLotesDet")
			_prorraRec = CType(info.GetValue("_prorraRec", GetType(Integralab.ORM.CollectionClasses.ProrraRecCollection)), Integralab.ORM.CollectionClasses.ProrraRecCollection)
			_alwaysFetchProrraRec = info.GetBoolean("_alwaysFetchProrraRec")
			_alreadyFetchedProrraRec = info.GetBoolean("_alreadyFetchedProrraRec")
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_salidaGanadoDet = CType(info.GetValue("_salidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)
			_alwaysFetchSalidaGanadoDet = info.GetBoolean("_alwaysFetchSalidaGanadoDet")
			_alreadyFetchedSalidaGanadoDet = info.GetBoolean("_alreadyFetchedSalidaGanadoDet")
			_aplicMediCollectionViaAplicMediDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDet")
			_productoCollectionViaAplicMediDet = CType(info.GetValue("_productoCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDet")
			_alreadyFetchedProductoCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDet")
			_mcecatCorralesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet")
			_aplicMediCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet")
			_aplicMediDetCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediDetCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetCollection)
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet")
			_productoCollectionViaAplicMediDetDet = CType(info.GetValue("_productoCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDetDet")
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDetDet")
			_mcecatCorralesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet")
			_cabAplForCollectionViaDetAplFor = CType(info.GetValue("_cabAplForCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplForCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchCabAplForCollectionViaDetAplFor")
			_alreadyFetchedCabAplForCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedCabAplForCollectionViaDetAplFor")
			_productoCollectionViaDetAplFor = CType(info.GetValue("_productoCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchProductoCollectionViaDetAplFor")
			_alreadyFetchedProductoCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetAplFor")
			_mcecatCorralesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatCorralesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor")
			_cabProMedCollectionViaDetDproMed = CType(info.GetValue("_cabProMedCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.CabProMedCollection)), Integralab.ORM.CollectionClasses.CabProMedCollection)
			_alwaysFetchCabProMedCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchCabProMedCollectionViaDetDproMed")
			_alreadyFetchedCabProMedCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedCabProMedCollectionViaDetDproMed")
			_detProMedCollectionViaDetDproMed = CType(info.GetValue("_detProMedCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.DetProMedCollection)), Integralab.ORM.CollectionClasses.DetProMedCollection)
			_alwaysFetchDetProMedCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchDetProMedCollectionViaDetDproMed")
			_alreadyFetchedDetProMedCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedDetProMedCollectionViaDetDproMed")
			_productoCollectionViaDetDproMed = CType(info.GetValue("_productoCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchProductoCollectionViaDetDproMed")
			_alreadyFetchedProductoCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetDproMed")
			_productoCollectionViaMcecatLotesCabFor = CType(info.GetValue("_productoCollectionViaMcecatLotesCabFor", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcecatLotesCabFor = info.GetBoolean("_alwaysFetchProductoCollectionViaMcecatLotesCabFor")
			_alreadyFetchedProductoCollectionViaMcecatLotesCabFor = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcecatLotesCabFor")
			_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet")
			_mcecatCorralesCabCollectionViaProrraRec = CType(info.GetValue("_mcecatCorralesCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaProrraRec")
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec")
			_salidaGanadoCabCollectionViaProrraRec = CType(info.GetValue("_salidaGanadoCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaProrraRec")
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec")
			_cabMovGanCollectionViaSalidaGanadoCab = CType(info.GetValue("_cabMovGanCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab")
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab")
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcgcatCausasMuerteCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection)), Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection)
			_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab")
			_catRastrosCollectionViaSalidaGanadoCab = CType(info.GetValue("_catRastrosCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CatRastrosCollection)), Integralab.ORM.CollectionClasses.CatRastrosCollection)
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab")
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab")
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_polizaCollectionViaSalidaGanadoCab = CType(info.GetValue("_polizaCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchPolizaCollectionViaSalidaGanadoCab")
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab")
			_mcecatLotesDetCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesDetCollection)), Integralab.ORM.CollectionClasses.McecatLotesDetCollection)
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet")
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet")
			_salidaGanadoCabCollectionViaSalidaGanadoDet = CType(info.GetValue("_salidaGanadoCabCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet")
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet")
			_cierreLote_ = CType(info.GetValue("_cierreLote_", GetType(CierreLoteEntity)), CierreLoteEntity)
			If Not _cierreLote_ Is Nothing Then
				AddHandler _cierreLote_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cierreLote_ReturnsNewIfNotFound = info.GetBoolean("_cierreLote_ReturnsNewIfNotFound")
			_alwaysFetchCierreLote_ = info.GetBoolean("_alwaysFetchCierreLote_")
			_alreadyFetchedCierreLote_ = info.GetBoolean("_alreadyFetchedCierreLote_")
			_mcecatCorralesCab = CType(info.GetValue("_mcecatCorralesCab", GetType(McecatCorralesCabEntity)), McecatCorralesCabEntity)
			If Not _mcecatCorralesCab Is Nothing Then
				AddHandler _mcecatCorralesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatCorralesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatCorralesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatCorralesCab = info.GetBoolean("_alwaysFetchMcecatCorralesCab")
			_alreadyFetchedMcecatCorralesCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCab")
			_cierreFicticio = CType(info.GetValue("_cierreFicticio", GetType(CierreFicticioEntity)), CierreFicticioEntity)
			If Not _cierreFicticio Is Nothing Then
				' rewire event handler.
				AddHandler _cierreFicticio.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cierreFicticioReturnsNewIfNotFound = info.GetBoolean("_cierreFicticioReturnsNewIfNotFound")
			_alwaysFetchCierreFicticio = info.GetBoolean("_alwaysFetchCierreFicticio")
			_alreadyFetchedCierreFicticio = info.GetBoolean("_alreadyFetchedCierreFicticio")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMediDet = (_aplicMediDet.Count > 0)
			_alreadyFetchedAplicMediDetDet = (_aplicMediDetDet.Count > 0)
			_alreadyFetchedCierreLote = (_cierreLote.Count > 0)
			_alreadyFetchedDetAplFor = (_detAplFor.Count > 0)
			_alreadyFetchedDetDproMed = (_detDproMed.Count > 0)
			_alreadyFetchedMcecatLotesCabFor = (_mcecatLotesCabFor.Count > 0)
			_alreadyFetchedMcecatLotesDet = (_mcecatLotesDet.Count > 0)
			_alreadyFetchedProrraRec = (_prorraRec.Count > 0)
			_alreadyFetchedSalidaGanadoCab = (_salidaGanadoCab.Count > 0)
			_alreadyFetchedSalidaGanadoDet = (_salidaGanadoDet.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = (_aplicMediCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDet = (_productoCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = (_mcecatCorralesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = (_aplicMediCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = (_aplicMediDetCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = (_productoCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = (_mcecatCorralesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedCabAplForCollectionViaDetAplFor = (_cabAplForCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedProductoCollectionViaDetAplFor = (_productoCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = (_mcecatCorralesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedCabProMedCollectionViaDetDproMed = (_cabProMedCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedDetProMedCollectionViaDetDproMed = (_detProMedCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedProductoCollectionViaDetDproMed = (_productoCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedProductoCollectionViaMcecatLotesCabFor = (_productoCollectionViaMcecatLotesCabFor.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = (_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = (_mcecatCorralesCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = (_salidaGanadoCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = (_cabMovGanCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = (_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = (_catRastrosCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = (_mcecatCorralesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = (_polizaCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = (_mcecatLotesDetCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = (_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = (_salidaGanadoCabCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedCierreLote_ = Not(_cierreLote_ Is Nothing)
			_alreadyFetchedMcecatCorralesCab = Not(_mcecatCorralesCab Is Nothing)
			_alreadyFetchedCierreFicticio = Not(_cierreFicticio Is Nothing)
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
			info.AddValue("_cierreLote", _cierreLote)
			info.AddValue("_alwaysFetchCierreLote", _alwaysFetchCierreLote)
			info.AddValue("_alreadyFetchedCierreLote", _alreadyFetchedCierreLote)
			info.AddValue("_detAplFor", _detAplFor)
			info.AddValue("_alwaysFetchDetAplFor", _alwaysFetchDetAplFor)
			info.AddValue("_alreadyFetchedDetAplFor", _alreadyFetchedDetAplFor)
			info.AddValue("_detDproMed", _detDproMed)
			info.AddValue("_alwaysFetchDetDproMed", _alwaysFetchDetDproMed)
			info.AddValue("_alreadyFetchedDetDproMed", _alreadyFetchedDetDproMed)
			info.AddValue("_mcecatLotesCabFor", _mcecatLotesCabFor)
			info.AddValue("_alwaysFetchMcecatLotesCabFor", _alwaysFetchMcecatLotesCabFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabFor", _alreadyFetchedMcecatLotesCabFor)
			info.AddValue("_mcecatLotesDet", _mcecatLotesDet)
			info.AddValue("_alwaysFetchMcecatLotesDet", _alwaysFetchMcecatLotesDet)
			info.AddValue("_alreadyFetchedMcecatLotesDet", _alreadyFetchedMcecatLotesDet)
			info.AddValue("_prorraRec", _prorraRec)
			info.AddValue("_alwaysFetchProrraRec", _alwaysFetchProrraRec)
			info.AddValue("_alreadyFetchedProrraRec", _alreadyFetchedProrraRec)
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_salidaGanadoDet", _salidaGanadoDet)
			info.AddValue("_alwaysFetchSalidaGanadoDet", _alwaysFetchSalidaGanadoDet)
			info.AddValue("_alreadyFetchedSalidaGanadoDet", _alreadyFetchedSalidaGanadoDet)
			info.AddValue("_aplicMediCollectionViaAplicMediDet", _aplicMediCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDet", _alwaysFetchAplicMediCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDet", _alreadyFetchedAplicMediCollectionViaAplicMediDet)
			info.AddValue("_productoCollectionViaAplicMediDet", _productoCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDet", _alwaysFetchProductoCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDet", _alreadyFetchedProductoCollectionViaAplicMediDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDet", _mcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_aplicMediCollectionViaAplicMediDetDet", _aplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDetDet", _alwaysFetchAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_aplicMediDetCollectionViaAplicMediDetDet", _aplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet", _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_productoCollectionViaAplicMediDetDet", _productoCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDetDet", _alwaysFetchProductoCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDetDet", _alreadyFetchedProductoCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", _mcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_cabAplForCollectionViaDetAplFor", _cabAplForCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchCabAplForCollectionViaDetAplFor", _alwaysFetchCabAplForCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedCabAplForCollectionViaDetAplFor", _alreadyFetchedCabAplForCollectionViaDetAplFor)
			info.AddValue("_productoCollectionViaDetAplFor", _productoCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchProductoCollectionViaDetAplFor", _alwaysFetchProductoCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetAplFor", _alreadyFetchedProductoCollectionViaDetAplFor)
			info.AddValue("_mcecatCorralesCabCollectionViaDetAplFor", _mcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor", _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor", _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_cabProMedCollectionViaDetDproMed", _cabProMedCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchCabProMedCollectionViaDetDproMed", _alwaysFetchCabProMedCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedCabProMedCollectionViaDetDproMed", _alreadyFetchedCabProMedCollectionViaDetDproMed)
			info.AddValue("_detProMedCollectionViaDetDproMed", _detProMedCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchDetProMedCollectionViaDetDproMed", _alwaysFetchDetProMedCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedDetProMedCollectionViaDetDproMed", _alreadyFetchedDetProMedCollectionViaDetDproMed)
			info.AddValue("_productoCollectionViaDetDproMed", _productoCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchProductoCollectionViaDetDproMed", _alwaysFetchProductoCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetDproMed", _alreadyFetchedProductoCollectionViaDetDproMed)
			info.AddValue("_productoCollectionViaMcecatLotesCabFor", _productoCollectionViaMcecatLotesCabFor)
			info.AddValue("_alwaysFetchProductoCollectionViaMcecatLotesCabFor", _alwaysFetchProductoCollectionViaMcecatLotesCabFor)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcecatLotesCabFor", _alreadyFetchedProductoCollectionViaMcecatLotesCabFor)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet", _mcgcatTiposdeGanadoCollectionViaMcecatLotesDet)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet", _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet)
			info.AddValue("_mcecatCorralesCabCollectionViaProrraRec", _mcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaProrraRec", _alwaysFetchMcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec", _alreadyFetchedMcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_salidaGanadoCabCollectionViaProrraRec", _salidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaProrraRec", _alwaysFetchSalidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec", _alreadyFetchedSalidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_cabMovGanCollectionViaSalidaGanadoCab", _cabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab", _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab", _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_mcgcatCausasMuerteCollectionViaSalidaGanadoCab", _mcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab", _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab", _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_catRastrosCollectionViaSalidaGanadoCab", _catRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab", _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab", _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", _mcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab", _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab", _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_polizaCollectionViaSalidaGanadoCab", _polizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchPolizaCollectionViaSalidaGanadoCab", _alwaysFetchPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab", _alreadyFetchedPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", _mcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet", _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet", _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_salidaGanadoCabCollectionViaSalidaGanadoDet", _salidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet", _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet", _alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_cierreLote_", _cierreLote_)
			info.AddValue("_cierreLote_ReturnsNewIfNotFound", _cierreLote_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCierreLote_", _alwaysFetchCierreLote_)
			info.AddValue("_alreadyFetchedCierreLote_", _alreadyFetchedCierreLote_)
			info.AddValue("_mcecatCorralesCab", _mcecatCorralesCab)
			info.AddValue("_mcecatCorralesCabReturnsNewIfNotFound", _mcecatCorralesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatCorralesCab", _alwaysFetchMcecatCorralesCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCab", _alreadyFetchedMcecatCorralesCab)
			info.AddValue("_cierreFicticio", _cierreFicticio)
			info.AddValue("_cierreFicticioReturnsNewIfNotFound", _cierreFicticioReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCierreFicticio", _alwaysFetchCierreFicticio)
			info.AddValue("_alreadyFetchedCierreFicticio", _alreadyFetchedCierreFicticio)
			
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
				Case "CierreLote_"
					_alreadyFetchedCierreLote_ = True
					Me.CierreLote_ = CType(entity, CierreLoteEntity)
				Case "McecatCorralesCab"
					_alreadyFetchedMcecatCorralesCab = True
					Me.McecatCorralesCab = CType(entity, McecatCorralesCabEntity)
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
				Case "CierreLote"
					_alreadyFetchedCierreLote = True
					If Not entity Is Nothing Then
						Me.CierreLote.Add(CType(entity, CierreLoteEntity))
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
				Case "McecatLotesCabFor"
					_alreadyFetchedMcecatLotesCabFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabFor.Add(CType(entity, McecatLotesCabForEntity))
					End If
				Case "McecatLotesDet"
					_alreadyFetchedMcecatLotesDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesDet.Add(CType(entity, McecatLotesDetEntity))
					End If
				Case "ProrraRec"
					_alreadyFetchedProrraRec = True
					If Not entity Is Nothing Then
						Me.ProrraRec.Add(CType(entity, ProrraRecEntity))
					End If
				Case "SalidaGanadoCab"
					_alreadyFetchedSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCab.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "SalidaGanadoDet"
					_alreadyFetchedSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoDet.Add(CType(entity, SalidaGanadoDetEntity))
					End If
				Case "AplicMediCollectionViaAplicMediDet"
					_alreadyFetchedAplicMediCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.AplicMediCollectionViaAplicMediDet.Add(CType(entity, AplicMediEntity))
					End If
				Case "ProductoCollectionViaAplicMediDet"
					_alreadyFetchedProductoCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaAplicMediDet.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDet.Add(CType(entity, McecatCorralesCabEntity))
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
				Case "ProductoCollectionViaAplicMediDetDet"
					_alreadyFetchedProductoCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaAplicMediDetDet.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "CabAplForCollectionViaDetAplFor"
					_alreadyFetchedCabAplForCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.CabAplForCollectionViaDetAplFor.Add(CType(entity, CabAplForEntity))
					End If
				Case "ProductoCollectionViaDetAplFor"
					_alreadyFetchedProductoCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetAplFor.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaDetAplFor.Add(CType(entity, McecatCorralesCabEntity))
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
				Case "ProductoCollectionViaDetDproMed"
					_alreadyFetchedProductoCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetDproMed.Add(CType(entity, ProductoEntity))
					End If
				Case "ProductoCollectionViaMcecatLotesCabFor"
					_alreadyFetchedProductoCollectionViaMcecatLotesCabFor = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMcecatLotesCabFor.Add(CType(entity, ProductoEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaMcecatLotesDet"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaMcecatLotesDet.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "McecatCorralesCabCollectionViaProrraRec"
					_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaProrraRec.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "SalidaGanadoCabCollectionViaProrraRec"
					_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCabCollectionViaProrraRec.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "CabMovGanCollectionViaSalidaGanadoCab"
					_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaSalidaGanadoCab.Add(CType(entity, CabMovGanEntity))
					End If
				Case "McgcatCausasMuerteCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McgcatCausasMuerteCollectionViaSalidaGanadoCab.Add(CType(entity, McgcatCausasMuerteEntity))
					End If
				Case "CatRastrosCollectionViaSalidaGanadoCab"
					_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.CatRastrosCollectionViaSalidaGanadoCab.Add(CType(entity, CatRastrosEntity))
					End If
				Case "McecatCorralesCabCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaSalidaGanadoCab.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "PolizaCollectionViaSalidaGanadoCab"
					_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaSalidaGanadoCab.Add(CType(entity, PolizaEntity))
					End If
				Case "McecatLotesDetCollectionViaSalidaGanadoDet"
					_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesDetCollectionViaSalidaGanadoDet.Add(CType(entity, McecatLotesDetEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaSalidaGanadoDet"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaSalidaGanadoDet.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "SalidaGanadoCabCollectionViaSalidaGanadoDet"
					_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCabCollectionViaSalidaGanadoDet.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "CierreFicticio"
					_alreadyFetchedCierreFicticio = True
					Me.CierreFicticio = CType(entity, CierreFicticioEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CierreLote_"
					SetupSyncCierreLote_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					SetupSyncMcecatCorralesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDet"
					_aplicMediDet.Add(CType(relatedEntity, AplicMediDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					_aplicMediDetDet.Add(CType(relatedEntity, AplicMediDetDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CierreLote"
					_cierreLote.Add(CType(relatedEntity, CierreLoteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAplFor"
					_detAplFor.Add(CType(relatedEntity, DetAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetDproMed"
					_detDproMed.Add(CType(relatedEntity, DetDproMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCabFor"
					_mcecatLotesCabFor.Add(CType(relatedEntity, McecatLotesCabForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesDet"
					_mcecatLotesDet.Add(CType(relatedEntity, McecatLotesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProrraRec"
					_prorraRec.Add(CType(relatedEntity, ProrraRecEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					_salidaGanadoCab.Add(CType(relatedEntity, SalidaGanadoCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					_salidaGanadoDet.Add(CType(relatedEntity, SalidaGanadoDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CierreFicticio"
					SetupSyncCierreFicticio(relatedEntity)
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
				Case "CierreLote_"
					DesetupSyncCierreLote_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					DesetupSyncMcecatCorralesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDetDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CierreLote"
					MyBase.PerformRelatedEntityRemoval(_cierreLote, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAplFor"
					MyBase.PerformRelatedEntityRemoval(_detAplFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetDproMed"
					MyBase.PerformRelatedEntityRemoval(_detDproMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCabFor"
					MyBase.PerformRelatedEntityRemoval(_mcecatLotesCabFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesDet"
					MyBase.PerformRelatedEntityRemoval(_mcecatLotesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProrraRec"
					MyBase.PerformRelatedEntityRemoval(_prorraRec, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CierreFicticio"
					DesetupSyncCierreFicticio(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()

			If Not _cierreFicticio Is Nothing Then
				toReturn.Add(_cierreFicticio)
			End If


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _cierreLote_ Is Nothing Then
				toReturn.Add(_cierreLote_)
			End If
			If Not _mcecatCorralesCab Is Nothing Then
				toReturn.Add(_mcecatCorralesCab)
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
			toReturn.Add(_cierreLote)
			toReturn.Add(_detAplFor)
			toReturn.Add(_detDproMed)
			toReturn.Add(_mcecatLotesCabFor)
			toReturn.Add(_mcecatLotesDet)
			toReturn.Add(_prorraRec)
			toReturn.Add(_salidaGanadoCab)
			toReturn.Add(_salidaGanadoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLote As System.Int32) As Boolean
			Return FetchUsingPK(idLote, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLote As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idLote, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idLote As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idLote, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdLote, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McecatLotesCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McecatLotesCabFieldIndex) As Boolean
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
				_aplicMediDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
				_aplicMediDetDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CierreLoteEntity'</returns>
		Public Function GetMultiCierreLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Return GetMultiCierreLote(forceFetch, _cierreLote.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCierreLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Return GetMultiCierreLote(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CierreLoteEntity'</returns>
		Public Function GetMultiCierreLote(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Return GetMultiCierreLote(forceFetch, _cierreLote.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCierreLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			If ( Not _alreadyFetchedCierreLote Or forceFetch Or _alwaysFetchCierreLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cierreLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cierreLote)
					End If
				End If
				_cierreLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cierreLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_cierreLote.GetMultiManyToOne(Me, Filter)
				_cierreLote.SuppressClearInGetMulti = False
				_alreadyFetchedCierreLote = True
			End If
			Return _cierreLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CierreLote'. These settings will be taken into account
		''' when the property CierreLote is requested or GetMultiCierreLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCierreLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cierreLote.SortClauses=sortClauses
			_cierreLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_detAplFor.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
				_detDproMed.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
				_mcecatLotesCabFor.GetMultiManyToOne(Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesDetEntity'</returns>
		Public Function GetMultiMcecatLotesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Return GetMultiMcecatLotesDet(forceFetch, _mcecatLotesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcecatLotesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Return GetMultiMcecatLotesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesDetEntity'</returns>
		Public Function GetMultiMcecatLotesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Return GetMultiMcecatLotesDet(forceFetch, _mcecatLotesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			If ( Not _alreadyFetchedMcecatLotesDet Or forceFetch Or _alwaysFetchMcecatLotesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesDet)
					End If
				End If
				_mcecatLotesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesDet.GetMultiManyToOne(Me, Nothing, Filter)
				_mcecatLotesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesDet = True
			End If
			Return _mcecatLotesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesDet'. These settings will be taken into account
		''' when the property McecatLotesDet is requested or GetMultiMcecatLotesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesDet.SortClauses=sortClauses
			_mcecatLotesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProrraRecEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProrraRecEntity'</returns>
		Public Function GetMultiProrraRec(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProrraRecCollection
			Return GetMultiProrraRec(forceFetch, _prorraRec.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProrraRecEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProrraRec(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProrraRecCollection
			Return GetMultiProrraRec(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProrraRecEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProrraRecEntity'</returns>
		Public Function GetMultiProrraRec(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProrraRecCollection
			Return GetMultiProrraRec(forceFetch, _prorraRec.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProrraRecEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProrraRec(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProrraRecCollection
			If ( Not _alreadyFetchedProrraRec Or forceFetch Or _alwaysFetchProrraRec) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _prorraRec.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_prorraRec)
					End If
				End If
				_prorraRec.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_prorraRec.EntityFactoryToUse = entityFactoryToUse
				End If
				_prorraRec.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_prorraRec.SuppressClearInGetMulti = False
				_alreadyFetchedProrraRec = True
			End If
			Return _prorraRec
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProrraRec'. These settings will be taken into account
		''' when the property ProrraRec is requested or GetMultiProrraRec is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProrraRec(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_prorraRec.SortClauses=sortClauses
			_prorraRec.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, _salidaGanadoCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, _salidaGanadoCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCab Or forceFetch Or _alwaysFetchSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCab)
					End If
				End If
				_salidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCab.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_salidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCab = True
			End If
			Return _salidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCab'. These settings will be taken into account
		''' when the property SalidaGanadoCab is requested or GetMultiSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCab.SortClauses=sortClauses
			_salidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoDetEntity'</returns>
		Public Function GetMultiSalidaGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
			Return GetMultiSalidaGanadoDet(forceFetch, _salidaGanadoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
			Return GetMultiSalidaGanadoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoDetEntity'</returns>
		Public Function GetMultiSalidaGanadoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
			Return GetMultiSalidaGanadoDet(forceFetch, _salidaGanadoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
			If ( Not _alreadyFetchedSalidaGanadoDet Or forceFetch Or _alwaysFetchSalidaGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoDet)
					End If
				End If
				_salidaGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoDet.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_salidaGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoDet = True
			End If
			Return _salidaGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoDet'. These settings will be taken into account
		''' when the property SalidaGanadoDet is requested or GetMultiSalidaGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoDet.SortClauses=sortClauses
			_salidaGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaAplicMediDet(forceFetch, _productoCollectionViaAplicMediDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaAplicMediDet Or forceFetch Or _alwaysFetchProductoCollectionViaAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaAplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaAplicMediDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_productoCollectionViaAplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaAplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaAplicMediDet.GetMulti(Filter, relations)
				_productoCollectionViaAplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaAplicMediDet = True
			End If
			Return _productoCollectionViaAplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaAplicMediDet'. These settings will be taken into account
		''' when the property ProductoCollectionViaAplicMediDet is requested or GetMultiProductoCollectionViaAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaAplicMediDet.SortClauses=sortClauses
			_productoCollectionViaAplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaAplicMediDetDet(forceFetch, _productoCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchProductoCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_productoCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_productoCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaAplicMediDetDet = True
			End If
			Return _productoCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property ProductoCollectionViaAplicMediDetDet is requested or GetMultiProductoCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_productoCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetAplFor(forceFetch, _productoCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetAplFor Or forceFetch Or _alwaysFetchProductoCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_productoCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetAplFor.GetMulti(Filter, relations)
				_productoCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetAplFor = True
			End If
			Return _productoCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetAplFor is requested or GetMultiProductoCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetAplFor.SortClauses=sortClauses
			_productoCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetDproMed(forceFetch, _productoCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetDproMed Or forceFetch Or _alwaysFetchProductoCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.ProductoEntityUsingIdMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_productoCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetDproMed.GetMulti(Filter, relations)
				_productoCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetDproMed = True
			End If
			Return _productoCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetDproMed is requested or GetMultiProductoCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetDproMed.SortClauses=sortClauses
			_productoCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMcecatLotesCabFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMcecatLotesCabFor(forceFetch, _productoCollectionViaMcecatLotesCabFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMcecatLotesCabFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMcecatLotesCabFor Or forceFetch Or _alwaysFetchProductoCollectionViaMcecatLotesCabFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMcecatLotesCabFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMcecatLotesCabFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.McecatLotesCabForEntityUsingIdLote, "__McecatLotesCabEntity__", "McecatLotesCabFor_", JoinHint.None)
				relations.Add(McecatLotesCabForEntity.Relations.ProductoEntityUsingIdFormula, "McecatLotesCabFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_productoCollectionViaMcecatLotesCabFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMcecatLotesCabFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMcecatLotesCabFor.GetMulti(Filter, relations)
				_productoCollectionViaMcecatLotesCabFor.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMcecatLotesCabFor = True
			End If
			Return _productoCollectionViaMcecatLotesCabFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMcecatLotesCabFor'. These settings will be taken into account
		''' when the property ProductoCollectionViaMcecatLotesCabFor is requested or GetMultiProductoCollectionViaMcecatLotesCabFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMcecatLotesCabFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMcecatLotesCabFor.SortClauses=sortClauses
			_productoCollectionViaMcecatLotesCabFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(forceFetch, _mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.McecatLotesDetEntityUsingIdLote, "__McecatLotesCabEntity__", "McecatLotesDet_", JoinHint.None)
				relations.Add(McecatLotesDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "McecatLotesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaMcecatLotesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaMcecatLotesDet'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaMcecatLotesDet is requested or GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaProrraRec(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaProrraRec(forceFetch, _mcecatCorralesCabCollectionViaProrraRec.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaProrraRec(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaProrraRec Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaProrraRec) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaProrraRec.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaProrraRec)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, "__McecatLotesCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatCorralesCabEntityUsingIdCorralReciba, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcecatCorralesCabCollectionViaProrraRec.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaProrraRec.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaProrraRec.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaProrraRec.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = True
			End If
			Return _mcecatCorralesCabCollectionViaProrraRec
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaProrraRec'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaProrraRec is requested or GetMultiMcecatCorralesCabCollectionViaProrraRec is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaProrraRec(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaProrraRec.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaProrraRec.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCabCollectionViaProrraRec(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCabCollectionViaProrraRec(forceFetch, _salidaGanadoCabCollectionViaProrraRec.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCabCollectionViaProrraRec(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCabCollectionViaProrraRec Or forceFetch Or _alwaysFetchSalidaGanadoCabCollectionViaProrraRec) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCabCollectionViaProrraRec.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCabCollectionViaProrraRec)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, "__McecatLotesCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_salidaGanadoCabCollectionViaProrraRec.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCabCollectionViaProrraRec.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCabCollectionViaProrraRec.GetMulti(Filter, relations)
				_salidaGanadoCabCollectionViaProrraRec.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = True
			End If
			Return _salidaGanadoCabCollectionViaProrraRec
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCabCollectionViaProrraRec'. These settings will be taken into account
		''' when the property SalidaGanadoCabCollectionViaProrraRec is requested or GetMultiSalidaGanadoCabCollectionViaProrraRec is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCabCollectionViaProrraRec(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCabCollectionViaProrraRec.SortClauses=sortClauses
			_salidaGanadoCabCollectionViaProrraRec.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch, _cabMovGanCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_cabMovGanCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_cabMovGanCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = True
			End If
			Return _cabMovGanCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaSalidaGanadoCab is requested or GetMultiCabMovGanCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_cabMovGanCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatCausasMuerteEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCausasMuerteEntity'</returns>
		Public Function GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
			Return GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab(forceFetch, _mcgcatCausasMuerteCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCausasMuerteEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
			If ( Not _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatCausasMuerteCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatCausasMuerteCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = True
			End If
			Return _mcgcatCausasMuerteCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatCausasMuerteCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property McgcatCausasMuerteCollectionViaSalidaGanadoCab is requested or GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatCausasMuerteCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatRastrosEntity'</returns>
		Public Function GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Return GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch, _catRastrosCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			If ( Not _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catRastrosCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catRastrosCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_catRastrosCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catRastrosCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_catRastrosCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_catRastrosCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = True
			End If
			Return _catRastrosCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatRastrosCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property CatRastrosCollectionViaSalidaGanadoCab is requested or GetMultiCatRastrosCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatRastrosCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catRastrosCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_catRastrosCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch, _mcecatCorralesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = True
			End If
			Return _mcecatCorralesCabCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaSalidaGanadoCab is requested or GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch, _polizaCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchPolizaCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_polizaCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_polizaCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = True
			End If
			Return _polizaCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property PolizaCollectionViaSalidaGanadoCab is requested or GetMultiPolizaCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_polizaCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesDetEntity'</returns>
		Public Function GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Return GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet(forceFetch, _mcecatLotesDetCollectionViaSalidaGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			If ( Not _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet Or forceFetch Or _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesDetCollectionViaSalidaGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesDetCollectionViaSalidaGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcecatLotesDetCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesDetCollectionViaSalidaGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesDetCollectionViaSalidaGanadoDet.GetMulti(Filter, relations)
				_mcecatLotesDetCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = True
			End If
			Return _mcecatLotesDetCollectionViaSalidaGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesDetCollectionViaSalidaGanadoDet'. These settings will be taken into account
		''' when the property McecatLotesDetCollectionViaSalidaGanadoDet is requested or GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesDetCollectionViaSalidaGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesDetCollectionViaSalidaGanadoDet.SortClauses=sortClauses
			_mcecatLotesDetCollectionViaSalidaGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(forceFetch, _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaSalidaGanadoDet'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaSalidaGanadoDet is requested or GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet(forceFetch, _salidaGanadoCabCollectionViaSalidaGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet Or forceFetch Or _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCabCollectionViaSalidaGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCabCollectionViaSalidaGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatLotesCabFieldIndex.IdLote), ComparisonOperator.Equal, Me.IdLote))
				_salidaGanadoCabCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCabCollectionViaSalidaGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCabCollectionViaSalidaGanadoDet.GetMulti(Filter, relations)
				_salidaGanadoCabCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = True
			End If
			Return _salidaGanadoCabCollectionViaSalidaGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCabCollectionViaSalidaGanadoDet'. These settings will be taken into account
		''' when the property SalidaGanadoCabCollectionViaSalidaGanadoDet is requested or GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCabCollectionViaSalidaGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCabCollectionViaSalidaGanadoDet.SortClauses=sortClauses
			_salidaGanadoCabCollectionViaSalidaGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CierreLoteEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CierreLoteEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCierreLote_() As CierreLoteEntity
			Return GetSingleCierreLote_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CierreLoteEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CierreLoteEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCierreLote_(forceFetch As Boolean) As CierreLoteEntity
			If ( Not _alreadyFetchedCierreLote_ Or forceFetch Or _alwaysFetchCierreLote_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CierreLoteEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCierreLote.GetValueOrDefault())
				End If
				If Not _cierreLote_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CierreLote_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CierreLoteEntity)
					End If
					Me.CierreLote_ = newEntity
					_alreadyFetchedCierreLote_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cierreLote_
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab() As McecatCorralesCabEntity
			Return GetSingleMcecatCorralesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab(forceFetch As Boolean) As McecatCorralesCabEntity
			If ( Not _alreadyFetchedMcecatCorralesCab Or forceFetch Or _alwaysFetchMcecatCorralesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatCorralesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCorral)
				End If
				If Not _mcecatCorralesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatCorralesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatCorralesCabEntity)
					End If
					Me.McecatCorralesCab = newEntity
					_alreadyFetchedMcecatCorralesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatCorralesCab
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'CierreFicticioEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'CierreFicticioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCierreFicticio() As CierreFicticioEntity
			Return GetSingleCierreFicticio(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CierreFicticioEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CierreFicticioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCierreFicticio(forceFetch As Boolean) As CierreFicticioEntity
			If ( Not _alreadyFetchedCierreFicticio Or forceFetch Or _alwaysFetchCierreFicticio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New CierreFicticioEntity()
				Dim relation As IEntityRelation = McecatLotesCabEntity.Relations.CierreFicticioEntityUsingIdLote
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdLote)
				End If
				If Not _cierreFicticioReturnsNewIfNotFound And Not fetchResult Then
					Me.CierreFicticio = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CierreFicticioEntity)
					End If
					Me.CierreFicticio = newEntity
					_alreadyFetchedCierreFicticio = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cierreFicticio
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McecatLotesCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McecatLotesCabFieldIndex)

					Case McecatLotesCabFieldIndex.IdCorral
						DesetupSyncMcecatCorralesCab(True, False)
						_alreadyFetchedMcecatCorralesCab = False































					Case McecatLotesCabFieldIndex.IdCierreLote
						DesetupSyncCierreLote_(True, False)
						_alreadyFetchedCierreLote_ = False
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
			_cierreLote.ActiveContext = MyBase.ActiveContext
			_detAplFor.ActiveContext = MyBase.ActiveContext
			_detDproMed.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabFor.ActiveContext = MyBase.ActiveContext
			_mcecatLotesDet.ActiveContext = MyBase.ActiveContext
			_prorraRec.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_salidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_aplicMediDetCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_cabAplForCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_cabProMedCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_detProMedCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcecatLotesCabFor.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatLotesDetCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
		If Not _cierreLote_ Is Nothing Then
				_cierreLote_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatCorralesCab Is Nothing Then
				_mcecatCorralesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cierreFicticio Is Nothing Then
				_cierreFicticio.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McecatLotesCabDAO = CType(CreateDAOInstance(), McecatLotesCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McecatLotesCabDAO = CType(CreateDAOInstance(), McecatLotesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McecatLotesCabDAO = CType(CreateDAOInstance(), McecatLotesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McecatLotesCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McecatLotesCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="validator">The validator Object for this McecatLotesCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idLote As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idLote, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_aplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_aplicMediDet.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchAplicMediDet = False
			_alreadyFetchedAplicMediDet = False
			_aplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(New AplicMediDetDetEntityFactory())
			_aplicMediDetDet.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchAplicMediDetDet = False
			_alreadyFetchedAplicMediDetDet = False
			_cierreLote = New Integralab.ORM.CollectionClasses.CierreLoteCollection(New CierreLoteEntityFactory())
			_cierreLote.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchCierreLote = False
			_alreadyFetchedCierreLote = False
			_detAplFor = New Integralab.ORM.CollectionClasses.DetAplForCollection(New DetAplForEntityFactory())
			_detAplFor.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchDetAplFor = False
			_alreadyFetchedDetAplFor = False
			_detDproMed = New Integralab.ORM.CollectionClasses.DetDproMedCollection(New DetDproMedEntityFactory())
			_detDproMed.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchDetDproMed = False
			_alreadyFetchedDetDproMed = False
			_mcecatLotesCabFor = New Integralab.ORM.CollectionClasses.McecatLotesCabForCollection(New McecatLotesCabForEntityFactory())
			_mcecatLotesCabFor.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchMcecatLotesCabFor = False
			_alreadyFetchedMcecatLotesCabFor = False
			_mcecatLotesDet = New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(New McecatLotesDetEntityFactory())
			_mcecatLotesDet.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchMcecatLotesDet = False
			_alreadyFetchedMcecatLotesDet = False
			_prorraRec = New Integralab.ORM.CollectionClasses.ProrraRecCollection(New ProrraRecEntityFactory())
			_prorraRec.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchProrraRec = False
			_alreadyFetchedProrraRec = False
			_salidaGanadoCab = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_salidaGanadoCab.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_salidaGanadoDet = New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(New SalidaGanadoDetEntityFactory())
			_salidaGanadoDet.SetContainingEntityInfo(Me, "McecatLotesCab")
			_alwaysFetchSalidaGanadoDet = False
			_alreadyFetchedSalidaGanadoDet = False
			_aplicMediCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = False
			_productoCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDet = False
			_mcecatCorralesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = False
			_aplicMediCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = False
			_aplicMediDetCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = False
			_productoCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDetDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = False
			_mcecatCorralesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_cabAplForCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_alwaysFetchCabAplForCollectionViaDetAplFor = False
			_alreadyFetchedCabAplForCollectionViaDetAplFor = False
			_productoCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetAplFor = False
			_alreadyFetchedProductoCollectionViaDetAplFor = False
			_mcecatCorralesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = False
			_cabProMedCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.CabProMedCollection(New CabProMedEntityFactory())
			_alwaysFetchCabProMedCollectionViaDetDproMed = False
			_alreadyFetchedCabProMedCollectionViaDetDproMed = False
			_detProMedCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.DetProMedCollection(New DetProMedEntityFactory())
			_alwaysFetchDetProMedCollectionViaDetDproMed = False
			_alreadyFetchedDetProMedCollectionViaDetDproMed = False
			_productoCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetDproMed = False
			_alreadyFetchedProductoCollectionViaDetDproMed = False
			_productoCollectionViaMcecatLotesCabFor = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcecatLotesCabFor = False
			_alreadyFetchedProductoCollectionViaMcecatLotesCabFor = False
			_mcgcatTiposdeGanadoCollectionViaMcecatLotesDet = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = False
			_mcecatCorralesCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaProrraRec = False
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = False
			_salidaGanadoCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaProrraRec = False
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = False
			_cabMovGanCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = False
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(New McgcatCausasMuerteEntityFactory())
			_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = False
			_catRastrosCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CatRastrosCollection(New CatRastrosEntityFactory())
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = False
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_polizaCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = False
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = False
			_mcecatLotesDetCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(New McecatLotesDetEntityFactory())
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = False
			_salidaGanadoCabCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet = False
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = False
			_cierreLote_ = Nothing
			_cierreLote_ReturnsNewIfNotFound = True
			_alwaysFetchCierreLote_ = False
			_alreadyFetchedCierreLote_ = False
			_mcecatCorralesCab = Nothing
			_mcecatCorralesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatCorralesCab = False
			_alreadyFetchedMcecatCorralesCab = False
			_cierreFicticio = Nothing
			_cierreFicticioReturnsNewIfNotFound = True
			_alwaysFetchCierreFicticio = False
			_alreadyFetchedCierreFicticio = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NombreLote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomCorLote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoKilosAlim", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoImpteAlim", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoImpteMed", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoImpte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumCabMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumKilosMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumImpteMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumEntCab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumEntKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumImpteAlim", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumKilosAlim", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumImpteMedic", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumSalCab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumSalKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumEntImpte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantSemReimplante", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Gdpini", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Gdp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Eca", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cki", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PesoEstimado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCierre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacioneReimplante", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoCostoInd", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCierreLote", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cierreLote_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCierreLote_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cierreLote_, AddressOf OnCierreLote_PropertyChanged, "CierreLote_", McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote, True, signalRelatedEntity, "McecatLotesCab_", resetFKFields, New Integer() { CInt(McecatLotesCabFieldIndex.IdCierreLote) } )
			_cierreLote_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cierreLote_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCierreLote_(relatedEntity As IEntity)
			DesetupSyncCierreLote_(True, True)
			_cierreLote_ = CType(relatedEntity, CierreLoteEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cierreLote_, AddressOf OnCierreLote_PropertyChanged, "CierreLote_", McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote, True, _alreadyFetchedCierreLote_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCierreLote_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatCorralesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, signalRelatedEntity, "McecatLotesCab", resetFKFields, New Integer() { CInt(McecatLotesCabFieldIndex.IdCorral) } )
			_mcecatCorralesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatCorralesCab(relatedEntity As IEntity)
			DesetupSyncMcecatCorralesCab(True, True)
			_mcecatCorralesCab = CType(relatedEntity, McecatCorralesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, _alreadyFetchedMcecatCorralesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatCorralesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _cierreFicticio</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCierreFicticio(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cierreFicticio, AddressOf OnCierreFicticioPropertyChanged, "CierreFicticio", McecatLotesCabEntity.Relations.CierreFicticioEntityUsingIdLote, False, signalRelatedEntity, "McecatLotesCab", False, New Integer() { CInt(McecatLotesCabFieldIndex.IdLote) } )
			_cierreFicticio = Nothing
		End Sub

		''' <summary>setups the sync logic for member _cierreFicticio</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCierreFicticio(relatedEntity As IEntity)
			DesetupSyncCierreFicticio(True, True)
			_cierreFicticio = CType(relatedEntity, CierreFicticioEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cierreFicticio, AddressOf OnCierreFicticioPropertyChanged, "CierreFicticio", McecatLotesCabEntity.Relations.CierreFicticioEntityUsingIdLote, False, _alreadyFetchedCierreFicticio, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCierreFicticioPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idLote">PK value for McecatLotesCab which data should be fetched into this McecatLotesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idLote As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McecatLotesCabFieldIndex.IdLote)).ForcedCurrentValueWrite(idLote)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcecatLotesCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McecatLotesCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McecatLotesCabRelations
			Get	
				Return New McecatLotesCabRelations() 
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
					McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDetDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CierreLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCierreLote() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CierreLoteCollection(), _
					McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CierreLoteEntity, Integer), 0, Nothing, Nothing, Nothing, "CierreLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAplForCollection(), _
					McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.DetAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetDproMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetDproMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetDproMedCollection(), _
					McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.DetDproMedEntity, Integer), 0, Nothing, Nothing, Nothing, "DetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCabFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabForCollection(), _
					McecatLotesCabEntity.Relations.McecatLotesCabForEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabForEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCabFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(), _
					McecatLotesCabEntity.Relations.McecatLotesDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProrraRec' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProrraRec() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProrraRecCollection(), _
					McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProrraRecEntity, Integer), 0, Nothing, Nothing, Nothing, "ProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediDetCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.AplicMediDetDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplForCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, relations, "CabAplForCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.DetAplForEntityUsingCveLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabProMedCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.CabProMedEntityUsingFolioProrrateoMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabProMedCollection(), _
					McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), 0, Nothing, Nothing, relations, "CabProMedCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetProMedCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetProMedCollection(), _
					McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.DetProMedEntity, Integer), 0, Nothing, Nothing, relations, "DetProMedCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatLotesCabEntity.Relations.DetDproMedEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcecatLotesCabFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.McecatLotesCabForEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatLotesCabForEntity.Relations.ProductoEntityUsingIdFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatLotesCabEntity.Relations.McecatLotesCabForEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcecatLotesCabFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaMcecatLotesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.McecatLotesDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatLotesDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					McecatLotesCabEntity.Relations.McecatLotesDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaMcecatLotesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatCorralesCabEntityUsingIdCorralReciba)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McecatLotesCabEntity.Relations.ProrraRecEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCausasMuerte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCausasMuerteCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCausasMuerteCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesDetCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesDetEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesDetCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, "__McecatLotesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McecatLotesCabEntity.Relations.SalidaGanadoDetEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CierreLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCierreLote_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CierreLoteCollection(), _
					McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CierreLoteEntity, Integer), 0, Nothing, Nothing, Nothing, "CierreLote_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CierreFicticio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCierreFicticio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CierreFicticioCollection(), _
					McecatLotesCabEntity.Relations.CierreFicticioEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), CType(Integralab.ORM.EntityType.CierreFicticioEntity, Integer), 0, Nothing, Nothing, Nothing, "CierreFicticio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McecatLotesCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McecatLotesCabEntity.CustomProperties
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
				Return McecatLotesCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdLote property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."IdLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdLote]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.IdLote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.IdLote, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCorral property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."IdCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.IdCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.IdCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The NombreLote property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."NombreLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NombreLote]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.NombreLote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.NombreLote, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomCorLote property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."NomCorLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomCorLote]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.NomCorLote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.NomCorLote, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoCabezas property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoCabezas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoKilos property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoKilosAlim property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoKilosAlim"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoKilosAlim]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoKilosAlim, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoKilosAlim, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoImpteAlim property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoImpteAlim"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoImpteAlim]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpteAlim, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpteAlim, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoImpteMed property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoImpteMed"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoImpteMed]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpteMed, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpteMed, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoImpte property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoImpte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoImpte]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoImpte, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumCabMuerte property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumCabMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumCabMuerte]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumCabMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumCabMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumKilosMuerte property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumKilosMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumKilosMuerte]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumKilosMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumKilosMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumImpteMuerte property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumImpteMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumImpteMuerte]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumEntCab property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumEntCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumEntCab]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumEntCab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumEntCab, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumEntKilos property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumEntKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumEntKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumEntKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumEntKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumImpteAlim property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumImpteAlim"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumImpteAlim]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteAlim, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteAlim, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumKilosAlim property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumKilosAlim"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumKilosAlim]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumKilosAlim, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumKilosAlim, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumImpteMedic property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumImpteMedic"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumImpteMedic]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteMedic, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumImpteMedic, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumSalCab property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumSalCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumSalCab]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumSalCab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumSalCab, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumSalKilos property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumSalKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumSalKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumSalKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumSalKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumEntImpte property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."AcumEntImpte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumEntImpte]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.AcumEntImpte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.AcumEntImpte, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantSemReimplante property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."CantSemReimplante"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantSemReimplante]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.CantSemReimplante, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.CantSemReimplante, Integer), value)
			End Set
		End Property
	
		''' <summary>The Gdpini property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."GDPIni"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Gdpini]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Gdpini, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Gdpini, Integer), value)
			End Set
		End Property
	
		''' <summary>The Gdp property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."GDP"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Gdp]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Gdp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Gdp, Integer), value)
			End Set
		End Property
	
		''' <summary>The Eca property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."ECA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Eca]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Eca, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Eca, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cki property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."CKI"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cki]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Cki, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Cki, Integer), value)
			End Set
		End Property
	
		''' <summary>The PesoEstimado property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."PesoEstimado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PesoEstimado]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.PesoEstimado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.PesoEstimado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCierre property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."FechaCierre"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCierre]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.FechaCierre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.FechaCierre, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacioneReimplante property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."ObservacioneReimplante"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacioneReimplante]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.ObservacioneReimplante, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.ObservacioneReimplante, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoCostoInd property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."SaldoCostoInd"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoCostoInd]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.SaldoCostoInd, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.SaldoCostoInd, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCierreLote property of the Entity McecatLotesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatLotesCab"."IdCierreLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCierreLote]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatLotesCabFieldIndex.IdCierreLote, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McecatLotesCabFieldIndex.IdCierreLote, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCierreLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CierreLote]() As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Get
				Return GetMultiCierreLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CierreLote. When set to true, CierreLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CierreLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiCierreLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCierreLote As Boolean
			Get
				Return _alwaysFetchCierreLote
			End Get
			Set
				_alwaysFetchCierreLote = value
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
	
		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesDet]() As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Get
				Return GetMultiMcecatLotesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesDet. When set to true, McecatLotesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesDet
			End Get
			Set
				_alwaysFetchMcecatLotesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProrraRecEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProrraRec()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProrraRec]() As Integralab.ORM.CollectionClasses.ProrraRecCollection
			Get
				Return GetMultiProrraRec(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProrraRec. When set to true, ProrraRec is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProrraRec is accessed. You can always execute
		''' a forced fetch by calling GetMultiProrraRec(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProrraRec As Boolean
			Get
				Return _alwaysFetchProrraRec
			End Get
			Set
				_alwaysFetchProrraRec = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCab]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCab. When set to true, SalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCab
			End Get
			Set
				_alwaysFetchSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoDet]() As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
			Get
				Return GetMultiSalidaGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoDet. When set to true, SalidaGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoDet As Boolean
			Get
				Return _alwaysFetchSalidaGanadoDet
			End Get
			Set
				_alwaysFetchSalidaGanadoDet = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaAplicMediDet]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaAplicMediDet. When set to true, ProductoCollectionViaAplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaAplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaAplicMediDet As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaAplicMediDet
			End Get
			Set
				_alwaysFetchProductoCollectionViaAplicMediDet = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaAplicMediDetDet. When set to true, ProductoCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchProductoCollectionViaAplicMediDetDet = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetAplFor. When set to true, ProductoCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetAplFor = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetDproMed. When set to true, ProductoCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMcecatLotesCabFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMcecatLotesCabFor]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMcecatLotesCabFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMcecatLotesCabFor. When set to true, ProductoCollectionViaMcecatLotesCabFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMcecatLotesCabFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMcecatLotesCabFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMcecatLotesCabFor As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMcecatLotesCabFor
			End Get
			Set
				_alwaysFetchProductoCollectionViaMcecatLotesCabFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaMcecatLotesDet]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaMcecatLotesDet. When set to true, McgcatTiposdeGanadoCollectionViaMcecatLotesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaMcecatLotesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaMcecatLotesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatLotesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaProrraRec()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaProrraRec]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaProrraRec(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaProrraRec. When set to true, McecatCorralesCabCollectionViaProrraRec is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaProrraRec is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaProrraRec(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaProrraRec As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaProrraRec
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaProrraRec = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCabCollectionViaProrraRec()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCabCollectionViaProrraRec]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCabCollectionViaProrraRec(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCabCollectionViaProrraRec. When set to true, SalidaGanadoCabCollectionViaProrraRec is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCabCollectionViaProrraRec is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCabCollectionViaProrraRec(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCabCollectionViaProrraRec As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCabCollectionViaProrraRec
			End Get
			Set
				_alwaysFetchSalidaGanadoCabCollectionViaProrraRec = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaSalidaGanadoCab. When set to true, CabMovGanCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatCausasMuerteEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatCausasMuerteCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
			Get
				Return GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCausasMuerteCollectionViaSalidaGanadoCab. When set to true, McgcatCausasMuerteCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCausasMuerteCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatCausasMuerteCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatRastrosCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatRastrosCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Get
				Return GetMultiCatRastrosCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatRastrosCollectionViaSalidaGanadoCab. When set to true, CatRastrosCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatRastrosCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatRastrosCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatRastrosCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaSalidaGanadoCab. When set to true, McecatCorralesCabCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaSalidaGanadoCab. When set to true, PolizaCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchPolizaCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesDetEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesDetCollectionViaSalidaGanadoDet]() As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
			Get
				Return GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesDetCollectionViaSalidaGanadoDet. When set to true, McecatLotesDetCollectionViaSalidaGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesDetCollectionViaSalidaGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesDetCollectionViaSalidaGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet
			End Get
			Set
				_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaSalidaGanadoDet]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaSalidaGanadoDet. When set to true, McgcatTiposdeGanadoCollectionViaSalidaGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaSalidaGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCabCollectionViaSalidaGanadoDet]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCabCollectionViaSalidaGanadoDet. When set to true, SalidaGanadoCabCollectionViaSalidaGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCabCollectionViaSalidaGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCabCollectionViaSalidaGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet
			End Get
			Set
				_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CierreLoteEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCierreLote_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CierreLote_]() As CierreLoteEntity
			Get
				Return GetSingleCierreLote_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCierreLote_(value)
				Else
					If value Is Nothing Then
						If Not _cierreLote_ Is Nothing Then
							_cierreLote_.UnsetRelatedEntity(Me, "McecatLotesCab_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McecatLotesCab_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CierreLote_. When set to true, CierreLote_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CierreLote_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleCierreLote_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCierreLote_ As Boolean
			Get
				Return _alwaysFetchCierreLote_
			End Get
			Set
				_alwaysFetchCierreLote_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CierreLote_ is not found
		''' in the database. When set to true, CierreLote_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CierreLote_ReturnsNewIfNotFound As Boolean
			Get
				Return _cierreLote_ReturnsNewIfNotFound
			End Get
			Set
				_cierreLote_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatCorralesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatCorralesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatCorralesCab]() As McecatCorralesCabEntity
			Get
				Return GetSingleMcecatCorralesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatCorralesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatCorralesCab Is Nothing Then
							_mcecatCorralesCab.UnsetRelatedEntity(Me, "McecatLotesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McecatLotesCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCab. When set to true, McecatCorralesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatCorralesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCab As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCab
			End Get
			Set
				_alwaysFetchMcecatCorralesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatCorralesCab is not found
		''' in the database. When set to true, McecatCorralesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatCorralesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatCorralesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatCorralesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'CierreFicticioEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCierreFicticio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CierreFicticio]() As CierreFicticioEntity
			Get
				Return GetSingleCierreFicticio(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCierreFicticio(value)
				Else
					If value Is Nothing Then
						DesetupSyncCierreFicticio(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "McecatLotesCab")
						SetupSyncCierreFicticio(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CierreFicticio. When set to true, CierreFicticio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CierreFicticio is accessed. You can always execute
		''' a forced fetch by calling GetSingleCierreFicticio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCierreFicticio As Boolean
			Get
				Return _alwaysFetchCierreFicticio
			End Get
			Set
				_alwaysFetchCierreFicticio = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CierreFicticio is not found
		''' in the database. When set to true, CierreFicticio will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CierreFicticioReturnsNewIfNotFound As Boolean
			Get
				Return _cierreFicticioReturnsNewIfNotFound
			End Get
			Set
				_cierreFicticioReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.McecatLotesCabEntity)
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
