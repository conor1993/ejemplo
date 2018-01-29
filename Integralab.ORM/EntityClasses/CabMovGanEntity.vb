' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 16:36:35
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
	''' <summary>Entity class which represents the entity 'CabMovGan'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabMovGanEntity 
#Else
	<Serializable()> _
	Public Class CabMovGanEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom As Boolean
		Private _cabRegCom_ As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom_, _alreadyFetchedCabRegCom_ As Boolean
		Private _detMovGan As Integralab.ORM.CollectionClasses.DetMovGanCollection
		Private _alwaysFetchDetMovGan, _alreadyFetchedDetMovGan As Boolean
		Private _salidaGanadoCab As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab As Boolean
		Private _catLugaresDeCompraCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom, _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom As Boolean
		Private _proveedorCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCabRegCom, _alreadyFetchedProveedorCollectionViaCabRegCom As Boolean
		Private _mcecatCorralesCabCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom, _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom As Boolean
		Private _mcgcatCompradoresdeGanadoCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom, _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom As Boolean
		Private _catLugaresDeCompraCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_, _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ As Boolean
		Private _proveedorCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCabRegCom_, _alreadyFetchedProveedorCollectionViaCabRegCom_ As Boolean
		Private _mcecatCorralesCabCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_, _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ As Boolean
		Private _mcgcatCompradoresdeGanadoCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
		Private _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_, _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaDetMovGan As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
		Private _mcgcatCausasMuerteCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection
		Private _alwaysFetchMcgcatCausasMuerteCollectionViaSalidaGanadoCab, _alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab As Boolean
		Private _catRastrosCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab, _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatCorralesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
		Private _polizaCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaSalidaGanadoCab, _alreadyFetchedPolizaCollectionViaSalidaGanadoCab As Boolean
		Private _mcgcatMovGanado As McgcatMovGanadoEntity
		Private _alwaysFetchMcgcatMovGanado, _alreadyFetchedMcgcatMovGanado, _mcgcatMovGanadoReturnsNewIfNotFound As Boolean


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
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		Public Sub New(folMovGan As System.String)

			InitClassFetch(folMovGan, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folMovGan As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folMovGan, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="validator">The custom validator Object for this CabMovGanEntity</param>
		Public Sub New(folMovGan As System.String, validator As IValidator)

			InitClassFetch(folMovGan, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_cabRegCom_ = CType(info.GetValue("_cabRegCom_", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom_ = info.GetBoolean("_alwaysFetchCabRegCom_")
			_alreadyFetchedCabRegCom_ = info.GetBoolean("_alreadyFetchedCabRegCom_")
			_detMovGan = CType(info.GetValue("_detMovGan", GetType(Integralab.ORM.CollectionClasses.DetMovGanCollection)), Integralab.ORM.CollectionClasses.DetMovGanCollection)
			_alwaysFetchDetMovGan = info.GetBoolean("_alwaysFetchDetMovGan")
			_alreadyFetchedDetMovGan = info.GetBoolean("_alreadyFetchedDetMovGan")
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_catLugaresDeCompraCollectionViaCabRegCom = CType(info.GetValue("_catLugaresDeCompraCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom")
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom")
			_proveedorCollectionViaCabRegCom = CType(info.GetValue("_proveedorCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchProveedorCollectionViaCabRegCom")
			_alreadyFetchedProveedorCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCabRegCom")
			_mcecatCorralesCabCollectionViaCabRegCom = CType(info.GetValue("_mcecatCorralesCabCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom")
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom")
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = CType(info.GetValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom")
			_catLugaresDeCompraCollectionViaCabRegCom_ = CType(info.GetValue("_catLugaresDeCompraCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_")
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_")
			_proveedorCollectionViaCabRegCom_ = CType(info.GetValue("_proveedorCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchProveedorCollectionViaCabRegCom_")
			_alreadyFetchedProveedorCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCabRegCom_")
			_mcecatCorralesCabCollectionViaCabRegCom_ = CType(info.GetValue("_mcecatCorralesCabCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_")
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_")
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = CType(info.GetValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection)
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_")
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_")
			_mcgcatTiposdeGanadoCollectionViaDetMovGan = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaDetMovGan", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan")
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
			_polizaCollectionViaSalidaGanadoCab = CType(info.GetValue("_polizaCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchPolizaCollectionViaSalidaGanadoCab")
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab")
			_mcgcatMovGanado = CType(info.GetValue("_mcgcatMovGanado", GetType(McgcatMovGanadoEntity)), McgcatMovGanadoEntity)
			If Not _mcgcatMovGanado Is Nothing Then
				AddHandler _mcgcatMovGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatMovGanadoReturnsNewIfNotFound = info.GetBoolean("_mcgcatMovGanadoReturnsNewIfNotFound")
			_alwaysFetchMcgcatMovGanado = info.GetBoolean("_alwaysFetchMcgcatMovGanado")
			_alreadyFetchedMcgcatMovGanado = info.GetBoolean("_alreadyFetchedMcgcatMovGanado")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabRegCom = (_cabRegCom.Count > 0)
			_alreadyFetchedCabRegCom_ = (_cabRegCom_.Count > 0)
			_alreadyFetchedDetMovGan = (_detMovGan.Count > 0)
			_alreadyFetchedSalidaGanadoCab = (_salidaGanadoCab.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = (_catLugaresDeCompraCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedProveedorCollectionViaCabRegCom = (_proveedorCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = (_mcecatCorralesCabCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = (_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ = (_catLugaresDeCompraCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedProveedorCollectionViaCabRegCom_ = (_proveedorCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ = (_mcecatCorralesCabCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = (_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan = (_mcgcatTiposdeGanadoCollectionViaDetMovGan.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = (_mcecatLotesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcgcatCausasMuerteCollectionViaSalidaGanadoCab = (_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = (_catRastrosCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = (_mcecatCorralesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = (_polizaCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcgcatMovGanado = Not(_mcgcatMovGanado Is Nothing)

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
			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_cabRegCom_", _cabRegCom_)
			info.AddValue("_alwaysFetchCabRegCom_", _alwaysFetchCabRegCom_)
			info.AddValue("_alreadyFetchedCabRegCom_", _alreadyFetchedCabRegCom_)
			info.AddValue("_detMovGan", _detMovGan)
			info.AddValue("_alwaysFetchDetMovGan", _alwaysFetchDetMovGan)
			info.AddValue("_alreadyFetchedDetMovGan", _alreadyFetchedDetMovGan)
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_catLugaresDeCompraCollectionViaCabRegCom", _catLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom", _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom", _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_proveedorCollectionViaCabRegCom", _proveedorCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchProveedorCollectionViaCabRegCom", _alwaysFetchProveedorCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCabRegCom", _alreadyFetchedProveedorCollectionViaCabRegCom)
			info.AddValue("_mcecatCorralesCabCollectionViaCabRegCom", _mcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom", _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom", _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom", _mcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom", _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom)
			info.AddValue("_catLugaresDeCompraCollectionViaCabRegCom_", _catLugaresDeCompraCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_", _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_", _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_)
			info.AddValue("_proveedorCollectionViaCabRegCom_", _proveedorCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchProveedorCollectionViaCabRegCom_", _alwaysFetchProveedorCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCabRegCom_", _alreadyFetchedProveedorCollectionViaCabRegCom_)
			info.AddValue("_mcecatCorralesCabCollectionViaCabRegCom_", _mcecatCorralesCabCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_", _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_", _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_)
			info.AddValue("_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_", _mcgcatCompradoresdeGanadoCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_", _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_", _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaDetMovGan", _mcgcatTiposdeGanadoCollectionViaDetMovGan)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan", _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan)
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
			info.AddValue("_polizaCollectionViaSalidaGanadoCab", _polizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchPolizaCollectionViaSalidaGanadoCab", _alwaysFetchPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab", _alreadyFetchedPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_mcgcatMovGanado", _mcgcatMovGanado)
			info.AddValue("_mcgcatMovGanadoReturnsNewIfNotFound", _mcgcatMovGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatMovGanado", _alwaysFetchMcgcatMovGanado)
			info.AddValue("_alreadyFetchedMcgcatMovGanado", _alreadyFetchedMcgcatMovGanado)

			
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
				Case "McgcatMovGanado"
					_alreadyFetchedMcgcatMovGanado = True
					Me.McgcatMovGanado = CType(entity, McgcatMovGanadoEntity)
				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "CabRegCom_"
					_alreadyFetchedCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.CabRegCom_.Add(CType(entity, CabRegComEntity))
					End If
				Case "DetMovGan"
					_alreadyFetchedDetMovGan = True
					If Not entity Is Nothing Then
						Me.DetMovGan.Add(CType(entity, DetMovGanEntity))
					End If
				Case "SalidaGanadoCab"
					_alreadyFetchedSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCab.Add(CType(entity, SalidaGanadoCabEntity))
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
				Case "McecatCorralesCabCollectionViaCabRegCom"
					_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaCabRegCom.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McgcatCompradoresdeGanadoCollectionViaCabRegCom"
					_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanadoCollectionViaCabRegCom.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaCabRegCom_"
					_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaCabRegCom_.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "ProveedorCollectionViaCabRegCom_"
					_alreadyFetchedProveedorCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCabRegCom_.Add(CType(entity, ProveedorEntity))
					End If
				Case "McecatCorralesCabCollectionViaCabRegCom_"
					_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaCabRegCom_.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McgcatCompradoresdeGanadoCollectionViaCabRegCom_"
					_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.McgcatCompradoresdeGanadoCollectionViaCabRegCom_.Add(CType(entity, McgcatCompradoresdeGanadoEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaDetMovGan"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaDetMovGan.Add(CType(entity, McgcatTiposdeGanadoEntity))
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
				Case "McgcatMovGanado"
					SetupSyncMcgcatMovGanado(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabRegCom"
					_cabRegCom.Add(CType(relatedEntity, CabRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabRegCom_"
					_cabRegCom_.Add(CType(relatedEntity, CabRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetMovGan"
					_detMovGan.Add(CType(relatedEntity, DetMovGanEntity))
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
				Case "McgcatMovGanado"
					DesetupSyncMcgcatMovGanado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabRegCom"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabRegCom_"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetMovGan"
					MyBase.PerformRelatedEntityRemoval(_detMovGan, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _mcgcatMovGanado Is Nothing Then
				toReturn.Add(_mcgcatMovGanado)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cabRegCom)
			toReturn.Add(_cabRegCom_)
			toReturn.Add(_detMovGan)
			toReturn.Add(_salidaGanadoCab)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folMovGan As System.String) As Boolean
			Return FetchUsingPK(folMovGan, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folMovGan As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folMovGan, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folMovGan As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folMovGan, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolMovGan, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabMovGanFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabMovGanFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_cabRegCom.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom_(forceFetch, _cabRegCom_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom_(forceFetch, _cabRegCom_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			If ( Not _alreadyFetchedCabRegCom_ Or forceFetch Or _alwaysFetchCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabRegCom_)
					End If
				End If
				_cabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabRegCom_.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_cabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedCabRegCom_ = True
			End If
			Return _cabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabRegCom_'. These settings will be taken into account
		''' when the property CabRegCom_ is requested or GetMultiCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabRegCom_.SortClauses=sortClauses
			_cabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_detMovGan.GetMultiManyToOne(Me, Nothing, Filter)
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
				_salidaGanadoCab.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Nothing, Filter)
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
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch, _mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
			End If
			Return _mcecatCorralesCabCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaCabRegCom is requested or GetMultiMcecatCorralesCabCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaCabRegCom.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom_(forceFetch, _catLugaresDeCompraCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_catLugaresDeCompraCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ = True
			End If
			Return _catLugaresDeCompraCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaCabRegCom_ is requested or GetMultiCatLugaresDeCompraCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaCabRegCom_.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCabRegCom_(forceFetch, _proveedorCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchProveedorCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_proveedorCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_proveedorCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCabRegCom_ = True
			End If
			Return _proveedorCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCabRegCom_ is requested or GetMultiProveedorCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCabRegCom_.SortClauses=sortClauses
			_proveedorCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaCabRegCom_(forceFetch, _mcecatCorralesCabCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_mcecatCorralesCabCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ = True
			End If
			Return _mcecatCorralesCabCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaCabRegCom_ is requested or GetMultiMcecatCorralesCabCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaCabRegCom_.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatCompradoresdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(forceFetch, _mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = True
			End If
			Return _mcgcatCompradoresdeGanadoCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatCompradoresdeGanadoCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property McgcatCompradoresdeGanadoCollectionViaCabRegCom_ is requested or GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.SortClauses=sortClauses
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan(forceFetch, _mcgcatTiposdeGanadoCollectionViaDetMovGan.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaDetMovGan.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaDetMovGan)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabMovGanEntity.Relations.DetMovGanEntityUsingFolMovGan, "__CabMovGanEntity__", "DetMovGan_", JoinHint.None)
				relations.Add(DetMovGanEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, "DetMovGan_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
				_mcgcatTiposdeGanadoCollectionViaDetMovGan.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaDetMovGan.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaDetMovGan.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaDetMovGan.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaDetMovGan
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaDetMovGan'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaDetMovGan is requested or GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaDetMovGan(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaDetMovGan.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaDetMovGan.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabMovGanFieldIndex.FolMovGan), ComparisonOperator.Equal, Me.FolMovGan))
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

		''' <summary>Retrieves the related entity of type 'McgcatMovGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McgcatMovGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatMovGanado() As McgcatMovGanadoEntity
			Return GetSingleMcgcatMovGanado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McgcatMovGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McgcatMovGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatMovGanado(forceFetch As Boolean) As McgcatMovGanadoEntity
			If ( Not _alreadyFetchedMcgcatMovGanado Or forceFetch Or _alwaysFetchMcgcatMovGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McgcatMovGanadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabMovGanEntity.Relations.McgcatMovGanadoEntityUsingCveMovGan) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveMovGan)
				End If
				If Not _mcgcatMovGanadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McgcatMovGanado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McgcatMovGanadoEntity)
					End If
					Me.McgcatMovGanado = newEntity
					_alreadyFetchedMcgcatMovGanado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcgcatMovGanado
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabMovGanFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabMovGanFieldIndex)


					Case CabMovGanFieldIndex.CveMovGan
						DesetupSyncMcgcatMovGanado(True, False)
						_alreadyFetchedMcgcatMovGanado = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabRegCom.ActiveContext = MyBase.ActiveContext
			_cabRegCom_.ActiveContext = MyBase.ActiveContext
			_detMovGan.ActiveContext = MyBase.ActiveContext
			_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaDetMovGan.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcgcatCausasMuerteCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
		If Not _mcgcatMovGanado Is Nothing Then
				_mcgcatMovGanado.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabMovGanDAO = CType(CreateDAOInstance(), CabMovGanDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabMovGanDAO = CType(CreateDAOInstance(), CabMovGanDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabMovGanDAO = CType(CreateDAOInstance(), CabMovGanDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabMovGanEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabMovGanEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="validator">The validator Object for this CabMovGanEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folMovGan As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folMovGan, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cabRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom.SetContainingEntityInfo(Me, "CabMovGan")
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_cabRegCom_ = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom_.SetContainingEntityInfo(Me, "CabMovGan_")
			_alwaysFetchCabRegCom_ = False
			_alreadyFetchedCabRegCom_ = False
			_detMovGan = New Integralab.ORM.CollectionClasses.DetMovGanCollection(New DetMovGanEntityFactory())
			_detMovGan.SetContainingEntityInfo(Me, "CabMovGan")
			_alwaysFetchDetMovGan = False
			_alreadyFetchedDetMovGan = False
			_salidaGanadoCab = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_salidaGanadoCab.SetContainingEntityInfo(Me, "CabMovGan")
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_catLugaresDeCompraCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = False
			_proveedorCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCabRegCom = False
			_alreadyFetchedProveedorCollectionViaCabRegCom = False
			_mcecatCorralesCabCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = False
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = False
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom = False
			_catLugaresDeCompraCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_ = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom_ = False
			_proveedorCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCabRegCom_ = False
			_alreadyFetchedProveedorCollectionViaCabRegCom_ = False
			_mcecatCorralesCabCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_ = False
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom_ = False
			_mcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(New McgcatCompradoresdeGanadoEntityFactory())
			_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = False
			_alreadyFetchedMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = False
			_mcgcatTiposdeGanadoCollectionViaDetMovGan = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetMovGan = False
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
			_polizaCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = False
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = False
			_mcgcatMovGanado = Nothing
			_mcgcatMovGanadoReturnsNewIfNotFound = True
			_alwaysFetchMcgcatMovGanado = False
			_alreadyFetchedMcgcatMovGanado = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolMovGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecMovGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveMovGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveGanadera", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("StaMov", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolRefere", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mcgcatMovGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatMovGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatMovGanado, AddressOf OnMcgcatMovGanadoPropertyChanged, "McgcatMovGanado", CabMovGanEntity.Relations.McgcatMovGanadoEntityUsingCveMovGan, True, signalRelatedEntity, "CabMovGan", resetFKFields, New Integer() { CInt(CabMovGanFieldIndex.CveMovGan) } )
			_mcgcatMovGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatMovGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatMovGanado(relatedEntity As IEntity)
			DesetupSyncMcgcatMovGanado(True, True)
			_mcgcatMovGanado = CType(relatedEntity, McgcatMovGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatMovGanado, AddressOf OnMcgcatMovGanadoPropertyChanged, "McgcatMovGanado", CabMovGanEntity.Relations.McgcatMovGanadoEntityUsingCveMovGan, True, _alreadyFetchedMcgcatMovGanado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcgcatMovGanadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folMovGan">PK value for CabMovGan which data should be fetched into this CabMovGan Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folMovGan As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabMovGanFieldIndex.FolMovGan)).ForcedCurrentValueWrite(folMovGan)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabMovGanDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabMovGanEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabMovGanRelations
			Get	
				Return New CabMovGanRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetMovGan() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetMovGanCollection(), _
					CabMovGanEntity.Relations.DetMovGanEntityUsingFolMovGan, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.DetMovGanEntity, Integer), 0, Nothing, Nothing, Nothing, "DetMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanadoCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCompradoresdeGanadoCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanadoCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					CabMovGanEntity.Relations.CabRegComEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCompradoresdeGanadoCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaDetMovGan() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.DetMovGanEntityUsingFolMovGan, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(DetMovGanEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					CabMovGanEntity.Relations.DetMovGanEntityUsingFolMovGan, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaDetMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCausasMuerte' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCausasMuerteCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McgcatCausasMuerteEntityUsingIdCausaMuerte)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCausasMuerteCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), 0, Nothing, Nothing, relations, "McgcatCausasMuerteCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, "__CabMovGanEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CabMovGanEntity.Relations.SalidaGanadoCabEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatMovGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatMovGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatMovGanadoCollection(), _
					CabMovGanEntity.Relations.McgcatMovGanadoEntityUsingCveMovGan, _
					CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), CType(Integralab.ORM.EntityType.McgcatMovGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatMovGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabMovGanEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabMovGanEntity.CustomProperties
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
				Return CabMovGanEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolMovGan property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Fol_MovGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolMovGan]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.FolMovGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.FolMovGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecMovGan property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Fec_MovGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecMovGan]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.FecMovGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.FecMovGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveMovGan property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Cve_MovGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveMovGan]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.CveMovGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.CveMovGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveGanadera property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Cve_Ganadera"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CveGanadera]() As Nullable(Of System.Byte)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.CveGanadera, Integer))

				Return CType(valueToReturn, Nullable(Of System.Byte))
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.CveGanadera, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolPoliza property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Fol_Poliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.FolPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.FolPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The StaMov property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Sta_Mov"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [StaMov]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.StaMov, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.StaMov, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolRefere property of the Entity CabMovGan<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabMovGan"."Fol_Refere"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolRefere]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabMovGanFieldIndex.FolRefere, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabMovGanFieldIndex.FolRefere, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabRegCom_]() As Integralab.ORM.CollectionClasses.CabRegComCollection
			Get
				Return GetMultiCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegCom_. When set to true, CabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegCom_ As Boolean
			Get
				Return _alwaysFetchCabRegCom_
			End Get
			Set
				_alwaysFetchCabRegCom_ = value
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
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaCabRegCom. When set to true, McecatCorralesCabCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = value
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
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaCabRegCom_. When set to true, CatLugaresDeCompraCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCabRegCom_. When set to true, ProveedorCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaCabRegCom_. When set to true, McecatCorralesCabCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatCompradoresdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatCompradoresdeGanadoCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection
			Get
				Return GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCompradoresdeGanadoCollectionViaCabRegCom_. When set to true, McgcatCompradoresdeGanadoCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCompradoresdeGanadoCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatCompradoresdeGanadoCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchMcgcatCompradoresdeGanadoCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaDetMovGan]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaDetMovGan. When set to true, McgcatTiposdeGanadoCollectionViaDetMovGan is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaDetMovGan is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaDetMovGan(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetMovGan = value
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
	
	
		''' <summary>Gets / sets related entity of type 'McgcatMovGanadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcgcatMovGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McgcatMovGanado]() As McgcatMovGanadoEntity
			Get
				Return GetSingleMcgcatMovGanado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcgcatMovGanado(value)
				Else
					If value Is Nothing Then
						If Not _mcgcatMovGanado Is Nothing Then
							_mcgcatMovGanado.UnsetRelatedEntity(Me, "CabMovGan")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabMovGan")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatMovGanado. When set to true, McgcatMovGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatMovGanado is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcgcatMovGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatMovGanado As Boolean
			Get
				Return _alwaysFetchMcgcatMovGanado
			End Get
			Set
				_alwaysFetchMcgcatMovGanado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McgcatMovGanado is not found
		''' in the database. When set to true, McgcatMovGanado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McgcatMovGanadoReturnsNewIfNotFound As Boolean
			Get
				Return _mcgcatMovGanadoReturnsNewIfNotFound
			End Get
			Set
				_mcgcatMovGanadoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CabMovGanEntity)
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
