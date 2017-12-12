' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:15
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
	''' <summary>Entity class which represents the entity 'MscmovtosAlmacenCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscmovtosAlmacenCabEntity 
#Else
	<Serializable()> _
	Public Class MscmovtosAlmacenCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
		Private _alwaysFetchMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesDet As Boolean
		Private _mscdetCanalAcorte As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
		Private _alwaysFetchMscdetCanalAcorte, _alreadyFetchedMscdetCanalAcorte As Boolean
		Private _mscdetCanalAcorte_ As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
		Private _alwaysFetchMscdetCanalAcorte_, _alreadyFetchedMscdetCanalAcorte_ As Boolean
		Private _mscloteCortesDet As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
		Private _alwaysFetchMscloteCortesDet, _alreadyFetchedMscloteCortesDet As Boolean
		Private _mscmovtosAlmacenDet As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
		Private _alwaysFetchMscmovtosAlmacenDet, _alreadyFetchedMscmovtosAlmacenDet As Boolean
		Private _mscrecepcionCanalesDet As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
		Private _alwaysFetchMscrecepcionCanalesDet, _alreadyFetchedMscrecepcionCanalesDet As Boolean
		Private _mscrecepcionCanalesDet_ As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
		Private _alwaysFetchMscrecepcionCanalesDet_, _alreadyFetchedMscrecepcionCanalesDet_ As Boolean
		Private _usrProdRegistroSacrificiosDecomiso As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
		Private _alwaysFetchUsrProdRegistroSacrificiosDecomiso, _alreadyFetchedUsrProdRegistroSacrificiosDecomiso As Boolean
		Private _usrProdRegistroSacrificiosDecomiso_ As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
		Private _alwaysFetchUsrProdRegistroSacrificiosDecomiso_, _alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ As Boolean
		Private _registroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisos, _alreadyFetchedRegistroSacrificiosDecomisos As Boolean
		Private _registroSacrificiosDecomisos_ As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisos_, _alreadyFetchedRegistroSacrificiosDecomisos_ As Boolean
		Private _mfacEmbarquesCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
		Private _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet, _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Boolean
		Private _mscloteCortesCabCollectionViaMscloteCortesDet As Integralab.ORM.CollectionClasses.MscloteCortesCabCollection
		Private _alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet, _alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet As Boolean
		Private _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
		Private _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet, _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet As Boolean
		Private _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
		Private _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_, _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ As Boolean
		Private _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
		Private _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso, _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso As Boolean
		Private _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
		Private _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_, _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Boolean
		Private _almacenCollectionViaRegistroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos, _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos As Boolean
		Private _almacenCollectionViaRegistroSacrificiosDecomisos_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_, _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ As Boolean
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
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		Public Sub New(idFolioMovimiento As System.String)

			InitClassFetch(idFolioMovimiento, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idFolioMovimiento As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idFolioMovimiento, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="validator">The custom validator Object for this MscmovtosAlmacenCabEntity</param>
		Public Sub New(idFolioMovimiento As System.String, validator As IValidator)

			InitClassFetch(idFolioMovimiento, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)
			_alwaysFetchMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesDet")
			_mscdetCanalAcorte = CType(info.GetValue("_mscdetCanalAcorte", GetType(Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection)), Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection)
			_alwaysFetchMscdetCanalAcorte = info.GetBoolean("_alwaysFetchMscdetCanalAcorte")
			_alreadyFetchedMscdetCanalAcorte = info.GetBoolean("_alreadyFetchedMscdetCanalAcorte")
			_mscdetCanalAcorte_ = CType(info.GetValue("_mscdetCanalAcorte_", GetType(Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection)), Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection)
			_alwaysFetchMscdetCanalAcorte_ = info.GetBoolean("_alwaysFetchMscdetCanalAcorte_")
			_alreadyFetchedMscdetCanalAcorte_ = info.GetBoolean("_alreadyFetchedMscdetCanalAcorte_")
			_mscloteCortesDet = CType(info.GetValue("_mscloteCortesDet", GetType(Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)), Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)
			_alwaysFetchMscloteCortesDet = info.GetBoolean("_alwaysFetchMscloteCortesDet")
			_alreadyFetchedMscloteCortesDet = info.GetBoolean("_alreadyFetchedMscloteCortesDet")
			_mscmovtosAlmacenDet = CType(info.GetValue("_mscmovtosAlmacenDet", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection)
			_alwaysFetchMscmovtosAlmacenDet = info.GetBoolean("_alwaysFetchMscmovtosAlmacenDet")
			_alreadyFetchedMscmovtosAlmacenDet = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenDet")
			_mscrecepcionCanalesDet = CType(info.GetValue("_mscrecepcionCanalesDet", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)
			_alwaysFetchMscrecepcionCanalesDet = info.GetBoolean("_alwaysFetchMscrecepcionCanalesDet")
			_alreadyFetchedMscrecepcionCanalesDet = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesDet")
			_mscrecepcionCanalesDet_ = CType(info.GetValue("_mscrecepcionCanalesDet_", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)
			_alwaysFetchMscrecepcionCanalesDet_ = info.GetBoolean("_alwaysFetchMscrecepcionCanalesDet_")
			_alreadyFetchedMscrecepcionCanalesDet_ = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesDet_")
			_usrProdRegistroSacrificiosDecomiso = CType(info.GetValue("_usrProdRegistroSacrificiosDecomiso", GetType(Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)), Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alwaysFetchUsrProdRegistroSacrificiosDecomiso")
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso")
			_usrProdRegistroSacrificiosDecomiso_ = CType(info.GetValue("_usrProdRegistroSacrificiosDecomiso_", GetType(Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)), Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alwaysFetchUsrProdRegistroSacrificiosDecomiso_")
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_")
			_registroSacrificiosDecomisos = CType(info.GetValue("_registroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos")
			_alreadyFetchedRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos")
			_registroSacrificiosDecomisos_ = CType(info.GetValue("_registroSacrificiosDecomisos_", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisos_ = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos_")
			_alreadyFetchedRegistroSacrificiosDecomisos_ = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos_")
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = CType(info.GetValue("_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet")
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet")
			_mscloteCortesCabCollectionViaMscloteCortesDet = CType(info.GetValue("_mscloteCortesCabCollectionViaMscloteCortesDet", GetType(Integralab.ORM.CollectionClasses.MscloteCortesCabCollection)), Integralab.ORM.CollectionClasses.MscloteCortesCabCollection)
			_alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet = info.GetBoolean("_alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet")
			_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet = info.GetBoolean("_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet")
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = CType(info.GetValue("_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)
			_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = info.GetBoolean("_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet")
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet")
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = CType(info.GetValue("_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)
			_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = info.GetBoolean("_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_")
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_")
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = CType(info.GetValue("_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso", GetType(Integralab.ORM.CollectionClasses.MsccatDecomisosCollection)), Integralab.ORM.CollectionClasses.MsccatDecomisosCollection)
			_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso")
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso")
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = CType(info.GetValue("_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_", GetType(Integralab.ORM.CollectionClasses.MsccatDecomisosCollection)), Integralab.ORM.CollectionClasses.MsccatDecomisosCollection)
			_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_")
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_")
			_almacenCollectionViaRegistroSacrificiosDecomisos = CType(info.GetValue("_almacenCollectionViaRegistroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos")
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos")
			_almacenCollectionViaRegistroSacrificiosDecomisos_ = CType(info.GetValue("_almacenCollectionViaRegistroSacrificiosDecomisos_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_")
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_")
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
			_alreadyFetchedMfacEmbarquesDet = (_mfacEmbarquesDet.Count > 0)
			_alreadyFetchedMscdetCanalAcorte = (_mscdetCanalAcorte.Count > 0)
			_alreadyFetchedMscdetCanalAcorte_ = (_mscdetCanalAcorte_.Count > 0)
			_alreadyFetchedMscloteCortesDet = (_mscloteCortesDet.Count > 0)
			_alreadyFetchedMscmovtosAlmacenDet = (_mscmovtosAlmacenDet.Count > 0)
			_alreadyFetchedMscrecepcionCanalesDet = (_mscrecepcionCanalesDet.Count > 0)
			_alreadyFetchedMscrecepcionCanalesDet_ = (_mscrecepcionCanalesDet_.Count > 0)
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = (_usrProdRegistroSacrificiosDecomiso.Count > 0)
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ = (_usrProdRegistroSacrificiosDecomiso_.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisos = (_registroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisos_ = (_registroSacrificiosDecomisos_.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = (_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = (_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet = (_mscloteCortesCabCollectionViaMscloteCortesDet.Count > 0)
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = (_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.Count > 0)
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = (_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.Count > 0)
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = (_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.Count > 0)
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = (_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.Count > 0)
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos = (_almacenCollectionViaRegistroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ = (_almacenCollectionViaRegistroSacrificiosDecomisos_.Count > 0)
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
			info.AddValue("_mfacEmbarquesDet", _mfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesDet", _alwaysFetchMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesDet)
			info.AddValue("_mscdetCanalAcorte", _mscdetCanalAcorte)
			info.AddValue("_alwaysFetchMscdetCanalAcorte", _alwaysFetchMscdetCanalAcorte)
			info.AddValue("_alreadyFetchedMscdetCanalAcorte", _alreadyFetchedMscdetCanalAcorte)
			info.AddValue("_mscdetCanalAcorte_", _mscdetCanalAcorte_)
			info.AddValue("_alwaysFetchMscdetCanalAcorte_", _alwaysFetchMscdetCanalAcorte_)
			info.AddValue("_alreadyFetchedMscdetCanalAcorte_", _alreadyFetchedMscdetCanalAcorte_)
			info.AddValue("_mscloteCortesDet", _mscloteCortesDet)
			info.AddValue("_alwaysFetchMscloteCortesDet", _alwaysFetchMscloteCortesDet)
			info.AddValue("_alreadyFetchedMscloteCortesDet", _alreadyFetchedMscloteCortesDet)
			info.AddValue("_mscmovtosAlmacenDet", _mscmovtosAlmacenDet)
			info.AddValue("_alwaysFetchMscmovtosAlmacenDet", _alwaysFetchMscmovtosAlmacenDet)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenDet", _alreadyFetchedMscmovtosAlmacenDet)
			info.AddValue("_mscrecepcionCanalesDet", _mscrecepcionCanalesDet)
			info.AddValue("_alwaysFetchMscrecepcionCanalesDet", _alwaysFetchMscrecepcionCanalesDet)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesDet", _alreadyFetchedMscrecepcionCanalesDet)
			info.AddValue("_mscrecepcionCanalesDet_", _mscrecepcionCanalesDet_)
			info.AddValue("_alwaysFetchMscrecepcionCanalesDet_", _alwaysFetchMscrecepcionCanalesDet_)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesDet_", _alreadyFetchedMscrecepcionCanalesDet_)
			info.AddValue("_usrProdRegistroSacrificiosDecomiso", _usrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alwaysFetchUsrProdRegistroSacrificiosDecomiso", _alwaysFetchUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso", _alreadyFetchedUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_usrProdRegistroSacrificiosDecomiso_", _usrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alwaysFetchUsrProdRegistroSacrificiosDecomiso_", _alwaysFetchUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_", _alreadyFetchedUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_registroSacrificiosDecomisos", _registroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos", _alwaysFetchRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos", _alreadyFetchedRegistroSacrificiosDecomisos)
			info.AddValue("_registroSacrificiosDecomisos_", _registroSacrificiosDecomisos_)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos_", _alwaysFetchRegistroSacrificiosDecomisos_)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos_", _alreadyFetchedRegistroSacrificiosDecomisos_)
			info.AddValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", _mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_mscloteCortesCabCollectionViaMscloteCortesDet", _mscloteCortesCabCollectionViaMscloteCortesDet)
			info.AddValue("_alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet", _alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet)
			info.AddValue("_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet", _alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet)
			info.AddValue("_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet", _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet", _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet", _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_", _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_", _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_", _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso", _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso", _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso", _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_", _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_", _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_", _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_almacenCollectionViaRegistroSacrificiosDecomisos", _almacenCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos", _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos", _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos)
			info.AddValue("_almacenCollectionViaRegistroSacrificiosDecomisos_", _almacenCollectionViaRegistroSacrificiosDecomisos_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_", _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_", _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_)
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
				Case "MfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesDet.Add(CType(entity, MfacEmbarquesDetEntity))
					End If
				Case "MscdetCanalAcorte"
					_alreadyFetchedMscdetCanalAcorte = True
					If Not entity Is Nothing Then
						Me.MscdetCanalAcorte.Add(CType(entity, MscdetCanalAcorteEntity))
					End If
				Case "MscdetCanalAcorte_"
					_alreadyFetchedMscdetCanalAcorte_ = True
					If Not entity Is Nothing Then
						Me.MscdetCanalAcorte_.Add(CType(entity, MscdetCanalAcorteEntity))
					End If
				Case "MscloteCortesDet"
					_alreadyFetchedMscloteCortesDet = True
					If Not entity Is Nothing Then
						Me.MscloteCortesDet.Add(CType(entity, MscloteCortesDetEntity))
					End If
				Case "MscmovtosAlmacenDet"
					_alreadyFetchedMscmovtosAlmacenDet = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenDet.Add(CType(entity, MscmovtosAlmacenDetEntity))
					End If
				Case "MscrecepcionCanalesDet"
					_alreadyFetchedMscrecepcionCanalesDet = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesDet.Add(CType(entity, MscrecepcionCanalesDetEntity))
					End If
				Case "MscrecepcionCanalesDet_"
					_alreadyFetchedMscrecepcionCanalesDet_ = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesDet_.Add(CType(entity, MscrecepcionCanalesDetEntity))
					End If
				Case "UsrProdRegistroSacrificiosDecomiso"
					_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = True
					If Not entity Is Nothing Then
						Me.UsrProdRegistroSacrificiosDecomiso.Add(CType(entity, UsrProdRegistroSacrificiosDecomisoEntity))
					End If
				Case "UsrProdRegistroSacrificiosDecomiso_"
					_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ = True
					If Not entity Is Nothing Then
						Me.UsrProdRegistroSacrificiosDecomiso_.Add(CType(entity, UsrProdRegistroSacrificiosDecomisoEntity))
					End If
				Case "RegistroSacrificiosDecomisos"
					_alreadyFetchedRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisos.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "RegistroSacrificiosDecomisos_"
					_alreadyFetchedRegistroSacrificiosDecomisos_ = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisos_.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet"
					_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "MscloteCortesCabCollectionViaMscloteCortesDet"
					_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet = True
					If Not entity Is Nothing Then
						Me.MscloteCortesCabCollectionViaMscloteCortesDet.Add(CType(entity, MscloteCortesCabEntity))
					End If
				Case "MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet"
					_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.Add(CType(entity, MscrecepcionCanalesCabEntity))
					End If
				Case "MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_"
					_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.Add(CType(entity, MscrecepcionCanalesCabEntity))
					End If
				Case "MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso"
					_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = True
					If Not entity Is Nothing Then
						Me.MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.Add(CType(entity, MsccatDecomisosEntity))
					End If
				Case "MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_"
					_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = True
					If Not entity Is Nothing Then
						Me.MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.Add(CType(entity, MsccatDecomisosEntity))
					End If
				Case "AlmacenCollectionViaRegistroSacrificiosDecomisos"
					_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaRegistroSacrificiosDecomisos.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaRegistroSacrificiosDecomisos_"
					_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaRegistroSacrificiosDecomisos_.Add(CType(entity, AlmacenEntity))
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
				Case "MfacEmbarquesDet"
					_mfacEmbarquesDet.Add(CType(relatedEntity, MfacEmbarquesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscdetCanalAcorte"
					_mscdetCanalAcorte.Add(CType(relatedEntity, MscdetCanalAcorteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscdetCanalAcorte_"
					_mscdetCanalAcorte_.Add(CType(relatedEntity, MscdetCanalAcorteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesDet"
					_mscloteCortesDet.Add(CType(relatedEntity, MscloteCortesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenDet"
					_mscmovtosAlmacenDet.Add(CType(relatedEntity, MscmovtosAlmacenDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet"
					_mscrecepcionCanalesDet.Add(CType(relatedEntity, MscrecepcionCanalesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet_"
					_mscrecepcionCanalesDet_.Add(CType(relatedEntity, MscrecepcionCanalesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					_usrProdRegistroSacrificiosDecomiso.Add(CType(relatedEntity, UsrProdRegistroSacrificiosDecomisoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso_"
					_usrProdRegistroSacrificiosDecomiso_.Add(CType(relatedEntity, UsrProdRegistroSacrificiosDecomisoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					_registroSacrificiosDecomisos.Add(CType(relatedEntity, RegistroSacrificiosDecomisosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos_"
					_registroSacrificiosDecomisos_.Add(CType(relatedEntity, RegistroSacrificiosDecomisosEntity))
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
				Case "MfacEmbarquesDet"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscdetCanalAcorte"
					MyBase.PerformRelatedEntityRemoval(_mscdetCanalAcorte, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscdetCanalAcorte_"
					MyBase.PerformRelatedEntityRemoval(_mscdetCanalAcorte_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesDet"
					MyBase.PerformRelatedEntityRemoval(_mscloteCortesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenDet"
					MyBase.PerformRelatedEntityRemoval(_mscmovtosAlmacenDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet"
					MyBase.PerformRelatedEntityRemoval(_mscrecepcionCanalesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet_"
					MyBase.PerformRelatedEntityRemoval(_mscrecepcionCanalesDet_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					MyBase.PerformRelatedEntityRemoval(_usrProdRegistroSacrificiosDecomiso, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso_"
					MyBase.PerformRelatedEntityRemoval(_usrProdRegistroSacrificiosDecomiso_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					MyBase.PerformRelatedEntityRemoval(_registroSacrificiosDecomisos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos_"
					MyBase.PerformRelatedEntityRemoval(_registroSacrificiosDecomisos_, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_mfacEmbarquesDet)
			toReturn.Add(_mscdetCanalAcorte)
			toReturn.Add(_mscdetCanalAcorte_)
			toReturn.Add(_mscloteCortesDet)
			toReturn.Add(_mscmovtosAlmacenDet)
			toReturn.Add(_mscrecepcionCanalesDet)
			toReturn.Add(_mscrecepcionCanalesDet_)
			toReturn.Add(_usrProdRegistroSacrificiosDecomiso)
			toReturn.Add(_usrProdRegistroSacrificiosDecomiso_)
			toReturn.Add(_registroSacrificiosDecomisos)
			toReturn.Add(_registroSacrificiosDecomisos_)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioMovimiento As System.String) As Boolean
			Return FetchUsingPK(idFolioMovimiento, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioMovimiento As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idFolioMovimiento, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idFolioMovimiento, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdFolioMovimiento, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscmovtosAlmacenCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscmovtosAlmacenCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, _mfacEmbarquesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, _mfacEmbarquesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			If ( Not _alreadyFetchedMfacEmbarquesDet Or forceFetch Or _alwaysFetchMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesDet)
					End If
				End If
				_mfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_mfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesDet = True
			End If
			Return _mfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesDet'. These settings will be taken into account
		''' when the property MfacEmbarquesDet is requested or GetMultiMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesDet.SortClauses=sortClauses
			_mfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscdetCanalAcorteEntity'</returns>
		Public Function GetMultiMscdetCanalAcorte(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte(forceFetch, _mscdetCanalAcorte.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscdetCanalAcorte(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscdetCanalAcorteEntity'</returns>
		Public Function GetMultiMscdetCanalAcorte(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte(forceFetch, _mscdetCanalAcorte.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscdetCanalAcorte(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			If ( Not _alreadyFetchedMscdetCanalAcorte Or forceFetch Or _alwaysFetchMscdetCanalAcorte) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscdetCanalAcorte.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscdetCanalAcorte)
					End If
				End If
				_mscdetCanalAcorte.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscdetCanalAcorte.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscdetCanalAcorte.GetMultiManyToOne(Me, Nothing, Filter)
				_mscdetCanalAcorte.SuppressClearInGetMulti = False
				_alreadyFetchedMscdetCanalAcorte = True
			End If
			Return _mscdetCanalAcorte
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscdetCanalAcorte'. These settings will be taken into account
		''' when the property MscdetCanalAcorte is requested or GetMultiMscdetCanalAcorte is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscdetCanalAcorte(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscdetCanalAcorte.SortClauses=sortClauses
			_mscdetCanalAcorte.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscdetCanalAcorteEntity'</returns>
		Public Function GetMultiMscdetCanalAcorte_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte_(forceFetch, _mscdetCanalAcorte_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscdetCanalAcorte_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscdetCanalAcorteEntity'</returns>
		Public Function GetMultiMscdetCanalAcorte_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Return GetMultiMscdetCanalAcorte_(forceFetch, _mscdetCanalAcorte_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscdetCanalAcorte_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			If ( Not _alreadyFetchedMscdetCanalAcorte_ Or forceFetch Or _alwaysFetchMscdetCanalAcorte_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscdetCanalAcorte_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscdetCanalAcorte_)
					End If
				End If
				_mscdetCanalAcorte_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscdetCanalAcorte_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscdetCanalAcorte_.GetMultiManyToOne(Nothing, Me, Filter)
				_mscdetCanalAcorte_.SuppressClearInGetMulti = False
				_alreadyFetchedMscdetCanalAcorte_ = True
			End If
			Return _mscdetCanalAcorte_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscdetCanalAcorte_'. These settings will be taken into account
		''' when the property MscdetCanalAcorte_ is requested or GetMultiMscdetCanalAcorte_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscdetCanalAcorte_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscdetCanalAcorte_.SortClauses=sortClauses
			_mscdetCanalAcorte_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetEntity'</returns>
		Public Function GetMultiMscloteCortesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet(forceFetch, _mscloteCortesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscloteCortesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetEntity'</returns>
		Public Function GetMultiMscloteCortesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet(forceFetch, _mscloteCortesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscloteCortesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			If ( Not _alreadyFetchedMscloteCortesDet Or forceFetch Or _alwaysFetchMscloteCortesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscloteCortesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscloteCortesDet)
					End If
				End If
				_mscloteCortesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscloteCortesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscloteCortesDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_mscloteCortesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscloteCortesDet = True
			End If
			Return _mscloteCortesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscloteCortesDet'. These settings will be taken into account
		''' when the property MscloteCortesDet is requested or GetMultiMscloteCortesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscloteCortesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscloteCortesDet.SortClauses=sortClauses
			_mscloteCortesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenDetEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
			Return GetMultiMscmovtosAlmacenDet(forceFetch, _mscmovtosAlmacenDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscmovtosAlmacenDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
			Return GetMultiMscmovtosAlmacenDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenDetEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
			Return GetMultiMscmovtosAlmacenDet(forceFetch, _mscmovtosAlmacenDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenDet Or forceFetch Or _alwaysFetchMscmovtosAlmacenDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenDet)
					End If
				End If
				_mscmovtosAlmacenDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenDet.GetMultiManyToOne(Nothing, Me, Filter)
				_mscmovtosAlmacenDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenDet = True
			End If
			Return _mscmovtosAlmacenDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenDet'. These settings will be taken into account
		''' when the property MscmovtosAlmacenDet is requested or GetMultiMscmovtosAlmacenDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenDet.SortClauses=sortClauses
			_mscmovtosAlmacenDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, _mscrecepcionCanalesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, _mscrecepcionCanalesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesDet Or forceFetch Or _alwaysFetchMscrecepcionCanalesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesDet)
					End If
				End If
				_mscrecepcionCanalesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesDet.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_mscrecepcionCanalesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesDet = True
			End If
			Return _mscrecepcionCanalesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesDet'. These settings will be taken into account
		''' when the property MscrecepcionCanalesDet is requested or GetMultiMscrecepcionCanalesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesDet.SortClauses=sortClauses
			_mscrecepcionCanalesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet_(forceFetch, _mscrecepcionCanalesDet_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrecepcionCanalesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet_(forceFetch, _mscrecepcionCanalesDet_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesDet_ Or forceFetch Or _alwaysFetchMscrecepcionCanalesDet_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesDet_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesDet_)
					End If
				End If
				_mscrecepcionCanalesDet_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesDet_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesDet_.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_mscrecepcionCanalesDet_.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesDet_ = True
			End If
			Return _mscrecepcionCanalesDet_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesDet_'. These settings will be taken into account
		''' when the property MscrecepcionCanalesDet_ is requested or GetMultiMscrecepcionCanalesDet_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesDet_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesDet_.SortClauses=sortClauses
			_mscrecepcionCanalesDet_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, _usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, _usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			If ( Not _alreadyFetchedUsrProdRegistroSacrificiosDecomiso Or forceFetch Or _alwaysFetchUsrProdRegistroSacrificiosDecomiso) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRegistroSacrificiosDecomiso.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRegistroSacrificiosDecomiso)
					End If
				End If
				_usrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRegistroSacrificiosDecomiso.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_usrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = True
			End If
			Return _usrProdRegistroSacrificiosDecomiso
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRegistroSacrificiosDecomiso'. These settings will be taken into account
		''' when the property UsrProdRegistroSacrificiosDecomiso is requested or GetMultiUsrProdRegistroSacrificiosDecomiso is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRegistroSacrificiosDecomiso(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRegistroSacrificiosDecomiso.SortClauses=sortClauses
			_usrProdRegistroSacrificiosDecomiso.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch, _usrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch, _usrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			If ( Not _alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ Or forceFetch Or _alwaysFetchUsrProdRegistroSacrificiosDecomiso_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRegistroSacrificiosDecomiso_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRegistroSacrificiosDecomiso_)
					End If
				End If
				_usrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRegistroSacrificiosDecomiso_.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_usrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ = True
			End If
			Return _usrProdRegistroSacrificiosDecomiso_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRegistroSacrificiosDecomiso_'. These settings will be taken into account
		''' when the property UsrProdRegistroSacrificiosDecomiso_ is requested or GetMultiUsrProdRegistroSacrificiosDecomiso_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRegistroSacrificiosDecomiso_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRegistroSacrificiosDecomiso_.SortClauses=sortClauses
			_usrProdRegistroSacrificiosDecomiso_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_registroSacrificiosDecomisos.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos_(forceFetch, _registroSacrificiosDecomisos_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos_(forceFetch, _registroSacrificiosDecomisos_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRegistroSacrificiosDecomisos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisos_ Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _registroSacrificiosDecomisos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_registroSacrificiosDecomisos_)
					End If
				End If
				_registroSacrificiosDecomisos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_registroSacrificiosDecomisos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_registroSacrificiosDecomisos_.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_registroSacrificiosDecomisos_.SuppressClearInGetMulti = False
				_alreadyFetchedRegistroSacrificiosDecomisos_ = True
			End If
			Return _registroSacrificiosDecomisos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RegistroSacrificiosDecomisos_'. These settings will be taken into account
		''' when the property RegistroSacrificiosDecomisos_ is requested or GetMultiRegistroSacrificiosDecomisos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRegistroSacrificiosDecomisos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_registroSacrificiosDecomisos_.SortClauses=sortClauses
			_registroSacrificiosDecomisos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch, _mfacEmbarquesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, "__MscmovtosAlmacenCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
			End If
			Return _mfacEmbarquesCabCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCabCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property MfacEmbarquesCabCollectionViaMfacEmbarquesDet is requested or GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCabCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch, _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, "__MscmovtosAlmacenCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = True
			End If
			Return _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is requested or GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscloteCortesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesCabEntity'</returns>
		Public Function GetMultiMscloteCortesCabCollectionViaMscloteCortesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscloteCortesCabCollection
			Return GetMultiMscloteCortesCabCollectionViaMscloteCortesDet(forceFetch, _mscloteCortesCabCollectionViaMscloteCortesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscloteCortesCabCollectionViaMscloteCortesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscloteCortesCabCollection
			If ( Not _alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet Or forceFetch Or _alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscloteCortesCabCollectionViaMscloteCortesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscloteCortesCabCollectionViaMscloteCortesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscloteCortesDetEntityUsingIdFolioMovimiento, "__MscmovtosAlmacenCabEntity__", "MscloteCortesDet_", JoinHint.None)
				relations.Add(MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte, "MscloteCortesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_mscloteCortesCabCollectionViaMscloteCortesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscloteCortesCabCollectionViaMscloteCortesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscloteCortesCabCollectionViaMscloteCortesDet.GetMulti(Filter, relations)
				_mscloteCortesCabCollectionViaMscloteCortesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet = True
			End If
			Return _mscloteCortesCabCollectionViaMscloteCortesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscloteCortesCabCollectionViaMscloteCortesDet'. These settings will be taken into account
		''' when the property MscloteCortesCabCollectionViaMscloteCortesDet is requested or GetMultiMscloteCortesCabCollectionViaMscloteCortesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscloteCortesCabCollectionViaMscloteCortesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscloteCortesCabCollectionViaMscloteCortesDet.SortClauses=sortClauses
			_mscloteCortesCabCollectionViaMscloteCortesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesCabEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Return GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(forceFetch, _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet Or forceFetch Or _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimiento, "__MscmovtosAlmacenCabEntity__", "MscrecepcionCanalesDet_", JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscrecepcionCanalesCabEntityUsingFolioMovimientoFolioSacrificio, "MscrecepcionCanalesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.GetMulti(Filter, relations)
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = True
			End If
			Return _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet'. These settings will be taken into account
		''' when the property MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet is requested or GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.SortClauses=sortClauses
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesCabEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Return GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(forceFetch, _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ Or forceFetch Or _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimientoCancela, "__MscmovtosAlmacenCabEntity__", "MscrecepcionCanalesDet_", JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscrecepcionCanalesCabEntityUsingFolioMovimientoFolioSacrificio, "MscrecepcionCanalesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.GetMulti(Filter, relations)
				_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = True
			End If
			Return _mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_'. These settings will be taken into account
		''' when the property MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ is requested or GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.SortClauses=sortClauses
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatDecomisosEntity'</returns>
		Public Function GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			Return GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch, _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			If ( Not _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso Or forceFetch Or _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioMovAlmacen, "__MscmovtosAlmacenCabEntity__", "UsrProdRegistroSacrificiosDecomiso_", JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MsccatDecomisosEntityUsingIdDecomiso, "UsrProdRegistroSacrificiosDecomiso_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.GetMulti(Filter, relations)
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = True
			End If
			Return _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso'. These settings will be taken into account
		''' when the property MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso is requested or GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.SortClauses=sortClauses
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatDecomisosEntity'</returns>
		Public Function GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			Return GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch, _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			If ( Not _alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ Or forceFetch Or _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioCancelAlmacen, "__MscmovtosAlmacenCabEntity__", "UsrProdRegistroSacrificiosDecomiso_", JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MsccatDecomisosEntityUsingIdDecomiso, "UsrProdRegistroSacrificiosDecomiso_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.GetMulti(Filter, relations)
				_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = True
			End If
			Return _msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_'. These settings will be taken into account
		''' when the property MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ is requested or GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.SortClauses=sortClauses
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos(forceFetch, _almacenCollectionViaRegistroSacrificiosDecomisos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos Or forceFetch Or _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaRegistroSacrificiosDecomisos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaRegistroSacrificiosDecomisos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioMovAlmacen, "__MscmovtosAlmacenCabEntity__", "RegistroSacrificiosDecomisos_", JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_almacenCollectionViaRegistroSacrificiosDecomisos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaRegistroSacrificiosDecomisos.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaRegistroSacrificiosDecomisos.GetMulti(Filter, relations)
				_almacenCollectionViaRegistroSacrificiosDecomisos.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos = True
			End If
			Return _almacenCollectionViaRegistroSacrificiosDecomisos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaRegistroSacrificiosDecomisos'. These settings will be taken into account
		''' when the property AlmacenCollectionViaRegistroSacrificiosDecomisos is requested or GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaRegistroSacrificiosDecomisos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaRegistroSacrificiosDecomisos.SortClauses=sortClauses
			_almacenCollectionViaRegistroSacrificiosDecomisos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_(forceFetch, _almacenCollectionViaRegistroSacrificiosDecomisos_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaRegistroSacrificiosDecomisos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaRegistroSacrificiosDecomisos_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioCancelAlmacen, "__MscmovtosAlmacenCabEntity__", "RegistroSacrificiosDecomisos_", JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd, "RegistroSacrificiosDecomisos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento), ComparisonOperator.Equal, Me.IdFolioMovimiento))
				_almacenCollectionViaRegistroSacrificiosDecomisos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaRegistroSacrificiosDecomisos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaRegistroSacrificiosDecomisos_.GetMulti(Filter, relations)
				_almacenCollectionViaRegistroSacrificiosDecomisos_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ = True
			End If
			Return _almacenCollectionViaRegistroSacrificiosDecomisos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaRegistroSacrificiosDecomisos_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaRegistroSacrificiosDecomisos_ is requested or GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaRegistroSacrificiosDecomisos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaRegistroSacrificiosDecomisos_.SortClauses=sortClauses
			_almacenCollectionViaRegistroSacrificiosDecomisos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCodAlmacen)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCodMovimiento)
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscmovtosAlmacenCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscmovtosAlmacenCabFieldIndex)

					Case MscmovtosAlmacenCabFieldIndex.IdCodAlmacen
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False


					Case MscmovtosAlmacenCabFieldIndex.IdCodMovimiento
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
			_mfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mscdetCanalAcorte.ActiveContext = MyBase.ActiveContext
			_mscdetCanalAcorte_.ActiveContext = MyBase.ActiveContext
			_mscloteCortesDet.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenDet.ActiveContext = MyBase.ActiveContext
			_mscrecepcionCanalesDet.ActiveContext = MyBase.ActiveContext
			_mscrecepcionCanalesDet_.ActiveContext = MyBase.ActiveContext
			_usrProdRegistroSacrificiosDecomiso.ActiveContext = MyBase.ActiveContext
			_usrProdRegistroSacrificiosDecomiso_.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisos_.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mscloteCortesCabCollectionViaMscloteCortesDet.ActiveContext = MyBase.ActiveContext
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet.ActiveContext = MyBase.ActiveContext
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_.ActiveContext = MyBase.ActiveContext
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso.ActiveContext = MyBase.ActiveContext
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaRegistroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaRegistroSacrificiosDecomisos_.ActiveContext = MyBase.ActiveContext
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
			Dim dao As MscmovtosAlmacenCabDAO = CType(CreateDAOInstance(), MscmovtosAlmacenCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscmovtosAlmacenCabDAO = CType(CreateDAOInstance(), MscmovtosAlmacenCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscmovtosAlmacenCabDAO = CType(CreateDAOInstance(), MscmovtosAlmacenCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscmovtosAlmacenCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="validator">The validator Object for this MscmovtosAlmacenCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idFolioMovimiento As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idFolioMovimiento, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(New MfacEmbarquesDetEntityFactory())
			_mfacEmbarquesDet.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesDet = False
			_mscdetCanalAcorte = New Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection(New MscdetCanalAcorteEntityFactory())
			_mscdetCanalAcorte.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchMscdetCanalAcorte = False
			_alreadyFetchedMscdetCanalAcorte = False
			_mscdetCanalAcorte_ = New Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection(New MscdetCanalAcorteEntityFactory())
			_mscdetCanalAcorte_.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab_")
			_alwaysFetchMscdetCanalAcorte_ = False
			_alreadyFetchedMscdetCanalAcorte_ = False
			_mscloteCortesDet = New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(New MscloteCortesDetEntityFactory())
			_mscloteCortesDet.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchMscloteCortesDet = False
			_alreadyFetchedMscloteCortesDet = False
			_mscmovtosAlmacenDet = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection(New MscmovtosAlmacenDetEntityFactory())
			_mscmovtosAlmacenDet.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchMscmovtosAlmacenDet = False
			_alreadyFetchedMscmovtosAlmacenDet = False
			_mscrecepcionCanalesDet = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(New MscrecepcionCanalesDetEntityFactory())
			_mscrecepcionCanalesDet.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchMscrecepcionCanalesDet = False
			_alreadyFetchedMscrecepcionCanalesDet = False
			_mscrecepcionCanalesDet_ = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(New MscrecepcionCanalesDetEntityFactory())
			_mscrecepcionCanalesDet_.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab_")
			_alwaysFetchMscrecepcionCanalesDet_ = False
			_alreadyFetchedMscrecepcionCanalesDet_ = False
			_usrProdRegistroSacrificiosDecomiso = New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(New UsrProdRegistroSacrificiosDecomisoEntityFactory())
			_usrProdRegistroSacrificiosDecomiso.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = False
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = False
			_usrProdRegistroSacrificiosDecomiso_ = New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(New UsrProdRegistroSacrificiosDecomisoEntityFactory())
			_usrProdRegistroSacrificiosDecomiso_.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab_")
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso_ = False
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso_ = False
			_registroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_registroSacrificiosDecomisos.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab")
			_alwaysFetchRegistroSacrificiosDecomisos = False
			_alreadyFetchedRegistroSacrificiosDecomisos = False
			_registroSacrificiosDecomisos_ = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_registroSacrificiosDecomisos_.SetContainingEntityInfo(Me, "MscmovtosAlmacenCab_")
			_alwaysFetchRegistroSacrificiosDecomisos_ = False
			_alreadyFetchedRegistroSacrificiosDecomisos_ = False
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = False
			_mscloteCortesCabCollectionViaMscloteCortesDet = New Integralab.ORM.CollectionClasses.MscloteCortesCabCollection(New MscloteCortesCabEntityFactory())
			_alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet = False
			_alreadyFetchedMscloteCortesCabCollectionViaMscloteCortesDet = False
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(New MscrecepcionCanalesCabEntityFactory())
			_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = False
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = False
			_mscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(New MscrecepcionCanalesCabEntityFactory())
			_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = False
			_alreadyFetchedMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = False
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = New Integralab.ORM.CollectionClasses.MsccatDecomisosCollection(New MsccatDecomisosEntityFactory())
			_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = False
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = False
			_msccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = New Integralab.ORM.CollectionClasses.MsccatDecomisosCollection(New MsccatDecomisosEntityFactory())
			_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = False
			_alreadyFetchedMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = False
			_almacenCollectionViaRegistroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos = False
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos = False
			_almacenCollectionViaRegistroSacrificiosDecomisos_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_ = False
			_alreadyFetchedAlmacenCollectionViaRegistroSacrificiosDecomisos_ = False
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

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCodAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCodMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contabilizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("QuienContabilizo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("QuienCancelo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovmientoReferencia", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen, True, signalRelatedEntity, "MscmovtosAlmacenCab", resetFKFields, New Integer() { CInt(MscmovtosAlmacenCabFieldIndex.IdCodAlmacen) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen, True, _alreadyFetchedAlmacen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMovimientoAlmacen, AddressOf OnTipoMovimientoAlmacenPropertyChanged, "TipoMovimientoAlmacen", MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, True, signalRelatedEntity, "MscmovtosAlmacenCab", resetFKFields, New Integer() { CInt(MscmovtosAlmacenCabFieldIndex.IdCodMovimiento) } )
			_tipoMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncTipoMovimientoAlmacen(True, True)
			_tipoMovimientoAlmacen = CType(relatedEntity, TipoMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMovimientoAlmacen, AddressOf OnTipoMovimientoAlmacenPropertyChanged, "TipoMovimientoAlmacen", MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, True, _alreadyFetchedTipoMovimientoAlmacen, New String() {  } )
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
		''' <param name="idFolioMovimiento">PK value for MscmovtosAlmacenCab which data should be fetched into this MscmovtosAlmacenCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idFolioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento)).ForcedCurrentValueWrite(idFolioMovimiento)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscmovtosAlmacenCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscmovtosAlmacenCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscmovtosAlmacenCabRelations
			Get	
				Return New MscmovtosAlmacenCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscdetCanalAcorte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscdetCanalAcorte() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscdetCanalAcorteEntityUsingIdFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscdetCanalAcorteEntity, Integer), 0, Nothing, Nothing, Nothing, "MscdetCanalAcorte", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscdetCanalAcorte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscdetCanalAcorte_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscdetCanalAcorteEntityUsingIdFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscdetCanalAcorteEntity, Integer), 0, Nothing, Nothing, Nothing, "MscdetCanalAcorte_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscloteCortesDetEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscmovtosAlmacenDetEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrecepcionCanalesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesDet_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimientoCancela, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrecepcionCanalesDet_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRegistroSacrificiosDecomiso' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRegistroSacrificiosDecomiso() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(), _
					MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioMovAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRegistroSacrificiosDecomisoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRegistroSacrificiosDecomiso", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRegistroSacrificiosDecomiso' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRegistroSacrificiosDecomiso_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(), _
					MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioCancelAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRegistroSacrificiosDecomisoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRegistroSacrificiosDecomiso_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioMovAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioCancelAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, relations, "RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesCabCollectionViaMscloteCortesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscloteCortesDetEntityUsingIdFolioMovimiento, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesCabCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscloteCortesDetEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesCabEntity, Integer), 0, Nothing, Nothing, relations, "MscloteCortesCabCollectionViaMscloteCortesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimiento, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscrecepcionCanalesCabEntityUsingFolioMovimientoFolioSacrificio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), 0, Nothing, Nothing, relations, "MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimientoCancela, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscrecepcionCanalesCabEntityUsingFolioMovimientoFolioSacrificio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(), _
					MscmovtosAlmacenCabEntity.Relations.MscrecepcionCanalesDetEntityUsingIdFolioMovimientoCancela, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), 0, Nothing, Nothing, relations, "MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioMovAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MsccatDecomisosEntityUsingIdDecomiso)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatDecomisosCollection(), _
					MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioMovAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), 0, Nothing, Nothing, relations, "MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioCancelAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MsccatDecomisosEntityUsingIdDecomiso)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatDecomisosCollection(), _
					MscmovtosAlmacenCabEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingFolioCancelAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), 0, Nothing, Nothing, relations, "MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioMovAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioMovAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaRegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaRegistroSacrificiosDecomisos_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioCancelAlmacen, "__MscmovtosAlmacenCabEntity__", String.Empty, JoinHint.None)
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MscmovtosAlmacenCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioCancelAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaRegistroSacrificiosDecomisos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMovimientoAlmacenCollection(), _
					MscmovtosAlmacenCabEntity.Relations.TipoMovimientoAlmacenEntityUsingIdCodMovimiento, _
					CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MscmovtosAlmacenCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscmovtosAlmacenCabEntity.CustomProperties
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
				Return MscmovtosAlmacenCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdFolioMovimiento property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."IdFolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdFolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCodAlmacen property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."IdCodAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCodAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdCodAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdCodAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCodMovimiento property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."IdCodMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCodMovimiento]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdCodMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdCodMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantPzas property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."CantPzas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantPzas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.CantPzas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.CantPzas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKilos property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."CantKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.CantKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.CantKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contabilizado property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."Contabilizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Contabilizado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.Contabilizado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.Contabilizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaContabilizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The QuienContabilizo property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."QuienContabilizo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [QuienContabilizo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.QuienContabilizo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.QuienContabilizo, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The QuienCancelo property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."QuienCancelo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [QuienCancelo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.QuienCancelo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.QuienCancelo, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionCancela property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."ObservacionCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionCancela]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.ObservacionCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.ObservacionCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovmientoReferencia property of the Entity MscmovtosAlmacenCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCMovtosAlmacenCab"."FolioMovmientoReferencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovmientoReferencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FolioMovmientoReferencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscmovtosAlmacenCabFieldIndex.FolioMovmientoReferencia, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Get
				Return GetMultiMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesDet. When set to true, MfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscdetCanalAcorte()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscdetCanalAcorte]() As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Get
				Return GetMultiMscdetCanalAcorte(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscdetCanalAcorte. When set to true, MscdetCanalAcorte is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscdetCanalAcorte is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscdetCanalAcorte(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscdetCanalAcorte As Boolean
			Get
				Return _alwaysFetchMscdetCanalAcorte
			End Get
			Set
				_alwaysFetchMscdetCanalAcorte = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscdetCanalAcorteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscdetCanalAcorte_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscdetCanalAcorte_]() As Integralab.ORM.CollectionClasses.MscdetCanalAcorteCollection
			Get
				Return GetMultiMscdetCanalAcorte_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscdetCanalAcorte_. When set to true, MscdetCanalAcorte_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscdetCanalAcorte_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscdetCanalAcorte_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscdetCanalAcorte_ As Boolean
			Get
				Return _alwaysFetchMscdetCanalAcorte_
			End Get
			Set
				_alwaysFetchMscdetCanalAcorte_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscloteCortesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscloteCortesDet]() As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Get
				Return GetMultiMscloteCortesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscloteCortesDet. When set to true, MscloteCortesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscloteCortesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscloteCortesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscloteCortesDet As Boolean
			Get
				Return _alwaysFetchMscloteCortesDet
			End Get
			Set
				_alwaysFetchMscloteCortesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenDet]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
			Get
				Return GetMultiMscmovtosAlmacenDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenDet. When set to true, MscmovtosAlmacenDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenDet As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenDet
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesDet]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Get
				Return GetMultiMscrecepcionCanalesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesDet. When set to true, MscrecepcionCanalesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesDet As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesDet
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesDet_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesDet_]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Get
				Return GetMultiMscrecepcionCanalesDet_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesDet_. When set to true, MscrecepcionCanalesDet_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesDet_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesDet_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesDet_ As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesDet_
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesDet_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRegistroSacrificiosDecomiso()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRegistroSacrificiosDecomiso]() As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Get
				Return GetMultiUsrProdRegistroSacrificiosDecomiso(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRegistroSacrificiosDecomiso. When set to true, UsrProdRegistroSacrificiosDecomiso is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRegistroSacrificiosDecomiso is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRegistroSacrificiosDecomiso(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRegistroSacrificiosDecomiso As Boolean
			Get
				Return _alwaysFetchUsrProdRegistroSacrificiosDecomiso
			End Get
			Set
				_alwaysFetchUsrProdRegistroSacrificiosDecomiso = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRegistroSacrificiosDecomiso_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRegistroSacrificiosDecomiso_]() As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Get
				Return GetMultiUsrProdRegistroSacrificiosDecomiso_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRegistroSacrificiosDecomiso_. When set to true, UsrProdRegistroSacrificiosDecomiso_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRegistroSacrificiosDecomiso_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRegistroSacrificiosDecomiso_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRegistroSacrificiosDecomiso_ As Boolean
			Get
				Return _alwaysFetchUsrProdRegistroSacrificiosDecomiso_
			End Get
			Set
				_alwaysFetchUsrProdRegistroSacrificiosDecomiso_ = value
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
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRegistroSacrificiosDecomisos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RegistroSacrificiosDecomisos_]() As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Get
				Return GetMultiRegistroSacrificiosDecomisos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisos_. When set to true, RegistroSacrificiosDecomisos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiRegistroSacrificiosDecomisos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisos_ As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisos_
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisos_ = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCabCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCabCollectionViaMfacEmbarquesDet. When set to true, MfacEmbarquesCabCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCabCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Get
				Return GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet. When set to true, RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscloteCortesCabCollectionViaMscloteCortesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscloteCortesCabCollectionViaMscloteCortesDet]() As Integralab.ORM.CollectionClasses.MscloteCortesCabCollection
			Get
				Return GetMultiMscloteCortesCabCollectionViaMscloteCortesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscloteCortesCabCollectionViaMscloteCortesDet. When set to true, MscloteCortesCabCollectionViaMscloteCortesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscloteCortesCabCollectionViaMscloteCortesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscloteCortesCabCollectionViaMscloteCortesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet As Boolean
			Get
				Return _alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet
			End Get
			Set
				_alwaysFetchMscloteCortesCabCollectionViaMscloteCortesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Get
				Return GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet. When set to true, MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Get
				Return GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_. When set to true, MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesCabCollectionViaMscrecepcionCanalesDet_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso]() As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			Get
				Return GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso. When set to true, MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso As Boolean
			Get
				Return _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso
			End Get
			Set
				_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_]() As Integralab.ORM.CollectionClasses.MsccatDecomisosCollection
			Get
				Return GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_. When set to true, MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Boolean
			Get
				Return _alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_
			End Get
			Set
				_alwaysFetchMsccatDecomisosCollectionViaUsrProdRegistroSacrificiosDecomiso_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaRegistroSacrificiosDecomisos]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaRegistroSacrificiosDecomisos. When set to true, AlmacenCollectionViaRegistroSacrificiosDecomisos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaRegistroSacrificiosDecomisos is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaRegistroSacrificiosDecomisos_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaRegistroSacrificiosDecomisos_. When set to true, AlmacenCollectionViaRegistroSacrificiosDecomisos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaRegistroSacrificiosDecomisos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaRegistroSacrificiosDecomisos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaRegistroSacrificiosDecomisos_ = value
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
							_almacen.UnsetRelatedEntity(Me, "MscmovtosAlmacenCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscmovtosAlmacenCab")
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
							_tipoMovimientoAlmacen.UnsetRelatedEntity(Me, "MscmovtosAlmacenCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscmovtosAlmacenCab")
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
				Return CInt(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity)
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
