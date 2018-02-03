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
	''' <summary>Entity class which represents the entity 'CuentaContable'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CuentaContableEntity 
#Else
	<Serializable()> _
	Public Class CuentaContableEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _acumuladoCuentasContables As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
		Private _alwaysFetchAcumuladoCuentasContables, _alreadyFetchedAcumuladoCuentasContables As Boolean
		Private _catTipNotas As Integralab.ORM.CollectionClasses.CatTipNotasCollection
		Private _alwaysFetchCatTipNotas, _alreadyFetchedCatTipNotas As Boolean
		Private _cfgCtrlCtas As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
		Private _alwaysFetchCfgCtrlCtas, _alreadyFetchedCfgCtrlCtas As Boolean
		Private _detBalance As Integralab.ORM.CollectionClasses.DetBalanceCollection
		Private _alwaysFetchDetBalance, _alreadyFetchedDetBalance As Boolean
		Private _detEdoRes As Integralab.ORM.CollectionClasses.DetEdoResCollection
		Private _alwaysFetchDetEdoRes, _alreadyFetchedDetEdoRes As Boolean
		Private _gastosDepartamentos As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
		Private _alwaysFetchGastosDepartamentos, _alreadyFetchedGastosDepartamentos As Boolean
		Private _almacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen As Boolean
		Private _mcatCentroCostosAlmacen As Integralab.ORM.CollectionClasses.McatCentroCostosCollection
		Private _alwaysFetchMcatCentroCostosAlmacen, _alreadyFetchedMcatCentroCostosAlmacen As Boolean
		Private _comicionista As Integralab.ORM.CollectionClasses.ComicionistaCollection
		Private _alwaysFetchComicionista, _alreadyFetchedComicionista As Boolean
		Private _proveedor As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor As Boolean
		Private _proveedor_ As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedor_, _alreadyFetchedProveedor_ As Boolean
		Private _mcgcatCompradoresdeGanado As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanado, _alreadyFetchedMcgcatCompradoresdeGanado As Boolean
		Private _cliente As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
		Private _alwaysFetchCliente, _alreadyFetchedCliente As Boolean
		Private _cliente_ As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
		Private _alwaysFetchCliente_, _alreadyFetchedCliente_ As Boolean
		Private _msccatProductos As Integralab.ORM.CollectionClasses.MsccatProductosCollection
		Private _alwaysFetchMsccatProductos, _alreadyFetchedMsccatProductos As Boolean
		Private _polizasModeloDet As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
		Private _alwaysFetchPolizasModeloDet, _alreadyFetchedPolizasModeloDet As Boolean
		Private _cuenta As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuenta, _alreadyFetchedCuenta As Boolean
		Private _usrConConceptosFlujoCuentas As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
		Private _alwaysFetchUsrConConceptosFlujoCuentas, _alreadyFetchedUsrConConceptosFlujoCuentas As Boolean
		Private _cuentaContable As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable As Boolean
		Private _cuentaContable_ As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContable_, _alreadyFetchedCuentaContable_ As Boolean
		Private _cuentasHijas As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentasHijas, _alreadyFetchedCuentasHijas As Boolean
		Private _polizaDetalle As Integralab.ORM.CollectionClasses.PolizaDetalleCollection
		Private _alwaysFetchPolizaDetalle, _alreadyFetchedPolizaDetalle As Boolean
		Private _usrCxpfacturasDet As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
		Private _alwaysFetchUsrCxpfacturasDet, _alreadyFetchedUsrCxpfacturasDet As Boolean
		Private _periodosContCollectionViaAcumuladoCuentasContables As Integralab.ORM.CollectionClasses.PeriodosContCollection
		Private _alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables, _alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables As Boolean
		Private _cabBalanceCollectionViaDetBalance As Integralab.ORM.CollectionClasses.CabBalanceCollection
		Private _alwaysFetchCabBalanceCollectionViaDetBalance, _alreadyFetchedCabBalanceCollectionViaDetBalance As Boolean
		Private _cabEdoResCollectionViaDetEdoRes As Integralab.ORM.CollectionClasses.CabEdoResCollection
		Private _alwaysFetchCabEdoResCollectionViaDetEdoRes, _alreadyFetchedCabEdoResCollectionViaDetEdoRes As Boolean
		Private _metodoCabCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.MetodoCabCollection
		Private _alwaysFetchMetodoCabCollectionViaGastosDepartamentos, _alreadyFetchedMetodoCabCollectionViaGastosDepartamentos As Boolean
		Private _polizaCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaGastosDepartamentos, _alreadyFetchedPolizaCollectionViaGastosDepartamentos As Boolean
		Private _plazaCollectionViaAlmacen As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaAlmacen, _alreadyFetchedPlazaCollectionViaAlmacen As Boolean
		Private _almacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaAlmacen, _alreadyFetchedAlmacenCollectionViaAlmacen As Boolean
		Private _tipoAlmacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.TipoAlmacenCollection
		Private _alwaysFetchTipoAlmacenCollectionViaAlmacen, _alreadyFetchedTipoAlmacenCollectionViaAlmacen As Boolean
		Private _plazaCollectionViaMcatCentroCostosAlmacen As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen, _alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen As Boolean
		Private _tipoComicionistaCollectionViaComicionista As Integralab.ORM.CollectionClasses.TipoComicionistaCollection
		Private _alwaysFetchTipoComicionistaCollectionViaComicionista, _alreadyFetchedTipoComicionistaCollectionViaComicionista As Boolean
		Private _plazaCollectionViaComicionista As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaComicionista, _alreadyFetchedPlazaCollectionViaComicionista As Boolean
		Private _catLugaresDeCompraCollectionViaProveedor As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaProveedor, _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor As Boolean
		Private _catLugaresDeCompraCollectionViaProveedor_ As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaProveedor_, _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ As Boolean
		Private _contDiotTiposOperacionCollectionViaProveedor As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
		Private _alwaysFetchContDiotTiposOperacionCollectionViaProveedor, _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor As Boolean
		Private _contDiotTiposOperacionCollectionViaProveedor_ As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
		Private _alwaysFetchContDiotTiposOperacionCollectionViaProveedor_, _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ As Boolean
		Private _contDiotTiposTercerosCollectionViaProveedor As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
		Private _alwaysFetchContDiotTiposTercerosCollectionViaProveedor, _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor As Boolean
		Private _contDiotTiposTercerosCollectionViaProveedor_ As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
		Private _alwaysFetchContDiotTiposTercerosCollectionViaProveedor_, _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ As Boolean
		Private _comicionistaCollectionViaMfacCatClientes As Integralab.ORM.CollectionClasses.ComicionistaCollection
		Private _alwaysFetchComicionistaCollectionViaMfacCatClientes, _alreadyFetchedComicionistaCollectionViaMfacCatClientes As Boolean
		Private _comicionistaCollectionViaMfacCatClientes_ As Integralab.ORM.CollectionClasses.ComicionistaCollection
		Private _alwaysFetchComicionistaCollectionViaMfacCatClientes_, _alreadyFetchedComicionistaCollectionViaMfacCatClientes_ As Boolean
		Private _polizasModeloCabCollectionViaPolizasModeloDet As Integralab.ORM.CollectionClasses.PolizasModeloCabCollection
		Private _alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet, _alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet As Boolean
		Private _tipoMonedaCollectionViaCuenta As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaCuenta, _alreadyFetchedTipoMonedaCollectionViaCuenta As Boolean
		Private _bancosCollectionViaCuenta As Integralab.ORM.CollectionClasses.BancosCollection
		Private _alwaysFetchBancosCollectionViaCuenta, _alreadyFetchedBancosCollectionViaCuenta As Boolean
		Private _usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas As Integralab.ORM.CollectionClasses.ConceptoFlujoCollection
		Private _alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas, _alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas As Boolean
		Private _polizaCollectionViaPolizaDetalle As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaPolizaDetalle, _alreadyFetchedPolizaCollectionViaPolizaDetalle As Boolean
		Private _usrCxpfacturasCabCollectionViaUsrCxpfacturasDet As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
		Private _alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet, _alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet As Boolean
		Private _cuentaEntrada As CuentaContableEntity
		Private _alwaysFetchCuentaEntrada, _alreadyFetchedCuentaEntrada, _cuentaEntradaReturnsNewIfNotFound As Boolean
		Private _cuentaSalida As CuentaContableEntity
		Private _alwaysFetchCuentaSalida, _alreadyFetchedCuentaSalida, _cuentaSalidaReturnsNewIfNotFound As Boolean
		Private _cuentaPadre As CuentaContableEntity
		Private _alwaysFetchCuentaPadre, _alreadyFetchedCuentaPadre, _cuentaPadreReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <param name="validator">The custom validator Object for this CuentaContableEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_acumuladoCuentasContables = CType(info.GetValue("_acumuladoCuentasContables", GetType(Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection)), Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection)
			_alwaysFetchAcumuladoCuentasContables = info.GetBoolean("_alwaysFetchAcumuladoCuentasContables")
			_alreadyFetchedAcumuladoCuentasContables = info.GetBoolean("_alreadyFetchedAcumuladoCuentasContables")
			_catTipNotas = CType(info.GetValue("_catTipNotas", GetType(Integralab.ORM.CollectionClasses.CatTipNotasCollection)), Integralab.ORM.CollectionClasses.CatTipNotasCollection)
			_alwaysFetchCatTipNotas = info.GetBoolean("_alwaysFetchCatTipNotas")
			_alreadyFetchedCatTipNotas = info.GetBoolean("_alreadyFetchedCatTipNotas")
			_cfgCtrlCtas = CType(info.GetValue("_cfgCtrlCtas", GetType(Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection)), Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection)
			_alwaysFetchCfgCtrlCtas = info.GetBoolean("_alwaysFetchCfgCtrlCtas")
			_alreadyFetchedCfgCtrlCtas = info.GetBoolean("_alreadyFetchedCfgCtrlCtas")
			_detBalance = CType(info.GetValue("_detBalance", GetType(Integralab.ORM.CollectionClasses.DetBalanceCollection)), Integralab.ORM.CollectionClasses.DetBalanceCollection)
			_alwaysFetchDetBalance = info.GetBoolean("_alwaysFetchDetBalance")
			_alreadyFetchedDetBalance = info.GetBoolean("_alreadyFetchedDetBalance")
			_detEdoRes = CType(info.GetValue("_detEdoRes", GetType(Integralab.ORM.CollectionClasses.DetEdoResCollection)), Integralab.ORM.CollectionClasses.DetEdoResCollection)
			_alwaysFetchDetEdoRes = info.GetBoolean("_alwaysFetchDetEdoRes")
			_alreadyFetchedDetEdoRes = info.GetBoolean("_alreadyFetchedDetEdoRes")
			_gastosDepartamentos = CType(info.GetValue("_gastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)), Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)
			_alwaysFetchGastosDepartamentos = info.GetBoolean("_alwaysFetchGastosDepartamentos")
			_alreadyFetchedGastosDepartamentos = info.GetBoolean("_alreadyFetchedGastosDepartamentos")
			_almacen = CType(info.GetValue("_almacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_mcatCentroCostosAlmacen = CType(info.GetValue("_mcatCentroCostosAlmacen", GetType(Integralab.ORM.CollectionClasses.McatCentroCostosCollection)), Integralab.ORM.CollectionClasses.McatCentroCostosCollection)
			_alwaysFetchMcatCentroCostosAlmacen = info.GetBoolean("_alwaysFetchMcatCentroCostosAlmacen")
			_alreadyFetchedMcatCentroCostosAlmacen = info.GetBoolean("_alreadyFetchedMcatCentroCostosAlmacen")
			_comicionista = CType(info.GetValue("_comicionista", GetType(Integralab.ORM.CollectionClasses.ComicionistaCollection)), Integralab.ORM.CollectionClasses.ComicionistaCollection)
			_alwaysFetchComicionista = info.GetBoolean("_alwaysFetchComicionista")
			_alreadyFetchedComicionista = info.GetBoolean("_alreadyFetchedComicionista")
			_proveedor = CType(info.GetValue("_proveedor", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_proveedor_ = CType(info.GetValue("_proveedor_", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedor_ = info.GetBoolean("_alwaysFetchProveedor_")
			_alreadyFetchedProveedor_ = info.GetBoolean("_alreadyFetchedProveedor_")
			_mcgcatCompradoresdeGanado = CType(info.GetValue("_mcgcatCompradoresdeGanado", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanado = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanado")
			_alreadyFetchedMcgcatCompradoresdeGanado = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanado")
			_cliente = CType(info.GetValue("_cliente", GetType(Integralab.ORM.CollectionClasses.MfacCatClientesCollection)), Integralab.ORM.CollectionClasses.MfacCatClientesCollection)
			_alwaysFetchCliente = info.GetBoolean("_alwaysFetchCliente")
			_alreadyFetchedCliente = info.GetBoolean("_alreadyFetchedCliente")
			_cliente_ = CType(info.GetValue("_cliente_", GetType(Integralab.ORM.CollectionClasses.MfacCatClientesCollection)), Integralab.ORM.CollectionClasses.MfacCatClientesCollection)
			_alwaysFetchCliente_ = info.GetBoolean("_alwaysFetchCliente_")
			_alreadyFetchedCliente_ = info.GetBoolean("_alreadyFetchedCliente_")
			_msccatProductos = CType(info.GetValue("_msccatProductos", GetType(Integralab.ORM.CollectionClasses.MsccatProductosCollection)), Integralab.ORM.CollectionClasses.MsccatProductosCollection)
			_alwaysFetchMsccatProductos = info.GetBoolean("_alwaysFetchMsccatProductos")
			_alreadyFetchedMsccatProductos = info.GetBoolean("_alreadyFetchedMsccatProductos")
			_polizasModeloDet = CType(info.GetValue("_polizasModeloDet", GetType(Integralab.ORM.CollectionClasses.PolizasModeloDetCollection)), Integralab.ORM.CollectionClasses.PolizasModeloDetCollection)
			_alwaysFetchPolizasModeloDet = info.GetBoolean("_alwaysFetchPolizasModeloDet")
			_alreadyFetchedPolizasModeloDet = info.GetBoolean("_alreadyFetchedPolizasModeloDet")
			_cuenta = CType(info.GetValue("_cuenta", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuenta = info.GetBoolean("_alwaysFetchCuenta")
			_alreadyFetchedCuenta = info.GetBoolean("_alreadyFetchedCuenta")
			_usrConConceptosFlujoCuentas = CType(info.GetValue("_usrConConceptosFlujoCuentas", GetType(Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection)), Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection)
			_alwaysFetchUsrConConceptosFlujoCuentas = info.GetBoolean("_alwaysFetchUsrConConceptosFlujoCuentas")
			_alreadyFetchedUsrConConceptosFlujoCuentas = info.GetBoolean("_alreadyFetchedUsrConConceptosFlujoCuentas")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_cuentaContable_ = CType(info.GetValue("_cuentaContable_", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContable_ = info.GetBoolean("_alwaysFetchCuentaContable_")
			_alreadyFetchedCuentaContable_ = info.GetBoolean("_alreadyFetchedCuentaContable_")
			_cuentasHijas = CType(info.GetValue("_cuentasHijas", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentasHijas = info.GetBoolean("_alwaysFetchCuentasHijas")
			_alreadyFetchedCuentasHijas = info.GetBoolean("_alreadyFetchedCuentasHijas")
			_polizaDetalle = CType(info.GetValue("_polizaDetalle", GetType(Integralab.ORM.CollectionClasses.PolizaDetalleCollection)), Integralab.ORM.CollectionClasses.PolizaDetalleCollection)
			_alwaysFetchPolizaDetalle = info.GetBoolean("_alwaysFetchPolizaDetalle")
			_alreadyFetchedPolizaDetalle = info.GetBoolean("_alreadyFetchedPolizaDetalle")
			_usrCxpfacturasDet = CType(info.GetValue("_usrCxpfacturasDet", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection)
			_alwaysFetchUsrCxpfacturasDet = info.GetBoolean("_alwaysFetchUsrCxpfacturasDet")
			_alreadyFetchedUsrCxpfacturasDet = info.GetBoolean("_alreadyFetchedUsrCxpfacturasDet")
			_periodosContCollectionViaAcumuladoCuentasContables = CType(info.GetValue("_periodosContCollectionViaAcumuladoCuentasContables", GetType(Integralab.ORM.CollectionClasses.PeriodosContCollection)), Integralab.ORM.CollectionClasses.PeriodosContCollection)
			_alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables = info.GetBoolean("_alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables")
			_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables = info.GetBoolean("_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables")
			_cabBalanceCollectionViaDetBalance = CType(info.GetValue("_cabBalanceCollectionViaDetBalance", GetType(Integralab.ORM.CollectionClasses.CabBalanceCollection)), Integralab.ORM.CollectionClasses.CabBalanceCollection)
			_alwaysFetchCabBalanceCollectionViaDetBalance = info.GetBoolean("_alwaysFetchCabBalanceCollectionViaDetBalance")
			_alreadyFetchedCabBalanceCollectionViaDetBalance = info.GetBoolean("_alreadyFetchedCabBalanceCollectionViaDetBalance")
			_cabEdoResCollectionViaDetEdoRes = CType(info.GetValue("_cabEdoResCollectionViaDetEdoRes", GetType(Integralab.ORM.CollectionClasses.CabEdoResCollection)), Integralab.ORM.CollectionClasses.CabEdoResCollection)
			_alwaysFetchCabEdoResCollectionViaDetEdoRes = info.GetBoolean("_alwaysFetchCabEdoResCollectionViaDetEdoRes")
			_alreadyFetchedCabEdoResCollectionViaDetEdoRes = info.GetBoolean("_alreadyFetchedCabEdoResCollectionViaDetEdoRes")
			_metodoCabCollectionViaGastosDepartamentos = CType(info.GetValue("_metodoCabCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.MetodoCabCollection)), Integralab.ORM.CollectionClasses.MetodoCabCollection)
			_alwaysFetchMetodoCabCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchMetodoCabCollectionViaGastosDepartamentos")
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos")
			_polizaCollectionViaGastosDepartamentos = CType(info.GetValue("_polizaCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchPolizaCollectionViaGastosDepartamentos")
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedPolizaCollectionViaGastosDepartamentos")
			_plazaCollectionViaAlmacen = CType(info.GetValue("_plazaCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaAlmacen = info.GetBoolean("_alwaysFetchPlazaCollectionViaAlmacen")
			_alreadyFetchedPlazaCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedPlazaCollectionViaAlmacen")
			_almacenCollectionViaAlmacen = CType(info.GetValue("_almacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchAlmacenCollectionViaAlmacen")
			_alreadyFetchedAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaAlmacen")
			_tipoAlmacenCollectionViaAlmacen = CType(info.GetValue("_tipoAlmacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.TipoAlmacenCollection)), Integralab.ORM.CollectionClasses.TipoAlmacenCollection)
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchTipoAlmacenCollectionViaAlmacen")
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedTipoAlmacenCollectionViaAlmacen")
			_plazaCollectionViaMcatCentroCostosAlmacen = CType(info.GetValue("_plazaCollectionViaMcatCentroCostosAlmacen", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen = info.GetBoolean("_alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen")
			_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen = info.GetBoolean("_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen")
			_tipoComicionistaCollectionViaComicionista = CType(info.GetValue("_tipoComicionistaCollectionViaComicionista", GetType(Integralab.ORM.CollectionClasses.TipoComicionistaCollection)), Integralab.ORM.CollectionClasses.TipoComicionistaCollection)
			_alwaysFetchTipoComicionistaCollectionViaComicionista = info.GetBoolean("_alwaysFetchTipoComicionistaCollectionViaComicionista")
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = info.GetBoolean("_alreadyFetchedTipoComicionistaCollectionViaComicionista")
			_plazaCollectionViaComicionista = CType(info.GetValue("_plazaCollectionViaComicionista", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaComicionista = info.GetBoolean("_alwaysFetchPlazaCollectionViaComicionista")
			_alreadyFetchedPlazaCollectionViaComicionista = info.GetBoolean("_alreadyFetchedPlazaCollectionViaComicionista")
			_catLugaresDeCompraCollectionViaProveedor = CType(info.GetValue("_catLugaresDeCompraCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor")
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor")
			_catLugaresDeCompraCollectionViaProveedor_ = CType(info.GetValue("_catLugaresDeCompraCollectionViaProveedor_", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor_ = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor_")
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_")
			_contDiotTiposOperacionCollectionViaProveedor = CType(info.GetValue("_contDiotTiposOperacionCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor")
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor")
			_contDiotTiposOperacionCollectionViaProveedor_ = CType(info.GetValue("_contDiotTiposOperacionCollectionViaProveedor_", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor_ = info.GetBoolean("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor_")
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ = info.GetBoolean("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_")
			_contDiotTiposTercerosCollectionViaProveedor = CType(info.GetValue("_contDiotTiposTercerosCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = info.GetBoolean("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor")
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = info.GetBoolean("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor")
			_contDiotTiposTercerosCollectionViaProveedor_ = CType(info.GetValue("_contDiotTiposTercerosCollectionViaProveedor_", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection)
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor_ = info.GetBoolean("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor_")
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ = info.GetBoolean("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_")
			_comicionistaCollectionViaMfacCatClientes = CType(info.GetValue("_comicionistaCollectionViaMfacCatClientes", GetType(Integralab.ORM.CollectionClasses.ComicionistaCollection)), Integralab.ORM.CollectionClasses.ComicionistaCollection)
			_alwaysFetchComicionistaCollectionViaMfacCatClientes = info.GetBoolean("_alwaysFetchComicionistaCollectionViaMfacCatClientes")
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes = info.GetBoolean("_alreadyFetchedComicionistaCollectionViaMfacCatClientes")
			_comicionistaCollectionViaMfacCatClientes_ = CType(info.GetValue("_comicionistaCollectionViaMfacCatClientes_", GetType(Integralab.ORM.CollectionClasses.ComicionistaCollection)), Integralab.ORM.CollectionClasses.ComicionistaCollection)
			_alwaysFetchComicionistaCollectionViaMfacCatClientes_ = info.GetBoolean("_alwaysFetchComicionistaCollectionViaMfacCatClientes_")
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes_ = info.GetBoolean("_alreadyFetchedComicionistaCollectionViaMfacCatClientes_")
			_polizasModeloCabCollectionViaPolizasModeloDet = CType(info.GetValue("_polizasModeloCabCollectionViaPolizasModeloDet", GetType(Integralab.ORM.CollectionClasses.PolizasModeloCabCollection)), Integralab.ORM.CollectionClasses.PolizasModeloCabCollection)
			_alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet = info.GetBoolean("_alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet")
			_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet = info.GetBoolean("_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet")
			_tipoMonedaCollectionViaCuenta = CType(info.GetValue("_tipoMonedaCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaCuenta = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaCuenta")
			_alreadyFetchedTipoMonedaCollectionViaCuenta = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaCuenta")
			_bancosCollectionViaCuenta = CType(info.GetValue("_bancosCollectionViaCuenta", GetType(Integralab.ORM.CollectionClasses.BancosCollection)), Integralab.ORM.CollectionClasses.BancosCollection)
			_alwaysFetchBancosCollectionViaCuenta = info.GetBoolean("_alwaysFetchBancosCollectionViaCuenta")
			_alreadyFetchedBancosCollectionViaCuenta = info.GetBoolean("_alreadyFetchedBancosCollectionViaCuenta")
			_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = CType(info.GetValue("_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas", GetType(Integralab.ORM.CollectionClasses.ConceptoFlujoCollection)), Integralab.ORM.CollectionClasses.ConceptoFlujoCollection)
			_alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = info.GetBoolean("_alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas")
			_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = info.GetBoolean("_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas")
			_polizaCollectionViaPolizaDetalle = CType(info.GetValue("_polizaCollectionViaPolizaDetalle", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaPolizaDetalle = info.GetBoolean("_alwaysFetchPolizaCollectionViaPolizaDetalle")
			_alreadyFetchedPolizaCollectionViaPolizaDetalle = info.GetBoolean("_alreadyFetchedPolizaCollectionViaPolizaDetalle")
			_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet = CType(info.GetValue("_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection)
			_alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = info.GetBoolean("_alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet")
			_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = info.GetBoolean("_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet")
			_cuentaEntrada = CType(info.GetValue("_cuentaEntrada", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaEntrada Is Nothing Then
				AddHandler _cuentaEntrada.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaEntradaReturnsNewIfNotFound = info.GetBoolean("_cuentaEntradaReturnsNewIfNotFound")
			_alwaysFetchCuentaEntrada = info.GetBoolean("_alwaysFetchCuentaEntrada")
			_alreadyFetchedCuentaEntrada = info.GetBoolean("_alreadyFetchedCuentaEntrada")
			_cuentaSalida = CType(info.GetValue("_cuentaSalida", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaSalida Is Nothing Then
				AddHandler _cuentaSalida.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaSalidaReturnsNewIfNotFound = info.GetBoolean("_cuentaSalidaReturnsNewIfNotFound")
			_alwaysFetchCuentaSalida = info.GetBoolean("_alwaysFetchCuentaSalida")
			_alreadyFetchedCuentaSalida = info.GetBoolean("_alreadyFetchedCuentaSalida")
			_cuentaPadre = CType(info.GetValue("_cuentaPadre", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaPadre Is Nothing Then
				AddHandler _cuentaPadre.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaPadreReturnsNewIfNotFound = info.GetBoolean("_cuentaPadreReturnsNewIfNotFound")
			_alwaysFetchCuentaPadre = info.GetBoolean("_alwaysFetchCuentaPadre")
			_alreadyFetchedCuentaPadre = info.GetBoolean("_alreadyFetchedCuentaPadre")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAcumuladoCuentasContables = (_acumuladoCuentasContables.Count > 0)
			_alreadyFetchedCatTipNotas = (_catTipNotas.Count > 0)
			_alreadyFetchedCfgCtrlCtas = (_cfgCtrlCtas.Count > 0)
			_alreadyFetchedDetBalance = (_detBalance.Count > 0)
			_alreadyFetchedDetEdoRes = (_detEdoRes.Count > 0)
			_alreadyFetchedGastosDepartamentos = (_gastosDepartamentos.Count > 0)
			_alreadyFetchedAlmacen = (_almacen.Count > 0)
			_alreadyFetchedMcatCentroCostosAlmacen = (_mcatCentroCostosAlmacen.Count > 0)
			_alreadyFetchedComicionista = (_comicionista.Count > 0)
			_alreadyFetchedProveedor = (_proveedor.Count > 0)
			_alreadyFetchedProveedor_ = (_proveedor_.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanado = (_mcgcatCompradoresdeGanado.Count > 0)
			_alreadyFetchedCliente = (_cliente.Count > 0)
			_alreadyFetchedCliente_ = (_cliente_.Count > 0)
			_alreadyFetchedMsccatProductos = (_msccatProductos.Count > 0)
			_alreadyFetchedPolizasModeloDet = (_polizasModeloDet.Count > 0)
			_alreadyFetchedCuenta = (_cuenta.Count > 0)
			_alreadyFetchedUsrConConceptosFlujoCuentas = (_usrConConceptosFlujoCuentas.Count > 0)
			_alreadyFetchedCuentaContable = (_cuentaContable.Count > 0)
			_alreadyFetchedCuentaContable_ = (_cuentaContable_.Count > 0)
			_alreadyFetchedCuentasHijas = (_cuentasHijas.Count > 0)
			_alreadyFetchedPolizaDetalle = (_polizaDetalle.Count > 0)
			_alreadyFetchedUsrCxpfacturasDet = (_usrCxpfacturasDet.Count > 0)
			_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables = (_periodosContCollectionViaAcumuladoCuentasContables.Count > 0)
			_alreadyFetchedCabBalanceCollectionViaDetBalance = (_cabBalanceCollectionViaDetBalance.Count > 0)
			_alreadyFetchedCabEdoResCollectionViaDetEdoRes = (_cabEdoResCollectionViaDetEdoRes.Count > 0)
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = (_metodoCabCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = (_polizaCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedPlazaCollectionViaAlmacen = (_plazaCollectionViaAlmacen.Count > 0)
			_alreadyFetchedAlmacenCollectionViaAlmacen = (_almacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = (_tipoAlmacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen = (_plazaCollectionViaMcatCentroCostosAlmacen.Count > 0)
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = (_tipoComicionistaCollectionViaComicionista.Count > 0)
			_alreadyFetchedPlazaCollectionViaComicionista = (_plazaCollectionViaComicionista.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = (_catLugaresDeCompraCollectionViaProveedor.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ = (_catLugaresDeCompraCollectionViaProveedor_.Count > 0)
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = (_contDiotTiposOperacionCollectionViaProveedor.Count > 0)
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ = (_contDiotTiposOperacionCollectionViaProveedor_.Count > 0)
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = (_contDiotTiposTercerosCollectionViaProveedor.Count > 0)
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ = (_contDiotTiposTercerosCollectionViaProveedor_.Count > 0)
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes = (_comicionistaCollectionViaMfacCatClientes.Count > 0)
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes_ = (_comicionistaCollectionViaMfacCatClientes_.Count > 0)
			_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet = (_polizasModeloCabCollectionViaPolizasModeloDet.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaCuenta = (_tipoMonedaCollectionViaCuenta.Count > 0)
			_alreadyFetchedBancosCollectionViaCuenta = (_bancosCollectionViaCuenta.Count > 0)
			_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = (_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.Count > 0)
			_alreadyFetchedPolizaCollectionViaPolizaDetalle = (_polizaCollectionViaPolizaDetalle.Count > 0)
			_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = (_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.Count > 0)
			_alreadyFetchedCuentaEntrada = Not(_cuentaEntrada Is Nothing)
			_alreadyFetchedCuentaSalida = Not(_cuentaSalida Is Nothing)
			_alreadyFetchedCuentaPadre = Not(_cuentaPadre Is Nothing)

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
			info.AddValue("_acumuladoCuentasContables", _acumuladoCuentasContables)
			info.AddValue("_alwaysFetchAcumuladoCuentasContables", _alwaysFetchAcumuladoCuentasContables)
			info.AddValue("_alreadyFetchedAcumuladoCuentasContables", _alreadyFetchedAcumuladoCuentasContables)
			info.AddValue("_catTipNotas", _catTipNotas)
			info.AddValue("_alwaysFetchCatTipNotas", _alwaysFetchCatTipNotas)
			info.AddValue("_alreadyFetchedCatTipNotas", _alreadyFetchedCatTipNotas)
			info.AddValue("_cfgCtrlCtas", _cfgCtrlCtas)
			info.AddValue("_alwaysFetchCfgCtrlCtas", _alwaysFetchCfgCtrlCtas)
			info.AddValue("_alreadyFetchedCfgCtrlCtas", _alreadyFetchedCfgCtrlCtas)
			info.AddValue("_detBalance", _detBalance)
			info.AddValue("_alwaysFetchDetBalance", _alwaysFetchDetBalance)
			info.AddValue("_alreadyFetchedDetBalance", _alreadyFetchedDetBalance)
			info.AddValue("_detEdoRes", _detEdoRes)
			info.AddValue("_alwaysFetchDetEdoRes", _alwaysFetchDetEdoRes)
			info.AddValue("_alreadyFetchedDetEdoRes", _alreadyFetchedDetEdoRes)
			info.AddValue("_gastosDepartamentos", _gastosDepartamentos)
			info.AddValue("_alwaysFetchGastosDepartamentos", _alwaysFetchGastosDepartamentos)
			info.AddValue("_alreadyFetchedGastosDepartamentos", _alreadyFetchedGastosDepartamentos)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_mcatCentroCostosAlmacen", _mcatCentroCostosAlmacen)
			info.AddValue("_alwaysFetchMcatCentroCostosAlmacen", _alwaysFetchMcatCentroCostosAlmacen)
			info.AddValue("_alreadyFetchedMcatCentroCostosAlmacen", _alreadyFetchedMcatCentroCostosAlmacen)
			info.AddValue("_comicionista", _comicionista)
			info.AddValue("_alwaysFetchComicionista", _alwaysFetchComicionista)
			info.AddValue("_alreadyFetchedComicionista", _alreadyFetchedComicionista)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_proveedor_", _proveedor_)
			info.AddValue("_alwaysFetchProveedor_", _alwaysFetchProveedor_)
			info.AddValue("_alreadyFetchedProveedor_", _alreadyFetchedProveedor_)
			info.AddValue("_mcgcatCompradoresdeGanado", _mcgcatCompradoresdeGanado)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanado", _alwaysFetchMcgcatCompradoresdeGanado)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanado", _alreadyFetchedMcgcatCompradoresdeGanado)
			info.AddValue("_cliente", _cliente)
			info.AddValue("_alwaysFetchCliente", _alwaysFetchCliente)
			info.AddValue("_alreadyFetchedCliente", _alreadyFetchedCliente)
			info.AddValue("_cliente_", _cliente_)
			info.AddValue("_alwaysFetchCliente_", _alwaysFetchCliente_)
			info.AddValue("_alreadyFetchedCliente_", _alreadyFetchedCliente_)
			info.AddValue("_msccatProductos", _msccatProductos)
			info.AddValue("_alwaysFetchMsccatProductos", _alwaysFetchMsccatProductos)
			info.AddValue("_alreadyFetchedMsccatProductos", _alreadyFetchedMsccatProductos)
			info.AddValue("_polizasModeloDet", _polizasModeloDet)
			info.AddValue("_alwaysFetchPolizasModeloDet", _alwaysFetchPolizasModeloDet)
			info.AddValue("_alreadyFetchedPolizasModeloDet", _alreadyFetchedPolizasModeloDet)
			info.AddValue("_cuenta", _cuenta)
			info.AddValue("_alwaysFetchCuenta", _alwaysFetchCuenta)
			info.AddValue("_alreadyFetchedCuenta", _alreadyFetchedCuenta)
			info.AddValue("_usrConConceptosFlujoCuentas", _usrConConceptosFlujoCuentas)
			info.AddValue("_alwaysFetchUsrConConceptosFlujoCuentas", _alwaysFetchUsrConConceptosFlujoCuentas)
			info.AddValue("_alreadyFetchedUsrConConceptosFlujoCuentas", _alreadyFetchedUsrConConceptosFlujoCuentas)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_cuentaContable_", _cuentaContable_)
			info.AddValue("_alwaysFetchCuentaContable_", _alwaysFetchCuentaContable_)
			info.AddValue("_alreadyFetchedCuentaContable_", _alreadyFetchedCuentaContable_)
			info.AddValue("_cuentasHijas", _cuentasHijas)
			info.AddValue("_alwaysFetchCuentasHijas", _alwaysFetchCuentasHijas)
			info.AddValue("_alreadyFetchedCuentasHijas", _alreadyFetchedCuentasHijas)
			info.AddValue("_polizaDetalle", _polizaDetalle)
			info.AddValue("_alwaysFetchPolizaDetalle", _alwaysFetchPolizaDetalle)
			info.AddValue("_alreadyFetchedPolizaDetalle", _alreadyFetchedPolizaDetalle)
			info.AddValue("_usrCxpfacturasDet", _usrCxpfacturasDet)
			info.AddValue("_alwaysFetchUsrCxpfacturasDet", _alwaysFetchUsrCxpfacturasDet)
			info.AddValue("_alreadyFetchedUsrCxpfacturasDet", _alreadyFetchedUsrCxpfacturasDet)
			info.AddValue("_periodosContCollectionViaAcumuladoCuentasContables", _periodosContCollectionViaAcumuladoCuentasContables)
			info.AddValue("_alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables", _alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables)
			info.AddValue("_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables", _alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables)
			info.AddValue("_cabBalanceCollectionViaDetBalance", _cabBalanceCollectionViaDetBalance)
			info.AddValue("_alwaysFetchCabBalanceCollectionViaDetBalance", _alwaysFetchCabBalanceCollectionViaDetBalance)
			info.AddValue("_alreadyFetchedCabBalanceCollectionViaDetBalance", _alreadyFetchedCabBalanceCollectionViaDetBalance)
			info.AddValue("_cabEdoResCollectionViaDetEdoRes", _cabEdoResCollectionViaDetEdoRes)
			info.AddValue("_alwaysFetchCabEdoResCollectionViaDetEdoRes", _alwaysFetchCabEdoResCollectionViaDetEdoRes)
			info.AddValue("_alreadyFetchedCabEdoResCollectionViaDetEdoRes", _alreadyFetchedCabEdoResCollectionViaDetEdoRes)
			info.AddValue("_metodoCabCollectionViaGastosDepartamentos", _metodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchMetodoCabCollectionViaGastosDepartamentos", _alwaysFetchMetodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos", _alreadyFetchedMetodoCabCollectionViaGastosDepartamentos)
			info.AddValue("_polizaCollectionViaGastosDepartamentos", _polizaCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchPolizaCollectionViaGastosDepartamentos", _alwaysFetchPolizaCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedPolizaCollectionViaGastosDepartamentos", _alreadyFetchedPolizaCollectionViaGastosDepartamentos)
			info.AddValue("_plazaCollectionViaAlmacen", _plazaCollectionViaAlmacen)
			info.AddValue("_alwaysFetchPlazaCollectionViaAlmacen", _alwaysFetchPlazaCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedPlazaCollectionViaAlmacen", _alreadyFetchedPlazaCollectionViaAlmacen)
			info.AddValue("_almacenCollectionViaAlmacen", _almacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchAlmacenCollectionViaAlmacen", _alwaysFetchAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaAlmacen", _alreadyFetchedAlmacenCollectionViaAlmacen)
			info.AddValue("_tipoAlmacenCollectionViaAlmacen", _tipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchTipoAlmacenCollectionViaAlmacen", _alwaysFetchTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedTipoAlmacenCollectionViaAlmacen", _alreadyFetchedTipoAlmacenCollectionViaAlmacen)
			info.AddValue("_plazaCollectionViaMcatCentroCostosAlmacen", _plazaCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen", _alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen", _alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen)
			info.AddValue("_tipoComicionistaCollectionViaComicionista", _tipoComicionistaCollectionViaComicionista)
			info.AddValue("_alwaysFetchTipoComicionistaCollectionViaComicionista", _alwaysFetchTipoComicionistaCollectionViaComicionista)
			info.AddValue("_alreadyFetchedTipoComicionistaCollectionViaComicionista", _alreadyFetchedTipoComicionistaCollectionViaComicionista)
			info.AddValue("_plazaCollectionViaComicionista", _plazaCollectionViaComicionista)
			info.AddValue("_alwaysFetchPlazaCollectionViaComicionista", _alwaysFetchPlazaCollectionViaComicionista)
			info.AddValue("_alreadyFetchedPlazaCollectionViaComicionista", _alreadyFetchedPlazaCollectionViaComicionista)
			info.AddValue("_catLugaresDeCompraCollectionViaProveedor", _catLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor", _alwaysFetchCatLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor", _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_catLugaresDeCompraCollectionViaProveedor_", _catLugaresDeCompraCollectionViaProveedor_)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor_", _alwaysFetchCatLugaresDeCompraCollectionViaProveedor_)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_", _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_)
			info.AddValue("_contDiotTiposOperacionCollectionViaProveedor", _contDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor", _alwaysFetchContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor", _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_contDiotTiposOperacionCollectionViaProveedor_", _contDiotTiposOperacionCollectionViaProveedor_)
			info.AddValue("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor_", _alwaysFetchContDiotTiposOperacionCollectionViaProveedor_)
			info.AddValue("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_", _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_)
			info.AddValue("_contDiotTiposTercerosCollectionViaProveedor", _contDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor", _alwaysFetchContDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor", _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor)
			info.AddValue("_contDiotTiposTercerosCollectionViaProveedor_", _contDiotTiposTercerosCollectionViaProveedor_)
			info.AddValue("_alwaysFetchContDiotTiposTercerosCollectionViaProveedor_", _alwaysFetchContDiotTiposTercerosCollectionViaProveedor_)
			info.AddValue("_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_", _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_)
			info.AddValue("_comicionistaCollectionViaMfacCatClientes", _comicionistaCollectionViaMfacCatClientes)
			info.AddValue("_alwaysFetchComicionistaCollectionViaMfacCatClientes", _alwaysFetchComicionistaCollectionViaMfacCatClientes)
			info.AddValue("_alreadyFetchedComicionistaCollectionViaMfacCatClientes", _alreadyFetchedComicionistaCollectionViaMfacCatClientes)
			info.AddValue("_comicionistaCollectionViaMfacCatClientes_", _comicionistaCollectionViaMfacCatClientes_)
			info.AddValue("_alwaysFetchComicionistaCollectionViaMfacCatClientes_", _alwaysFetchComicionistaCollectionViaMfacCatClientes_)
			info.AddValue("_alreadyFetchedComicionistaCollectionViaMfacCatClientes_", _alreadyFetchedComicionistaCollectionViaMfacCatClientes_)
			info.AddValue("_polizasModeloCabCollectionViaPolizasModeloDet", _polizasModeloCabCollectionViaPolizasModeloDet)
			info.AddValue("_alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet", _alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet)
			info.AddValue("_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet", _alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet)
			info.AddValue("_tipoMonedaCollectionViaCuenta", _tipoMonedaCollectionViaCuenta)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaCuenta", _alwaysFetchTipoMonedaCollectionViaCuenta)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaCuenta", _alreadyFetchedTipoMonedaCollectionViaCuenta)
			info.AddValue("_bancosCollectionViaCuenta", _bancosCollectionViaCuenta)
			info.AddValue("_alwaysFetchBancosCollectionViaCuenta", _alwaysFetchBancosCollectionViaCuenta)
			info.AddValue("_alreadyFetchedBancosCollectionViaCuenta", _alreadyFetchedBancosCollectionViaCuenta)
			info.AddValue("_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas", _usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas)
			info.AddValue("_alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas", _alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas)
			info.AddValue("_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas", _alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas)
			info.AddValue("_polizaCollectionViaPolizaDetalle", _polizaCollectionViaPolizaDetalle)
			info.AddValue("_alwaysFetchPolizaCollectionViaPolizaDetalle", _alwaysFetchPolizaCollectionViaPolizaDetalle)
			info.AddValue("_alreadyFetchedPolizaCollectionViaPolizaDetalle", _alreadyFetchedPolizaCollectionViaPolizaDetalle)
			info.AddValue("_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet", _usrCxpfacturasCabCollectionViaUsrCxpfacturasDet)
			info.AddValue("_alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet", _alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet)
			info.AddValue("_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet", _alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet)
			info.AddValue("_cuentaEntrada", _cuentaEntrada)
			info.AddValue("_cuentaEntradaReturnsNewIfNotFound", _cuentaEntradaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaEntrada", _alwaysFetchCuentaEntrada)
			info.AddValue("_alreadyFetchedCuentaEntrada", _alreadyFetchedCuentaEntrada)
			info.AddValue("_cuentaSalida", _cuentaSalida)
			info.AddValue("_cuentaSalidaReturnsNewIfNotFound", _cuentaSalidaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaSalida", _alwaysFetchCuentaSalida)
			info.AddValue("_alreadyFetchedCuentaSalida", _alreadyFetchedCuentaSalida)
			info.AddValue("_cuentaPadre", _cuentaPadre)
			info.AddValue("_cuentaPadreReturnsNewIfNotFound", _cuentaPadreReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaPadre", _alwaysFetchCuentaPadre)
			info.AddValue("_alreadyFetchedCuentaPadre", _alreadyFetchedCuentaPadre)

			
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
				Case "CuentaEntrada"
					_alreadyFetchedCuentaEntrada = True
					Me.CuentaEntrada = CType(entity, CuentaContableEntity)
				Case "CuentaSalida"
					_alreadyFetchedCuentaSalida = True
					Me.CuentaSalida = CType(entity, CuentaContableEntity)
				Case "CuentaPadre"
					_alreadyFetchedCuentaPadre = True
					Me.CuentaPadre = CType(entity, CuentaContableEntity)
				Case "AcumuladoCuentasContables"
					_alreadyFetchedAcumuladoCuentasContables = True
					If Not entity Is Nothing Then
						Me.AcumuladoCuentasContables.Add(CType(entity, AcumuladoCuentasContablesEntity))
					End If
				Case "CatTipNotas"
					_alreadyFetchedCatTipNotas = True
					If Not entity Is Nothing Then
						Me.CatTipNotas.Add(CType(entity, CatTipNotasEntity))
					End If
				Case "CfgCtrlCtas"
					_alreadyFetchedCfgCtrlCtas = True
					If Not entity Is Nothing Then
						Me.CfgCtrlCtas.Add(CType(entity, CfgCtrlCtasEntity))
					End If
				Case "DetBalance"
					_alreadyFetchedDetBalance = True
					If Not entity Is Nothing Then
						Me.DetBalance.Add(CType(entity, DetBalanceEntity))
					End If
				Case "DetEdoRes"
					_alreadyFetchedDetEdoRes = True
					If Not entity Is Nothing Then
						Me.DetEdoRes.Add(CType(entity, DetEdoResEntity))
					End If
				Case "GastosDepartamentos"
					_alreadyFetchedGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.GastosDepartamentos.Add(CType(entity, GastosDepartamentosEntity))
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
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					If Not entity Is Nothing Then
						Me.Proveedor.Add(CType(entity, ProveedorEntity))
					End If
				Case "Proveedor_"
					_alreadyFetchedProveedor_ = True
					If Not entity Is Nothing Then
						Me.Proveedor_.Add(CType(entity, ProveedorEntity))
					End If
				Case "McgcatCompradoresdeGanado"
					_alreadyFetchedMcgcatCompradoresdeGanado = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanado.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
					End If
				Case "Cliente"
					_alreadyFetchedCliente = True
					If Not entity Is Nothing Then
						Me.Cliente.Add(CType(entity, MfacCatClientesEntity))
					End If
				Case "Cliente_"
					_alreadyFetchedCliente_ = True
					If Not entity Is Nothing Then
						Me.Cliente_.Add(CType(entity, MfacCatClientesEntity))
					End If
				Case "MsccatProductos"
					_alreadyFetchedMsccatProductos = True
					If Not entity Is Nothing Then
						Me.MsccatProductos.Add(CType(entity, MsccatProductosEntity))
					End If
				Case "PolizasModeloDet"
					_alreadyFetchedPolizasModeloDet = True
					If Not entity Is Nothing Then
						Me.PolizasModeloDet.Add(CType(entity, PolizasModeloDetEntity))
					End If
				Case "Cuenta"
					_alreadyFetchedCuenta = True
					If Not entity Is Nothing Then
						Me.Cuenta.Add(CType(entity, CuentaEntity))
					End If
				Case "UsrConConceptosFlujoCuentas"
					_alreadyFetchedUsrConConceptosFlujoCuentas = True
					If Not entity Is Nothing Then
						Me.UsrConConceptosFlujoCuentas.Add(CType(entity, ConceptoFlujoCuentaEntity))
					End If
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					If Not entity Is Nothing Then
						Me.CuentaContable.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaContable_"
					_alreadyFetchedCuentaContable_ = True
					If Not entity Is Nothing Then
						Me.CuentaContable_.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentasHijas"
					_alreadyFetchedCuentasHijas = True
					If Not entity Is Nothing Then
						Me.CuentasHijas.Add(CType(entity, CuentaContableEntity))
					End If
				Case "PolizaDetalle"
					_alreadyFetchedPolizaDetalle = True
					If Not entity Is Nothing Then
						Me.PolizaDetalle.Add(CType(entity, PolizaDetalleEntity))
					End If
				Case "UsrCxpfacturasDet"
					_alreadyFetchedUsrCxpfacturasDet = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasDet.Add(CType(entity, UsrCxpfacturasDetEntity))
					End If
				Case "PeriodosContCollectionViaAcumuladoCuentasContables"
					_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables = True
					If Not entity Is Nothing Then
						Me.PeriodosContCollectionViaAcumuladoCuentasContables.Add(CType(entity, PeriodosContEntity))
					End If
				Case "CabBalanceCollectionViaDetBalance"
					_alreadyFetchedCabBalanceCollectionViaDetBalance = True
					If Not entity Is Nothing Then
						Me.CabBalanceCollectionViaDetBalance.Add(CType(entity, CabBalanceEntity))
					End If
				Case "CabEdoResCollectionViaDetEdoRes"
					_alreadyFetchedCabEdoResCollectionViaDetEdoRes = True
					If Not entity Is Nothing Then
						Me.CabEdoResCollectionViaDetEdoRes.Add(CType(entity, CabEdoResEntity))
					End If
				Case "MetodoCabCollectionViaGastosDepartamentos"
					_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.MetodoCabCollectionViaGastosDepartamentos.Add(CType(entity, MetodoCabEntity))
					End If
				Case "PolizaCollectionViaGastosDepartamentos"
					_alreadyFetchedPolizaCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaGastosDepartamentos.Add(CType(entity, PolizaEntity))
					End If
				Case "PlazaCollectionViaAlmacen"
					_alreadyFetchedPlazaCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaAlmacen.Add(CType(entity, PlazaEntity))
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
				Case "PlazaCollectionViaMcatCentroCostosAlmacen"
					_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaMcatCentroCostosAlmacen.Add(CType(entity, PlazaEntity))
					End If
				Case "TipoComicionistaCollectionViaComicionista"
					_alreadyFetchedTipoComicionistaCollectionViaComicionista = True
					If Not entity Is Nothing Then
						Me.TipoComicionistaCollectionViaComicionista.Add(CType(entity, TipoComicionistaEntity))
					End If
				Case "PlazaCollectionViaComicionista"
					_alreadyFetchedPlazaCollectionViaComicionista = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaComicionista.Add(CType(entity, PlazaEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaProveedor"
					_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaProveedor.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaProveedor_"
					_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaProveedor_.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "ContDiotTiposOperacionCollectionViaProveedor"
					_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposOperacionCollectionViaProveedor.Add(CType(entity, ContDiotTiposOperacionEntity))
					End If
				Case "ContDiotTiposOperacionCollectionViaProveedor_"
					_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposOperacionCollectionViaProveedor_.Add(CType(entity, ContDiotTiposOperacionEntity))
					End If
				Case "ContDiotTiposTercerosCollectionViaProveedor"
					_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposTercerosCollectionViaProveedor.Add(CType(entity, ContDiotTiposTercerosEntity))
					End If
				Case "ContDiotTiposTercerosCollectionViaProveedor_"
					_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposTercerosCollectionViaProveedor_.Add(CType(entity, ContDiotTiposTercerosEntity))
					End If
				Case "ComicionistaCollectionViaMfacCatClientes"
					_alreadyFetchedComicionistaCollectionViaMfacCatClientes = True
					If Not entity Is Nothing Then
						Me.ComicionistaCollectionViaMfacCatClientes.Add(CType(entity, ComicionistaEntity))
					End If
				Case "ComicionistaCollectionViaMfacCatClientes_"
					_alreadyFetchedComicionistaCollectionViaMfacCatClientes_ = True
					If Not entity Is Nothing Then
						Me.ComicionistaCollectionViaMfacCatClientes_.Add(CType(entity, ComicionistaEntity))
					End If
				Case "PolizasModeloCabCollectionViaPolizasModeloDet"
					_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet = True
					If Not entity Is Nothing Then
						Me.PolizasModeloCabCollectionViaPolizasModeloDet.Add(CType(entity, PolizasModeloCabEntity))
					End If
				Case "TipoMonedaCollectionViaCuenta"
					_alreadyFetchedTipoMonedaCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaCuenta.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "BancosCollectionViaCuenta"
					_alreadyFetchedBancosCollectionViaCuenta = True
					If Not entity Is Nothing Then
						Me.BancosCollectionViaCuenta.Add(CType(entity, BancosEntity))
					End If
				Case "UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas"
					_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = True
					If Not entity Is Nothing Then
						Me.UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.Add(CType(entity, ConceptoFlujoEntity))
					End If
				Case "PolizaCollectionViaPolizaDetalle"
					_alreadyFetchedPolizaCollectionViaPolizaDetalle = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaPolizaDetalle.Add(CType(entity, PolizaEntity))
					End If
				Case "UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet"
					_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet.Add(CType(entity, UsrCxpfacturasCabEntity))
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
				Case "CuentaEntrada"
					SetupSyncCuentaEntrada(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaSalida"
					SetupSyncCuentaSalida(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaPadre"
					SetupSyncCuentaPadre(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AcumuladoCuentasContables"
					_acumuladoCuentasContables.Add(CType(relatedEntity, AcumuladoCuentasContablesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CatTipNotas"
					_catTipNotas.Add(CType(relatedEntity, CatTipNotasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CfgCtrlCtas"
					_cfgCtrlCtas.Add(CType(relatedEntity, CfgCtrlCtasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetBalance"
					_detBalance.Add(CType(relatedEntity, DetBalanceEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetEdoRes"
					_detEdoRes.Add(CType(relatedEntity, DetEdoResEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					_gastosDepartamentos.Add(CType(relatedEntity, GastosDepartamentosEntity))
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
				Case "Proveedor"
					_proveedor.Add(CType(relatedEntity, ProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Proveedor_"
					_proveedor_.Add(CType(relatedEntity, ProveedorEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcatCompradoresdeGanado"
					_mcgcatCompradoresdeGanado.Add(CType(relatedEntity, McgcatCompradoresdeGanadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cliente"
					_cliente.Add(CType(relatedEntity, MfacCatClientesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cliente_"
					_cliente_.Add(CType(relatedEntity, MfacCatClientesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductos"
					_msccatProductos.Add(CType(relatedEntity, MsccatProductosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PolizasModeloDet"
					_polizasModeloDet.Add(CType(relatedEntity, PolizasModeloDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cuenta"
					_cuenta.Add(CType(relatedEntity, CuentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrConConceptosFlujoCuentas"
					_usrConConceptosFlujoCuentas.Add(CType(relatedEntity, ConceptoFlujoCuentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					_cuentaContable.Add(CType(relatedEntity, CuentaContableEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable_"
					_cuentaContable_.Add(CType(relatedEntity, CuentaContableEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentasHijas"
					_cuentasHijas.Add(CType(relatedEntity, CuentaContableEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PolizaDetalle"
					_polizaDetalle.Add(CType(relatedEntity, PolizaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxpfacturasDet"
					_usrCxpfacturasDet.Add(CType(relatedEntity, UsrCxpfacturasDetEntity))
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
				Case "CuentaEntrada"
					DesetupSyncCuentaEntrada(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaSalida"
					DesetupSyncCuentaSalida(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaPadre"
					DesetupSyncCuentaPadre(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AcumuladoCuentasContables"
					MyBase.PerformRelatedEntityRemoval(_acumuladoCuentasContables, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CatTipNotas"
					MyBase.PerformRelatedEntityRemoval(_catTipNotas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CfgCtrlCtas"
					MyBase.PerformRelatedEntityRemoval(_cfgCtrlCtas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetBalance"
					MyBase.PerformRelatedEntityRemoval(_detBalance, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetEdoRes"
					MyBase.PerformRelatedEntityRemoval(_detEdoRes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					MyBase.PerformRelatedEntityRemoval(_gastosDepartamentos, relatedEntity, signalRelatedEntityManyToOne)
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
				Case "Proveedor"
					MyBase.PerformRelatedEntityRemoval(_proveedor, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Proveedor_"
					MyBase.PerformRelatedEntityRemoval(_proveedor_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcatCompradoresdeGanado"
					MyBase.PerformRelatedEntityRemoval(_mcgcatCompradoresdeGanado, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cliente"
					MyBase.PerformRelatedEntityRemoval(_cliente, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cliente_"
					MyBase.PerformRelatedEntityRemoval(_cliente_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductos"
					MyBase.PerformRelatedEntityRemoval(_msccatProductos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PolizasModeloDet"
					MyBase.PerformRelatedEntityRemoval(_polizasModeloDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cuenta"
					MyBase.PerformRelatedEntityRemoval(_cuenta, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrConConceptosFlujoCuentas"
					MyBase.PerformRelatedEntityRemoval(_usrConConceptosFlujoCuentas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					MyBase.PerformRelatedEntityRemoval(_cuentaContable, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable_"
					MyBase.PerformRelatedEntityRemoval(_cuentaContable_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentasHijas"
					MyBase.PerformRelatedEntityRemoval(_cuentasHijas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PolizaDetalle"
					MyBase.PerformRelatedEntityRemoval(_polizaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxpfacturasDet"
					MyBase.PerformRelatedEntityRemoval(_usrCxpfacturasDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _cuentaEntrada Is Nothing Then
				toReturn.Add(_cuentaEntrada)
			End If
			If Not _cuentaSalida Is Nothing Then
				toReturn.Add(_cuentaSalida)
			End If
			If Not _cuentaPadre Is Nothing Then
				toReturn.Add(_cuentaPadre)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_acumuladoCuentasContables)
			toReturn.Add(_catTipNotas)
			toReturn.Add(_cfgCtrlCtas)
			toReturn.Add(_detBalance)
			toReturn.Add(_detEdoRes)
			toReturn.Add(_gastosDepartamentos)
			toReturn.Add(_almacen)
			toReturn.Add(_mcatCentroCostosAlmacen)
			toReturn.Add(_comicionista)
			toReturn.Add(_proveedor)
			toReturn.Add(_proveedor_)
			toReturn.Add(_mcgcatCompradoresdeGanado)
			toReturn.Add(_cliente)
			toReturn.Add(_cliente_)
			toReturn.Add(_msccatProductos)
			toReturn.Add(_polizasModeloDet)
			toReturn.Add(_cuenta)
			toReturn.Add(_usrConConceptosFlujoCuentas)
			toReturn.Add(_cuentaContable)
			toReturn.Add(_cuentaContable_)
			toReturn.Add(_cuentasHijas)
			toReturn.Add(_polizaDetalle)
			toReturn.Add(_usrCxpfacturasDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CuentaContableFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CuentaContableFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'AcumuladoCuentasContablesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AcumuladoCuentasContablesEntity'</returns>
		Public Function GetMultiAcumuladoCuentasContables(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
			Return GetMultiAcumuladoCuentasContables(forceFetch, _acumuladoCuentasContables.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AcumuladoCuentasContablesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAcumuladoCuentasContables(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
			Return GetMultiAcumuladoCuentasContables(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AcumuladoCuentasContablesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AcumuladoCuentasContablesEntity'</returns>
		Public Function GetMultiAcumuladoCuentasContables(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
			Return GetMultiAcumuladoCuentasContables(forceFetch, _acumuladoCuentasContables.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AcumuladoCuentasContablesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAcumuladoCuentasContables(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
			If ( Not _alreadyFetchedAcumuladoCuentasContables Or forceFetch Or _alwaysFetchAcumuladoCuentasContables) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _acumuladoCuentasContables.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_acumuladoCuentasContables)
					End If
				End If
				_acumuladoCuentasContables.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_acumuladoCuentasContables.EntityFactoryToUse = entityFactoryToUse
				End If
				_acumuladoCuentasContables.GetMultiManyToOne(Me, Nothing, Filter)
				_acumuladoCuentasContables.SuppressClearInGetMulti = False
				_alreadyFetchedAcumuladoCuentasContables = True
			End If
			Return _acumuladoCuentasContables
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AcumuladoCuentasContables'. These settings will be taken into account
		''' when the property AcumuladoCuentasContables is requested or GetMultiAcumuladoCuentasContables is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAcumuladoCuentasContables(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_acumuladoCuentasContables.SortClauses=sortClauses
			_acumuladoCuentasContables.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CatTipNotasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatTipNotasEntity'</returns>
		Public Function GetMultiCatTipNotas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatTipNotasCollection
			Return GetMultiCatTipNotas(forceFetch, _catTipNotas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CatTipNotasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCatTipNotas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatTipNotasCollection
			Return GetMultiCatTipNotas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CatTipNotasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CatTipNotasEntity'</returns>
		Public Function GetMultiCatTipNotas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CatTipNotasCollection
			Return GetMultiCatTipNotas(forceFetch, _catTipNotas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CatTipNotasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatTipNotas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CatTipNotasCollection
			If ( Not _alreadyFetchedCatTipNotas Or forceFetch Or _alwaysFetchCatTipNotas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catTipNotas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catTipNotas)
					End If
				End If
				_catTipNotas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catTipNotas.EntityFactoryToUse = entityFactoryToUse
				End If
				_catTipNotas.GetMultiManyToOne(Me, Filter)
				_catTipNotas.SuppressClearInGetMulti = False
				_alreadyFetchedCatTipNotas = True
			End If
			Return _catTipNotas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatTipNotas'. These settings will be taken into account
		''' when the property CatTipNotas is requested or GetMultiCatTipNotas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatTipNotas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catTipNotas.SortClauses=sortClauses
			_catTipNotas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CfgCtrlCtasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CfgCtrlCtasEntity'</returns>
		Public Function GetMultiCfgCtrlCtas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
			Return GetMultiCfgCtrlCtas(forceFetch, _cfgCtrlCtas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CfgCtrlCtasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCfgCtrlCtas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
			Return GetMultiCfgCtrlCtas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CfgCtrlCtasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CfgCtrlCtasEntity'</returns>
		Public Function GetMultiCfgCtrlCtas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
			Return GetMultiCfgCtrlCtas(forceFetch, _cfgCtrlCtas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CfgCtrlCtasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCfgCtrlCtas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
			If ( Not _alreadyFetchedCfgCtrlCtas Or forceFetch Or _alwaysFetchCfgCtrlCtas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cfgCtrlCtas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cfgCtrlCtas)
					End If
				End If
				_cfgCtrlCtas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cfgCtrlCtas.EntityFactoryToUse = entityFactoryToUse
				End If
				_cfgCtrlCtas.GetMultiManyToOne(Me, Filter)
				_cfgCtrlCtas.SuppressClearInGetMulti = False
				_alreadyFetchedCfgCtrlCtas = True
			End If
			Return _cfgCtrlCtas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CfgCtrlCtas'. These settings will be taken into account
		''' when the property CfgCtrlCtas is requested or GetMultiCfgCtrlCtas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCfgCtrlCtas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cfgCtrlCtas.SortClauses=sortClauses
			_cfgCtrlCtas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetBalanceEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetBalanceEntity'</returns>
		Public Function GetMultiDetBalance(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetBalanceCollection
			Return GetMultiDetBalance(forceFetch, _detBalance.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetBalanceEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetBalance(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetBalanceCollection
			Return GetMultiDetBalance(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetBalanceEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetBalanceEntity'</returns>
		Public Function GetMultiDetBalance(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetBalanceCollection
			Return GetMultiDetBalance(forceFetch, _detBalance.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetBalanceEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetBalance(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetBalanceCollection
			If ( Not _alreadyFetchedDetBalance Or forceFetch Or _alwaysFetchDetBalance) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detBalance.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detBalance)
					End If
				End If
				_detBalance.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detBalance.EntityFactoryToUse = entityFactoryToUse
				End If
				_detBalance.GetMultiManyToOne(Nothing, Me, Filter)
				_detBalance.SuppressClearInGetMulti = False
				_alreadyFetchedDetBalance = True
			End If
			Return _detBalance
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetBalance'. These settings will be taken into account
		''' when the property DetBalance is requested or GetMultiDetBalance is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetBalance(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detBalance.SortClauses=sortClauses
			_detBalance.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetEdoResEntity'</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, _detEdoRes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetEdoResEntity'</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, _detEdoRes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			If ( Not _alreadyFetchedDetEdoRes Or forceFetch Or _alwaysFetchDetEdoRes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detEdoRes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detEdoRes)
					End If
				End If
				_detEdoRes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detEdoRes.EntityFactoryToUse = entityFactoryToUse
				End If
				_detEdoRes.GetMultiManyToOne(Nothing, Me, Filter)
				_detEdoRes.SuppressClearInGetMulti = False
				_alreadyFetchedDetEdoRes = True
			End If
			Return _detEdoRes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetEdoRes'. These settings will be taken into account
		''' when the property DetEdoRes is requested or GetMultiDetEdoRes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetEdoRes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detEdoRes.SortClauses=sortClauses
			_detEdoRes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_gastosDepartamentos.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
				_almacen.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
				_mcatCentroCostosAlmacen.GetMultiManyToOne(Nothing, Me, Filter)
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
				_comicionista.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedor)
					End If
				End If
				_proveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedor.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_proveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProveedor = True
			End If
			Return _proveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Proveedor'. These settings will be taken into account
		''' when the property Proveedor is requested or GetMultiProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedor.SortClauses=sortClauses
			_proveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor_(forceFetch, _proveedor_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor_(forceFetch, _proveedor_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedor_ Or forceFetch Or _alwaysFetchProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedor_)
					End If
				End If
				_proveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedor_.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_proveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedProveedor_ = True
			End If
			Return _proveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Proveedor_'. These settings will be taken into account
		''' when the property Proveedor_ is requested or GetMultiProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedor_.SortClauses=sortClauses
			_proveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCompradoresdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatCompradoresdeGanado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanado(forceFetch, _mcgcatCompradoresdeGanado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcgcatCompradoresdeGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCompradoresdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatCompradoresdeGanado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanado(forceFetch, _mcgcatCompradoresdeGanado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatCompradoresdeGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatCompradoresdeGanado Or forceFetch Or _alwaysFetchMcgcatCompradoresdeGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatCompradoresdeGanado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatCompradoresdeGanado)
					End If
				End If
				_mcgcatCompradoresdeGanado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatCompradoresdeGanado.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatCompradoresdeGanado.GetMultiManyToOne(Me, Filter)
				_mcgcatCompradoresdeGanado.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatCompradoresdeGanado = True
			End If
			Return _mcgcatCompradoresdeGanado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatCompradoresdeGanado'. These settings will be taken into account
		''' when the property McgcatCompradoresdeGanado is requested or GetMultiMcgcatCompradoresdeGanado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatCompradoresdeGanado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatCompradoresdeGanado.SortClauses=sortClauses
			_mcgcatCompradoresdeGanado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
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
				_cliente.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiCliente_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente_(forceFetch, _cliente_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCliente_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiCliente_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiCliente_(forceFetch, _cliente_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCliente_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			If ( Not _alreadyFetchedCliente_ Or forceFetch Or _alwaysFetchCliente_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cliente_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cliente_)
					End If
				End If
				_cliente_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cliente_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cliente_.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cliente_.SuppressClearInGetMulti = False
				_alreadyFetchedCliente_ = True
			End If
			Return _cliente_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cliente_'. These settings will be taken into account
		''' when the property Cliente_ is requested or GetMultiCliente_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCliente_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cliente_.SortClauses=sortClauses
			_cliente_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosEntity'</returns>
		Public Function GetMultiMsccatProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductos(forceFetch, _msccatProductos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMsccatProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosEntity'</returns>
		Public Function GetMultiMsccatProductos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductos(forceFetch, _msccatProductos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			If ( Not _alreadyFetchedMsccatProductos Or forceFetch Or _alwaysFetchMsccatProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductos)
					End If
				End If
				_msccatProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductos.GetMultiManyToOne(Me, Filter)
				_msccatProductos.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductos = True
			End If
			Return _msccatProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductos'. These settings will be taken into account
		''' when the property MsccatProductos is requested or GetMultiMsccatProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductos.SortClauses=sortClauses
			_msccatProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PolizasModeloDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizasModeloDetEntity'</returns>
		Public Function GetMultiPolizasModeloDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
			Return GetMultiPolizasModeloDet(forceFetch, _polizasModeloDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizasModeloDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPolizasModeloDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
			Return GetMultiPolizasModeloDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizasModeloDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PolizasModeloDetEntity'</returns>
		Public Function GetMultiPolizasModeloDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
			Return GetMultiPolizasModeloDet(forceFetch, _polizasModeloDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizasModeloDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizasModeloDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
			If ( Not _alreadyFetchedPolizasModeloDet Or forceFetch Or _alwaysFetchPolizasModeloDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizasModeloDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizasModeloDet)
					End If
				End If
				_polizasModeloDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizasModeloDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizasModeloDet.GetMultiManyToOne(Nothing, Me, Filter)
				_polizasModeloDet.SuppressClearInGetMulti = False
				_alreadyFetchedPolizasModeloDet = True
			End If
			Return _polizasModeloDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizasModeloDet'. These settings will be taken into account
		''' when the property PolizasModeloDet is requested or GetMultiPolizasModeloDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizasModeloDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizasModeloDet.SortClauses=sortClauses
			_polizasModeloDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuenta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuenta(forceFetch, _cuenta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuenta Or forceFetch Or _alwaysFetchCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuenta)
					End If
				End If
				_cuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuenta.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cuenta.SuppressClearInGetMulti = False
				_alreadyFetchedCuenta = True
			End If
			Return _cuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cuenta'. These settings will be taken into account
		''' when the property Cuenta is requested or GetMultiCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuenta.SortClauses=sortClauses
			_cuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ConceptoFlujoCuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConceptoFlujoCuentaEntity'</returns>
		Public Function GetMultiUsrConConceptosFlujoCuentas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
			Return GetMultiUsrConConceptosFlujoCuentas(forceFetch, _usrConConceptosFlujoCuentas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConceptoFlujoCuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrConConceptosFlujoCuentas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
			Return GetMultiUsrConConceptosFlujoCuentas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConceptoFlujoCuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ConceptoFlujoCuentaEntity'</returns>
		Public Function GetMultiUsrConConceptosFlujoCuentas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
			Return GetMultiUsrConConceptosFlujoCuentas(forceFetch, _usrConConceptosFlujoCuentas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ConceptoFlujoCuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrConConceptosFlujoCuentas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
			If ( Not _alreadyFetchedUsrConConceptosFlujoCuentas Or forceFetch Or _alwaysFetchUsrConConceptosFlujoCuentas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrConConceptosFlujoCuentas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrConConceptosFlujoCuentas)
					End If
				End If
				_usrConConceptosFlujoCuentas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrConConceptosFlujoCuentas.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrConConceptosFlujoCuentas.GetMultiManyToOne(Nothing, Me, Filter)
				_usrConConceptosFlujoCuentas.SuppressClearInGetMulti = False
				_alreadyFetchedUsrConConceptosFlujoCuentas = True
			End If
			Return _usrConConceptosFlujoCuentas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrConConceptosFlujoCuentas'. These settings will be taken into account
		''' when the property UsrConConceptosFlujoCuentas is requested or GetMultiUsrConConceptosFlujoCuentas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrConConceptosFlujoCuentas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrConConceptosFlujoCuentas.SortClauses=sortClauses
			_usrConConceptosFlujoCuentas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContable(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable(forceFetch, _cuentaContable.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuentaContable(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContable(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable(forceFetch, _cuentaContable.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContable(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContable Or forceFetch Or _alwaysFetchCuentaContable) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContable.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContable)
					End If
				End If
				_cuentaContable.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContable.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContable.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_cuentaContable.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContable = True
			End If
			Return _cuentaContable
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContable'. These settings will be taken into account
		''' when the property CuentaContable is requested or GetMultiCuentaContable is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContable(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContable.SortClauses=sortClauses
			_cuentaContable.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContable_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable_(forceFetch, _cuentaContable_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuentaContable_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContable_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContable_(forceFetch, _cuentaContable_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContable_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContable_ Or forceFetch Or _alwaysFetchCuentaContable_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContable_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContable_)
					End If
				End If
				_cuentaContable_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContable_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContable_.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_cuentaContable_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContable_ = True
			End If
			Return _cuentaContable_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContable_'. These settings will be taken into account
		''' when the property CuentaContable_ is requested or GetMultiCuentaContable_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContable_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContable_.SortClauses=sortClauses
			_cuentaContable_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentasHijas(forceFetch, _cuentasHijas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentasHijas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentasHijas(forceFetch, _cuentasHijas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentasHijas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentasHijas Or forceFetch Or _alwaysFetchCuentasHijas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentasHijas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentasHijas)
					End If
				End If
				_cuentasHijas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentasHijas.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentasHijas.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_cuentasHijas.SuppressClearInGetMulti = False
				_alreadyFetchedCuentasHijas = True
			End If
			Return _cuentasHijas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentasHijas'. These settings will be taken into account
		''' when the property CuentasHijas is requested or GetMultiCuentasHijas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentasHijas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentasHijas.SortClauses=sortClauses
			_cuentasHijas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_polizaDetalle.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, _usrCxpfacturasDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Return GetMultiUsrCxpfacturasDet(forceFetch, _usrCxpfacturasDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			If ( Not _alreadyFetchedUsrCxpfacturasDet Or forceFetch Or _alwaysFetchUsrCxpfacturasDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasDet)
					End If
				End If
				_usrCxpfacturasDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasDet.GetMultiManyToOne(Me, Nothing, Filter)
				_usrCxpfacturasDet.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasDet = True
			End If
			Return _usrCxpfacturasDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasDet'. These settings will be taken into account
		''' when the property UsrCxpfacturasDet is requested or GetMultiUsrCxpfacturasDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasDet.SortClauses=sortClauses
			_usrCxpfacturasDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'PeriodosContEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PeriodosContEntity'</returns>
		Public Function GetMultiPeriodosContCollectionViaAcumuladoCuentasContables(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PeriodosContCollection
			Return GetMultiPeriodosContCollectionViaAcumuladoCuentasContables(forceFetch, _periodosContCollectionViaAcumuladoCuentasContables.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PeriodosContEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPeriodosContCollectionViaAcumuladoCuentasContables(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PeriodosContCollection
			If ( Not _alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables Or forceFetch Or _alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _periodosContCollectionViaAcumuladoCuentasContables.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_periodosContCollectionViaAcumuladoCuentasContables)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, "__CuentaContableEntity__", "AcumuladoCuentasContables_", JoinHint.None)
				relations.Add(AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, "AcumuladoCuentasContables_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_periodosContCollectionViaAcumuladoCuentasContables.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_periodosContCollectionViaAcumuladoCuentasContables.EntityFactoryToUse = entityFactoryToUse
				End If
				_periodosContCollectionViaAcumuladoCuentasContables.GetMulti(Filter, relations)
				_periodosContCollectionViaAcumuladoCuentasContables.SuppressClearInGetMulti = False
				_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables = True
			End If
			Return _periodosContCollectionViaAcumuladoCuentasContables
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PeriodosContCollectionViaAcumuladoCuentasContables'. These settings will be taken into account
		''' when the property PeriodosContCollectionViaAcumuladoCuentasContables is requested or GetMultiPeriodosContCollectionViaAcumuladoCuentasContables is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPeriodosContCollectionViaAcumuladoCuentasContables(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_periodosContCollectionViaAcumuladoCuentasContables.SortClauses=sortClauses
			_periodosContCollectionViaAcumuladoCuentasContables.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabBalanceEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabBalanceEntity'</returns>
		Public Function GetMultiCabBalanceCollectionViaDetBalance(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabBalanceCollection
			Return GetMultiCabBalanceCollectionViaDetBalance(forceFetch, _cabBalanceCollectionViaDetBalance.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabBalanceEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabBalanceCollectionViaDetBalance(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabBalanceCollection
			If ( Not _alreadyFetchedCabBalanceCollectionViaDetBalance Or forceFetch Or _alwaysFetchCabBalanceCollectionViaDetBalance) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabBalanceCollectionViaDetBalance.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabBalanceCollectionViaDetBalance)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, "__CuentaContableEntity__", "DetBalance_", JoinHint.None)
				relations.Add(DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, "DetBalance_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabBalanceCollectionViaDetBalance.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabBalanceCollectionViaDetBalance.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabBalanceCollectionViaDetBalance.GetMulti(Filter, relations)
				_cabBalanceCollectionViaDetBalance.SuppressClearInGetMulti = False
				_alreadyFetchedCabBalanceCollectionViaDetBalance = True
			End If
			Return _cabBalanceCollectionViaDetBalance
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabBalanceCollectionViaDetBalance'. These settings will be taken into account
		''' when the property CabBalanceCollectionViaDetBalance is requested or GetMultiCabBalanceCollectionViaDetBalance is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabBalanceCollectionViaDetBalance(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabBalanceCollectionViaDetBalance.SortClauses=sortClauses
			_cabBalanceCollectionViaDetBalance.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabEdoResEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabEdoResEntity'</returns>
		Public Function GetMultiCabEdoResCollectionViaDetEdoRes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabEdoResCollection
			Return GetMultiCabEdoResCollectionViaDetEdoRes(forceFetch, _cabEdoResCollectionViaDetEdoRes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabEdoResEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabEdoResCollectionViaDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabEdoResCollection
			If ( Not _alreadyFetchedCabEdoResCollectionViaDetEdoRes Or forceFetch Or _alwaysFetchCabEdoResCollectionViaDetEdoRes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabEdoResCollectionViaDetEdoRes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabEdoResCollectionViaDetEdoRes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, "__CuentaContableEntity__", "DetEdoRes_", JoinHint.None)
				relations.Add(DetEdoResEntity.Relations.CabEdoResEntityUsingCveEdoRes, "DetEdoRes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cabEdoResCollectionViaDetEdoRes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabEdoResCollectionViaDetEdoRes.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabEdoResCollectionViaDetEdoRes.GetMulti(Filter, relations)
				_cabEdoResCollectionViaDetEdoRes.SuppressClearInGetMulti = False
				_alreadyFetchedCabEdoResCollectionViaDetEdoRes = True
			End If
			Return _cabEdoResCollectionViaDetEdoRes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabEdoResCollectionViaDetEdoRes'. These settings will be taken into account
		''' when the property CabEdoResCollectionViaDetEdoRes is requested or GetMultiCabEdoResCollectionViaDetEdoRes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabEdoResCollectionViaDetEdoRes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabEdoResCollectionViaDetEdoRes.SortClauses=sortClauses
			_cabEdoResCollectionViaDetEdoRes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "__CuentaContableEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch, _polizaCollectionViaGastosDepartamentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaGastosDepartamentos Or forceFetch Or _alwaysFetchPolizaCollectionViaGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaGastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaGastosDepartamentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "__CuentaContableEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaGastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaGastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaGastosDepartamentos.GetMulti(Filter, relations)
				_polizaCollectionViaGastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaGastosDepartamentos = True
			End If
			Return _polizaCollectionViaGastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaGastosDepartamentos'. These settings will be taken into account
		''' when the property PolizaCollectionViaGastosDepartamentos is requested or GetMultiPolizaCollectionViaGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaGastosDepartamentos.SortClauses=sortClauses
			_polizaCollectionViaGastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaMcatCentroCostosAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaMcatCentroCostosAlmacen(forceFetch, _plazaCollectionViaMcatCentroCostosAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaMcatCentroCostosAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen Or forceFetch Or _alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaMcatCentroCostosAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaMcatCentroCostosAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, "__CuentaContableEntity__", "McatCentroCostos_", JoinHint.None)
				relations.Add(McatCentroCostosEntity.Relations.PlazaEntityUsingIdPlaza, "McatCentroCostos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaMcatCentroCostosAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaMcatCentroCostosAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaMcatCentroCostosAlmacen.GetMulti(Filter, relations)
				_plazaCollectionViaMcatCentroCostosAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen = True
			End If
			Return _plazaCollectionViaMcatCentroCostosAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaMcatCentroCostosAlmacen'. These settings will be taken into account
		''' when the property PlazaCollectionViaMcatCentroCostosAlmacen is requested or GetMultiPlazaCollectionViaMcatCentroCostosAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaMcatCentroCostosAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaMcatCentroCostosAlmacen.SortClauses=sortClauses
			_plazaCollectionViaMcatCentroCostosAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "__CuentaContableEntity__", "Comicionista_", JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, "Comicionista_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaComicionista(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaComicionista(forceFetch, _plazaCollectionViaComicionista.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaComicionista(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaComicionista Or forceFetch Or _alwaysFetchPlazaCollectionViaComicionista) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaComicionista.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaComicionista)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "__CuentaContableEntity__", "Comicionista_", JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.PlazaEntityUsingPlaza, "Comicionista_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaComicionista.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaComicionista.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaComicionista.GetMulti(Filter, relations)
				_plazaCollectionViaComicionista.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaComicionista = True
			End If
			Return _plazaCollectionViaComicionista
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaComicionista'. These settings will be taken into account
		''' when the property PlazaCollectionViaComicionista is requested or GetMultiPlazaCollectionViaComicionista is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaComicionista(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaComicionista.SortClauses=sortClauses
			_plazaCollectionViaComicionista.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch, _catLugaresDeCompraCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_catLugaresDeCompraCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaProveedor.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = True
			End If
			Return _catLugaresDeCompraCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaProveedor'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaProveedor is requested or GetMultiCatLugaresDeCompraCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaProveedor.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaProveedor_(forceFetch, _catLugaresDeCompraCollectionViaProveedor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaProveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaProveedor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_catLugaresDeCompraCollectionViaProveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaProveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaProveedor_.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaProveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ = True
			End If
			Return _catLugaresDeCompraCollectionViaProveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaProveedor_'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaProveedor_ is requested or GetMultiCatLugaresDeCompraCollectionViaProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaProveedor_.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaProveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposOperacionEntity'</returns>
		Public Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Return GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch, _contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			If ( Not _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor Or forceFetch Or _alwaysFetchContDiotTiposOperacionCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposOperacionCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposOperacionCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposOperacionCollectionViaProveedor.GetMulti(Filter, relations)
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
			End If
			Return _contDiotTiposOperacionCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposOperacionCollectionViaProveedor'. These settings will be taken into account
		''' when the property ContDiotTiposOperacionCollectionViaProveedor is requested or GetMultiContDiotTiposOperacionCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposOperacionCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposOperacionCollectionViaProveedor.SortClauses=sortClauses
			_contDiotTiposOperacionCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposOperacionEntity'</returns>
		Public Function GetMultiContDiotTiposOperacionCollectionViaProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Return GetMultiContDiotTiposOperacionCollectionViaProveedor_(forceFetch, _contDiotTiposOperacionCollectionViaProveedor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposOperacionCollectionViaProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			If ( Not _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ Or forceFetch Or _alwaysFetchContDiotTiposOperacionCollectionViaProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposOperacionCollectionViaProveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposOperacionCollectionViaProveedor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_contDiotTiposOperacionCollectionViaProveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposOperacionCollectionViaProveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposOperacionCollectionViaProveedor_.GetMulti(Filter, relations)
				_contDiotTiposOperacionCollectionViaProveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ = True
			End If
			Return _contDiotTiposOperacionCollectionViaProveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposOperacionCollectionViaProveedor_'. These settings will be taken into account
		''' when the property ContDiotTiposOperacionCollectionViaProveedor_ is requested or GetMultiContDiotTiposOperacionCollectionViaProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposOperacionCollectionViaProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposOperacionCollectionViaProveedor_.SortClauses=sortClauses
			_contDiotTiposOperacionCollectionViaProveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposTercerosEntity'</returns>
		Public Function GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Return GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch, _contDiotTiposTercerosCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposTercerosCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			If ( Not _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor Or forceFetch Or _alwaysFetchContDiotTiposTercerosCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposTercerosCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposTercerosCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_contDiotTiposTercerosCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposTercerosCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposTercerosCollectionViaProveedor.GetMulti(Filter, relations)
				_contDiotTiposTercerosCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = True
			End If
			Return _contDiotTiposTercerosCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposTercerosCollectionViaProveedor'. These settings will be taken into account
		''' when the property ContDiotTiposTercerosCollectionViaProveedor is requested or GetMultiContDiotTiposTercerosCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposTercerosCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposTercerosCollectionViaProveedor.SortClauses=sortClauses
			_contDiotTiposTercerosCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposTercerosEntity'</returns>
		Public Function GetMultiContDiotTiposTercerosCollectionViaProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Return GetMultiContDiotTiposTercerosCollectionViaProveedor_(forceFetch, _contDiotTiposTercerosCollectionViaProveedor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposTercerosCollectionViaProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			If ( Not _alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ Or forceFetch Or _alwaysFetchContDiotTiposTercerosCollectionViaProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposTercerosCollectionViaProveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposTercerosCollectionViaProveedor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_contDiotTiposTercerosCollectionViaProveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposTercerosCollectionViaProveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposTercerosCollectionViaProveedor_.GetMulti(Filter, relations)
				_contDiotTiposTercerosCollectionViaProveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ = True
			End If
			Return _contDiotTiposTercerosCollectionViaProveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposTercerosCollectionViaProveedor_'. These settings will be taken into account
		''' when the property ContDiotTiposTercerosCollectionViaProveedor_ is requested or GetMultiContDiotTiposTercerosCollectionViaProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposTercerosCollectionViaProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposTercerosCollectionViaProveedor_.SortClauses=sortClauses
			_contDiotTiposTercerosCollectionViaProveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ComicionistaEntity'</returns>
		Public Function GetMultiComicionistaCollectionViaMfacCatClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Return GetMultiComicionistaCollectionViaMfacCatClientes(forceFetch, _comicionistaCollectionViaMfacCatClientes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiComicionistaCollectionViaMfacCatClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			If ( Not _alreadyFetchedComicionistaCollectionViaMfacCatClientes Or forceFetch Or _alwaysFetchComicionistaCollectionViaMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _comicionistaCollectionViaMfacCatClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_comicionistaCollectionViaMfacCatClientes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "__CuentaContableEntity__", "MfacCatClientes_", JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_comicionistaCollectionViaMfacCatClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_comicionistaCollectionViaMfacCatClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_comicionistaCollectionViaMfacCatClientes.GetMulti(Filter, relations)
				_comicionistaCollectionViaMfacCatClientes.SuppressClearInGetMulti = False
				_alreadyFetchedComicionistaCollectionViaMfacCatClientes = True
			End If
			Return _comicionistaCollectionViaMfacCatClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ComicionistaCollectionViaMfacCatClientes'. These settings will be taken into account
		''' when the property ComicionistaCollectionViaMfacCatClientes is requested or GetMultiComicionistaCollectionViaMfacCatClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersComicionistaCollectionViaMfacCatClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_comicionistaCollectionViaMfacCatClientes.SortClauses=sortClauses
			_comicionistaCollectionViaMfacCatClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ComicionistaEntity'</returns>
		Public Function GetMultiComicionistaCollectionViaMfacCatClientes_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Return GetMultiComicionistaCollectionViaMfacCatClientes_(forceFetch, _comicionistaCollectionViaMfacCatClientes_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiComicionistaCollectionViaMfacCatClientes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ComicionistaCollection
			If ( Not _alreadyFetchedComicionistaCollectionViaMfacCatClientes_ Or forceFetch Or _alwaysFetchComicionistaCollectionViaMfacCatClientes_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _comicionistaCollectionViaMfacCatClientes_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_comicionistaCollectionViaMfacCatClientes_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "__CuentaContableEntity__", "MfacCatClientes_", JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, "MfacCatClientes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_comicionistaCollectionViaMfacCatClientes_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_comicionistaCollectionViaMfacCatClientes_.EntityFactoryToUse = entityFactoryToUse
				End If
				_comicionistaCollectionViaMfacCatClientes_.GetMulti(Filter, relations)
				_comicionistaCollectionViaMfacCatClientes_.SuppressClearInGetMulti = False
				_alreadyFetchedComicionistaCollectionViaMfacCatClientes_ = True
			End If
			Return _comicionistaCollectionViaMfacCatClientes_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ComicionistaCollectionViaMfacCatClientes_'. These settings will be taken into account
		''' when the property ComicionistaCollectionViaMfacCatClientes_ is requested or GetMultiComicionistaCollectionViaMfacCatClientes_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersComicionistaCollectionViaMfacCatClientes_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_comicionistaCollectionViaMfacCatClientes_.SortClauses=sortClauses
			_comicionistaCollectionViaMfacCatClientes_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizasModeloCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizasModeloCabEntity'</returns>
		Public Function GetMultiPolizasModeloCabCollectionViaPolizasModeloDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizasModeloCabCollection
			Return GetMultiPolizasModeloCabCollectionViaPolizasModeloDet(forceFetch, _polizasModeloCabCollectionViaPolizasModeloDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizasModeloCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizasModeloCabCollectionViaPolizasModeloDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizasModeloCabCollection
			If ( Not _alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet Or forceFetch Or _alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizasModeloCabCollectionViaPolizasModeloDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizasModeloCabCollectionViaPolizasModeloDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, "__CuentaContableEntity__", "PolizasModeloDet_", JoinHint.None)
				relations.Add(PolizasModeloDetEntity.Relations.PolizasModeloCabEntityUsingCodigo, "PolizasModeloDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizasModeloCabCollectionViaPolizasModeloDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizasModeloCabCollectionViaPolizasModeloDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizasModeloCabCollectionViaPolizasModeloDet.GetMulti(Filter, relations)
				_polizasModeloCabCollectionViaPolizasModeloDet.SuppressClearInGetMulti = False
				_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet = True
			End If
			Return _polizasModeloCabCollectionViaPolizasModeloDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizasModeloCabCollectionViaPolizasModeloDet'. These settings will be taken into account
		''' when the property PolizasModeloCabCollectionViaPolizasModeloDet is requested or GetMultiPolizasModeloCabCollectionViaPolizasModeloDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizasModeloCabCollectionViaPolizasModeloDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizasModeloCabCollectionViaPolizasModeloDet.SortClauses=sortClauses
			_polizasModeloCabCollectionViaPolizasModeloDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaCuenta(forceFetch, _tipoMonedaCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaCuenta Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "__CuentaContableEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoMonedaCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaCuenta.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaCuenta = True
			End If
			Return _tipoMonedaCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaCuenta'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaCuenta is requested or GetMultiTipoMonedaCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaCuenta.SortClauses=sortClauses
			_tipoMonedaCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'BancosEntity'</returns>
		Public Function GetMultiBancosCollectionViaCuenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.BancosCollection
			Return GetMultiBancosCollectionViaCuenta(forceFetch, _bancosCollectionViaCuenta.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiBancosCollectionViaCuenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.BancosCollection
			If ( Not _alreadyFetchedBancosCollectionViaCuenta Or forceFetch Or _alwaysFetchBancosCollectionViaCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _bancosCollectionViaCuenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_bancosCollectionViaCuenta)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "__CuentaContableEntity__", "Cuenta_", JoinHint.None)
				relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId, "Cuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_bancosCollectionViaCuenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_bancosCollectionViaCuenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_bancosCollectionViaCuenta.GetMulti(Filter, relations)
				_bancosCollectionViaCuenta.SuppressClearInGetMulti = False
				_alreadyFetchedBancosCollectionViaCuenta = True
			End If
			Return _bancosCollectionViaCuenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'BancosCollectionViaCuenta'. These settings will be taken into account
		''' when the property BancosCollectionViaCuenta is requested or GetMultiBancosCollectionViaCuenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersBancosCollectionViaCuenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_bancosCollectionViaCuenta.SortClauses=sortClauses
			_bancosCollectionViaCuenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ConceptoFlujoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConceptoFlujoEntity'</returns>
		Public Function GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConceptoFlujoCollection
			Return GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(forceFetch, _usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ConceptoFlujoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConceptoFlujoCollection
			If ( Not _alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas Or forceFetch Or _alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, "__CuentaContableEntity__", "ConceptoFlujoCuenta_", JoinHint.None)
				relations.Add(ConceptoFlujoCuentaEntity.Relations.ConceptoFlujoEntityUsingConceptoFlujoId, "ConceptoFlujoCuenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.GetMulti(Filter, relations)
				_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.SuppressClearInGetMulti = False
				_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = True
			End If
			Return _usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas'. These settings will be taken into account
		''' when the property UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas is requested or GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.SortClauses=sortClauses
			_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaPolizaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaPolizaDetalle(forceFetch, _polizaCollectionViaPolizaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaPolizaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaPolizaDetalle Or forceFetch Or _alwaysFetchPolizaCollectionViaPolizaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaPolizaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaPolizaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, "__CuentaContableEntity__", "PolizaDetalle_", JoinHint.None)
				relations.Add(PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId, "PolizaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaPolizaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaPolizaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaPolizaDetalle.GetMulti(Filter, relations)
				_polizaCollectionViaPolizaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaPolizaDetalle = True
			End If
			Return _polizaCollectionViaPolizaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaPolizaDetalle'. These settings will be taken into account
		''' when the property PolizaCollectionViaPolizaDetalle is requested or GetMultiPolizaCollectionViaPolizaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaPolizaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaPolizaDetalle.SortClauses=sortClauses
			_polizaCollectionViaPolizaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasCabEntity'</returns>
		Public Function GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Return GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(forceFetch, _usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			If ( Not _alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet Or forceFetch Or _alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, "__CuentaContableEntity__", "UsrCxpfacturasDet_", JoinHint.None)
				relations.Add(UsrCxpfacturasDetEntity.Relations.UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura, "UsrCxpfacturasDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CuentaContableFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.GetMulti(Filter, relations)
				_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = True
			End If
			Return _usrCxpfacturasCabCollectionViaUsrCxpfacturasDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet'. These settings will be taken into account
		''' when the property UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet is requested or GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.SortClauses=sortClauses
			_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaEntrada() As CuentaContableEntity
			Return GetSingleCuentaEntrada(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaEntrada(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaEntrada Or forceFetch Or _alwaysFetchCuentaEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaEnt) Then
					fetchResult = newEntity.FetchUsingPK(Me.CtaEnt.GetValueOrDefault())
				End If
				If Not _cuentaEntradaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaEntrada = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaEntrada = newEntity
					_alreadyFetchedCuentaEntrada = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaEntrada
		End Function
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaSalida() As CuentaContableEntity
			Return GetSingleCuentaSalida(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaSalida(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaSalida Or forceFetch Or _alwaysFetchCuentaSalida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaSal) Then
					fetchResult = newEntity.FetchUsingPK(Me.CtaSal.GetValueOrDefault())
				End If
				If Not _cuentaSalidaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaSalida = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaSalida = newEntity
					_alreadyFetchedCuentaSalida = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaSalida
		End Function
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaPadre() As CuentaContableEntity
			Return GetSingleCuentaPadre(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaPadre(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaPadre Or forceFetch Or _alwaysFetchCuentaPadre) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaPadre) Then
					fetchResult = newEntity.FetchUsingPK(Me.CtaPadre.GetValueOrDefault())
				End If
				If Not _cuentaPadreReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaPadre = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaPadre = newEntity
					_alreadyFetchedCuentaPadre = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaPadre
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CuentaContableFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CuentaContableFieldIndex)








					Case CuentaContableFieldIndex.CtaPadre
						DesetupSyncCuentaPadre(True, False)
						_alreadyFetchedCuentaPadre = False
					Case CuentaContableFieldIndex.CtaEnt
						DesetupSyncCuentaEntrada(True, False)
						_alreadyFetchedCuentaEntrada = False
					Case CuentaContableFieldIndex.CtaSal
						DesetupSyncCuentaSalida(True, False)
						_alreadyFetchedCuentaSalida = False











					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_acumuladoCuentasContables.ActiveContext = MyBase.ActiveContext
			_catTipNotas.ActiveContext = MyBase.ActiveContext
			_cfgCtrlCtas.ActiveContext = MyBase.ActiveContext
			_detBalance.ActiveContext = MyBase.ActiveContext
			_detEdoRes.ActiveContext = MyBase.ActiveContext
			_gastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_almacen.ActiveContext = MyBase.ActiveContext
			_mcatCentroCostosAlmacen.ActiveContext = MyBase.ActiveContext
			_comicionista.ActiveContext = MyBase.ActiveContext
			_proveedor.ActiveContext = MyBase.ActiveContext
			_proveedor_.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanado.ActiveContext = MyBase.ActiveContext
			_cliente.ActiveContext = MyBase.ActiveContext
			_cliente_.ActiveContext = MyBase.ActiveContext
			_msccatProductos.ActiveContext = MyBase.ActiveContext
			_polizasModeloDet.ActiveContext = MyBase.ActiveContext
			_cuenta.ActiveContext = MyBase.ActiveContext
			_usrConConceptosFlujoCuentas.ActiveContext = MyBase.ActiveContext
			_cuentaContable.ActiveContext = MyBase.ActiveContext
			_cuentaContable_.ActiveContext = MyBase.ActiveContext
			_cuentasHijas.ActiveContext = MyBase.ActiveContext
			_polizaDetalle.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasDet.ActiveContext = MyBase.ActiveContext
			_periodosContCollectionViaAcumuladoCuentasContables.ActiveContext = MyBase.ActiveContext
			_cabBalanceCollectionViaDetBalance.ActiveContext = MyBase.ActiveContext
			_cabEdoResCollectionViaDetEdoRes.ActiveContext = MyBase.ActiveContext
			_metodoCabCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_tipoAlmacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaMcatCentroCostosAlmacen.ActiveContext = MyBase.ActiveContext
			_tipoComicionistaCollectionViaComicionista.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaComicionista.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaProveedor_.ActiveContext = MyBase.ActiveContext
			_contDiotTiposOperacionCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_contDiotTiposOperacionCollectionViaProveedor_.ActiveContext = MyBase.ActiveContext
			_contDiotTiposTercerosCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_contDiotTiposTercerosCollectionViaProveedor_.ActiveContext = MyBase.ActiveContext
			_comicionistaCollectionViaMfacCatClientes.ActiveContext = MyBase.ActiveContext
			_comicionistaCollectionViaMfacCatClientes_.ActiveContext = MyBase.ActiveContext
			_polizasModeloCabCollectionViaPolizasModeloDet.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaCuenta.ActiveContext = MyBase.ActiveContext
			_bancosCollectionViaCuenta.ActiveContext = MyBase.ActiveContext
			_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaPolizaDetalle.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet.ActiveContext = MyBase.ActiveContext
		If Not _cuentaEntrada Is Nothing Then
				_cuentaEntrada.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaSalida Is Nothing Then
				_cuentaSalida.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaPadre Is Nothing Then
				_cuentaPadre.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CuentaContableDAO = CType(CreateDAOInstance(), CuentaContableDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CuentaContableDAO = CType(CreateDAOInstance(), CuentaContableDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CuentaContableDAO = CType(CreateDAOInstance(), CuentaContableDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CuentaContableEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentaContableEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <param name="validator">The validator Object for this CuentaContableEntity</param>
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
			_acumuladoCuentasContables = New Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection(New AcumuladoCuentasContablesEntityFactory())
			_acumuladoCuentasContables.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchAcumuladoCuentasContables = False
			_alreadyFetchedAcumuladoCuentasContables = False
			_catTipNotas = New Integralab.ORM.CollectionClasses.CatTipNotasCollection(New CatTipNotasEntityFactory())
			_catTipNotas.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchCatTipNotas = False
			_alreadyFetchedCatTipNotas = False
			_cfgCtrlCtas = New Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection(New CfgCtrlCtasEntityFactory())
			_cfgCtrlCtas.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchCfgCtrlCtas = False
			_alreadyFetchedCfgCtrlCtas = False
			_detBalance = New Integralab.ORM.CollectionClasses.DetBalanceCollection(New DetBalanceEntityFactory())
			_detBalance.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchDetBalance = False
			_alreadyFetchedDetBalance = False
			_detEdoRes = New Integralab.ORM.CollectionClasses.DetEdoResCollection(New DetEdoResEntityFactory())
			_detEdoRes.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchDetEdoRes = False
			_alreadyFetchedDetEdoRes = False
			_gastosDepartamentos = New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(New GastosDepartamentosEntityFactory())
			_gastosDepartamentos.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchGastosDepartamentos = False
			_alreadyFetchedGastosDepartamentos = False
			_almacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_almacen.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_mcatCentroCostosAlmacen = New Integralab.ORM.CollectionClasses.McatCentroCostosCollection(New McatCentroCostosEntityFactory())
			_mcatCentroCostosAlmacen.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchMcatCentroCostosAlmacen = False
			_alreadyFetchedMcatCentroCostosAlmacen = False
			_comicionista = New Integralab.ORM.CollectionClasses.ComicionistaCollection(New ComicionistaEntityFactory())
			_comicionista.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchComicionista = False
			_alreadyFetchedComicionista = False
			_proveedor = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_proveedor.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_proveedor_ = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_proveedor_.SetContainingEntityInfo(Me, "CuentaContable_")
			_alwaysFetchProveedor_ = False
			_alreadyFetchedProveedor_ = False
			_mcgcatCompradoresdeGanado = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_mcgcatCompradoresdeGanado.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchMcgcatCompradoresdeGanado = False
			_alreadyFetchedMcgcatCompradoresdeGanado = False
			_cliente = New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(New MfacCatClientesEntityFactory())
			_cliente.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchCliente = False
			_alreadyFetchedCliente = False
			_cliente_ = New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(New MfacCatClientesEntityFactory())
			_cliente_.SetContainingEntityInfo(Me, "CuentaContable_")
			_alwaysFetchCliente_ = False
			_alreadyFetchedCliente_ = False
			_msccatProductos = New Integralab.ORM.CollectionClasses.MsccatProductosCollection(New MsccatProductosEntityFactory())
			_msccatProductos.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchMsccatProductos = False
			_alreadyFetchedMsccatProductos = False
			_polizasModeloDet = New Integralab.ORM.CollectionClasses.PolizasModeloDetCollection(New PolizasModeloDetEntityFactory())
			_polizasModeloDet.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchPolizasModeloDet = False
			_alreadyFetchedPolizasModeloDet = False
			_cuenta = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_cuenta.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchCuenta = False
			_alreadyFetchedCuenta = False
			_usrConConceptosFlujoCuentas = New Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection(New ConceptoFlujoCuentaEntityFactory())
			_usrConConceptosFlujoCuentas.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchUsrConConceptosFlujoCuentas = False
			_alreadyFetchedUsrConConceptosFlujoCuentas = False
			_cuentaContable = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_cuentaContable.SetContainingEntityInfo(Me, "CuentaEntrada")
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_cuentaContable_ = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_cuentaContable_.SetContainingEntityInfo(Me, "CuentaSalida")
			_alwaysFetchCuentaContable_ = False
			_alreadyFetchedCuentaContable_ = False
			_cuentasHijas = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_cuentasHijas.SetContainingEntityInfo(Me, "CuentaPadre")
			_alwaysFetchCuentasHijas = False
			_alreadyFetchedCuentasHijas = False
			_polizaDetalle = New Integralab.ORM.CollectionClasses.PolizaDetalleCollection(New PolizaDetalleEntityFactory())
			_polizaDetalle.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchPolizaDetalle = False
			_alreadyFetchedPolizaDetalle = False
			_usrCxpfacturasDet = New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection(New UsrCxpfacturasDetEntityFactory())
			_usrCxpfacturasDet.SetContainingEntityInfo(Me, "CuentaContable")
			_alwaysFetchUsrCxpfacturasDet = False
			_alreadyFetchedUsrCxpfacturasDet = False
			_periodosContCollectionViaAcumuladoCuentasContables = New Integralab.ORM.CollectionClasses.PeriodosContCollection(New PeriodosContEntityFactory())
			_alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables = False
			_alreadyFetchedPeriodosContCollectionViaAcumuladoCuentasContables = False
			_cabBalanceCollectionViaDetBalance = New Integralab.ORM.CollectionClasses.CabBalanceCollection(New CabBalanceEntityFactory())
			_alwaysFetchCabBalanceCollectionViaDetBalance = False
			_alreadyFetchedCabBalanceCollectionViaDetBalance = False
			_cabEdoResCollectionViaDetEdoRes = New Integralab.ORM.CollectionClasses.CabEdoResCollection(New CabEdoResEntityFactory())
			_alwaysFetchCabEdoResCollectionViaDetEdoRes = False
			_alreadyFetchedCabEdoResCollectionViaDetEdoRes = False
			_metodoCabCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.MetodoCabCollection(New MetodoCabEntityFactory())
			_alwaysFetchMetodoCabCollectionViaGastosDepartamentos = False
			_alreadyFetchedMetodoCabCollectionViaGastosDepartamentos = False
			_polizaCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaGastosDepartamentos = False
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = False
			_plazaCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaAlmacen = False
			_alreadyFetchedPlazaCollectionViaAlmacen = False
			_almacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaAlmacen = False
			_alreadyFetchedAlmacenCollectionViaAlmacen = False
			_tipoAlmacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(New TipoAlmacenEntityFactory())
			_alwaysFetchTipoAlmacenCollectionViaAlmacen = False
			_alreadyFetchedTipoAlmacenCollectionViaAlmacen = False
			_plazaCollectionViaMcatCentroCostosAlmacen = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen = False
			_alreadyFetchedPlazaCollectionViaMcatCentroCostosAlmacen = False
			_tipoComicionistaCollectionViaComicionista = New Integralab.ORM.CollectionClasses.TipoComicionistaCollection(New TipoComicionistaEntityFactory())
			_alwaysFetchTipoComicionistaCollectionViaComicionista = False
			_alreadyFetchedTipoComicionistaCollectionViaComicionista = False
			_plazaCollectionViaComicionista = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaComicionista = False
			_alreadyFetchedPlazaCollectionViaComicionista = False
			_catLugaresDeCompraCollectionViaProveedor = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = False
			_catLugaresDeCompraCollectionViaProveedor_ = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor_ = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor_ = False
			_contDiotTiposOperacionCollectionViaProveedor = New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(New ContDiotTiposOperacionEntityFactory())
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = False
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = False
			_contDiotTiposOperacionCollectionViaProveedor_ = New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(New ContDiotTiposOperacionEntityFactory())
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor_ = False
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor_ = False
			_contDiotTiposTercerosCollectionViaProveedor = New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(New ContDiotTiposTercerosEntityFactory())
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = False
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor = False
			_contDiotTiposTercerosCollectionViaProveedor_ = New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(New ContDiotTiposTercerosEntityFactory())
			_alwaysFetchContDiotTiposTercerosCollectionViaProveedor_ = False
			_alreadyFetchedContDiotTiposTercerosCollectionViaProveedor_ = False
			_comicionistaCollectionViaMfacCatClientes = New Integralab.ORM.CollectionClasses.ComicionistaCollection(New ComicionistaEntityFactory())
			_alwaysFetchComicionistaCollectionViaMfacCatClientes = False
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes = False
			_comicionistaCollectionViaMfacCatClientes_ = New Integralab.ORM.CollectionClasses.ComicionistaCollection(New ComicionistaEntityFactory())
			_alwaysFetchComicionistaCollectionViaMfacCatClientes_ = False
			_alreadyFetchedComicionistaCollectionViaMfacCatClientes_ = False
			_polizasModeloCabCollectionViaPolizasModeloDet = New Integralab.ORM.CollectionClasses.PolizasModeloCabCollection(New PolizasModeloCabEntityFactory())
			_alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet = False
			_alreadyFetchedPolizasModeloCabCollectionViaPolizasModeloDet = False
			_tipoMonedaCollectionViaCuenta = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaCuenta = False
			_alreadyFetchedTipoMonedaCollectionViaCuenta = False
			_bancosCollectionViaCuenta = New Integralab.ORM.CollectionClasses.BancosCollection(New BancosEntityFactory())
			_alwaysFetchBancosCollectionViaCuenta = False
			_alreadyFetchedBancosCollectionViaCuenta = False
			_usrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = New Integralab.ORM.CollectionClasses.ConceptoFlujoCollection(New ConceptoFlujoEntityFactory())
			_alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = False
			_alreadyFetchedUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = False
			_polizaCollectionViaPolizaDetalle = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaPolizaDetalle = False
			_alreadyFetchedPolizaCollectionViaPolizaDetalle = False
			_usrCxpfacturasCabCollectionViaUsrCxpfacturasDet = New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection(New UsrCxpfacturasCabEntityFactory())
			_alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = False
			_alreadyFetchedUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = False
			_cuentaEntrada = Nothing
			_cuentaEntradaReturnsNewIfNotFound = True
			_alwaysFetchCuentaEntrada = False
			_alreadyFetchedCuentaEntrada = False
			_cuentaSalida = Nothing
			_cuentaSalidaReturnsNewIfNotFound = True
			_alwaysFetchCuentaSalida = False
			_alreadyFetchedCuentaSalida = False
			_cuentaPadre = Nothing
			_cuentaPadreReturnsNewIfNotFound = True
			_alwaysFetchCuentaPadre = False
			_alreadyFetchedCuentaPadre = False

			
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

			_fieldsCustomProperties.Add("Cta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SsubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SssubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomCuenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Naturaleza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumeroHijos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaPadre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaEnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaSal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoAnoAnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoIniEjerc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooResultad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooPresup", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooAfectable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooInactiva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooDepta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooBancos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Titulo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTitulo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodAgrupSat", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cuentaEntrada</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaEntrada(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaEntrada, AddressOf OnCuentaEntradaPropertyChanged, "CuentaEntrada", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaEnt, True, signalRelatedEntity, "CuentaContable", resetFKFields, New Integer() { CInt(CuentaContableFieldIndex.CtaEnt) } )
			_cuentaEntrada = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaEntrada</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaEntrada(relatedEntity As IEntity)
			DesetupSyncCuentaEntrada(True, True)
			_cuentaEntrada = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaEntrada, AddressOf OnCuentaEntradaPropertyChanged, "CuentaEntrada", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaEnt, True, _alreadyFetchedCuentaEntrada, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaEntradaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaSalida</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaSalida(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaSalida, AddressOf OnCuentaSalidaPropertyChanged, "CuentaSalida", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaSal, True, signalRelatedEntity, "CuentaContable_", resetFKFields, New Integer() { CInt(CuentaContableFieldIndex.CtaSal) } )
			_cuentaSalida = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaSalida</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaSalida(relatedEntity As IEntity)
			DesetupSyncCuentaSalida(True, True)
			_cuentaSalida = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaSalida, AddressOf OnCuentaSalidaPropertyChanged, "CuentaSalida", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaSal, True, _alreadyFetchedCuentaSalida, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaSalidaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaPadre</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaPadre(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaPadre, AddressOf OnCuentaPadrePropertyChanged, "CuentaPadre", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaPadre, True, signalRelatedEntity, "CuentasHijas", resetFKFields, New Integer() { CInt(CuentaContableFieldIndex.CtaPadre) } )
			_cuentaPadre = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaPadre</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaPadre(relatedEntity As IEntity)
			DesetupSyncCuentaPadre(True, True)
			_cuentaPadre = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaPadre, AddressOf OnCuentaPadrePropertyChanged, "CuentaPadre", CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaPadre, True, _alreadyFetchedCuentaPadre, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaPadrePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for CuentaContable which data should be fetched into this CuentaContable Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CuentaContableFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCuentaContableDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CuentaContableEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CuentaContableRelations
			Get	
				Return New CuentaContableRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AcumuladoCuentasContables' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAcumuladoCuentasContables() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection(), _
					CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.AcumuladoCuentasContablesEntity, Integer), 0, Nothing, Nothing, Nothing, "AcumuladoCuentasContables", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatTipNotas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatTipNotas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatTipNotasCollection(), _
					CuentaContableEntity.Relations.CatTipNotasEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CatTipNotasEntity, Integer), 0, Nothing, Nothing, Nothing, "CatTipNotas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CfgCtrlCtas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCfgCtrlCtas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection(), _
					CuentaContableEntity.Relations.CfgCtrlCtasEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CfgCtrlCtasEntity, Integer), 0, Nothing, Nothing, Nothing, "CfgCtrlCtas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetBalance' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetBalance() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetBalanceCollection(), _
					CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.DetBalanceEntity, Integer), 0, Nothing, Nothing, Nothing, "DetBalance", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetEdoRes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetEdoRes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetEdoResCollection(), _
					CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.DetEdoResEntity, Integer), 0, Nothing, Nothing, Nothing, "DetEdoRes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GastosDepartamentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathGastosDepartamentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(), _
					CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.GastosDepartamentosEntity, Integer), 0, Nothing, Nothing, Nothing, "GastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McatCentroCostos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcatCentroCostosAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McatCentroCostosCollection(), _
					CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.McatCentroCostosEntity, Integer), 0, Nothing, Nothing, Nothing, "McatCentroCostosAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathComicionista() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ComicionistaCollection(), _
					CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), 0, Nothing, Nothing, Nothing, "Comicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					CuentaContableEntity.Relations.McgcatCompradoresdeGanadoEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatCompradoresdeGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCliente() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "Cliente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCliente_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "Cliente_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					CuentaContableEntity.Relations.MsccatProductosEntityUsingIdCeuntaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PolizasModeloDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizasModeloDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizasModeloDetCollection(), _
					CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PolizasModeloDetEntity, Integer), 0, Nothing, Nothing, Nothing, "PolizasModeloDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "Cuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConceptoFlujoCuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrConConceptosFlujoCuentas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection(), _
					CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ConceptoFlujoCuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrConConceptosFlujoCuentas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCtaEnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCtaSal, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentasHijas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCtaPadre, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentasHijas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PolizaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaDetalleCollection(), _
					CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PolizaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "PolizaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection(), _
					CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasDetEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PeriodosCont' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPeriodosContCollectionViaAcumuladoCuentasContables() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PeriodosContCollection(), _
					CuentaContableEntity.Relations.AcumuladoCuentasContablesEntityUsingCodigo, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PeriodosContEntity, Integer), 0, Nothing, Nothing, relations, "PeriodosContCollectionViaAcumuladoCuentasContables", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabBalance' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabBalanceCollectionViaDetBalance() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabBalanceCollection(), _
					CuentaContableEntity.Relations.DetBalanceEntityUsingCveCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CabBalanceEntity, Integer), 0, Nothing, Nothing, relations, "CabBalanceCollectionViaDetBalance", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabEdoRes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabEdoResCollectionViaDetEdoRes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(DetEdoResEntity.Relations.CabEdoResEntityUsingCveEdoRes)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabEdoResCollection(), _
					CuentaContableEntity.Relations.DetEdoResEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CabEdoResEntity, Integer), 0, Nothing, Nothing, relations, "CabEdoResCollectionViaDetEdoRes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MetodoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMetodoCabCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.MetodoCabEntityUsingIdMetodoProrrateo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MetodoCabCollection(), _
					CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), 0, Nothing, Nothing, relations, "MetodoCabCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaContableEntity.Relations.GastosDepartamentosEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.TipoAlmacenEntityUsingTipoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(), _
					CuentaContableEntity.Relations.AlmacenEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "TipoAlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaMcatCentroCostosAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(McatCentroCostosEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CuentaContableEntity.Relations.McatCentroCostosEntityUsingIdCuentaCont, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaMcatCentroCostosAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoComicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoComicionistaCollectionViaComicionista() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoComicionistaCollection(), _
					CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.TipoComicionistaEntity, Integer), 0, Nothing, Nothing, relations, "TipoComicionistaCollectionViaComicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaComicionista() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ComicionistaEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CuentaContableEntity.Relations.ComicionistaEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaComicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaProveedor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaProveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposOperacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposOperacionCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposOperacionEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposOperacionCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposOperacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposOperacionCollectionViaProveedor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposOperacionEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposOperacionCollectionViaProveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposTerceros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposTercerosCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposTercerosCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposTerceros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposTercerosCollectionViaProveedor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposTercerosEntityUsingIdcontdiottiposterceros)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection(), _
					CuentaContableEntity.Relations.ProveedorEntityUsingPrCuentaAnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposTercerosCollectionViaProveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathComicionistaCollectionViaMfacCatClientes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ComicionistaCollection(), _
					CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), 0, Nothing, Nothing, relations, "ComicionistaCollectionViaMfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathComicionistaCollectionViaMfacCatClientes_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ComicionistaCollection(), _
					CuentaContableEntity.Relations.MfacCatClientesEntityUsingCuentaAnticipoId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), 0, Nothing, Nothing, relations, "ComicionistaCollectionViaMfacCatClientes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PolizasModeloCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizasModeloCabCollectionViaPolizasModeloDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(PolizasModeloDetEntity.Relations.PolizasModeloCabEntityUsingCodigo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizasModeloCabCollection(), _
					CuentaContableEntity.Relations.PolizasModeloDetEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PolizasModeloCabEntity, Integer), 0, Nothing, Nothing, relations, "PolizasModeloCabCollectionViaPolizasModeloDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.TipoMonedaEntityUsingTipomonedaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBancosCollectionViaCuenta() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(CuentaEntity.Relations.BancosEntityUsingBancoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					CuentaContableEntity.Relations.CuentaEntityUsingCuentacontableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, relations, "BancosCollectionViaCuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConceptoFlujo' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(ConceptoFlujoCuentaEntity.Relations.ConceptoFlujoEntityUsingConceptoFlujoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConceptoFlujoCollection(), _
					CuentaContableEntity.Relations.ConceptoFlujoCuentaEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.ConceptoFlujoEntity, Integer), 0, Nothing, Nothing, relations, "UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaPolizaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CuentaContableEntity.Relations.PolizaDetalleEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaPolizaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, "__CuentaContableEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrCxpfacturasDetEntity.Relations.UsrCxpfacturasCabEntityUsingEmpresaIdIdProveedorNoFactura)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection(), _
					CuentaContableEntity.Relations.UsrCxpfacturasDetEntityUsingCuentaContableId, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasCabEntity, Integer), 0, Nothing, Nothing, relations, "UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaEntrada() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaEnt, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaSalida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaSal, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaPadre() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CuentaContableEntity.Relations.CuentaContableEntityUsingCodigoCtaPadre, _
					CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaPadre", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CuentaContableEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CuentaContableEntity.CustomProperties
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
				Return CuentaContableEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."Cta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.Cta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.Cta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubCta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SsubCta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SsubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SsubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SsubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SssubCta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SSSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SssubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SssubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SssubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomCuenta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."NomCuenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomCuenta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.NomCuenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.NomCuenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Naturaleza property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."Naturaleza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Naturaleza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.Naturaleza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.Naturaleza, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumeroHijos property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."NumeroHijos"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumeroHijos]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.NumeroHijos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.NumeroHijos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaPadre property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."CtaPadre"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaPadre]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.CtaPadre, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.CtaPadre, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaEnt property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."CtaEnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaEnt]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.CtaEnt, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.CtaEnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaSal property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."CtaSal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaSal]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.CtaSal, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.CtaSal, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoAnoAnt property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SaldoAnoAnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoAnoAnt]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SaldoAnoAnt, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SaldoAnoAnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoIniEjerc property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SaldoIniEjerc"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoIniEjerc]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SaldoIniEjerc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SaldoIniEjerc, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooResultad property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooResultad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooResultad]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooResultad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooResultad, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooPresup property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooPresup"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooPresup]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooPresup, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooPresup, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooAfectable property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooAfectable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooAfectable]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooAfectable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooAfectable, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooInactiva property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooInactiva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooInactiva]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooInactiva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooInactiva, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooDepta property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooDepta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooDepta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooDepta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooDepta, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooBancos property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."BooBancos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooBancos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.BooBancos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.BooBancos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Titulo property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."Titulo"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Titulo]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.Titulo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.Titulo, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTitulo property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."SubTitulo"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTitulo]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.SubTitulo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.SubTitulo, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodAgrupSat property of the Entity CuentaContable<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentas"."CodAgrupSAT"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodAgrupSat]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentaContableFieldIndex.CodAgrupSat, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentaContableFieldIndex.CodAgrupSat, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AcumuladoCuentasContablesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAcumuladoCuentasContables()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AcumuladoCuentasContables]() As Integralab.ORM.CollectionClasses.AcumuladoCuentasContablesCollection
			Get
				Return GetMultiAcumuladoCuentasContables(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AcumuladoCuentasContables. When set to true, AcumuladoCuentasContables is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AcumuladoCuentasContables is accessed. You can always execute
		''' a forced fetch by calling GetMultiAcumuladoCuentasContables(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAcumuladoCuentasContables As Boolean
			Get
				Return _alwaysFetchAcumuladoCuentasContables
			End Get
			Set
				_alwaysFetchAcumuladoCuentasContables = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatTipNotasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatTipNotas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatTipNotas]() As Integralab.ORM.CollectionClasses.CatTipNotasCollection
			Get
				Return GetMultiCatTipNotas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatTipNotas. When set to true, CatTipNotas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatTipNotas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatTipNotas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatTipNotas As Boolean
			Get
				Return _alwaysFetchCatTipNotas
			End Get
			Set
				_alwaysFetchCatTipNotas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CfgCtrlCtasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCfgCtrlCtas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CfgCtrlCtas]() As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
			Get
				Return GetMultiCfgCtrlCtas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CfgCtrlCtas. When set to true, CfgCtrlCtas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CfgCtrlCtas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCfgCtrlCtas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCfgCtrlCtas As Boolean
			Get
				Return _alwaysFetchCfgCtrlCtas
			End Get
			Set
				_alwaysFetchCfgCtrlCtas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetBalanceEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetBalance()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetBalance]() As Integralab.ORM.CollectionClasses.DetBalanceCollection
			Get
				Return GetMultiDetBalance(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetBalance. When set to true, DetBalance is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetBalance is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetBalance(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetBalance As Boolean
			Get
				Return _alwaysFetchDetBalance
			End Get
			Set
				_alwaysFetchDetBalance = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetEdoRes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetEdoRes]() As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Get
				Return GetMultiDetEdoRes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetEdoRes. When set to true, DetEdoRes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetEdoRes is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetEdoRes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetEdoRes As Boolean
			Get
				Return _alwaysFetchDetEdoRes
			End Get
			Set
				_alwaysFetchDetEdoRes = value
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
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Proveedor]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Proveedor_]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor_. When set to true, Proveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor_ As Boolean
			Get
				Return _alwaysFetchProveedor_
			End Get
			Set
				_alwaysFetchProveedor_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatCompradoresdeGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatCompradoresdeGanado]() As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Get
				Return GetMultiMcgcatCompradoresdeGanado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCompradoresdeGanado. When set to true, McgcatCompradoresdeGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCompradoresdeGanado is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatCompradoresdeGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCompradoresdeGanado As Boolean
			Get
				Return _alwaysFetchMcgcatCompradoresdeGanado
			End Get
			Set
				_alwaysFetchMcgcatCompradoresdeGanado = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCliente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cliente]() As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
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
	
		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCliente_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cliente_]() As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Get
				Return GetMultiCliente_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cliente_. When set to true, Cliente_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cliente_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCliente_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCliente_ As Boolean
			Get
				Return _alwaysFetchCliente_
			End Get
			Set
				_alwaysFetchCliente_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductos]() As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Get
				Return GetMultiMsccatProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductos. When set to true, MsccatProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductos
			End Get
			Set
				_alwaysFetchMsccatProductos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizasModeloDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizasModeloDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizasModeloDet]() As Integralab.ORM.CollectionClasses.PolizasModeloDetCollection
			Get
				Return GetMultiPolizasModeloDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizasModeloDet. When set to true, PolizasModeloDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizasModeloDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizasModeloDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizasModeloDet As Boolean
			Get
				Return _alwaysFetchPolizasModeloDet
			End Get
			Set
				_alwaysFetchPolizasModeloDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cuenta]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cuenta. When set to true, Cuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuenta As Boolean
			Get
				Return _alwaysFetchCuenta
			End Get
			Set
				_alwaysFetchCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ConceptoFlujoCuentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrConConceptosFlujoCuentas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrConConceptosFlujoCuentas]() As Integralab.ORM.CollectionClasses.ConceptoFlujoCuentaCollection
			Get
				Return GetMultiUsrConConceptosFlujoCuentas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrConConceptosFlujoCuentas. When set to true, UsrConConceptosFlujoCuentas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrConConceptosFlujoCuentas is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrConConceptosFlujoCuentas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrConConceptosFlujoCuentas As Boolean
			Get
				Return _alwaysFetchUsrConConceptosFlujoCuentas
			End Get
			Set
				_alwaysFetchUsrConConceptosFlujoCuentas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContable()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContable]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContable(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable. When set to true, CuentaContable is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContable(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable As Boolean
			Get
				Return _alwaysFetchCuentaContable
			End Get
			Set
				_alwaysFetchCuentaContable = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContable_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContable_]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContable_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable_. When set to true, CuentaContable_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContable_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable_ As Boolean
			Get
				Return _alwaysFetchCuentaContable_
			End Get
			Set
				_alwaysFetchCuentaContable_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentasHijas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentasHijas]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentasHijas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentasHijas. When set to true, CuentasHijas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentasHijas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentasHijas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentasHijas As Boolean
			Get
				Return _alwaysFetchCuentasHijas
			End Get
			Set
				_alwaysFetchCuentasHijas = value
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
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasDet]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection
			Get
				Return GetMultiUsrCxpfacturasDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasDet. When set to true, UsrCxpfacturasDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasDet As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasDet
			End Get
			Set
				_alwaysFetchUsrCxpfacturasDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PeriodosContEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPeriodosContCollectionViaAcumuladoCuentasContables()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PeriodosContCollectionViaAcumuladoCuentasContables]() As Integralab.ORM.CollectionClasses.PeriodosContCollection
			Get
				Return GetMultiPeriodosContCollectionViaAcumuladoCuentasContables(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PeriodosContCollectionViaAcumuladoCuentasContables. When set to true, PeriodosContCollectionViaAcumuladoCuentasContables is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PeriodosContCollectionViaAcumuladoCuentasContables is accessed. You can always execute
		''' a forced fetch by calling GetMultiPeriodosContCollectionViaAcumuladoCuentasContables(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables As Boolean
			Get
				Return _alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables
			End Get
			Set
				_alwaysFetchPeriodosContCollectionViaAcumuladoCuentasContables = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabBalanceEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabBalanceCollectionViaDetBalance()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabBalanceCollectionViaDetBalance]() As Integralab.ORM.CollectionClasses.CabBalanceCollection
			Get
				Return GetMultiCabBalanceCollectionViaDetBalance(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabBalanceCollectionViaDetBalance. When set to true, CabBalanceCollectionViaDetBalance is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabBalanceCollectionViaDetBalance is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabBalanceCollectionViaDetBalance(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabBalanceCollectionViaDetBalance As Boolean
			Get
				Return _alwaysFetchCabBalanceCollectionViaDetBalance
			End Get
			Set
				_alwaysFetchCabBalanceCollectionViaDetBalance = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabEdoResEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabEdoResCollectionViaDetEdoRes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabEdoResCollectionViaDetEdoRes]() As Integralab.ORM.CollectionClasses.CabEdoResCollection
			Get
				Return GetMultiCabEdoResCollectionViaDetEdoRes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabEdoResCollectionViaDetEdoRes. When set to true, CabEdoResCollectionViaDetEdoRes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabEdoResCollectionViaDetEdoRes is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabEdoResCollectionViaDetEdoRes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabEdoResCollectionViaDetEdoRes As Boolean
			Get
				Return _alwaysFetchCabEdoResCollectionViaDetEdoRes
			End Get
			Set
				_alwaysFetchCabEdoResCollectionViaDetEdoRes = value
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
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaGastosDepartamentos]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaGastosDepartamentos. When set to true, PolizaCollectionViaGastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaGastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaGastosDepartamentos
			End Get
			Set
				_alwaysFetchPolizaCollectionViaGastosDepartamentos = value
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
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaMcatCentroCostosAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaMcatCentroCostosAlmacen]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaMcatCentroCostosAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaMcatCentroCostosAlmacen. When set to true, PlazaCollectionViaMcatCentroCostosAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaMcatCentroCostosAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaMcatCentroCostosAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen
			End Get
			Set
				_alwaysFetchPlazaCollectionViaMcatCentroCostosAlmacen = value
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
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaComicionista()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaComicionista]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaComicionista(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaComicionista. When set to true, PlazaCollectionViaComicionista is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaComicionista is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaComicionista(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaComicionista As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaComicionista
			End Get
			Set
				_alwaysFetchPlazaCollectionViaComicionista = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaProveedor. When set to true, CatLugaresDeCompraCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaProveedor
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaProveedor_]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaProveedor_. When set to true, CatLugaresDeCompraCollectionViaProveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaProveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaProveedor_ As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaProveedor_
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaProveedor_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposOperacionCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposOperacionCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Get
				Return GetMultiContDiotTiposOperacionCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposOperacionCollectionViaProveedor. When set to true, ContDiotTiposOperacionCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposOperacionCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposOperacionCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposOperacionCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchContDiotTiposOperacionCollectionViaProveedor
			End Get
			Set
				_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposOperacionCollectionViaProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposOperacionCollectionViaProveedor_]() As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Get
				Return GetMultiContDiotTiposOperacionCollectionViaProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposOperacionCollectionViaProveedor_. When set to true, ContDiotTiposOperacionCollectionViaProveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposOperacionCollectionViaProveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposOperacionCollectionViaProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposOperacionCollectionViaProveedor_ As Boolean
			Get
				Return _alwaysFetchContDiotTiposOperacionCollectionViaProveedor_
			End Get
			Set
				_alwaysFetchContDiotTiposOperacionCollectionViaProveedor_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposTercerosCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposTercerosCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Get
				Return GetMultiContDiotTiposTercerosCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposTercerosCollectionViaProveedor. When set to true, ContDiotTiposTercerosCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposTercerosCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposTercerosCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposTercerosCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchContDiotTiposTercerosCollectionViaProveedor
			End Get
			Set
				_alwaysFetchContDiotTiposTercerosCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposTercerosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposTercerosCollectionViaProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposTercerosCollectionViaProveedor_]() As Integralab.ORM.CollectionClasses.ContDiotTiposTercerosCollection
			Get
				Return GetMultiContDiotTiposTercerosCollectionViaProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposTercerosCollectionViaProveedor_. When set to true, ContDiotTiposTercerosCollectionViaProveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposTercerosCollectionViaProveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposTercerosCollectionViaProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposTercerosCollectionViaProveedor_ As Boolean
			Get
				Return _alwaysFetchContDiotTiposTercerosCollectionViaProveedor_
			End Get
			Set
				_alwaysFetchContDiotTiposTercerosCollectionViaProveedor_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiComicionistaCollectionViaMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ComicionistaCollectionViaMfacCatClientes]() As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Get
				Return GetMultiComicionistaCollectionViaMfacCatClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ComicionistaCollectionViaMfacCatClientes. When set to true, ComicionistaCollectionViaMfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ComicionistaCollectionViaMfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiComicionistaCollectionViaMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchComicionistaCollectionViaMfacCatClientes As Boolean
			Get
				Return _alwaysFetchComicionistaCollectionViaMfacCatClientes
			End Get
			Set
				_alwaysFetchComicionistaCollectionViaMfacCatClientes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ComicionistaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiComicionistaCollectionViaMfacCatClientes_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ComicionistaCollectionViaMfacCatClientes_]() As Integralab.ORM.CollectionClasses.ComicionistaCollection
			Get
				Return GetMultiComicionistaCollectionViaMfacCatClientes_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ComicionistaCollectionViaMfacCatClientes_. When set to true, ComicionistaCollectionViaMfacCatClientes_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ComicionistaCollectionViaMfacCatClientes_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiComicionistaCollectionViaMfacCatClientes_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchComicionistaCollectionViaMfacCatClientes_ As Boolean
			Get
				Return _alwaysFetchComicionistaCollectionViaMfacCatClientes_
			End Get
			Set
				_alwaysFetchComicionistaCollectionViaMfacCatClientes_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizasModeloCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizasModeloCabCollectionViaPolizasModeloDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizasModeloCabCollectionViaPolizasModeloDet]() As Integralab.ORM.CollectionClasses.PolizasModeloCabCollection
			Get
				Return GetMultiPolizasModeloCabCollectionViaPolizasModeloDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizasModeloCabCollectionViaPolizasModeloDet. When set to true, PolizasModeloCabCollectionViaPolizasModeloDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizasModeloCabCollectionViaPolizasModeloDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizasModeloCabCollectionViaPolizasModeloDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet As Boolean
			Get
				Return _alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet
			End Get
			Set
				_alwaysFetchPolizasModeloCabCollectionViaPolizasModeloDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaCuenta. When set to true, TipoMonedaCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaCuenta
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'BancosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBancosCollectionViaCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [BancosCollectionViaCuenta]() As Integralab.ORM.CollectionClasses.BancosCollection
			Get
				Return GetMultiBancosCollectionViaCuenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for BancosCollectionViaCuenta. When set to true, BancosCollectionViaCuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time BancosCollectionViaCuenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiBancosCollectionViaCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBancosCollectionViaCuenta As Boolean
			Get
				Return _alwaysFetchBancosCollectionViaCuenta
			End Get
			Set
				_alwaysFetchBancosCollectionViaCuenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ConceptoFlujoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas]() As Integralab.ORM.CollectionClasses.ConceptoFlujoCollection
			Get
				Return GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas. When set to true, UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas As Boolean
			Get
				Return _alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas
			End Get
			Set
				_alwaysFetchUsrConConceptosFlujoCollectionViaUsrConConceptosFlujoCuentas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaPolizaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaPolizaDetalle]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaPolizaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaPolizaDetalle. When set to true, PolizaCollectionViaPolizaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaPolizaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaPolizaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaPolizaDetalle As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaPolizaDetalle
			End Get
			Set
				_alwaysFetchPolizaCollectionViaPolizaDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasCabCollection
			Get
				Return GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet. When set to true, UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasCabCollectionViaUsrCxpfacturasDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet
			End Get
			Set
				_alwaysFetchUsrCxpfacturasCabCollectionViaUsrCxpfacturasDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaEntrada]() As CuentaContableEntity
			Get
				Return GetSingleCuentaEntrada(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaEntrada(value)
				Else
					If value Is Nothing Then
						If Not _cuentaEntrada Is Nothing Then
							_cuentaEntrada.UnsetRelatedEntity(Me, "CuentaContable")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CuentaContable")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaEntrada. When set to true, CuentaEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaEntrada is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaEntrada As Boolean
			Get
				Return _alwaysFetchCuentaEntrada
			End Get
			Set
				_alwaysFetchCuentaEntrada = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaEntrada is not found
		''' in the database. When set to true, CuentaEntrada will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaEntradaReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaEntradaReturnsNewIfNotFound
			End Get
			Set
				_cuentaEntradaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaSalida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaSalida]() As CuentaContableEntity
			Get
				Return GetSingleCuentaSalida(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaSalida(value)
				Else
					If value Is Nothing Then
						If Not _cuentaSalida Is Nothing Then
							_cuentaSalida.UnsetRelatedEntity(Me, "CuentaContable_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CuentaContable_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaSalida. When set to true, CuentaSalida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaSalida is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaSalida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaSalida As Boolean
			Get
				Return _alwaysFetchCuentaSalida
			End Get
			Set
				_alwaysFetchCuentaSalida = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaSalida is not found
		''' in the database. When set to true, CuentaSalida will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaSalidaReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaSalidaReturnsNewIfNotFound
			End Get
			Set
				_cuentaSalidaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaPadre()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaPadre]() As CuentaContableEntity
			Get
				Return GetSingleCuentaPadre(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaPadre(value)
				Else
					If value Is Nothing Then
						If Not _cuentaPadre Is Nothing Then
							_cuentaPadre.UnsetRelatedEntity(Me, "CuentasHijas")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CuentasHijas")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaPadre. When set to true, CuentaPadre is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaPadre is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaPadre(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaPadre As Boolean
			Get
				Return _alwaysFetchCuentaPadre
			End Get
			Set
				_alwaysFetchCuentaPadre = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaPadre is not found
		''' in the database. When set to true, CuentaPadre will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaPadreReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaPadreReturnsNewIfNotFound
			End Get
			Set
				_cuentaPadreReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CuentaContableEntity)
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
