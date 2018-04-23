' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:21:57
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
	''' <summary>Entity class which represents the entity 'McgcatTiposdeGanado'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McgcatTiposdeGanadoEntity 
#Else
	<Serializable()> _
	Public Class McgcatTiposdeGanadoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detFacturas As Integralab.ORM.CollectionClasses.DetFacturasCollection
		Private _alwaysFetchDetFacturas, _alreadyFetchedDetFacturas As Boolean
		Private _detMovGan As Integralab.ORM.CollectionClasses.DetMovGanCollection
		Private _alwaysFetchDetMovGan, _alreadyFetchedDetMovGan As Boolean
		Private _detRegCom As Integralab.ORM.CollectionClasses.DetRegComCollection
		Private _alwaysFetchDetRegCom, _alreadyFetchedDetRegCom As Boolean
		Private _mcecatCorralesDet As Integralab.ORM.CollectionClasses.McecatCorralesDetCollection
		Private _alwaysFetchMcecatCorralesDet, _alreadyFetchedMcecatCorralesDet As Boolean
		Private _mcecatLotesDet As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
		Private _alwaysFetchMcecatLotesDet, _alreadyFetchedMcecatLotesDet As Boolean
		Private _salidaGanadoDet As Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection
		Private _alwaysFetchSalidaGanadoDet, _alreadyFetchedSalidaGanadoDet As Boolean
		Private _usrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
		Private _alwaysFetchUsrProdRecepcionDetalle, _alreadyFetchedUsrProdRecepcionDetalle As Boolean
		Private _recepcionGanado As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
		Private _alwaysFetchRecepcionGanado, _alreadyFetchedRecepcionGanado As Boolean
		Private _cabFacturasCollectionViaDetFacturas As Integralab.ORM.CollectionClasses.CabFacturasCollection
		Private _alwaysFetchCabFacturasCollectionViaDetFacturas, _alreadyFetchedCabFacturasCollectionViaDetFacturas As Boolean
		Private _cabMovGanCollectionViaDetMovGan As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaDetMovGan, _alreadyFetchedCabMovGanCollectionViaDetMovGan As Boolean
		Private _cabRegComCollectionViaDetRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegComCollectionViaDetRegCom, _alreadyFetchedCabRegComCollectionViaDetRegCom As Boolean
		Private _mcecatCorralesCabCollectionViaMcecatCorralesDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet, _alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet As Boolean
		Private _mcecatLotesCabCollectionViaMcecatLotesDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet, _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet As Boolean
		Private _mcecatLotesDetCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.McecatLotesDetCollection
		Private _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet, _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet As Boolean
		Private _salidaGanadoCabCollectionViaSalidaGanadoDet As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet, _alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet As Boolean
		Private _productoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _msccatProductosCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.MsccatProductosCollection
		Private _alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _recepcionGanadoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
		Private _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle As Boolean



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
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		Public Sub New(idTipoGanado As System.Int32)

			InitClassFetch(idTipoGanado, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idTipoGanado As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idTipoGanado, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="validator">The custom validator Object for this McgcatTiposdeGanadoEntity</param>
		Public Sub New(idTipoGanado As System.Int32, validator As IValidator)

			InitClassFetch(idTipoGanado, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detFacturas = CType(info.GetValue("_detFacturas", GetType(Integralab.ORM.CollectionClasses.DetFacturasCollection)), Integralab.ORM.CollectionClasses.DetFacturasCollection)
			_alwaysFetchDetFacturas = info.GetBoolean("_alwaysFetchDetFacturas")
			_alreadyFetchedDetFacturas = info.GetBoolean("_alreadyFetchedDetFacturas")
			_detMovGan = CType(info.GetValue("_detMovGan", GetType(Integralab.ORM.CollectionClasses.DetMovGanCollection)), Integralab.ORM.CollectionClasses.DetMovGanCollection)
			_alwaysFetchDetMovGan = info.GetBoolean("_alwaysFetchDetMovGan")
			_alreadyFetchedDetMovGan = info.GetBoolean("_alreadyFetchedDetMovGan")
			_detRegCom = CType(info.GetValue("_detRegCom", GetType(Integralab.ORM.CollectionClasses.DetRegComCollection)), Integralab.ORM.CollectionClasses.DetRegComCollection)
			_alwaysFetchDetRegCom = info.GetBoolean("_alwaysFetchDetRegCom")
			_alreadyFetchedDetRegCom = info.GetBoolean("_alreadyFetchedDetRegCom")
			_mcecatCorralesDet = CType(info.GetValue("_mcecatCorralesDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesDetCollection)), Integralab.ORM.CollectionClasses.McecatCorralesDetCollection)
			_alwaysFetchMcecatCorralesDet = info.GetBoolean("_alwaysFetchMcecatCorralesDet")
			_alreadyFetchedMcecatCorralesDet = info.GetBoolean("_alreadyFetchedMcecatCorralesDet")
			_mcecatLotesDet = CType(info.GetValue("_mcecatLotesDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesDetCollection)), Integralab.ORM.CollectionClasses.McecatLotesDetCollection)
			_alwaysFetchMcecatLotesDet = info.GetBoolean("_alwaysFetchMcecatLotesDet")
			_alreadyFetchedMcecatLotesDet = info.GetBoolean("_alreadyFetchedMcecatLotesDet")
			_salidaGanadoDet = CType(info.GetValue("_salidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection)
			_alwaysFetchSalidaGanadoDet = info.GetBoolean("_alwaysFetchSalidaGanadoDet")
			_alreadyFetchedSalidaGanadoDet = info.GetBoolean("_alreadyFetchedSalidaGanadoDet")
			_usrProdRecepcionDetalle = CType(info.GetValue("_usrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)
			_alwaysFetchUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchUsrProdRecepcionDetalle")
			_alreadyFetchedUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedUsrProdRecepcionDetalle")
			_recepcionGanado = CType(info.GetValue("_recepcionGanado", GetType(Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)), Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)
			_alwaysFetchRecepcionGanado = info.GetBoolean("_alwaysFetchRecepcionGanado")
			_alreadyFetchedRecepcionGanado = info.GetBoolean("_alreadyFetchedRecepcionGanado")
			_cabFacturasCollectionViaDetFacturas = CType(info.GetValue("_cabFacturasCollectionViaDetFacturas", GetType(Integralab.ORM.CollectionClasses.CabFacturasCollection)), Integralab.ORM.CollectionClasses.CabFacturasCollection)
			_alwaysFetchCabFacturasCollectionViaDetFacturas = info.GetBoolean("_alwaysFetchCabFacturasCollectionViaDetFacturas")
			_alreadyFetchedCabFacturasCollectionViaDetFacturas = info.GetBoolean("_alreadyFetchedCabFacturasCollectionViaDetFacturas")
			_cabMovGanCollectionViaDetMovGan = CType(info.GetValue("_cabMovGanCollectionViaDetMovGan", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaDetMovGan = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaDetMovGan")
			_alreadyFetchedCabMovGanCollectionViaDetMovGan = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaDetMovGan")
			_cabRegComCollectionViaDetRegCom = CType(info.GetValue("_cabRegComCollectionViaDetRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegComCollectionViaDetRegCom = info.GetBoolean("_alwaysFetchCabRegComCollectionViaDetRegCom")
			_alreadyFetchedCabRegComCollectionViaDetRegCom = info.GetBoolean("_alreadyFetchedCabRegComCollectionViaDetRegCom")
			_mcecatCorralesCabCollectionViaMcecatCorralesDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaMcecatCorralesDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet")
			_mcecatLotesCabCollectionViaMcecatLotesDet = CType(info.GetValue("_mcecatLotesCabCollectionViaMcecatLotesDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet")
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet")
			_mcecatLotesCabCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcecatLotesCabCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet")
			_mcecatLotesDetCollectionViaSalidaGanadoDet = CType(info.GetValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesDetCollection)), Integralab.ORM.CollectionClasses.McecatLotesDetCollection)
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet")
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet")
			_salidaGanadoCabCollectionViaSalidaGanadoDet = CType(info.GetValue("_salidaGanadoCabCollectionViaSalidaGanadoDet", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet")
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = info.GetBoolean("_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet")
			_productoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_productoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle")
			_msccatProductosCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_msccatProductosCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.MsccatProductosCollection)), Integralab.ORM.CollectionClasses.MsccatProductosCollection)
			_alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle")
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_recepcionGanadoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)), Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetFacturas = (_detFacturas.Count > 0)
			_alreadyFetchedDetMovGan = (_detMovGan.Count > 0)
			_alreadyFetchedDetRegCom = (_detRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesDet = (_mcecatCorralesDet.Count > 0)
			_alreadyFetchedMcecatLotesDet = (_mcecatLotesDet.Count > 0)
			_alreadyFetchedSalidaGanadoDet = (_salidaGanadoDet.Count > 0)
			_alreadyFetchedUsrProdRecepcionDetalle = (_usrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedRecepcionGanado = (_recepcionGanado.Count > 0)
			_alreadyFetchedCabFacturasCollectionViaDetFacturas = (_cabFacturasCollectionViaDetFacturas.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaDetMovGan = (_cabMovGanCollectionViaDetMovGan.Count > 0)
			_alreadyFetchedCabRegComCollectionViaDetRegCom = (_cabRegComCollectionViaDetRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet = (_mcecatCorralesCabCollectionViaMcecatCorralesDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet = (_mcecatLotesCabCollectionViaMcecatLotesDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = (_mcecatLotesCabCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = (_mcecatLotesDetCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = (_salidaGanadoCabCollectionViaSalidaGanadoDet.Count > 0)
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = (_productoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle = (_msccatProductosCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = (_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.Count > 0)


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
			info.AddValue("_detFacturas", _detFacturas)
			info.AddValue("_alwaysFetchDetFacturas", _alwaysFetchDetFacturas)
			info.AddValue("_alreadyFetchedDetFacturas", _alreadyFetchedDetFacturas)
			info.AddValue("_detMovGan", _detMovGan)
			info.AddValue("_alwaysFetchDetMovGan", _alwaysFetchDetMovGan)
			info.AddValue("_alreadyFetchedDetMovGan", _alreadyFetchedDetMovGan)
			info.AddValue("_detRegCom", _detRegCom)
			info.AddValue("_alwaysFetchDetRegCom", _alwaysFetchDetRegCom)
			info.AddValue("_alreadyFetchedDetRegCom", _alreadyFetchedDetRegCom)
			info.AddValue("_mcecatCorralesDet", _mcecatCorralesDet)
			info.AddValue("_alwaysFetchMcecatCorralesDet", _alwaysFetchMcecatCorralesDet)
			info.AddValue("_alreadyFetchedMcecatCorralesDet", _alreadyFetchedMcecatCorralesDet)
			info.AddValue("_mcecatLotesDet", _mcecatLotesDet)
			info.AddValue("_alwaysFetchMcecatLotesDet", _alwaysFetchMcecatLotesDet)
			info.AddValue("_alreadyFetchedMcecatLotesDet", _alreadyFetchedMcecatLotesDet)
			info.AddValue("_salidaGanadoDet", _salidaGanadoDet)
			info.AddValue("_alwaysFetchSalidaGanadoDet", _alwaysFetchSalidaGanadoDet)
			info.AddValue("_alreadyFetchedSalidaGanadoDet", _alreadyFetchedSalidaGanadoDet)
			info.AddValue("_usrProdRecepcionDetalle", _usrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchUsrProdRecepcionDetalle", _alwaysFetchUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedUsrProdRecepcionDetalle", _alreadyFetchedUsrProdRecepcionDetalle)
			info.AddValue("_recepcionGanado", _recepcionGanado)
			info.AddValue("_alwaysFetchRecepcionGanado", _alwaysFetchRecepcionGanado)
			info.AddValue("_alreadyFetchedRecepcionGanado", _alreadyFetchedRecepcionGanado)
			info.AddValue("_cabFacturasCollectionViaDetFacturas", _cabFacturasCollectionViaDetFacturas)
			info.AddValue("_alwaysFetchCabFacturasCollectionViaDetFacturas", _alwaysFetchCabFacturasCollectionViaDetFacturas)
			info.AddValue("_alreadyFetchedCabFacturasCollectionViaDetFacturas", _alreadyFetchedCabFacturasCollectionViaDetFacturas)
			info.AddValue("_cabMovGanCollectionViaDetMovGan", _cabMovGanCollectionViaDetMovGan)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaDetMovGan", _alwaysFetchCabMovGanCollectionViaDetMovGan)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaDetMovGan", _alreadyFetchedCabMovGanCollectionViaDetMovGan)
			info.AddValue("_cabRegComCollectionViaDetRegCom", _cabRegComCollectionViaDetRegCom)
			info.AddValue("_alwaysFetchCabRegComCollectionViaDetRegCom", _alwaysFetchCabRegComCollectionViaDetRegCom)
			info.AddValue("_alreadyFetchedCabRegComCollectionViaDetRegCom", _alreadyFetchedCabRegComCollectionViaDetRegCom)
			info.AddValue("_mcecatCorralesCabCollectionViaMcecatCorralesDet", _mcecatCorralesCabCollectionViaMcecatCorralesDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet", _alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet", _alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet)
			info.AddValue("_mcecatLotesCabCollectionViaMcecatLotesDet", _mcecatLotesCabCollectionViaMcecatLotesDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet", _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet", _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet)
			info.AddValue("_mcecatLotesCabCollectionViaSalidaGanadoDet", _mcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet", _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet", _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet)
			info.AddValue("_mcecatLotesDetCollectionViaSalidaGanadoDet", _mcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet", _alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet", _alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet)
			info.AddValue("_salidaGanadoCabCollectionViaSalidaGanadoDet", _salidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet", _alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet", _alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet)
			info.AddValue("_productoCollectionViaUsrProdRecepcionDetalle", _productoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_msccatProductosCollectionViaUsrProdRecepcionDetalle", _msccatProductosCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle", _alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_recepcionGanadoCollectionViaUsrProdRecepcionDetalle", _recepcionGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle)


			
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

				Case "DetFacturas"
					_alreadyFetchedDetFacturas = True
					If Not entity Is Nothing Then
						Me.DetFacturas.Add(CType(entity, DetFacturasEntity))
					End If
				Case "DetMovGan"
					_alreadyFetchedDetMovGan = True
					If Not entity Is Nothing Then
						Me.DetMovGan.Add(CType(entity, DetMovGanEntity))
					End If
				Case "DetRegCom"
					_alreadyFetchedDetRegCom = True
					If Not entity Is Nothing Then
						Me.DetRegCom.Add(CType(entity, DetRegComEntity))
					End If
				Case "McecatCorralesDet"
					_alreadyFetchedMcecatCorralesDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesDet.Add(CType(entity, McecatCorralesDetEntity))
					End If
				Case "McecatLotesDet"
					_alreadyFetchedMcecatLotesDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesDet.Add(CType(entity, McecatLotesDetEntity))
					End If
				Case "SalidaGanadoDet"
					_alreadyFetchedSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoDet.Add(CType(entity, SalidaGanadoDetEntity))
					End If
				Case "UsrProdRecepcionDetalle"
					_alreadyFetchedUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionDetalle.Add(CType(entity, UsrProdRecepcionDetalleEntity))
					End If
				Case "RecepcionGanado"
					_alreadyFetchedRecepcionGanado = True
					If Not entity Is Nothing Then
						Me.RecepcionGanado.Add(CType(entity, RecepcionGanadoEntity))
					End If
				Case "CabFacturasCollectionViaDetFacturas"
					_alreadyFetchedCabFacturasCollectionViaDetFacturas = True
					If Not entity Is Nothing Then
						Me.CabFacturasCollectionViaDetFacturas.Add(CType(entity, CabFacturasEntity))
					End If
				Case "CabMovGanCollectionViaDetMovGan"
					_alreadyFetchedCabMovGanCollectionViaDetMovGan = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaDetMovGan.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CabRegComCollectionViaDetRegCom"
					_alreadyFetchedCabRegComCollectionViaDetRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegComCollectionViaDetRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "McecatCorralesCabCollectionViaMcecatCorralesDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaMcecatCorralesDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaMcecatLotesDet"
					_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaMcecatLotesDet.Add(CType(entity, McecatLotesCabEntity))
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
				Case "SalidaGanadoCabCollectionViaSalidaGanadoDet"
					_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCabCollectionViaSalidaGanadoDet.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "ProductoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "MsccatProductosCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.MsccatProductosCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, MsccatProductosEntity))
					End If
				Case "RecepcionGanadoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.RecepcionGanadoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, RecepcionGanadoEntity))
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

				Case "DetFacturas"
					_detFacturas.Add(CType(relatedEntity, DetFacturasEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetMovGan"
					_detMovGan.Add(CType(relatedEntity, DetMovGanEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetRegCom"
					_detRegCom.Add(CType(relatedEntity, DetRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesDet"
					_mcecatCorralesDet.Add(CType(relatedEntity, McecatCorralesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesDet"
					_mcecatLotesDet.Add(CType(relatedEntity, McecatLotesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					_salidaGanadoDet.Add(CType(relatedEntity, SalidaGanadoDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					_usrProdRecepcionDetalle.Add(CType(relatedEntity, UsrProdRecepcionDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionGanado"
					_recepcionGanado.Add(CType(relatedEntity, RecepcionGanadoEntity))
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

				Case "DetFacturas"
					MyBase.PerformRelatedEntityRemoval(_detFacturas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetMovGan"
					MyBase.PerformRelatedEntityRemoval(_detMovGan, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetRegCom"
					MyBase.PerformRelatedEntityRemoval(_detRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesDet"
					MyBase.PerformRelatedEntityRemoval(_mcecatCorralesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesDet"
					MyBase.PerformRelatedEntityRemoval(_mcecatLotesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SalidaGanadoDet"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionGanado"
					MyBase.PerformRelatedEntityRemoval(_recepcionGanado, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_detFacturas)
			toReturn.Add(_detMovGan)
			toReturn.Add(_detRegCom)
			toReturn.Add(_mcecatCorralesDet)
			toReturn.Add(_mcecatLotesDet)
			toReturn.Add(_salidaGanadoDet)
			toReturn.Add(_usrProdRecepcionDetalle)
			toReturn.Add(_recepcionGanado)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idTipoGanado As System.Int32) As Boolean
			Return FetchUsingPK(idTipoGanado, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idTipoGanado As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idTipoGanado, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idTipoGanado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idTipoGanado, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdTipoGanado, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McgcatTiposdeGanadoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McgcatTiposdeGanadoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetFacturasEntity'</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, _detFacturas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetFacturasEntity'</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, _detFacturas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			If ( Not _alreadyFetchedDetFacturas Or forceFetch Or _alwaysFetchDetFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detFacturas)
					End If
				End If
				_detFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_detFacturas.GetMultiManyToOne(Nothing, Me, Filter)
				_detFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedDetFacturas = True
			End If
			Return _detFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetFacturas'. These settings will be taken into account
		''' when the property DetFacturas is requested or GetMultiDetFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detFacturas.SortClauses=sortClauses
			_detFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetMovGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetMovGanEntity'</returns>
		Public Function GetMultiDetMovGan(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetMovGanCollection
			Return GetMultiDetMovGan(forceFetch, _detMovGan.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetMovGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetMovGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetMovGanCollection
			Return GetMultiDetMovGan(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetMovGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetMovGanEntity'</returns>
		Public Function GetMultiDetMovGan(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetMovGanCollection
			Return GetMultiDetMovGan(forceFetch, _detMovGan.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetMovGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetMovGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetMovGanCollection
			If ( Not _alreadyFetchedDetMovGan Or forceFetch Or _alwaysFetchDetMovGan) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detMovGan.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detMovGan)
					End If
				End If
				_detMovGan.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detMovGan.EntityFactoryToUse = entityFactoryToUse
				End If
				_detMovGan.GetMultiManyToOne(Nothing, Me, Filter)
				_detMovGan.SuppressClearInGetMulti = False
				_alreadyFetchedDetMovGan = True
			End If
			Return _detMovGan
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetMovGan'. These settings will be taken into account
		''' when the property DetMovGan is requested or GetMultiDetMovGan is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetMovGan(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detMovGan.SortClauses=sortClauses
			_detMovGan.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetRegComEntity'</returns>
		Public Function GetMultiDetRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetRegComCollection
			Return GetMultiDetRegCom(forceFetch, _detRegCom.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetRegComCollection
			Return GetMultiDetRegCom(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetRegComEntity'</returns>
		Public Function GetMultiDetRegCom(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetRegComCollection
			Return GetMultiDetRegCom(forceFetch, _detRegCom.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetRegComCollection
			If ( Not _alreadyFetchedDetRegCom Or forceFetch Or _alwaysFetchDetRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detRegCom)
					End If
				End If
				_detRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_detRegCom.GetMultiManyToOne(Nothing, Me, Filter)
				_detRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedDetRegCom = True
			End If
			Return _detRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetRegCom'. These settings will be taken into account
		''' when the property DetRegCom is requested or GetMultiDetRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detRegCom.SortClauses=sortClauses
			_detRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_mcecatCorralesDet.GetMultiManyToOne(Nothing, Me, Filter)
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
				_mcecatLotesDet.GetMultiManyToOne(Nothing, Me, Filter)
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
				_salidaGanadoDet.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
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
				_usrProdRecepcionDetalle.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, _recepcionGanado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, _recepcionGanado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			If ( Not _alreadyFetchedRecepcionGanado Or forceFetch Or _alwaysFetchRecepcionGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionGanado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionGanado)
					End If
				End If
				_recepcionGanado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionGanado.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionGanado.GetMultiManyToOne(Nothing, Me, Filter)
				_recepcionGanado.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionGanado = True
			End If
			Return _recepcionGanado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionGanado'. These settings will be taken into account
		''' when the property RecepcionGanado is requested or GetMultiRecepcionGanado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionGanado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionGanado.SortClauses=sortClauses
			_recepcionGanado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabFacturasEntity'</returns>
		Public Function GetMultiCabFacturasCollectionViaDetFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Return GetMultiCabFacturasCollectionViaDetFacturas(forceFetch, _cabFacturasCollectionViaDetFacturas.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabFacturasCollectionViaDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabFacturasCollection
			If ( Not _alreadyFetchedCabFacturasCollectionViaDetFacturas Or forceFetch Or _alwaysFetchCabFacturasCollectionViaDetFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabFacturasCollectionViaDetFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabFacturasCollectionViaDetFacturas)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", "DetFacturas_", JoinHint.None)
				relations.Add(DetFacturasEntity.Relations.CabFacturasEntityUsingFolFactura, "DetFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_cabFacturasCollectionViaDetFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabFacturasCollectionViaDetFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabFacturasCollectionViaDetFacturas.GetMulti(Filter, relations)
				_cabFacturasCollectionViaDetFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedCabFacturasCollectionViaDetFacturas = True
			End If
			Return _cabFacturasCollectionViaDetFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabFacturasCollectionViaDetFacturas'. These settings will be taken into account
		''' when the property CabFacturasCollectionViaDetFacturas is requested or GetMultiCabFacturasCollectionViaDetFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabFacturasCollectionViaDetFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabFacturasCollectionViaDetFacturas.SortClauses=sortClauses
			_cabFacturasCollectionViaDetFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaDetMovGan(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaDetMovGan(forceFetch, _cabMovGanCollectionViaDetMovGan.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaDetMovGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaDetMovGan Or forceFetch Or _alwaysFetchCabMovGanCollectionViaDetMovGan) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaDetMovGan.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaDetMovGan)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", "DetMovGan_", JoinHint.None)
				relations.Add(DetMovGanEntity.Relations.CabMovGanEntityUsingFolMovGan, "DetMovGan_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_cabMovGanCollectionViaDetMovGan.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaDetMovGan.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaDetMovGan.GetMulti(Filter, relations)
				_cabMovGanCollectionViaDetMovGan.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaDetMovGan = True
			End If
			Return _cabMovGanCollectionViaDetMovGan
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaDetMovGan'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaDetMovGan is requested or GetMultiCabMovGanCollectionViaDetMovGan is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaDetMovGan(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaDetMovGan.SortClauses=sortClauses
			_cabMovGanCollectionViaDetMovGan.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegComCollectionViaDetRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegComCollectionViaDetRegCom(forceFetch, _cabRegComCollectionViaDetRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabRegComCollectionViaDetRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabRegComCollection
			If ( Not _alreadyFetchedCabRegComCollectionViaDetRegCom Or forceFetch Or _alwaysFetchCabRegComCollectionViaDetRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabRegComCollectionViaDetRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabRegComCollectionViaDetRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", "DetRegCom_", JoinHint.None)
				relations.Add(DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, "DetRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_cabRegComCollectionViaDetRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabRegComCollectionViaDetRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabRegComCollectionViaDetRegCom.GetMulti(Filter, relations)
				_cabRegComCollectionViaDetRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabRegComCollectionViaDetRegCom = True
			End If
			Return _cabRegComCollectionViaDetRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabRegComCollectionViaDetRegCom'. These settings will be taken into account
		''' when the property CabRegComCollectionViaDetRegCom is requested or GetMultiCabRegComCollectionViaDetRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabRegComCollectionViaDetRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabRegComCollectionViaDetRegCom.SortClauses=sortClauses
			_cabRegComCollectionViaDetRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet(forceFetch, _mcecatCorralesCabCollectionViaMcecatCorralesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaMcecatCorralesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaMcecatCorralesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "McecatCorralesDet_", JoinHint.None)
				relations.Add(McecatCorralesDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "McecatCorralesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_mcecatCorralesCabCollectionViaMcecatCorralesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaMcecatCorralesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaMcecatCorralesDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaMcecatCorralesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet = True
			End If
			Return _mcecatCorralesCabCollectionViaMcecatCorralesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaMcecatCorralesDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaMcecatCorralesDet is requested or GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaMcecatCorralesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaMcecatCorralesDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaMcecatCorralesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaMcecatLotesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaMcecatLotesDet(forceFetch, _mcecatLotesCabCollectionViaMcecatLotesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaMcecatLotesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaMcecatLotesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaMcecatLotesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "McecatLotesDet_", JoinHint.None)
				relations.Add(McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "McecatLotesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_mcecatLotesCabCollectionViaMcecatLotesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaMcecatLotesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaMcecatLotesDet.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaMcecatLotesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet = True
			End If
			Return _mcecatLotesCabCollectionViaMcecatLotesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaMcecatLotesDet'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaMcecatLotesDet is requested or GetMultiMcecatLotesCabCollectionViaMcecatLotesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaMcecatLotesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaMcecatLotesDet.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaMcecatLotesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
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
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
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
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "SalidaGanadoDet_", JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab, "SalidaGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
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

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaUsrProdRecepcionDetalle(forceFetch, _productoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaUsrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaUsrProdRecepcionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_productoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaUsrProdRecepcionDetalle.GetMulti(Filter, relations)
				_productoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = True
			End If
			Return _productoCollectionViaUsrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaUsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaUsrProdRecepcionDetalle is requested or GetMultiProductoCollectionViaUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaUsrProdRecepcionDetalle.SortClauses=sortClauses
			_productoCollectionViaUsrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosEntity'</returns>
		Public Function GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle(forceFetch, _msccatProductosCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			If ( Not _alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductosCollectionViaUsrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductosCollectionViaUsrProdRecepcionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_msccatProductosCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductosCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductosCollectionViaUsrProdRecepcionDetalle.GetMulti(Filter, relations)
				_msccatProductosCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle = True
			End If
			Return _msccatProductosCollectionViaUsrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductosCollectionViaUsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property MsccatProductosCollectionViaUsrProdRecepcionDetalle is requested or GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductosCollectionViaUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductosCollectionViaUsrProdRecepcionDetalle.SortClauses=sortClauses
			_msccatProductosCollectionViaUsrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch, _recepcionGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			If ( Not _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle Or forceFetch Or _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionGanadoCollectionViaUsrProdRecepcionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionGanadoCollectionViaUsrProdRecepcionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatTiposdeGanadoFieldIndex.IdTipoGanado), ComparisonOperator.Equal, Me.IdTipoGanado))
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.GetMulti(Filter, relations)
				_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = True
			End If
			Return _recepcionGanadoCollectionViaUsrProdRecepcionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionGanadoCollectionViaUsrProdRecepcionDetalle'. These settings will be taken into account
		''' when the property RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is requested or GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.SortClauses=sortClauses
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McgcatTiposdeGanadoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McgcatTiposdeGanadoFieldIndex)










					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detFacturas.ActiveContext = MyBase.ActiveContext
			_detMovGan.ActiveContext = MyBase.ActiveContext
			_detRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesDet.ActiveContext = MyBase.ActiveContext
			_salidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_usrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_recepcionGanado.ActiveContext = MyBase.ActiveContext
			_cabFacturasCollectionViaDetFacturas.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaDetMovGan.ActiveContext = MyBase.ActiveContext
			_cabRegComCollectionViaDetRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaMcecatCorralesDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaMcecatLotesDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesDetCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCabCollectionViaSalidaGanadoDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_msccatProductosCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McgcatTiposdeGanadoDAO = CType(CreateDAOInstance(), McgcatTiposdeGanadoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McgcatTiposdeGanadoDAO = CType(CreateDAOInstance(), McgcatTiposdeGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McgcatTiposdeGanadoDAO = CType(CreateDAOInstance(), McgcatTiposdeGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McgcatTiposdeGanadoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="validator">The validator Object for this McgcatTiposdeGanadoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idTipoGanado As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idTipoGanado, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detFacturas = New Integralab.ORM.CollectionClasses.DetFacturasCollection(New DetFacturasEntityFactory())
			_detFacturas.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchDetFacturas = False
			_alreadyFetchedDetFacturas = False
			_detMovGan = New Integralab.ORM.CollectionClasses.DetMovGanCollection(New DetMovGanEntityFactory())
			_detMovGan.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchDetMovGan = False
			_alreadyFetchedDetMovGan = False
			_detRegCom = New Integralab.ORM.CollectionClasses.DetRegComCollection(New DetRegComEntityFactory())
			_detRegCom.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchDetRegCom = False
			_alreadyFetchedDetRegCom = False
			_mcecatCorralesDet = New Integralab.ORM.CollectionClasses.McecatCorralesDetCollection(New McecatCorralesDetEntityFactory())
			_mcecatCorralesDet.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchMcecatCorralesDet = False
			_alreadyFetchedMcecatCorralesDet = False
			_mcecatLotesDet = New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(New McecatLotesDetEntityFactory())
			_mcecatLotesDet.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchMcecatLotesDet = False
			_alreadyFetchedMcecatLotesDet = False
			_salidaGanadoDet = New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(New SalidaGanadoDetEntityFactory())
			_salidaGanadoDet.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchSalidaGanadoDet = False
			_alreadyFetchedSalidaGanadoDet = False
			_usrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(New UsrProdRecepcionDetalleEntityFactory())
			_usrProdRecepcionDetalle.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchUsrProdRecepcionDetalle = False
			_alreadyFetchedUsrProdRecepcionDetalle = False
			_recepcionGanado = New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(New RecepcionGanadoEntityFactory())
			_recepcionGanado.SetContainingEntityInfo(Me, "McgcatTiposdeGanado")
			_alwaysFetchRecepcionGanado = False
			_alreadyFetchedRecepcionGanado = False
			_cabFacturasCollectionViaDetFacturas = New Integralab.ORM.CollectionClasses.CabFacturasCollection(New CabFacturasEntityFactory())
			_alwaysFetchCabFacturasCollectionViaDetFacturas = False
			_alreadyFetchedCabFacturasCollectionViaDetFacturas = False
			_cabMovGanCollectionViaDetMovGan = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaDetMovGan = False
			_alreadyFetchedCabMovGanCollectionViaDetMovGan = False
			_cabRegComCollectionViaDetRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_alwaysFetchCabRegComCollectionViaDetRegCom = False
			_alreadyFetchedCabRegComCollectionViaDetRegCom = False
			_mcecatCorralesCabCollectionViaMcecatCorralesDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaMcecatCorralesDet = False
			_mcecatLotesCabCollectionViaMcecatLotesDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaMcecatLotesDet = False
			_mcecatLotesCabCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoDet = False
			_mcecatLotesDetCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(New McecatLotesDetEntityFactory())
			_alwaysFetchMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_alreadyFetchedMcecatLotesDetCollectionViaSalidaGanadoDet = False
			_salidaGanadoCabCollectionViaSalidaGanadoDet = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_alwaysFetchSalidaGanadoCabCollectionViaSalidaGanadoDet = False
			_alreadyFetchedSalidaGanadoCabCollectionViaSalidaGanadoDet = False
			_productoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = False
			_msccatProductosCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.MsccatProductosCollection(New MsccatProductosEntityFactory())
			_alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedMsccatProductosCollectionViaUsrProdRecepcionDetalle = False
			_recepcionGanadoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(New RecepcionGanadoEntityFactory())
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumuladoCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AcumuladoKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaEntrada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Lados", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idTipoGanado">PK value for McgcatTiposdeGanado which data should be fetched into this McgcatTiposdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idTipoGanado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McgcatTiposdeGanadoFieldIndex.IdTipoGanado)).ForcedCurrentValueWrite(idTipoGanado)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcgcatTiposdeGanadoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McgcatTiposdeGanadoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McgcatTiposdeGanadoRelations
			Get	
				Return New McgcatTiposdeGanadoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetFacturas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetFacturas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetFacturasCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.DetFacturasEntity, Integer), 0, Nothing, Nothing, Nothing, "DetFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetMovGan() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetMovGanCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.DetMovGanEntity, Integer), 0, Nothing, Nothing, Nothing, "DetMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetRegComCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.DetRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "DetRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesDetCollection(), _
					McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(), _
					McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoDetCollection(), _
					McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(), _
					McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					McgcatTiposdeGanadoEntity.Relations.RecepcionGanadoEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabFacturas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabFacturasCollectionViaDetFacturas() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetFacturasEntity.Relations.CabFacturasEntityUsingFolFactura)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabFacturasCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetFacturasEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), 0, Nothing, Nothing, relations, "CabFacturasCollectionViaDetFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaDetMovGan() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetMovGanEntity.Relations.CabMovGanEntityUsingFolMovGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetMovGanEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaDetMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegComCollectionViaDetRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(DetRegComEntity.Relations.CabRegComEntityUsingFolRecep)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					McgcatTiposdeGanadoEntity.Relations.DetRegComEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, relations, "CabRegComCollectionViaDetRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaMcecatCorralesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatCorralesDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McgcatTiposdeGanadoEntity.Relations.McecatCorralesDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaMcecatCorralesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaMcecatLotesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McgcatTiposdeGanadoEntity.Relations.McecatLotesDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaMcecatLotesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesDetCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.McecatLotesDetEntityUsingIdMcecatLotesDet)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesDetCollection(), _
					McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesDetEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesDetCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCabCollectionViaSalidaGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McgcatTiposdeGanadoEntity.Relations.SalidaGanadoDetEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, relations, "SalidaGanadoCabCollectionViaSalidaGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, relations, "MsccatProductosCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanadoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, "__McgcatTiposdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					McgcatTiposdeGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, relations, "RecepcionGanadoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McgcatTiposdeGanadoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McgcatTiposdeGanadoEntity.CustomProperties
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
				Return McgcatTiposdeGanadoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdTipoGanado property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."IdTipoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdTipoGanado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.IdTipoGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.IdTipoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescCorta property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."DescCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 6<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.DescCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.DescCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumuladoCabezas property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."AcumuladoCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumuladoCabezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.AcumuladoCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.AcumuladoCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The AcumuladoKilos property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."AcumuladoKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AcumuladoKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.AcumuladoKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.AcumuladoKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaEntrada property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."FechaUltimaEntrada"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaEntrada]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.FechaUltimaEntrada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.FechaUltimaEntrada, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaSalida property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."FechaUltimaSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaSalida]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.FechaUltimaSalida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.FechaUltimaSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Lados property of the Entity McgcatTiposdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatTiposdeGanado"."Lados"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Lados]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Lados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McgcatTiposdeGanadoFieldIndex.Lados, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetFacturas]() As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Get
				Return GetMultiDetFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetFacturas. When set to true, DetFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetFacturas As Boolean
			Get
				Return _alwaysFetchDetFacturas
			End Get
			Set
				_alwaysFetchDetFacturas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetMovGanEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetMovGan()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetMovGan]() As Integralab.ORM.CollectionClasses.DetMovGanCollection
			Get
				Return GetMultiDetMovGan(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetMovGan. When set to true, DetMovGan is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetMovGan is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetMovGan(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetMovGan As Boolean
			Get
				Return _alwaysFetchDetMovGan
			End Get
			Set
				_alwaysFetchDetMovGan = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetRegCom]() As Integralab.ORM.CollectionClasses.DetRegComCollection
			Get
				Return GetMultiDetRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetRegCom. When set to true, DetRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetRegCom As Boolean
			Get
				Return _alwaysFetchDetRegCom
			End Get
			Set
				_alwaysFetchDetRegCom = value
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
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionGanado]() As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Get
				Return GetMultiRecepcionGanado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanado. When set to true, RecepcionGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanado is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanado As Boolean
			Get
				Return _alwaysFetchRecepcionGanado
			End Get
			Set
				_alwaysFetchRecepcionGanado = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabFacturasEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabFacturasCollectionViaDetFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabFacturasCollectionViaDetFacturas]() As Integralab.ORM.CollectionClasses.CabFacturasCollection
			Get
				Return GetMultiCabFacturasCollectionViaDetFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabFacturasCollectionViaDetFacturas. When set to true, CabFacturasCollectionViaDetFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabFacturasCollectionViaDetFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabFacturasCollectionViaDetFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabFacturasCollectionViaDetFacturas As Boolean
			Get
				Return _alwaysFetchCabFacturasCollectionViaDetFacturas
			End Get
			Set
				_alwaysFetchCabFacturasCollectionViaDetFacturas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaDetMovGan()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaDetMovGan]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaDetMovGan(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaDetMovGan. When set to true, CabMovGanCollectionViaDetMovGan is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaDetMovGan is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaDetMovGan(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaDetMovGan As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaDetMovGan
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaDetMovGan = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabRegComCollectionViaDetRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabRegComCollectionViaDetRegCom]() As Integralab.ORM.CollectionClasses.CabRegComCollection
			Get
				Return GetMultiCabRegComCollectionViaDetRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegComCollectionViaDetRegCom. When set to true, CabRegComCollectionViaDetRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegComCollectionViaDetRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabRegComCollectionViaDetRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegComCollectionViaDetRegCom As Boolean
			Get
				Return _alwaysFetchCabRegComCollectionViaDetRegCom
			End Get
			Set
				_alwaysFetchCabRegComCollectionViaDetRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaMcecatCorralesDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaMcecatCorralesDet. When set to true, McecatCorralesCabCollectionViaMcecatCorralesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaMcecatCorralesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaMcecatCorralesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaMcecatCorralesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaMcecatLotesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaMcecatLotesDet]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaMcecatLotesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaMcecatLotesDet. When set to true, McecatLotesCabCollectionViaMcecatLotesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaMcecatLotesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaMcecatLotesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaMcecatLotesDet = value
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
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaUsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaUsrProdRecepcionDetalle. When set to true, ProductoCollectionViaUsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaUsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductosCollectionViaUsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Get
				Return GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosCollectionViaUsrProdRecepcionDetalle. When set to true, MsccatProductosCollectionViaUsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosCollectionViaUsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductosCollectionViaUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchMsccatProductosCollectionViaUsrProdRecepcionDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionGanadoCollectionViaUsrProdRecepcionDetalle]() As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Get
				Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanadoCollectionViaUsrProdRecepcionDetalle. When set to true, RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanadoCollectionViaUsrProdRecepcionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
			Get
				Return _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle
			End Get
			Set
				_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionDetalle = value
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
				Return CInt(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity)
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
