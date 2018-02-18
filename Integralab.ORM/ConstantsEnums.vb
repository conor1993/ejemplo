' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 11:55:37
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System

Namespace Integralab.ORM

	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AcumuladoCuentasContables.
	''' </summary>
	Public Enum AcumuladoCuentasContablesFieldIndex
		[Codigo]
		[Ejercicio]
		[SaldoIniEjer]
		[Cargos01]
		[Cargos02]
		[Cargos03]
		[Cargos04]
		[Cargos05]
		[Cargos06]
		[Cargos07]
		[Cargos08]
		[Cargos09]
		[Cargos10]
		[Cargos11]
		[Cargos12]
		[Abonos01]
		[Abonos02]
		[Abonos03]
		[Abonos04]
		[Abonos05]
		[Abonos06]
		[Abonos07]
		[Abonos08]
		[Abonos09]
		[Abonos10]
		[Abonos11]
		[Abonos12]
		[Presup01]
		[Presup02]
		[Presup03]
		[Presup04]
		[Presup05]
		[Presup06]
		[Presup07]
		[Presup08]
		[Presup09]
		[Presup10]
		[Presup11]
		[Presup12]
		[SaldoFinEjer]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Almacen.
	''' </summary>
	Public Enum AlmacenFieldIndex
		[AlmacenId]
		[Descripcion]
		[DescripcionCorta]
		[TipoAlmacen]
		[Almacen]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[Plaza]
		[Letra]
		[IdCuentaContable]
		[TipoProducto]
		[Tercero]
		[IdCliente]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AlmacenCatalogo.
	''' </summary>
	Public Enum AlmacenCatalogoFieldIndex
		[IdCodAlmacen]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[IdCodTipoAlmacen]
		[CtaMay]
		[SubCta]
		[SsbCta]
		[SssCta]
		[Propio]
		[IdCliente]
		[Consecutivo]
		[LetraSerie]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AlmacenesFamilias.
	''' </summary>
	Public Enum AlmacenesFamiliasFieldIndex
		[CodigoAlmacen]
		[CodigoLinea]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AlmacenesSucursal.
	''' </summary>
	Public Enum AlmacenesSucursalFieldIndex
		[SucursalId]
		[AlmacenId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AlmacenSucursal.
	''' </summary>
	Public Enum AlmacenSucursalFieldIndex
		[SucursalId]
		[AlmacenId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AplicMedi.
	''' </summary>
	Public Enum AplicMediFieldIndex
		[FolAplicMedi]
		[IdAlmacen]
		[IdUsuarioAlta]
		[IdusuarioCancelacion]
		[FolioMovimientoAlmacen]
		[FolioMovimientoAlmacenCancelacion]
		[FechaAplicacionMedicamento]
		[FechaCancelacion]
		[FechaContabilizacion]
		[FechaCaptura]
		[TotalCabezas]
		[TotalKilos]
		[CostoTotal]
		[NumPoliza]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AplicMediDet.
	''' </summary>
	Public Enum AplicMediDetFieldIndex
		[FolioAplicacionMedicamento]
		[IdLote]
		[IdMedicamento]
		[IdCorral]
		[BooTrab]
		[BooReim]
		[Cantidad]
		[CosProm]
		[Cabezas]
		[Kilos]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AplicMediDetDet.
	''' </summary>
	Public Enum AplicMediDetDetFieldIndex
		[FolioAplicacionMedicamento]
		[IdLote]
		[IdMedicamento]
		[IdCorral]
		[AretePropio]
		[Cantidad]
		[Costo]
		[Kilos]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AutCreditoEmb.
	''' </summary>
	Public Enum AutCreditoEmbFieldIndex
		[FolioEmbarque]
		[Fecha]
		[Usuario]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AutorizaProcesos.
	''' </summary>
	Public Enum AutorizaProcesosFieldIndex
		[EmpresaId]
		[Usrndx]
		[CambiarPrecioFacturacion]
		[CancelarFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Bancos.
	''' </summary>
	Public Enum BancosFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[UsuarioAlta]
		[FechaAlta]
		[UsuarioBaja]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[BncCveSat]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Beneficiario.
	''' </summary>
	Public Enum BeneficiarioFieldIndex
		[Codigo]
		[CodigoProveedor]
		[Beneficiario]
		[Estatus]
		[EsProveedor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BitacoraFolio.
	''' </summary>
	Public Enum BitacoraFolioFieldIndex
		[Id]
		[UsuarioId]
		[Fecha]
		[Folioanterior]
		[Folionuevo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BitacoraPv.
	''' </summary>
	Public Enum BitacoraPvFieldIndex
		[IdBitacora]
		[Fecha]
		[Forma]
		[Evento]
		[Usuario]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabAplFor.
	''' </summary>
	Public Enum CabAplForFieldIndex
		[FolAplF]
		[FechaAplicacion]
		[FechaContabilizacion]
		[FolPoliza]
		[Costo]
		[IdUsuarioAlta]
		[IdUsuarioCancelacion]
		[FechaCaptura]
		[FechaCancelacion]
		[Estatus]
		[Cabezas]
		[FolioMovimientoAlmacen]
		[FolioMovimientoAlmacenCancelacion]
		[IdAlmacen]
		[TotalServidas]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabBalance.
	''' </summary>
	Public Enum CabBalanceFieldIndex
		[CveBalance]
		[NomBalance]
		[Saldo]
		[IdAgrupador]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabEdoRes.
	''' </summary>
	Public Enum CabEdoResFieldIndex
		[CveEdoRes]
		[NomEdoRes]
		[SaldoMes]
		[SaldoAcum]
		[IdAgrupador]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabFacturas.
	''' </summary>
	Public Enum CabFacturasFieldIndex
		[FolFactura]
		[FecFactura]
		[FecCaptura]
		[Referencia]
		[CveUs]
		[TipoFactu]
		[CveCliente]
		[StaFacturacion]
		[DiasCred]
		[FecVenci]
		[SubTotal]
		[ImpteDescto]
		[ImpteIva]
		[Status]
		[MotivoCancel]
		[FecConta]
		[FolPoliza]
		[FecCancelacion]
		[FecCanConta]
		[FolCanPoliza]
		[Cabezas]
		[Kilos]
		[PtjIva]
		[Uuid]
		[LugarExpedicion]
		[FormaPago]
		[MetodoPago]
		[NumCta]
		[UsoCfdi]
		[Direccion]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabGasTrans.
	''' </summary>
	Public Enum CabGasTransFieldIndex
		[FolRecep]
		[FecRecep]
		[CveChofer]
		[CveVehiculo]
		[ImpteIva]
		[ImpteTotal]
		[FecConta]
		[NumPoliza]
		[Status]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabMediReim.
	''' </summary>
	Public Enum CabMediReimFieldIndex
		[CveMedi]
		[NomMedi]
		[BooXcab]
		[BooXkilo]
		[Unidad]
		[Unidades]
		[UniXkilo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabMediTrab.
	''' </summary>
	Public Enum CabMediTrabFieldIndex
		[CveMedi]
		[NomMedi]
		[BooXcab]
		[BooXkilo]
		[Unidad]
		[Unidades]
		[UniXkilo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabMovGan.
	''' </summary>
	Public Enum CabMovGanFieldIndex
		[FolMovGan]
		[FecMovGan]
		[CveMovGan]
		[CveGanadera]
		[FecConta]
		[FolPoliza]
		[StaMov]
		[CostoTotal]
		[FolRefere]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabPrepForm.
	''' </summary>
	Public Enum CabPrepFormFieldIndex
		[FolPrepForm]
		[IdPlaza]
		[FecPrepForm]
		[CveAlmacen]
		[CveFormula]
		[CantaPreparar]
		[CantRealaPrep]
		[CveMovAlm]
		[CostoTotal]
		[Observaciones]
		[FecConta]
		[NumPoliza]
		[FecCancela]
		[RefCancela]
		[Estatus]
		[FolioMovimientoAlmacenEntradaFormula]
		[FolioMovimientoAlmacenCancelacionEntradaFormula]
		[IdEnvase]
		[FolioMovimientoAlmacenSalidaIngredientes]
		[FolioMovimientoAlmacenCancelacionSalidaIngredientes]
		[CantidadEnvase]
		[Lote]
		[FechaCaducidad]
		[IdUsuarioAlta]
		[IdUsuarioCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabProMed.
	''' </summary>
	Public Enum CabProMedFieldIndex
		[FolioProrrateoMedicamento]
		[IdAlmacen]
		[IdUsuarioAlta]
		[FolioMovimientoAlmacenSalida]
		[NumPoliza]
		[FechaProrrateo]
		[FechaCaptura]
		[FechaContabilizacion]
		[CostoTotal]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabRecCor.
	''' </summary>
	Public Enum CabRecCorFieldIndex
		[FolMov]
		[FecMov]
		[CveCorRec]
		[CveCorDes]
		[CveLoteDes]
		[Cabezas]
		[Kilos]
		[CostoEntRec]
		[ImpteAlimRec]
		[KilosAlimRec]
		[ImpteMedRec]
		[CostoxKilo]
		[CostoMovto]
		[FecConta]
		[FolPoliza]
		[StaMov]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CabRegCom.
	''' </summary>
	Public Enum CabRegComFieldIndex
		[FolRecep]
		[FecRecep]
		[CveProveGan]
		[CveLugCom]
		[CveComiGan]
		[NumGuias]
		[ImpteXguia]
		[HorasViaje]
		[ImptePredial]
		[BooPredial]
		[ImpteEduc]
		[BooEduc]
		[PesoEntReal]
		[CabezasComp]
		[KilosComp]
		[ImpteComp]
		[Observaciones]
		[StaCerrado]
		[CveCorral]
		[DiasCredito]
		[FecPago]
		[NumFactura]
		[NomBanco]
		[NomSucursal]
		[NumCuenta]
		[FecConta]
		[NumPoliza]
		[ComiXcab]
		[Status]
		[CostosIndi]
		[FolFactura]
		[FechaCaptura]
		[FolioRecepcionPesada]
		[FolioMovimientoGanado]
		[FolioMovimientoGanadoCancelacion]
		[TipoComision]
		[FechaCancelacion]
		[IdUsuarioCancelacion]
		[IdUsuarioAlta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatAgrupadoresBalGralEdoRes.
	''' </summary>
	Public Enum CatAgrupadoresBalGralEdoResFieldIndex
		[Código]
		[Descripcion]
		[BalanceGral]
		[Prioridad]
		[EsActivo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatDeptos.
	''' </summary>
	Public Enum CatDeptosFieldIndex
		[CveDepto]
		[NomDepto]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatIntroductores.
	''' </summary>
	Public Enum CatIntroductoresFieldIndex
		[IdIntroductor]
		[Nombre]
		[ApellidoPaterno]
		[ApellidoMaterno]
		[Rfc]
		[FechaUltimaIntGanado]
		[CantCabUltimaIntGanado]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatLugaresDeCompra.
	''' </summary>
	Public Enum CatLugaresDeCompraFieldIndex
		[IdLugarCompra]
		[Descripcion]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[Estatus]
		[HorasTransporte]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatLugCom.
	''' </summary>
	Public Enum CatLugComFieldIndex
		[Codigo]
		[IdPoblacion]
		[Descripcion]
		[Domicilio]
		[HorasViaje]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatMovGan.
	''' </summary>
	Public Enum CatMovGanFieldIndex
		[CveMovGan]
		[NomMovGan]
		[StaTipoMov]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatMovimientosAlmacenPv.
	''' </summary>
	Public Enum CatMovimientosAlmacenPvFieldIndex
		[IdMov]
		[Descripcion]
		[DescripcionCorta]
		[AfectaCosto]
		[Direccion]
		[Estatus]
		[FechaAlta]
		[UsuarioAltaId]
		[FechaBaja]
		[UsuarioBajaId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatNutrientes.
	''' </summary>
	Public Enum CatNutrientesFieldIndex
		[CveNutriente]
		[NomNutriente]
		[Unidad]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatPrexCort.
	''' </summary>
	Public Enum CatPrexCortFieldIndex
		[CveCliente]
		[CveDestino]
		[CveCorte]
		[CveSubCorte]
		[PrecioxKgr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatPrexProd.
	''' </summary>
	Public Enum CatPrexProdFieldIndex
		[CveCliente]
		[CveDestino]
		[CveProdRas]
		[PrecioxKgr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatProveedores.
	''' </summary>
	Public Enum CatProveedoresFieldIndex
		[IdProveedor]
		[Nombre]
		[Rfc]
		[TipoProveedor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatRastros.
	''' </summary>
	Public Enum CatRastrosFieldIndex
		[IdRastro]
		[Descripcion]
		[DescCorta]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CatTipNotas.
	''' </summary>
	Public Enum CatTipNotasFieldIndex
		[CveTipNota]
		[NomTipNota]
		[IdCuentaContable]
		[FehaAlta]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CfgCtrlCtas.
	''' </summary>
	Public Enum CfgCtrlCtasFieldIndex
		[IdConCfgCtas]
		[IdCuentaContable]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Cheque.
	''' </summary>
	Public Enum ChequeFieldIndex
		[CuentaId]
		[Folio]
		[Medio]
		[BeneficiarioId]
		[PolizaId]
		[CuentaDestinoId]
		[Origen]
		[TipoMovimiento]
		[FechaMovimiento]
		[FechaDocumento]
		[FechaEmision]
		[FechaCancelacion]
		[Concepto]
		[Emitido]
		[Anticipo]
		[Resguardo]
		[Importe]
		[TipoCambio]
		[Estatus]
		[PeriodoId]
		[PolizaIdCancelacion]
		[Entregado]
		[FechaEntrega]
		[Referencia]
		[CodBanco]
		[CuentaDestinoReceptor]
		[CodBancoDestino]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChequeDevuelto.
	''' </summary>
	Public Enum ChequeDevueltoFieldIndex
		[IdChequeDevuelto]
		[NoCheque]
		[IdBanco]
		[IdCliente]
		[FechaCaptura]
		[FechaDevolucion]
		[Recibio]
		[Observaciones]
		[Importe]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChequesPos.
	''' </summary>
	Public Enum ChequesPosFieldIndex
		[CveCliente]
		[FecCaptura]
		[NumCheque]
		[CveBanCte]
		[ImpteCheque]
		[FecCobro]
		[FolCobro]
		[CveUser]
		[Estatus]
		[BooAplicar]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CierreFicticio.
	''' </summary>
	Public Enum CierreFicticioFieldIndex
		[IdLote]
		[FechaInicio]
		[FechaCierreFic]
		[DiasCabeza]
		[KilosAlimento]
		[PesoEntrada]
		[PesoActual]
		[PesoPromEstimado]
		[CostoEntrada]
		[CostoAlimento]
		[CostoMedicina]
		[CostosIndirectos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CierreLote.
	''' </summary>
	Public Enum CierreLoteFieldIndex
		[IdCierreLote]
		[IdLote]
		[DiasCabezas]
		[Gdp]
		[Eca]
		[Cki]
		[FecCierre]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Ciudad.
	''' </summary>
	Public Enum CiudadFieldIndex
		[CodigoEstado]
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ClasificadorDeEstadosFinancieros.
	''' </summary>
	Public Enum ClasificadorDeEstadosFinancierosFieldIndex
		[Codigo]
		[Descripcion]
		[Detalle]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Cliente.
	''' </summary>
	Public Enum ClienteFieldIndex
		[Codigo]
		[Nombres]
		[ApellidoPaterno]
		[ApellidoMaterno]
		[UsuarioAlta]
		[FechaAlta]
		[FechaCaptura]
		[PersonaFisica]
		[Estatus]
		[Rfc]
		[CodigoZona]
		[CodigoPlaza]
		[ListaPrecios]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[UsuarioBaja]
		[EsComprador]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Comicionista.
	''' </summary>
	Public Enum ComicionistaFieldIndex
		[Codigo]
		[Nombre]
		[Apaterno]
		[Amaterno]
		[Plaza]
		[TipoComisionista]
		[FechaAlta]
		[Domicilio]
		[Colonia]
		[CodigoPostal]
		[Estado]
		[Ciudad]
		[Poblacion]
		[Email]
		[Zona]
		[LadaTel1]
		[LadaTel2]
		[LadaFax]
		[Telefono1]
		[Telefono2]
		[Fax]
		[Rfc]
		[Estatus]
		[IdCuentaContable]
		[Porcentaje]
		[Sueldo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConceptoCaja.
	''' </summary>
	Public Enum ConceptoCajaFieldIndex
		[IdConCaja]
		[Tipo]
		[Concepto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConceptoFlujo.
	''' </summary>
	Public Enum ConceptoFlujoFieldIndex
		[Codigo]
		[NombreCorto]
		[Nombre]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConceptoFlujoCuenta.
	''' </summary>
	Public Enum ConceptoFlujoCuentaFieldIndex
		[ConceptoFlujoId]
		[CuentaContableId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConCfgCtas.
	''' </summary>
	Public Enum ConCfgCtasFieldIndex
		[IdConCfgCtas]
		[Concepto]
		[Afectable]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CondicionesPago.
	''' </summary>
	Public Enum CondicionesPagoFieldIndex
		[IdCondicionPago]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConfigGan.
	''' </summary>
	Public Enum ConfigGanFieldIndex
		[IdConfiguracion]
		[TipoCambio]
		[FactorConver]
		[IdTipoAlmacenFormula]
		[IdTipoAlmacenRolado]
		[IdTipoAlmacenMedicamento]
		[Gdpini]
		[ImptePredial]
		[PtjEduca]
		[FecCieEng]
		[CosIndMen]
		[MesCosInd]
		[CveDepGana]
		[CveMovSalMat]
		[IdFamiliaMedicamento]
		[RequerirArete]
		[TransferirRecibaPorArete]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConfigPuntoVta.
	''' </summary>
	Public Enum ConfigPuntoVtaFieldIndex
		[AltaProdNv]
		[ModPrecioNv]
		[ActualListaPrecioNv]
		[ControlTurnoAutom]
		[CodCtePublicoGral]
		[ConceptoPagoFactura]
		[CodSucursal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConfiguracionChequesImp.
	''' </summary>
	Public Enum ConfiguracionChequesImpFieldIndex
		[Codigo]
		[IdBanco]
		[FechaImpCol]
		[FechaImpRen]
		[BeneficiarioImpCol]
		[BeneficiarioImpRen]
		[ImporteImpCol]
		[ImporteImpRen]
		[ImporteConLetraImpCol]
		[ImporteConLetraImpRen]
		[FechaCopiaImpCol]
		[FechaCopiaImpRen]
		[BeneficiarioCopiaImpCol]
		[BeneficiarioCopiaImpRen]
		[ImporteCopiaImpCol]
		[ImporteCopiaImpRen]
		[ImporteConLetraCopiaImpCol]
		[ImporteConLetraCopiaImpRen]
		[CuentaImpCol]
		[CuentaImpRen]
		[SubCtaImpCol]
		[SubCtaImpRen]
		[SubSubCtaImpCol]
		[SubSubCtaImpRen]
		[SubSubSubCtaImpCol]
		[SubSubSubCtaImpRen]
		[DescripcionImpCol]
		[DescripcionImpRen]
		[CargoImpCol]
		[CargoImpRen]
		[AbonoImpCol]
		[AbonoImpRen]
		[AbonoAcuentaImpCol]
		[AbonoAcuentaImpRen]
		[ImprimirCuentaConcentrada]
		[ImprimirCuentaDetallada]
		[ConceptoImpCol]
		[ConceptoImpRen]
		[AbonoAcuentaCopiaImpCol]
		[AbonoAcuentaCopiaImpRen]
		[FolioChequeImpCol]
		[FolioChequeImpRen]
		[FolioChequeCopiaImpCol]
		[FolioChequeCopiaImpRen]
		[CargoTotalImpCol]
		[CargoTotalImpRen]
		[AbonoTotalImpCol]
		[AbonoTotalImpRen]
		[BancoImpCol]
		[BancoImpRen]
		[CuentaBancoImpCol]
		[CuentaBancoImpRen]
		[ChequeImpCol]
		[ChequeImpRen]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConfiguracionFactura.
	''' </summary>
	Public Enum ConfiguracionFacturaFieldIndex
		[IdConfiguracion]
		[Campo1X]
		[Campo1Y]
		[Campo2X]
		[Campo2Y]
		[Campo3X]
		[Campo3Y]
		[Campo4X]
		[Campo4Y]
		[Campo5X]
		[Campo5Y]
		[Campo6X]
		[Campo6Y]
		[Campo7X]
		[Campo7Y]
		[Campo8X]
		[Campo8Y]
		[Campo9X]
		[Campo9Y]
		[Campo10X]
		[Campo10Y]
		[Campo11X]
		[Campo11Y]
		[Campo12X]
		[Campo12Y]
		[Campo13X]
		[Campo13Y]
		[Campo14X]
		[Campo14Y]
		[Campo15X]
		[Campo15Y]
		[Campo16X]
		[Campo16Y]
		[Campo17X]
		[Campo17Y]
		[Campo18X]
		[Campo18Y]
		[Campo19X]
		[Campo19Y]
		[Campo20X]
		[Campo20Y]
		[TipoLetra]
		[Tamaño]
		[RenglonesEnDetalle]
		[Descripcion]
		[LetrasXrenglonDelTotalEnLetra]
		[LetrasXrenglonDomicilio]
		[FechaUltimaModificacion]
		[IdUsuarioAlta]
		[IdUsuarioUltimaModificacion]
		[Serie]
		[LetrasXrenglonCliente]
		[LetrasXrenglonDelTotalEnLetraPagare]
		[DatosClienteCpC]
		[DatosClienteCpR]
		[DatosFacturaObsrvC]
		[DatosFacturaObsrvR]
		[LetrasxRenglonObsrv]
		[DatosFacturaReferenciaC]
		[DatosFacturaReferenciaR]
		[LetrasxRenglonReferencia]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConfiguracionLecturaEtiqueta.
	''' </summary>
	Public Enum ConfiguracionLecturaEtiquetaFieldIndex
		[IdCodigo]
		[CodigoColumnaInicial]
		[CodigoLongitud]
		[PiezasColumnaInicial]
		[PiezasLongitud]
		[KilosColumnaInicial]
		[KilosLongitud]
		[FechaColumnaInicial]
		[FechaLongitud]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConLotSac.
	''' </summary>
	Public Enum ConLotSacFieldIndex
		[IdConLotSac]
		[IdSalidaGanadoRastro]
		[RemanCabe]
		[RemanKilos]
		[SacrifCabe]
		[SacrifKilos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ConMes.
	''' </summary>
	Public Enum ConMesFieldIndex
		[NumYear]
		[NumMes]
		[Abierto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContDiotTiposOperacion.
	''' </summary>
	Public Enum ContDiotTiposOperacionFieldIndex
		[CodDiot]
		[ClaveHacienda]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContDiotTiposTerceros.
	''' </summary>
	Public Enum ContDiotTiposTercerosFieldIndex
		[CodDiot]
		[ClaveHacienda]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ControlTurno.
	''' </summary>
	Public Enum ControlTurnoFieldIndex
		[Id]
		[CodSucursal]
		[CodUsuario]
		[CodCaja]
		[FechaInicio]
		[FechaFin]
		[FondoInicial]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CostoIndirecto.
	''' </summary>
	Public Enum CostoIndirectoFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[CtaMayor]
		[Scta]
		[Sscta]
		[Ssscta]
		[DescripcionCuenta]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CostoProducto.
	''' </summary>
	Public Enum CostoProductoFieldIndex
		[ProductoId]
		[UltimoCosto]
		[UltimoProveedorId]
		[FechaUltimoCosto]
		[Costo]
		[ProveedorId]
		[FechaActualizacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CostoProductoProveedor.
	''' </summary>
	Public Enum CostoProductoProveedorFieldIndex
		[Producto]
		[Proveedor]
		[Costo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CotizacionServicio.
	''' </summary>
	Public Enum CotizacionServicioFieldIndex
		[Folio]
		[SucursalId]
		[ProveedorId]
		[Observaciones]
		[FechaAlta]
		[UsuarioAlta]
		[UsuarioCancelacion]
		[MotivoCancelacionId]
		[FechaCancelacion]
		[ObservacionesCancelacion]
		[Estatus]
		[OrdenServicioGenerada]
		[SubTotal]
		[Iva]
		[Descuento]
		[Total]
		[TipoMonedaId]
		[FolioOrdenServicio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CotizacionServicioDetalle.
	''' </summary>
	Public Enum CotizacionServicioDetalleFieldIndex
		[FolioCotizacion]
		[FolioSolicitud]
		[Indice]
		[Cantidad]
		[Costo]
		[Estatus]
		[Descuento]
		[Iva]
		[Total]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Cuenta.
	''' </summary>
	Public Enum CuentaFieldIndex
		[Codigo]
		[CuentacontableId]
		[EmpresaId]
		[BancoId]
		[TipomonedaId]
		[Folioactual]
		[Cuenta]
		[Descripcion]
		[Cuentahabiente]
		[Saldoinicial]
		[Saldodiaant]
		[Saldoreal]
		[Saldoactual]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CuentaContable.
	''' </summary>
	Public Enum CuentaContableFieldIndex
		[Codigo]
		[Cta]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[NomCuenta]
		[Naturaleza]
		[NumeroHijos]
		[CtaPadre]
		[CtaEnt]
		[CtaSal]
		[SaldoAnoAnt]
		[SaldoIniEjerc]
		[BooResultad]
		[BooPresup]
		[BooAfectable]
		[BooInactiva]
		[BooDepta]
		[BooBancos]
		[Titulo]
		[SubTitulo]
		[CodAgrupSat]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CuentasFiscal.
	''' </summary>
	Public Enum CuentasFiscalFieldIndex
		[Codigo]
		[Cta]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[NomCuenta]
		[Naturaleza]
		[NumeroHijos]
		[CtaPadre]
		[CtaEnt]
		[CtaSal]
		[SaldoAnoAnt]
		[SaldoIniEjerc]
		[BooResultad]
		[BooPresup]
		[BooAfectable]
		[BooInactiva]
		[BooDepta]
		[BooBancos]
		[Cargos01]
		[Cargos02]
		[Cargos03]
		[Cargos04]
		[Cargos05]
		[Cargos06]
		[Cargos07]
		[Cargos08]
		[Cargos09]
		[Cargos10]
		[Cargos11]
		[Cargos12]
		[Abonos01]
		[Abonos02]
		[Abonos03]
		[Abonos04]
		[Abonos05]
		[Abonos06]
		[Abonos07]
		[Abonos08]
		[Abonos09]
		[Abonos10]
		[Abonos11]
		[Abonos12]
		[Presup01]
		[Presup02]
		[Presup03]
		[Presup04]
		[Presup05]
		[Presup06]
		[Presup07]
		[Presup08]
		[Presup09]
		[Presup10]
		[Presup11]
		[Presup12]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetAlimentos.
	''' </summary>
	Public Enum DetAlimentosFieldIndex
		[CveAlimento]
		[CveNutriente]
		[PtjNutriente]
		[CveRenglon]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetalleClasificadordeEstadosFinancieros.
	''' </summary>
	Public Enum DetalleClasificadordeEstadosFinancierosFieldIndex
		[Codigo]
		[CodigoClasificador]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetalleKitPv.
	''' </summary>
	Public Enum DetalleKitPvFieldIndex
		[IdKit]
		[IdProducto]
		[Cantidad]
		[Precio]
		[Iva]
		[Ieps]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetAplFor.
	''' </summary>
	Public Enum DetAplForFieldIndex
		[FolAplF]
		[CveLote]
		[CveCorral]
		[CveRenglon]
		[CveFormula]
		[Cabezas]
		[KilosxLote]
		[CantServ1]
		[CantServ2]
		[CantServ3]
		[CantServ4]
		[Costo]
		[Importe]
		[Servidas]
		[LoteAlmacen]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetBalance.
	''' </summary>
	Public Enum DetBalanceFieldIndex
		[CveBalance]
		[CveCuentaContable]
		[CveRenglon]
		[StaSumaResta]
		[CveCta]
		[CveSubCta]
		[CveSsubCta]
		[CveSssubCta]
		[Saldo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetDproMed.
	''' </summary>
	Public Enum DetDproMedFieldIndex
		[FolioProrrateoMedicamento]
		[IdLote]
		[IdMedicamento]
		[CostoXmedi]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetEdoRes.
	''' </summary>
	Public Enum DetEdoResFieldIndex
		[CveEdoRes]
		[CveRenglon]
		[StaSumaResta]
		[CuentaContableId]
		[SaldoMes]
		[SaldoAcum]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetFacturas.
	''' </summary>
	Public Enum DetFacturasFieldIndex
		[FolFactura]
		[CveRenglon]
		[FecFactura]
		[TipoFactu]
		[CveAlmacen]
		[CveProducto]
		[BooServicio]
		[CveGanado]
		[Cantidad]
		[Cabezas]
		[Kilos]
		[CostoUni]
		[PrecioUni]
		[PtjIva]
		[Status]
		[FecConta]
		[FolPoliza]
		[FecCancelacion]
		[CveCorral]
		[PrecioxKilo]
		[CostoxKilo]
		[Descripcion]
		[CveProdServ]
		[CveUnidad]
		[Iva]
		[Subtotal]
		[Total]
		[Unidad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetGasTrans.
	''' </summary>
	Public Enum DetGasTransFieldIndex
		[FolRecep]
		[CveRenglon]
		[CveGasto]
		[PtjIva]
		[ImpteGasto]
		[Retencion]
		[NoFactura]
		[CodProveedor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetMovGan.
	''' </summary>
	Public Enum DetMovGanFieldIndex
		[FolMovGan]
		[FecMovGan]
		[CveGanado]
		[CveMovGan]
		[CveGanadera]
		[Cabezas]
		[Kilos]
		[CostoxKilo]
		[IdDetMovGan]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetPrepForm.
	''' </summary>
	Public Enum DetPrepFormFieldIndex
		[FolPrepForm]
		[CveProducto]
		[IdPlaza]
		[PtjFormula]
		[KgrsFormula]
		[KgrsSalida]
		[CostoUni]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetPrepFormLote.
	''' </summary>
	Public Enum DetPrepFormLoteFieldIndex
		[FolPrepForm]
		[CveProducto]
		[Lote]
		[IdPlaza]
		[Cantidad]
		[CostoUni]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetProMed.
	''' </summary>
	Public Enum DetProMedFieldIndex
		[FolioProrrateoMedicamento]
		[IdMedicamento]
		[CostoProm]
		[Cantidad]
		[CostoXcab]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetRecCor.
	''' </summary>
	Public Enum DetRecCorFieldIndex
		[FolMov]
		[FecMov]
		[CveCorRec]
		[CveCorDes]
		[CveLoteDes]
		[CveGanado]
		[Cabezas]
		[Kilos]
		[CostoxKilo]
		[Aresiniiga]
		[Aretransporte]
		[Arepropio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DetRegCom.
	''' </summary>
	Public Enum DetRegComFieldIndex
		[FolRecep]
		[CveRenglon]
		[CveGanado]
		[CantCabezas]
		[CantKilos]
		[PrecioXkilo]
		[CantKilosRecibidos]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DevolucionProductos.
	''' </summary>
	Public Enum DevolucionProductosFieldIndex
		[Folio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[Embarque]
		[IdCliente]
		[UtilparaVenta]
		[EnCaja]
		[IdFolioEtiqueta]
		[FolioMovimientoAlmacen]
		[FolioMovimeintoAlmacenCancelacion]
		[FechaCaptura]
		[FechaCancelacion]
		[IdUsuarioAlta]
		[IdUsuarioCancelacion]
		[IdMotivoDevolucion]
		[Estatus]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Documento.
	''' </summary>
	Public Enum DocumentoFieldIndex
		[IdDocumento]
		[IdDocumentoTipo]
		[Descripcion]
		[Medida]
		[PaginaWidth]
		[PaginaHeight]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DocumentoDetalle.
	''' </summary>
	Public Enum DocumentoDetalleFieldIndex
		[IdDocumento]
		[IdDocumentoDetalle]
		[IdDocumentoDato]
		[EsImagen]
		[X]
		[Y]
		[Fuente]
		[TamanoFuente]
		[Color]
		[Orientacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DocumentoImagen.
	''' </summary>
	Public Enum DocumentoImagenFieldIndex
		[IdDocumentoImagen]
		[Imagen]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DocumentoTexto.
	''' </summary>
	Public Enum DocumentoTextoFieldIndex
		[IdDocumentoTexto]
		[Texto]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DocumentoTipo.
	''' </summary>
	Public Enum DocumentoTipoFieldIndex
		[IdDocumentoTipo]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DocumentoTipoCampo.
	''' </summary>
	Public Enum DocumentoTipoCampoFieldIndex
		[IdDocumentoTipo]
		[IdDocumentoTipoCampo]
		[EsImagen]
		[Imagen]
		[Campo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DomicilioFiscal.
	''' </summary>
	Public Enum DomicilioFiscalFieldIndex
		[Codigo]
		[Rfc]
		[RazonSocial]
		[Domicilio]
		[Colonia]
		[CodigoPostal]
		[Estado]
		[Ciudad]
		[Poblacion]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MtivoBaja]
		[ObservacionesBaja]
		[EsPrincipal]
		[EsCliente]
		[Calle]
		[NoExterior]
		[NoInterior]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DomicilioFiscalesClientes.
	''' </summary>
	Public Enum DomicilioFiscalesClientesFieldIndex
		[Codigo]
		[Cliente]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ECtSatcatBancos.
	''' </summary>
	Public Enum ECtSatcatBancosFieldIndex
		[CveBco]
		[NomCorto]
		[NomRazonSocial]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Estado.
	''' </summary>
	Public Enum EstadoFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FacturaFolios.
	''' </summary>
	Public Enum FacturaFoliosFieldIndex
		[IdFacturaFolios]
		[FolioInicial]
		[NumFolios]
		[Consecutivo]
		[StaLetraSerie]
		[NoAprobacion]
		[AnoAprobacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FacturasClientesCab.
	''' </summary>
	Public Enum FacturasClientesCabFieldIndex
		[NoFactura]
		[IdCliente]
		[FechaFactura]
		[FechaCaptura]
		[FechaVencimiento]
		[Contado]
		[Credito]
		[SubTotal]
		[Iva]
		[Total]
		[Contabilizado]
		[IdPoliza]
		[FechaContabilizacion]
		[Estatus]
		[Observaciones]
		[FechaCancelacion]
		[IdUsuarioCancela]
		[IdClienteCargo]
		[TopoFactura]
		[FechaVencOriginal]
		[Serie]
		[FormaDePago]
		[CondicionesDePago]
		[MetodoDePago]
		[Uuid]
		[IdDomicilioFiscal]
		[Ieps]
		[Origen]
		[NumCtaPago]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FacturasClientesDet.
	''' </summary>
	Public Enum FacturasClientesDetFieldIndex
		[NoFactura]
		[IdCliente]
		[CtaMay]
		[SubCta]
		[SsbCta]
		[SssCta]
		[Importe]
		[CargoAbono]
		[SerieFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FacturasClientesDetProductosTotales.
	''' </summary>
	Public Enum FacturasClientesDetProductosTotalesFieldIndex
		[NoFactura]
		[IdProducto]
		[KilosEmbarcados]
		[KilosFacturados]
		[PrecioxKgr]
		[ImporteEmbarcado]
		[ImporteFacturado]
		[Renglon]
		[FolioEmbarque]
		[TipoProducto]
		[PrecioKgrReal]
		[IdUsuarioAutorizacionCambioPrecio]
		[Piezas]
		[NotaVenta]
		[SerieFactura]
		[Iva]
		[Ieps]
		[CveProdServSat]
		[CveUnidadSat]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Folio.
	''' </summary>
	Public Enum FolioFieldIndex
		[FolioNdx]
		[LpidPlaza]
		[LpidListaPrecios]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FolioFactura.
	''' </summary>
	Public Enum FolioFacturaFieldIndex
		[CodFolio]
		[Folio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: FormaPago.
	''' </summary>
	Public Enum FormaPagoFieldIndex
		[IdFormaPago]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: GastosDepartamentos.
	''' </summary>
	Public Enum GastosDepartamentosFieldIndex
		[IdPoliza]
		[IdSucursal]
		[IdMetodoProrrateo]
		[IdCuentaContable]
		[PtjImporte]
		[Importe]
		[FechaPoliza]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: HistorialCambiosFecha.
	''' </summary>
	Public Enum HistorialCambiosFechaFieldIndex
		[IdHistorial]
		[IdFolioEtiqueta]
		[FechaCorte]
		[FechaCaducidad]
		[FechaCaducidadNueva]
		[FechaEmpaqueNueva]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: IngresoCaja.
	''' </summary>
	Public Enum IngresoCajaFieldIndex
		[Id]
		[CodUsuario]
		[CodControlTurno]
		[CodCaja]
		[FechaHora]
		[Importe]
		[Estatus]
		[IdConcepto]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InventarioAlmacen.
	''' </summary>
	Public Enum InventarioAlmacenFieldIndex
		[AlmacenId]
		[ProductoId]
		[Año]
		[Mes]
		[FechaUltimoCosto]
		[UltimoCosto]
		[CostoPromedio]
		[CantidadInicial]
		[CantidadExistencia]
		[CantidadEntrada]
		[FechaUltimaEntrada]
		[CantidadSalidas]
		[FechaUltimaSalida]
		[CantidadPorSurtir]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: inventarioAlmacenLotes.
	''' </summary>
	Public Enum inventarioAlmacenLotesFieldIndex
		[AlmacenId]
		[ProductoId]
		[Lote]
		[Año]
		[Mes]
		[FechaUltimoCosto]
		[UltimoCosto]
		[CostoPromedio]
		[CantidadInicial]
		[CantidadExistencia]
		[CantidadEntrada]
		[FechaUltimaEntrada]
		[CantidadSalidas]
		[FechaUltimaSalida]
		[FechaCaducidad]
		[FechaAlta]
		[CantidadPorSurtir]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InventarioConfiguracion.
	''' </summary>
	Public Enum InventarioConfiguracionFieldIndex
		[Ndx]
		[ExInventarioInicial]
		[ExCompra]
		[ExDevolucionVenta]
		[ExTraspaso]
		[ExDevolucionConsumo]
		[ExConsignacion]
		[ExAjusteInventario]
		[ExOtros]
		[SxDevolucionCompra]
		[SxVenta]
		[SxTraspaso]
		[SxConsumo]
		[SxDevolucionConsignacion]
		[SxAjusteInventario]
		[SxOtros]
		[UsuarioId]
		[FechaConf]
		[Exmedicamento]
		[ExprocesoGranoRolado]
		[ExcancelacionSalidaGranoRolado]
		[ExregresoMedicamento]
		[ExcancelacionAplicacionFormula]
		[ExcancelacionAplicacionMedicamento]
		[SxaplicacionFormula]
		[SxaplicacionMedicamento]
		[SxcancelacionEntradaMedicamento]
		[SxcancelacionEntradaProcesoGranoRolado]
		[SxprocesoGranoRolado]
		[SxcancelacionRegresoMedicamento]
		[ExCancelacionTraspaso]
		[SxCancelacionTraspaso]
		[ExPreparaciionMezcla]
		[ExCancelacionSalidaXpreparacionMezcla]
		[SxPreparacionMezcla]
		[SxCancelacionEntradaXpreparacionMezcla]
		[ExCancelacionOtrasSalidas]
		[SxCancelacionOtrasEntradas]
		[SxcancelacionEntradaRecepcionConsignacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InventarioFisico.
	''' </summary>
	Public Enum InventarioFisicoFieldIndex
		[AlmacenId]
		[ProductoId]
		[Cantidad]
		[FechaInventario]
		[CantidadSistema]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InventarioMovimientoAlmacen.
	''' </summary>
	Public Enum InventarioMovimientoAlmacenFieldIndex
		[AlmacenId]
		[FolioMovimiento]
		[FechaMovimiento]
		[TipoMovimientoId]
		[CostoTotal]
		[Origen]
		[Referencia]
		[UsuarioId]
		[EstatusContabilizado]
		[FechaContabilizacion]
		[PolizaContabilidad]
		[Entrega]
		[Recibe]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InventarioMovimientoAlmacenDetalles.
	''' </summary>
	Public Enum InventarioMovimientoAlmacenDetallesFieldIndex
		[Indice]
		[AlmacenId]
		[FolioMovimiento]
		[ProductoId]
		[FechaMovimiento]
		[Cantidad]
		[Costo]
		[Descuento]
		[Lote]
		[CostoPromedioAnterior]
		[CostoPromedio]
		[IdCentroCosto]
		[CantidadUsada]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: InvHistorialPv.
	''' </summary>
	Public Enum InvHistorialPvFieldIndex
		[IdAlmacen]
		[IdProducto]
		[FechaInventario]
		[ExistenciaFisica]
		[ExistenciaSistema]
		[PrecioUnitario]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Linea.
	''' </summary>
	Public Enum LineaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionBaja]
		[LinPuntoVenta]
		[LinMeat]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ListadePrecios.
	''' </summary>
	Public Enum ListadePreciosFieldIndex
		[IdCliente]
		[IdPuntoEntrega]
		[IdProducto]
		[PrecioxKgr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ListaPrecio.
	''' </summary>
	Public Enum ListaPrecioFieldIndex
		[Plaza]
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Fecha]
		[Observaciones]
		[Vigencia]
		[DiasVigencia]
		[FechaVigenciaDe]
		[FechaVigenciaA]
		[EsListaBase]
		[Estatus]
		[FechaCaptura]
		[UsuarioAlta]
		[FechaCancela]
		[ObservacionesCancela]
		[UsuarioCancela]
		[MotivoCancelacion]
		[ListaBase]
		[LpidTipoVenta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ListaPrecioDetalle.
	''' </summary>
	Public Enum ListaPrecioDetalleFieldIndex
		[ListaPrecios]
		[Producto]
		[Costo]
		[Utilidad]
		[PrecioVentaC]
		[PrecioVentaP]
		[ComicionP]
		[ComicionC]
		[Estatus]
		[LpdporcDescto]
		[LpdimpDescto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Marca.
	''' </summary>
	Public Enum MarcaFieldIndex
		[Codigo]
		[DescripcionCorta]
		[Descripcion]
		[Estatus]
		[Observaciones]
		[UsuarioAlta]
		[FechaAlta]
		[UsuarioBaja]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionBaja]
		[McaPuntoVenta]
		[McaMeat]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McatCentroCostos.
	''' </summary>
	Public Enum McatCentroCostosFieldIndex
		[IdCentroCostoAlm]
		[IdPlaza]
		[Descripcion]
		[IdCuentaCont]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Mcattiposcliente.
	''' </summary>
	Public Enum McattiposclienteFieldIndex
		[Idtipocliente]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatCorralesCab.
	''' </summary>
	Public Enum McecatCorralesCabFieldIndex
		[IdCorral]
		[NombreCorral]
		[NomCorCorral]
		[IdTipoCorral]
		[Capacidad]
		[Superficie]
		[Observaciones]
		[Estatus]
		[FechaBaja]
		[MotivoBaja]
		[QuiendioBaja]
		[TipoCorral]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatCorralesDet.
	''' </summary>
	Public Enum McecatCorralesDetFieldIndex
		[IdCorral]
		[IdTipoGanado]
		[ExistCabezas]
		[ExistKilos]
		[CostoEnt]
		[ImpteMedicamento]
		[ImpteAlimento]
		[KilosAlimento]
		[FechaUltEnt]
		[FechaUltSal]
		[FechaUltReinicio]
		[SaldoCostoInd]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatLotesCab.
	''' </summary>
	Public Enum McecatLotesCabFieldIndex
		[IdLote]
		[IdCorral]
		[NombreLote]
		[NomCorLote]
		[FechaCaptura]
		[SaldoCabezas]
		[SaldoKilos]
		[SaldoKilosAlim]
		[SaldoImpteAlim]
		[SaldoImpteMed]
		[SaldoImpte]
		[AcumCabMuerte]
		[AcumKilosMuerte]
		[AcumImpteMuerte]
		[AcumEntCab]
		[AcumEntKilos]
		[AcumImpteAlim]
		[AcumKilosAlim]
		[AcumImpteMedic]
		[AcumSalCab]
		[AcumSalKilos]
		[AcumEntImpte]
		[CantSemReimplante]
		[Gdpini]
		[Gdp]
		[Eca]
		[Cki]
		[PesoEstimado]
		[FechaCierre]
		[Observaciones]
		[ObservacioneReimplante]
		[SaldoCostoInd]
		[Estatus]
		[IdCierreLote]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatLotesCabFor.
	''' </summary>
	Public Enum McecatLotesCabForFieldIndex
		[IdLote]
		[IdFormula]
		[IdRenglon]
		[DiasFormula]
		[FecInicio]
		[FecFinal]
		[ConsxCabKil]
		[PorServida1]
		[PorServida2]
		[PorServida3]
		[PorServida4]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatLotesDet.
	''' </summary>
	Public Enum McecatLotesDetFieldIndex
		[IdLote]
		[IdTipoGanado]
		[AretePropio]
		[AreteSiniiga]
		[AreteTransporte]
		[KilosEntrada]
		[KilosSalida]
		[FechaEntrada]
		[FechaSalida]
		[KilosAlim]
		[ImpteAlim]
		[ImpteMed]
		[Gdpini]
		[Gdp]
		[Eca]
		[Cki]
		[PesoEstimado]
		[SaldoCostoInd]
		[Impte]
		[Estatus]
		[IdMcecatLotesDet]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McecatTiposCorral.
	''' </summary>
	Public Enum McecatTiposCorralFieldIndex
		[IdTipoCorral]
		[DescTipoCorral]
		[DescCorTipoCorral]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatCausasMuerte.
	''' </summary>
	Public Enum McgcatCausasMuerteFieldIndex
		[IdCausaMuerte]
		[NombreCausaMuerte]
		[NomCorCausaMuerte]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatChoferes.
	''' </summary>
	Public Enum McgcatChoferesFieldIndex
		[IdChofer]
		[NombreChofer]
		[ApPatChofer]
		[ApMatChofer]
		[NomCorChofer]
		[Domicilio]
		[Colonia]
		[IdPoblacion]
		[IdCiudad]
		[IdEstado]
		[Telefono]
		[TelefonoCel]
		[NoLicencia]
		[TipoLicencia]
		[FechaVenceLicencia]
		[TipoSangre]
		[Observaciones]
		[FechaBaja]
		[MotivoBaja]
		[QuiendioBaja]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatCompradoresdeGanado.
	''' </summary>
	Public Enum McgcatCompradoresdeGanadoFieldIndex
		[IdComprador]
		[Nombre]
		[ApellidoPaterno]
		[ApellidoMaterno]
		[Rfc]
		[CalleyNumero]
		[Colonia]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[PagarComision]
		[ComisionxCabeza]
		[Estatus]
		[FechaAlta]
		[FechaBaja]
		[IdCuentaContable]
		[ComisionXkilo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatConcepGastos.
	''' </summary>
	Public Enum McgcatConcepGastosFieldIndex
		[IdConceptoGasto]
		[Descripcion]
		[DescCorta]
		[AplicaIva]
		[PorcentajeIva]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatMovGanado.
	''' </summary>
	Public Enum McgcatMovGanadoFieldIndex
		[IdMovGanado]
		[NombreMovGanado]
		[NomCorMovGanado]
		[Observaciones]
		[Salida]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatTiposdeGanado.
	''' </summary>
	Public Enum McgcatTiposdeGanadoFieldIndex
		[IdTipoGanado]
		[Descripcion]
		[DescCorta]
		[Observaciones]
		[AcumuladoCabezas]
		[AcumuladoKilos]
		[FechaUltimaEntrada]
		[FechaUltimaSalida]
		[Estatus]
		[Lados]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcatVehiculos.
	''' </summary>
	Public Enum McgcatVehiculosFieldIndex
		[IdVehiculo]
		[DescVehiculo]
		[DescCorVehiculo]
		[Marca]
		[Modelo]
		[Placas]
		[NoSerie]
		[FechaCompra]
		[Observaciones]
		[FechaBaja]
		[MotivoBaja]
		[QuiendioBaja]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcompraGanadoCab.
	''' </summary>
	Public Enum McgcompraGanadoCabFieldIndex
		[FolioCompra]
		[IdProveedor]
		[FechaCompra]
		[FechaCaptura]
		[IdComprador]
		[IdCorral]
		[CantCabezas]
		[KilosComprados]
		[KilosRecibidos]
		[Merma]
		[Observaciones]
		[Importe]
		[NoGuia]
		[ImporteGuia]
		[Estatus]
		[FechaCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgcompraGanadoDet.
	''' </summary>
	Public Enum McgcompraGanadoDetFieldIndex
		[FolioCompra]
		[IdTipoGanado]
		[CantCabezas]
		[Kilos]
		[CostoxCab]
		[Importe]
		[CostoxKilo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McgconfiguracionMovimientoGanado.
	''' </summary>
	Public Enum McgconfiguracionMovimientoGanadoFieldIndex
		[Codigo]
		[EntradaXcompraGanado]
		[SalidaXcancelacionCompraGanado]
		[SalidaRecibaVenta]
		[SalidaRecibaMuerte]
		[SalidaRecibaRastro]
		[SalidaRecibaEnfermeria]
		[EntradaRecibaCancelacionVenta]
		[EntradaRecibaCancelacionMuerte]
		[EntradaRecibaCancelacionRastro]
		[EntradaRecibaCancelacionEnfermeria]
		[SalidaCorralVenta]
		[SalidaCorralMuerte]
		[SalidaCorralRastro]
		[SalidaCorralTraspaso]
		[EntradaCorralCancelacionVenta]
		[EntradaCorralCancelacionMuerte]
		[EntradaCorralCancelacionRastro]
		[EntradaCorralCancelacionTraspaso]
		[EntradaCorralTraspaso]
		[EntradaRastroXsalidaReciba]
		[EntradaCorralXtransferenciaReciba]
		[SalidaRecibaXtransferenciaAcorral]
		[SalidaCorralXcancelacionTransferenciaRecibaAcorral]
		[EntradaRecibaXcancelacionTransferenciaRecibaAcorral]
		[EntradaXcancelacionSacrificio]
		[SalidaXcancelacionEntradaRastroXsalidaRecibaArastro]
		[SalidaXsacrificio]
		[EntradaReinicioReciba]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McomCotizacionCompra.
	''' </summary>
	Public Enum McomCotizacionCompraFieldIndex
		[IdCotizacion]
		[FolioCotizacion]
		[IdSucursal]
		[IdUsuarioAlta]
		[Observaciones]
		[FechaCaptura]
		[IdUsuarioCancelacion]
		[ObservacionesCancelacion]
		[FechaCancelacion]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McomCotizacionCompraProveedor.
	''' </summary>
	Public Enum McomCotizacionCompraProveedorFieldIndex
		[IdCotizacion]
		[IdProveedor]
		[Observaciones]
		[DiasCredito]
		[Importe]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[FechaCotizacion]
		[FechaCaptura]
		[FechaVigencia]
		[IdUsuarioAlta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McomCotizacionCompraProveedorDetalle.
	''' </summary>
	Public Enum McomCotizacionCompraProveedorDetalleFieldIndex
		[IdCotizacion]
		[IdProveedor]
		[IdProducto]
		[IdSolicitud]
		[Cantidad]
		[IdMoneda]
		[TipoCambio]
		[Precio]
		[Importe]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: McomRecepcionOrdenCompraDet.
	''' </summary>
	Public Enum McomRecepcionOrdenCompraDetFieldIndex
		[IdRecepcionOrdenCompra]
		[IdProducto]
		[Cantidad]
		[Costo]
		[Iva]
		[Descuento]
		[Total]
		[Ieps]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MetodoCab.
	''' </summary>
	Public Enum MetodoCabFieldIndex
		[Codigo]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MetodoDet.
	''' </summary>
	Public Enum MetodoDetFieldIndex
		[CodMetodo]
		[CodCentroCosto]
		[Porcentaje]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MetodoPago.
	''' </summary>
	Public Enum MetodoPagoFieldIndex
		[IdMetodoPago]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MfacCatClientes.
	''' </summary>
	Public Enum MfacCatClientesFieldIndex
		[IdCliente]
		[Nombre]
		[RazonSocial]
		[Domicilio]
		[Colonia]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[CodigoPostal]
		[Estatus]
		[FechaAlta]
		[FechaCancelacion]
		[DiasCredito]
		[DiasRevision]
		[LimiteCredito]
		[DiasPago]
		[TipoFacturacion]
		[FechaUltimaCompra]
		[ImporteUltimaCompra]
		[Telefono]
		[Rfc]
		[ObservacionesPalletizado]
		[CuentaContId]
		[CuentaAnticipoId]
		[Introductor]
		[ClientesVarios]
		[IdVendedor]
		[EsPersonaFisica]
		[Logo]
		[Idtipocliente]
		[Canaldistribucion]
		[UsoCfdi]
		[FormaPago]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MfacClientesDatosFiscales.
	''' </summary>
	Public Enum MfacClientesDatosFiscalesFieldIndex
		[IdCliente]
		[IdRenglon]
		[Domicilio]
		[Colonia]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[CodigoPostal]
		[Telefono1]
		[Fax]
		[Celular]
		[Email]
		[EsPrincipal]
		[Calle]
		[NoExt]
		[NoInt]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MfacEmbarquesCab.
	''' </summary>
	Public Enum MfacEmbarquesCabFieldIndex
		[IdFolioEmbarque]
		[FechaEmbarque]
		[FechaCaptura]
		[FechaCancelacion]
		[IdCliente]
		[IdVehiculo]
		[IdChofer]
		[TotalPiezas]
		[TotalKgrs]
		[Estatus]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[IdPuntoEntrega]
		[TotalCajas]
		[IdFolioMovimiento]
		[NoFactura]
		[FolioEmbarqueEmp]
		[IdUsuarioAutorizo]
		[Exportacion]
		[IdClienteAsignado]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MfacEmbarquesDet.
	''' </summary>
	Public Enum MfacEmbarquesDetFieldIndex
		[IdFolioEmbarque]
		[Renglon]
		[IdFolioEtiqueta]
		[IdProducto]
		[CantPzas]
		[CantKgrs]
		[Estatus]
		[TipoProducto]
		[NoFactura]
		[FolioSacrificio]
		[IdFolioMovimientoAlmacen]
		[Precio]
		[SerieFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MgcnfFoliadorAlmacen.
	''' </summary>
	Public Enum MgcnfFoliadorAlmacenFieldIndex
		[LetraSerie]
		[Año]
		[Mes]
		[Consecutivo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MgcnfFoliadores.
	''' </summary>
	Public Enum MgcnfFoliadoresFieldIndex
		[Codigo]
		[Año]
		[Mes]
		[IdAlmacen]
		[Consecutivo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MgcnfFolios.
	''' </summary>
	Public Enum MgcnfFoliosFieldIndex
		[Año]
		[Mes]
		[LoteCortes]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MgralcatPuntosEntrega.
	''' </summary>
	Public Enum MgralcatPuntosEntregaFieldIndex
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[IdPuntoEntrega]
		[Descripcion]
		[Direccion]
		[Colonia]
		[Telefono]
		[CodigoPostal]
		[Estatus]
		[IdCliente]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvMovimientosAlmacenPv.
	''' </summary>
	Public Enum MinvMovimientosAlmacenPvFieldIndex
		[AlmacenId]
		[FolioMovimiento]
		[FechaMovimiento]
		[TipoMovimientoId]
		[CostoTotal]
		[Origen]
		[Referencia]
		[UsuarioId]
		[EstatusContabilizado]
		[FechaContabilizacion]
		[PolizaContabilidad]
		[Entrega]
		[Recibe]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvMovimientosAlmacenPvdetalles.
	''' </summary>
	Public Enum MinvMovimientosAlmacenPvdetallesFieldIndex
		[Indice]
		[AlmacenId]
		[FolioMovimiento]
		[ProductoId]
		[FechaMovimiento]
		[Cantidad]
		[Costo]
		[Descuento]
		[Lote]
		[CostoPromedioAnterior]
		[CostoPromedio]
		[IdCentroCosto]
		[CantidadUsada]
		[IdProdComp]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenEntrada.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenEntradaFieldIndex
		[FolioTransferencia]
		[IdAlmacenDestino]
		[FechaMovimiento]
		[FechaCaptura]
		[TotalProductos]
		[Importe]
		[Estatus]
		[IdAlmacenOrigen]
		[FechaCancelacion]
		[IdUsuarioCancelacion]
		[FolioTransferenciaSalida]
		[FolioMovmientoAlmacen]
		[FolioMovmientoAlmacenCancelacion]
		[IdUsuarioAlta]
		[Entrega]
		[Recibe]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenEntradaDetalle.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenEntradaDetalleFieldIndex
		[FolioTransferencia]
		[IdProducto]
		[Lote]
		[Cantidad]
		[Importe]
		[CostoUnitario]
		[Iva]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenProd.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenProdFieldIndex
		[FolioTransferencia]
		[IdAlmacenDestino]
		[FechaMovimiento]
		[FechaCaptura]
		[Kilos]
		[Piezas]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenProdDetalle.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenProdDetalleFieldIndex
		[FolioTransferencia]
		[FolioEtiqueta]
		[IdProducto]
		[Kilos]
		[Piezas]
		[FechaCaptura]
		[FolioMovimeinto]
		[TipoProducto]
		[IdAlmacenOrigen]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenSalida.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenSalidaFieldIndex
		[FolioTransferencia]
		[IdAlmacenDestino]
		[FechaMovimiento]
		[FechaCaptura]
		[TotalProductos]
		[Importe]
		[Estatus]
		[IdAlmacenOrigen]
		[FechaCancelacion]
		[IdUsuarioCancelacion]
		[FolioMovimiento]
		[FolioMovimientoCancelacion]
		[IdUsuarioAlta]
		[Entrega]
		[Recibe]
		[Observaciones]
		[Iva]
		[Total]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MinvTransferenciaAlmacenSalidaDetalle.
	''' </summary>
	Public Enum MinvTransferenciaAlmacenSalidaDetalleFieldIndex
		[FolioTransferencia]
		[IdProducto]
		[Lote]
		[Cantidad]
		[Importe]
		[CostoUnitario]
		[Iva]
		[FechaCaducidad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Modulo.
	''' </summary>
	Public Enum ModuloFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[EsBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Moneda.
	''' </summary>
	Public Enum MonedaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[TipoCambio]
		[Estatus]
		[UsuarioAltaId]
		[FechaAlta]
		[Observaciones]
		[MotivoCancelacionId]
		[ObservacionesCancelacion]
		[UsuarioCancelacionId]
		[FechaCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MotivoBaja.
	''' </summary>
	Public Enum MotivoBajaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[FechaAlta]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MotivoBajaDetalle.
	''' </summary>
	Public Enum MotivoBajaDetalleFieldIndex
		[Idmotivo]
		[Idmodulo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MotivoCancelacion.
	''' </summary>
	Public Enum MotivoCancelacionFieldIndex
		[IdMotivo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[FechaAlta]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MotivoCancelacionDetalle.
	''' </summary>
	Public Enum MotivoCancelacionDetalleFieldIndex
		[Idmotivo]
		[Idmodulo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatDecomisos.
	''' </summary>
	Public Enum MsccatDecomisosFieldIndex
		[IdDecomiso]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatMotivoDevolucion.
	''' </summary>
	Public Enum MsccatMotivoDevolucionFieldIndex
		[IdMotivoDevolucion]
		[Descripcion]
		[DescripcionCorta]
		[Estatus]
		[IdUsuarioAlta]
		[FechaCaptura]
		[IdUsuarioBaja]
		[FechaCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatMovtosAlmacen.
	''' </summary>
	Public Enum MsccatMovtosAlmacenFieldIndex
		[IdCodMovimiento]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[TipoEntSal]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatProductos.
	''' </summary>
	Public Enum MsccatProductosFieldIndex
		[IdProducto]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[SubProducto]
		[PreCorte]
		[Corte]
		[Decomisa]
		[EnPiezas]
		[Estatus]
		[CodProdAnt]
		[MaximoPiezasxCaja]
		[NombreIngles]
		[CodigoBarra]
		[IdCeuntaContable]
		[PrecioXkilo]
		[PiezasXcabeza]
		[KilosMaximo]
		[KilosMinimo]
		[Canal]
		[EsMerma]
		[ValorAgregado]
		[ConHueso]
		[EsDerivable]
		[Claveproserv]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatProductosDetalle.
	''' </summary>
	Public Enum MsccatProductosDetalleFieldIndex
		[IdProducto]
		[IdDecomiso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatServiciosRastro.
	''' </summary>
	Public Enum MsccatServiciosRastroFieldIndex
		[IdServicio]
		[NombreServicio]
		[NomCorServicio]
		[Importe]
		[PorcentajeIva]
		[CtaMay]
		[SubCta]
		[SsbCta]
		[SssCta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccatTiposAlmacen.
	''' </summary>
	Public Enum MsccatTiposAlmacenFieldIndex
		[IdCodTipoAlmacen]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccomprasCanales.
	''' </summary>
	Public Enum MsccomprasCanalesFieldIndex
		[IdFolioCompra]
		[IdCompra]
		[IdCodProveedor]
		[FechaCompra]
		[FechaCaptura]
		[CantCanales]
		[CantKilos]
		[ImporteDescuento]
		[ImporteSubTotal]
		[ImporteIva]
		[ImporteCompra]
		[FolioMovAlmacen]
		[Estatus]
		[IdUsuario]
		[FechaCancela]
		[ObservacionCancela]
		[IdUsuarioCancela]
		[Contabilizado]
		[FechaContabilizo]
		[IdPoliza]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscconfigMovtosAlmacen.
	''' </summary>
	Public Enum MscconfigMovtosAlmacenFieldIndex
		[IdConfiguracion]
		[EntradaCanalAlmacen]
		[EntradaCorteXcaptura]
		[EntradaProductoXcaptura]
		[EntradaCorteXdevolucionVenta]
		[EntradaCanalXdevolucionVenta]
		[EntradaProductoXdevolucionVenta]
		[EntradaProductoXdecomiso]
		[EntradaCanalXdecomiso]
		[EntradaProductoXcompra]
		[EntradaCanalXcompra]
		[EntradaCorteXcompra]
		[EntradaProductoXotrasEntradas]
		[EntradaCanalXotrasEntradas]
		[EntradaCorteXotrasEntradas]
		[EntradaProductoInventarioInicial]
		[EntradaCanalInventarioInicial]
		[EntradaCorteInventarioInicial]
		[EntradaProductoXajusteInventario]
		[EntradaCanalXajusteInventario]
		[EntradaCorteXajusteInventario]
		[EntradaCanalXcancelacionCanalAcorte]
		[SalidaCanalXcancelacionCanalAlmacen]
		[SalidaCorteXcancelacionCapturaCorte]
		[SalidaProductoXcancelacionProductoCaptura]
		[SalidaCorteXventa]
		[SalidaCanalXventa]
		[SalidaProductoXventa]
		[SalidaCanalXcancelacionDecomiso]
		[SalidaProductoXcancelacionDecomiso]
		[SalidaProductoXcancelacionCompra]
		[SalidaCanalXcancelacionCompra]
		[SalidaCorteXcancelacionCompra]
		[SalidaProductoXotrasSalidas]
		[SalidaCanalXotrasSalidas]
		[SalidaCorteXotrasSalidas]
		[SalidaProductoXcancelacionInventarioInicial]
		[SalidaCanalXcancelacionInventarioInicial]
		[SalidaCorteXcancelacionInventarioInicial]
		[SalidaProductoXajusteInventario]
		[SalidaCanalXajusteInventario]
		[SalidaCorteXajusteInventario]
		[SalidaCanalXcanalAcorte]
		[EntradaCanalXcancelacionVenta]
		[EntradaCorteXcancelacionVenta]
		[EntradaProductoXcancelacionVenta]
		[EntradaCorteXcancelacionReproceso]
		[SalidaCorteXreproceso]
		[SalidaCorteXcancelacionDevolucionVenta]
		[EntradaCorteXtraspaso]
		[SalidaCorteXtraspaso]
		[EntradaCorteXcancelacionSalidaTraspaso]
		[SalidaCorteXcancelacionEntradaTraspaso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MsccortesPreCortes.
	''' </summary>
	Public Enum MsccortesPreCortesFieldIndex
		[IdCorte]
		[IdPreCorte]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscdetCanalAcorte.
	''' </summary>
	Public Enum MscdetCanalAcorteFieldIndex
		[IdFolioLoteCorte]
		[FolioSacrificio]
		[IdFolioCanal]
		[Lado]
		[KgrsEnCorte]
		[Estatus]
		[IdFolioMovimientoAlmacen]
		[IdFolioMovimientoAlmacenCancelacion]
		[FechaCaptura]
		[FechaCancelacion]
		[IdUsuarioAlta]
		[IdusaurioCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscdetCanalCompras.
	''' </summary>
	Public Enum MscdetCanalComprasFieldIndex
		[IdFolioCompra]
		[IdFolioCanal]
		[Lado]
		[CantKgrsFapsa]
		[CantKgrsRecibidos]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscinventarioFisico.
	''' </summary>
	Public Enum MscinventarioFisicoFieldIndex
		[IdCodAlmacen]
		[IdCodProducto]
		[FechaInventario]
		[ExistFisicaKilos]
		[ExistFisicaPzas]
		[ExistLibrosKilos]
		[ExistLibrosPzas]
		[PrecioUnitario]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscinventarioProducto.
	''' </summary>
	Public Enum MscinventarioProductoFieldIndex
		[IdCodAlmacen]
		[IdCodProducto]
		[Año]
		[Mes]
		[ExistKilos]
		[ExistPzas]
		[EntKilos]
		[EntPzas]
		[SalKilos]
		[SalPzas]
		[ExtPiezasInicial]
		[ExtKilosInicial]
		[UltimoCosto]
		[CostoProm]
		[FechaUltimaEntrada]
		[FechaUltimaSalida]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscloteCortesCab.
	''' </summary>
	Public Enum MscloteCortesCabFieldIndex
		[LoteCorte]
		[LoteSacrificio]
		[FechaCorte]
		[IdCliente]
		[FechaCad]
		[DiasCad]
		[TotalPzas]
		[TotalKgs]
		[ConsecEtiquetas]
		[Observaciones]
		[Estatus]
		[FechaCierre]
		[FechaCancela]
		[MotivoCancela]
		[FechaCaptura]
		[IdUsuarioCancela]
		[ObservacionesCancela]
		[FolCorPza]
		[FechaFapsa]
		[EsReproceso]
		[Nopiezas]
		[Producto]
		[Unidad]
		[Conductor]
		[Placas]
		[Horaviaje]
		[Idproveedor]
		[Cvelugcomp]
		[Cvecomprador]
		[ObservacionesLotes]
		[KilosRecibidos]
		[Nofactura]
		[Importe]
		[Precioxkilo]
		[Precioxkilogasto]
		[Precioxkilototal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscloteCortesDet.
	''' </summary>
	Public Enum MscloteCortesDetFieldIndex
		[LoteCorte]
		[IdFolioEtiqueta]
		[IdCorte]
		[IdProducto]
		[CantPzas]
		[CantKgrs]
		[Estatus]
		[IdFolioEmbarque]
		[IdFolioMovimiento]
		[CodigoBarra]
		[IdFolioEtiquetaReferencia]
		[Grados]
		[IdCliente]
		[FechaCaptura]
		[LoteCorteReproceso]
		[IdFolioMovimientoAlmacenReproceso]
		[IdFolioMovimientoAlmacenAjuste]
		[FechaCaducidad]
		[FechaCaducidadAnterior]
		[IdFolioMovimientoAlmacenCongelado]
		[GradosAnterior]
		[TipoProducto]
		[IdAlmacenActual]
		[IdAlmacenOrigen]
		[TipoProductoAnterior]
		[MasDe30Meses]
		[CantLibras]
		[Farenheit]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscloteCortesDetComparacion.
	''' </summary>
	Public Enum MscloteCortesDetComparacionFieldIndex
		[LoteCorte]
		[IdFolioEtiqueta]
		[IdCorte]
		[IdProducto]
		[CantPzas]
		[CantKgrs]
		[Estatus]
		[IdFolioEmbarque]
		[IdFolioMovimiento]
		[CodigoBarra]
		[IdFolioEtiquetaReferencia]
		[Grados]
		[IdCliente]
		[FechaCaptura]
		[FechaMovimiento]
		[IdAlmacen]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscmovtosAlmacenCab.
	''' </summary>
	Public Enum MscmovtosAlmacenCabFieldIndex
		[IdFolioMovimiento]
		[IdCodAlmacen]
		[FechaMovimiento]
		[FechaCaptura]
		[IdCodMovimiento]
		[CantPzas]
		[CantKilos]
		[Estatus]
		[Contabilizado]
		[FechaContabilizacion]
		[IdPoliza]
		[QuienContabilizo]
		[FechaCancelacion]
		[QuienCancelo]
		[ObservacionCancela]
		[FolioMovmientoReferencia]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscmovtosAlmacenDet.
	''' </summary>
	Public Enum MscmovtosAlmacenDetFieldIndex
		[IdFolioMovimiento]
		[IdCodProducto]
		[CantKilos]
		[CantPzas]
		[CostoUnitario]
		[Iva]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscproductosDecomisos.
	''' </summary>
	Public Enum MscproductosDecomisosFieldIndex
		[IdProducto]
		[IdDecomiso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscproductosValorAgregado.
	''' </summary>
	Public Enum MscproductosValorAgregadoFieldIndex
		[IdProducto]
		[IdSubCorte]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscrecepcionCanalesCab.
	''' </summary>
	Public Enum MscrecepcionCanalesCabFieldIndex
		[FolioMovimiento]
		[FolioSacrificio]
		[FechaSacrificio]
		[FechaCaptura]
		[LotePropio]
		[CodCliente]
		[CantCanales]
		[KgrsRastro]
		[Observaciones]
		[Estatus]
		[FechaCancelacion]
		[IdRastro]
		[KgrsBascula]
		[KgrsCalientes]
		[IdUsuarioCancela]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscrecepcionCanalesDet.
	''' </summary>
	Public Enum MscrecepcionCanalesDetFieldIndex
		[FolioMovimiento]
		[FolioSacrificio]
		[IdFolioCanal]
		[Consecutivo]
		[Lado]
		[KgrsRastro]
		[KgrsBascula]
		[Estatus]
		[IdFolioMovimiento]
		[CodigoBarra]
		[KgrsCalientes]
		[IdFolioMovimientoCancela]
		[IdUsuarioCancela]
		[FechaCancelacion]
		[LoteEngora]
		[IdCliente]
		[Sexo]
		[Res]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscregistroSacrificioCab.
	''' </summary>
	Public Enum MscregistroSacrificioCabFieldIndex
		[IdFolioSacrificio]
		[IdFolioRastro]
		[IdCodCliente]
		[FechaSacrificio]
		[FechaCaptura]
		[CantCabSacrificio]
		[CantCabMuertas]
		[CantCanales]
		[KgsEnPie]
		[KgsCanal]
		[Estatus]
		[Observaciones]
		[FechaCancelacion]
		[ObservacionesCancelacion]
		[ImporteSacrificio]
		[FolioMovAlmacen]
		[IdUsuario]
		[IdUsuarioCancela]
		[Contabilizado]
		[FechaContabilizacion]
		[IdPoliza]
		[PorcientoRendimiento]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscrelacionCortesClientes.
	''' </summary>
	Public Enum MscrelacionCortesClientesFieldIndex
		[CodCliente]
		[CodCorte]
		[CodCorteCliente]
		[Descripcion]
		[IdDestino]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscrelacionProductosRastros.
	''' </summary>
	Public Enum MscrelacionProductosRastrosFieldIndex
		[CodRastro]
		[CodProducto]
		[CodProductoRastro]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscsalidasGanadoCab.
	''' </summary>
	Public Enum MscsalidasGanadoCabFieldIndex
		[FolioSalidaGanado]
		[LotedeCorral]
		[CantCabezas]
		[CantKgrsPie]
		[CodUnidadVehiculo]
		[CodChofer]
		[Estatus]
		[FechaSalida]
		[FechaCaptura]
		[FechaCancelacion]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MscsalidasGanadoDet.
	''' </summary>
	Public Enum MscsalidasGanadoDetFieldIndex
		[FolioSalidaGanado]
		[CodTipoGanado]
		[CantCabezas]
		[CantKilos]
		[CostoxKilo]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MveCta.
	''' </summary>
	Public Enum MveCtaFieldIndex
		[IdMveCta]
		[IdCuenta]
		[Referencia]
		[Fecha]
		[Concepto]
		[TipoMov]
		[Importe]
		[Conciliado]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MvtosBancariosCb.
	''' </summary>
	Public Enum MvtosBancariosCbFieldIndex
		[NumeroPol]
		[CtaBancar]
		[FecMov]
		[Referencia]
		[Importe]
		[Benefic]
		[Concepto]
		[TipoMov]
		[CarAbo]
		[Origen]
		[CveCancel]
		[CveConcil]
		[CtaBanDes]
		[FechaCap]
		[TipoCambio]
		[SaldoAnterior]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomCatEmpleados.
	''' </summary>
	Public Enum NomCatEmpleadosFieldIndex
		[Codigo]
		[Nombres]
		[ApellidoPaterno]
		[ApellidoMaterno]
		[FechaNacimiento]
		[Rfc]
		[Curp]
		[Sexo]
		[Domicilio]
		[Colonia]
		[CodigoPostal]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[Telefono]
		[Celular]
		[EstadoCivil]
		[Conyuge]
		[Padre]
		[Madre]
		[Imss]
		[IdDepartamento]
		[IdPuesto]
		[SalarioActual]
		[Sdi]
		[Fonacot]
		[Descanso]
		[Turno]
		[AplicaImss]
		[AplicaIsr]
		[Factor]
		[DiasAginaldo]
		[DiasAginaldoAdicional]
		[DiasVacaciones]
		[DiasVacacionesAdicional]
		[DiasPrimaVacacional]
		[Estatus]
		[FechaAlta]
		[FechaIngreso]
		[FechaBaja]
		[Infonavit]
		[Tipocreditoinfonavit]
		[ImporteDescuentoInfonavit]
		[FecheOtorgamientoCrédito]
		[PensionAlimenticia]
		[PorcDescuentoPensionAlimenticia]
		[NoClinica]
		[NombreClinica]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomCatPuestos.
	''' </summary>
	Public Enum NomCatPuestosFieldIndex
		[Codigo]
		[Descripcion]
		[SueldoDiario]
		[Estatus]
		[IdUsuarioAlta]
		[FechaAlta]
		[IdUsuarioCancela]
		[FechaCancelacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomConfiguracion.
	''' </summary>
	Public Enum NomConfiguracionFieldIndex
		[Codigo]
		[SalarioMinimoDf]
		[SalarioMininimoSinaloa]
		[MesComercial]
		[DiasdeTrabajo]
		[HorasDiarias]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomDiasVacaciones.
	''' </summary>
	Public Enum NomDiasVacacionesFieldIndex
		[Año]
		[Dias]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomImportes.
	''' </summary>
	Public Enum NomImportesFieldIndex
		[Folio]
		[IdEmpleado]
		[Quincena]
		[Fecha]
		[DiasTrabajados]
		[SueldoDiario]
		[ImporteSueldo]
		[Comisiones]
		[HorasExtras]
		[ImporteHorasExtras]
		[HorasExtrasTriples]
		[ImportesHorasExtrasTriples]
		[ImporteHorasExtrasExentasIsr]
		[ImporteHorasExtrasExentasImss]
		[ImporteTotalPercepciones]
		[ImportePercepcionGravadaIsr]
		[ImportePercepcionGravadaImss]
		[ImporteIsrsubsidioalEmpleo]
		[ImporteIsrsegunTarifa]
		[ImporteSubsidioalEmpleo]
		[ImporteExcedente]
		[ImportePrestacionesenDinero]
		[ImporteGastosMedicosPensionados]
		[ImporteInvalidezyVida]
		[ImporteTotalCuotaMensual]
		[ImporteCesantiayVejez]
		[ImporteTotalCuotaBimestral]
		[ImporteCuotaFija]
		[ImporteExcedentePatronal]
		[ImportePrestacionesenDineroPatronal]
		[ImporteGastosMedicosPatronal]
		[ImporteInvalidezVidaPatronal]
		[ImporteGuardariaPatronal]
		[ImporteRiesgoTrabajoPatronal]
		[ImporteTotalCuotaMensualPatronal]
		[ImporteCesantiayVejezPatronal]
		[ImporteRetiroSar]
		[ImporteInfonavit]
		[ImporteTotalaPercibir]
		[Pretamos]
		[Infonavit]
		[CostoHrsExtrasDobles]
		[CostoHrsExtrasTriples]
		[ImporteNetoaPercibir]
		[ImporteHorasExtrasDobles]
		[HorasExtrasDobles]
		[ImportePensionAlimenticia]
		[SmregionA]
		[SmregionC]
		[MesComercial]
		[HorasDiariasTrabajadas]
		[DiasdeFalta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomImssinfonavit.
	''' </summary>
	Public Enum NomImssinfonavitFieldIndex
		[Codigo]
		[EnfyMatEnEspecieCuotaFijaObrero]
		[EnfyMatEnEspecieCuotaFijaPatronal]
		[EnfyMatEnEspecieExcedenteObrero]
		[EnfyMatEnEspecieExcedentePatronal]
		[EnfyMatEnDineroObrero]
		[EnfyMatEnDineroPatronal]
		[EnfyMatGastosMedicosObrero]
		[EnfyMatGastosMedicosPatronal]
		[InvalidezyVidaObrero]
		[InvalidezyVidaPatronal]
		[Guarderias]
		[Retiro]
		[RetCesantiayVejezObrero]
		[RetCesantiayVejezPatronal]
		[Infonavit]
		[Riesgotrabajo]
		[TopeVssmdfintegrarcuotaFija]
		[TopeVssmdfintegrarcalculocuotaFija]
		[TopeVssmdfintegrarexcedente]
		[TopeVssmdfintegrarcalculoexcedente]
		[TopeVssmdfintegrarendinero]
		[TopeVssmdfintegrarcalculoendinero]
		[TopeVssmdfintegrargastosMedicos]
		[TopeVssmdfintegrarcalculogastosMedicos]
		[TopeVssmdfintegrarinvalidezyvida]
		[TopeVssmdfintegrarcalculoinvalidezyvida]
		[TopeVssmdfintegrarguarderias]
		[TopeVssmdfintegrarcalculoguarderias]
		[TopeVssmdfintegrarretiro]
		[TopeVssmdfintegrarcalculoretiro]
		[TopeVssmdfintegrarcesantiayvejez]
		[TopeVssmdfintegrarcalculocesantiayvejez]
		[TopeVssmdfintegrarinfonavit]
		[TopeVssmdfintegrarcalculoinfonavit]
		[TopeVssmdfintegrarriesgodeTrabajo]
		[TopeVssmdfintegrarcalculoriesgodeTrabajo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomIsr.
	''' </summary>
	Public Enum NomIsrFieldIndex
		[Codigo]
		[Año]
		[LimiteInf]
		[LimiteSup]
		[CuotaFija]
		[PorcentajeParaExedente]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NomSubsidioEmpleo.
	''' </summary>
	Public Enum NomSubsidioEmpleoFieldIndex
		[Codigo]
		[Año]
		[IngresosDe]
		[IngresosHasta]
		[Subsidio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaCreditoCab.
	''' </summary>
	Public Enum NotaCreditoCabFieldIndex
		[FolNota]
		[IdCliente]
		[FechaNota]
		[Elaboro]
		[Autorizo]
		[Estatus]
		[IdConcepto]
		[Total]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaCreditoDet.
	''' </summary>
	Public Enum NotaCreditoDetFieldIndex
		[FolNota]
		[FolFactura]
		[SubTotal]
		[ImpteIva]
		[Total]
		[Estatus]
		[FecAplica]
		[Cheque]
		[OrigenCta]
		[Aplicar]
		[FolPago]
		[SerieFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaVenta.
	''' </summary>
	Public Enum NotaVentaFieldIndex
		[Codigo]
		[CodSucursal]
		[Estatus]
		[SubTotal]
		[Descuento]
		[Total]
		[FechaVenta]
		[FechaCancelacion]
		[UsuarioCancelacion]
		[UsuarioAlta]
		[MotivoCancelacion]
		[ObservacionesCancelacion]
		[Iva]
		[Ieps]
		[IdFactura]
		[Importe]
		[Pago]
		[Cambio]
		[PagoTarj]
		[CodCaja]
		[IdControlTurno]
		[IdControlTurnoCanc]
		[CodCajaCanc]
		[SerieFact]
		[FolioFact]
		[Mod]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaVentaDetalle.
	''' </summary>
	Public Enum NotaVentaDetalleFieldIndex
		[Codigo]
		[NotaVenta]
		[Producto]
		[Cantidad]
		[Precio]
		[Importe]
		[Descuento]
		[Iva]
		[Lote]
		[Ieps]
		[IdControlTurnoCanc]
		[FechaHoraCanc]
		[IdProductoCompuesto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaVentaDetalleResp.
	''' </summary>
	Public Enum NotaVentaDetalleRespFieldIndex
		[Codigo]
		[NotaVenta]
		[Producto]
		[Cantidad]
		[Precio]
		[Importe]
		[Descuento]
		[Iva]
		[Lote]
		[Ieps]
		[IdControlTurnoCanc]
		[FechaHoraCanc]
		[IdProductoCompuesto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NotaVentaResp.
	''' </summary>
	Public Enum NotaVentaRespFieldIndex
		[Codigo]
		[Sucursal]
		[Estatus]
		[SubTotal]
		[Descuento]
		[Total]
		[FechaVenta]
		[FechaCancelacion]
		[UsuarioCancelacion]
		[UsuarioAlta]
		[MotivoCancelacion]
		[ObservacionesCancelacion]
		[Iva]
		[Ieps]
		[IdFactura]
		[Importe]
		[PagoEfec]
		[PagoTarj]
		[Cambio]
		[CodCaja]
		[IdControlTurno]
		[IdControlTurnoCanc]
		[CodCajaCanc]
		[SerieFact]
		[FolioFact]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrdenCompra.
	''' </summary>
	Public Enum OrdenCompraFieldIndex
		[IdOrdenCompra]
		[FolioOrdenCompra]
		[IdSucursal]
		[IdProveedor]
		[Observaciones]
		[DiasCredito]
		[FechaOrdenCompra]
		[FechaCaptura]
		[IdUsuarioAlta]
		[FechaCancelacion]
		[IdUsuarioCancelacion]
		[ObservacionesCancelacion]
		[Importe]
		[Descuento]
		[SubTotal]
		[IvaPor]
		[IvaTotal]
		[IvaFlete]
		[ImpteIvaFlete]
		[Total]
		[Estatus]
		[Autorizada]
		[Recibida]
		[FechaAutorizacion]
		[FechaRecepcion]
		[EsDirecta]
		[IdMoneda]
		[TipoCambio]
		[IepsTotal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrdenCompraDetalle.
	''' </summary>
	Public Enum OrdenCompraDetalleFieldIndex
		[IdOrdenCompra]
		[IdProducto]
		[IdDetalle]
		[IdCotizacion]
		[CantidadSolicitada]
		[CantidadOrdenar]
		[IdMoneda]
		[TipoCambio]
		[Precio]
		[Descuento]
		[Importe]
		[Estatus]
		[CantPendientexRecibir]
		[CantRecibida]
		[IdSolicitud]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrdenServicio.
	''' </summary>
	Public Enum OrdenServicioFieldIndex
		[Folio]
		[SucursalId]
		[ProveedorId]
		[Observaciones]
		[MonedaId]
		[TipoCambio]
		[DiasCredito]
		[FechaAlta]
		[UsuarioAltaId]
		[FechaCancelacion]
		[UsuarioCancelacionId]
		[ObservacionesCancelacion]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[MotivoCancelacionId]
		[Estatus]
		[Autorizada]
		[Recibida]
		[FechaAutorizacion]
		[FechaRecepcion]
		[UsuarioRecepOrdenId]
		[FechaCancelaRecep]
		[UsuarioCancelaRecepOrdenId]
		[FolioFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: OrdenServicioDetalle.
	''' </summary>
	Public Enum OrdenServicioDetalleFieldIndex
		[Folio]
		[FolioDetalleSolicitud]
		[Indice]
		[CantidadSolicitada]
		[CantidadOrdenar]
		[Precio]
		[Descuento]
		[Iva]
		[Importe]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PagoCheDevueltoCab.
	''' </summary>
	Public Enum PagoCheDevueltoCabFieldIndex
		[IdPagoCheDevueltoCab]
		[FechaCaptura]
		[FechaPago]
		[FechaCancelacion]
		[Saldo]
		[Importe]
		[Referencia]
		[Estatus]
		[Folio]
		[IdBancoDeposito]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PagoCheDevueltoDet.
	''' </summary>
	Public Enum PagoCheDevueltoDetFieldIndex
		[IdPagoCheDevueltoCab]
		[IdPagoCheDevueltoDet]
		[IdChequeDevuelto]
		[Saldo]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PagoDeCtes.
	''' </summary>
	Public Enum PagoDeCtesFieldIndex
		[CveCliente]
		[FolIngreso]
		[FecIngreso]
		[FolFactura]
		[ImpteIngreso]
		[TipoPago]
		[Documento]
		[ImpteNotaCred]
		[ImpteChePos]
		[Estatus]
		[CveUser]
		[CveUserCancel]
		[FecCancela]
		[ImpteFactura]
		[SaldoFactura]
		[IdPoliza]
		[IdPolizaCancelacion]
		[SerieFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PeriodosCont.
	''' </summary>
	Public Enum PeriodosContFieldIndex
		[Ejercicio]
		[PolizaCierre]
		[PolizaTraspaso]
		[FechaCierre]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Plaza.
	''' </summary>
	Public Enum PlazaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[FechaAlta]
		[UsuarioAlta]
		[Estatus]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Poblacion.
	''' </summary>
	Public Enum PoblacionFieldIndex
		[PidEstado]
		[CodigoCiudad]
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PogrCb.
	''' </summary>
	Public Enum PogrCbFieldIndex
		[NumeroPol]
		[FecPoliza]
		[ImptePoliza]
		[Concepto]
		[Origen]
		[CveError]
		[CveVigencia]
		[Referencia]
		[MotivoCanc]
		[Benefic]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PoGrDt.
	''' </summary>
	Public Enum PoGrDtFieldIndex
		[NumeroPol]
		[CveRenglon]
		[FechaPol]
		[CtaMayor]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[Concepto]
		[CarAbo]
		[Referencia]
		[Importe]
		[CveVig]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Poliza.
	''' </summary>
	Public Enum PolizaFieldIndex
		[Codigo]
		[EmpresaId]
		[TipoPoliza]
		[Mes]
		[Ano]
		[Folio]
		[FechaPoliza]
		[FechaCaptura]
		[Importe]
		[Concepto]
		[Origen]
		[TipoError]
		[Estatus]
		[Referencia]
		[TipoCambio]
		[NumeroPoliza]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PolizaDetalle.
	''' </summary>
	Public Enum PolizaDetalleFieldIndex
		[PolizaId]
		[Posicion]
		[CuentaContableId]
		[OperacionCa]
		[Importe]
		[Concepto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PolizasModeloCab.
	''' </summary>
	Public Enum PolizasModeloCabFieldIndex
		[Codigo]
		[Descripcion]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PolizasModeloDet.
	''' </summary>
	Public Enum PolizasModeloDetFieldIndex
		[Codigo]
		[IdCuentaContable]
		[CargoAbono]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Presentacion.
	''' </summary>
	Public Enum PresentacionFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Cantidad]
		[CodigoUnidadMedida]
		[Observacion]
		[Estatus]
		[UsuarioAlta]
		[FechaAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Presupuesto.
	''' </summary>
	Public Enum PresupuestoFieldIndex
		[Folio]
		[SucursalId]
		[TipoPresupuestoId]
		[Descripcion]
		[Obserbaciones]
		[FechaAlta]
		[UsuarioAlta]
		[UsuarioCancelacion]
		[MotivoCancelacionId]
		[FechaCancelacion]
		[ObserbacionesCancelacion]
		[Estatus]
		[OrdenCompraGenerada]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PresupuestoCompraDetalle.
	''' </summary>
	Public Enum PresupuestoCompraDetalleFieldIndex
		[PresupuestoId]
		[ProductoId]
		[Cantidad]
		[PrecioUltimaCompra]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Producto.
	''' </summary>
	Public Enum ProductoFieldIndex
		[Codigo]
		[Descripcion]
		[DescrpcionCorta]
		[PdIdLinea]
		[CodigoUnidadMedida]
		[CodigoMarca]
		[CodigoPresentacion]
		[SeFactura]
		[SeRecibeParcial]
		[SeObtieneMermas]
		[SeRecibeSinFactura]
		[SeFacturaSinExistencia]
		[SeManejaPorLotes]
		[ProductoGeneral]
		[EsMezcla]
		[EsIngrediente]
		[EsMaterialEnvase]
		[DiasMinCaducidad]
		[Piezas]
		[UsuarioAlta]
		[FechaAlta]
		[UsuarioBaja]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionBaja]
		[Estatus]
		[CodigoRelacionado]
		[CodigoTipoProducto]
		[PdCaduca]
		[SeAplicaIva]
		[FactorConver]
		[FechaUltimaCompra]
		[CantidadUltimaCompra]
		[ImporteUltimaCompra]
		[UltimoCosto]
		[ArtPuntoVenta]
		[ArtMeat]
		[CodigoBarra]
		[PorcIeps]
		[PdEsKit]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductoCostoIndirecto.
	''' </summary>
	Public Enum ProductoCostoIndirectoFieldIndex
		[CodigoProducto]
		[CodigoCostoIndirecto]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductoDerivado.
	''' </summary>
	Public Enum ProductoDerivadoFieldIndex
		[IdProducto]
		[IdDerivado]
		[Cantidad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductoMezcla.
	''' </summary>
	Public Enum ProductoMezclaFieldIndex
		[CodigoProducto]
		[CodigoIngrediente]
		[Porcentaje]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProrraRec.
	''' </summary>
	Public Enum ProrraRecFieldIndex
		[IdProrraRec]
		[Fecha]
		[Kilos]
		[IdLote]
		[IdCorralReciba]
		[CostoxKilo]
		[Importe]
		[IdSalidaGanadoCab]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Proveedor.
	''' </summary>
	Public Enum ProveedorFieldIndex
		[Codigo]
		[Rfc]
		[RazonSocial]
		[Beneficiario]
		[Contacto]
		[ReprecentanteLegal]
		[Estatus]
		[Domicilio]
		[Colonia]
		[CodigoPostal]
		[PrIdEstado]
		[PrIdCiudad]
		[CodigoPoblacion]
		[UsuarioAlta]
		[FechaAlta]
		[UsuarioBaja]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[CuentaContId]
		[PrCuentaAnt]
		[EsdeGanado]
		[Nombre]
		[FechaUltimaCompra]
		[ImporteUltimaCompra]
		[FechaUltimoPago]
		[ImporteUltimoPago]
		[ComprasAnoActual]
		[ComprasAnoAnterior]
		[SaldoActual]
		[IdLugarCompra]
		[AcumComCab]
		[AcumComKil]
		[AcumComCabAnterior]
		[AcumComKilAnterior]
		[PrMeat]
		[PrPuntoVenta]
		[Idcontdiottiposterceros]
		[Idcontdiottiposoperacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProveedorAvanzado.
	''' </summary>
	Public Enum ProveedorAvanzadoFieldIndex
		[Codigo]
		[Email]
		[Web]
		[CodigoTipoProveedor]
		[DiaRevision]
		[DiaPago]
		[Telefono1]
		[Telefono2]
		[Fax]
		[DiasCredito]
		[PorcentajeDescuento]
		[ClaveBancaria]
		[CodigoBanco]
		[LadaTel1]
		[LadaTel2]
		[LadaFax]
		[PrioridadPago]
		[PorcentajeFinanciero]
		[AutoFactura]
		[PrNoCuenta]
		[PrClaveBancaria]
		[ClaveMonedas]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PvnotasVentaRetCab.
	''' </summary>
	Public Enum PvnotasVentaRetCabFieldIndex
		[Id]
		[IdNom]
		[NumArticulos]
		[Total]
		[Fecha]
		[CodUsuario]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PvnotasVentaRetDet.
	''' </summary>
	Public Enum PvnotasVentaRetDetFieldIndex
		[IdNota]
		[Consecutivo]
		[CodArticulo]
		[Cantidad]
		[PrecioUnit]
		[Descuento]
		[Iva]
		[Ieps]
		[IdProdComp]
		[EsKit]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecepcionGanado.
	''' </summary>
	Public Enum RecepcionGanadoFieldIndex
		[LoteRecepcion]
		[IdCliente]
		[FechaRecepcion]
		[LoteEngorda]
		[CantCabezas]
		[KilosEnviados]
		[KilosRecibidos]
		[Unidad]
		[Conductor]
		[Placas]
		[Observaciones]
		[IdUsuario]
		[Estatus]
		[FechaCancelacion]
		[IdUsuarioCancelacion]
		[ObservacionesCancelacion]
		[KilosPrimerPesada]
		[KilosSegundaPesada]
		[MultiplesIntroductores]
		[IdTipoGanado]
		[CabezasMachos]
		[CabezaHembra]
		[IdProveedor]
		[TipoPesada]
		[FechaCaptura]
		[FechaSalida]
		[Maquila]
		[CveLugCom]
		[CveComiGan]
		[HorasViaje]
		[KilosComp]
		[ImpteComp]
		[DiasCredito]
		[FecPago]
		[NumFactura]
		[FecConta]
		[NumPoliza]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecepcionOrdenCompra.
	''' </summary>
	Public Enum RecepcionOrdenCompraFieldIndex
		[IdRecepcionOrdenCompra]
		[IdOrdenCompra]
		[FolioMovimientoAml]
		[FechaRecepcion]
		[FolioMovimientoAlmCan]
		[AlmacenId]
		[FechaCancelacion]
		[UsuarioAltaId]
		[UsuarioCancelacionId]
		[Estatus]
		[MotivoCancelacionId]
		[Observaciones]
		[ObservacionesCancelacion]
		[IdSucursal]
		[NoFactura]
		[Facturada]
		[SubTotal]
		[Iva]
		[Descuento]
		[Total]
		[FolioRecepcionOrdenCompra]
		[FechaCaptura]
		[EsDirecta]
		[OrigenMovimiento]
		[Ieps]
		[IdProveedor]
		[NoRemision]
		[Pagada]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ReferenciaProductoDerivado.
	''' </summary>
	Public Enum ReferenciaProductoDerivadoFieldIndex
		[IdReferencia]
		[IdProducto]
		[Referencia]
		[Origen]
		[FechaMovimiento]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RegistroSacrificiosCab.
	''' </summary>
	Public Enum RegistroSacrificiosCabFieldIndex
		[LoteSacrificio]
		[FechaSacrificio]
		[CantCabezasSacrificio]
		[CantCabezasEnmantadas]
		[CantCabezasClasificadas]
		[CantCabezasSinSacrificar]
		[KilosRecibidos]
		[KilosSacrificio]
		[CantCanalesSacrificio]
		[KilosCalientes]
		[Rendimiento]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RegistroSacrificiosDecomisos.
	''' </summary>
	Public Enum RegistroSacrificiosDecomisosFieldIndex
		[LoteSacrificio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[Decomiso]
		[IdDecomiso]
		[IdAlmacenProd]
		[KilosSalida]
		[PiezasSalida]
		[FolioMovAlmacen]
		[FolioCancelAlmacen]
		[Estatus]
		[KilosEmbarcados]
		[PiezasEmbarcadas]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RegistroSacrificiosDet.
	''' </summary>
	Public Enum RegistroSacrificiosDetFieldIndex
		[LoteSacrificio]
		[FolioCanal]
		[Lado]
		[KilosCalientes]
		[FechaCaptura]
		[KilosFrios]
		[Rendimiento]
		[LoteCorte]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RetiroCaja.
	''' </summary>
	Public Enum RetiroCajaFieldIndex
		[Id]
		[CodUsuario]
		[CodControlTurno]
		[CodCaja]
		[FechaHora]
		[Importe]
		[Estatus]
		[IdConcepto]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RFC.
	''' </summary>
	Public Enum RFCFieldIndex
		[Rfc]
		[RazonSocial]
		[Domicilio]
		[Colonia]
		[CodigoPostal]
		[Poblacion]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalidaGanadoCab.
	''' </summary>
	Public Enum SalidaGanadoCabFieldIndex
		[IdSalidaGanadoCab]
		[Fecha]
		[IdCorral]
		[IdLoteDestino]
		[IdRastro]
		[IdVenta]
		[Cabezas]
		[Kilos]
		[CostoEntrada]
		[CostoAlimento]
		[KilosAlimento]
		[CostoMedicina]
		[CostoxKilo]
		[CostoMovto]
		[FecConta]
		[IdPoliza]
		[Estatus]
		[IdTipoReciba]
		[Aviso]
		[IdCausaMuerte]
		[Recuperacion]
		[ImporteVenta]
		[FolioMovimientoGanado]
		[CostoIndirecto]
		[Folio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalidaGanadoDet.
	''' </summary>
	Public Enum SalidaGanadoDetFieldIndex
		[IdSalidaGanadoCab]
		[IdTipoGanado]
		[IdSalidaGanadoDet]
		[Fecha]
		[Cabezas]
		[Kilos]
		[CostoxKilo]
		[CostoEntrada]
		[CostoAlimento]
		[CostoMedicina]
		[KilosAlimento]
		[PrecioxKilo]
		[Arete]
		[AreteSiniiga]
		[AreteTransporte]
		[IdLote]
		[CostoOperacional]
		[IdMcecatLotesDet]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SatAgrupador.
	''' </summary>
	Public Enum SatAgrupadorFieldIndex
		[Nivel]
		[CodAgrupador]
		[NombreCuenta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Servicios.
	''' </summary>
	Public Enum ServiciosFieldIndex
		[Codigo]
		[NomServicio]
		[TipoServicio]
		[Estatus]
		[FechaAlta]
		[Costo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiciosPorSacrificio.
	''' </summary>
	Public Enum ServiciosPorSacrificioFieldIndex
		[FolioSacrificio]
		[FolioCanal]
		[IdServicio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiciosXembarque.
	''' </summary>
	Public Enum ServiciosXembarqueFieldIndex
		[FoloEmbarque]
		[IdCliente]
		[IdServicio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SolicitudProducto.
	''' </summary>
	Public Enum SolicitudProductoFieldIndex
		[IdSolicitud]
		[FolioSolicitud]
		[IdSucursal]
		[IdUsuarioAlta]
		[EntregarA]
		[EntregarEn]
		[Observaciones]
		[Estatus]
		[FechaSolicitud]
		[FechaCaptura]
		[IdUsuarioCancelacion]
		[ObserbacionesCancelacion]
		[FechaCancelacion]
		[SolicitadoPor]
		[FechaSurtir]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SolicitudProductoDetalle.
	''' </summary>
	Public Enum SolicitudProductoDetalleFieldIndex
		[IdSolicitud]
		[IdProducto]
		[Cantidad]
		[Urgente]
		[Observaciones]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SolicitudServicios.
	''' </summary>
	Public Enum SolicitudServiciosFieldIndex
		[Folio]
		[SucursalId]
		[UsuarioAlta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioCancelacion]
		[MotivoCancelacion]
		[ObservacionesCancelacion]
		[FechaCancelacion]
		[EntregarA]
		[EntregarEn]
		[FechaCaptura]
		[SolicitadoPor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SolicitudServiciosDetalle.
	''' </summary>
	Public Enum SolicitudServiciosDetalleFieldIndex
		[Folio]
		[Indice]
		[Servicio]
		[Cantidad]
		[Urgente]
		[Observaciones]
		[Estatus]
		[FechaServicio]
		[FolioPresupuesto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SubLinea.
	''' </summary>
	Public Enum SubLineaFieldIndex
		[CodigoLinea]
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Sucursal.
	''' </summary>
	Public Enum SucursalFieldIndex
		[CodigoPlaza]
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[Serie]
		[ScidAlmacen]
		[ScidFolioFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoAlmacen.
	''' </summary>
	Public Enum TipoAlmacenFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[EsSubAlmacen]
		[DeProduccion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoCambio.
	''' </summary>
	Public Enum TipoCambioFieldIndex
		[Indice]
		[Fecha]
		[Tipocambio]
		[TipomonedaId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoComicionista.
	''' </summary>
	Public Enum TipoComicionistaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoMoneda.
	''' </summary>
	Public Enum TipoMonedaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[FechaAlta]
		[UsuarioAlta]
		[Estatus]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[MonedaLocal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoMotivo.
	''' </summary>
	Public Enum TipoMotivoFieldIndex
		[Codigo]
		[Modulo]
		[Descripcion]
		[DescripcionCorta]
		[Estatus]
		[EsBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoMovimientoAlmacen.
	''' </summary>
	Public Enum TipoMovimientoAlmacenFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[AfectaCosto]
		[Direccion]
		[Estatus]
		[FechaAlta]
		[UsuarioAltaId]
		[FechaBaja]
		[UsuarioBajaId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoPresupuesto.
	''' </summary>
	Public Enum TipoPresupuestoFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[FechaAlta]
		[Observaciones]
		[Estatus]
		[FechaBaja]
		[UsuarioBaja]
		[ObservacionesBaja]
		[MotivoBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoProducto.
	''' </summary>
	Public Enum TipoProductoFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Venta]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoProveedor.
	''' </summary>
	Public Enum TipoProveedorFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[UsuarioAlta]
		[FechaAlta]
		[UsuarioBaja]
		[FechaBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[Tpmeat]
		[TppuntoVenta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TipoVenta.
	''' </summary>
	Public Enum TipoVentaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[FechaAlta]
		[Estatus]
		[UsuarioAlta]
		[UsuarioBaja]
		[ObservacionesBaja]
		[FechaBaja]
		[EsCredito]
		[EsCreditoNormal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UnidadMedida.
	''' </summary>
	Public Enum UnidadMedidaFieldIndex
		[Codigo]
		[Descripcion]
		[DescripcionCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		[Claveunidadsat]
		[Clavedemoneda]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrBanDepositos.
	''' </summary>
	Public Enum UsrBanDepositosFieldIndex
		[CuentaId]
		[Folio]
		[Medio]
		[PolizaId]
		[Origen]
		[FechaMovimiento]
		[FechaCancelacion]
		[Concepto]
		[Importe]
		[TipoCambio]
		[Estatus]
		[PeriodoId]
		[PolizaIdCancelacion]
		[Referencia]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrConfigContabilidad.
	''' </summary>
	Public Enum UsrConfigContabilidadFieldIndex
		[CancelacionPolizasNegativos]
		[Iva]
		[Isr]
		[TasaRetencion]
		[MostrarDomicPoliza]
		[FechaCierreDiarioBanco]
		[Ivaflete]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrCxpfacturasApagar.
	''' </summary>
	Public Enum UsrCxpfacturasApagarFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[FechaVencimiento]
		[ImporteTotal]
		[ImporteAbono]
		[ImporteApagar]
		[Estatus]
		[Saldo]
		[FechaProgramacion]
		[IdUsuarioAutorizacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrCxpfacturasCab.
	''' </summary>
	Public Enum UsrCxpfacturasCabFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[FechaFactura]
		[FechaCaptura]
		[FechaVencimiento]
		[SubTotal]
		[Iva]
		[Total]
		[Anticipo]
		[Estatus]
		[IdUsuarioAlta]
		[IdMotivoCancelacion]
		[IdUsuarioCancelacion]
		[Observaciones]
		[FechaCancelacion]
		[Saldo]
		[Gastos]
		[Servicios]
		[TasaIva]
		[TasaIsr]
		[TasaRetIva]
		[ImporteIsr]
		[ImporteRetIva]
		[Concepto]
		[Contabilizada]
		[FechaContabilizacion]
		[IdPoliza]
		[Uuid]
		[Ieps]
		[Ivaflete]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrCxpfacturasDet.
	''' </summary>
	Public Enum UsrCxpfacturasDetFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[CuentaContableId]
		[CarAbo]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrCxpfacturasDetRecepciones.
	''' </summary>
	Public Enum UsrCxpfacturasDetRecepcionesFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[IdRecepcionOrdenCompra]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrCxppagosProveedores.
	''' </summary>
	Public Enum UsrCxppagosProveedoresFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[Cheque]
		[Referencia]
		[PolizaId]
		[FechaPago]
		[Importe]
		[CuentaBancariaId]
		[Estatus]
		[FechaCancelacion]
		[PolizaIdCancelacion]
		[IdUsuarioAlta]
		[IdUsuarioCancela]
		[IdConcepto]
		[NoRemision]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrProdConfiguracion.
	''' </summary>
	Public Enum UsrProdConfiguracionFieldIndex
		[IdConfiguracion]
		[ObtenerPeso]
		[RecibirCanales]
		[Embarcarmasdeuncliente]
		[EmbarcarDiferentesProductos]
		[ImprimirEtiquetasCortes]
		[ImprimirEtiquetasCanales]
		[ImprimirEtiquetasProductos]
		[LlenarCajasDiferentesProductos]
		[ImprimirEtiquetaDiferentesProductos]
		[TrabajarLoteSacrificiosAbiertos]
		[TrabajarLoteCortesAbiertos]
		[IdAlmacenCanales]
		[IdAlmacenCortes]
		[IdAlmacenProductos]
		[IdAlmacenDecomisos]
		[LoteCorteAsociadoaLotesSacrificio]
		[ContraseñaEmb]
		[IdTipoAlmacen]
		[TiempoEsperaSacrificio]
		[ObtenerCanalEntradaCanalAlmacen]
		[IncluirPrecioEmbarque]
		[TemperaturaProdFresco]
		[TemperaturaProdCongelado]
		[DiasCaducidadProdFresco]
		[DiasCaducidadProdCongelado]
		[IdAlmacenCorteCongelado]
		[IdAlmacenValorAgregado]
		[TemperaturaValorAgregado]
		[DiasCaducidadValorAgregado]
		[IdAlmacenValorAgregadoCongelado]
		[TemperaturaValorAgregadoCongelado]
		[DiasCaducidadValorAgregadoCongelado]
		[DiasCaducidadHuesoFresco]
		[DiasCaducidadHuesoCongelado]
		[ProductosDerivados]
		[ReferenciarPrecioEmbarqueEnFacturacion]
		[EsTiflogo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrProdRecepcionDetalle.
	''' </summary>
	Public Enum UsrProdRecepcionDetalleFieldIndex
		[LoteRecepcion]
		[Renglon]
		[IdTipoGanado]
		[IdProducto]
		[CantCabezas]
		[DescripcionProducto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrProdRecepcionGanadoDet.
	''' </summary>
	Public Enum UsrProdRecepcionGanadoDetFieldIndex
		[LoteRecepcion]
		[LoteSacrificio]
		[CantCabezas]
		[KilosEnPie]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsrProdRegistroSacrificiosDecomiso.
	''' </summary>
	Public Enum UsrProdRegistroSacrificiosDecomisoFieldIndex
		[FolioSacrificio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[KilosSalida]
		[PiezasSalida]
		[FolioMovAlmacen]
		[FolioCancelAlmacen]
		[Estatus]
		[KilosEmbarcados]
		[PiezasEmbarcadas]
		[IdDecomiso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsuariosSucursal.
	''' </summary>
	Public Enum UsuariosSucursalFieldIndex
		[SucursalId]
		[UsuarioId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UsuarioSucursal.
	''' </summary>
	Public Enum UsuarioSucursalFieldIndex
		[SucursalId]
		[UsuarioId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Zona.
	''' </summary>
	Public Enum ZonaFieldIndex
		[Codigo]
		[Descripcion]
		[DescCorta]
		[Observaciones]
		[Estatus]
		[FechaAlta]
		[UsuarioAlta]
		[FechaBaja]
		[UsuarioBaja]
		[MotivoBaja]
		[ObservacionesBaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ZonaDetalle.
	''' </summary>
	Public Enum ZonaDetalleFieldIndex
		[ZnidZona]
		[IdEstado]
		[IdCiudad]
		[PidPoblacion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ComCotizaciones.
	''' </summary>
	Public Enum ComCotizacionesFieldIndex
		[FolioCotizacion]
		[IdCotizacion]
		[IdSucursal]
		[IdProveedor]
		[IdProducto]
		[Cantidad]
		[Precio]
		[Descuento]
		[Importe]
		[Scdescripcion]
		[Pldescripcion]
		[PrRazSocial]
		[PdDescripcion]
		[IdMoneda]
		[Tmdescripcion]
		[PlidPlaza]
		[FechaCaptura]
		[UmidUnidadMedida]
		[Umdescripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ListaParaAnalizarCotizacionCompra.
	''' </summary>
	Public Enum ListaParaAnalizarCotizacionCompraFieldIndex
		[IdSucursal]
		[IdCotizacion]
		[Codigo]
		[Producto]
		[Cantidad]
		[CodigoProveedor]
		[Proveedor]
		[Precio]
		[Descuento]
		[Importe]
		[Plaza]
		[AplicaIva]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwAlmKardex.
	''' </summary>
	Public Enum VwAlmKardexFieldIndex
		[AlmacenId]
		[ProductoId]
		[PdDescripcion]
		[PdIdLinea]
		[PdIdUnidadMedida]
		[Umdescripcion]
		[Lndescripcion]
		[Expr1]
		[LnidLinea]
		[Año]
		[Mes]
		[CostoPromedio]
		[FolioMovimiento]
		[FechaMovimiento]
		[Cantidad]
		[Costo]
		[Descuento]
		[TipoMovimientoId]
		[Origen]
		[Descripcion]
		[CantidadEntradas]
		[CantidadSalidas]
		[Direccion]
		[CantidadInicial]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwAlmKardexDetalle.
	''' </summary>
	Public Enum VwAlmKardexDetalleFieldIndex
		[UltimoCosto]
		[Año]
		[Mes]
		[CantidadExistencia]
		[ProductoId]
		[AlmacenId]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwAlmKardexProduccion.
	''' </summary>
	Public Enum VwAlmKardexProduccionFieldIndex
		[IdCodAlmacen]
		[IdCodProducto]
		[Descripcion]
		[Año]
		[Mes]
		[ExtPiezasInicial]
		[ExtKilosInicial]
		[CostoProm]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwAlmKardexProduccionDet.
	''' </summary>
	Public Enum VwAlmKardexProduccionDetFieldIndex
		[IdFolioMovimiento]
		[FechaMovimiento]
		[IdCodProducto]
		[Descripcion]
		[CantKilos]
		[CantPzas]
		[CostoUnitario]
		[IdCodAlmacen]
		[Almacen]
		[Direccion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwAlmTarjetas.
	''' </summary>
	Public Enum VwAlmTarjetasFieldIndex
		[IdFolioMovimiento]
		[FechaMovimiento]
		[IdCodAlmacen]
		[IdCodMovimiento]
		[Descripcion]
		[IdCodProducto]
		[CantKilos]
		[CantPzas]
		[TipoMovimiento]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusqCanalesEmbarque.
	''' </summary>
	Public Enum VwBusqCanalesEmbarqueFieldIndex
		[KgrsRastro]
		[KgrsBascula]
		[KgrsCalientes]
		[FolioSacrificio]
		[Estatus]
		[Nombre]
		[CodigoBarra]
		[FechaSacrificio]
		[IdCliente]
		[IdFolioCanal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaAplicacionFormula.
	''' </summary>
	Public Enum VwBusquedaAplicacionFormulaFieldIndex
		[FolAplF]
		[FechaAplicacion]
		[Costo]
		[Estatus]
		[Cabezas]
		[TotalServidas]
		[IdAlmacen]
		[Nombre]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaAplicacionMedicamento.
	''' </summary>
	Public Enum VwBusquedaAplicacionMedicamentoFieldIndex
		[FolioAplicacionMedicamento]
		[IdAlmacen]
		[Almacen]
		[IdUsuarioAlta]
		[FolioMovimientoAlmacen]
		[FechaAplicacionMedicamento]
		[FechaCaptura]
		[TotalCabezas]
		[TotalKilos]
		[CostoTotal]
		[Estatus]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaClientes.
	''' </summary>
	Public Enum VwBusquedaClientesFieldIndex
		[Nombre]
		[IdEstado]
		[IdCiudad]
		[IdPoblacion]
		[EstatusCad]
		[FechaAlta]
		[Domicilio]
		[Colonia]
		[RazonSocial]
		[Rfc]
		[IdCliente]
		[Estatus]
		[IntroductorCad]
		[Introductor]
		[Poblacion]
		[TipoPersonaCad]
		[TipoPersona]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaComparacionMedicamentos.
	''' </summary>
	Public Enum VwBusquedaComparacionMedicamentosFieldIndex
		[FolioAplicacionMedicamento]
		[FechaAplicacionMedicamento]
		[Medicamento]
		[UnidadMedida]
		[Lote]
		[Corral]
		[CosProm]
		[Cantidad]
		[ImporteReal]
		[CantidadTeorica]
		[DifPorc]
		[Cabezas]
		[Kilos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaComprasdeGanado.
	''' </summary>
	Public Enum VwBusquedaComprasdeGanadoFieldIndex
		[FolioRecepcionCompra]
		[FechaRecepcionCompra]
		[IdProveedor]
		[Proveedor]
		[IdLugarCompra]
		[LugarCompra]
		[IdCompradorGanado]
		[CompradorGanado]
		[IdCorral]
		[Corral]
		[NumGuias]
		[ImpteXguia]
		[CabezasComp]
		[KilosComp]
		[ImpteComp]
		[StaCerrado]
		[Status]
		[CostosIndi]
		[PesoEntReal]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaComprasGanadoDetalle.
	''' </summary>
	Public Enum VwBusquedaComprasGanadoDetalleFieldIndex
		[FolioRecepcionCompra]
		[IdTipoGanado]
		[TipoGanado]
		[Cabezas]
		[KilosComprados]
		[PrecioXkilo]
		[KilosRecibidos]
		[Importe]
		[KilosPromedioPorCabeza]
		[CostoPromedioXcabeza]
		[FecRecep]
		[CveProveGan]
		[CveLugCom]
		[CveComiGan]
		[CveCorral]
		[Status]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaCortes.
	''' </summary>
	Public Enum VwBusquedaCortesFieldIndex
		[IdFolioEtiqueta]
		[LoteCorte]
		[IdAlmacen]
		[Almacen]
		[TipoAlmacen]
		[NomCorte]
		[CodPreCorte]
		[NomSubCorte]
		[CodCorte]
		[CantPzas]
		[CantKgrs]
		[FechaCorte]
		[FechaCad]
		[Estatus]
		[TotalPzas]
		[TotalKgs]
		[IdCorte]
		[IdProducto]
		[IdCliente]
		[LoteSacrificio]
		[Grados]
		[IdFolioMovimiento]
		[IdFolioEmbarque]
		[IdClienteEmb]
		[IdPuntoEntrega]
		[IdChofer]
		[FechaEmbarque]
		[CodigoBarra]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaCotizaciones.
	''' </summary>
	Public Enum VwBusquedaCotizacionesFieldIndex
		[IdCotizacion]
		[IdSucursal]
		[IdProveedor]
		[Observaciones]
		[Importe]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[FechaAlta]
		[Estatus]
		[Proveedor]
		[Plaza]
		[PlazId]
		[EstatusStr]
		[Sucursal]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaDevoluciones.
	''' </summary>
	Public Enum VwBusquedaDevolucionesFieldIndex
		[Folio]
		[Embarque]
		[IdCliente]
		[Nombre]
		[IdPrecorte]
		[Precorte]
		[IdCorte]
		[Corte]
		[EnCaja]
		[UtilparaVenta]
		[Piezas]
		[Kilos]
		[Estatus]
		[FechaCaptura]
		[FolioMovimientoAlmacen]
		[IdMotivoDevolucion]
		[IdFolioEtiqueta]
		[EstatusCad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaEmbarques.
	''' </summary>
	Public Enum VwBusquedaEmbarquesFieldIndex
		[IdFolioEmbarque]
		[FechaEmbarque]
		[IdCliente]
		[Nombre]
		[IdVehiculo]
		[Vehiculo]
		[IdChofer]
		[Chofer]
		[TotalPiezas]
		[TotalKgrs]
		[EstatusCad]
		[Domicilio]
		[Rfc]
		[Estatus]
		[TotalCajas]
		[FolioEmbarqueEmp]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaLoteCortes.
	''' </summary>
	Public Enum VwBusquedaLoteCortesFieldIndex
		[LoteCorte]
		[LoteSacrificio]
		[FechaCorte]
		[IdCliente]
		[Introductor]
		[TotalKgs]
		[EstatusCad]
		[Estatus]
		[DiasCad]
		[TipoLote]
		[EsReproceso]
		[TotalPzas]
		[Producto]
		[Descripcion]
		[Precioxkilototal]
		[KilosRecibidos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaMovimientosAlmacen.
	''' </summary>
	Public Enum VwBusquedaMovimientosAlmacenFieldIndex
		[IdAlmacen]
		[FolioMovimiento]
		[FechaMovimiento]
		[IdTipoMovimiento]
		[CostoTotal]
		[Origen]
		[Referencia]
		[UsuarioId]
		[FechaContabilizacion]
		[PolizaContabilidad]
		[Entrega]
		[Recibe]
		[Observaciones]
		[Almacen]
		[TipoMovimiento]
		[Direccion]
		[AfectaCosto]
		[EstatusContabilizado]
		[DireccionStr]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaPreparacionMezcla.
	''' </summary>
	Public Enum VwBusquedaPreparacionMezclaFieldIndex
		[FolPrepForm]
		[IdPlaza]
		[FecPrepForm]
		[IdAlmacen]
		[Almacen]
		[IdMezcla]
		[Mezcla]
		[CantaPreparar]
		[CantRealaPrep]
		[CostoTotal]
		[Estatus]
		[EstatusStr]
		[Lote]
		[IdEnvase]
		[Envase]
		[CantidadEnvase]
		[Plaza]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaProductosCapturaInventarioFisico.
	''' </summary>
	Public Enum VwBusquedaProductosCapturaInventarioFisicoFieldIndex
		[Nombre]
		[Lndescripcion]
		[PdIdProducto]
		[PdDescripcion]
		[Umdescripcion]
		[PdSeManejaPorLotes]
		[Lote]
		[PdIdSubLinea]
		[SlidLinea]
		[IdAlmacen]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaProrrateoMedicamento.
	''' </summary>
	Public Enum VwBusquedaProrrateoMedicamentoFieldIndex
		[FolioProrrateoMedicamento]
		[IdAlmacen]
		[FolioMovimientoAlmacenSalida]
		[FechaProrrateo]
		[FechaCaptura]
		[CostoTotal]
		[Estatus]
		[Almacen]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaProveedor.
	''' </summary>
	Public Enum VwBusquedaProveedorFieldIndex
		[IdProveedor]
		[PrRfc]
		[PrRazSocial]
		[PrBeneficiario]
		[PrContacto]
		[PrRepLegal]
		[PrEstatus]
		[PrDomicilio]
		[PrColonia]
		[CodigoPostal]
		[IdPoblacion]
		[PrIdUsuarioAlta]
		[PrFechaAlta]
		[PrIdUsuarioBaja]
		[PrFechaBaja]
		[PrIdMotivoBaja]
		[PrObservacionesBaja]
		[PrCuentaContId]
		[PrCuentaAnt]
		[Poblacion]
		[EstatusCad]
		[EsdeGanado]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaTransferenciaEntrada.
	''' </summary>
	Public Enum VwBusquedaTransferenciaEntradaFieldIndex
		[FolioTransferenciaEntrada]
		[IdAlmacenDestino]
		[AlmacenDestino]
		[FechaMovimiento]
		[TotalProductos]
		[Importe]
		[Estatus]
		[IdAlmacenOrigen]
		[AlmacenOrigen]
		[FolioTransferenciaSalida]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwBusquedaTransferenciaSalida.
	''' </summary>
	Public Enum VwBusquedaTransferenciaSalidaFieldIndex
		[FolioTransferencia]
		[IdAlmacenOrigen]
		[AlmacenOrigen]
		[IdAlmacenDestino]
		[AlmacenDestino]
		[FechaMovimiento]
		[TotalProductos]
		[Importe]
		[Estatus]
		[EstatusStr]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwClientes.
	''' </summary>
	Public Enum VwClientesFieldIndex
		[IdCliente]
		[Nombre]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwComGanExistenciaEnCorrales.
	''' </summary>
	Public Enum VwComGanExistenciaEnCorralesFieldIndex
		[IdCorral]
		[NombreCorral]
		[Cabezas]
		[Kilos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwComGanExistenciaEnCorralesPorTipodeGanado.
	''' </summary>
	Public Enum VwComGanExistenciaEnCorralesPorTipodeGanadoFieldIndex
		[IdCorral]
		[NombreCorral]
		[Cabezas]
		[Kilos]
		[IdTipoGanado]
		[Descripcion]
		[CostoEnt]
		[ImpteMedicamento]
		[ImpteAlimento]
		[KilosAlimento]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwComGanExistenciasLotesCorrales.
	''' </summary>
	Public Enum VwComGanExistenciasLotesCorralesFieldIndex
		[IdLote]
		[NombreLote]
		[IdCorral]
		[NombreCorral]
		[SaldoCabezas]
		[SaldoKilos]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompBusqCotizacionServicios.
	''' </summary>
	Public Enum VwCompBusqCotizacionServiciosFieldIndex
		[Folio]
		[FolioCotizacion]
		[SucursalId]
		[Scdescripcion]
		[ScidPlaza]
		[Pldescripcion]
		[ProveedorId]
		[PrRazSocial]
		[FolioSolicitud]
		[Indice]
		[Servicio]
		[Cantidad]
		[Total]
		[FechaAlta]
		[Estatus]
		[Costo]
		[Descuento]
		[EstatusSolicitud]
		[Iva]
		[FolioOrdenServicio]
		[SubTotal2]
		[Descuento2]
		[Total2]
		[Iva2]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompBusqSolicitudServicios.
	''' </summary>
	Public Enum VwCompBusqSolicitudServiciosFieldIndex
		[Servicio]
		[FechaServicio]
		[Urgente]
		[Cantidad]
		[SucursalId]
		[Scdescripcion]
		[PlidPlaza]
		[Pldescripcion]
		[Folio]
		[Indice]
		[Estatus]
		[FechaAlta]
		[Estatus2]
		[EstatusDet]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompConsultaOrdenCompra.
	''' </summary>
	Public Enum VwCompConsultaOrdenCompraFieldIndex
		[IdOrdenCompra]
		[FolioOrdenCompra]
		[PlIdPlaza]
		[PlDescripcion]
		[IdSucursal]
		[Sucursal]
		[IdProveedor]
		[Proveedor]
		[Importe]
		[Descuento]
		[SubTotal]
		[Ivatotal]
		[Total]
		[FechaOrdenCompra]
		[Observaciones]
		[Estatus]
		[Autorizada]
		[Recibida]
		[EstatusDes]
		[Moneda]
		[TipoCambio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompCotizacionServicios.
	''' </summary>
	Public Enum VwCompCotizacionServiciosFieldIndex
		[Folio]
		[SucursalId]
		[ProveedorId]
		[IdPlaza]
		[Plaza]
		[Proveedor]
		[Estatus]
		[Sucursal]
		[FechaAlta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompFiniquitoOrdenCompra.
	''' </summary>
	Public Enum VwCompFiniquitoOrdenCompraFieldIndex
		[IdOrdenCompra]
		[Autorizada]
		[SucursalId]
		[Sucursal]
		[ProveedorId]
		[Proveedor]
		[Importe]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[Fecha]
		[Estatus]
		[Ordenado]
		[Recibido]
		[IdPlaza]
		[FolioOrdenCompra]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompOrdenesdeCompra.
	''' </summary>
	Public Enum VwCompOrdenesdeCompraFieldIndex
		[FolioOrdenCompra]
		[PlIdPlaza]
		[PlDescripcion]
		[SucursalId]
		[Sucursal]
		[ProveedorId]
		[Proveedor]
		[MonedaId]
		[Moneda]
		[Importe]
		[Descuento]
		[SubTotal]
		[IvaTotal]
		[Total]
		[FechaAlta]
		[Observaciones]
		[Estatus]
		[IdCotizacion]
		[IdSolicitud]
		[Autorizada]
		[Recibida]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompRecepciondeOrdenes.
	''' </summary>
	Public Enum VwCompRecepciondeOrdenesFieldIndex
		[IdOrdenCompra]
		[IdSucursal]
		[Sucursal]
		[IdPlaza]
		[Plaza]
		[IdProveedor]
		[Proveedor]
		[Estatus]
		[ProveedorId]
		[Estatus2]
		[FechaRecepcion]
		[FolioOrdenCompra]
		[AlmacenId]
		[Nombre]
		[Foliorecepcionordencompra]
		[Idrecepcionordencompra]
		[EsDirecta]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompReporteCotizaciones.
	''' </summary>
	Public Enum VwCompReporteCotizacionesFieldIndex
		[IdCotizacion]
		[IdSucursal]
		[Scdescripcion]
		[ScidPlaza]
		[Pldescripcion]
		[FechaAlta]
		[Observaciones]
		[IdProducto]
		[PdDescripcion]
		[Cantidad]
		[Umdescripcion]
		[IdProveedor]
		[PrRazSocial]
		[Precio]
		[Descuento]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompReporteOrdenesCompra.
	''' </summary>
	Public Enum VwCompReporteOrdenesCompraFieldIndex
		[IdOrdenCompra]
		[IdSucursal]
		[Scdescripcion]
		[ScidPlaza]
		[Pldescripcion]
		[FechaAlta]
		[Observaciones]
		[IdProducto]
		[PdDescripcion]
		[CantidadSolicitada]
		[CantidadOrdenar]
		[CantPendientexRecibir]
		[Umdescripcion]
		[IdProveedor]
		[PrRazSocial]
		[Precio]
		[Descuento]
		[Importe]
		[Estatus]
		[Autorizada]
		[Recibida]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompReporteOrdenesServicios.
	''' </summary>
	Public Enum VwCompReporteOrdenesServiciosFieldIndex
		[Servicio]
		[FolioDetalleSolicitud]
		[Indice]
		[CantidadSolicitada]
		[CantidadOrdenar]
		[Precio]
		[Descuento]
		[Iva]
		[Importe]
		[Folio]
		[SucursalId]
		[ProveedorId]
		[FechaAlta]
		[Scdescripcion]
		[ScidPlaza]
		[Pldescripcion]
		[PrRazSocial]
		[Estatus]
		[RecibidaCad]
		[Recibida]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompReportePresupuestos.
	''' </summary>
	Public Enum VwCompReportePresupuestosFieldIndex
		[Folio]
		[SucursalId]
		[Scdescripcion]
		[ScidPlaza]
		[TipoPresupuestoId]
		[FechaAlta]
		[ProductoId]
		[Presupuesto]
		[Obserbaciones]
		[Cantidad]
		[PdDescripcion]
		[Pldescripcion]
		[Umdescripcion]
		[TipoPresupuesto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompReporteRecepcionesOrdenesCompra.
	''' </summary>
	Public Enum VwCompReporteRecepcionesOrdenesCompraFieldIndex
		[IdRecepcionOrdenCompra]
		[IdOrdenCompra]
		[IdSucursal]
		[Scdescripcion]
		[ScidPlaza]
		[Pldescripcion]
		[Observaciones]
		[IdProducto]
		[PdDescripcion]
		[Cantidad]
		[Umdescripcion]
		[ProveedorId]
		[PrRazSocial]
		[FolioMovimientoAml]
		[AlmacenId]
		[FolioMovimientoAlmCan]
		[FechaRecepcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompsolicitudes.
	''' </summary>
	Public Enum VwCompsolicitudesFieldIndex
		[NoSolicitud]
		[Fecha]
		[ClavePlaza]
		[Plaza]
		[ClaveSucursal]
		[Sucursal]
		[EstatusSolicitud]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCompSolicitudServicios.
	''' </summary>
	Public Enum VwCompSolicitudServiciosFieldIndex
		[SucursalId]
		[Scdescripcion]
		[Folio]
		[FechaAlta]
		[Pldescripcion]
		[PlidPlaza]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaCortesParaReimprecion.
	''' </summary>
	Public Enum VwConsultaCortesParaReimprecionFieldIndex
		[IdFolioEtiqueta]
		[LoteCorte]
		[CantPzas]
		[CantKgrs]
		[FechaCorte]
		[FechaCad]
		[Estatus]
		[IdPreCorte]
		[IdCorte]
		[PreCorte]
		[Corte]
		[IdFolioEmbarque]
		[EstatusCad]
		[LoteCorteReproceso]
		[IdFolioMovimientoAlmacenReproceso]
		[IdFolioMovimientoAlmacenAjuste]
		[FechaCaptura]
		[IdCliente]
		[Cliente]
		[FechaEmbarque]
		[CodigoBarra]
		[IdAlmacenActual]
		[IdAlmacenOrigen]
		[TipoProducto]
		[FechaCaducidad]
		[FechaCaducidadNueva]
		[IdFolioMovimientoAlmacenCongelado]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaFacturas.
	''' </summary>
	Public Enum VwConsultaFacturasFieldIndex
		[NoFactura]
		[IdCliente]
		[Nombre]
		[FechaFactura]
		[FechaCaptura]
		[FechaVencimiento]
		[Contado]
		[Credito]
		[Subtotal]
		[Iva]
		[Total]
		[Estatus]
		[EstatusCad]
		[Observaciones]
		[Rfc]
		[IdFolioEmbarque]
		[IdPoliza]
		[Domicilio]
		[IdClienteCargo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaFacturasSinFiltrado.
	''' </summary>
	Public Enum VwConsultaFacturasSinFiltradoFieldIndex
		[Serie]
		[NoFactura]
		[IdCliente]
		[Nombre]
		[FechaFactura]
		[FechaCaptura]
		[FechaVencimiento]
		[Contado]
		[Credito]
		[Subtotal]
		[Iva]
		[Total]
		[Estatus]
		[EstatusCad]
		[Observaciones]
		[Rfc]
		[IdFolioEmbarque]
		[IdPoliza]
		[Domicilio]
		[IdClienteCargo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaNomina.
	''' </summary>
	Public Enum VwConsultaNominaFieldIndex
		[Folio]
		[Quincena]
		[Fecha]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaPakingListDetalle.
	''' </summary>
	Public Enum VwConsultaPakingListDetalleFieldIndex
		[LoteCorte]
		[IdFolioEtiqueta]
		[IdCorte]
		[IdProducto]
		[CantPzas]
		[CantKgrs]
		[Estatus]
		[IdFolioEmbarque]
		[IdFolioMovimiento]
		[CodigoBarra]
		[IdFolioEtiquetaReferencia]
		[Grados]
		[IdCliente]
		[FechaCaptura]
		[LoteCorteReproceso]
		[IdFolioMovimientoAlmacenReproceso]
		[IdFolioMovimientoAlmacenAjuste]
		[FechaCaducidad]
		[FechaCaducidadAnterior]
		[IdFolioMovimientoAlmacenCongelado]
		[GradosAnterior]
		[TipoProducto]
		[IdAlmacenActual]
		[IdAlmacenOrigen]
		[TipoProductoAnterior]
		[CantLibras]
		[MasDe30Meses]
		[Farenheit]
		[ProductoIngles]
		[Producto]
		[PreCorte]
		[PreCorteIngles]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwConsultaSacrificios.
	''' </summary>
	Public Enum VwConsultaSacrificiosFieldIndex
		[FolioSacrificio]
		[IdCliente]
		[FechaSacrificio]
		[CantCabSacrificio]
		[CantCanales]
		[KgsEnPie]
		[KgsCanal]
		[Estatus]
		[Cliente]
		[EstatusCad]
		[LoteRastro]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwContCuentas.
	''' </summary>
	Public Enum VwContCuentasFieldIndex
		[CuentaContable]
		[NombreCuenta]
		[Naturaleza]
		[SaldoAñoAnterior]
		[SaldoInicioEjercicio]
		[Afectable]
		[Inactiva]
		[Codigo]
		[NaturalezaCad]
		[Bancos]
		[Departamentalizable]
		[Presupuesto]
		[Resultados]
		[Cta]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[BancosCad]
		[PresupuestoCad]
		[DepartamentalizableCad]
		[ResultadosCad]
		[AfectableCad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCuentasFisc.
	''' </summary>
	Public Enum VwCuentasFiscFieldIndex
		[CuentaContable]
		[NombreCuenta]
		[Naturaleza]
		[SaldoAñoAnterior]
		[SaldoInicioEjercicio]
		[Afectable]
		[Inactiva]
		[Codigo]
		[NaturalezaCad]
		[Bancos]
		[Departamentalizable]
		[Presupuesto]
		[Resultados]
		[Cta]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[BancosCad]
		[PresupuestoCad]
		[DepartamentalizableCad]
		[ResultadosCad]
		[AfectableCad]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxcfacturasClientes.
	''' </summary>
	Public Enum VwCxcfacturasClientesFieldIndex
		[IdCliente]
		[NoFactura]
		[IdClienteCargo]
		[FechaFactura]
		[FechaVencimiento]
		[Total]
		[ImporteIngreso]
		[SaldoFactura]
		[Nombre]
		[Serie]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxcreporteCobranzaDiario.
	''' </summary>
	Public Enum VwCxcreporteCobranzaDiarioFieldIndex
		[CveCliente]
		[Nombre]
		[FolIngreso]
		[FolFactura]
		[Ingreso]
		[Documento]
		[Estatus]
		[FechaIngreso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxpauxiliarPasivos.
	''' </summary>
	Public Enum VwCxpauxiliarPasivosFieldIndex
		[Cta]
		[SubCta]
		[SsubCta]
		[SssubCta]
		[NomCuenta]
		[IdProveedor]
		[PrRazSocial]
		[NoFactura]
		[FechaFactura]
		[FechaVencimiento]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxpfacturas.
	''' </summary>
	Public Enum VwCxpfacturasFieldIndex
		[NoFactura]
		[IdProveedor]
		[FechaFactura]
		[PrIdTipoProveedor]
		[TprDescripcion]
		[PrRazSocial]
		[FechaVencimiento]
		[SubTotal]
		[Iva]
		[Total]
		[Anticipo]
		[FolioRecepcion]
		[Fecha]
		[FolioOrdenCompra]
		[CantidadRecepcion]
		[ImporteRecepcion]
		[EstatusFacturas]
		[Cheque]
		[SubtotalRecepcion]
		[IvaRecepcion]
		[EsServicio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxpfacturasAgrupadas.
	''' </summary>
	Public Enum VwCxpfacturasAgrupadasFieldIndex
		[NoFactura]
		[IdProveedor]
		[FechaFactura]
		[PrIdTipoProveedor]
		[TprDescripcion]
		[PrRazSocial]
		[FechaVencimiento]
		[SubTotal]
		[Iva]
		[Total]
		[Anticipo]
		[Cheque]
		[EstatusFacturas]
		[EsServicio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwCxpfacturasSinContabilizar.
	''' </summary>
	Public Enum VwCxpfacturasSinContabilizarFieldIndex
		[NoFactura]
		[FechaCaptura]
		[FechaFactura]
		[Importe]
		[FechaContabilizacion]
		[IdProveedor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwFacturas.
	''' </summary>
	Public Enum VwFacturasFieldIndex
		[EmpresaId]
		[IdProveedor]
		[NoFactura]
		[FechaFactura]
		[FechaVencimiento]
		[SubTotal]
		[Iva]
		[Importe]
		[EstatusFactura]
		[PrRazSocial]
		[Gastos]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwHistorialdeComprasdeProductos.
	''' </summary>
	Public Enum VwHistorialdeComprasdeProductosFieldIndex
		[IdProveedor]
		[PrRazSocial]
		[IdProducto]
		[FechaRecepcion]
		[Costo]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwMovAlmacenDet.
	''' </summary>
	Public Enum VwMovAlmacenDetFieldIndex
		[Folio]
		[AlmacenId]
		[Codigo]
		[Producto]
		[Cantidad]
		[Costo]
		[Descuento]
		[Expr1]
		[Importe]
		[Medida]
		[IdMedida]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwMovAmacenCab.
	''' </summary>
	Public Enum VwMovAmacenCabFieldIndex
		[AlmacenId]
		[Almacen]
		[FolioMovimiento]
		[Fecha]
		[TipoMovimientoId]
		[Entrega]
		[Recibe]
		[Observaciones]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwMovimientosAlmacenGeneral.
	''' </summary>
	Public Enum VwMovimientosAlmacenGeneralFieldIndex
		[Codigo]
		[Nombre]
		[FolioMovimiento]
		[TipoMovimientoId]
		[Movimiento]
		[PdDescripcion]
		[PdIdUnidadMedida]
		[Umdescripcion]
		[ProductoId]
		[Cantidad]
		[Costo]
		[Descuento]
		[Expr1]
		[FechaMovimiento]
		[Referencia]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwOrdenesServicio.
	''' </summary>
	Public Enum VwOrdenesServicioFieldIndex
		[Folio]
		[Observaciones]
		[Plaza]
		[SucursalId]
		[Sucursal]
		[ProveedorId]
		[MonedaId]
		[TipoCambio]
		[DiasCredito]
		[FechaAlta]
		[Descuento]
		[SubTotal]
		[Iva]
		[Total]
		[TipoMoneda]
		[Estatus]
		[Autorizada]
		[Proveedor]
		[Moneda]
		[Recibida]
		[IdPlaza]
		[RecibidaEnum]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwPagoClientes.
	''' </summary>
	Public Enum VwPagoClientesFieldIndex
		[FolIngreso]
		[CveCliente]
		[FecIngreso]
		[Nombre]
		[Importe]
		[Estatus]
		[EstatusCad]
		[FolFactura]
		[Cuenta]
		[BncDescripcion]
		[TipoFactura]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwPagoClientesCabecero.
	''' </summary>
	Public Enum VwPagoClientesCabeceroFieldIndex
		[FolIngreso]
		[CveCliente]
		[FecIngreso]
		[Nombre]
		[Importe]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwpagosaProveedores.
	''' </summary>
	Public Enum VwpagosaProveedoresFieldIndex
		[EmpresaId]
		[IdProveedor]
		[Cheque]
		[PolizaId]
		[CuentaBancariaId]
		[Estatus]
		[FechaMovimiento]
		[Importe]
		[Cuenta]
		[NumeroPoliza]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwPolizas.
	''' </summary>
	Public Enum VwPolizasFieldIndex
		[Codigo]
		[EmpresaId]
		[TipoCad]
		[TipoPoliza]
		[FechaPoliza]
		[NumeroPoliza]
		[FechaCaptura]
		[Importe]
		[OrigenCad]
		[EstatusCad]
		[Concepto]
		[Origen]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdCortes.
	''' </summary>
	Public Enum VwProdCortesFieldIndex
		[LoteCorte]
		[CodPreCorte]
		[PreCorte]
		[CodCorte]
		[Corte]
		[CantPzas]
		[CantKgrs]
		[IdFolioEtiqueta]
		[IdCliente]
		[Nombre]
		[Estatus]
		[IdFolioEmbarque]
		[LoteSacrificio]
		[FechaCorte]
		[FechaCad]
		[IdAlmacenActual]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdCortesAgrupados.
	''' </summary>
	Public Enum VwProdCortesAgrupadosFieldIndex
		[LoteCorte]
		[LoteSacrificio]
		[FechaCorte]
		[FechaCad]
		[IdCliente]
		[Nombre]
		[Estatus]
		[TotalPiezas]
		[PiezasExistentes]
		[PiezasEmbarcadas]
		[TotalKilos]
		[KilosExistentes]
		[KilosEmbarcados]
		[TotalCajas]
		[CajasExistentes]
		[CajasEmbarcadas]
		[CajasCanceladas]
		[CanalesAcorte]
		[KilosAcorte]
		[PiezasCanceladas]
		[KilosCancelados]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdDetalleCanales.
	''' </summary>
	Public Enum VwProdDetalleCanalesFieldIndex
		[FolioSacrificio]
		[IdFolioCanal]
		[KgrsBascula]
		[Estatus]
		[LoteCorte]
		[FolioEmbarque]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdRegistroCanales.
	''' </summary>
	Public Enum VwProdRegistroCanalesFieldIndex
		[FolioSacrificio]
		[FechaSacrificio]
		[CantCanales]
		[Estatus]
		[KgrsBascula]
		[CanalesEnCorte]
		[KilosEnCorte]
		[CanalesEnEmbarque]
		[KilosEnEmbarque]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdRendimientosCortes.
	''' </summary>
	Public Enum VwProdRendimientosCortesFieldIndex
		[FolioSacrificio]
		[FechaSacrificio]
		[IdCodCliente]
		[Nombre]
		[PorcientoEnviadoaCorte]
		[KilosAcorte]
		[CanalesAcorte]
		[IdProducto]
		[Corte]
		[Piezas]
		[Kilos]
		[RendimientoPorCorte]
		[RendimientoPorPiezas]
		[PiezasProducidas]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProdRendimientosSacrificios.
	''' </summary>
	Public Enum VwProdRendimientosSacrificiosFieldIndex
		[FolioSacrificio]
		[FechaSacrificio]
		[CantCabSacrificio]
		[KgsEnPie]
		[IdCodCliente]
		[Nombre]
		[Canales]
		[KilosCalientes]
		[KilosBasculas]
		[RendimientoPorSacrificio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProductosEnAlmacen.
	''' </summary>
	Public Enum VwProductosEnAlmacenFieldIndex
		[AlmacenId]
		[ProductoId]
		[PdDescripcion]
		[Umdescripcion]
		[LnidLinea]
		[CodigoBarra]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProductosGanado.
	''' </summary>
	Public Enum VwProductosGanadoFieldIndex
		[IdProducto]
		[Descripcion]
		[Canal]
		[Estatus]
		[Corte]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwProductosGenerales.
	''' </summary>
	Public Enum VwProductosGeneralesFieldIndex
		[PdIdProducto]
		[PdDescripcion]
		[PdDescrpcionCorta]
		[PdIdLinea]
		[PdIdUnidadMedida]
		[PdIdMarca]
		[PdIdPresentacion]
		[PdSeFactura]
		[PdSeRecibeParcial]
		[PdSeObtieneMermas]
		[PdSeRecibeSinFactura]
		[PdSeFacturaSinExistencia]
		[PdSeManejaPorLotes]
		[PdProductoGeneral]
		[PdMezcla]
		[PdIngrediente]
		[PdMaterialEnvase]
		[PdDiasMaxCaducidad]
		[PdPiezas]
		[PdIdUsuarioAlta]
		[PdFechaAlta]
		[PdIdUsuarioBaja]
		[PdFechaBaja]
		[PdIdMotivoBaja]
		[PdObservacionBaja]
		[PdEstatus]
		[PdCodigoRelacionado]
		[PdTipoProducto]
		[PdCaduca]
		[PdSeAplicaIva]
		[FactorConver]
		[FechaUltimaCompra]
		[CantidadUltimaCompra]
		[ImporteUltimaCompra]
		[UltimoCosto]
		[ArtPuntoVenta]
		[ArtMeat]
		[CodigoBarra]
		[PorcIeps]
		[PdEsKit]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwRegistroSacrificio.
	''' </summary>
	Public Enum VwRegistroSacrificioFieldIndex
		[LoteRecepcion]
		[LoteEngorda]
		[FechaRecepcion]
		[IdCliente]
		[KilosRecibidos]
		[CantCabezas]
		[Unidad]
		[Conductor]
		[Placas]
		[SumaCabezasDet]
		[SumaCabezasMuertas]
		[Estatus]
		[KilosPromedio]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteCanales.
	''' </summary>
	Public Enum VwReporteCanalesFieldIndex
		[FolioSacrificio]
		[Fecha]
		[NumRes]
		[Canal]
		[Kilogramos]
		[EstatusCadena]
		[LoteCorte]
		[FolioEmbarque]
		[Estatus]
		[Introductor]
		[IdCliente]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteComprativoInventario.
	''' </summary>
	Public Enum VwReporteComprativoInventarioFieldIndex
		[Nombre]
		[Existencia]
		[ProductoId]
		[AlmacenId]
		[PdDescripcion]
		[Cantidad]
		[FechaInventario]
		[Diferencia]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteDecomisos.
	''' </summary>
	Public Enum VwReporteDecomisosFieldIndex
		[FolioSacrificio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[Nombre]
		[Descripcion]
		[IdCodCliente]
		[FechaSacrificio]
		[NomDecomiso]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReportedeEmabarquesDetallado.
	''' </summary>
	Public Enum VwReportedeEmabarquesDetalladoFieldIndex
		[IdFolioEmbarque]
		[FechaEmbarque]
		[IdCliente]
		[Nombre]
		[Vehiculo]
		[Chofer]
		[TotalPiezas]
		[TotalKgrs]
		[TotalCajas]
		[Estado]
		[Ciudad]
		[Poblacion]
		[Direccion]
		[Descripcion]
		[Colonia]
		[Telefono]
		[CodigoPostal]
		[IdFolioEtiqueta]
		[IdProducto]
		[Producto]
		[CantPzas]
		[CantKgrs]
		[FolioEmbarqueEmp]
		[LoteCorte]
		[FechaCorte]
		[PrecioxKgr]
		[ImporteCaja]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteDeEmbarques.
	''' </summary>
	Public Enum VwReporteDeEmbarquesFieldIndex
		[Nombre]
		[FechaEmbarque]
		[IdFolioEmbarque]
		[FolioEmbarqueEmp]
		[NoFactura]
		[Descripcion]
		[Kilos]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteDeEmbarquesConcentrado.
	''' </summary>
	Public Enum VwReporteDeEmbarquesConcentradoFieldIndex
		[IdCliente]
		[Nombre]
		[FechaEmbarque]
		[IdFolioEmbarque]
		[FolioEmbarqueEmp]
		[NoFactura]
		[Estatus]
		[ImporteFactura]
		[Descripcion]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteDevoluciones.
	''' </summary>
	Public Enum VwReporteDevolucionesFieldIndex
		[Folio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[Embarque]
		[IdCliente]
		[UtilparaVenta]
		[UtilparaVentaCad]
		[EnCaja]
		[EnCajaCad]
		[IdFolioEtiqueta]
		[FolioMovimientoAlmacen]
		[FolioMovimeintoAlmacenCancelacion]
		[FechaCaptura]
		[FechaCancelacion]
		[IdUsuarioAlta]
		[IdMotivoDevolucion]
		[Estatus]
		[EstatusCad]
		[Nombre]
		[MotivoDevolucion]
		[Producto]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteEmbarques.
	''' </summary>
	Public Enum VwReporteEmbarquesFieldIndex
		[IdFolioEmbarque]
		[FechaEmbarque]
		[Cliente]
		[Producto]
		[Estatus]
		[CantPzas]
		[CantKgrs]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteExistenciaSubProductos.
	''' </summary>
	Public Enum VwReporteExistenciaSubProductosFieldIndex
		[FolioSacrificio]
		[IdProducto]
		[Piezas]
		[Kilos]
		[KilosSalida]
		[PiezasSalida]
		[Nombre]
		[Descripcion]
		[IdCodCliente]
		[ExistenciaPiezas]
		[ExistenciaKilos]
		[FechaSacrificio]
		[NomDecomiso]
		[Decomiso]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteMovimientosProduccion.
	''' </summary>
	Public Enum VwReporteMovimientosProduccionFieldIndex
		[Codigo]
		[Nombre]
		[IdMovimiento]
		[TipoMovimiento]
		[IdProducto]
		[Producto]
		[IdFolioMovimiento]
		[FechaMovimiento]
		[FechaCancelacion]
		[QuienCancelo]
		[CantKilos]
		[CantPzas]
		[CostoUnitario]
		[Iva]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwReporteNomina.
	''' </summary>
	Public Enum VwReporteNominaFieldIndex
		[Nombre]
		[Quincena]
		[Fecha]
		[ImporteSueldo]
		[Comisiones]
		[ImporteHorasExtras]
		[ImporteTotalCuotaMensual]
		[ImporteIsrsegunTarifa]
		[ImporteSubsidioalEmpleo]
		[Pretamos]
		[Infonavit]
		[ImportePensionAlimenticia]
		[Folio]
		[IdEmpleado]
		[SueldoDiario]
		[Descripcion]
		[NomDepto]
		[HorasExtrasTriples]
		[HorasExtrasDobles]
		[DiasTrabajados]
		[SmregionA]
		[SmregionC]
		[MesComercial]
		[Factor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwTraspasoDeCajas.
	''' </summary>
	Public Enum VwTraspasoDeCajasFieldIndex
		[FolioTransferencia]
		[IdAlmacenDestino]
		[FechaMovimiento]
		[FechaCaptura]
		[Kilos]
		[Piezas]
		[Almacen]
		[EstatusCad]
		[Estatus]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwVentasXfactura.
	''' </summary>
	Public Enum VwVentasXfacturaFieldIndex
		[Factura]
		[Fecha]
		[Cliente]
		[TipoFactura]
		[SubTotal]
		[Iva]
		[Total]
		[Embarque]
		[Descuento]
		[Sta]
		[Contado]
		[IdCliente]
		[Vendedor]
		[IdVendedor]
		AmountOfFields
	End Enum


	''' <summary>
	''' Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : VwVtasEmbarques.
	''' </summary>
	Public Enum VwVtasEmbarquesFieldIndex
		[IdFolioEmbarque]
		[FechaEmbarque]
		[Nombre]
		[Vehiculo]
		[Chofer]
		[TotalPiezas]
		[TotalKgrs]
		[TotalCajas]
		[Estado]
		[Ciudad]
		[Poblacion]
		[Direccion]
		[Descripcion]
		[Colonia]
		[Telefono]
		[CodigoPostal]
		[IdFolioEtiqueta]
		[IdProducto]
		[Producto]
		[CantPzas]
		[CantKgrs]
		[NoFactura]
		[Estatus]
		AmountOfFields
	End Enum

 
	''' <summary>
	''' Index Enum To fast-access TypedList Fields In the Columns collection of the Typed List: ListaCorrales
	''' </summary>
	Public Enum ListaCorralesTypedListFieldIndex
		IdCorral
		NombreCorral
		NomCorCorral
		IdTipoCorral
		Capacidad
		Estatus
		TipoCorral
		Superficie
		AmountOfFields
	End Enum

 
	''' <summary>
	''' Index Enum To fast-access TypedList Fields In the Columns collection of the Typed List: ListaLotes
	''' </summary>
	Public Enum ListaLotesTypedListFieldIndex
		IdLote
		IdCorral
		NombreLote
		NomCorLote
		SaldoKilos
		SaldoKilosAlim
		SaldoImpteAlim
		SaldoImpteMed
		SaldoImpte
		SaldoCabezas
		FechaInicio
		SaldoCostoInd
		AmountOfFields
	End Enum

 
	''' <summary>
	''' Index Enum To fast-access TypedList Fields In the Columns collection of the Typed List: ListaNotasVenta
	''' </summary>
	Public Enum ListaNotasVentaTypedListFieldIndex
		Codigo
		Sucursal
		Estatus
		SubTotal
		Descuento
		Total
		FechaVenta
		MotivoCancelacion
		ObservacionesCancelacion
		Iva
		Ieps
		Importe
		Pago
		Cambio
		UsuarioAlta
		AmountOfFields
	End Enum

 
	''' <summary>
	''' Index Enum To fast-access TypedList Fields In the Columns collection of the Typed List: MovimientosAlmacenGeneral
	''' </summary>
	Public Enum MovimientosAlmacenGeneralTypedListFieldIndex
		FolioMovimiento
		ProductoId
		Producto
		TipoMovimeinto
		TipoMovimientoId
		FechaMovimiento
		Almacen
		AlmacenId
		Costo
		Cantidad
		AmountOfFields
	End Enum

 
	''' <summary>
	''' Index Enum To fast-access TypedList Fields In the Columns collection of the Typed List: ProductosGenerales
	''' </summary>
	Public Enum ProductosGeneralesTypedListFieldIndex
		Codigo
		Descripcion
		AmountOfFields
	End Enum


	''' <summary>
	''' Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	''' </summary>
	Public Enum EntityType
		AcumuladoCuentasContablesEntity
		AlmacenEntity
		AlmacenCatalogoEntity
		AlmacenesFamiliasEntity
		AlmacenesSucursalEntity
		AlmacenSucursalEntity
		AplicMediEntity
		AplicMediDetEntity
		AplicMediDetDetEntity
		AutCreditoEmbEntity
		AutorizaProcesosEntity
		BancosEntity
		BeneficiarioEntity
		BitacoraFolioEntity
		BitacoraPvEntity
		CabAplForEntity
		CabBalanceEntity
		CabEdoResEntity
		CabFacturasEntity
		CabGasTransEntity
		CabMediReimEntity
		CabMediTrabEntity
		CabMovGanEntity
		CabPrepFormEntity
		CabProMedEntity
		CabRecCorEntity
		CabRegComEntity
		CatAgrupadoresBalGralEdoResEntity
		CatDeptosEntity
		CatIntroductoresEntity
		CatLugaresDeCompraEntity
		CatLugComEntity
		CatMovGanEntity
		CatMovimientosAlmacenPvEntity
		CatNutrientesEntity
		CatPrexCortEntity
		CatPrexProdEntity
		CatProveedoresEntity
		CatRastrosEntity
		CatTipNotasEntity
		CfgCtrlCtasEntity
		ChequeEntity
		ChequeDevueltoEntity
		ChequesPosEntity
		CierreFicticioEntity
		CierreLoteEntity
		CiudadEntity
		ClasificadorDeEstadosFinancierosEntity
		ClienteEntity
		ComicionistaEntity
		ConceptoCajaEntity
		ConceptoFlujoEntity
		ConceptoFlujoCuentaEntity
		ConCfgCtasEntity
		CondicionesPagoEntity
		ConfigGanEntity
		ConfigPuntoVtaEntity
		ConfiguracionChequesImpEntity
		ConfiguracionFacturaEntity
		ConfiguracionLecturaEtiquetaEntity
		ConLotSacEntity
		ConMesEntity
		ContDiotTiposOperacionEntity
		ContDiotTiposTercerosEntity
		ControlTurnoEntity
		CostoIndirectoEntity
		CostoProductoEntity
		CostoProductoProveedorEntity
		CotizacionServicioEntity
		CotizacionServicioDetalleEntity
		CuentaEntity
		CuentaContableEntity
		CuentasFiscalEntity
		DetAlimentosEntity
		DetalleClasificadordeEstadosFinancierosEntity
		DetalleKitPvEntity
		DetAplForEntity
		DetBalanceEntity
		DetDproMedEntity
		DetEdoResEntity
		DetFacturasEntity
		DetGasTransEntity
		DetMovGanEntity
		DetPrepFormEntity
		DetPrepFormLoteEntity
		DetProMedEntity
		DetRecCorEntity
		DetRegComEntity
		DevolucionProductosEntity
		DocumentoEntity
		DocumentoDetalleEntity
		DocumentoImagenEntity
		DocumentoTextoEntity
		DocumentoTipoEntity
		DocumentoTipoCampoEntity
		DomicilioFiscalEntity
		DomicilioFiscalesClientesEntity
		ECtSatcatBancosEntity
		EstadoEntity
		FacturaFoliosEntity
		FacturasClientesCabEntity
		FacturasClientesDetEntity
		FacturasClientesDetProductosTotalesEntity
		FolioEntity
		FolioFacturaEntity
		FormaPagoEntity
		GastosDepartamentosEntity
		HistorialCambiosFechaEntity
		IngresoCajaEntity
		InventarioAlmacenEntity
		inventarioAlmacenLotesEntity
		InventarioConfiguracionEntity
		InventarioFisicoEntity
		InventarioMovimientoAlmacenEntity
		InventarioMovimientoAlmacenDetallesEntity
		InvHistorialPvEntity
		LineaEntity
		ListadePreciosEntity
		ListaPrecioEntity
		ListaPrecioDetalleEntity
		MarcaEntity
		McatCentroCostosEntity
		McattiposclienteEntity
		McecatCorralesCabEntity
		McecatCorralesDetEntity
		McecatLotesCabEntity
		McecatLotesCabForEntity
		McecatLotesDetEntity
		McecatTiposCorralEntity
		McgcatCausasMuerteEntity
		McgcatChoferesEntity
		McgcatCompradoresdeGanadoEntity
		McgcatConcepGastosEntity
		McgcatMovGanadoEntity
		McgcatTiposdeGanadoEntity
		McgcatVehiculosEntity
		McgcompraGanadoCabEntity
		McgcompraGanadoDetEntity
		McgconfiguracionMovimientoGanadoEntity
		McomCotizacionCompraEntity
		McomCotizacionCompraProveedorEntity
		McomCotizacionCompraProveedorDetalleEntity
		McomRecepcionOrdenCompraDetEntity
		MetodoCabEntity
		MetodoDetEntity
		MetodoPagoEntity
		MfacCatClientesEntity
		MfacClientesDatosFiscalesEntity
		MfacEmbarquesCabEntity
		MfacEmbarquesDetEntity
		MgcnfFoliadorAlmacenEntity
		MgcnfFoliadoresEntity
		MgcnfFoliosEntity
		MgralcatPuntosEntregaEntity
		MinvMovimientosAlmacenPvEntity
		MinvMovimientosAlmacenPvdetallesEntity
		MinvTransferenciaAlmacenEntradaEntity
		MinvTransferenciaAlmacenEntradaDetalleEntity
		MinvTransferenciaAlmacenProdEntity
		MinvTransferenciaAlmacenProdDetalleEntity
		MinvTransferenciaAlmacenSalidaEntity
		MinvTransferenciaAlmacenSalidaDetalleEntity
		ModuloEntity
		MonedaEntity
		MotivoBajaEntity
		MotivoBajaDetalleEntity
		MotivoCancelacionEntity
		MotivoCancelacionDetalleEntity
		MsccatDecomisosEntity
		MsccatMotivoDevolucionEntity
		MsccatMovtosAlmacenEntity
		MsccatProductosEntity
		MsccatProductosDetalleEntity
		MsccatServiciosRastroEntity
		MsccatTiposAlmacenEntity
		MsccomprasCanalesEntity
		MscconfigMovtosAlmacenEntity
		MsccortesPreCortesEntity
		MscdetCanalAcorteEntity
		MscdetCanalComprasEntity
		MscinventarioFisicoEntity
		MscinventarioProductoEntity
		MscloteCortesCabEntity
		MscloteCortesDetEntity
		MscloteCortesDetComparacionEntity
		MscmovtosAlmacenCabEntity
		MscmovtosAlmacenDetEntity
		MscproductosDecomisosEntity
		MscproductosValorAgregadoEntity
		MscrecepcionCanalesCabEntity
		MscrecepcionCanalesDetEntity
		MscregistroSacrificioCabEntity
		MscrelacionCortesClientesEntity
		MscrelacionProductosRastrosEntity
		MscsalidasGanadoCabEntity
		MscsalidasGanadoDetEntity
		MveCtaEntity
		MvtosBancariosCbEntity
		NomCatEmpleadosEntity
		NomCatPuestosEntity
		NomConfiguracionEntity
		NomDiasVacacionesEntity
		NomImportesEntity
		NomImssinfonavitEntity
		NomIsrEntity
		NomSubsidioEmpleoEntity
		NotaCreditoCabEntity
		NotaCreditoDetEntity
		NotaVentaEntity
		NotaVentaDetalleEntity
		NotaVentaDetalleRespEntity
		NotaVentaRespEntity
		OrdenCompraEntity
		OrdenCompraDetalleEntity
		OrdenServicioEntity
		OrdenServicioDetalleEntity
		PagoCheDevueltoCabEntity
		PagoCheDevueltoDetEntity
		PagoDeCtesEntity
		PeriodosContEntity
		PlazaEntity
		PoblacionEntity
		PogrCbEntity
		PoGrDtEntity
		PolizaEntity
		PolizaDetalleEntity
		PolizasModeloCabEntity
		PolizasModeloDetEntity
		PresentacionEntity
		PresupuestoEntity
		PresupuestoCompraDetalleEntity
		ProductoEntity
		ProductoCostoIndirectoEntity
		ProductoDerivadoEntity
		ProductoMezclaEntity
		ProrraRecEntity
		ProveedorEntity
		ProveedorAvanzadoEntity
		PvnotasVentaRetCabEntity
		PvnotasVentaRetDetEntity
		RecepcionGanadoEntity
		RecepcionOrdenCompraEntity
		ReferenciaProductoDerivadoEntity
		RegistroSacrificiosCabEntity
		RegistroSacrificiosDecomisosEntity
		RegistroSacrificiosDetEntity
		RetiroCajaEntity
		RFCEntity
		SalidaGanadoCabEntity
		SalidaGanadoDetEntity
		SatAgrupadorEntity
		ServiciosEntity
		ServiciosPorSacrificioEntity
		ServiciosXembarqueEntity
		SolicitudProductoEntity
		SolicitudProductoDetalleEntity
		SolicitudServiciosEntity
		SolicitudServiciosDetalleEntity
		SubLineaEntity
		SucursalEntity
		TipoAlmacenEntity
		TipoCambioEntity
		TipoComicionistaEntity
		TipoMonedaEntity
		TipoMotivoEntity
		TipoMovimientoAlmacenEntity
		TipoPresupuestoEntity
		TipoProductoEntity
		TipoProveedorEntity
		TipoVentaEntity
		UnidadMedidaEntity
		UsrBanDepositosEntity
		UsrConfigContabilidadEntity
		UsrCxpfacturasApagarEntity
		UsrCxpfacturasCabEntity
		UsrCxpfacturasDetEntity
		UsrCxpfacturasDetRecepcionesEntity
		UsrCxppagosProveedoresEntity
		UsrProdConfiguracionEntity
		UsrProdRecepcionDetalleEntity
		UsrProdRecepcionGanadoDetEntity
		UsrProdRegistroSacrificiosDecomisoEntity
		UsuariosSucursalEntity
		UsuarioSucursalEntity
		ZonaEntity
		ZonaDetalleEntity
	End Enum



	''' <summary>
	''' Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.
	''' </summary>
	Public Enum TypedViewType
		ComCotizacionesTypedView
		ListaParaAnalizarCotizacionCompraTypedView
		VwAlmKardexTypedView
		VwAlmKardexDetalleTypedView
		VwAlmKardexProduccionTypedView
		VwAlmKardexProduccionDetTypedView
		VwAlmTarjetasTypedView
		VwBusqCanalesEmbarqueTypedView
		VwBusquedaAplicacionFormulaTypedView
		VwBusquedaAplicacionMedicamentoTypedView
		VwBusquedaClientesTypedView
		VwBusquedaComparacionMedicamentosTypedView
		VwBusquedaComprasdeGanadoTypedView
		VwBusquedaComprasGanadoDetalleTypedView
		VwBusquedaCortesTypedView
		VwBusquedaCotizacionesTypedView
		VwBusquedaDevolucionesTypedView
		VwBusquedaEmbarquesTypedView
		VwBusquedaLoteCortesTypedView
		VwBusquedaMovimientosAlmacenTypedView
		VwBusquedaPreparacionMezclaTypedView
		VwBusquedaProductosCapturaInventarioFisicoTypedView
		VwBusquedaProrrateoMedicamentoTypedView
		VwBusquedaProveedorTypedView
		VwBusquedaTransferenciaEntradaTypedView
		VwBusquedaTransferenciaSalidaTypedView
		VwClientesTypedView
		VwComGanExistenciaEnCorralesTypedView
		VwComGanExistenciaEnCorralesPorTipodeGanadoTypedView
		VwComGanExistenciasLotesCorralesTypedView
		VwCompBusqCotizacionServiciosTypedView
		VwCompBusqSolicitudServiciosTypedView
		VwCompConsultaOrdenCompraTypedView
		VwCompCotizacionServiciosTypedView
		VwCompFiniquitoOrdenCompraTypedView
		VwCompOrdenesdeCompraTypedView
		VwCompRecepciondeOrdenesTypedView
		VwCompReporteCotizacionesTypedView
		VwCompReporteOrdenesCompraTypedView
		VwCompReporteOrdenesServiciosTypedView
		VwCompReportePresupuestosTypedView
		VwCompReporteRecepcionesOrdenesCompraTypedView
		VwCompsolicitudesTypedView
		VwCompSolicitudServiciosTypedView
		VwConsultaCortesParaReimprecionTypedView
		VwConsultaFacturasTypedView
		VwConsultaFacturasSinFiltradoTypedView
		VwConsultaNominaTypedView
		VwConsultaPakingListDetalleTypedView
		VwConsultaSacrificiosTypedView
		VwContCuentasTypedView
		VwCuentasFiscTypedView
		VwCxcfacturasClientesTypedView
		VwCxcreporteCobranzaDiarioTypedView
		VwCxpauxiliarPasivosTypedView
		VwCxpfacturasTypedView
		VwCxpfacturasAgrupadasTypedView
		VwCxpfacturasSinContabilizarTypedView
		VwFacturasTypedView
		VwHistorialdeComprasdeProductosTypedView
		VwMovAlmacenDetTypedView
		VwMovAmacenCabTypedView
		VwMovimientosAlmacenGeneralTypedView
		VwOrdenesServicioTypedView
		VwPagoClientesTypedView
		VwPagoClientesCabeceroTypedView
		VwpagosaProveedoresTypedView
		VwPolizasTypedView
		VwProdCortesTypedView
		VwProdCortesAgrupadosTypedView
		VwProdDetalleCanalesTypedView
		VwProdRegistroCanalesTypedView
		VwProdRendimientosCortesTypedView
		VwProdRendimientosSacrificiosTypedView
		VwProductosEnAlmacenTypedView
		VwProductosGanadoTypedView
		VwProductosGeneralesTypedView
		VwRegistroSacrificioTypedView
		VwReporteCanalesTypedView
		VwReporteComprativoInventarioTypedView
		VwReporteDecomisosTypedView
		VwReportedeEmabarquesDetalladoTypedView
		VwReporteDeEmbarquesTypedView
		VwReporteDeEmbarquesConcentradoTypedView
		VwReporteDevolucionesTypedView
		VwReporteEmbarquesTypedView
		VwReporteExistenciaSubProductosTypedView
		VwReporteMovimientosProduccionTypedView
		VwReporteNominaTypedView
		VwTraspasoDeCajasTypedView
		VwVentasXfacturaTypedView
		VwVtasEmbarquesTypedView
	End Enum


#Region "Custom ConstantsEnums Code"
	
	' __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
End Namespace


