' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 12:00:05
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
	''' <summary>Entity class which represents the entity 'Poliza'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PolizaEntity 
#Else
	<Serializable()> _
	Public Class PolizaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabFacturas As Integralab.ORM.CollectionClasses.CabFacturasCollection
		Private _alwaysFetchCabFacturas, _alreadyFetchedCabFacturas As Boolean
		Private _cabFacturas_ As Integralab.ORM.CollectionClasses.CabFacturasCollection
		Private _alwaysFetchCabFacturas_, _alreadyFetchedCabFacturas_ As Boolean
		Private _facturasClientesCab As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
		Private _alwaysFetchFacturasClientesCab, _alreadyFetchedFacturasClientesCab As Boolean
		Private _gastosDepartamentos As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
		Private _alwaysFetchGastosDepartamentos, _alreadyFetchedGastosDepartamentos As Boolean
		Private _mvtosBancariosCb As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
		Private _alwaysFetchMvtosBancariosCb, _alreadyFetchedMvtosBancariosCb As Boolean
		Private _pagoDeCtes As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
		Private _alwaysFetchPagoDeCtes, _alreadyFetchedPagoDeCtes As Boolean
		Private _pagoDeCtes_ As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
		Private _alwaysFetchPagoDeCtes_, _alreadyFetchedPagoDeCtes_ As Boolean
		Private _salidaGanadoCab As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab As Boolean
		Private _cheque As Integralab.ORM.CollectionClasses.ChequeCollection
		Private _alwaysFetchCheque, _alreadyFetchedCheque As Boolean
		Private _cheque_ As Integralab.ORM.CollectionClasses.ChequeCollection
		Private _alwaysFetchCheque_, _alreadyFetchedCheque_ As Boolean
		Private _usrBanDepositos As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
		Private _alwaysFetchUsrBanDepositos, _alreadyFetchedUsrBanDepositos As Boolean
		Private _usrBanDepositos_ As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
		Private _alwaysFetchUsrBanDepositos_, _alreadyFetchedUsrBanDepositos_ As Boolean
		Private _polizaDetalle As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
		Private _alwaysFetchPolizaDetalle, _alreadyFetchedPolizaDetalle As Boolean
		Private _usrCxppagosProveedores As Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection
		Private _alwaysFetchUsrCxppagosProveedores, _alreadyFetchedUsrCxppagosProveedores As Boolean
		Private _salidaGanadoCabCollectionViaCabFacturas As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas, _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas As Boolean
		Private _salidaGanadoCabCollectionViaCabFacturas_ As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_, _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ As Boolean
		Private _metodoCabCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.MetodoCabCollection
		Private _alwaysFetchMetodoCabCollectionViaGastosDepartamentos, _alreadyFetchedMetodoCabCollectionViaGastosDepartamentos As Boolean
		Private _cuentaContableCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaGastosDepartamentos, _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos As Boolean
		Private _cabMovGanCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab, _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
		Private _mcgcatCausasMuerteCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
		Private _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab, _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab As Boolean
		Private _catRastrosCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab, _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatCorralesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
		Private _beneficiarioCollectionViaCheque As Integralab.ORM.CollectionClasses.BeneficiarioCollection
		Private _alwaysFetchBeneficiarioCollectionViaCheque, _alreadyFetchedBeneficiarioCollectionViaCheque As Boolean
		Private _beneficiarioCollectionViaCheque_ As Integralab.ORM.CollectionClasses.BeneficiarioCollection
		Private _alwaysFetchBeneficiarioCollectionViaCheque_, _alreadyFetchedBeneficiarioCollectionViaCheque_ As Boolean
		Private _cuentaCollectionViaCheque As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque, _alreadyFetchedCuentaCollectionViaCheque As Boolean
		Private _cuentaCollectionViaCheque__ As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque__, _alreadyFetchedCuentaCollectionViaCheque__ As Boolean
		Private _cuentaCollectionViaCheque_ As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque_, _alreadyFetchedCuentaCollectionViaCheque_ As Boolean
		Private _cuentaCollectionViaCheque___ As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque___, _alreadyFetchedCuentaCollectionViaCheque___ As Boolean
		Private _cuentaCollectionViaUsrBanDepositos As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaUsrBanDepositos, _alreadyFetchedCuentaCollectionViaUsrBanDepositos As Boolean
		Private _cuentaCollectionViaUsrBanDepositos_ As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaUsrBanDepositos_, _alreadyFetchedCuentaCollectionViaUsrBanDepositos_ As Boolean
		Private _cuentaContableCollectionViaPolizaDetalle As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaPolizaDetalle, _alreadyFetchedCuentaContableCollectionViaPolizaDetalle As Boolean
		Private _cuentaCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores, _alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores As Boolean
		Private _proveedorCollectionViaUsrCxppagosProveedores As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores, _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores As Boolean



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
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <param name="validator">The custom validator Object for this PolizaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabFacturas = CType(info.GetValue("_cabFacturas", GetType(Integralab.ORM.CollectionClasses.CabFacturasCollection)), Integralab.ORM.CollectionClasses.CabFacturasCollection)
			_alwaysFetchCabFacturas = info.GetBoolean("_alwaysFetchCabFacturas")
			_alreadyFetchedCabFacturas = info.GetBoolean("_alreadyFetchedCabFacturas")
			_cabFacturas_ = CType(info.GetValue("_cabFacturas_", GetType(Integralab.ORM.CollectionClasses.CabFacturasCollection)), Integralab.ORM.CollectionClasses.CabFacturasCollection)
			_alwaysFetchCabFacturas_ = info.GetBoolean("_alwaysFetchCabFacturas_")
			_alreadyFetchedCabFacturas_ = info.GetBoolean("_alreadyFetchedCabFacturas_")
			_facturasClientesCab = CType(info.GetValue("_facturasClientesCab", GetType(Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)), Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)
			_alwaysFetchFacturasClientesCab = info.GetBoolean("_alwaysFetchFacturasClientesCab")
			_alreadyFetchedFacturasClientesCab = info.GetBoolean("_alreadyFetchedFacturasClientesCab")
			_gastosDepartamentos = CType(info.GetValue("_gastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)), Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)
			_alwaysFetchGastosDepartamentos = info.GetBoolean("_alwaysFetchGastosDepartamentos")
			_alreadyFetchedGastosDepartamentos = info.GetBoolean("_alreadyFetchedGastosDepartamentos")
			_mvtosBancariosCb = CType(info.GetValue("_mvtosBancariosCb", GetType(Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection)), Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection)
			_alwaysFetchMvtosBancariosCb = info.GetBoolean("_alwaysFetchMvtosBancariosCb")
			_alreadyFetchedMvtosBancariosCb = info.GetBoolean("_alreadyFetchedMvtosBancariosCb")
			_pagoDeCtes = CType(info.GetValue("_pagoDeCtes", GetType(Integralab.ORM.CollectionClasses.PagoDeCtesCollection)), Integralab.ORM.CollectionClasses.PagoDeCtesCollection)
			_alwaysFetchPagoDeCtes = info.GetBoolean("_alwaysFetchPagoDeCtes")
			_alreadyFetchedPagoDeCtes = info.GetBoolean("_alreadyFetchedPagoDeCtes")
			_pagoDeCtes_ = CType(info.GetValue("_pagoDeCtes_", GetType(Integralab.ORM.CollectionClasses.PagoDeCtesCollection)), Integralab.ORM.CollectionClasses.PagoDeCtesCollection)
			_alwaysFetchPagoDeCtes_ = info.GetBoolean("_alwaysFetchPagoDeCtes_")
			_alreadyFetchedPagoDeCtes_ = info.GetBoolean("_alreadyFetchedPagoDeCtes_")
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_cheque = CType(info.GetValue("_cheque", GetType(Integralab.ORM.CollectionClasses.ChequeCollection)), Integralab.ORM.CollectionClasses.ChequeCollection)
			_alwaysFetchCheque = info.GetBoolean("_alwaysFetchCheque")
			_alreadyFetchedCheque = info.GetBoolean("_alreadyFetchedCheque")
			_cheque_ = CType(info.GetValue("_cheque_", GetType(Integralab.ORM.CollectionClasses.ChequeCollection)), Integralab.ORM.CollectionClasses.ChequeCollection)
			_alwaysFetchCheque_ = info.GetBoolean("_alwaysFetchCheque_")
			_alreadyFetchedCheque_ = info.GetBoolean("_alreadyFetchedCheque_")
			_usrBanDepositos = CType(info.GetValue("_usrBanDepositos", GetType(Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)), Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)
			_alwaysFetchUsrBanDepositos = info.GetBoolean("_alwaysFetchUsrBanDepositos")
			_alreadyFetchedUsrBanDepositos = info.GetBoolean("_alreadyFetchedUsrBanDepositos")
			_usrBanDepositos_ = CType(info.GetValue("_usrBanDepositos_", GetType(Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)), Integralab.ORM.CollectionClasses.UsrBanDepositosCollection)
			_alwaysFetchUsrBanDepositos_ = info.GetBoolean("_alwaysFetchUsrBanDepositos_")
			_alreadyFetchedUsrBanDepositos_ = info.GetBoolean("_alreadyFetchedUsrBanDepositos_")
			_polizaDetalle = CType(info.GetValue("_polizaDetalle", GetType(Integralab.ORM.CollectionClasses.PolizaDetalleCollection)), Integralab.ORM.CollectionClasses.PolizaDetalleCollection)
			_alwaysFetchPolizaDetalle = info.GetBoolean("_alwaysFetchPolizaDetalle")
			_alreadyFetchedPolizaDetalle = info.GetBoolean("_alreadyFetchedPolizaDetalle")
			_usrCxppagosProveedores = CType(info.GetValue("_usrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)), Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection)
			_alwaysFetchUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchUsrCxppagosProveedores")
			_alreadyFetchedUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedUsrCxppagosProveedores")
			_salidaGanadoCabCollectionViaCabFacturas = CType(info.GetValue("_salidaGanadoCabCollectionViaCabFacturas", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas")
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas")
			_salidaGanadoCabCollectionViaCabFacturas_ = CType(info.GetValue("_salidaGanadoCabCollectionViaCabFacturas_", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_ = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_")
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_")
			_metodoCabCollectionViaGastosDepartamentos = CType(info.GetValue("_metodoCabCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.MetodoCabCollection)), Integralab.ORM.CollectionClasses.MetodoCabCollection)
			_alwaysFetchMetodoCabCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchMetodoCabCollectionViaGastosDepartamentos")
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos")
			_cuentaContableCollectionViaGastosDepartamentos = CType(info.GetValue("_cuentaContableCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaGastosDepartamentos")
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos")
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
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_beneficiarioCollectionViaCheque = CType(info.GetValue("_beneficiarioCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.BeneficiarioCollection)), Integralab.ORM.CollectionClasses.BeneficiarioCollection)
			_alwaysFetchBeneficiarioCollectionViaCheque = info.GetBoolean("_alwaysFetchBeneficiarioCollectionViaCheque")
			_alreadyFetchedBeneficiarioCollectionViaCheque = info.GetBoolean("_alreadyFetchedBeneficiarioCollectionViaCheque")
			_beneficiarioCollectionViaCheque_ = CType(info.GetValue("_beneficiarioCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.BeneficiarioCollection)), Integralab.ORM.CollectionClasses.BeneficiarioCollection)
			_alwaysFetchBeneficiarioCollectionViaCheque_ = info.GetBoolean("_alwaysFetchBeneficiarioCollectionViaCheque_")
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedBeneficiarioCollectionViaCheque_")
			_cuentaCollectionViaCheque = CType(info.GetValue("_cuentaCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque")
			_alreadyFetchedCuentaCollectionViaCheque = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque")
			_cuentaCollectionViaCheque__ = CType(info.GetValue("_cuentaCollectionViaCheque__", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque__ = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque__")
			_alreadyFetchedCuentaCollectionViaCheque__ = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque__")
			_cuentaCollectionViaCheque_ = CType(info.GetValue("_cuentaCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque_ = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque_")
			_alreadyFetchedCuentaCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque_")
			_cuentaCollectionViaCheque___ = CType(info.GetValue("_cuentaCollectionViaCheque___", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque___ = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque___")
			_alreadyFetchedCuentaCollectionViaCheque___ = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque___")
			_cuentaCollectionViaUsrBanDepositos = CType(info.GetValue("_cuentaCollectionViaUsrBanDepositos", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaUsrBanDepositos = info.GetBoolean("_alwaysFetchCuentaCollectionViaUsrBanDepositos")
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos = info.GetBoolean("_alreadyFetchedCuentaCollectionViaUsrBanDepositos")
			_cuentaCollectionViaUsrBanDepositos_ = CType(info.GetValue("_cuentaCollectionViaUsrBanDepositos_", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaUsrBanDepositos_ = info.GetBoolean("_alwaysFetchCuentaCollectionViaUsrBanDepositos_")
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos_ = info.GetBoolean("_alreadyFetchedCuentaCollectionViaUsrBanDepositos_")
			_cuentaContableCollectionViaPolizaDetalle = CType(info.GetValue("_cuentaContableCollectionViaPolizaDetalle", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaPolizaDetalle = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaPolizaDetalle")
			_alreadyFetchedCuentaContableCollectionViaPolizaDetalle = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaPolizaDetalle")
			_cuentaCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_cuentaCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores")
			_proveedorCollectionViaUsrCxppagosProveedores = CType(info.GetValue("_proveedorCollectionViaUsrCxppagosProveedores", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores")
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = info.GetBoolean("_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabFacturas = (_cabFacturas.Count > 0)
			_alreadyFetchedCabFacturas_ = (_cabFacturas_.Count > 0)
			_alreadyFetchedFacturasClientesCab = (_facturasClientesCab.Count > 0)
			_alreadyFetchedGastosDepartamentos = (_gastosDepartamentos.Count > 0)
			_alreadyFetchedMvtosBancariosCb = (_mvtosBancariosCb.Count > 0)
			_alreadyFetchedPagoDeCtes = (_pagoDeCtes.Count > 0)
			_alreadyFetchedPagoDeCtes_ = (_pagoDeCtes_.Count > 0)
			_alreadyFetchedSalidaGanadoCab = (_salidaGanadoCab.Count > 0)
			_alreadyFetchedCheque = (_cheque.Count > 0)
			_alreadyFetchedCheque_ = (_cheque_.Count > 0)
			_alreadyFetchedUsrBanDepositos = (_usrBanDepositos.Count > 0)
			_alreadyFetchedUsrBanDepositos_ = (_usrBanDepositos_.Count > 0)
			_alreadyFetchedPolizaDetalle = (_polizaDetalle.Count > 0)
			_alreadyFetchedUsrCxppagosProveedores = (_usrCxppagosProveedores.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas = (_salidaGanadoCabCollectionViaCabFacturas.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ = (_salidaGanadoCabCollectionViaCabFacturas_.Count > 0)
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = (_metodoCabCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = (_cuentaContableCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = (_cabMovGanCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = (_mcecatLotesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = (_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = (_catRastrosCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = (_mcecatCorralesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedBeneficiarioCollectionViaCheque = (_beneficiarioCollectionViaCheque.Count > 0)
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = (_beneficiarioCollectionViaCheque_.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque = (_cuentaCollectionViaCheque.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque__ = (_cuentaCollectionViaCheque__.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque_ = (_cuentaCollectionViaCheque_.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque___ = (_cuentaCollectionViaCheque___.Count > 0)
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos = (_cuentaCollectionViaUsrBanDepositos.Count > 0)
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos_ = (_cuentaCollectionViaUsrBanDepositos_.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaPolizaDetalle = (_cuentaContableCollectionViaPolizaDetalle.Count > 0)
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = (_cuentaCollectionViaUsrCxppagosProveedores.Count > 0)
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = (_proveedorCollectionViaUsrCxppagosProveedores.Count > 0)


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
			info.AddValue("_cabFacturas", _cabFacturas)
			info.AddValue("_alwaysFetchCabFacturas", _alwaysFetchCabFacturas)
			info.AddValue("_alreadyFetchedCabFacturas", _alreadyFetchedCabFacturas)
			info.AddValue("_cabFacturas_", _cabFacturas_)
			info.AddValue("_alwaysFetchCabFacturas_", _alwaysFetchCabFacturas_)
			info.AddValue("_alreadyFetchedCabFacturas_", _alreadyFetchedCabFacturas_)
			info.AddValue("_facturasClientesCab", _facturasClientesCab)
			info.AddValue("_alwaysFetchFacturasClientesCab", _alwaysFetchFacturasClientesCab)
			info.AddValue("_alreadyFetchedFacturasClientesCab", _alreadyFetchedFacturasClientesCab)
			info.AddValue("_gastosDepartamentos", _gastosDepartamentos)
			info.AddValue("_alwaysFetchGastosDepartamentos", _alwaysFetchGastosDepartamentos)
			info.AddValue("_alreadyFetchedGastosDepartamentos", _alreadyFetchedGastosDepartamentos)
			info.AddValue("_mvtosBancariosCb", _mvtosBancariosCb)
			info.AddValue("_alwaysFetchMvtosBancariosCb", _alwaysFetchMvtosBancariosCb)
			info.AddValue("_alreadyFetchedMvtosBancariosCb", _alreadyFetchedMvtosBancariosCb)
			info.AddValue("_pagoDeCtes", _pagoDeCtes)
			info.AddValue("_alwaysFetchPagoDeCtes", _alwaysFetchPagoDeCtes)
			info.AddValue("_alreadyFetchedPagoDeCtes", _alreadyFetchedPagoDeCtes)
			info.AddValue("_pagoDeCtes_", _pagoDeCtes_)
			info.AddValue("_alwaysFetchPagoDeCtes_", _alwaysFetchPagoDeCtes_)
			info.AddValue("_alreadyFetchedPagoDeCtes_", _alreadyFetchedPagoDeCtes_)
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_cheque", _cheque)
			info.AddValue("_alwaysFetchCheque", _alwaysFetchCheque)
			info.AddValue("_alreadyFetchedCheque", _alreadyFetchedCheque)
			info.AddValue("_cheque_", _cheque_)
			info.AddValue("_alwaysFetchCheque_", _alwaysFetchCheque_)
			info.AddValue("_alreadyFetchedCheque_", _alreadyFetchedCheque_)
			info.AddValue("_usrBanDepositos", _usrBanDepositos)
			info.AddValue("_alwaysFetchUsrBanDepositos", _alwaysFetchUsrBanDepositos)
			info.AddValue("_alreadyFetchedUsrBanDepositos", _alreadyFetchedUsrBanDepositos)
			info.AddValue("_usrBanDepositos_", _usrBanDepositos_)
			info.AddValue("_alwaysFetchUsrBanDepositos_", _alwaysFetchUsrBanDepositos_)
			info.AddValue("_alreadyFetchedUsrBanDepositos_", _alreadyFetchedUsrBanDepositos_)
			info.AddValue("_polizaDetalle", _polizaDetalle)
			info.AddValue("_alwaysFetchPolizaDetalle", _alwaysFetchPolizaDetalle)
			info.AddValue("_alreadyFetchedPolizaDetalle", _alreadyFetchedPolizaDetalle)
			info.AddValue("_usrCxppagosProveedores", _usrCxppagosProveedores)
			info.AddValue("_alwaysFetchUsrCxppagosProveedores", _alwaysFetchUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedUsrCxppagosProveedores", _alreadyFetchedUsrCxppagosProveedores)
			info.AddValue("_salidaGanadoCabCollectionViaCabFacturas", _salidaGanadoCabCollectionViaCabFacturas)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas", _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas", _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas)
			info.AddValue("_salidaGanadoCabCollectionViaCabFacturas_", _salidaGanadoCabCollectionViaCabFacturas_)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_", _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_", _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_)
			info.AddValue("_metodoCabCollectionViaGastosDepartamentos", _metodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchMetodoCabCollectionViaGastosDepartamentos", _alwaysFetchMetodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos", _alreadyFetchedMetodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_cuentaContableCollectionViaGastosDepartamentos", _cuentaContableCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaGastosDepartamentos", _alwaysFetchCuentaContableCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos", _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos)
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
			info.AddValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", _mcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab", _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab", _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_beneficiarioCollectionViaCheque", _beneficiarioCollectionViaCheque)
			info.AddValue("_alwaysFetchBeneficiarioCollectionViaCheque", _alwaysFetchBeneficiarioCollectionViaCheque)
			info.AddValue("_alreadyFetchedBeneficiarioCollectionViaCheque", _alreadyFetchedBeneficiarioCollectionViaCheque)
			info.AddValue("_beneficiarioCollectionViaCheque_", _beneficiarioCollectionViaCheque_)
			info.AddValue("_alwaysFetchBeneficiarioCollectionViaCheque_", _alwaysFetchBeneficiarioCollectionViaCheque_)
			info.AddValue("_alreadyFetchedBeneficiarioCollectionViaCheque_", _alreadyFetchedBeneficiarioCollectionViaCheque_)
			info.AddValue("_cuentaCollectionViaCheque", _cuentaCollectionViaCheque)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque", _alwaysFetchCuentaCollectionViaCheque)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque", _alreadyFetchedCuentaCollectionViaCheque)
			info.AddValue("_cuentaCollectionViaCheque__", _cuentaCollectionViaCheque__)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque__", _alwaysFetchCuentaCollectionViaCheque__)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque__", _alreadyFetchedCuentaCollectionViaCheque__)
			info.AddValue("_cuentaCollectionViaCheque_", _cuentaCollectionViaCheque_)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque_", _alwaysFetchCuentaCollectionViaCheque_)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque_", _alreadyFetchedCuentaCollectionViaCheque_)
			info.AddValue("_cuentaCollectionViaCheque___", _cuentaCollectionViaCheque___)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque___", _alwaysFetchCuentaCollectionViaCheque___)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque___", _alreadyFetchedCuentaCollectionViaCheque___)
			info.AddValue("_cuentaCollectionViaUsrBanDepositos", _cuentaCollectionViaUsrBanDepositos)
			info.AddValue("_alwaysFetchCuentaCollectionViaUsrBanDepositos", _alwaysFetchCuentaCollectionViaUsrBanDepositos)
			info.AddValue("_alreadyFetchedCuentaCollectionViaUsrBanDepositos", _alreadyFetchedCuentaCollectionViaUsrBanDepositos)
			info.AddValue("_cuentaCollectionViaUsrBanDepositos_", _cuentaCollectionViaUsrBanDepositos_)
			info.AddValue("_alwaysFetchCuentaCollectionViaUsrBanDepositos_", _alwaysFetchCuentaCollectionViaUsrBanDepositos_)
			info.AddValue("_alreadyFetchedCuentaCollectionViaUsrBanDepositos_", _alreadyFetchedCuentaCollectionViaUsrBanDepositos_)
			info.AddValue("_cuentaContableCollectionViaPolizaDetalle", _cuentaContableCollectionViaPolizaDetalle)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaPolizaDetalle", _alwaysFetchCuentaContableCollectionViaPolizaDetalle)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaPolizaDetalle", _alreadyFetchedCuentaContableCollectionViaPolizaDetalle)
			info.AddValue("_cuentaCollectionViaUsrCxppagosProveedores", _cuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores", _alwaysFetchCuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores", _alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores)
			info.AddValue("_proveedorCollectionViaUsrCxppagosProveedores", _proveedorCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores", _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores)
			info.AddValue("_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores", _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores)


			
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

				Case "CabFacturas"
					_alreadyFetchedCabFacturas = True
					If Not entity Is Nothing Then
						Me.CabFacturas.Add(CType(entity, CabFacturasEntity))
					End If
				Case "CabFacturas_"
					_alreadyFetchedCabFacturas_ = True
					If Not entity Is Nothing Then
						Me.CabFacturas_.Add(CType(entity, CabFacturasEntity))
					End If
				Case "FacturasClientesCab"
					_alreadyFetchedFacturasClientesCab = True
					If Not entity Is Nothing Then
						Me.FacturasClientesCab.Add(CType(entity, FacturasClientesCabEntity))
					End If
				Case "GastosDepartamentos"
					_alreadyFetchedGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.GastosDepartamentos.Add(CType(entity, GastosDepartamentosEntity))
					End If
				Case "MvtosBancariosCb"
					_alreadyFetchedMvtosBancariosCb = True
					If Not entity Is Nothing Then
						Me.MvtosBancariosCb.Add(CType(entity, MvtosBancariosCbEntity))
					End If
				Case "PagoDeCtes"
					_alreadyFetchedPagoDeCtes = True
					If Not entity Is Nothing Then
						Me.PagoDeCtes.Add(CType(entity, PagoDeCtesEntity))
					End If
				Case "PagoDeCtes_"
					_alreadyFetchedPagoDeCtes_ = True
					If Not entity Is Nothing Then
						Me.PagoDeCtes_.Add(CType(entity, PagoDeCtesEntity))
					End If
				Case "SalidaGanadoCab"
					_alreadyFetchedSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCab.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "Cheque"
					_alreadyFetchedCheque = True
					If Not entity Is Nothing Then
						Me.Cheque.Add(CType(entity, ChequeEntity))
					End If
				Case "Cheque_"
					_alreadyFetchedCheque_ = True
					If Not entity Is Nothing Then
						Me.Cheque_.Add(CType(entity, ChequeEntity))
					End If
				Case "UsrBanDepositos"
					_alreadyFetchedUsrBanDepositos = True
					If Not entity Is Nothing Then
						Me.UsrBanDepositos.Add(CType(entity, UsrBanDepositosEntity))
					End If
				Case "UsrBanDepositos_"
					_alreadyFetchedUsrBanDepositos_ = True
					If Not entity Is Nothing Then
						Me.UsrBanDepositos_.Add(CType(entity, UsrBanDepositosEntity))
					End If
				Case "PolizaDetalle"
					_alreadyFetchedPolizaDetalle = True
					If Not entity Is Nothing Then
						Me.PolizaDetalle.Add(CType(entity, PolizaDetalleEntity))
					End If
				Case "UsrCxppagosProveedores"
					_alreadyFetchedUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.UsrCxppagosProveedores.Add(CType(entity, UsrCxppagosProveedoresEntity))
					End If
				Case "SalidaGanadoCabCollectionViaCabFacturas"
					_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCabCollectionViaCabFacturas.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "SalidaGanadoCabCollectionViaCabFacturas_"
					_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCabCollectionViaCabFacturas_.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "MetodoCabCollectionViaGastosDepartamentos"
					_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.MetodoCabCollectionViaGastosDepartamentos.Add(CType(entity, MetodoCabEntity))
					End If
				Case "CuentaContableCollectionViaGastosDepartamentos"
					_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaGastosDepartamentos.Add(CType(entity, CuentaContableEntity))
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
				Case "McecatCorralesCabCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaSalidaGanadoCab.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "BeneficiarioCollectionViaCheque"
					_alreadyFetchedBeneficiarioCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.BeneficiarioCollectionViaCheque.Add(CType(entity, BeneficiarioEntity))
					End If
				Case "BeneficiarioCollectionViaCheque_"
					_alreadyFetchedBeneficiarioCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.BeneficiarioCollectionViaCheque_.Add(CType(entity, BeneficiarioEntity))
					End If
				Case "CuentaCollectionViaCheque"
					_alreadyFetchedCuentaCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaCheque__"
					_alreadyFetchedCuentaCollectionViaCheque__ = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque__.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaCheque_"
					_alreadyFetchedCuentaCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque_.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaCheque___"
					_alreadyFetchedCuentaCollectionViaCheque___ = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque___.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaUsrBanDepositos"
					_alreadyFetchedCuentaCollectionViaUsrBanDepositos = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaUsrBanDepositos.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaUsrBanDepositos_"
					_alreadyFetchedCuentaCollectionViaUsrBanDepositos_ = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaUsrBanDepositos_.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaContableCollectionViaPolizaDetalle"
					_alreadyFetchedCuentaContableCollectionViaPolizaDetalle = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaPolizaDetalle.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaUsrCxppagosProveedores.Add(CType(entity, CuentaEntity))
					End If
				Case "ProveedorCollectionViaUsrCxppagosProveedores"
					_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaUsrCxppagosProveedores.Add(CType(entity, ProveedorEntity))
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

				Case "CabFacturas"
					_cabFacturas.Add(CType(relatedEntity, CabFacturasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabFacturas_"
					_cabFacturas_.Add(CType(relatedEntity, CabFacturasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "FacturasClientesCab"
					_facturasClientesCab.Add(CType(relatedEntity, FacturasClientesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					_gastosDepartamentos.Add(CType(relatedEntity, GastosDepartamentosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MvtosBancariosCb"
					_mvtosBancariosCb.Add(CType(relatedEntity, MvtosBancariosCbEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoDeCtes"
					_pagoDeCtes.Add(CType(relatedEntity, PagoDeCtesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoDeCtes_"
					_pagoDeCtes_.Add(CType(relatedEntity, PagoDeCtesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					_salidaGanadoCab.Add(CType(relatedEntity, SalidaGanadoCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cheque"
					_cheque.Add(CType(relatedEntity, ChequeEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cheque_"
					_cheque_.Add(CType(relatedEntity, ChequeEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrBanDepositos"
					_usrBanDepositos.Add(CType(relatedEntity, UsrBanDepositosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrBanDepositos_"
					_usrBanDepositos_.Add(CType(relatedEntity, UsrBanDepositosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PolizaDetalle"
					_polizaDetalle.Add(CType(relatedEntity, PolizaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					_usrCxppagosProveedores.Add(CType(relatedEntity, UsrCxppagosProveedoresEntity))
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

				Case "CabFacturas"
					MyBase.PerformRelatedEntityRemoval(_cabFacturas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabFacturas_"
					MyBase.PerformRelatedEntityRemoval(_cabFacturas_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "FacturasClientesCab"
					MyBase.PerformRelatedEntityRemoval(_facturasClientesCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					MyBase.PerformRelatedEntityRemoval(_gastosDepartamentos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MvtosBancariosCb"
					MyBase.PerformRelatedEntityRemoval(_mvtosBancariosCb, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoDeCtes"
					MyBase.PerformRelatedEntityRemoval(_pagoDeCtes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoDeCtes_"
					MyBase.PerformRelatedEntityRemoval(_pagoDeCtes_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoCab"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cheque"
					MyBase.PerformRelatedEntityRemoval(_cheque, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cheque_"
					MyBase.PerformRelatedEntityRemoval(_cheque_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrBanDepositos"
					MyBase.PerformRelatedEntityRemoval(_usrBanDepositos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrBanDepositos_"
					MyBase.PerformRelatedEntityRemoval(_usrBanDepositos_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PolizaDetalle"
					MyBase.PerformRelatedEntityRemoval(_polizaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxppagosProveedores"
					MyBase.PerformRelatedEntityRemoval(_usrCxppagosProveedores, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_cabFacturas)
			toReturn.Add(_cabFacturas_)
			toReturn.Add(_facturasClientesCab)
			toReturn.Add(_gastosDepartamentos)
			toReturn.Add(_mvtosBancariosCb)
			toReturn.Add(_pagoDeCtes)
			toReturn.Add(_pagoDeCtes_)
			toReturn.Add(_salidaGanadoCab)
			toReturn.Add(_cheque)
			toReturn.Add(_cheque_)
			toReturn.Add(_usrBanDepositos)
			toReturn.Add(_usrBanDepositos_)
			toReturn.Add(_polizaDetalle)
			toReturn.Add(_usrCxppagosProveedores)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PolizaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PolizaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabFacturasEntity'</returns>
		Public Function GetMultiCabFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas(forceFetch, _cabFacturas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabFacturasEntity'</returns>
		Public Function GetMultiCabFacturas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas(forceFetch, _cabFacturas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			If ( Not _alreadyFetchedCabFacturas Or forceFetch Or _alwaysFetchCabFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabFacturas)
					End If
				End If
				_cabFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabFacturas.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_cabFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedCabFacturas = True
			End If
			Return _cabFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabFacturas'. These settings will be taken into account
		''' when the property CabFacturas is requested or GetMultiCabFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabFacturas.SortClauses=sortClauses
			_cabFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabFacturasEntity'</returns>
		Public Function GetMultiCabFacturas_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas_(forceFetch, _cabFacturas_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabFacturas_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabFacturasEntity'</returns>
		Public Function GetMultiCabFacturas_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturas_(forceFetch, _cabFacturas_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabFacturas_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			If ( Not _alreadyFetchedCabFacturas_ Or forceFetch Or _alwaysFetchCabFacturas_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabFacturas_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabFacturas_)
					End If
				End If
				_cabFacturas_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabFacturas_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabFacturas_.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cabFacturas_.SuppressClearInGetMulti = False
				_alreadyFetchedCabFacturas_ = True
			End If
			Return _cabFacturas_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabFacturas_'. These settings will be taken into account
		''' when the property CabFacturas_ is requested or GetMultiCabFacturas_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabFacturas_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabFacturas_.SortClauses=sortClauses
			_cabFacturas_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, _facturasClientesCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, _facturasClientesCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			If ( Not _alreadyFetchedFacturasClientesCab Or forceFetch Or _alwaysFetchFacturasClientesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesCab)
					End If
				End If
				_facturasClientesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesCab.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_facturasClientesCab.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesCab = True
			End If
			Return _facturasClientesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesCab'. These settings will be taken into account
		''' when the property FacturasClientesCab is requested or GetMultiFacturasClientesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesCab.SortClauses=sortClauses
			_facturasClientesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			If ( Not _alreadyFetchedGastosDepartamentos Or forceFetch Or _alwaysFetchGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _gastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_gastosDepartamentos)
					End If
				End If
				_gastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_gastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_gastosDepartamentos.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_gastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedGastosDepartamentos = True
			End If
			Return _gastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'GastosDepartamentos'. These settings will be taken into account
		''' when the property GastosDepartamentos is requested or GetMultiGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_gastosDepartamentos.SortClauses=sortClauses
			_gastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MvtosBancariosCbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MvtosBancariosCbEntity'</returns>
		Public Function GetMultiMvtosBancariosCb(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
			Return GetMultiMvtosBancariosCb(forceFetch, _mvtosBancariosCb.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MvtosBancariosCbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMvtosBancariosCb(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
			Return GetMultiMvtosBancariosCb(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MvtosBancariosCbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MvtosBancariosCbEntity'</returns>
		Public Function GetMultiMvtosBancariosCb(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
			Return GetMultiMvtosBancariosCb(forceFetch, _mvtosBancariosCb.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MvtosBancariosCbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMvtosBancariosCb(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
			If ( Not _alreadyFetchedMvtosBancariosCb Or forceFetch Or _alwaysFetchMvtosBancariosCb) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mvtosBancariosCb.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mvtosBancariosCb)
					End If
				End If
				_mvtosBancariosCb.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mvtosBancariosCb.EntityFactoryToUse = entityFactoryToUse
				End If
				_mvtosBancariosCb.GetMultiManyToOne(Me, Filter)
				_mvtosBancariosCb.SuppressClearInGetMulti = False
				_alreadyFetchedMvtosBancariosCb = True
			End If
			Return _mvtosBancariosCb
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MvtosBancariosCb'. These settings will be taken into account
		''' when the property MvtosBancariosCb is requested or GetMultiMvtosBancariosCb is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMvtosBancariosCb(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mvtosBancariosCb.SortClauses=sortClauses
			_mvtosBancariosCb.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, _pagoDeCtes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, _pagoDeCtes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoDeCtes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			If ( Not _alreadyFetchedPagoDeCtes Or forceFetch Or _alwaysFetchPagoDeCtes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoDeCtes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoDeCtes)
					End If
				End If
				_pagoDeCtes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoDeCtes.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoDeCtes.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_pagoDeCtes.SuppressClearInGetMulti = False
				_alreadyFetchedPagoDeCtes = True
			End If
			Return _pagoDeCtes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoDeCtes'. These settings will be taken into account
		''' when the property PagoDeCtes is requested or GetMultiPagoDeCtes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoDeCtes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoDeCtes.SortClauses=sortClauses
			_pagoDeCtes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes_(forceFetch, _pagoDeCtes_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPagoDeCtes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes_(forceFetch, _pagoDeCtes_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoDeCtes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			If ( Not _alreadyFetchedPagoDeCtes_ Or forceFetch Or _alwaysFetchPagoDeCtes_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoDeCtes_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoDeCtes_)
					End If
				End If
				_pagoDeCtes_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoDeCtes_.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoDeCtes_.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_pagoDeCtes_.SuppressClearInGetMulti = False
				_alreadyFetchedPagoDeCtes_ = True
			End If
			Return _pagoDeCtes_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoDeCtes_'. These settings will be taken into account
		''' when the property PagoDeCtes_ is requested or GetMultiPagoDeCtes_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoDeCtes_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoDeCtes_.SortClauses=sortClauses
			_pagoDeCtes_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_salidaGanadoCab.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			If ( Not _alreadyFetchedCheque Or forceFetch Or _alwaysFetchCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cheque)
					End If
				End If
				_cheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_cheque.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_cheque.SuppressClearInGetMulti = False
				_alreadyFetchedCheque = True
			End If
			Return _cheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cheque'. These settings will be taken into account
		''' when the property Cheque is requested or GetMultiCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cheque.SortClauses=sortClauses
			_cheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, _cheque_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque_(forceFetch, _cheque_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			If ( Not _alreadyFetchedCheque_ Or forceFetch Or _alwaysFetchCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cheque_)
					End If
				End If
				_cheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cheque_.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_cheque_.SuppressClearInGetMulti = False
				_alreadyFetchedCheque_ = True
			End If
			Return _cheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cheque_'. These settings will be taken into account
		''' when the property Cheque_ is requested or GetMultiCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cheque_.SortClauses=sortClauses
			_cheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, _usrBanDepositos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos(forceFetch, _usrBanDepositos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			If ( Not _alreadyFetchedUsrBanDepositos Or forceFetch Or _alwaysFetchUsrBanDepositos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrBanDepositos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrBanDepositos)
					End If
				End If
				_usrBanDepositos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrBanDepositos.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrBanDepositos.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_usrBanDepositos.SuppressClearInGetMulti = False
				_alreadyFetchedUsrBanDepositos = True
			End If
			Return _usrBanDepositos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrBanDepositos'. These settings will be taken into account
		''' when the property UsrBanDepositos is requested or GetMultiUsrBanDepositos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrBanDepositos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrBanDepositos.SortClauses=sortClauses
			_usrBanDepositos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos_(forceFetch, _usrBanDepositos_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrBanDepositos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrBanDepositosEntity'</returns>
		Public Function GetMultiUsrBanDepositos_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Return GetMultiUsrBanDepositos_(forceFetch, _usrBanDepositos_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrBanDepositos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			If ( Not _alreadyFetchedUsrBanDepositos_ Or forceFetch Or _alwaysFetchUsrBanDepositos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrBanDepositos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrBanDepositos_)
					End If
				End If
				_usrBanDepositos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrBanDepositos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrBanDepositos_.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_usrBanDepositos_.SuppressClearInGetMulti = False
				_alreadyFetchedUsrBanDepositos_ = True
			End If
			Return _usrBanDepositos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrBanDepositos_'. These settings will be taken into account
		''' when the property UsrBanDepositos_ is requested or GetMultiUsrBanDepositos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrBanDepositos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrBanDepositos_.SortClauses=sortClauses
			_usrBanDepositos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PolizaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaDetalleEntity'</returns>
		Public Function GetMultiPolizaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
			Return GetMultiPolizaDetalle(forceFetch, _polizaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPolizaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
			Return GetMultiPolizaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PolizaDetalleEntity'</returns>
		Public Function GetMultiPolizaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
			Return GetMultiPolizaDetalle(forceFetch, _polizaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
			If ( Not _alreadyFetchedPolizaDetalle Or forceFetch Or _alwaysFetchPolizaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaDetalle)
					End If
				End If
				_polizaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_polizaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaDetalle = True
			End If
			Return _polizaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaDetalle'. These settings will be taken into account
		''' when the property PolizaDetalle is requested or GetMultiPolizaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaDetalle.SortClauses=sortClauses
			_polizaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_usrCxppagosProveedores.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCabCollectionViaCabFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCabCollectionViaCabFacturas(forceFetch, _salidaGanadoCabCollectionViaCabFacturas.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCabCollectionViaCabFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas Or forceFetch Or _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCabCollectionViaCabFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCabCollectionViaCabFacturas)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.CabFacturasEntityUsingFolPoliza, "__PolizaEntity__", "CabFacturas_", JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia, "CabFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_salidaGanadoCabCollectionViaCabFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCabCollectionViaCabFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCabCollectionViaCabFacturas.GetMulti(Filter, relations)
				_salidaGanadoCabCollectionViaCabFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas = True
			End If
			Return _salidaGanadoCabCollectionViaCabFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCabCollectionViaCabFacturas'. These settings will be taken into account
		''' when the property SalidaGanadoCabCollectionViaCabFacturas is requested or GetMultiSalidaGanadoCabCollectionViaCabFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCabCollectionViaCabFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCabCollectionViaCabFacturas.SortClauses=sortClauses
			_salidaGanadoCabCollectionViaCabFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCabCollectionViaCabFacturas_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCabCollectionViaCabFacturas_(forceFetch, _salidaGanadoCabCollectionViaCabFacturas_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCabCollectionViaCabFacturas_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ Or forceFetch Or _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCabCollectionViaCabFacturas_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCabCollectionViaCabFacturas_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.CabFacturasEntityUsingFolCanPoliza, "__PolizaEntity__", "CabFacturas_", JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia, "CabFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_salidaGanadoCabCollectionViaCabFacturas_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCabCollectionViaCabFacturas_.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCabCollectionViaCabFacturas_.GetMulti(Filter, relations)
				_salidaGanadoCabCollectionViaCabFacturas_.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ = True
			End If
			Return _salidaGanadoCabCollectionViaCabFacturas_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCabCollectionViaCabFacturas_'. These settings will be taken into account
		''' when the property SalidaGanadoCabCollectionViaCabFacturas_ is requested or GetMultiSalidaGanadoCabCollectionViaCabFacturas_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCabCollectionViaCabFacturas_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCabCollectionViaCabFacturas_.SortClauses=sortClauses
			_salidaGanadoCabCollectionViaCabFacturas_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MetodoCabEntity'</returns>
		Public Function GetMultiMetodoCabCollectionViaGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MetodoCabCollection
			Return GetMultiMetodoCabCollectionViaGastosDepartamentos(forceFetch, _metodoCabCollectionViaGastosDepartamentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMetodoCabCollectionViaGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MetodoCabCollection
			If ( Not _alreadyFetchedMetodoCabCollectionViaGastosDepartamentos Or forceFetch Or _alwaysFetchMetodoCabCollectionViaGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _metodoCabCollectionViaGastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_metodoCabCollectionViaGastosDepartamentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, "__PolizaEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_metodoCabCollectionViaGastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_metodoCabCollectionViaGastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_metodoCabCollectionViaGastosDepartamentos.GetMulti(Filter, relations)
				_metodoCabCollectionViaGastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = True
			End If
			Return _metodoCabCollectionViaGastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MetodoCabCollectionViaGastosDepartamentos'. These settings will be taken into account
		''' when the property MetodoCabCollectionViaGastosDepartamentos is requested or GetMultiMetodoCabCollectionViaGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMetodoCabCollectionViaGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_metodoCabCollectionViaGastosDepartamentos.SortClauses=sortClauses
			_metodoCabCollectionViaGastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch, _cuentaContableCollectionViaGastosDepartamentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos Or forceFetch Or _alwaysFetchCuentaContableCollectionViaGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaGastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaGastosDepartamentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, "__PolizaEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaGastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaGastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaGastosDepartamentos.GetMulti(Filter, relations)
				_cuentaContableCollectionViaGastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = True
			End If
			Return _cuentaContableCollectionViaGastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaGastosDepartamentos'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaGastosDepartamentos is requested or GetMultiCuentaContableCollectionViaGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaGastosDepartamentos.SortClauses=sortClauses
			_cuentaContableCollectionViaGastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiarioCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiarioCollectionViaCheque(forceFetch, _beneficiarioCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBeneficiarioCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			If ( Not _alreadyFetchedBeneficiarioCollectionViaCheque Or forceFetch Or _alwaysFetchBeneficiarioCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _beneficiarioCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_beneficiarioCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_beneficiarioCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_beneficiarioCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_beneficiarioCollectionViaCheque.GetMulti(Filter, relations)
				_beneficiarioCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedBeneficiarioCollectionViaCheque = True
			End If
			Return _beneficiarioCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BeneficiarioCollectionViaCheque'. These settings will be taken into account
		''' when the property BeneficiarioCollectionViaCheque is requested or GetMultiBeneficiarioCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBeneficiarioCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_beneficiarioCollectionViaCheque.SortClauses=sortClauses
			_beneficiarioCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BeneficiarioEntity'</returns>
		Public Function GetMultiBeneficiarioCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Return GetMultiBeneficiarioCollectionViaCheque_(forceFetch, _beneficiarioCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBeneficiarioCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			If ( Not _alreadyFetchedBeneficiarioCollectionViaCheque_ Or forceFetch Or _alwaysFetchBeneficiarioCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _beneficiarioCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_beneficiarioCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_beneficiarioCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_beneficiarioCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_beneficiarioCollectionViaCheque_.GetMulti(Filter, relations)
				_beneficiarioCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedBeneficiarioCollectionViaCheque_ = True
			End If
			Return _beneficiarioCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BeneficiarioCollectionViaCheque_'. These settings will be taken into account
		''' when the property BeneficiarioCollectionViaCheque_ is requested or GetMultiBeneficiarioCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBeneficiarioCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_beneficiarioCollectionViaCheque_.SortClauses=sortClauses
			_beneficiarioCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque(forceFetch, _cuentaCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque = True
			End If
			Return _cuentaCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque is requested or GetMultiCuentaCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque.SortClauses=sortClauses
			_cuentaCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque__(forceFetch, _cuentaCollectionViaCheque__.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque__ Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque__)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque__.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque__.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque__.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque__ = True
			End If
			Return _cuentaCollectionViaCheque__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque__'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque__ is requested or GetMultiCuentaCollectionViaCheque__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque__.SortClauses=sortClauses
			_cuentaCollectionViaCheque__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque_(forceFetch, _cuentaCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque_ Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque_.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque_ = True
			End If
			Return _cuentaCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque_'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque_ is requested or GetMultiCuentaCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque_.SortClauses=sortClauses
			_cuentaCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque___(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque___(forceFetch, _cuentaCollectionViaCheque___.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque___(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque___ Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque___) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque___.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque___)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque___.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque___.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque___.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque___.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque___ = True
			End If
			Return _cuentaCollectionViaCheque___
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque___'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque___ is requested or GetMultiCuentaCollectionViaCheque___ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque___(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque___.SortClauses=sortClauses
			_cuentaCollectionViaCheque___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaUsrBanDepositos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaUsrBanDepositos(forceFetch, _cuentaCollectionViaUsrBanDepositos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaUsrBanDepositos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaUsrBanDepositos Or forceFetch Or _alwaysFetchCuentaCollectionViaUsrBanDepositos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaUsrBanDepositos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaUsrBanDepositos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaIdCancelacion, "__PolizaEntity__", "UsrBanDepositos_", JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.CuentaEntityUsingCuentaId, "UsrBanDepositos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaUsrBanDepositos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaUsrBanDepositos.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaUsrBanDepositos.GetMulti(Filter, relations)
				_cuentaCollectionViaUsrBanDepositos.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaUsrBanDepositos = True
			End If
			Return _cuentaCollectionViaUsrBanDepositos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaUsrBanDepositos'. These settings will be taken into account
		''' when the property CuentaCollectionViaUsrBanDepositos is requested or GetMultiCuentaCollectionViaUsrBanDepositos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaUsrBanDepositos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaUsrBanDepositos.SortClauses=sortClauses
			_cuentaCollectionViaUsrBanDepositos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaUsrBanDepositos_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaUsrBanDepositos_(forceFetch, _cuentaCollectionViaUsrBanDepositos_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaUsrBanDepositos_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaUsrBanDepositos_ Or forceFetch Or _alwaysFetchCuentaCollectionViaUsrBanDepositos_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaUsrBanDepositos_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaUsrBanDepositos_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaId, "__PolizaEntity__", "UsrBanDepositos_", JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.CuentaEntityUsingCuentaId, "UsrBanDepositos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaUsrBanDepositos_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaUsrBanDepositos_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaUsrBanDepositos_.GetMulti(Filter, relations)
				_cuentaCollectionViaUsrBanDepositos_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaUsrBanDepositos_ = True
			End If
			Return _cuentaCollectionViaUsrBanDepositos_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaUsrBanDepositos_'. These settings will be taken into account
		''' when the property CuentaCollectionViaUsrBanDepositos_ is requested or GetMultiCuentaCollectionViaUsrBanDepositos_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaUsrBanDepositos_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaUsrBanDepositos_.SortClauses=sortClauses
			_cuentaCollectionViaUsrBanDepositos_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaPolizaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaPolizaDetalle(forceFetch, _cuentaContableCollectionViaPolizaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaPolizaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaPolizaDetalle Or forceFetch Or _alwaysFetchCuentaContableCollectionViaPolizaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaPolizaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaPolizaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.PolizaDetalleEntityUsingPolizaId, "__PolizaEntity__", "PolizaDetalle_", JoinHint.None)
				relations.Add(PolizaDetalleEntity.Relations.CuentaContableEntityUsingCuentaContableId, "PolizaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaPolizaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaPolizaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaPolizaDetalle.GetMulti(Filter, relations)
				_cuentaContableCollectionViaPolizaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaPolizaDetalle = True
			End If
			Return _cuentaContableCollectionViaPolizaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaPolizaDetalle'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaPolizaDetalle is requested or GetMultiCuentaContableCollectionViaPolizaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaPolizaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaPolizaDetalle.SortClauses=sortClauses
			_cuentaContableCollectionViaPolizaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, "__PolizaEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch, _proveedorCollectionViaUsrCxppagosProveedores.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaUsrCxppagosProveedores(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores Or forceFetch Or _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaUsrCxppagosProveedores.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaUsrCxppagosProveedores)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, "__PolizaEntity__", "UsrCxppagosProveedores_", JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.ProveedorEntityUsingIdProveedor, "UsrCxppagosProveedores_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PolizaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_proveedorCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaUsrCxppagosProveedores.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaUsrCxppagosProveedores.GetMulti(Filter, relations)
				_proveedorCollectionViaUsrCxppagosProveedores.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = True
			End If
			Return _proveedorCollectionViaUsrCxppagosProveedores
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaUsrCxppagosProveedores'. These settings will be taken into account
		''' when the property ProveedorCollectionViaUsrCxppagosProveedores is requested or GetMultiProveedorCollectionViaUsrCxppagosProveedores is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaUsrCxppagosProveedores(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaUsrCxppagosProveedores.SortClauses=sortClauses
			_proveedorCollectionViaUsrCxppagosProveedores.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PolizaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PolizaFieldIndex)
















					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabFacturas.ActiveContext = MyBase.ActiveContext
			_cabFacturas_.ActiveContext = MyBase.ActiveContext
			_facturasClientesCab.ActiveContext = MyBase.ActiveContext
			_gastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_mvtosBancariosCb.ActiveContext = MyBase.ActiveContext
			_pagoDeCtes.ActiveContext = MyBase.ActiveContext
			_pagoDeCtes_.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_cheque.ActiveContext = MyBase.ActiveContext
			_cheque_.ActiveContext = MyBase.ActiveContext
			_usrBanDepositos.ActiveContext = MyBase.ActiveContext
			_usrBanDepositos_.ActiveContext = MyBase.ActiveContext
			_polizaDetalle.ActiveContext = MyBase.ActiveContext
			_usrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaCabFacturas.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaCabFacturas_.ActiveContext = MyBase.ActiveContext
			_metodoCabCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_beneficiarioCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_beneficiarioCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque__.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque___.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaUsrBanDepositos.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaUsrBanDepositos_.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaPolizaDetalle.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaUsrCxppagosProveedores.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PolizaDAO = CType(CreateDAOInstance(), PolizaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PolizaDAO = CType(CreateDAOInstance(), PolizaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PolizaDAO = CType(CreateDAOInstance(), PolizaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PolizaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PolizaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <param name="validator">The validator Object for this PolizaEntity</param>
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
			_cabFacturas = New Integralab.ORM.CollectionClasses.CabFacturasCollection(New CabFacturasEntityFactory())
			_cabFacturas.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchCabFacturas = False
			_alreadyFetchedCabFacturas = False
			_cabFacturas_ = New Integralab.ORM.CollectionClasses.CabFacturasCollection(New CabFacturasEntityFactory())
			_cabFacturas_.SetContainingEntityInfo(Me, "Poliza_")
			_alwaysFetchCabFacturas_ = False
			_alreadyFetchedCabFacturas_ = False
			_facturasClientesCab = New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(New FacturasClientesCabEntityFactory())
			_facturasClientesCab.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchFacturasClientesCab = False
			_alreadyFetchedFacturasClientesCab = False
			_gastosDepartamentos = New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(New GastosDepartamentosEntityFactory())
			_gastosDepartamentos.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchGastosDepartamentos = False
			_alreadyFetchedGastosDepartamentos = False
			_mvtosBancariosCb = New Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection(New MvtosBancariosCbEntityFactory())
			_mvtosBancariosCb.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchMvtosBancariosCb = False
			_alreadyFetchedMvtosBancariosCb = False
			_pagoDeCtes = New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(New PagoDeCtesEntityFactory())
			_pagoDeCtes.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchPagoDeCtes = False
			_alreadyFetchedPagoDeCtes = False
			_pagoDeCtes_ = New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(New PagoDeCtesEntityFactory())
			_pagoDeCtes_.SetContainingEntityInfo(Me, "Poliza_")
			_alwaysFetchPagoDeCtes_ = False
			_alreadyFetchedPagoDeCtes_ = False
			_salidaGanadoCab = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_salidaGanadoCab.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_cheque = New Integralab.ORM.CollectionClasses.ChequeCollection(New ChequeEntityFactory())
			_cheque.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchCheque = False
			_alreadyFetchedCheque = False
			_cheque_ = New Integralab.ORM.CollectionClasses.ChequeCollection(New ChequeEntityFactory())
			_cheque_.SetContainingEntityInfo(Me, "Poliza_")
			_alwaysFetchCheque_ = False
			_alreadyFetchedCheque_ = False
			_usrBanDepositos = New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(New UsrBanDepositosEntityFactory())
			_usrBanDepositos.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchUsrBanDepositos = False
			_alreadyFetchedUsrBanDepositos = False
			_usrBanDepositos_ = New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(New UsrBanDepositosEntityFactory())
			_usrBanDepositos_.SetContainingEntityInfo(Me, "Poliza_")
			_alwaysFetchUsrBanDepositos_ = False
			_alreadyFetchedUsrBanDepositos_ = False
			_polizaDetalle = New Integralab.ORM.CollectionClasses.PolizaDetalleCollection(New PolizaDetalleEntityFactory())
			_polizaDetalle.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchPolizaDetalle = False
			_alreadyFetchedPolizaDetalle = False
			_usrCxppagosProveedores = New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(New UsrCxppagosProveedoresEntityFactory())
			_usrCxppagosProveedores.SetContainingEntityInfo(Me, "Poliza")
			_alwaysFetchUsrCxppagosProveedores = False
			_alreadyFetchedUsrCxppagosProveedores = False
			_salidaGanadoCabCollectionViaCabFacturas = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas = False
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas = False
			_salidaGanadoCabCollectionViaCabFacturas_ = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_ = False
			_alreadyFetchedSalidaGanadoCabCollectionViaCabFacturas_ = False
			_metodoCabCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.MetodoCabCollection(New MetodoCabEntityFactory())
			_alwaysFetchMetodoCabCollectionViaGastosDepartamentos = False
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = False
			_cuentaContableCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = False
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = False
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
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_beneficiarioCollectionViaCheque = New Integralab.ORM.CollectionClasses.BeneficiarioCollection(New BeneficiarioEntityFactory())
			_alwaysFetchBeneficiarioCollectionViaCheque = False
			_alreadyFetchedBeneficiarioCollectionViaCheque = False
			_beneficiarioCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.BeneficiarioCollection(New BeneficiarioEntityFactory())
			_alwaysFetchBeneficiarioCollectionViaCheque_ = False
			_alreadyFetchedBeneficiarioCollectionViaCheque_ = False
			_cuentaCollectionViaCheque = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque = False
			_alreadyFetchedCuentaCollectionViaCheque = False
			_cuentaCollectionViaCheque__ = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque__ = False
			_alreadyFetchedCuentaCollectionViaCheque__ = False
			_cuentaCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque_ = False
			_alreadyFetchedCuentaCollectionViaCheque_ = False
			_cuentaCollectionViaCheque___ = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque___ = False
			_alreadyFetchedCuentaCollectionViaCheque___ = False
			_cuentaCollectionViaUsrBanDepositos = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaUsrBanDepositos = False
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos = False
			_cuentaCollectionViaUsrBanDepositos_ = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaUsrBanDepositos_ = False
			_alreadyFetchedCuentaCollectionViaUsrBanDepositos_ = False
			_cuentaContableCollectionViaPolizaDetalle = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaPolizaDetalle = False
			_alreadyFetchedCuentaContableCollectionViaPolizaDetalle = False
			_cuentaCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedCuentaCollectionViaUsrCxppagosProveedores = False
			_proveedorCollectionViaUsrCxppagosProveedores = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = False
			_alreadyFetchedProveedorCollectionViaUsrCxppagosProveedores = False


			
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

			_fieldsCustomProperties.Add("EmpresaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Mes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Ano", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Concepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoError", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumeroPoliza", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Poliza which data should be fetched into this Poliza Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PolizaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePolizaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PolizaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PolizaRelations
			Get	
				Return New PolizaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabFacturas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabFacturas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabFacturasCollection(), _
					PolizaEntity.Relations.CabFacturasEntityUsingFolPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), 0, Nothing, Nothing, Nothing, "CabFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabFacturas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabFacturas_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabFacturasCollection(), _
					PolizaEntity.Relations.CabFacturasEntityUsingFolCanPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), 0, Nothing, Nothing, Nothing, "CabFacturas_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					PolizaEntity.Relations.FacturasClientesCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GastosDepartamentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathGastosDepartamentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(), _
					PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.GastosDepartamentosEntity, Integer), 0, Nothing, Nothing, Nothing, "GastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MvtosBancariosCb' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMvtosBancariosCb() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection(), _
					PolizaEntity.Relations.MvtosBancariosCbEntityUsingNumeroPol, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.MvtosBancariosCbEntity, Integer), 0, Nothing, Nothing, Nothing, "MvtosBancariosCb", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoDeCtes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoDeCtes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(), _
					PolizaEntity.Relations.PagoDeCtesEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoDeCtes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoDeCtes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoDeCtes_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(), _
					PolizaEntity.Relations.PagoDeCtesEntityUsingIdPolizaCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoDeCtes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cheque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCheque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.ChequeEntity, Integer), 0, Nothing, Nothing, Nothing, "Cheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cheque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCheque_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.ChequeEntity, Integer), 0, Nothing, Nothing, Nothing, "Cheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrBanDepositos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrBanDepositos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(), _
					PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.UsrBanDepositosEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrBanDepositos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrBanDepositos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrBanDepositos_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrBanDepositosCollection(), _
					PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.UsrBanDepositosEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrBanDepositos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PolizaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaDetalleCollection(), _
					PolizaEntity.Relations.PolizaDetalleEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.PolizaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "PolizaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxppagosProveedores' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxppagosProveedoresCollection(), _
					PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxppagosProveedoresEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaCabFacturas() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.CabFacturasEntityUsingFolPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					PolizaEntity.Relations.CabFacturasEntityUsingFolPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaCabFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaCabFacturas_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.CabFacturasEntityUsingFolCanPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					PolizaEntity.Relations.CabFacturasEntityUsingFolCanPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaCabFacturas_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MetodoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMetodoCabCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MetodoCabCollection(), _
					PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), 0, Nothing, Nothing, relations, "MetodoCabCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					PolizaEntity.Relations.GastosDepartamentosEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCausasMuerte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCausasMuerteCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCausasMuerteCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					PolizaEntity.Relations.SalidaGanadoCabEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiarioCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, relations, "BeneficiarioCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiarioCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, relations, "BeneficiarioCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque__() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque___() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.ChequeEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaUsrBanDepositos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaIdCancelacion, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.CuentaEntityUsingCuentaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaUsrBanDepositos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaUsrBanDepositos_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrBanDepositosEntity.Relations.CuentaEntityUsingCuentaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.UsrBanDepositosEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaUsrBanDepositos_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaPolizaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.PolizaDetalleEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(PolizaDetalleEntity.Relations.CuentaContableEntityUsingCuentaContableId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					PolizaEntity.Relations.PolizaDetalleEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaPolizaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.CuentaEntityUsingCuentaBancariaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaUsrCxppagosProveedores() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, "__PolizaEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxppagosProveedoresEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					PolizaEntity.Relations.UsrCxppagosProveedoresEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.PolizaEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaUsrCxppagosProveedores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PolizaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PolizaEntity.CustomProperties
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
				Return PolizaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The EmpresaId property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."EmpresaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EmpresaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.EmpresaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.EmpresaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoPoliza property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."TipoPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.TipoPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.TipoPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Mes property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Mes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Mes]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Mes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Mes, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ano property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Ano"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Ano]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Ano, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Ano, Integer), value)
			End Set
		End Property
	
		''' <summary>The Folio property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaPoliza property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."FechaPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaPoliza]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.FechaPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.FechaPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Concepto property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Concepto"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Concepto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Concepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Concepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Origen property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Origen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Origen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Origen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Origen, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoError property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."TipoError"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoError]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.TipoError, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.TipoError, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.Referencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCambio property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."TipoCambio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCambio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.TipoCambio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.TipoCambio, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumeroPoliza property of the Entity Poliza<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContPolizas"."NumeroPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumeroPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PolizaFieldIndex.NumeroPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PolizaFieldIndex.NumeroPoliza, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabFacturas]() As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Get
				Return GetMultiCabFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabFacturas. When set to true, CabFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabFacturas As Boolean
			Get
				Return _alwaysFetchCabFacturas
			End Get
			Set
				_alwaysFetchCabFacturas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabFacturas_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabFacturas_]() As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Get
				Return GetMultiCabFacturas_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabFacturas_. When set to true, CabFacturas_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabFacturas_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabFacturas_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabFacturas_ As Boolean
			Get
				Return _alwaysFetchCabFacturas_
			End Get
			Set
				_alwaysFetchCabFacturas_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesCab]() As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Get
				Return GetMultiFacturasClientesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCab. When set to true, FacturasClientesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCab As Boolean
			Get
				Return _alwaysFetchFacturasClientesCab
			End Get
			Set
				_alwaysFetchFacturasClientesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [GastosDepartamentos]() As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Get
				Return GetMultiGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for GastosDepartamentos. When set to true, GastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time GastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchGastosDepartamentos
			End Get
			Set
				_alwaysFetchGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MvtosBancariosCbEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMvtosBancariosCb()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MvtosBancariosCb]() As Integralab.ORM.CollectionClasses.MvtosBancariosCbCollection
			Get
				Return GetMultiMvtosBancariosCb(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MvtosBancariosCb. When set to true, MvtosBancariosCb is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MvtosBancariosCb is accessed. You can always execute
		''' a forced fetch by calling GetMultiMvtosBancariosCb(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMvtosBancariosCb As Boolean
			Get
				Return _alwaysFetchMvtosBancariosCb
			End Get
			Set
				_alwaysFetchMvtosBancariosCb = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoDeCtes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoDeCtes]() As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Get
				Return GetMultiPagoDeCtes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoDeCtes. When set to true, PagoDeCtes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoDeCtes is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoDeCtes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoDeCtes As Boolean
			Get
				Return _alwaysFetchPagoDeCtes
			End Get
			Set
				_alwaysFetchPagoDeCtes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoDeCtes_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoDeCtes_]() As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Get
				Return GetMultiPagoDeCtes_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoDeCtes_. When set to true, PagoDeCtes_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoDeCtes_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoDeCtes_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoDeCtes_ As Boolean
			Get
				Return _alwaysFetchPagoDeCtes_
			End Get
			Set
				_alwaysFetchPagoDeCtes_ = value
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
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cheque]() As Integralab.ORM.CollectionClasses.ChequeCollection
			Get
				Return GetMultiCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cheque. When set to true, Cheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCheque As Boolean
			Get
				Return _alwaysFetchCheque
			End Get
			Set
				_alwaysFetchCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cheque_]() As Integralab.ORM.CollectionClasses.ChequeCollection
			Get
				Return GetMultiCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cheque_. When set to true, Cheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCheque_ As Boolean
			Get
				Return _alwaysFetchCheque_
			End Get
			Set
				_alwaysFetchCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrBanDepositos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrBanDepositos]() As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Get
				Return GetMultiUsrBanDepositos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrBanDepositos. When set to true, UsrBanDepositos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrBanDepositos is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrBanDepositos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrBanDepositos As Boolean
			Get
				Return _alwaysFetchUsrBanDepositos
			End Get
			Set
				_alwaysFetchUsrBanDepositos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrBanDepositosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrBanDepositos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrBanDepositos_]() As Integralab.ORM.CollectionClasses.UsrBanDepositosCollection
			Get
				Return GetMultiUsrBanDepositos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrBanDepositos_. When set to true, UsrBanDepositos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrBanDepositos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrBanDepositos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrBanDepositos_ As Boolean
			Get
				Return _alwaysFetchUsrBanDepositos_
			End Get
			Set
				_alwaysFetchUsrBanDepositos_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaDetalle]() As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
			Get
				Return GetMultiPolizaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaDetalle. When set to true, PolizaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaDetalle As Boolean
			Get
				Return _alwaysFetchPolizaDetalle
			End Get
			Set
				_alwaysFetchPolizaDetalle = value
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
	
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCabCollectionViaCabFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCabCollectionViaCabFacturas]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCabCollectionViaCabFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCabCollectionViaCabFacturas. When set to true, SalidaGanadoCabCollectionViaCabFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCabCollectionViaCabFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCabCollectionViaCabFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCabCollectionViaCabFacturas As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas
			End Get
			Set
				_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCabCollectionViaCabFacturas_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCabCollectionViaCabFacturas_]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCabCollectionViaCabFacturas_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCabCollectionViaCabFacturas_. When set to true, SalidaGanadoCabCollectionViaCabFacturas_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCabCollectionViaCabFacturas_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCabCollectionViaCabFacturas_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCabCollectionViaCabFacturas_ As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_
			End Get
			Set
				_alwaysFetchSalidaGanadoCabCollectionViaCabFacturas_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMetodoCabCollectionViaGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MetodoCabCollectionViaGastosDepartamentos]() As Integralab.ORM.CollectionClasses.MetodoCabCollection
			Get
				Return GetMultiMetodoCabCollectionViaGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MetodoCabCollectionViaGastosDepartamentos. When set to true, MetodoCabCollectionViaGastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MetodoCabCollectionViaGastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMetodoCabCollectionViaGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMetodoCabCollectionViaGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchMetodoCabCollectionViaGastosDepartamentos
			End Get
			Set
				_alwaysFetchMetodoCabCollectionViaGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaGastosDepartamentos]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaGastosDepartamentos. When set to true, CuentaContableCollectionViaGastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaGastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaGastosDepartamentos
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = value
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
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBeneficiarioCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BeneficiarioCollectionViaCheque]() As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Get
				Return GetMultiBeneficiarioCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BeneficiarioCollectionViaCheque. When set to true, BeneficiarioCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BeneficiarioCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiBeneficiarioCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiarioCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchBeneficiarioCollectionViaCheque
			End Get
			Set
				_alwaysFetchBeneficiarioCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'BeneficiarioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBeneficiarioCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BeneficiarioCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.BeneficiarioCollection
			Get
				Return GetMultiBeneficiarioCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BeneficiarioCollectionViaCheque_. When set to true, BeneficiarioCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BeneficiarioCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiBeneficiarioCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiarioCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchBeneficiarioCollectionViaCheque_
			End Get
			Set
				_alwaysFetchBeneficiarioCollectionViaCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque. When set to true, CuentaCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque__]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque__. When set to true, CuentaCollectionViaCheque__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque__ As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque__
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque_. When set to true, CuentaCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque_
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque___()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque___]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque___(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque___. When set to true, CuentaCollectionViaCheque___ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque___ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque___(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque___ As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque___
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque___ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaUsrBanDepositos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaUsrBanDepositos]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaUsrBanDepositos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaUsrBanDepositos. When set to true, CuentaCollectionViaUsrBanDepositos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaUsrBanDepositos is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaUsrBanDepositos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaUsrBanDepositos As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaUsrBanDepositos
			End Get
			Set
				_alwaysFetchCuentaCollectionViaUsrBanDepositos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaUsrBanDepositos_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaUsrBanDepositos_]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaUsrBanDepositos_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaUsrBanDepositos_. When set to true, CuentaCollectionViaUsrBanDepositos_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaUsrBanDepositos_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaUsrBanDepositos_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaUsrBanDepositos_ As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaUsrBanDepositos_
			End Get
			Set
				_alwaysFetchCuentaCollectionViaUsrBanDepositos_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaPolizaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaPolizaDetalle]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaPolizaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaPolizaDetalle. When set to true, CuentaContableCollectionViaPolizaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaPolizaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaPolizaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaPolizaDetalle As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaPolizaDetalle
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaPolizaDetalle = value
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaUsrCxppagosProveedores()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaUsrCxppagosProveedores]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaUsrCxppagosProveedores(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaUsrCxppagosProveedores. When set to true, ProveedorCollectionViaUsrCxppagosProveedores is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaUsrCxppagosProveedores is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaUsrCxppagosProveedores(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaUsrCxppagosProveedores As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaUsrCxppagosProveedores
			End Get
			Set
				_alwaysFetchProveedorCollectionViaUsrCxppagosProveedores = value
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
				Return CInt(Integralab.ORM.EntityType.PolizaEntity)
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
