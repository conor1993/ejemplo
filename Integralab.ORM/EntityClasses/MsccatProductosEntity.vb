' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 09:23:47
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
	''' <summary>Entity class which represents the entity 'MsccatProductos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MsccatProductosEntity 
#Else
	<Serializable()> _
	Public Class MsccatProductosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
		Private _alwaysFetchMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesDet As Boolean
		Private _minvTransferenciaAlmacenProdDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenProdDetalle, _alreadyFetchedMinvTransferenciaAlmacenProdDetalle As Boolean
		Private _msccatProductosDetalle As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
		Private _alwaysFetchMsccatProductosDetalle, _alreadyFetchedMsccatProductosDetalle As Boolean
		Private _msccortesPreCortes_ As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
		Private _alwaysFetchMsccortesPreCortes_, _alreadyFetchedMsccortesPreCortes_ As Boolean
		Private _devolucionProductos As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
		Private _alwaysFetchDevolucionProductos, _alreadyFetchedDevolucionProductos As Boolean
		Private _mscinventarioProducto As Integralab.ORM.CollectionClasses.MscinventarioProductoCollection
		Private _alwaysFetchMscinventarioProducto, _alreadyFetchedMscinventarioProducto As Boolean
		Private _mscloteCortesDet As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
		Private _alwaysFetchMscloteCortesDet, _alreadyFetchedMscloteCortesDet As Boolean
		Private _mscloteCortesDet_ As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
		Private _alwaysFetchMscloteCortesDet_, _alreadyFetchedMscloteCortesDet_ As Boolean
		Private _mscloteCortesDetComparacion As Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection
		Private _alwaysFetchMscloteCortesDetComparacion, _alreadyFetchedMscloteCortesDetComparacion As Boolean
		Private _mscmovtosAlmacenDet As Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection
		Private _alwaysFetchMscmovtosAlmacenDet, _alreadyFetchedMscmovtosAlmacenDet As Boolean
		Private _mscrelacionCortesClientes As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
		Private _alwaysFetchMscrelacionCortesClientes, _alreadyFetchedMscrelacionCortesClientes As Boolean
		Private _mscrelacionProductosRastros As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
		Private _alwaysFetchMscrelacionProductosRastros, _alreadyFetchedMscrelacionProductosRastros As Boolean
		Private _productoDerivado As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
		Private _alwaysFetchProductoDerivado, _alreadyFetchedProductoDerivado As Boolean
		Private _productoDerivado_ As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
		Private _alwaysFetchProductoDerivado_, _alreadyFetchedProductoDerivado_ As Boolean
		Private _referenciaProductoDerivado As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
		Private _alwaysFetchReferenciaProductoDerivado, _alreadyFetchedReferenciaProductoDerivado As Boolean
		Private _usrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
		Private _alwaysFetchUsrProdRecepcionDetalle, _alreadyFetchedUsrProdRecepcionDetalle As Boolean
		Private _usrProdRegistroSacrificiosDecomiso As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
		Private _alwaysFetchUsrProdRegistroSacrificiosDecomiso, _alreadyFetchedUsrProdRegistroSacrificiosDecomiso As Boolean
		Private _registroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisos, _alreadyFetchedRegistroSacrificiosDecomisos As Boolean
		Private _mfacEmbarquesCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
		Private _mfacEmbarquesCabCollectionViaDevolucionProductos As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos, _alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos As Boolean
		Private _catRastrosCollectionViaMscrelacionProductosRastros As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros, _alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean
		Private _msccortesPreCortes As MsccortesPreCortesEntity
		Private _alwaysFetchMsccortesPreCortes, _alreadyFetchedMsccortesPreCortes, _msccortesPreCortesReturnsNewIfNotFound As Boolean

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
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		Public Sub New(idProducto As System.Int32)

			InitClassFetch(idProducto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idProducto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idProducto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="validator">The custom validator Object for this MsccatProductosEntity</param>
		Public Sub New(idProducto As System.Int32, validator As IValidator)

			InitClassFetch(idProducto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)
			_alwaysFetchMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesDet")
			_minvTransferenciaAlmacenProdDetalle = CType(info.GetValue("_minvTransferenciaAlmacenProdDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenProdDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenProdDetalle")
			_msccatProductosDetalle = CType(info.GetValue("_msccatProductosDetalle", GetType(Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection)), Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection)
			_alwaysFetchMsccatProductosDetalle = info.GetBoolean("_alwaysFetchMsccatProductosDetalle")
			_alreadyFetchedMsccatProductosDetalle = info.GetBoolean("_alreadyFetchedMsccatProductosDetalle")
			_msccortesPreCortes_ = CType(info.GetValue("_msccortesPreCortes_", GetType(Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection)), Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection)
			_alwaysFetchMsccortesPreCortes_ = info.GetBoolean("_alwaysFetchMsccortesPreCortes_")
			_alreadyFetchedMsccortesPreCortes_ = info.GetBoolean("_alreadyFetchedMsccortesPreCortes_")
			_devolucionProductos = CType(info.GetValue("_devolucionProductos", GetType(Integralab.ORM.CollectionClasses.DevolucionProductosCollection)), Integralab.ORM.CollectionClasses.DevolucionProductosCollection)
			_alwaysFetchDevolucionProductos = info.GetBoolean("_alwaysFetchDevolucionProductos")
			_alreadyFetchedDevolucionProductos = info.GetBoolean("_alreadyFetchedDevolucionProductos")
			_mscinventarioProducto = CType(info.GetValue("_mscinventarioProducto", GetType(Integralab.ORM.CollectionClasses.MscinventarioProductoCollection)), Integralab.ORM.CollectionClasses.MscinventarioProductoCollection)
			_alwaysFetchMscinventarioProducto = info.GetBoolean("_alwaysFetchMscinventarioProducto")
			_alreadyFetchedMscinventarioProducto = info.GetBoolean("_alreadyFetchedMscinventarioProducto")
			_mscloteCortesDet = CType(info.GetValue("_mscloteCortesDet", GetType(Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)), Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)
			_alwaysFetchMscloteCortesDet = info.GetBoolean("_alwaysFetchMscloteCortesDet")
			_alreadyFetchedMscloteCortesDet = info.GetBoolean("_alreadyFetchedMscloteCortesDet")
			_mscloteCortesDet_ = CType(info.GetValue("_mscloteCortesDet_", GetType(Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)), Integralab.ORM.CollectionClasses.MscloteCortesDetCollection)
			_alwaysFetchMscloteCortesDet_ = info.GetBoolean("_alwaysFetchMscloteCortesDet_")
			_alreadyFetchedMscloteCortesDet_ = info.GetBoolean("_alreadyFetchedMscloteCortesDet_")
			_mscloteCortesDetComparacion = CType(info.GetValue("_mscloteCortesDetComparacion", GetType(Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection)), Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection)
			_alwaysFetchMscloteCortesDetComparacion = info.GetBoolean("_alwaysFetchMscloteCortesDetComparacion")
			_alreadyFetchedMscloteCortesDetComparacion = info.GetBoolean("_alreadyFetchedMscloteCortesDetComparacion")
			_mscmovtosAlmacenDet = CType(info.GetValue("_mscmovtosAlmacenDet", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection)
			_alwaysFetchMscmovtosAlmacenDet = info.GetBoolean("_alwaysFetchMscmovtosAlmacenDet")
			_alreadyFetchedMscmovtosAlmacenDet = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenDet")
			_mscrelacionCortesClientes = CType(info.GetValue("_mscrelacionCortesClientes", GetType(Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)), Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)
			_alwaysFetchMscrelacionCortesClientes = info.GetBoolean("_alwaysFetchMscrelacionCortesClientes")
			_alreadyFetchedMscrelacionCortesClientes = info.GetBoolean("_alreadyFetchedMscrelacionCortesClientes")
			_mscrelacionProductosRastros = CType(info.GetValue("_mscrelacionProductosRastros", GetType(Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection)), Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection)
			_alwaysFetchMscrelacionProductosRastros = info.GetBoolean("_alwaysFetchMscrelacionProductosRastros")
			_alreadyFetchedMscrelacionProductosRastros = info.GetBoolean("_alreadyFetchedMscrelacionProductosRastros")
			_productoDerivado = CType(info.GetValue("_productoDerivado", GetType(Integralab.ORM.CollectionClasses.ProductoDerivadoCollection)), Integralab.ORM.CollectionClasses.ProductoDerivadoCollection)
			_alwaysFetchProductoDerivado = info.GetBoolean("_alwaysFetchProductoDerivado")
			_alreadyFetchedProductoDerivado = info.GetBoolean("_alreadyFetchedProductoDerivado")
			_productoDerivado_ = CType(info.GetValue("_productoDerivado_", GetType(Integralab.ORM.CollectionClasses.ProductoDerivadoCollection)), Integralab.ORM.CollectionClasses.ProductoDerivadoCollection)
			_alwaysFetchProductoDerivado_ = info.GetBoolean("_alwaysFetchProductoDerivado_")
			_alreadyFetchedProductoDerivado_ = info.GetBoolean("_alreadyFetchedProductoDerivado_")
			_referenciaProductoDerivado = CType(info.GetValue("_referenciaProductoDerivado", GetType(Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection)), Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection)
			_alwaysFetchReferenciaProductoDerivado = info.GetBoolean("_alwaysFetchReferenciaProductoDerivado")
			_alreadyFetchedReferenciaProductoDerivado = info.GetBoolean("_alreadyFetchedReferenciaProductoDerivado")
			_usrProdRecepcionDetalle = CType(info.GetValue("_usrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)
			_alwaysFetchUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchUsrProdRecepcionDetalle")
			_alreadyFetchedUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedUsrProdRecepcionDetalle")
			_usrProdRegistroSacrificiosDecomiso = CType(info.GetValue("_usrProdRegistroSacrificiosDecomiso", GetType(Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)), Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alwaysFetchUsrProdRegistroSacrificiosDecomiso")
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso")
			_registroSacrificiosDecomisos = CType(info.GetValue("_registroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos")
			_alreadyFetchedRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos")
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_mfacEmbarquesCabCollectionViaDevolucionProductos = CType(info.GetValue("_mfacEmbarquesCabCollectionViaDevolucionProductos", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos")
			_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos")
			_catRastrosCollectionViaMscrelacionProductosRastros = CType(info.GetValue("_catRastrosCollectionViaMscrelacionProductosRastros", GetType(Integralab.ORM.CollectionClasses.CatRastrosCollection)), Integralab.ORM.CollectionClasses.CatRastrosCollection)
			_alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros = info.GetBoolean("_alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros")
			_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros = info.GetBoolean("_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros")
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_msccortesPreCortes = CType(info.GetValue("_msccortesPreCortes", GetType(MsccortesPreCortesEntity)), MsccortesPreCortesEntity)
			If Not _msccortesPreCortes Is Nothing Then
				' rewire event handler.
				AddHandler _msccortesPreCortes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccortesPreCortesReturnsNewIfNotFound = info.GetBoolean("_msccortesPreCortesReturnsNewIfNotFound")
			_alwaysFetchMsccortesPreCortes = info.GetBoolean("_alwaysFetchMsccortesPreCortes")
			_alreadyFetchedMsccortesPreCortes = info.GetBoolean("_alreadyFetchedMsccortesPreCortes")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMfacEmbarquesDet = (_mfacEmbarquesDet.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = (_minvTransferenciaAlmacenProdDetalle.Count > 0)
			_alreadyFetchedMsccatProductosDetalle = (_msccatProductosDetalle.Count > 0)
			_alreadyFetchedMsccortesPreCortes_ = (_msccortesPreCortes_.Count > 0)
			_alreadyFetchedDevolucionProductos = (_devolucionProductos.Count > 0)
			_alreadyFetchedMscinventarioProducto = (_mscinventarioProducto.Count > 0)
			_alreadyFetchedMscloteCortesDet = (_mscloteCortesDet.Count > 0)
			_alreadyFetchedMscloteCortesDet_ = (_mscloteCortesDet_.Count > 0)
			_alreadyFetchedMscloteCortesDetComparacion = (_mscloteCortesDetComparacion.Count > 0)
			_alreadyFetchedMscmovtosAlmacenDet = (_mscmovtosAlmacenDet.Count > 0)
			_alreadyFetchedMscrelacionCortesClientes = (_mscrelacionCortesClientes.Count > 0)
			_alreadyFetchedMscrelacionProductosRastros = (_mscrelacionProductosRastros.Count > 0)
			_alreadyFetchedProductoDerivado = (_productoDerivado.Count > 0)
			_alreadyFetchedProductoDerivado_ = (_productoDerivado_.Count > 0)
			_alreadyFetchedReferenciaProductoDerivado = (_referenciaProductoDerivado.Count > 0)
			_alreadyFetchedUsrProdRecepcionDetalle = (_usrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = (_usrProdRegistroSacrificiosDecomiso.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisos = (_registroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = (_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos = (_mfacEmbarquesCabCollectionViaDevolucionProductos.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros = (_catRastrosCollectionViaMscrelacionProductosRastros.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = (_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)
			_alreadyFetchedMsccortesPreCortes = Not(_msccortesPreCortes Is Nothing)
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
			info.AddValue("_minvTransferenciaAlmacenProdDetalle", _minvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenProdDetalle", _alwaysFetchMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenProdDetalle", _alreadyFetchedMinvTransferenciaAlmacenProdDetalle)
			info.AddValue("_msccatProductosDetalle", _msccatProductosDetalle)
			info.AddValue("_alwaysFetchMsccatProductosDetalle", _alwaysFetchMsccatProductosDetalle)
			info.AddValue("_alreadyFetchedMsccatProductosDetalle", _alreadyFetchedMsccatProductosDetalle)
			info.AddValue("_msccortesPreCortes_", _msccortesPreCortes_)
			info.AddValue("_alwaysFetchMsccortesPreCortes_", _alwaysFetchMsccortesPreCortes_)
			info.AddValue("_alreadyFetchedMsccortesPreCortes_", _alreadyFetchedMsccortesPreCortes_)
			info.AddValue("_devolucionProductos", _devolucionProductos)
			info.AddValue("_alwaysFetchDevolucionProductos", _alwaysFetchDevolucionProductos)
			info.AddValue("_alreadyFetchedDevolucionProductos", _alreadyFetchedDevolucionProductos)
			info.AddValue("_mscinventarioProducto", _mscinventarioProducto)
			info.AddValue("_alwaysFetchMscinventarioProducto", _alwaysFetchMscinventarioProducto)
			info.AddValue("_alreadyFetchedMscinventarioProducto", _alreadyFetchedMscinventarioProducto)
			info.AddValue("_mscloteCortesDet", _mscloteCortesDet)
			info.AddValue("_alwaysFetchMscloteCortesDet", _alwaysFetchMscloteCortesDet)
			info.AddValue("_alreadyFetchedMscloteCortesDet", _alreadyFetchedMscloteCortesDet)
			info.AddValue("_mscloteCortesDet_", _mscloteCortesDet_)
			info.AddValue("_alwaysFetchMscloteCortesDet_", _alwaysFetchMscloteCortesDet_)
			info.AddValue("_alreadyFetchedMscloteCortesDet_", _alreadyFetchedMscloteCortesDet_)
			info.AddValue("_mscloteCortesDetComparacion", _mscloteCortesDetComparacion)
			info.AddValue("_alwaysFetchMscloteCortesDetComparacion", _alwaysFetchMscloteCortesDetComparacion)
			info.AddValue("_alreadyFetchedMscloteCortesDetComparacion", _alreadyFetchedMscloteCortesDetComparacion)
			info.AddValue("_mscmovtosAlmacenDet", _mscmovtosAlmacenDet)
			info.AddValue("_alwaysFetchMscmovtosAlmacenDet", _alwaysFetchMscmovtosAlmacenDet)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenDet", _alreadyFetchedMscmovtosAlmacenDet)
			info.AddValue("_mscrelacionCortesClientes", _mscrelacionCortesClientes)
			info.AddValue("_alwaysFetchMscrelacionCortesClientes", _alwaysFetchMscrelacionCortesClientes)
			info.AddValue("_alreadyFetchedMscrelacionCortesClientes", _alreadyFetchedMscrelacionCortesClientes)
			info.AddValue("_mscrelacionProductosRastros", _mscrelacionProductosRastros)
			info.AddValue("_alwaysFetchMscrelacionProductosRastros", _alwaysFetchMscrelacionProductosRastros)
			info.AddValue("_alreadyFetchedMscrelacionProductosRastros", _alreadyFetchedMscrelacionProductosRastros)
			info.AddValue("_productoDerivado", _productoDerivado)
			info.AddValue("_alwaysFetchProductoDerivado", _alwaysFetchProductoDerivado)
			info.AddValue("_alreadyFetchedProductoDerivado", _alreadyFetchedProductoDerivado)
			info.AddValue("_productoDerivado_", _productoDerivado_)
			info.AddValue("_alwaysFetchProductoDerivado_", _alwaysFetchProductoDerivado_)
			info.AddValue("_alreadyFetchedProductoDerivado_", _alreadyFetchedProductoDerivado_)
			info.AddValue("_referenciaProductoDerivado", _referenciaProductoDerivado)
			info.AddValue("_alwaysFetchReferenciaProductoDerivado", _alwaysFetchReferenciaProductoDerivado)
			info.AddValue("_alreadyFetchedReferenciaProductoDerivado", _alreadyFetchedReferenciaProductoDerivado)
			info.AddValue("_usrProdRecepcionDetalle", _usrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchUsrProdRecepcionDetalle", _alwaysFetchUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedUsrProdRecepcionDetalle", _alreadyFetchedUsrProdRecepcionDetalle)
			info.AddValue("_usrProdRegistroSacrificiosDecomiso", _usrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alwaysFetchUsrProdRegistroSacrificiosDecomiso", _alwaysFetchUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso", _alreadyFetchedUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_registroSacrificiosDecomisos", _registroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos", _alwaysFetchRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos", _alreadyFetchedRegistroSacrificiosDecomisos)
			info.AddValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", _mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_mfacEmbarquesCabCollectionViaDevolucionProductos", _mfacEmbarquesCabCollectionViaDevolucionProductos)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos", _alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos", _alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos)
			info.AddValue("_catRastrosCollectionViaMscrelacionProductosRastros", _catRastrosCollectionViaMscrelacionProductosRastros)
			info.AddValue("_alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros", _alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros)
			info.AddValue("_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros", _alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_msccortesPreCortes", _msccortesPreCortes)
			info.AddValue("_msccortesPreCortesReturnsNewIfNotFound", _msccortesPreCortesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccortesPreCortes", _alwaysFetchMsccortesPreCortes)
			info.AddValue("_alreadyFetchedMsccortesPreCortes", _alreadyFetchedMsccortesPreCortes)
			
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
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "MfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesDet.Add(CType(entity, MfacEmbarquesDetEntity))
					End If
				Case "MinvTransferenciaAlmacenProdDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenProdDetalle.Add(CType(entity, MinvTransferenciaAlmacenProdDetalleEntity))
					End If
				Case "MsccatProductosDetalle"
					_alreadyFetchedMsccatProductosDetalle = True
					If Not entity Is Nothing Then
						Me.MsccatProductosDetalle.Add(CType(entity, MsccatProductosDetalleEntity))
					End If
				Case "MsccortesPreCortes_"
					_alreadyFetchedMsccortesPreCortes_ = True
					If Not entity Is Nothing Then
						Me.MsccortesPreCortes_.Add(CType(entity, MsccortesPreCortesEntity))
					End If
				Case "DevolucionProductos"
					_alreadyFetchedDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.DevolucionProductos.Add(CType(entity, DevolucionProductosEntity))
					End If
				Case "MscinventarioProducto"
					_alreadyFetchedMscinventarioProducto = True
					If Not entity Is Nothing Then
						Me.MscinventarioProducto.Add(CType(entity, MscinventarioProductoEntity))
					End If
				Case "MscloteCortesDet"
					_alreadyFetchedMscloteCortesDet = True
					If Not entity Is Nothing Then
						Me.MscloteCortesDet.Add(CType(entity, MscloteCortesDetEntity))
					End If
				Case "MscloteCortesDet_"
					_alreadyFetchedMscloteCortesDet_ = True
					If Not entity Is Nothing Then
						Me.MscloteCortesDet_.Add(CType(entity, MscloteCortesDetEntity))
					End If
				Case "MscloteCortesDetComparacion"
					_alreadyFetchedMscloteCortesDetComparacion = True
					If Not entity Is Nothing Then
						Me.MscloteCortesDetComparacion.Add(CType(entity, MscloteCortesDetComparacionEntity))
					End If
				Case "MscmovtosAlmacenDet"
					_alreadyFetchedMscmovtosAlmacenDet = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenDet.Add(CType(entity, MscmovtosAlmacenDetEntity))
					End If
				Case "MscrelacionCortesClientes"
					_alreadyFetchedMscrelacionCortesClientes = True
					If Not entity Is Nothing Then
						Me.MscrelacionCortesClientes.Add(CType(entity, MscrelacionCortesClientesEntity))
					End If
				Case "MscrelacionProductosRastros"
					_alreadyFetchedMscrelacionProductosRastros = True
					If Not entity Is Nothing Then
						Me.MscrelacionProductosRastros.Add(CType(entity, MscrelacionProductosRastrosEntity))
					End If
				Case "ProductoDerivado"
					_alreadyFetchedProductoDerivado = True
					If Not entity Is Nothing Then
						Me.ProductoDerivado.Add(CType(entity, ProductoDerivadoEntity))
					End If
				Case "ProductoDerivado_"
					_alreadyFetchedProductoDerivado_ = True
					If Not entity Is Nothing Then
						Me.ProductoDerivado_.Add(CType(entity, ProductoDerivadoEntity))
					End If
				Case "ReferenciaProductoDerivado"
					_alreadyFetchedReferenciaProductoDerivado = True
					If Not entity Is Nothing Then
						Me.ReferenciaProductoDerivado.Add(CType(entity, ReferenciaProductoDerivadoEntity))
					End If
				Case "UsrProdRecepcionDetalle"
					_alreadyFetchedUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionDetalle.Add(CType(entity, UsrProdRecepcionDetalleEntity))
					End If
				Case "UsrProdRegistroSacrificiosDecomiso"
					_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = True
					If Not entity Is Nothing Then
						Me.UsrProdRegistroSacrificiosDecomiso.Add(CType(entity, UsrProdRegistroSacrificiosDecomisoEntity))
					End If
				Case "RegistroSacrificiosDecomisos"
					_alreadyFetchedRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisos.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaDevolucionProductos"
					_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaDevolucionProductos.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "CatRastrosCollectionViaMscrelacionProductosRastros"
					_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros = True
					If Not entity Is Nothing Then
						Me.CatRastrosCollectionViaMscrelacionProductosRastros.Add(CType(entity, CatRastrosEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "MsccortesPreCortes"
					_alreadyFetchedMsccortesPreCortes = True
					Me.MsccortesPreCortes = CType(entity, MsccortesPreCortesEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					_mfacEmbarquesDet.Add(CType(relatedEntity, MfacEmbarquesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenProdDetalle"
					_minvTransferenciaAlmacenProdDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenProdDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductosDetalle"
					_msccatProductosDetalle.Add(CType(relatedEntity, MsccatProductosDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccortesPreCortes_"
					_msccortesPreCortes_.Add(CType(relatedEntity, MsccortesPreCortesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DevolucionProductos"
					_devolucionProductos.Add(CType(relatedEntity, DevolucionProductosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscinventarioProducto"
					_mscinventarioProducto.Add(CType(relatedEntity, MscinventarioProductoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesDet"
					_mscloteCortesDet.Add(CType(relatedEntity, MscloteCortesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesDet_"
					_mscloteCortesDet_.Add(CType(relatedEntity, MscloteCortesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesDetComparacion"
					_mscloteCortesDetComparacion.Add(CType(relatedEntity, MscloteCortesDetComparacionEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenDet"
					_mscmovtosAlmacenDet.Add(CType(relatedEntity, MscmovtosAlmacenDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					_mscrelacionCortesClientes.Add(CType(relatedEntity, MscrelacionCortesClientesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrelacionProductosRastros"
					_mscrelacionProductosRastros.Add(CType(relatedEntity, MscrelacionProductosRastrosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProductoDerivado"
					_productoDerivado.Add(CType(relatedEntity, ProductoDerivadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProductoDerivado_"
					_productoDerivado_.Add(CType(relatedEntity, ProductoDerivadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ReferenciaProductoDerivado"
					_referenciaProductoDerivado.Add(CType(relatedEntity, ReferenciaProductoDerivadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					_usrProdRecepcionDetalle.Add(CType(relatedEntity, UsrProdRecepcionDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					_usrProdRegistroSacrificiosDecomiso.Add(CType(relatedEntity, UsrProdRegistroSacrificiosDecomisoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					_registroSacrificiosDecomisos.Add(CType(relatedEntity, RegistroSacrificiosDecomisosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccortesPreCortes"
					SetupSyncMsccortesPreCortes(relatedEntity)
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
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenProdDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenProdDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductosDetalle"
					MyBase.PerformRelatedEntityRemoval(_msccatProductosDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccortesPreCortes_"
					MyBase.PerformRelatedEntityRemoval(_msccortesPreCortes_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DevolucionProductos"
					MyBase.PerformRelatedEntityRemoval(_devolucionProductos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscinventarioProducto"
					MyBase.PerformRelatedEntityRemoval(_mscinventarioProducto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesDet"
					MyBase.PerformRelatedEntityRemoval(_mscloteCortesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesDet_"
					MyBase.PerformRelatedEntityRemoval(_mscloteCortesDet_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesDetComparacion"
					MyBase.PerformRelatedEntityRemoval(_mscloteCortesDetComparacion, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenDet"
					MyBase.PerformRelatedEntityRemoval(_mscmovtosAlmacenDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					MyBase.PerformRelatedEntityRemoval(_mscrelacionCortesClientes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrelacionProductosRastros"
					MyBase.PerformRelatedEntityRemoval(_mscrelacionProductosRastros, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProductoDerivado"
					MyBase.PerformRelatedEntityRemoval(_productoDerivado, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProductoDerivado_"
					MyBase.PerformRelatedEntityRemoval(_productoDerivado_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ReferenciaProductoDerivado"
					MyBase.PerformRelatedEntityRemoval(_referenciaProductoDerivado, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					MyBase.PerformRelatedEntityRemoval(_usrProdRegistroSacrificiosDecomiso, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					MyBase.PerformRelatedEntityRemoval(_registroSacrificiosDecomisos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccortesPreCortes"
					DesetupSyncMsccortesPreCortes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()

			If Not _msccortesPreCortes Is Nothing Then
				toReturn.Add(_msccortesPreCortes)
			End If


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If




			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mfacEmbarquesDet)
			toReturn.Add(_minvTransferenciaAlmacenProdDetalle)
			toReturn.Add(_msccatProductosDetalle)
			toReturn.Add(_msccortesPreCortes_)
			toReturn.Add(_devolucionProductos)
			toReturn.Add(_mscinventarioProducto)
			toReturn.Add(_mscloteCortesDet)
			toReturn.Add(_mscloteCortesDet_)
			toReturn.Add(_mscloteCortesDetComparacion)
			toReturn.Add(_mscmovtosAlmacenDet)
			toReturn.Add(_mscrelacionCortesClientes)
			toReturn.Add(_mscrelacionProductosRastros)
			toReturn.Add(_productoDerivado)
			toReturn.Add(_productoDerivado_)
			toReturn.Add(_referenciaProductoDerivado)
			toReturn.Add(_usrProdRecepcionDetalle)
			toReturn.Add(_usrProdRegistroSacrificiosDecomiso)
			toReturn.Add(_registroSacrificiosDecomisos)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idProducto As System.Int32) As Boolean
			Return FetchUsingPK(idProducto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idProducto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idProducto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idProducto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdProducto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MsccatProductosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MsccatProductosFieldIndex) As Boolean
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
				_mfacEmbarquesDet.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
				_minvTransferenciaAlmacenProdDetalle.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosDetalleEntity'</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, _msccatProductosDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosDetalleEntity'</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, _msccatProductosDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			If ( Not _alreadyFetchedMsccatProductosDetalle Or forceFetch Or _alwaysFetchMsccatProductosDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductosDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductosDetalle)
					End If
				End If
				_msccatProductosDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductosDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductosDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_msccatProductosDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductosDetalle = True
			End If
			Return _msccatProductosDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductosDetalle'. These settings will be taken into account
		''' when the property MsccatProductosDetalle is requested or GetMultiMsccatProductosDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductosDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductosDetalle.SortClauses=sortClauses
			_msccatProductosDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MsccortesPreCortesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccortesPreCortesEntity'</returns>
		Public Function GetMultiMsccortesPreCortes_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
			Return GetMultiMsccortesPreCortes_(forceFetch, _msccortesPreCortes_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccortesPreCortesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMsccortesPreCortes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
			Return GetMultiMsccortesPreCortes_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccortesPreCortesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MsccortesPreCortesEntity'</returns>
		Public Function GetMultiMsccortesPreCortes_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
			Return GetMultiMsccortesPreCortes_(forceFetch, _msccortesPreCortes_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccortesPreCortesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccortesPreCortes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
			If ( Not _alreadyFetchedMsccortesPreCortes_ Or forceFetch Or _alwaysFetchMsccortesPreCortes_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccortesPreCortes_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccortesPreCortes_)
					End If
				End If
				_msccortesPreCortes_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccortesPreCortes_.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccortesPreCortes_.GetMultiManyToOne(Me, Filter)
				_msccortesPreCortes_.SuppressClearInGetMulti = False
				_alreadyFetchedMsccortesPreCortes_ = True
			End If
			Return _msccortesPreCortes_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccortesPreCortes_'. These settings will be taken into account
		''' when the property MsccortesPreCortes_ is requested or GetMultiMsccortesPreCortes_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccortesPreCortes_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccortesPreCortes_.SortClauses=sortClauses
			_msccortesPreCortes_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DevolucionProductosEntity'</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, _devolucionProductos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DevolucionProductosEntity'</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, _devolucionProductos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			If ( Not _alreadyFetchedDevolucionProductos Or forceFetch Or _alwaysFetchDevolucionProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _devolucionProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_devolucionProductos)
					End If
				End If
				_devolucionProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_devolucionProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_devolucionProductos.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_devolucionProductos.SuppressClearInGetMulti = False
				_alreadyFetchedDevolucionProductos = True
			End If
			Return _devolucionProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DevolucionProductos'. These settings will be taken into account
		''' when the property DevolucionProductos is requested or GetMultiDevolucionProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDevolucionProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_devolucionProductos.SortClauses=sortClauses
			_devolucionProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_mscinventarioProducto.GetMultiManyToOne(Nothing, Me, Filter)
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
				_mscloteCortesDet.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetEntity'</returns>
		Public Function GetMultiMscloteCortesDet_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet_(forceFetch, _mscloteCortesDet_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscloteCortesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscloteCortesDetEntity'</returns>
		Public Function GetMultiMscloteCortesDet_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Return GetMultiMscloteCortesDet_(forceFetch, _mscloteCortesDet_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscloteCortesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			If ( Not _alreadyFetchedMscloteCortesDet_ Or forceFetch Or _alwaysFetchMscloteCortesDet_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscloteCortesDet_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscloteCortesDet_)
					End If
				End If
				_mscloteCortesDet_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscloteCortesDet_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscloteCortesDet_.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_mscloteCortesDet_.SuppressClearInGetMulti = False
				_alreadyFetchedMscloteCortesDet_ = True
			End If
			Return _mscloteCortesDet_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscloteCortesDet_'. These settings will be taken into account
		''' when the property MscloteCortesDet_ is requested or GetMultiMscloteCortesDet_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscloteCortesDet_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscloteCortesDet_.SortClauses=sortClauses
			_mscloteCortesDet_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_mscloteCortesDetComparacion.GetMultiManyToOne(Nothing, Me, Filter)
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
				_mscmovtosAlmacenDet.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			If ( Not _alreadyFetchedMscrelacionCortesClientes Or forceFetch Or _alwaysFetchMscrelacionCortesClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrelacionCortesClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrelacionCortesClientes)
					End If
				End If
				_mscrelacionCortesClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrelacionCortesClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrelacionCortesClientes.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_mscrelacionCortesClientes.SuppressClearInGetMulti = False
				_alreadyFetchedMscrelacionCortesClientes = True
			End If
			Return _mscrelacionCortesClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrelacionCortesClientes'. These settings will be taken into account
		''' when the property MscrelacionCortesClientes is requested or GetMultiMscrelacionCortesClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrelacionCortesClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrelacionCortesClientes.SortClauses=sortClauses
			_mscrelacionCortesClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscrelacionProductosRastrosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionProductosRastrosEntity'</returns>
		Public Function GetMultiMscrelacionProductosRastros(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
			Return GetMultiMscrelacionProductosRastros(forceFetch, _mscrelacionProductosRastros.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionProductosRastrosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrelacionProductosRastros(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
			Return GetMultiMscrelacionProductosRastros(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionProductosRastrosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionProductosRastrosEntity'</returns>
		Public Function GetMultiMscrelacionProductosRastros(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
			Return GetMultiMscrelacionProductosRastros(forceFetch, _mscrelacionProductosRastros.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionProductosRastrosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrelacionProductosRastros(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
			If ( Not _alreadyFetchedMscrelacionProductosRastros Or forceFetch Or _alwaysFetchMscrelacionProductosRastros) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrelacionProductosRastros.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrelacionProductosRastros)
					End If
				End If
				_mscrelacionProductosRastros.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrelacionProductosRastros.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrelacionProductosRastros.GetMultiManyToOne(Nothing, Me, Filter)
				_mscrelacionProductosRastros.SuppressClearInGetMulti = False
				_alreadyFetchedMscrelacionProductosRastros = True
			End If
			Return _mscrelacionProductosRastros
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrelacionProductosRastros'. These settings will be taken into account
		''' when the property MscrelacionProductosRastros is requested or GetMultiMscrelacionProductosRastros is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrelacionProductosRastros(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrelacionProductosRastros.SortClauses=sortClauses
			_mscrelacionProductosRastros.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoDerivadoEntity'</returns>
		Public Function GetMultiProductoDerivado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado(forceFetch, _productoDerivado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProductoDerivado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoDerivadoEntity'</returns>
		Public Function GetMultiProductoDerivado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado(forceFetch, _productoDerivado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoDerivado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			If ( Not _alreadyFetchedProductoDerivado Or forceFetch Or _alwaysFetchProductoDerivado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoDerivado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoDerivado)
					End If
				End If
				_productoDerivado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoDerivado.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoDerivado.GetMultiManyToOne(Me, Nothing, Filter)
				_productoDerivado.SuppressClearInGetMulti = False
				_alreadyFetchedProductoDerivado = True
			End If
			Return _productoDerivado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoDerivado'. These settings will be taken into account
		''' when the property ProductoDerivado is requested or GetMultiProductoDerivado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoDerivado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoDerivado.SortClauses=sortClauses
			_productoDerivado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoDerivadoEntity'</returns>
		Public Function GetMultiProductoDerivado_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado_(forceFetch, _productoDerivado_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProductoDerivado_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoDerivadoEntity'</returns>
		Public Function GetMultiProductoDerivado_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Return GetMultiProductoDerivado_(forceFetch, _productoDerivado_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoDerivado_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			If ( Not _alreadyFetchedProductoDerivado_ Or forceFetch Or _alwaysFetchProductoDerivado_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoDerivado_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoDerivado_)
					End If
				End If
				_productoDerivado_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoDerivado_.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoDerivado_.GetMultiManyToOne(Nothing, Me, Filter)
				_productoDerivado_.SuppressClearInGetMulti = False
				_alreadyFetchedProductoDerivado_ = True
			End If
			Return _productoDerivado_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoDerivado_'. These settings will be taken into account
		''' when the property ProductoDerivado_ is requested or GetMultiProductoDerivado_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoDerivado_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoDerivado_.SortClauses=sortClauses
			_productoDerivado_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ReferenciaProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ReferenciaProductoDerivadoEntity'</returns>
		Public Function GetMultiReferenciaProductoDerivado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
			Return GetMultiReferenciaProductoDerivado(forceFetch, _referenciaProductoDerivado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ReferenciaProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiReferenciaProductoDerivado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
			Return GetMultiReferenciaProductoDerivado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ReferenciaProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ReferenciaProductoDerivadoEntity'</returns>
		Public Function GetMultiReferenciaProductoDerivado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
			Return GetMultiReferenciaProductoDerivado(forceFetch, _referenciaProductoDerivado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ReferenciaProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiReferenciaProductoDerivado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
			If ( Not _alreadyFetchedReferenciaProductoDerivado Or forceFetch Or _alwaysFetchReferenciaProductoDerivado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _referenciaProductoDerivado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_referenciaProductoDerivado)
					End If
				End If
				_referenciaProductoDerivado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_referenciaProductoDerivado.EntityFactoryToUse = entityFactoryToUse
				End If
				_referenciaProductoDerivado.GetMultiManyToOne(Me, Filter)
				_referenciaProductoDerivado.SuppressClearInGetMulti = False
				_alreadyFetchedReferenciaProductoDerivado = True
			End If
			Return _referenciaProductoDerivado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ReferenciaProductoDerivado'. These settings will be taken into account
		''' when the property ReferenciaProductoDerivado is requested or GetMultiReferenciaProductoDerivado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersReferenciaProductoDerivado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_referenciaProductoDerivado.SortClauses=sortClauses
			_referenciaProductoDerivado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_usrProdRecepcionDetalle.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
				_usrProdRegistroSacrificiosDecomiso.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
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
				_registroSacrificiosDecomisos.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
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
				relations.Add(MsccatProductosEntity.Relations.MfacEmbarquesDetEntityUsingIdProducto, "__MsccatProductosEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
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

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos(forceFetch, _mfacEmbarquesCabCollectionViaDevolucionProductos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos Or forceFetch Or _alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCabCollectionViaDevolucionProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCabCollectionViaDevolucionProductos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MsccatProductosEntity.Relations.DevolucionProductosEntityUsingIdProducto, "__MsccatProductosEntity__", "DevolucionProductos_", JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque, "DevolucionProductos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
				_mfacEmbarquesCabCollectionViaDevolucionProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCabCollectionViaDevolucionProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCabCollectionViaDevolucionProductos.GetMulti(Filter, relations)
				_mfacEmbarquesCabCollectionViaDevolucionProductos.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos = True
			End If
			Return _mfacEmbarquesCabCollectionViaDevolucionProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCabCollectionViaDevolucionProductos'. These settings will be taken into account
		''' when the property MfacEmbarquesCabCollectionViaDevolucionProductos is requested or GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCabCollectionViaDevolucionProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCabCollectionViaDevolucionProductos.SortClauses=sortClauses
			_mfacEmbarquesCabCollectionViaDevolucionProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatRastrosEntity'</returns>
		Public Function GetMultiCatRastrosCollectionViaMscrelacionProductosRastros(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Return GetMultiCatRastrosCollectionViaMscrelacionProductosRastros(forceFetch, _catRastrosCollectionViaMscrelacionProductosRastros.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatRastrosCollectionViaMscrelacionProductosRastros(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			If ( Not _alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros Or forceFetch Or _alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catRastrosCollectionViaMscrelacionProductosRastros.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catRastrosCollectionViaMscrelacionProductosRastros)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MsccatProductosEntity.Relations.MscrelacionProductosRastrosEntityUsingCodProducto, "__MsccatProductosEntity__", "MscrelacionProductosRastros_", JoinHint.None)
				relations.Add(MscrelacionProductosRastrosEntity.Relations.CatRastrosEntityUsingCodRastro, "MscrelacionProductosRastros_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
				_catRastrosCollectionViaMscrelacionProductosRastros.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catRastrosCollectionViaMscrelacionProductosRastros.EntityFactoryToUse = entityFactoryToUse
				End If
				_catRastrosCollectionViaMscrelacionProductosRastros.GetMulti(Filter, relations)
				_catRastrosCollectionViaMscrelacionProductosRastros.SuppressClearInGetMulti = False
				_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros = True
			End If
			Return _catRastrosCollectionViaMscrelacionProductosRastros
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatRastrosCollectionViaMscrelacionProductosRastros'. These settings will be taken into account
		''' when the property CatRastrosCollectionViaMscrelacionProductosRastros is requested or GetMultiCatRastrosCollectionViaMscrelacionProductosRastros is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatRastrosCollectionViaMscrelacionProductosRastros(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catRastrosCollectionViaMscrelacionProductosRastros.SortClauses=sortClauses
			_catRastrosCollectionViaMscrelacionProductosRastros.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(MsccatProductosEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__MsccatProductosEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatProductosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MsccatProductosEntity.Relations.CuentaContableEntityUsingIdCeuntaContable) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCeuntaContable.GetValueOrDefault())
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
	
	
		''' <summary>Retrieves the related entity of type 'MsccortesPreCortesEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'MsccortesPreCortesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccortesPreCortes() As MsccortesPreCortesEntity
			Return GetSingleMsccortesPreCortes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccortesPreCortesEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccortesPreCortesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccortesPreCortes(forceFetch As Boolean) As MsccortesPreCortesEntity
			If ( Not _alreadyFetchedMsccortesPreCortes Or forceFetch Or _alwaysFetchMsccortesPreCortes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New MsccortesPreCortesEntity()
				Dim relation As IEntityRelation = MsccatProductosEntity.Relations.MsccortesPreCortesEntityUsingIdCorte
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _msccortesPreCortesReturnsNewIfNotFound And Not fetchResult Then
					Me.MsccortesPreCortes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccortesPreCortesEntity)
					End If
					Me.MsccortesPreCortes = newEntity
					_alreadyFetchedMsccortesPreCortes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccortesPreCortes
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MsccatProductosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MsccatProductosFieldIndex)














					Case MsccatProductosFieldIndex.IdCeuntaContable
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
			_mfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenProdDetalle.ActiveContext = MyBase.ActiveContext
			_msccatProductosDetalle.ActiveContext = MyBase.ActiveContext
			_msccortesPreCortes_.ActiveContext = MyBase.ActiveContext
			_devolucionProductos.ActiveContext = MyBase.ActiveContext
			_mscinventarioProducto.ActiveContext = MyBase.ActiveContext
			_mscloteCortesDet.ActiveContext = MyBase.ActiveContext
			_mscloteCortesDet_.ActiveContext = MyBase.ActiveContext
			_mscloteCortesDetComparacion.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenDet.ActiveContext = MyBase.ActiveContext
			_mscrelacionCortesClientes.ActiveContext = MyBase.ActiveContext
			_mscrelacionProductosRastros.ActiveContext = MyBase.ActiveContext
			_productoDerivado.ActiveContext = MyBase.ActiveContext
			_productoDerivado_.ActiveContext = MyBase.ActiveContext
			_referenciaProductoDerivado.ActiveContext = MyBase.ActiveContext
			_usrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_usrProdRegistroSacrificiosDecomiso.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaDevolucionProductos.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaMscrelacionProductosRastros.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccortesPreCortes Is Nothing Then
				_msccortesPreCortes.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MsccatProductosDAO = CType(CreateDAOInstance(), MsccatProductosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MsccatProductosDAO = CType(CreateDAOInstance(), MsccatProductosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MsccatProductosDAO = CType(CreateDAOInstance(), MsccatProductosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MsccatProductosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MsccatProductosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="validator">The validator Object for this MsccatProductosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idProducto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idProducto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(New MfacEmbarquesDetEntityFactory())
			_mfacEmbarquesDet.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesDet = False
			_minvTransferenciaAlmacenProdDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection(New MinvTransferenciaAlmacenProdDetalleEntityFactory())
			_minvTransferenciaAlmacenProdDetalle.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMinvTransferenciaAlmacenProdDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenProdDetalle = False
			_msccatProductosDetalle = New Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection(New MsccatProductosDetalleEntityFactory())
			_msccatProductosDetalle.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMsccatProductosDetalle = False
			_alreadyFetchedMsccatProductosDetalle = False
			_msccortesPreCortes_ = New Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection(New MsccortesPreCortesEntityFactory())
			_msccortesPreCortes_.SetContainingEntityInfo(Me, "MsccatProductos_")
			_alwaysFetchMsccortesPreCortes_ = False
			_alreadyFetchedMsccortesPreCortes_ = False
			_devolucionProductos = New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(New DevolucionProductosEntityFactory())
			_devolucionProductos.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchDevolucionProductos = False
			_alreadyFetchedDevolucionProductos = False
			_mscinventarioProducto = New Integralab.ORM.CollectionClasses.MscinventarioProductoCollection(New MscinventarioProductoEntityFactory())
			_mscinventarioProducto.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMscinventarioProducto = False
			_alreadyFetchedMscinventarioProducto = False
			_mscloteCortesDet = New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(New MscloteCortesDetEntityFactory())
			_mscloteCortesDet.SetContainingEntityInfo(Me, "MsccatProductosPreCorte")
			_alwaysFetchMscloteCortesDet = False
			_alreadyFetchedMscloteCortesDet = False
			_mscloteCortesDet_ = New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(New MscloteCortesDetEntityFactory())
			_mscloteCortesDet_.SetContainingEntityInfo(Me, "MsccatProductosCorte")
			_alwaysFetchMscloteCortesDet_ = False
			_alreadyFetchedMscloteCortesDet_ = False
			_mscloteCortesDetComparacion = New Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection(New MscloteCortesDetComparacionEntityFactory())
			_mscloteCortesDetComparacion.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMscloteCortesDetComparacion = False
			_alreadyFetchedMscloteCortesDetComparacion = False
			_mscmovtosAlmacenDet = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection(New MscmovtosAlmacenDetEntityFactory())
			_mscmovtosAlmacenDet.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMscmovtosAlmacenDet = False
			_alreadyFetchedMscmovtosAlmacenDet = False
			_mscrelacionCortesClientes = New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(New MscrelacionCortesClientesEntityFactory())
			_mscrelacionCortesClientes.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMscrelacionCortesClientes = False
			_alreadyFetchedMscrelacionCortesClientes = False
			_mscrelacionProductosRastros = New Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection(New MscrelacionProductosRastrosEntityFactory())
			_mscrelacionProductosRastros.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchMscrelacionProductosRastros = False
			_alreadyFetchedMscrelacionProductosRastros = False
			_productoDerivado = New Integralab.ORM.CollectionClasses.ProductoDerivadoCollection(New ProductoDerivadoEntityFactory())
			_productoDerivado.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchProductoDerivado = False
			_alreadyFetchedProductoDerivado = False
			_productoDerivado_ = New Integralab.ORM.CollectionClasses.ProductoDerivadoCollection(New ProductoDerivadoEntityFactory())
			_productoDerivado_.SetContainingEntityInfo(Me, "MsccatProductos_")
			_alwaysFetchProductoDerivado_ = False
			_alreadyFetchedProductoDerivado_ = False
			_referenciaProductoDerivado = New Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection(New ReferenciaProductoDerivadoEntityFactory())
			_referenciaProductoDerivado.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchReferenciaProductoDerivado = False
			_alreadyFetchedReferenciaProductoDerivado = False
			_usrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(New UsrProdRecepcionDetalleEntityFactory())
			_usrProdRecepcionDetalle.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchUsrProdRecepcionDetalle = False
			_alreadyFetchedUsrProdRecepcionDetalle = False
			_usrProdRegistroSacrificiosDecomiso = New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(New UsrProdRegistroSacrificiosDecomisoEntityFactory())
			_usrProdRegistroSacrificiosDecomiso.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = False
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = False
			_registroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_registroSacrificiosDecomisos.SetContainingEntityInfo(Me, "MsccatProductos")
			_alwaysFetchRegistroSacrificiosDecomisos = False
			_alreadyFetchedRegistroSacrificiosDecomisos = False
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_mfacEmbarquesCabCollectionViaDevolucionProductos = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaDevolucionProductos = False
			_catRastrosCollectionViaMscrelacionProductosRastros = New Integralab.ORM.CollectionClasses.CatRastrosCollection(New CatRastrosEntityFactory())
			_alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros = False
			_alreadyFetchedCatRastrosCollectionViaMscrelacionProductosRastros = False
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_msccortesPreCortes = Nothing
			_msccortesPreCortesReturnsNewIfNotFound = True
			_alwaysFetchMsccortesPreCortes = False
			_alreadyFetchedMsccortesPreCortes = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PreCorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Corte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Decomisa", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnPiezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodProdAnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MaximoPiezasxCaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NombreIngles", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCeuntaContable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrecioXkilo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PiezasXcabeza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosMaximo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosMinimo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Canal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsMerma", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ValorAgregado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ConHueso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsDerivable", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", MsccatProductosEntity.Relations.CuentaContableEntityUsingIdCeuntaContable, True, signalRelatedEntity, "MsccatProductos", resetFKFields, New Integer() { CInt(MsccatProductosFieldIndex.IdCeuntaContable) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", MsccatProductosEntity.Relations.CuentaContableEntityUsingIdCeuntaContable, True, _alreadyFetchedCuentaContable, New String() {  } )
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

		''' <summary>Removes the sync logic for member _msccortesPreCortes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccortesPreCortes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccortesPreCortes, AddressOf OnMsccortesPreCortesPropertyChanged, "MsccortesPreCortes", MsccatProductosEntity.Relations.MsccortesPreCortesEntityUsingIdCorte, False, signalRelatedEntity, "MsccatProductos", False, New Integer() { CInt(MsccatProductosFieldIndex.IdProducto) } )
			_msccortesPreCortes = Nothing
		End Sub

		''' <summary>setups the sync logic for member _msccortesPreCortes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccortesPreCortes(relatedEntity As IEntity)
			DesetupSyncMsccortesPreCortes(True, True)
			_msccortesPreCortes = CType(relatedEntity, MsccortesPreCortesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccortesPreCortes, AddressOf OnMsccortesPreCortesPropertyChanged, "MsccortesPreCortes", MsccatProductosEntity.Relations.MsccortesPreCortesEntityUsingIdCorte, False, _alreadyFetchedMsccortesPreCortes, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccortesPreCortesPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idProducto">PK value for MsccatProductos which data should be fetched into this MsccatProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MsccatProductosFieldIndex.IdProducto)).ForcedCurrentValueWrite(idProducto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMsccatProductosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MsccatProductosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MsccatProductosRelations
			Get	
				Return New MsccatProductosRelations() 
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
					MsccatProductosEntity.Relations.MfacEmbarquesDetEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenProdDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenProdDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenProdDetalleCollection(), _
					MsccatProductosEntity.Relations.MinvTransferenciaAlmacenProdDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenProdDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenProdDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductosDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection(), _
					MsccatProductosEntity.Relations.MsccatProductosDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductosDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccortesPreCortes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccortesPreCortes_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection(), _
					MsccatProductosEntity.Relations.MsccortesPreCortesEntityUsingIdPreCorte, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MsccortesPreCortesEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccortesPreCortes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DevolucionProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDevolucionProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(), _
					MsccatProductosEntity.Relations.DevolucionProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "DevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscinventarioProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscinventarioProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscinventarioProductoCollection(), _
					MsccatProductosEntity.Relations.MscinventarioProductoEntityUsingIdCodProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscinventarioProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "MscinventarioProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(), _
					MsccatProductosEntity.Relations.MscloteCortesDetEntityUsingIdCorte, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesDet_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection(), _
					MsccatProductosEntity.Relations.MscloteCortesDetEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesDet_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesDetComparacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesDetComparacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesDetComparacionCollection(), _
					MsccatProductosEntity.Relations.MscloteCortesDetComparacionEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesDetComparacionEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesDetComparacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenDetCollection(), _
					MsccatProductosEntity.Relations.MscmovtosAlmacenDetEntityUsingIdCodProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrelacionCortesClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrelacionCortesClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(), _
					MsccatProductosEntity.Relations.MscrelacionCortesClientesEntityUsingCodCorte, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscrelacionCortesClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrelacionCortesClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrelacionProductosRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrelacionProductosRastros() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection(), _
					MsccatProductosEntity.Relations.MscrelacionProductosRastrosEntityUsingCodProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MscrelacionProductosRastrosEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrelacionProductosRastros", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductoDerivado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoDerivado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoDerivadoCollection(), _
					MsccatProductosEntity.Relations.ProductoDerivadoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.ProductoDerivadoEntity, Integer), 0, Nothing, Nothing, Nothing, "ProductoDerivado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductoDerivado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoDerivado_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoDerivadoCollection(), _
					MsccatProductosEntity.Relations.ProductoDerivadoEntityUsingIdDerivado, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.ProductoDerivadoEntity, Integer), 0, Nothing, Nothing, Nothing, "ProductoDerivado_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ReferenciaProductoDerivado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathReferenciaProductoDerivado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection(), _
					MsccatProductosEntity.Relations.ReferenciaProductoDerivadoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.ReferenciaProductoDerivadoEntity, Integer), 0, Nothing, Nothing, Nothing, "ReferenciaProductoDerivado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(), _
					MsccatProductosEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRegistroSacrificiosDecomiso' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRegistroSacrificiosDecomiso() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(), _
					MsccatProductosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRegistroSacrificiosDecomisoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRegistroSacrificiosDecomiso", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MsccatProductosEntity.Relations.RegistroSacrificiosDecomisosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatProductosEntity.Relations.MfacEmbarquesDetEntityUsingIdProducto, "__MsccatProductosEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MsccatProductosEntity.Relations.MfacEmbarquesDetEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaDevolucionProductos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatProductosEntity.Relations.DevolucionProductosEntityUsingIdProducto, "__MsccatProductosEntity__", String.Empty, JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MsccatProductosEntity.Relations.DevolucionProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaDevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaMscrelacionProductosRastros() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatProductosEntity.Relations.MscrelacionProductosRastrosEntityUsingCodProducto, "__MsccatProductosEntity__", String.Empty, JoinHint.None)
				relations.Add(MscrelacionProductosRastrosEntity.Relations.CatRastrosEntityUsingCodRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					MsccatProductosEntity.Relations.MscrelacionProductosRastrosEntityUsingCodProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaMscrelacionProductosRastros", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatProductosEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, "__MsccatProductosEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					MsccatProductosEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					MsccatProductosEntity.Relations.CuentaContableEntityUsingIdCeuntaContable, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccortesPreCortes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccortesPreCortes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection(), _
					MsccatProductosEntity.Relations.MsccortesPreCortesEntityUsingIdCorte, _
					CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), CType(Integralab.ORM.EntityType.MsccortesPreCortesEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccortesPreCortes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MsccatProductosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MsccatProductosEntity.CustomProperties
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
				Return MsccatProductosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdProducto property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."DescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubProducto property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."SubProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubProducto]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.SubProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.SubProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The PreCorte property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."PreCorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PreCorte]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.PreCorte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.PreCorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The Corte property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Corte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Corte]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Corte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Corte, Integer), value)
			End Set
		End Property
	
		''' <summary>The Decomisa property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Decomisa"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Decomisa]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Decomisa, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Decomisa, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnPiezas property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."EnPiezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnPiezas]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.EnPiezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.EnPiezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodProdAnt property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."CodProdAnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodProdAnt]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.CodProdAnt, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.CodProdAnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The MaximoPiezasxCaja property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."MaximoPiezasxCaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MaximoPiezasxCaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.MaximoPiezasxCaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.MaximoPiezasxCaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The NombreIngles property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."NombreIngles"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NombreIngles]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.NombreIngles, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.NombreIngles, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoBarra property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."CodigoBarra"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoBarra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.CodigoBarra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.CodigoBarra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCeuntaContable property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."IdCuentaContable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCeuntaContable]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.IdCeuntaContable, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.IdCeuntaContable, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrecioXkilo property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."PrecioXKilo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrecioXkilo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.PrecioXkilo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.PrecioXkilo, Integer), value)
			End Set
		End Property
	
		''' <summary>The PiezasXcabeza property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."PiezasXCabeza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PiezasXcabeza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.PiezasXcabeza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.PiezasXcabeza, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosMaximo property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."KilosMaximo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosMaximo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.KilosMaximo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.KilosMaximo, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosMinimo property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."KilosMinimo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosMinimo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.KilosMinimo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.KilosMinimo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Canal property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."Canal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Canal]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.Canal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.Canal, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsMerma property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."EsMerma"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsMerma]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.EsMerma, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.EsMerma, Integer), value)
			End Set
		End Property
	
		''' <summary>The ValorAgregado property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."ValorAgregado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ValorAgregado]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.ValorAgregado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.ValorAgregado, Integer), value)
			End Set
		End Property
	
		''' <summary>The ConHueso property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."ConHueso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ConHueso]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.ConHueso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.ConHueso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsDerivable property of the Entity MsccatProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatProductos"."EsDerivable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsDerivable]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatProductosFieldIndex.EsDerivable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MsccatProductosFieldIndex.EsDerivable, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductosDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductosDetalle]() As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Get
				Return GetMultiMsccatProductosDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosDetalle. When set to true, MsccatProductosDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductosDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosDetalle As Boolean
			Get
				Return _alwaysFetchMsccatProductosDetalle
			End Get
			Set
				_alwaysFetchMsccatProductosDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccortesPreCortesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccortesPreCortes_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccortesPreCortes_]() As Integralab.ORM.CollectionClasses.MsccortesPreCortesCollection
			Get
				Return GetMultiMsccortesPreCortes_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccortesPreCortes_. When set to true, MsccortesPreCortes_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccortesPreCortes_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccortesPreCortes_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccortesPreCortes_ As Boolean
			Get
				Return _alwaysFetchMsccortesPreCortes_
			End Get
			Set
				_alwaysFetchMsccortesPreCortes_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDevolucionProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DevolucionProductos]() As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Get
				Return GetMultiDevolucionProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DevolucionProductos. When set to true, DevolucionProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DevolucionProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiDevolucionProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDevolucionProductos As Boolean
			Get
				Return _alwaysFetchDevolucionProductos
			End Get
			Set
				_alwaysFetchDevolucionProductos = value
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
	
		''' <summary>Retrieves all related entities of type 'MscloteCortesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscloteCortesDet_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscloteCortesDet_]() As Integralab.ORM.CollectionClasses.MscloteCortesDetCollection
			Get
				Return GetMultiMscloteCortesDet_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscloteCortesDet_. When set to true, MscloteCortesDet_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscloteCortesDet_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscloteCortesDet_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscloteCortesDet_ As Boolean
			Get
				Return _alwaysFetchMscloteCortesDet_
			End Get
			Set
				_alwaysFetchMscloteCortesDet_ = value
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
	
		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrelacionCortesClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrelacionCortesClientes]() As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Get
				Return GetMultiMscrelacionCortesClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrelacionCortesClientes. When set to true, MscrelacionCortesClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrelacionCortesClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrelacionCortesClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrelacionCortesClientes As Boolean
			Get
				Return _alwaysFetchMscrelacionCortesClientes
			End Get
			Set
				_alwaysFetchMscrelacionCortesClientes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrelacionProductosRastrosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrelacionProductosRastros()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrelacionProductosRastros]() As Integralab.ORM.CollectionClasses.MscrelacionProductosRastrosCollection
			Get
				Return GetMultiMscrelacionProductosRastros(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrelacionProductosRastros. When set to true, MscrelacionProductosRastros is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrelacionProductosRastros is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrelacionProductosRastros(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrelacionProductosRastros As Boolean
			Get
				Return _alwaysFetchMscrelacionProductosRastros
			End Get
			Set
				_alwaysFetchMscrelacionProductosRastros = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoDerivado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoDerivado]() As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Get
				Return GetMultiProductoDerivado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoDerivado. When set to true, ProductoDerivado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoDerivado is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoDerivado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoDerivado As Boolean
			Get
				Return _alwaysFetchProductoDerivado
			End Get
			Set
				_alwaysFetchProductoDerivado = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoDerivado_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoDerivado_]() As Integralab.ORM.CollectionClasses.ProductoDerivadoCollection
			Get
				Return GetMultiProductoDerivado_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoDerivado_. When set to true, ProductoDerivado_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoDerivado_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoDerivado_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoDerivado_ As Boolean
			Get
				Return _alwaysFetchProductoDerivado_
			End Get
			Set
				_alwaysFetchProductoDerivado_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ReferenciaProductoDerivadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiReferenciaProductoDerivado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ReferenciaProductoDerivado]() As Integralab.ORM.CollectionClasses.ReferenciaProductoDerivadoCollection
			Get
				Return GetMultiReferenciaProductoDerivado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ReferenciaProductoDerivado. When set to true, ReferenciaProductoDerivado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ReferenciaProductoDerivado is accessed. You can always execute
		''' a forced fetch by calling GetMultiReferenciaProductoDerivado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchReferenciaProductoDerivado As Boolean
			Get
				Return _alwaysFetchReferenciaProductoDerivado
			End Get
			Set
				_alwaysFetchReferenciaProductoDerivado = value
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
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCabCollectionViaDevolucionProductos]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCabCollectionViaDevolucionProductos. When set to true, MfacEmbarquesCabCollectionViaDevolucionProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCabCollectionViaDevolucionProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCabCollectionViaDevolucionProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos
			End Get
			Set
				_alwaysFetchMfacEmbarquesCabCollectionViaDevolucionProductos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatRastrosCollectionViaMscrelacionProductosRastros()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatRastrosCollectionViaMscrelacionProductosRastros]() As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Get
				Return GetMultiCatRastrosCollectionViaMscrelacionProductosRastros(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatRastrosCollectionViaMscrelacionProductosRastros. When set to true, CatRastrosCollectionViaMscrelacionProductosRastros is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatRastrosCollectionViaMscrelacionProductosRastros is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatRastrosCollectionViaMscrelacionProductosRastros(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros As Boolean
			Get
				Return _alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros
			End Get
			Set
				_alwaysFetchCatRastrosCollectionViaMscrelacionProductosRastros = value
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
							_cuentaContable.UnsetRelatedEntity(Me, "MsccatProductos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MsccatProductos")
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
	
	
		''' <summary>Gets / Sets related entity of type 'MsccortesPreCortesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccortesPreCortes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccortesPreCortes]() As MsccortesPreCortesEntity
			Get
				Return GetSingleMsccortesPreCortes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccortesPreCortes(value)
				Else
					If value Is Nothing Then
						DesetupSyncMsccortesPreCortes(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "MsccatProductos")
						SetupSyncMsccortesPreCortes(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccortesPreCortes. When set to true, MsccortesPreCortes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccortesPreCortes is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccortesPreCortes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccortesPreCortes As Boolean
			Get
				Return _alwaysFetchMsccortesPreCortes
			End Get
			Set
				_alwaysFetchMsccortesPreCortes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccortesPreCortes is not found
		''' in the database. When set to true, MsccortesPreCortes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccortesPreCortesReturnsNewIfNotFound As Boolean
			Get
				Return _msccortesPreCortesReturnsNewIfNotFound
			End Get
			Set
				_msccortesPreCortesReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MsccatProductosEntity)
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
