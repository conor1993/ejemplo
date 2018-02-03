' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 16:33:22
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
	''' <summary>Entity class which represents the entity 'McecatCorralesCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McecatCorralesCabEntity 
#Else
	<Serializable()> _
	Public Class McecatCorralesCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMediDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDet, _alreadyFetchedAplicMediDet As Boolean
		Private _aplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
		Private _alwaysFetchAplicMediDetDet, _alreadyFetchedAplicMediDetDet As Boolean
		Private _cabRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom As Boolean
		Private _detAplFor As Integralab.ORM.CollectionClasses.DetAplForCollection
		Private _alwaysFetchDetAplFor, _alreadyFetchedDetAplFor As Boolean
		Private _mcecatCorralesDet As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
		Private _alwaysFetchMcecatCorralesDet, _alreadyFetchedMcecatCorralesDet As Boolean
		Private _mcecatLotesCab As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCab, _alreadyFetchedMcecatLotesCab As Boolean
		Private _mcgcompraGanadoCab As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
		Private _alwaysFetchMcgcompraGanadoCab, _alreadyFetchedMcgcompraGanadoCab As Boolean
		Private _prorraRec As Integralab.ORM.CollectionClasses.ProrraRecCollection
		Private _alwaysFetchProrraRec, _alreadyFetchedProrraRec As Boolean
		Private _salidaGanadoCab As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab As Boolean
		Private _aplicMediCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDet, _alreadyFetchedAplicMediCollectionViaAplicMediDet As Boolean
		Private _productoCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDet, _alreadyFetchedProductoCollectionViaAplicMediDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet As Boolean
		Private _aplicMediCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediCollection
		Private _alwaysFetchAplicMediCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediCollectionViaAplicMediDetDet As Boolean
		Private _aplicMediDetCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet As Boolean
		Private _productoCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDetDet, _alreadyFetchedProductoCollectionViaAplicMediDetDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
		Private _cabMovGanCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom, _alreadyFetchedCabMovGanCollectionViaCabRegCom As Boolean
		Private _cabMovGanCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom_, _alreadyFetchedCabMovGanCollectionViaCabRegCom_ As Boolean
		Private _catLugaresDeCompraCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom, _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom As Boolean
		Private _proveedorCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCabRegCom, _alreadyFetchedProveedorCollectionViaCabRegCom As Boolean
		Private _mcgcatCompradoresdeGanadoCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom, _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
		Private _cabAplForCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.CabAplForCollection
		Private _alwaysFetchCabAplForCollectionViaDetAplFor, _alreadyFetchedCabAplForCollectionViaDetAplFor As Boolean
		Private _productoCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetAplFor, _alreadyFetchedProductoCollectionViaDetAplFor As Boolean
		Private _mcecatLotesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaDetAplFor, _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet As Boolean
		Private _cierreLoteCollectionViaMcecatLotesCab As Integralab.ORM.CollectionClasses.CierreLoteCollection
		Private _alwaysFetchCierreLoteCollectionViaMcecatLotesCab, _alreadyFetchedCierreLoteCollectionViaMcecatLotesCab As Boolean
		Private _catProveedoresCollectionViaMcgcompraGanadoCab As Integralab.ORM.CollectionClasses.CatProveedoresCollection
		Private _alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab, _alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab As Boolean
		Private _mcecatLotesCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaProrraRec, _alreadyFetchedMcecatLotesCabCollectionViaProrraRec As Boolean
		Private _salidaGanadoCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaProrraRec, _alreadyFetchedSalidaGanadoCabCollectionViaProrraRec As Boolean
		Private _cabMovGanCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab, _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
		Private _mcgcatCausasMuerteCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
		Private _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab, _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab As Boolean
		Private _catRastrosCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab, _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab As Boolean
		Private _polizaCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaSalidaGanadoCab, _alreadyFetchedPolizaCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatTiposCorral As McecatTiposCorralEntity
		Private _alwaysFetchMcecatTiposCorral, _alreadyFetchedMcecatTiposCorral, _mcecatTiposCorralReturnsNewIfNotFound As Boolean


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
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		Public Sub New(idCorral As System.String)

			InitClassFetch(idCorral, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCorral As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCorral, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="validator">The custom validator Object for this McecatCorralesCabEntity</param>
		Public Sub New(idCorral As System.String, validator As IValidator)

			InitClassFetch(idCorral, validator, Nothing)
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
			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_detAplFor = CType(info.GetValue("_detAplFor", GetType(Integralab.ORM.CollectionClasses.DetAplForCollection)), Integralab.ORM.CollectionClasses.DetAplForCollection)
			_alwaysFetchDetAplFor = info.GetBoolean("_alwaysFetchDetAplFor")
			_alreadyFetchedDetAplFor = info.GetBoolean("_alreadyFetchedDetAplFor")
			_mcecatCorralesDet = CType(info.GetValue("_mcecatCorralesDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesDetCollection)), Integralab.ORM.CollectionClasses.McecatCorralesDetCollection)
			_alwaysFetchMcecatCorralesDet = info.GetBoolean("_alwaysFetchMcecatCorralesDet")
			_alreadyFetchedMcecatCorralesDet = info.GetBoolean("_alreadyFetchedMcecatCorralesDet")
			_mcecatLotesCab = CType(info.GetValue("_mcecatLotesCab", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCab = info.GetBoolean("_alwaysFetchMcecatLotesCab")
			_alreadyFetchedMcecatLotesCab = info.GetBoolean("_alreadyFetchedMcecatLotesCab")
			_mcgcompraGanadoCab = CType(info.GetValue("_mcgcompraGanadoCab", GetType(Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection)), Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection)
			_alwaysFetchMcgcompraGanadoCab = info.GetBoolean("_alwaysFetchMcgcompraGanadoCab")
			_alreadyFetchedMcgcompraGanadoCab = info.GetBoolean("_alreadyFetchedMcgcompraGanadoCab")
			_prorraRec = CType(info.GetValue("_prorraRec", GetType(Integralab.ORM.CollectionClasses.ProrraRecCollection)), Integralab.ORM.CollectionClasses.ProrraRecCollection)
			_alwaysFetchProrraRec = info.GetBoolean("_alwaysFetchProrraRec")
			_alreadyFetchedProrraRec = info.GetBoolean("_alreadyFetchedProrraRec")
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_aplicMediCollectionViaAplicMediDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDet")
			_productoCollectionViaAplicMediDet = CType(info.GetValue("_productoCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDet")
			_alreadyFetchedProductoCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDet")
			_mcecatLotesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet")
			_aplicMediCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediCollection)), Integralab.ORM.CollectionClasses.AplicMediCollection)
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet")
			_aplicMediDetCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediDetCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetCollection)
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet")
			_productoCollectionViaAplicMediDetDet = CType(info.GetValue("_productoCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDetDet")
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDetDet")
			_mcecatLotesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet")
			_cabMovGanCollectionViaCabRegCom = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom")
			_cabMovGanCollectionViaCabRegCom_ = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom_")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom_")
			_catLugaresDeCompraCollectionViaCabRegCom = CType(info.GetValue("_catLugaresDeCompraCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom")
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom")
			_proveedorCollectionViaCabRegCom = CType(info.GetValue("_proveedorCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchProveedorCollectionViaCabRegCom")
			_alreadyFetchedProveedorCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCabRegCom")
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = CType(info.GetValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_cabAplForCollectionViaDetAplFor = CType(info.GetValue("_cabAplForCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.CabAplForCollection)), Integralab.ORM.CollectionClasses.CabAplForCollection)
			_alwaysFetchCabAplForCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchCabAplForCollectionViaDetAplFor")
			_alreadyFetchedCabAplForCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedCabAplForCollectionViaDetAplFor")
			_productoCollectionViaDetAplFor = CType(info.GetValue("_productoCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchProductoCollectionViaDetAplFor")
			_alreadyFetchedProductoCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetAplFor")
			_mcecatLotesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatLotesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor")
			_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet")
			_cierreLoteCollectionViaMcecatLotesCab = CType(info.GetValue("_cierreLoteCollectionViaMcecatLotesCab", GetType(Integralab.ORM.CollectionClasses.CierreLoteCollection)), Integralab.ORM.CollectionClasses.CierreLoteCollection)
			_alwaysFetchCierreLoteCollectionViaMcecatLotesCab = info.GetBoolean("_alwaysFetchCierreLoteCollectionViaMcecatLotesCab")
			_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab = info.GetBoolean("_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab")
			_catProveedoresCollectionViaMcgcompraGanadoCab = CType(info.GetValue("_catProveedoresCollectionViaMcgcompraGanadoCab", GetType(Integralab.ORM.CollectionClasses.CatProveedoresCollection)), Integralab.ORM.CollectionClasses.CatProveedoresCollection)
			_alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab = info.GetBoolean("_alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab")
			_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab = info.GetBoolean("_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab")
			_mcecatLotesCabCollectionViaProrraRec = CType(info.GetValue("_mcecatLotesCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaProrraRec")
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaProrraRec")
			_salidaGanadoCabCollectionViaProrraRec = CType(info.GetValue("_salidaGanadoCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaProrraRec")
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec")
			_cabMovGanCollectionViaSalidaGanadoCab = CType(info.GetValue("_cabMovGanCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab")
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab")
			_mcecatLotesCabCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcecatLotesCabCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab")
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcgcatCausasMuerteCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection)), Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection)
			_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab")
			_catRastrosCollectionViaSalidaGanadoCab = CType(info.GetValue("_catRastrosCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CatRastrosCollection)), Integralab.ORM.CollectionClasses.CatRastrosCollection)
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab")
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab")
			_polizaCollectionViaSalidaGanadoCab = CType(info.GetValue("_polizaCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchPolizaCollectionViaSalidaGanadoCab")
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab")
			_mcecatTiposCorral = CType(info.GetValue("_mcecatTiposCorral", GetType(McecatTiposCorralEntity)), McecatTiposCorralEntity)
			If Not _mcecatTiposCorral Is Nothing Then
				AddHandler _mcecatTiposCorral.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatTiposCorralReturnsNewIfNotFound = info.GetBoolean("_mcecatTiposCorralReturnsNewIfNotFound")
			_alwaysFetchMcecatTiposCorral = info.GetBoolean("_alwaysFetchMcecatTiposCorral")
			_alreadyFetchedMcecatTiposCorral = info.GetBoolean("_alreadyFetchedMcecatTiposCorral")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMediDet = (_aplicMediDet.Count > 0)
			_alreadyFetchedAplicMediDetDet = (_aplicMediDetDet.Count > 0)
			_alreadyFetchedCabRegCom = (_cabRegCom.Count > 0)
			_alreadyFetchedDetAplFor = (_detAplFor.Count > 0)
			_alreadyFetchedMcecatCorralesDet = (_mcecatCorralesDet.Count > 0)
			_alreadyFetchedMcecatLotesCab = (_mcecatLotesCab.Count > 0)
			_alreadyFetchedMcgcompraGanadoCab = (_mcgcompraGanadoCab.Count > 0)
			_alreadyFetchedProrraRec = (_prorraRec.Count > 0)
			_alreadyFetchedSalidaGanadoCab = (_salidaGanadoCab.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = (_aplicMediCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDet = (_productoCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = (_mcecatLotesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = (_aplicMediCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = (_aplicMediDetCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = (_productoCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = (_mcecatLotesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = (_cabMovGanCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = (_cabMovGanCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = (_catLugaresDeCompraCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedProveedorCollectionViaCabRegCom = (_proveedorCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = (_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCabAplForCollectionViaDetAplFor = (_cabAplForCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedProductoCollectionViaDetAplFor = (_productoCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = (_mcecatLotesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = (_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.Count > 0)
			_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab = (_cierreLoteCollectionViaMcecatLotesCab.Count > 0)
			_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab = (_catProveedoresCollectionViaMcgcompraGanadoCab.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = (_mcecatLotesCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = (_salidaGanadoCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = (_cabMovGanCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = (_mcecatLotesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = (_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = (_catRastrosCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = (_polizaCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatTiposCorral = Not(_mcecatTiposCorral Is Nothing)

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
			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_detAplFor", _detAplFor)
			info.AddValue("_alwaysFetchDetAplFor", _alwaysFetchDetAplFor)
			info.AddValue("_alreadyFetchedDetAplFor", _alreadyFetchedDetAplFor)
			info.AddValue("_mcecatCorralesDet", _mcecatCorralesDet)
			info.AddValue("_alwaysFetchMcecatCorralesDet", _alwaysFetchMcecatCorralesDet)
			info.AddValue("_alreadyFetchedMcecatCorralesDet", _alreadyFetchedMcecatCorralesDet)
			info.AddValue("_mcecatLotesCab", _mcecatLotesCab)
			info.AddValue("_alwaysFetchMcecatLotesCab", _alwaysFetchMcecatLotesCab)
			info.AddValue("_alreadyFetchedMcecatLotesCab", _alreadyFetchedMcecatLotesCab)
			info.AddValue("_mcgcompraGanadoCab", _mcgcompraGanadoCab)
			info.AddValue("_alwaysFetchMcgcompraGanadoCab", _alwaysFetchMcgcompraGanadoCab)
			info.AddValue("_alreadyFetchedMcgcompraGanadoCab", _alreadyFetchedMcgcompraGanadoCab)
			info.AddValue("_prorraRec", _prorraRec)
			info.AddValue("_alwaysFetchProrraRec", _alwaysFetchProrraRec)
			info.AddValue("_alreadyFetchedProrraRec", _alreadyFetchedProrraRec)
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_aplicMediCollectionViaAplicMediDet", _aplicMediCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDet", _alwaysFetchAplicMediCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDet", _alreadyFetchedAplicMediCollectionViaAplicMediDet)
			info.AddValue("_productoCollectionViaAplicMediDet", _productoCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDet", _alwaysFetchProductoCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDet", _alreadyFetchedProductoCollectionViaAplicMediDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDet", _mcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_aplicMediCollectionViaAplicMediDetDet", _aplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediCollectionViaAplicMediDetDet", _alwaysFetchAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediCollectionViaAplicMediDetDet)
			info.AddValue("_aplicMediDetCollectionViaAplicMediDetDet", _aplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet", _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_productoCollectionViaAplicMediDetDet", _productoCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDetDet", _alwaysFetchProductoCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDetDet", _alreadyFetchedProductoCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDetDet", _mcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_cabMovGanCollectionViaCabRegCom", _cabMovGanCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom", _alwaysFetchCabMovGanCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom", _alreadyFetchedCabMovGanCollectionViaCabRegCom)
			info.AddValue("_cabMovGanCollectionViaCabRegCom_", _cabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom_", _alwaysFetchCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom_", _alreadyFetchedCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_catLugaresDeCompraCollectionViaCabRegCom", _catLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom", _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom", _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_proveedorCollectionViaCabRegCom", _proveedorCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchProveedorCollectionViaCabRegCom", _alwaysFetchProveedorCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCabRegCom", _alreadyFetchedProveedorCollectionViaCabRegCom)
			info.AddValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", _mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_cabAplForCollectionViaDetAplFor", _cabAplForCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchCabAplForCollectionViaDetAplFor", _alwaysFetchCabAplForCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedCabAplForCollectionViaDetAplFor", _alreadyFetchedCabAplForCollectionViaDetAplFor)
			info.AddValue("_productoCollectionViaDetAplFor", _productoCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchProductoCollectionViaDetAplFor", _alwaysFetchProductoCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetAplFor", _alreadyFetchedProductoCollectionViaDetAplFor)
			info.AddValue("_mcecatLotesCabCollectionViaDetAplFor", _mcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor", _alwaysFetchMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor", _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet", _mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet", _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet)
			info.AddValue("_cierreLoteCollectionViaMcecatLotesCab", _cierreLoteCollectionViaMcecatLotesCab)
			info.AddValue("_alwaysFetchCierreLoteCollectionViaMcecatLotesCab", _alwaysFetchCierreLoteCollectionViaMcecatLotesCab)
			info.AddValue("_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab", _alreadyFetchedCierreLoteCollectionViaMcecatLotesCab)
			info.AddValue("_catProveedoresCollectionViaMcgcompraGanadoCab", _catProveedoresCollectionViaMcgcompraGanadoCab)
			info.AddValue("_alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab", _alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab)
			info.AddValue("_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab", _alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab)
			info.AddValue("_mcecatLotesCabCollectionViaProrraRec", _mcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaProrraRec", _alwaysFetchMcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaProrraRec", _alreadyFetchedMcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_salidaGanadoCabCollectionViaProrraRec", _salidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaProrraRec", _alwaysFetchSalidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec", _alreadyFetchedSalidaGanadoCabCollectionViaProrraRec)
			info.AddValue("_cabMovGanCollectionViaSalidaGanadoCab", _cabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab", _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab", _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatLotesCabCollectionViaSalidaGanadoCab", _mcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab", _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab", _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_mcgcatCausasMuerteCollectionViaSalidaGanadoCab", _mcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab", _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab", _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab)
			info.AddValue("_catRastrosCollectionViaSalidaGanadoCab", _catRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab", _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab", _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_polizaCollectionViaSalidaGanadoCab", _polizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchPolizaCollectionViaSalidaGanadoCab", _alwaysFetchPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab", _alreadyFetchedPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatTiposCorral", _mcecatTiposCorral)
			info.AddValue("_mcecatTiposCorralReturnsNewIfNotFound", _mcecatTiposCorralReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatTiposCorral", _alwaysFetchMcecatTiposCorral)
			info.AddValue("_alreadyFetchedMcecatTiposCorral", _alreadyFetchedMcecatTiposCorral)

			
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
				Case "McecatTiposCorral"
					_alreadyFetchedMcecatTiposCorral = True
					Me.McecatTiposCorral = CType(entity, McecatTiposCorralEntity)
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
				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "DetAplFor"
					_alreadyFetchedDetAplFor = True
					If Not entity Is Nothing Then
						Me.DetAplFor.Add(CType(entity, DetAplForEntity))
					End If
				Case "McecatCorralesDet"
					_alreadyFetchedMcecatCorralesDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesDet.Add(CType(entity, McecatCorralesDetEntity))
					End If
				Case "McecatLotesCab"
					_alreadyFetchedMcecatLotesCab = True
					If Not entity Is Nothing Then
						Me.McecatLotesCab.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "McgcompraGanadoCab"
					_alreadyFetchedMcgcompraGanadoCab = True
					If Not entity Is Nothing Then
						Me.McgcompraGanadoCab.Add(CType(entity, McgcompraGanadoCabEntity))
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
				Case "ProductoCollectionViaAplicMediDetDet"
					_alreadyFetchedProductoCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaAplicMediDetDet.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatLotesCabEntity))
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
				Case "ProveedorCollectionViaCabRegCom"
					_alreadyFetchedProveedorCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCabRegCom.Add(CType(entity, ProveedorEntity))
					End If
				Case "McgcatCompradoresdeGanadoCollectionViaCabRegCom"
					_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanadoCollectionViaCabRegCom.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
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
				Case "McecatLotesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaDetAplFor.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaMcecatCorralesDet"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaMcecatCorralesDet.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "CierreLoteCollectionViaMcecatLotesCab"
					_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab = True
					If Not entity Is Nothing Then
						Me.CierreLoteCollectionViaMcecatLotesCab.Add(CType(entity, CierreLoteEntity))
					End If
				Case "CatProveedoresCollectionViaMcgcompraGanadoCab"
					_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab = True
					If Not entity Is Nothing Then
						Me.CatProveedoresCollectionViaMcgcompraGanadoCab.Add(CType(entity, CatProveedoresEntity))
					End If
				Case "McecatLotesCabCollectionViaProrraRec"
					_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaProrraRec.Add(CType(entity, McecatLotesCabEntity))
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
				Case "McecatLotesCabCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaSalidaGanadoCab.Add(CType(entity, McecatLotesCabEntity))
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
				Case "PolizaCollectionViaSalidaGanadoCab"
					_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaSalidaGanadoCab.Add(CType(entity, PolizaEntity))
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
				Case "McecatTiposCorral"
					SetupSyncMcecatTiposCorral(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDet"
					_aplicMediDet.Add(CType(relatedEntity, AplicMediDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					_aplicMediDetDet.Add(CType(relatedEntity, AplicMediDetDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabRegCom"
					_cabRegCom.Add(CType(relatedEntity, CabRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAplFor"
					_detAplFor.Add(CType(relatedEntity, DetAplForEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesDet"
					_mcecatCorralesDet.Add(CType(relatedEntity, McecatCorralesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCab"
					_mcecatLotesCab.Add(CType(relatedEntity, McecatLotesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcompraGanadoCab"
					_mcgcompraGanadoCab.Add(CType(relatedEntity, McgcompraGanadoCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProrraRec"
					_prorraRec.Add(CType(relatedEntity, ProrraRecEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					_salidaGanadoCab.Add(CType(relatedEntity, SalidaGanadoCabEntity))
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
				Case "McecatTiposCorral"
					DesetupSyncMcecatTiposCorral(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDetDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabRegCom"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAplFor"
					MyBase.PerformRelatedEntityRemoval(_detAplFor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesDet"
					MyBase.PerformRelatedEntityRemoval(_mcecatCorralesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCab"
					MyBase.PerformRelatedEntityRemoval(_mcecatLotesCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcompraGanadoCab"
					MyBase.PerformRelatedEntityRemoval(_mcgcompraGanadoCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProrraRec"
					MyBase.PerformRelatedEntityRemoval(_prorraRec, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoCab, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _mcecatTiposCorral Is Nothing Then
				toReturn.Add(_mcecatTiposCorral)
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
			toReturn.Add(_cabRegCom)
			toReturn.Add(_detAplFor)
			toReturn.Add(_mcecatCorralesDet)
			toReturn.Add(_mcecatLotesCab)
			toReturn.Add(_mcgcompraGanadoCab)
			toReturn.Add(_prorraRec)
			toReturn.Add(_salidaGanadoCab)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCorral As System.String) As Boolean
			Return FetchUsingPK(idCorral, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCorral As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCorral, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCorral As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCorral, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCorral, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McecatCorralesCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McecatCorralesCabFieldIndex) As Boolean
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
				_aplicMediDet.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
				_aplicMediDetDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
				_cabRegCom.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
				_detAplFor.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesDetEntity'</returns>
		Public Function GetMultiMcecatCorralesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
			Return GetMultiMcecatCorralesDet(forceFetch, _mcecatCorralesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcecatCorralesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
			Return GetMultiMcecatCorralesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesDetEntity'</returns>
		Public Function GetMultiMcecatCorralesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
			Return GetMultiMcecatCorralesDet(forceFetch, _mcecatCorralesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
			If ( Not _alreadyFetchedMcecatCorralesDet Or forceFetch Or _alwaysFetchMcecatCorralesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesDet)
					End If
				End If
				_mcecatCorralesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesDet.GetMultiManyToOne(Me, Nothing, Filter)
				_mcecatCorralesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesDet = True
			End If
			Return _mcecatCorralesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesDet'. These settings will be taken into account
		''' when the property McecatCorralesDet is requested or GetMultiMcecatCorralesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesDet.SortClauses=sortClauses
			_mcecatCorralesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCab(forceFetch, _mcecatLotesCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcecatLotesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCab(forceFetch, _mcecatLotesCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCab Or forceFetch Or _alwaysFetchMcecatLotesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCab)
					End If
				End If
				_mcecatLotesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCab.GetMultiManyToOne(Nothing, Me, Filter)
				_mcecatLotesCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCab = True
			End If
			Return _mcecatLotesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCab'. These settings will be taken into account
		''' when the property McecatLotesCab is requested or GetMultiMcecatLotesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCab.SortClauses=sortClauses
			_mcecatLotesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McgcompraGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcompraGanadoCabEntity'</returns>
		Public Function GetMultiMcgcompraGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
			Return GetMultiMcgcompraGanadoCab(forceFetch, _mcgcompraGanadoCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcompraGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcgcompraGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
			Return GetMultiMcgcompraGanadoCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcompraGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McgcompraGanadoCabEntity'</returns>
		Public Function GetMultiMcgcompraGanadoCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
			Return GetMultiMcgcompraGanadoCab(forceFetch, _mcgcompraGanadoCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcompraGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcompraGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
			If ( Not _alreadyFetchedMcgcompraGanadoCab Or forceFetch Or _alwaysFetchMcgcompraGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcompraGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcompraGanadoCab)
					End If
				End If
				_mcgcompraGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcompraGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcompraGanadoCab.GetMultiManyToOne(Nothing, Me, Filter)
				_mcgcompraGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcompraGanadoCab = True
			End If
			Return _mcgcompraGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcompraGanadoCab'. These settings will be taken into account
		''' when the property McgcompraGanadoCab is requested or GetMultiMcgcompraGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcompraGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcompraGanadoCab.SortClauses=sortClauses
			_mcgcompraGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_prorraRec.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
				_salidaGanadoCab.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCabRegCom(forceFetch, _proveedorCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCabRegCom Or forceFetch Or _alwaysFetchProveedorCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCabRegCom.GetMulti(Filter, relations)
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCabRegCom = True
			End If
			Return _proveedorCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCabRegCom is requested or GetMultiProveedorCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCabRegCom.SortClauses=sortClauses
			_proveedorCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(forceFetch, _mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.McecatCorralesDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", "McecatCorralesDet_", JoinHint.None)
				relations.Add(McecatCorralesDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "McecatCorralesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaMcecatCorralesDet'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaMcecatCorralesDet is requested or GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CierreLoteEntity'</returns>
		Public Function GetMultiCierreLoteCollectionViaMcecatLotesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Return GetMultiCierreLoteCollectionViaMcecatLotesCab(forceFetch, _cierreLoteCollectionViaMcecatLotesCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCierreLoteCollectionViaMcecatLotesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CierreLoteCollection
			If ( Not _alreadyFetchedCierreLoteCollectionViaMcecatLotesCab Or forceFetch Or _alwaysFetchCierreLoteCollectionViaMcecatLotesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cierreLoteCollectionViaMcecatLotesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cierreLoteCollectionViaMcecatLotesCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.McecatLotesCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "McecatLotesCab_", JoinHint.None)
				relations.Add(McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote, "McecatLotesCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_cierreLoteCollectionViaMcecatLotesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cierreLoteCollectionViaMcecatLotesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_cierreLoteCollectionViaMcecatLotesCab.GetMulti(Filter, relations)
				_cierreLoteCollectionViaMcecatLotesCab.SuppressClearInGetMulti = False
				_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab = True
			End If
			Return _cierreLoteCollectionViaMcecatLotesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CierreLoteCollectionViaMcecatLotesCab'. These settings will be taken into account
		''' when the property CierreLoteCollectionViaMcecatLotesCab is requested or GetMultiCierreLoteCollectionViaMcecatLotesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCierreLoteCollectionViaMcecatLotesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cierreLoteCollectionViaMcecatLotesCab.SortClauses=sortClauses
			_cierreLoteCollectionViaMcecatLotesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatProveedoresEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatProveedoresEntity'</returns>
		Public Function GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatProveedoresCollection
			Return GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab(forceFetch, _catProveedoresCollectionViaMcgcompraGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatProveedoresEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatProveedoresCollection
			If ( Not _alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab Or forceFetch Or _alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catProveedoresCollectionViaMcgcompraGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catProveedoresCollectionViaMcgcompraGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.McgcompraGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "McgcompraGanadoCab_", JoinHint.None)
				relations.Add(McgcompraGanadoCabEntity.Relations.CatProveedoresEntityUsingIdProveedor, "McgcompraGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_catProveedoresCollectionViaMcgcompraGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catProveedoresCollectionViaMcgcompraGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_catProveedoresCollectionViaMcgcompraGanadoCab.GetMulti(Filter, relations)
				_catProveedoresCollectionViaMcgcompraGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab = True
			End If
			Return _catProveedoresCollectionViaMcgcompraGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatProveedoresCollectionViaMcgcompraGanadoCab'. These settings will be taken into account
		''' when the property CatProveedoresCollectionViaMcgcompraGanadoCab is requested or GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatProveedoresCollectionViaMcgcompraGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catProveedoresCollectionViaMcgcompraGanadoCab.SortClauses=sortClauses
			_catProveedoresCollectionViaMcgcompraGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaProrraRec(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaProrraRec(forceFetch, _mcecatLotesCabCollectionViaProrraRec.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaProrraRec(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaProrraRec Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaProrraRec) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaProrraRec.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaProrraRec)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, "__McecatCorralesCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatLotesCabEntityUsingIdLote, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_mcecatLotesCabCollectionViaProrraRec.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaProrraRec.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaProrraRec.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaProrraRec.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = True
			End If
			Return _mcecatLotesCabCollectionViaProrraRec
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaProrraRec'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaProrraRec is requested or GetMultiMcecatLotesCabCollectionViaProrraRec is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaProrraRec(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaProrraRec.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaProrraRec.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, "__McecatCorralesCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch, _mcecatLotesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
				_mcecatLotesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = True
			End If
			Return _mcecatLotesCabCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaSalidaGanadoCab is requested or GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McecatCorralesCabFieldIndex.IdCorral), ComparisonOperator.Equal, Me.IdCorral))
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

		''' <summary>Retrieves the related entity of type 'McecatTiposCorralEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatTiposCorralEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatTiposCorral() As McecatTiposCorralEntity
			Return GetSingleMcecatTiposCorral(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatTiposCorralEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatTiposCorralEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatTiposCorral(forceFetch As Boolean) As McecatTiposCorralEntity
			If ( Not _alreadyFetchedMcecatTiposCorral Or forceFetch Or _alwaysFetchMcecatTiposCorral) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatTiposCorralEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McecatCorralesCabEntity.Relations.McecatTiposCorralEntityUsingIdTipoCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdTipoCorral)
				End If
				If Not _mcecatTiposCorralReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatTiposCorral = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatTiposCorralEntity)
					End If
					Me.McecatTiposCorral = newEntity
					_alreadyFetchedMcecatTiposCorral = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatTiposCorral
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McecatCorralesCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McecatCorralesCabFieldIndex)



					Case McecatCorralesCabFieldIndex.IdTipoCorral
						DesetupSyncMcecatTiposCorral(True, False)
						_alreadyFetchedMcecatTiposCorral = False








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
			_cabRegCom.ActiveContext = MyBase.ActiveContext
			_detAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCab.ActiveContext = MyBase.ActiveContext
			_mcgcompraGanadoCab.ActiveContext = MyBase.ActiveContext
			_prorraRec.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_aplicMediCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_aplicMediDetCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_cabAplForCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet.ActiveContext = MyBase.ActiveContext
			_cierreLoteCollectionViaMcecatLotesCab.ActiveContext = MyBase.ActiveContext
			_catProveedoresCollectionViaMcgcompraGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
		If Not _mcecatTiposCorral Is Nothing Then
				_mcecatTiposCorral.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McecatCorralesCabDAO = CType(CreateDAOInstance(), McecatCorralesCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McecatCorralesCabDAO = CType(CreateDAOInstance(), McecatCorralesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McecatCorralesCabDAO = CType(CreateDAOInstance(), McecatCorralesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McecatCorralesCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McecatCorralesCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="validator">The validator Object for this McecatCorralesCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCorral As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCorral, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_aplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_aplicMediDet.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchAplicMediDet = False
			_alreadyFetchedAplicMediDet = False
			_aplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(New AplicMediDetDetEntityFactory())
			_aplicMediDetDet.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchAplicMediDetDet = False
			_alreadyFetchedAplicMediDetDet = False
			_cabRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_detAplFor = New Integralab.ORM.CollectionClasses.DetAplForCollection(New DetAplForEntityFactory())
			_detAplFor.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchDetAplFor = False
			_alreadyFetchedDetAplFor = False
			_mcecatCorralesDet = New Integralab.ORM.CollectionClasses.McecatCorralesDetCollection(New McecatCorralesDetEntityFactory())
			_mcecatCorralesDet.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchMcecatCorralesDet = False
			_alreadyFetchedMcecatCorralesDet = False
			_mcecatLotesCab = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_mcecatLotesCab.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchMcecatLotesCab = False
			_alreadyFetchedMcecatLotesCab = False
			_mcgcompraGanadoCab = New Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection(New McgcompraGanadoCabEntityFactory())
			_mcgcompraGanadoCab.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchMcgcompraGanadoCab = False
			_alreadyFetchedMcgcompraGanadoCab = False
			_prorraRec = New Integralab.ORM.CollectionClasses.ProrraRecCollection(New ProrraRecEntityFactory())
			_prorraRec.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchProrraRec = False
			_alreadyFetchedProrraRec = False
			_salidaGanadoCab = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_salidaGanadoCab.SetContainingEntityInfo(Me, "McecatCorralesCab")
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_aplicMediCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDet = False
			_productoCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDet = False
			_mcecatLotesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = False
			_aplicMediCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediCollection(New AplicMediEntityFactory())
			_alwaysFetchAplicMediCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediCollectionViaAplicMediDetDet = False
			_aplicMediDetCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = False
			_productoCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDetDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = False
			_mcecatLotesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = False
			_cabMovGanCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = False
			_cabMovGanCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = False
			_catLugaresDeCompraCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = False
			_proveedorCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCabRegCom = False
			_alreadyFetchedProveedorCollectionViaCabRegCom = False
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_cabAplForCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.CabAplForCollection(New CabAplForEntityFactory())
			_alwaysFetchCabAplForCollectionViaDetAplFor = False
			_alreadyFetchedCabAplForCollectionViaDetAplFor = False
			_productoCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetAplFor = False
			_alreadyFetchedProductoCollectionViaDetAplFor = False
			_mcecatLotesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = False
			_mcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = False
			_cierreLoteCollectionViaMcecatLotesCab = New Integralab.ORM.CollectionClasses.CierreLoteCollection(New CierreLoteEntityFactory())
			_alwaysFetchCierreLoteCollectionViaMcecatLotesCab = False
			_alreadyFetchedCierreLoteCollectionViaMcecatLotesCab = False
			_catProveedoresCollectionViaMcgcompraGanadoCab = New Integralab.ORM.CollectionClasses.CatProveedoresCollection(New CatProveedoresEntityFactory())
			_alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab = False
			_alreadyFetchedCatProveedoresCollectionViaMcgcompraGanadoCab = False
			_mcecatLotesCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaProrraRec = False
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = False
			_salidaGanadoCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaProrraRec = False
			_alreadyFetchedSalidaGanadoCabCollectionViaProrraRec = False
			_cabMovGanCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = False
			_mcecatLotesCabCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = False
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(New McgcatCausasMuerteEntityFactory())
			_alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = False
			_catRastrosCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CatRastrosCollection(New CatRastrosEntityFactory())
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = False
			_polizaCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = False
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = False
			_mcecatTiposCorral = Nothing
			_mcecatTiposCorralReturnsNewIfNotFound = True
			_alwaysFetchMcecatTiposCorral = False
			_alreadyFetchedMcecatTiposCorral = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NombreCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomCorCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Capacidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Superficie", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("QuiendioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCorral", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mcecatTiposCorral</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatTiposCorral(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatTiposCorral, AddressOf OnMcecatTiposCorralPropertyChanged, "McecatTiposCorral", McecatCorralesCabEntity.Relations.McecatTiposCorralEntityUsingIdTipoCorral, True, signalRelatedEntity, "McecatCorralesCab", resetFKFields, New Integer() { CInt(McecatCorralesCabFieldIndex.IdTipoCorral) } )
			_mcecatTiposCorral = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatTiposCorral</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatTiposCorral(relatedEntity As IEntity)
			DesetupSyncMcecatTiposCorral(True, True)
			_mcecatTiposCorral = CType(relatedEntity, McecatTiposCorralEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatTiposCorral, AddressOf OnMcecatTiposCorralPropertyChanged, "McecatTiposCorral", McecatCorralesCabEntity.Relations.McecatTiposCorralEntityUsingIdTipoCorral, True, _alreadyFetchedMcecatTiposCorral, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatTiposCorralPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idCorral">PK value for McecatCorralesCab which data should be fetched into this McecatCorralesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCorral As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McecatCorralesCabFieldIndex.IdCorral)).ForcedCurrentValueWrite(idCorral)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcecatCorralesCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McecatCorralesCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McecatCorralesCabRelations
			Get	
				Return New McecatCorralesCabRelations() 
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
					McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDetDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAplForCollection(), _
					McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.DetAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesDetCollection(), _
					McecatCorralesCabEntity.Relations.McecatCorralesDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.McecatLotesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcompraGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcompraGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection(), _
					McecatCorralesCabEntity.Relations.McgcompraGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcompraGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcompraGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProrraRec' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProrraRec() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProrraRecCollection(), _
					McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProrraRecEntity, Integer), 0, Nothing, Nothing, Nothing, "ProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediDetCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.AplicMediDetDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanadoCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					McecatCorralesCabEntity.Relations.CabRegComEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCompradoresdeGanadoCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabAplForCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.CabAplForEntityUsingFolAplF)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabAplForCollection(), _
					McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), 0, Nothing, Nothing, relations, "CabAplForCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.DetAplForEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.McecatCorralesDetEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatCorralesDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					McecatCorralesCabEntity.Relations.McecatCorralesDetEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaMcecatCorralesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CierreLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCierreLoteCollectionViaMcecatLotesCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.McecatLotesCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatLotesCabEntity.Relations.CierreLoteEntityUsingIdCierreLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CierreLoteCollection(), _
					McecatCorralesCabEntity.Relations.McecatLotesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CierreLoteEntity, Integer), 0, Nothing, Nothing, relations, "CierreLoteCollectionViaMcecatLotesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatProveedores' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatProveedoresCollectionViaMcgcompraGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.McgcompraGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(McgcompraGanadoCabEntity.Relations.CatProveedoresEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatProveedoresCollection(), _
					McecatCorralesCabEntity.Relations.McgcompraGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CatProveedoresEntity, Integer), 0, Nothing, Nothing, relations, "CatProveedoresCollectionViaMcgcompraGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McecatCorralesCabEntity.Relations.ProrraRecEntityUsingIdCorralReciba, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCausasMuerte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCausasMuerteCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCausasMuerteCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, "__McecatCorralesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					McecatCorralesCabEntity.Relations.SalidaGanadoCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatTiposCorral' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatTiposCorral() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatTiposCorralCollection(), _
					McecatCorralesCabEntity.Relations.McecatTiposCorralEntityUsingIdTipoCorral, _
					CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatTiposCorralEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatTiposCorral", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McecatCorralesCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McecatCorralesCabEntity.CustomProperties
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
				Return McecatCorralesCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCorral property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."IdCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.IdCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.IdCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The NombreCorral property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."NombreCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NombreCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.NombreCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.NombreCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomCorCorral property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."NomCorCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomCorCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.NomCorCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.NomCorCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdTipoCorral property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."IdTipoCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdTipoCorral]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.IdTipoCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.IdTipoCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The Capacidad property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."Capacidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Capacidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.Capacidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.Capacidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Superficie property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."Superficie"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Superficie]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.Superficie, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.Superficie, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.FechaBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."MotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.MotivoBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The QuiendioBaja property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."QuiendioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [QuiendioBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.QuiendioBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.QuiendioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCorral property of the Entity McecatCorralesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCECatCorralesCab"."TipoCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCorral]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McecatCorralesCabFieldIndex.TipoCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McecatCorralesCabFieldIndex.TipoCorral, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesDet]() As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
			Get
				Return GetMultiMcecatCorralesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesDet. When set to true, McecatCorralesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesDet
			End Get
			Set
				_alwaysFetchMcecatCorralesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCab]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCab. When set to true, McecatLotesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCab
			End Get
			Set
				_alwaysFetchMcecatLotesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcompraGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcompraGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcompraGanadoCab]() As Integralab.ORM.CollectionClasses.McgcompraGanadoCabCollection
			Get
				Return GetMultiMcgcompraGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcompraGanadoCab. When set to true, McgcompraGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcompraGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcompraGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcompraGanadoCab As Boolean
			Get
				Return _alwaysFetchMcgcompraGanadoCab
			End Get
			Set
				_alwaysFetchMcgcompraGanadoCab = value
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCabRegCom. When set to true, ProveedorCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCabRegCom = value
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
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaMcecatCorralesDet]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaMcecatCorralesDet. When set to true, McgcatTiposdeGanadoCollectionViaMcecatCorralesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaMcecatCorralesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaMcecatCorralesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CierreLoteEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCierreLoteCollectionViaMcecatLotesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CierreLoteCollectionViaMcecatLotesCab]() As Integralab.ORM.CollectionClasses.CierreLoteCollection
			Get
				Return GetMultiCierreLoteCollectionViaMcecatLotesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CierreLoteCollectionViaMcecatLotesCab. When set to true, CierreLoteCollectionViaMcecatLotesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CierreLoteCollectionViaMcecatLotesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCierreLoteCollectionViaMcecatLotesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCierreLoteCollectionViaMcecatLotesCab As Boolean
			Get
				Return _alwaysFetchCierreLoteCollectionViaMcecatLotesCab
			End Get
			Set
				_alwaysFetchCierreLoteCollectionViaMcecatLotesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatProveedoresEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatProveedoresCollectionViaMcgcompraGanadoCab]() As Integralab.ORM.CollectionClasses.CatProveedoresCollection
			Get
				Return GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatProveedoresCollectionViaMcgcompraGanadoCab. When set to true, CatProveedoresCollectionViaMcgcompraGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatProveedoresCollectionViaMcgcompraGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatProveedoresCollectionViaMcgcompraGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab As Boolean
			Get
				Return _alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab
			End Get
			Set
				_alwaysFetchCatProveedoresCollectionViaMcgcompraGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaProrraRec()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaProrraRec]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaProrraRec(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaProrraRec. When set to true, McecatLotesCabCollectionViaProrraRec is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaProrraRec is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaProrraRec(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaProrraRec As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaProrraRec
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaProrraRec = value
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
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaSalidaGanadoCab. When set to true, McecatLotesCabCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = value
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
	
	
		''' <summary>Gets / sets related entity of type 'McecatTiposCorralEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatTiposCorral()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatTiposCorral]() As McecatTiposCorralEntity
			Get
				Return GetSingleMcecatTiposCorral(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatTiposCorral(value)
				Else
					If value Is Nothing Then
						If Not _mcecatTiposCorral Is Nothing Then
							_mcecatTiposCorral.UnsetRelatedEntity(Me, "McecatCorralesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McecatCorralesCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatTiposCorral. When set to true, McecatTiposCorral is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatTiposCorral is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatTiposCorral(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatTiposCorral As Boolean
			Get
				Return _alwaysFetchMcecatTiposCorral
			End Get
			Set
				_alwaysFetchMcecatTiposCorral = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatTiposCorral is not found
		''' in the database. When set to true, McecatTiposCorral will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatTiposCorralReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatTiposCorralReturnsNewIfNotFound
			End Get
			Set
				_mcecatTiposCorralReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.McecatCorralesCabEntity)
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
