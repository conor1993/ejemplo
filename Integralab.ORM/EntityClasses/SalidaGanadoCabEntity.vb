' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:21
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
	''' <summary>Entity class which represents the entity 'SalidaGanadoCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class SalidaGanadoCabEntity 
#Else
	<Serializable()> _
	Public Class SalidaGanadoCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabFacturas As Integralab.ORM.CollectionClasses.CabFacturasCollection
		Private _alwaysFetchCabFacturas, _alreadyFetchedCabFacturas As Boolean
		Private _conLotSac As Integralab.ORM.CollectionClasses.ConLotSacCollection
		Private _alwaysFetchConLotSac, _alreadyFetchedConLotSac As Boolean
		Private _prorraRec As Integralab.ORM.CollectionClasses.ProrraRecCollection
		Private _alwaysFetchProrraRec, _alreadyFetchedProrraRec As Boolean
		Private _salidaGanadoDet As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
		Private _alwaysFetchSalidaGanadoDet, _alreadyFetchedSalidaGanadoDet As Boolean
		Private _polizaCollectionViaCabFacturas As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCabFacturas, _alreadyFetchedPolizaCollectionViaCabFacturas As Boolean
		Private _polizaCollectionViaCabFacturas_ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCabFacturas_, _alreadyFetchedPolizaCollectionViaCabFacturas_ As Boolean
		Private _mcecatCorralesCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaProrraRec, _alreadyFetchedMcecatCorralesCabCollectionViaProrraRec As Boolean
		Private _mcecatLotesCabCollectionViaProrraRec As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaProrraRec, _alreadyFetchedMcecatLotesCabCollectionViaProrraRec As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet As Boolean
		Private _mcecatLotesDetCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
		Private _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet, _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet As Boolean
		Private _cabMovGan As CabMovGanEntity
		Private _alwaysFetchCabMovGan, _alreadyFetchedCabMovGan, _cabMovGanReturnsNewIfNotFound As Boolean
		Private _mcecatLotesCab As McecatLotesCabEntity
		Private _alwaysFetchMcecatLotesCab, _alreadyFetchedMcecatLotesCab, _mcecatLotesCabReturnsNewIfNotFound As Boolean
		Private _mcgcatCausasMuerte As McgcatCausasMuerteEntity
		Private _alwaysFetchMcgcatCausasMuerte, _alreadyFetchedMcgcatCausasMuerte, _mcgcatCausasMuerteReturnsNewIfNotFound As Boolean
		Private _catRastros As CatRastrosEntity
		Private _alwaysFetchCatRastros, _alreadyFetchedCatRastros, _catRastrosReturnsNewIfNotFound As Boolean
		Private _mcecatCorralesCab As McecatCorralesCabEntity
		Private _alwaysFetchMcecatCorralesCab, _alreadyFetchedMcecatCorralesCab, _mcecatCorralesCabReturnsNewIfNotFound As Boolean
		Private _poliza As PolizaEntity
		Private _alwaysFetchPoliza, _alreadyFetchedPoliza, _polizaReturnsNewIfNotFound As Boolean


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
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		Public Sub New(idSalidaGanadoCab As System.Int32)

			InitClassFetch(idSalidaGanadoCab, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idSalidaGanadoCab As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idSalidaGanadoCab, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="validator">The custom validator Object for this SalidaGanadoCabEntity</param>
		Public Sub New(idSalidaGanadoCab As System.Int32, validator As IValidator)

			InitClassFetch(idSalidaGanadoCab, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabFacturas = CType(info.GetValue("_cabFacturas", GetType(Integralab.ORM.CollectionClasses.CabFacturasCollection)), Integralab.ORM.CollectionClasses.CabFacturasCollection)
			_alwaysFetchCabFacturas = info.GetBoolean("_alwaysFetchCabFacturas")
			_alreadyFetchedCabFacturas = info.GetBoolean("_alreadyFetchedCabFacturas")
			_conLotSac = CType(info.GetValue("_conLotSac", GetType(Integralab.ORM.CollectionClasses.ConLotSacCollection)), Integralab.ORM.CollectionClasses.ConLotSacCollection)
			_alwaysFetchConLotSac = info.GetBoolean("_alwaysFetchConLotSac")
			_alreadyFetchedConLotSac = info.GetBoolean("_alreadyFetchedConLotSac")
			_prorraRec = CType(info.GetValue("_prorraRec", GetType(Integralab.ORM.CollectionClasses.ProrraRecCollection)), Integralab.ORM.CollectionClasses.ProrraRecCollection)
			_alwaysFetchProrraRec = info.GetBoolean("_alwaysFetchProrraRec")
			_alreadyFetchedProrraRec = info.GetBoolean("_alreadyFetchedProrraRec")
			_salidaGanadoDet = CType(info.GetValue("_salidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)
			_alwaysFetchSalidaGanadoDet = info.GetBoolean("_alwaysFetchSalidaGanadoDet")
			_alreadyFetchedSalidaGanadoDet = info.GetBoolean("_alreadyFetchedSalidaGanadoDet")
			_polizaCollectionViaCabFacturas = CType(info.GetValue("_polizaCollectionViaCabFacturas", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCabFacturas = info.GetBoolean("_alwaysFetchPolizaCollectionViaCabFacturas")
			_alreadyFetchedPolizaCollectionViaCabFacturas = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCabFacturas")
			_polizaCollectionViaCabFacturas_ = CType(info.GetValue("_polizaCollectionViaCabFacturas_", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCabFacturas_ = info.GetBoolean("_alwaysFetchPolizaCollectionViaCabFacturas_")
			_alreadyFetchedPolizaCollectionViaCabFacturas_ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCabFacturas_")
			_mcecatCorralesCabCollectionViaProrraRec = CType(info.GetValue("_mcecatCorralesCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaProrraRec")
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec")
			_mcecatLotesCabCollectionViaProrraRec = CType(info.GetValue("_mcecatLotesCabCollectionViaProrraRec", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaProrraRec = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaProrraRec")
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaProrraRec")
			_mcecatLotesCabCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcecatLotesCabCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet")
			_mcecatLotesDetCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesDetCollection)), Integralab.ORM.CollectionClasses.McecatLotesDetCollection)
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet")
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet")
			_cabMovGan = CType(info.GetValue("_cabMovGan", GetType(CabMovGanEntity)), CabMovGanEntity)
			If Not _cabMovGan Is Nothing Then
				AddHandler _cabMovGan.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabMovGanReturnsNewIfNotFound = info.GetBoolean("_cabMovGanReturnsNewIfNotFound")
			_alwaysFetchCabMovGan = info.GetBoolean("_alwaysFetchCabMovGan")
			_alreadyFetchedCabMovGan = info.GetBoolean("_alreadyFetchedCabMovGan")
			_mcecatLotesCab = CType(info.GetValue("_mcecatLotesCab", GetType(McecatLotesCabEntity)), McecatLotesCabEntity)
			If Not _mcecatLotesCab Is Nothing Then
				AddHandler _mcecatLotesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatLotesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatLotesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatLotesCab = info.GetBoolean("_alwaysFetchMcecatLotesCab")
			_alreadyFetchedMcecatLotesCab = info.GetBoolean("_alreadyFetchedMcecatLotesCab")
			_mcgcatCausasMuerte = CType(info.GetValue("_mcgcatCausasMuerte", GetType(McgcatCausasMuerteEntity)), McgcatCausasMuerteEntity)
			If Not _mcgcatCausasMuerte Is Nothing Then
				AddHandler _mcgcatCausasMuerte.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatCausasMuerteReturnsNewIfNotFound = info.GetBoolean("_mcgcatCausasMuerteReturnsNewIfNotFound")
			_alwaysFetchMcgcatCausasMuerte = info.GetBoolean("_alwaysFetchMcgcatCausasMuerte")
			_alreadyFetchedMcgcatCausasMuerte = info.GetBoolean("_alreadyFetchedMcgcatCausasMuerte")
			_catRastros = CType(info.GetValue("_catRastros", GetType(CatRastrosEntity)), CatRastrosEntity)
			If Not _catRastros Is Nothing Then
				AddHandler _catRastros.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catRastrosReturnsNewIfNotFound = info.GetBoolean("_catRastrosReturnsNewIfNotFound")
			_alwaysFetchCatRastros = info.GetBoolean("_alwaysFetchCatRastros")
			_alreadyFetchedCatRastros = info.GetBoolean("_alreadyFetchedCatRastros")
			_mcecatCorralesCab = CType(info.GetValue("_mcecatCorralesCab", GetType(McecatCorralesCabEntity)), McecatCorralesCabEntity)
			If Not _mcecatCorralesCab Is Nothing Then
				AddHandler _mcecatCorralesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatCorralesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatCorralesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatCorralesCab = info.GetBoolean("_alwaysFetchMcecatCorralesCab")
			_alreadyFetchedMcecatCorralesCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCab")
			_poliza = CType(info.GetValue("_poliza", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza Is Nothing Then
				AddHandler _poliza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_polizaReturnsNewIfNotFound = info.GetBoolean("_polizaReturnsNewIfNotFound")
			_alwaysFetchPoliza = info.GetBoolean("_alwaysFetchPoliza")
			_alreadyFetchedPoliza = info.GetBoolean("_alreadyFetchedPoliza")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabFacturas = (_cabFacturas.Count > 0)
			_alreadyFetchedConLotSac = (_conLotSac.Count > 0)
			_alreadyFetchedProrraRec = (_prorraRec.Count > 0)
			_alreadyFetchedSalidaGanadoDet = (_salidaGanadoDet.Count > 0)
			_alreadyFetchedPolizaCollectionViaCabFacturas = (_polizaCollectionViaCabFacturas.Count > 0)
			_alreadyFetchedPolizaCollectionViaCabFacturas_ = (_polizaCollectionViaCabFacturas_.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = (_mcecatCorralesCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = (_mcecatLotesCabCollectionViaProrraRec.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = (_mcecatLotesCabCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = (_mcecatLotesDetCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = (_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedCabMovGan = Not(_cabMovGan Is Nothing)
			_alreadyFetchedMcecatLotesCab = Not(_mcecatLotesCab Is Nothing)
			_alreadyFetchedMcgcatCausasMuerte = Not(_mcgcatCausasMuerte Is Nothing)
			_alreadyFetchedCatRastros = Not(_catRastros Is Nothing)
			_alreadyFetchedMcecatCorralesCab = Not(_mcecatCorralesCab Is Nothing)
			_alreadyFetchedPoliza = Not(_poliza Is Nothing)

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
			info.AddValue("_conLotSac", _conLotSac)
			info.AddValue("_alwaysFetchConLotSac", _alwaysFetchConLotSac)
			info.AddValue("_alreadyFetchedConLotSac", _alreadyFetchedConLotSac)
			info.AddValue("_prorraRec", _prorraRec)
			info.AddValue("_alwaysFetchProrraRec", _alwaysFetchProrraRec)
			info.AddValue("_alreadyFetchedProrraRec", _alreadyFetchedProrraRec)
			info.AddValue("_salidaGanadoDet", _salidaGanadoDet)
			info.AddValue("_alwaysFetchSalidaGanadoDet", _alwaysFetchSalidaGanadoDet)
			info.AddValue("_alreadyFetchedSalidaGanadoDet", _alreadyFetchedSalidaGanadoDet)
			info.AddValue("_polizaCollectionViaCabFacturas", _polizaCollectionViaCabFacturas)
			info.AddValue("_alwaysFetchPolizaCollectionViaCabFacturas", _alwaysFetchPolizaCollectionViaCabFacturas)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCabFacturas", _alreadyFetchedPolizaCollectionViaCabFacturas)
			info.AddValue("_polizaCollectionViaCabFacturas_", _polizaCollectionViaCabFacturas_)
			info.AddValue("_alwaysFetchPolizaCollectionViaCabFacturas_", _alwaysFetchPolizaCollectionViaCabFacturas_)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCabFacturas_", _alreadyFetchedPolizaCollectionViaCabFacturas_)
			info.AddValue("_mcecatCorralesCabCollectionViaProrraRec", _mcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaProrraRec", _alwaysFetchMcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec", _alreadyFetchedMcecatCorralesCabCollectionViaProrraRec)
			info.AddValue("_mcecatLotesCabCollectionViaProrraRec", _mcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaProrraRec", _alwaysFetchMcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaProrraRec", _alreadyFetchedMcecatLotesCabCollectionViaProrraRec)
			info.AddValue("_mcecatLotesCabCollectionViaSalidaGanadoDet", _mcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet", _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet", _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", _mcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet", _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet", _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet)
			info.AddValue("_cabMovGan", _cabMovGan)
			info.AddValue("_cabMovGanReturnsNewIfNotFound", _cabMovGanReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabMovGan", _alwaysFetchCabMovGan)
			info.AddValue("_alreadyFetchedCabMovGan", _alreadyFetchedCabMovGan)
			info.AddValue("_mcecatLotesCab", _mcecatLotesCab)
			info.AddValue("_mcecatLotesCabReturnsNewIfNotFound", _mcecatLotesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatLotesCab", _alwaysFetchMcecatLotesCab)
			info.AddValue("_alreadyFetchedMcecatLotesCab", _alreadyFetchedMcecatLotesCab)
			info.AddValue("_mcgcatCausasMuerte", _mcgcatCausasMuerte)
			info.AddValue("_mcgcatCausasMuerteReturnsNewIfNotFound", _mcgcatCausasMuerteReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatCausasMuerte", _alwaysFetchMcgcatCausasMuerte)
			info.AddValue("_alreadyFetchedMcgcatCausasMuerte", _alreadyFetchedMcgcatCausasMuerte)
			info.AddValue("_catRastros", _catRastros)
			info.AddValue("_catRastrosReturnsNewIfNotFound", _catRastrosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatRastros", _alwaysFetchCatRastros)
			info.AddValue("_alreadyFetchedCatRastros", _alreadyFetchedCatRastros)
			info.AddValue("_mcecatCorralesCab", _mcecatCorralesCab)
			info.AddValue("_mcecatCorralesCabReturnsNewIfNotFound", _mcecatCorralesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatCorralesCab", _alwaysFetchMcecatCorralesCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCab", _alreadyFetchedMcecatCorralesCab)
			info.AddValue("_poliza", _poliza)
			info.AddValue("_polizaReturnsNewIfNotFound", _polizaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza", _alwaysFetchPoliza)
			info.AddValue("_alreadyFetchedPoliza", _alreadyFetchedPoliza)

			
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
				Case "CabMovGan"
					_alreadyFetchedCabMovGan = True
					Me.CabMovGan = CType(entity, CabMovGanEntity)
				Case "McecatLotesCab"
					_alreadyFetchedMcecatLotesCab = True
					Me.McecatLotesCab = CType(entity, McecatLotesCabEntity)
				Case "McgcatCausasMuerte"
					_alreadyFetchedMcgcatCausasMuerte = True
					Me.McgcatCausasMuerte = CType(entity, McgcatCausasMuerteEntity)
				Case "CatRastros"
					_alreadyFetchedCatRastros = True
					Me.CatRastros = CType(entity, CatRastrosEntity)
				Case "McecatCorralesCab"
					_alreadyFetchedMcecatCorralesCab = True
					Me.McecatCorralesCab = CType(entity, McecatCorralesCabEntity)
				Case "Poliza"
					_alreadyFetchedPoliza = True
					Me.Poliza = CType(entity, PolizaEntity)
				Case "CabFacturas"
					_alreadyFetchedCabFacturas = True
					If Not entity Is Nothing Then
						Me.CabFacturas.Add(CType(entity, CabFacturasEntity))
					End If
				Case "ConLotSac"
					_alreadyFetchedConLotSac = True
					If Not entity Is Nothing Then
						Me.ConLotSac.Add(CType(entity, ConLotSacEntity))
					End If
				Case "ProrraRec"
					_alreadyFetchedProrraRec = True
					If Not entity Is Nothing Then
						Me.ProrraRec.Add(CType(entity, ProrraRecEntity))
					End If
				Case "SalidaGanadoDet"
					_alreadyFetchedSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoDet.Add(CType(entity, SalidaGanadoDetEntity))
					End If
				Case "PolizaCollectionViaCabFacturas"
					_alreadyFetchedPolizaCollectionViaCabFacturas = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCabFacturas.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaCabFacturas_"
					_alreadyFetchedPolizaCollectionViaCabFacturas_ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCabFacturas_.Add(CType(entity, PolizaEntity))
					End If
				Case "McecatCorralesCabCollectionViaProrraRec"
					_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaProrraRec.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaProrraRec"
					_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaProrraRec.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaSalidaGanadoDet"
					_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaSalidaGanadoDet.Add(CType(entity, McecatLotesCabEntity))
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

				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CabMovGan"
					SetupSyncCabMovGan(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCab"
					SetupSyncMcecatLotesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcatCausasMuerte"
					SetupSyncMcgcatCausasMuerte(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CatRastros"
					SetupSyncCatRastros(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					SetupSyncMcecatCorralesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza"
					SetupSyncPoliza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabFacturas"
					_cabFacturas.Add(CType(relatedEntity, CabFacturasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ConLotSac"
					_conLotSac.Add(CType(relatedEntity, ConLotSacEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ProrraRec"
					_prorraRec.Add(CType(relatedEntity, ProrraRecEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					_salidaGanadoDet.Add(CType(relatedEntity, SalidaGanadoDetEntity))
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
				Case "CabMovGan"
					DesetupSyncCabMovGan(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCab"
					DesetupSyncMcecatLotesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcatCausasMuerte"
					DesetupSyncMcgcatCausasMuerte(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CatRastros"
					DesetupSyncCatRastros(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					DesetupSyncMcecatCorralesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza"
					DesetupSyncPoliza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabFacturas"
					MyBase.PerformRelatedEntityRemoval(_cabFacturas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ConLotSac"
					MyBase.PerformRelatedEntityRemoval(_conLotSac, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ProrraRec"
					MyBase.PerformRelatedEntityRemoval(_prorraRec, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _cabMovGan Is Nothing Then
				toReturn.Add(_cabMovGan)
			End If
			If Not _mcecatLotesCab Is Nothing Then
				toReturn.Add(_mcecatLotesCab)
			End If
			If Not _mcgcatCausasMuerte Is Nothing Then
				toReturn.Add(_mcgcatCausasMuerte)
			End If
			If Not _catRastros Is Nothing Then
				toReturn.Add(_catRastros)
			End If
			If Not _mcecatCorralesCab Is Nothing Then
				toReturn.Add(_mcecatCorralesCab)
			End If
			If Not _poliza Is Nothing Then
				toReturn.Add(_poliza)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cabFacturas)
			toReturn.Add(_conLotSac)
			toReturn.Add(_prorraRec)
			toReturn.Add(_salidaGanadoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idSalidaGanadoCab As System.Int32) As Boolean
			Return FetchUsingPK(idSalidaGanadoCab, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idSalidaGanadoCab As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idSalidaGanadoCab, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idSalidaGanadoCab As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idSalidaGanadoCab, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdSalidaGanadoCab, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As SalidaGanadoCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As SalidaGanadoCabFieldIndex) As Boolean
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
				_cabFacturas.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ConLotSacEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConLotSacEntity'</returns>
		Public Function GetMultiConLotSac(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConLotSacCollection
			Return GetMultiConLotSac(forceFetch, _conLotSac.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConLotSacEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiConLotSac(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConLotSacCollection
			Return GetMultiConLotSac(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConLotSacEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ConLotSacEntity'</returns>
		Public Function GetMultiConLotSac(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConLotSacCollection
			Return GetMultiConLotSac(forceFetch, _conLotSac.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ConLotSacEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiConLotSac(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConLotSacCollection
			If ( Not _alreadyFetchedConLotSac Or forceFetch Or _alwaysFetchConLotSac) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _conLotSac.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_conLotSac)
					End If
				End If
				_conLotSac.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_conLotSac.EntityFactoryToUse = entityFactoryToUse
				End If
				_conLotSac.GetMultiManyToOne(Me, Filter)
				_conLotSac.SuppressClearInGetMulti = False
				_alreadyFetchedConLotSac = True
			End If
			Return _conLotSac
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ConLotSac'. These settings will be taken into account
		''' when the property ConLotSac is requested or GetMultiConLotSac is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersConLotSac(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_conLotSac.SortClauses=sortClauses
			_conLotSac.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_prorraRec.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
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
				_salidaGanadoDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCabFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCabFacturas(forceFetch, _polizaCollectionViaCabFacturas.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCabFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCabFacturas Or forceFetch Or _alwaysFetchPolizaCollectionViaCabFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCabFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCabFacturas)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, "__SalidaGanadoCabEntity__", "CabFacturas_", JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza, "CabFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
				_polizaCollectionViaCabFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCabFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCabFacturas.GetMulti(Filter, relations)
				_polizaCollectionViaCabFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCabFacturas = True
			End If
			Return _polizaCollectionViaCabFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCabFacturas'. These settings will be taken into account
		''' when the property PolizaCollectionViaCabFacturas is requested or GetMultiPolizaCollectionViaCabFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCabFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCabFacturas.SortClauses=sortClauses
			_polizaCollectionViaCabFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCabFacturas_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCabFacturas_(forceFetch, _polizaCollectionViaCabFacturas_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCabFacturas_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCabFacturas_ Or forceFetch Or _alwaysFetchPolizaCollectionViaCabFacturas_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCabFacturas_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCabFacturas_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, "__SalidaGanadoCabEntity__", "CabFacturas_", JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza, "CabFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
				_polizaCollectionViaCabFacturas_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCabFacturas_.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCabFacturas_.GetMulti(Filter, relations)
				_polizaCollectionViaCabFacturas_.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCabFacturas_ = True
			End If
			Return _polizaCollectionViaCabFacturas_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCabFacturas_'. These settings will be taken into account
		''' when the property PolizaCollectionViaCabFacturas_ is requested or GetMultiPolizaCollectionViaCabFacturas_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCabFacturas_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCabFacturas_.SortClauses=sortClauses
			_polizaCollectionViaCabFacturas_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatCorralesCabEntityUsingIdCorralReciba, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
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
				relations.Add(SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", "ProrraRec_", JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatLotesCabEntityUsingIdLote, "ProrraRec_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
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

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet(forceFetch, _mcecatLotesCabCollectionViaSalidaGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaSalidaGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaSalidaGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
				_mcecatLotesCabCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaSalidaGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaSalidaGanadoDet.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaSalidaGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = True
			End If
			Return _mcecatLotesCabCollectionViaSalidaGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaSalidaGanadoDet'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaSalidaGanadoDet is requested or GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaSalidaGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaSalidaGanadoDet.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaSalidaGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
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
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab), ComparisonOperator.Equal, Me.IdSalidaGanadoCab))
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

		''' <summary>Retrieves the related entity of type 'CabMovGanEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CabMovGanEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMovGan() As CabMovGanEntity
			Return GetSingleCabMovGan(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabMovGanEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabMovGanEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMovGan(forceFetch As Boolean) As CabMovGanEntity
			If ( Not _alreadyFetchedCabMovGan Or forceFetch Or _alwaysFetchCabMovGan) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CabMovGanEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioMovimientoGanado)
				End If
				If Not _cabMovGanReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CabMovGan = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabMovGanEntity)
					End If
					Me.CabMovGan = newEntity
					_alreadyFetchedCabMovGan = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabMovGan
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab() As McecatLotesCabEntity
			Return GetSingleMcecatLotesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab(forceFetch As Boolean) As McecatLotesCabEntity
			If ( Not _alreadyFetchedMcecatLotesCab Or forceFetch Or _alwaysFetchMcecatLotesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatLotesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdLoteDestino.GetValueOrDefault())
				End If
				If Not _mcecatLotesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatLotesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatLotesCabEntity)
					End If
					Me.McecatLotesCab = newEntity
					_alreadyFetchedMcecatLotesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatLotesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'McgcatCausasMuerteEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McgcatCausasMuerteEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatCausasMuerte() As McgcatCausasMuerteEntity
			Return GetSingleMcgcatCausasMuerte(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McgcatCausasMuerteEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McgcatCausasMuerteEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatCausasMuerte(forceFetch As Boolean) As McgcatCausasMuerteEntity
			If ( Not _alreadyFetchedMcgcatCausasMuerte Or forceFetch Or _alwaysFetchMcgcatCausasMuerte) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McgcatCausasMuerteEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCausaMuerte.GetValueOrDefault())
				End If
				If Not _mcgcatCausasMuerteReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McgcatCausasMuerte = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McgcatCausasMuerteEntity)
					End If
					Me.McgcatCausasMuerte = newEntity
					_alreadyFetchedMcgcatCausasMuerte = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcgcatCausasMuerte
		End Function
	
		''' <summary>Retrieves the related entity of type 'CatRastrosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatRastrosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatRastros() As CatRastrosEntity
			Return GetSingleCatRastros(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatRastrosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatRastrosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatRastros(forceFetch As Boolean) As CatRastrosEntity
			If ( Not _alreadyFetchedCatRastros Or forceFetch Or _alwaysFetchCatRastros) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatRastrosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdRastro.GetValueOrDefault())
				End If
				If Not _catRastrosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatRastros = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatRastrosEntity)
					End If
					Me.CatRastros = newEntity
					_alreadyFetchedCatRastros = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catRastros
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
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral) Then
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
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza() As PolizaEntity
			Return GetSinglePoliza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza Or forceFetch Or _alwaysFetchPoliza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPoliza.GetValueOrDefault())
				End If
				If Not _polizaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza = newEntity
					_alreadyFetchedPoliza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(SalidaGanadoCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, SalidaGanadoCabFieldIndex)


					Case SalidaGanadoCabFieldIndex.IdCorral
						DesetupSyncMcecatCorralesCab(True, False)
						_alreadyFetchedMcecatCorralesCab = False
					Case SalidaGanadoCabFieldIndex.IdLoteDestino
						DesetupSyncMcecatLotesCab(True, False)
						_alreadyFetchedMcecatLotesCab = False
					Case SalidaGanadoCabFieldIndex.IdRastro
						DesetupSyncCatRastros(True, False)
						_alreadyFetchedCatRastros = False










					Case SalidaGanadoCabFieldIndex.IdPoliza
						DesetupSyncPoliza(True, False)
						_alreadyFetchedPoliza = False



					Case SalidaGanadoCabFieldIndex.IdCausaMuerte
						DesetupSyncMcgcatCausasMuerte(True, False)
						_alreadyFetchedMcgcatCausasMuerte = False


					Case SalidaGanadoCabFieldIndex.FolioMovimientoGanado
						DesetupSyncCabMovGan(True, False)
						_alreadyFetchedCabMovGan = False


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabFacturas.ActiveContext = MyBase.ActiveContext
			_conLotSac.ActiveContext = MyBase.ActiveContext
			_prorraRec.ActiveContext = MyBase.ActiveContext
			_salidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCabFacturas.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCabFacturas_.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaProrraRec.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesDetCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
		If Not _cabMovGan Is Nothing Then
				_cabMovGan.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatLotesCab Is Nothing Then
				_mcecatLotesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcgcatCausasMuerte Is Nothing Then
				_mcgcatCausasMuerte.ActiveContext = MyBase.ActiveContext
			End If
		If Not _catRastros Is Nothing Then
				_catRastros.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatCorralesCab Is Nothing Then
				_mcecatCorralesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza Is Nothing Then
				_poliza.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As SalidaGanadoCabDAO = CType(CreateDAOInstance(), SalidaGanadoCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As SalidaGanadoCabDAO = CType(CreateDAOInstance(), SalidaGanadoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As SalidaGanadoCabDAO = CType(CreateDAOInstance(), SalidaGanadoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this SalidaGanadoCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.SalidaGanadoCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="validator">The validator Object for this SalidaGanadoCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idSalidaGanadoCab As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idSalidaGanadoCab, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cabFacturas = New Integralab.ORM.CollectionClasses.CabFacturasCollection(New CabFacturasEntityFactory())
			_cabFacturas.SetContainingEntityInfo(Me, "SalidaGanadoCab")
			_alwaysFetchCabFacturas = False
			_alreadyFetchedCabFacturas = False
			_conLotSac = New Integralab.ORM.CollectionClasses.ConLotSacCollection(New ConLotSacEntityFactory())
			_conLotSac.SetContainingEntityInfo(Me, "SalidaGanadoCab")
			_alwaysFetchConLotSac = False
			_alreadyFetchedConLotSac = False
			_prorraRec = New Integralab.ORM.CollectionClasses.ProrraRecCollection(New ProrraRecEntityFactory())
			_prorraRec.SetContainingEntityInfo(Me, "SalidaGanadoCab")
			_alwaysFetchProrraRec = False
			_alreadyFetchedProrraRec = False
			_salidaGanadoDet = New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(New SalidaGanadoDetEntityFactory())
			_salidaGanadoDet.SetContainingEntityInfo(Me, "SalidaGanadoCab")
			_alwaysFetchSalidaGanadoDet = False
			_alreadyFetchedSalidaGanadoDet = False
			_polizaCollectionViaCabFacturas = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCabFacturas = False
			_alreadyFetchedPolizaCollectionViaCabFacturas = False
			_polizaCollectionViaCabFacturas_ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCabFacturas_ = False
			_alreadyFetchedPolizaCollectionViaCabFacturas_ = False
			_mcecatCorralesCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaProrraRec = False
			_alreadyFetchedMcecatCorralesCabCollectionViaProrraRec = False
			_mcecatLotesCabCollectionViaProrraRec = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaProrraRec = False
			_alreadyFetchedMcecatLotesCabCollectionViaProrraRec = False
			_mcecatLotesCabCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = False
			_mcecatLotesDetCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(New McecatLotesDetEntityFactory())
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_mcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet = False
			_cabMovGan = Nothing
			_cabMovGanReturnsNewIfNotFound = True
			_alwaysFetchCabMovGan = False
			_alreadyFetchedCabMovGan = False
			_mcecatLotesCab = Nothing
			_mcecatLotesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatLotesCab = False
			_alreadyFetchedMcecatLotesCab = False
			_mcgcatCausasMuerte = Nothing
			_mcgcatCausasMuerteReturnsNewIfNotFound = True
			_alwaysFetchMcgcatCausasMuerte = False
			_alreadyFetchedMcgcatCausasMuerte = False
			_catRastros = Nothing
			_catRastrosReturnsNewIfNotFound = True
			_alwaysFetchCatRastros = False
			_alreadyFetchedCatRastros = False
			_mcecatCorralesCab = Nothing
			_mcecatCorralesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatCorralesCab = False
			_alreadyFetchedMcecatCorralesCab = False
			_poliza = Nothing
			_polizaReturnsNewIfNotFound = True
			_alwaysFetchPoliza = False
			_alreadyFetchedPoliza = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSalidaGanadoCab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLoteDestino", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoEntrada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoAlimento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosAlimento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoMedicina", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoxKilo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoMovto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoReciba", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Aviso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCausaMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recuperacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoIndirecto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cabMovGan</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabMovGan(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabMovGan, AddressOf OnCabMovGanPropertyChanged, "CabMovGan", SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.FolioMovimientoGanado) } )
			_cabMovGan = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cabMovGan</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabMovGan(relatedEntity As IEntity)
			DesetupSyncCabMovGan(True, True)
			_cabMovGan = CType(relatedEntity, CabMovGanEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabMovGan, AddressOf OnCabMovGanPropertyChanged, "CabMovGan", SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, True, _alreadyFetchedCabMovGan, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabMovGanPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatLotesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatLotesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.IdLoteDestino) } )
			_mcecatLotesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatLotesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatLotesCab(relatedEntity As IEntity)
			DesetupSyncMcecatLotesCab(True, True)
			_mcecatLotesCab = CType(relatedEntity, McecatLotesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, True, _alreadyFetchedMcecatLotesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatLotesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcgcatCausasMuerte</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatCausasMuerte(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatCausasMuerte, AddressOf OnMcgcatCausasMuertePropertyChanged, "McgcatCausasMuerte", SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.IdCausaMuerte) } )
			_mcgcatCausasMuerte = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatCausasMuerte</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatCausasMuerte(relatedEntity As IEntity)
			DesetupSyncMcgcatCausasMuerte(True, True)
			_mcgcatCausasMuerte = CType(relatedEntity, McgcatCausasMuerteEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatCausasMuerte, AddressOf OnMcgcatCausasMuertePropertyChanged, "McgcatCausasMuerte", SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, True, _alreadyFetchedMcgcatCausasMuerte, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcgcatCausasMuertePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _catRastros</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatRastros(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catRastros, AddressOf OnCatRastrosPropertyChanged, "CatRastros", SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.IdRastro) } )
			_catRastros = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catRastros</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatRastros(relatedEntity As IEntity)
			DesetupSyncCatRastros(True, True)
			_catRastros = CType(relatedEntity, CatRastrosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catRastros, AddressOf OnCatRastrosPropertyChanged, "CatRastros", SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, True, _alreadyFetchedCatRastros, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatRastrosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatCorralesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.IdCorral) } )
			_mcecatCorralesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatCorralesCab(relatedEntity As IEntity)
			DesetupSyncMcecatCorralesCab(True, True)
			_mcecatCorralesCab = CType(relatedEntity, McecatCorralesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, _alreadyFetchedMcecatCorralesCab, New String() {  } )
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
		''' <summary>Removes the sync logic for member _poliza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, True, signalRelatedEntity, "SalidaGanadoCab", resetFKFields, New Integer() { CInt(SalidaGanadoCabFieldIndex.IdPoliza) } )
			_poliza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza(relatedEntity As IEntity)
			DesetupSyncPoliza(True, True)
			_poliza = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, True, _alreadyFetchedPoliza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPolizaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idSalidaGanadoCab">PK value for SalidaGanadoCab which data should be fetched into this SalidaGanadoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idSalidaGanadoCab As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab)).ForcedCurrentValueWrite(idSalidaGanadoCab)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateSalidaGanadoCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New SalidaGanadoCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As SalidaGanadoCabRelations
			Get	
				Return New SalidaGanadoCabRelations() 
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
					SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), 0, Nothing, Nothing, Nothing, "CabFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConLotSac' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathConLotSac() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConLotSacCollection(), _
					SalidaGanadoCabEntity.Relations.ConLotSacEntityUsingIdSalidaGanadoRastro, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.ConLotSacEntity, Integer), 0, Nothing, Nothing, Nothing, "ConLotSac", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProrraRec' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProrraRec() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProrraRecCollection(), _
					SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.ProrraRecEntity, Integer), 0, Nothing, Nothing, Nothing, "ProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(), _
					SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCabFacturas() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCabFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCabFacturas_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					SalidaGanadoCabEntity.Relations.CabFacturasEntityUsingReferencia, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCabFacturas_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatCorralesCabEntityUsingIdCorralReciba)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaProrraRec() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ProrraRecEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					SalidaGanadoCabEntity.Relations.ProrraRecEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaProrraRec", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesDetCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(), _
					SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesDetEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesDetCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, "__SalidaGanadoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGan() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, Nothing, "CabMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCausasMuerte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCausasMuerte() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(), _
					SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatCausasMuerte", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastros() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, Nothing, "CatRastros", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "SalidaGanadoCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return SalidaGanadoCabEntity.CustomProperties
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
				Return SalidaGanadoCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdSalidaGanadoCab property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdSalidaGanadoCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdSalidaGanadoCab]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdSalidaGanadoCab, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fecha property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Fecha"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Fecha]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Fecha, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Fecha, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCorral property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdLoteDestino property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdLoteDestino"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdLoteDestino]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdLoteDestino, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdLoteDestino, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdRastro property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdRastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdRastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdVenta property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cabezas property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Cabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cabezas]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Cabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Cabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Kilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoEntrada property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoEntrada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoEntrada]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoEntrada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoEntrada, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoAlimento property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoAlimento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoAlimento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoAlimento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoAlimento, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosAlimento property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."KilosAlimento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosAlimento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.KilosAlimento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.KilosAlimento, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoMedicina property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoMedicina"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoMedicina]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoMedicina, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoMedicina, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoxKilo property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoxKilo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoxKilo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoxKilo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoxKilo, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoMovto property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoMovto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CostoMovto]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoMovto, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoMovto, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdPoliza, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdTipoReciba property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdTipoReciba"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdTipoReciba]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdTipoReciba, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdTipoReciba, Integer), value)
			End Set
		End Property
	
		''' <summary>The Aviso property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Aviso"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Aviso]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Aviso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Aviso, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCausaMuerte property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."IdCausaMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCausaMuerte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.IdCausaMuerte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.IdCausaMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recuperacion property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Recuperacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Recuperacion]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Recuperacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Recuperacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteVenta property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."ImporteVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteVenta]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.ImporteVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.ImporteVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoGanado property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."FolioMovimientoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoGanado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.FolioMovimientoGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.FolioMovimientoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoIndirecto property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."CostoIndirecto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoIndirecto]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.CostoIndirecto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.CostoIndirecto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Folio property of the Entity SalidaGanadoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "SalidaGanadoCab"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SalidaGanadoCabFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SalidaGanadoCabFieldIndex.Folio, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'ConLotSacEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiConLotSac()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ConLotSac]() As Integralab.ORM.CollectionClasses.ConLotSacCollection
			Get
				Return GetMultiConLotSac(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ConLotSac. When set to true, ConLotSac is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ConLotSac is accessed. You can always execute
		''' a forced fetch by calling GetMultiConLotSac(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchConLotSac As Boolean
			Get
				Return _alwaysFetchConLotSac
			End Get
			Set
				_alwaysFetchConLotSac = value
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
	
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCabFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCabFacturas]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCabFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCabFacturas. When set to true, PolizaCollectionViaCabFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCabFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCabFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCabFacturas As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCabFacturas
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCabFacturas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCabFacturas_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCabFacturas_]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCabFacturas_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCabFacturas_. When set to true, PolizaCollectionViaCabFacturas_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCabFacturas_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCabFacturas_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCabFacturas_ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCabFacturas_
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCabFacturas_ = value
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
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaSalidaGanadoDet]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaSalidaGanadoDet. When set to true, McecatLotesCabCollectionViaSalidaGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaSalidaGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaSalidaGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet = value
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
	
	
		''' <summary>Gets / sets related entity of type 'CabMovGanEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabMovGan()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabMovGan]() As CabMovGanEntity
			Get
				Return GetSingleCabMovGan(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabMovGan(value)
				Else
					If value Is Nothing Then
						If Not _cabMovGan Is Nothing Then
							_cabMovGan.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGan. When set to true, CabMovGan is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGan is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabMovGan(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGan As Boolean
			Get
				Return _alwaysFetchCabMovGan
			End Get
			Set
				_alwaysFetchCabMovGan = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabMovGan is not found
		''' in the database. When set to true, CabMovGan will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabMovGanReturnsNewIfNotFound As Boolean
			Get
				Return _cabMovGanReturnsNewIfNotFound
			End Get
			Set
				_cabMovGanReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatLotesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatLotesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatLotesCab]() As McecatLotesCabEntity
			Get
				Return GetSingleMcecatLotesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatLotesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatLotesCab Is Nothing Then
							_mcecatLotesCab.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCab. When set to true, McecatLotesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatLotesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCab
			End Get
			Set
				_alwaysFetchMcecatLotesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatLotesCab is not found
		''' in the database. When set to true, McecatLotesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatLotesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatLotesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatLotesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McgcatCausasMuerteEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcgcatCausasMuerte()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McgcatCausasMuerte]() As McgcatCausasMuerteEntity
			Get
				Return GetSingleMcgcatCausasMuerte(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcgcatCausasMuerte(value)
				Else
					If value Is Nothing Then
						If Not _mcgcatCausasMuerte Is Nothing Then
							_mcgcatCausasMuerte.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCausasMuerte. When set to true, McgcatCausasMuerte is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCausasMuerte is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcgcatCausasMuerte(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCausasMuerte As Boolean
			Get
				Return _alwaysFetchMcgcatCausasMuerte
			End Get
			Set
				_alwaysFetchMcgcatCausasMuerte = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McgcatCausasMuerte is not found
		''' in the database. When set to true, McgcatCausasMuerte will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McgcatCausasMuerteReturnsNewIfNotFound As Boolean
			Get
				Return _mcgcatCausasMuerteReturnsNewIfNotFound
			End Get
			Set
				_mcgcatCausasMuerteReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CatRastrosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatRastros()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatRastros]() As CatRastrosEntity
			Get
				Return GetSingleCatRastros(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatRastros(value)
				Else
					If value Is Nothing Then
						If Not _catRastros Is Nothing Then
							_catRastros.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatRastros. When set to true, CatRastros is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatRastros is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatRastros(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatRastros As Boolean
			Get
				Return _alwaysFetchCatRastros
			End Get
			Set
				_alwaysFetchCatRastros = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatRastros is not found
		''' in the database. When set to true, CatRastros will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatRastrosReturnsNewIfNotFound As Boolean
			Get
				Return _catRastrosReturnsNewIfNotFound
			End Get
			Set
				_catRastrosReturnsNewIfNotFound = value
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
							_mcecatCorralesCab.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
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
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza]() As PolizaEntity
			Get
				Return GetSinglePoliza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza(value)
				Else
					If value Is Nothing Then
						If Not _poliza Is Nothing Then
							_poliza.UnsetRelatedEntity(Me, "SalidaGanadoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SalidaGanadoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza. When set to true, Poliza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza As Boolean
			Get
				Return _alwaysFetchPoliza
			End Get
			Set
				_alwaysFetchPoliza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza is not found
		''' in the database. When set to true, Poliza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PolizaReturnsNewIfNotFound As Boolean
			Get
				Return _polizaReturnsNewIfNotFound
			End Get
			Set
				_polizaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.SalidaGanadoCabEntity)
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
