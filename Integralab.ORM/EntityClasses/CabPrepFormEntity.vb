' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:52:58
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
	''' <summary>Entity class which represents the entity 'CabPrepForm'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabPrepFormEntity 
#Else
	<Serializable()> _
	Public Class CabPrepFormEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detPrepForm As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepForm, _alreadyFetchedDetPrepForm As Boolean
		Private _detPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
		Private _alwaysFetchDetPrepFormLote, _alreadyFetchedDetPrepFormLote As Boolean
		Private _productoCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetPrepForm, _alreadyFetchedProductoCollectionViaDetPrepForm As Boolean
		Private _plazaCollectionViaDetPrepForm As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaDetPrepForm, _alreadyFetchedPlazaCollectionViaDetPrepForm As Boolean
		Private _detPrepFormCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.DetPrepFormCollection
		Private _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote, _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote As Boolean
		Private _productoCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetPrepFormLote, _alreadyFetchedProductoCollectionViaDetPrepFormLote As Boolean
		Private _plazaCollectionViaDetPrepFormLote As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaDetPrepFormLote, _alreadyFetchedPlazaCollectionViaDetPrepFormLote As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _envase As ProductoEntity
		Private _alwaysFetchEnvase, _alreadyFetchedEnvase, _envaseReturnsNewIfNotFound As Boolean
		Private _plaza As PlazaEntity
		Private _alwaysFetchPlaza, _alreadyFetchedPlaza, _plazaReturnsNewIfNotFound As Boolean
		Private _movimientoAlmacenEntradaMezcla As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchMovimientoAlmacenEntradaMezcla, _alreadyFetchedMovimientoAlmacenEntradaMezcla, _movimientoAlmacenEntradaMezclaReturnsNewIfNotFound As Boolean
		Private _movimientoAlmacenCancelacionEntradaMezcla As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla, _alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla, _movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound As Boolean
		Private _movimientoAlmacenSalidaIngrediente As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchMovimientoAlmacenSalidaIngrediente, _alreadyFetchedMovimientoAlmacenSalidaIngrediente, _movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound As Boolean
		Private _movimientoAlmacenCancelacionSalidaIngrediente As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente, _alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente, _movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound As Boolean


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
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		Public Sub New(folPrepForm As System.String, idPlaza As System.Int32)

			InitClassFetch(folPrepForm, idPlaza, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folPrepForm As System.String, idPlaza As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folPrepForm, idPlaza, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="validator">The custom validator Object for this CabPrepFormEntity</param>
		Public Sub New(folPrepForm As System.String, idPlaza As System.Int32, validator As IValidator)

			InitClassFetch(folPrepForm, idPlaza, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detPrepForm = CType(info.GetValue("_detPrepForm", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepForm = info.GetBoolean("_alwaysFetchDetPrepForm")
			_alreadyFetchedDetPrepForm = info.GetBoolean("_alreadyFetchedDetPrepForm")
			_detPrepFormLote = CType(info.GetValue("_detPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)), Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection)
			_alwaysFetchDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormLote")
			_alreadyFetchedDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormLote")
			_productoCollectionViaDetPrepForm = CType(info.GetValue("_productoCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchProductoCollectionViaDetPrepForm")
			_alreadyFetchedProductoCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetPrepForm")
			_plazaCollectionViaDetPrepForm = CType(info.GetValue("_plazaCollectionViaDetPrepForm", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaDetPrepForm = info.GetBoolean("_alwaysFetchPlazaCollectionViaDetPrepForm")
			_alreadyFetchedPlazaCollectionViaDetPrepForm = info.GetBoolean("_alreadyFetchedPlazaCollectionViaDetPrepForm")
			_detPrepFormCollectionViaDetPrepFormLote = CType(info.GetValue("_detPrepFormCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.DetPrepFormCollection)), Integralab.ORM.CollectionClasses.DetPrepFormCollection)
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote")
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote")
			_productoCollectionViaDetPrepFormLote = CType(info.GetValue("_productoCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchProductoCollectionViaDetPrepFormLote")
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetPrepFormLote")
			_plazaCollectionViaDetPrepFormLote = CType(info.GetValue("_plazaCollectionViaDetPrepFormLote", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaDetPrepFormLote = info.GetBoolean("_alwaysFetchPlazaCollectionViaDetPrepFormLote")
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = info.GetBoolean("_alreadyFetchedPlazaCollectionViaDetPrepFormLote")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_envase = CType(info.GetValue("_envase", GetType(ProductoEntity)), ProductoEntity)
			If Not _envase Is Nothing Then
				AddHandler _envase.AfterSave, AddressOf OnEntityAfterSave
			End If
			_envaseReturnsNewIfNotFound = info.GetBoolean("_envaseReturnsNewIfNotFound")
			_alwaysFetchEnvase = info.GetBoolean("_alwaysFetchEnvase")
			_alreadyFetchedEnvase = info.GetBoolean("_alreadyFetchedEnvase")
			_plaza = CType(info.GetValue("_plaza", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza Is Nothing Then
				AddHandler _plaza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plazaReturnsNewIfNotFound = info.GetBoolean("_plazaReturnsNewIfNotFound")
			_alwaysFetchPlaza = info.GetBoolean("_alwaysFetchPlaza")
			_alreadyFetchedPlaza = info.GetBoolean("_alreadyFetchedPlaza")
			_movimientoAlmacenEntradaMezcla = CType(info.GetValue("_movimientoAlmacenEntradaMezcla", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _movimientoAlmacenEntradaMezcla Is Nothing Then
				AddHandler _movimientoAlmacenEntradaMezcla.AfterSave, AddressOf OnEntityAfterSave
			End If
			_movimientoAlmacenEntradaMezclaReturnsNewIfNotFound = info.GetBoolean("_movimientoAlmacenEntradaMezclaReturnsNewIfNotFound")
			_alwaysFetchMovimientoAlmacenEntradaMezcla = info.GetBoolean("_alwaysFetchMovimientoAlmacenEntradaMezcla")
			_alreadyFetchedMovimientoAlmacenEntradaMezcla = info.GetBoolean("_alreadyFetchedMovimientoAlmacenEntradaMezcla")
			_movimientoAlmacenCancelacionEntradaMezcla = CType(info.GetValue("_movimientoAlmacenCancelacionEntradaMezcla", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _movimientoAlmacenCancelacionEntradaMezcla Is Nothing Then
				AddHandler _movimientoAlmacenCancelacionEntradaMezcla.AfterSave, AddressOf OnEntityAfterSave
			End If
			_movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound = info.GetBoolean("_movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound")
			_alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla = info.GetBoolean("_alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla")
			_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = info.GetBoolean("_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla")
			_movimientoAlmacenSalidaIngrediente = CType(info.GetValue("_movimientoAlmacenSalidaIngrediente", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _movimientoAlmacenSalidaIngrediente Is Nothing Then
				AddHandler _movimientoAlmacenSalidaIngrediente.AfterSave, AddressOf OnEntityAfterSave
			End If
			_movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound = info.GetBoolean("_movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound")
			_alwaysFetchMovimientoAlmacenSalidaIngrediente = info.GetBoolean("_alwaysFetchMovimientoAlmacenSalidaIngrediente")
			_alreadyFetchedMovimientoAlmacenSalidaIngrediente = info.GetBoolean("_alreadyFetchedMovimientoAlmacenSalidaIngrediente")
			_movimientoAlmacenCancelacionSalidaIngrediente = CType(info.GetValue("_movimientoAlmacenCancelacionSalidaIngrediente", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _movimientoAlmacenCancelacionSalidaIngrediente Is Nothing Then
				AddHandler _movimientoAlmacenCancelacionSalidaIngrediente.AfterSave, AddressOf OnEntityAfterSave
			End If
			_movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound = info.GetBoolean("_movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound")
			_alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente = info.GetBoolean("_alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente")
			_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = info.GetBoolean("_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetPrepForm = (_detPrepForm.Count > 0)
			_alreadyFetchedDetPrepFormLote = (_detPrepFormLote.Count > 0)
			_alreadyFetchedProductoCollectionViaDetPrepForm = (_productoCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedPlazaCollectionViaDetPrepForm = (_plazaCollectionViaDetPrepForm.Count > 0)
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = (_detPrepFormCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = (_productoCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = (_plazaCollectionViaDetPrepFormLote.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedEnvase = Not(_envase Is Nothing)
			_alreadyFetchedPlaza = Not(_plaza Is Nothing)
			_alreadyFetchedMovimientoAlmacenEntradaMezcla = Not(_movimientoAlmacenEntradaMezcla Is Nothing)
			_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = Not(_movimientoAlmacenCancelacionEntradaMezcla Is Nothing)
			_alreadyFetchedMovimientoAlmacenSalidaIngrediente = Not(_movimientoAlmacenSalidaIngrediente Is Nothing)
			_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = Not(_movimientoAlmacenCancelacionSalidaIngrediente Is Nothing)

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
			info.AddValue("_detPrepForm", _detPrepForm)
			info.AddValue("_alwaysFetchDetPrepForm", _alwaysFetchDetPrepForm)
			info.AddValue("_alreadyFetchedDetPrepForm", _alreadyFetchedDetPrepForm)
			info.AddValue("_detPrepFormLote", _detPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormLote", _alwaysFetchDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormLote", _alreadyFetchedDetPrepFormLote)
			info.AddValue("_productoCollectionViaDetPrepForm", _productoCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchProductoCollectionViaDetPrepForm", _alwaysFetchProductoCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetPrepForm", _alreadyFetchedProductoCollectionViaDetPrepForm)
			info.AddValue("_plazaCollectionViaDetPrepForm", _plazaCollectionViaDetPrepForm)
			info.AddValue("_alwaysFetchPlazaCollectionViaDetPrepForm", _alwaysFetchPlazaCollectionViaDetPrepForm)
			info.AddValue("_alreadyFetchedPlazaCollectionViaDetPrepForm", _alreadyFetchedPlazaCollectionViaDetPrepForm)
			info.AddValue("_detPrepFormCollectionViaDetPrepFormLote", _detPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote", _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote", _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote)
			info.AddValue("_productoCollectionViaDetPrepFormLote", _productoCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchProductoCollectionViaDetPrepFormLote", _alwaysFetchProductoCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetPrepFormLote", _alreadyFetchedProductoCollectionViaDetPrepFormLote)
			info.AddValue("_plazaCollectionViaDetPrepFormLote", _plazaCollectionViaDetPrepFormLote)
			info.AddValue("_alwaysFetchPlazaCollectionViaDetPrepFormLote", _alwaysFetchPlazaCollectionViaDetPrepFormLote)
			info.AddValue("_alreadyFetchedPlazaCollectionViaDetPrepFormLote", _alreadyFetchedPlazaCollectionViaDetPrepFormLote)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_envase", _envase)
			info.AddValue("_envaseReturnsNewIfNotFound", _envaseReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchEnvase", _alwaysFetchEnvase)
			info.AddValue("_alreadyFetchedEnvase", _alreadyFetchedEnvase)
			info.AddValue("_plaza", _plaza)
			info.AddValue("_plazaReturnsNewIfNotFound", _plazaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza", _alwaysFetchPlaza)
			info.AddValue("_alreadyFetchedPlaza", _alreadyFetchedPlaza)
			info.AddValue("_movimientoAlmacenEntradaMezcla", _movimientoAlmacenEntradaMezcla)
			info.AddValue("_movimientoAlmacenEntradaMezclaReturnsNewIfNotFound", _movimientoAlmacenEntradaMezclaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMovimientoAlmacenEntradaMezcla", _alwaysFetchMovimientoAlmacenEntradaMezcla)
			info.AddValue("_alreadyFetchedMovimientoAlmacenEntradaMezcla", _alreadyFetchedMovimientoAlmacenEntradaMezcla)
			info.AddValue("_movimientoAlmacenCancelacionEntradaMezcla", _movimientoAlmacenCancelacionEntradaMezcla)
			info.AddValue("_movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound", _movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla", _alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla)
			info.AddValue("_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla", _alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla)
			info.AddValue("_movimientoAlmacenSalidaIngrediente", _movimientoAlmacenSalidaIngrediente)
			info.AddValue("_movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound", _movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMovimientoAlmacenSalidaIngrediente", _alwaysFetchMovimientoAlmacenSalidaIngrediente)
			info.AddValue("_alreadyFetchedMovimientoAlmacenSalidaIngrediente", _alreadyFetchedMovimientoAlmacenSalidaIngrediente)
			info.AddValue("_movimientoAlmacenCancelacionSalidaIngrediente", _movimientoAlmacenCancelacionSalidaIngrediente)
			info.AddValue("_movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound", _movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente", _alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente)
			info.AddValue("_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente", _alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente)

			
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
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "Envase"
					_alreadyFetchedEnvase = True
					Me.Envase = CType(entity, ProductoEntity)
				Case "Plaza"
					_alreadyFetchedPlaza = True
					Me.Plaza = CType(entity, PlazaEntity)
				Case "MovimientoAlmacenEntradaMezcla"
					_alreadyFetchedMovimientoAlmacenEntradaMezcla = True
					Me.MovimientoAlmacenEntradaMezcla = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "MovimientoAlmacenCancelacionEntradaMezcla"
					_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = True
					Me.MovimientoAlmacenCancelacionEntradaMezcla = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "MovimientoAlmacenSalidaIngrediente"
					_alreadyFetchedMovimientoAlmacenSalidaIngrediente = True
					Me.MovimientoAlmacenSalidaIngrediente = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "MovimientoAlmacenCancelacionSalidaIngrediente"
					_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = True
					Me.MovimientoAlmacenCancelacionSalidaIngrediente = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "DetPrepForm"
					_alreadyFetchedDetPrepForm = True
					If Not entity Is Nothing Then
						Me.DetPrepForm.Add(CType(entity, DetPrepFormEntity))
					End If
				Case "DetPrepFormLote"
					_alreadyFetchedDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.DetPrepFormLote.Add(CType(entity, DetPrepFormLoteEntity))
					End If
				Case "ProductoCollectionViaDetPrepForm"
					_alreadyFetchedProductoCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetPrepForm.Add(CType(entity, ProductoEntity))
					End If
				Case "PlazaCollectionViaDetPrepForm"
					_alreadyFetchedPlazaCollectionViaDetPrepForm = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaDetPrepForm.Add(CType(entity, PlazaEntity))
					End If
				Case "DetPrepFormCollectionViaDetPrepFormLote"
					_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.DetPrepFormCollectionViaDetPrepFormLote.Add(CType(entity, DetPrepFormEntity))
					End If
				Case "ProductoCollectionViaDetPrepFormLote"
					_alreadyFetchedProductoCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetPrepFormLote.Add(CType(entity, ProductoEntity))
					End If
				Case "PlazaCollectionViaDetPrepFormLote"
					_alreadyFetchedPlazaCollectionViaDetPrepFormLote = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaDetPrepFormLote.Add(CType(entity, PlazaEntity))
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
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Envase"
					SetupSyncEnvase(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Plaza"
					SetupSyncPlaza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MovimientoAlmacenEntradaMezcla"
					SetupSyncMovimientoAlmacenEntradaMezcla(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MovimientoAlmacenCancelacionEntradaMezcla"
					SetupSyncMovimientoAlmacenCancelacionEntradaMezcla(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MovimientoAlmacenSalidaIngrediente"
					SetupSyncMovimientoAlmacenSalidaIngrediente(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MovimientoAlmacenCancelacionSalidaIngrediente"
					SetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepForm"
					_detPrepForm.Add(CType(relatedEntity, DetPrepFormEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					_detPrepFormLote.Add(CType(relatedEntity, DetPrepFormLoteEntity))
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
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Envase"
					DesetupSyncEnvase(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Plaza"
					DesetupSyncPlaza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MovimientoAlmacenEntradaMezcla"
					DesetupSyncMovimientoAlmacenEntradaMezcla(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MovimientoAlmacenCancelacionEntradaMezcla"
					DesetupSyncMovimientoAlmacenCancelacionEntradaMezcla(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MovimientoAlmacenSalidaIngrediente"
					DesetupSyncMovimientoAlmacenSalidaIngrediente(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MovimientoAlmacenCancelacionSalidaIngrediente"
					DesetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepForm"
					MyBase.PerformRelatedEntityRemoval(_detPrepForm, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetPrepFormLote"
					MyBase.PerformRelatedEntityRemoval(_detPrepFormLote, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If
			If Not _envase Is Nothing Then
				toReturn.Add(_envase)
			End If
			If Not _plaza Is Nothing Then
				toReturn.Add(_plaza)
			End If
			If Not _movimientoAlmacenEntradaMezcla Is Nothing Then
				toReturn.Add(_movimientoAlmacenEntradaMezcla)
			End If
			If Not _movimientoAlmacenCancelacionEntradaMezcla Is Nothing Then
				toReturn.Add(_movimientoAlmacenCancelacionEntradaMezcla)
			End If
			If Not _movimientoAlmacenSalidaIngrediente Is Nothing Then
				toReturn.Add(_movimientoAlmacenSalidaIngrediente)
			End If
			If Not _movimientoAlmacenCancelacionSalidaIngrediente Is Nothing Then
				toReturn.Add(_movimientoAlmacenCancelacionSalidaIngrediente)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detPrepForm)
			toReturn.Add(_detPrepFormLote)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folPrepForm As System.String, idPlaza As System.Int32) As Boolean
			Return FetchUsingPK(folPrepForm, idPlaza, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folPrepForm As System.String, idPlaza As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folPrepForm, idPlaza, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folPrepForm As System.String, idPlaza As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folPrepForm, idPlaza, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolPrepForm, Me.IdPlaza, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabPrepFormFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabPrepFormFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, _detPrepForm.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepForm(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepForm(forceFetch, _detPrepForm.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			If ( Not _alreadyFetchedDetPrepForm Or forceFetch Or _alwaysFetchDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepForm)
					End If
				End If
				_detPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepForm.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_detPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepForm = True
			End If
			Return _detPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepForm'. These settings will be taken into account
		''' when the property DetPrepForm is requested or GetMultiDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepForm.SortClauses=sortClauses
			_detPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormLoteEntity'</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, _detPrepFormLote.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormLoteEntity'</returns>
		Public Function GetMultiDetPrepFormLote(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Return GetMultiDetPrepFormLote(forceFetch, _detPrepFormLote.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			If ( Not _alreadyFetchedDetPrepFormLote Or forceFetch Or _alwaysFetchDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepFormLote)
					End If
				End If
				_detPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepFormLote.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_detPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepFormLote = True
			End If
			Return _detPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepFormLote'. These settings will be taken into account
		''' when the property DetPrepFormLote is requested or GetMultiDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepFormLote.SortClauses=sortClauses
			_detPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetPrepForm(forceFetch, _productoCollectionViaDetPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetPrepForm Or forceFetch Or _alwaysFetchProductoCollectionViaDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.ProductoEntityUsingCveProducto, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), ComparisonOperator.Equal, Me.FolPrepForm))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), ComparisonOperator.Equal, Me.IdPlaza))
				_productoCollectionViaDetPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetPrepForm.GetMulti(Filter, relations)
				_productoCollectionViaDetPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetPrepForm = True
			End If
			Return _productoCollectionViaDetPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetPrepForm'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetPrepForm is requested or GetMultiProductoCollectionViaDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetPrepForm.SortClauses=sortClauses
			_productoCollectionViaDetPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaDetPrepForm(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaDetPrepForm(forceFetch, _plazaCollectionViaDetPrepForm.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaDetPrepForm(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaDetPrepForm Or forceFetch Or _alwaysFetchPlazaCollectionViaDetPrepForm) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaDetPrepForm.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaDetPrepForm)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", "DetPrepForm_", JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, "DetPrepForm_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), ComparisonOperator.Equal, Me.FolPrepForm))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), ComparisonOperator.Equal, Me.IdPlaza))
				_plazaCollectionViaDetPrepForm.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaDetPrepForm.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaDetPrepForm.GetMulti(Filter, relations)
				_plazaCollectionViaDetPrepForm.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaDetPrepForm = True
			End If
			Return _plazaCollectionViaDetPrepForm
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaDetPrepForm'. These settings will be taken into account
		''' when the property PlazaCollectionViaDetPrepForm is requested or GetMultiPlazaCollectionViaDetPrepForm is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaDetPrepForm(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaDetPrepForm.SortClauses=sortClauses
			_plazaCollectionViaDetPrepForm.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetPrepFormEntity'</returns>
		Public Function GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Return GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch, _detPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetPrepFormCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			If ( Not _alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detPrepFormCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detPrepFormCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), ComparisonOperator.Equal, Me.FolPrepForm))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), ComparisonOperator.Equal, Me.IdPlaza))
				_detPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detPrepFormCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_detPrepFormCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_detPrepFormCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = True
			End If
			Return _detPrepFormCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetPrepFormCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property DetPrepFormCollectionViaDetPrepFormLote is requested or GetMultiDetPrepFormCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetPrepFormCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detPrepFormCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_detPrepFormCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetPrepFormLote(forceFetch, _productoCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchProductoCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.ProductoEntityUsingCveProducto, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), ComparisonOperator.Equal, Me.FolPrepForm))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), ComparisonOperator.Equal, Me.IdPlaza))
				_productoCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_productoCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetPrepFormLote = True
			End If
			Return _productoCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetPrepFormLote is requested or GetMultiProductoCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_productoCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch, _plazaCollectionViaDetPrepFormLote.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaDetPrepFormLote(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaDetPrepFormLote Or forceFetch Or _alwaysFetchPlazaCollectionViaDetPrepFormLote) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaDetPrepFormLote.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaDetPrepFormLote)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", "DetPrepFormLote_", JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.PlazaEntityUsingIdPlaza, "DetPrepFormLote_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.FolPrepForm), ComparisonOperator.Equal, Me.FolPrepForm))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabPrepFormFieldIndex.IdPlaza), ComparisonOperator.Equal, Me.IdPlaza))
				_plazaCollectionViaDetPrepFormLote.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaDetPrepFormLote.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaDetPrepFormLote.GetMulti(Filter, relations)
				_plazaCollectionViaDetPrepFormLote.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaDetPrepFormLote = True
			End If
			Return _plazaCollectionViaDetPrepFormLote
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaDetPrepFormLote'. These settings will be taken into account
		''' when the property PlazaCollectionViaDetPrepFormLote is requested or GetMultiPlazaCollectionViaDetPrepFormLote is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaDetPrepFormLote(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaDetPrepFormLote.SortClauses=sortClauses
			_plazaCollectionViaDetPrepFormLote.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveAlmacen)
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
	
		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto() As ProductoEntity
			Return GetSingleProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveFormula)
				End If
				If Not _productoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto = newEntity
					_alreadyFetchedProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto
		End Function
	
		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleEnvase() As ProductoEntity
			Return GetSingleEnvase(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleEnvase(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedEnvase Or forceFetch Or _alwaysFetchEnvase) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdEnvase.GetValueOrDefault())
				End If
				If Not _envaseReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Envase = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Envase = newEntity
					_alreadyFetchedEnvase = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _envase
		End Function
	
		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza() As PlazaEntity
			Return GetSinglePlaza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza(forceFetch As Boolean) As PlazaEntity
			If ( Not _alreadyFetchedPlaza Or forceFetch Or _alwaysFetchPlaza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PlazaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPlaza)
				End If
				If Not _plazaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Plaza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PlazaEntity)
					End If
					Me.Plaza = newEntity
					_alreadyFetchedPlaza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _plaza
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenEntradaMezcla() As InventarioMovimientoAlmacenEntity
			Return GetSingleMovimientoAlmacenEntradaMezcla(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenEntradaMezcla(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedMovimientoAlmacenEntradaMezcla Or forceFetch Or _alwaysFetchMovimientoAlmacenEntradaMezcla) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveAlmacen, Me.FolioMovimientoAlmacenEntradaFormula)
				End If
				If Not _movimientoAlmacenEntradaMezclaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MovimientoAlmacenEntradaMezcla = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.MovimientoAlmacenEntradaMezcla = newEntity
					_alreadyFetchedMovimientoAlmacenEntradaMezcla = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _movimientoAlmacenEntradaMezcla
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenCancelacionEntradaMezcla() As InventarioMovimientoAlmacenEntity
			Return GetSingleMovimientoAlmacenCancelacionEntradaMezcla(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenCancelacionEntradaMezcla(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla Or forceFetch Or _alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveAlmacen, Me.FolioMovimientoAlmacenCancelacionEntradaFormula)
				End If
				If Not _movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MovimientoAlmacenCancelacionEntradaMezcla = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.MovimientoAlmacenCancelacionEntradaMezcla = newEntity
					_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _movimientoAlmacenCancelacionEntradaMezcla
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenSalidaIngrediente() As InventarioMovimientoAlmacenEntity
			Return GetSingleMovimientoAlmacenSalidaIngrediente(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenSalidaIngrediente(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedMovimientoAlmacenSalidaIngrediente Or forceFetch Or _alwaysFetchMovimientoAlmacenSalidaIngrediente) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveAlmacen, Me.FolioMovimientoAlmacenSalidaIngredientes)
				End If
				If Not _movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MovimientoAlmacenSalidaIngrediente = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.MovimientoAlmacenSalidaIngrediente = newEntity
					_alreadyFetchedMovimientoAlmacenSalidaIngrediente = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _movimientoAlmacenSalidaIngrediente
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenCancelacionSalidaIngrediente() As InventarioMovimientoAlmacenEntity
			Return GetSingleMovimientoAlmacenCancelacionSalidaIngrediente(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMovimientoAlmacenCancelacionSalidaIngrediente(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente Or forceFetch Or _alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveAlmacen, Me.FolioMovimientoAlmacenCancelacionSalidaIngredientes)
				End If
				If Not _movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MovimientoAlmacenCancelacionSalidaIngrediente = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.MovimientoAlmacenCancelacionSalidaIngrediente = newEntity
					_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _movimientoAlmacenCancelacionSalidaIngrediente
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabPrepFormFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabPrepFormFieldIndex)

					Case CabPrepFormFieldIndex.IdPlaza
						DesetupSyncPlaza(True, False)
						_alreadyFetchedPlaza = False

					Case CabPrepFormFieldIndex.CveAlmacen
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
						DesetupSyncMovimientoAlmacenEntradaMezcla(True, False)
						_alreadyFetchedMovimientoAlmacenEntradaMezcla = False
						DesetupSyncMovimientoAlmacenCancelacionEntradaMezcla(True, False)
						_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = False
						DesetupSyncMovimientoAlmacenSalidaIngrediente(True, False)
						_alreadyFetchedMovimientoAlmacenSalidaIngrediente = False
						DesetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(True, False)
						_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = False
					Case CabPrepFormFieldIndex.CveFormula
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False










					Case CabPrepFormFieldIndex.FolioMovimientoAlmacenEntradaFormula
						DesetupSyncMovimientoAlmacenEntradaMezcla(True, False)
						_alreadyFetchedMovimientoAlmacenEntradaMezcla = False
					Case CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionEntradaFormula
						DesetupSyncMovimientoAlmacenCancelacionEntradaMezcla(True, False)
						_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = False
					Case CabPrepFormFieldIndex.IdEnvase
						DesetupSyncEnvase(True, False)
						_alreadyFetchedEnvase = False
					Case CabPrepFormFieldIndex.FolioMovimientoAlmacenSalidaIngredientes
						DesetupSyncMovimientoAlmacenSalidaIngrediente(True, False)
						_alreadyFetchedMovimientoAlmacenSalidaIngrediente = False
					Case CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionSalidaIngredientes
						DesetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(True, False)
						_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detPrepForm.ActiveContext = MyBase.ActiveContext
			_detPrepFormLote.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaDetPrepForm.ActiveContext = MyBase.ActiveContext
			_detPrepFormCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaDetPrepFormLote.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _envase Is Nothing Then
				_envase.ActiveContext = MyBase.ActiveContext
			End If
		If Not _plaza Is Nothing Then
				_plaza.ActiveContext = MyBase.ActiveContext
			End If
		If Not _movimientoAlmacenEntradaMezcla Is Nothing Then
				_movimientoAlmacenEntradaMezcla.ActiveContext = MyBase.ActiveContext
			End If
		If Not _movimientoAlmacenCancelacionEntradaMezcla Is Nothing Then
				_movimientoAlmacenCancelacionEntradaMezcla.ActiveContext = MyBase.ActiveContext
			End If
		If Not _movimientoAlmacenSalidaIngrediente Is Nothing Then
				_movimientoAlmacenSalidaIngrediente.ActiveContext = MyBase.ActiveContext
			End If
		If Not _movimientoAlmacenCancelacionSalidaIngrediente Is Nothing Then
				_movimientoAlmacenCancelacionSalidaIngrediente.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabPrepFormDAO = CType(CreateDAOInstance(), CabPrepFormDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabPrepFormDAO = CType(CreateDAOInstance(), CabPrepFormDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabPrepFormDAO = CType(CreateDAOInstance(), CabPrepFormDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabPrepFormEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabPrepFormEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="validator">The validator Object for this CabPrepFormEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folPrepForm As System.String, idPlaza As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folPrepForm, idPlaza, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detPrepForm = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_detPrepForm.SetContainingEntityInfo(Me, "CabPrepForm")
			_alwaysFetchDetPrepForm = False
			_alreadyFetchedDetPrepForm = False
			_detPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(New DetPrepFormLoteEntityFactory())
			_detPrepFormLote.SetContainingEntityInfo(Me, "CabPrepForm")
			_alwaysFetchDetPrepFormLote = False
			_alreadyFetchedDetPrepFormLote = False
			_productoCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetPrepForm = False
			_alreadyFetchedProductoCollectionViaDetPrepForm = False
			_plazaCollectionViaDetPrepForm = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaDetPrepForm = False
			_alreadyFetchedPlazaCollectionViaDetPrepForm = False
			_detPrepFormCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.DetPrepFormCollection(New DetPrepFormEntityFactory())
			_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = False
			_alreadyFetchedDetPrepFormCollectionViaDetPrepFormLote = False
			_productoCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetPrepFormLote = False
			_alreadyFetchedProductoCollectionViaDetPrepFormLote = False
			_plazaCollectionViaDetPrepFormLote = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaDetPrepFormLote = False
			_alreadyFetchedPlazaCollectionViaDetPrepFormLote = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_envase = Nothing
			_envaseReturnsNewIfNotFound = True
			_alwaysFetchEnvase = False
			_alreadyFetchedEnvase = False
			_plaza = Nothing
			_plazaReturnsNewIfNotFound = True
			_alwaysFetchPlaza = False
			_alreadyFetchedPlaza = False
			_movimientoAlmacenEntradaMezcla = Nothing
			_movimientoAlmacenEntradaMezclaReturnsNewIfNotFound = True
			_alwaysFetchMovimientoAlmacenEntradaMezcla = False
			_alreadyFetchedMovimientoAlmacenEntradaMezcla = False
			_movimientoAlmacenCancelacionEntradaMezcla = Nothing
			_movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound = True
			_alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla = False
			_alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla = False
			_movimientoAlmacenSalidaIngrediente = Nothing
			_movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound = True
			_alwaysFetchMovimientoAlmacenSalidaIngrediente = False
			_alreadyFetchedMovimientoAlmacenSalidaIngrediente = False
			_movimientoAlmacenCancelacionSalidaIngrediente = Nothing
			_movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound = True
			_alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente = False
			_alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolPrepForm", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPlaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecPrepForm", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveFormula", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantaPreparar", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantRealaPrep", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveMovAlm", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RefCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenEntradaFormula", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenCancelacionEntradaFormula", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEnvase", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenSalidaIngredientes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenCancelacionSalidaIngredientes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadEnvase", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Lote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaducidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, True, signalRelatedEntity, "CabPrepForm", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveAlmacen) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, True, _alreadyFetchedAlmacen, New String() {  } )
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
		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, True, signalRelatedEntity, "CabPrepForm", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveFormula) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, True, _alreadyFetchedProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _envase</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncEnvase(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _envase, AddressOf OnEnvasePropertyChanged, "Envase", CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, True, signalRelatedEntity, "CabPrepForm_", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.IdEnvase) } )
			_envase = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _envase</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncEnvase(relatedEntity As IEntity)
			DesetupSyncEnvase(True, True)
			_envase = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _envase, AddressOf OnEnvasePropertyChanged, "Envase", CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, True, _alreadyFetchedEnvase, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnEnvasePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _plaza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, True, signalRelatedEntity, "CabPrepForm", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.IdPlaza) } )
			_plaza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza(relatedEntity As IEntity)
			DesetupSyncPlaza(True, True)
			_plaza = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, True, _alreadyFetchedPlaza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPlazaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _movimientoAlmacenEntradaMezcla</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMovimientoAlmacenEntradaMezcla(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _movimientoAlmacenEntradaMezcla, AddressOf OnMovimientoAlmacenEntradaMezclaPropertyChanged, "MovimientoAlmacenEntradaMezcla", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, True, signalRelatedEntity, "CabPrepForm", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveAlmacen), CInt(CabPrepFormFieldIndex.FolioMovimientoAlmacenEntradaFormula) } )
			_movimientoAlmacenEntradaMezcla = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _movimientoAlmacenEntradaMezcla</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMovimientoAlmacenEntradaMezcla(relatedEntity As IEntity)
			DesetupSyncMovimientoAlmacenEntradaMezcla(True, True)
			_movimientoAlmacenEntradaMezcla = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _movimientoAlmacenEntradaMezcla, AddressOf OnMovimientoAlmacenEntradaMezclaPropertyChanged, "MovimientoAlmacenEntradaMezcla", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, True, _alreadyFetchedMovimientoAlmacenEntradaMezcla, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMovimientoAlmacenEntradaMezclaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _movimientoAlmacenCancelacionEntradaMezcla</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMovimientoAlmacenCancelacionEntradaMezcla(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _movimientoAlmacenCancelacionEntradaMezcla, AddressOf OnMovimientoAlmacenCancelacionEntradaMezclaPropertyChanged, "MovimientoAlmacenCancelacionEntradaMezcla", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, True, signalRelatedEntity, "CabPrepForm_", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveAlmacen), CInt(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionEntradaFormula) } )
			_movimientoAlmacenCancelacionEntradaMezcla = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _movimientoAlmacenCancelacionEntradaMezcla</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMovimientoAlmacenCancelacionEntradaMezcla(relatedEntity As IEntity)
			DesetupSyncMovimientoAlmacenCancelacionEntradaMezcla(True, True)
			_movimientoAlmacenCancelacionEntradaMezcla = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _movimientoAlmacenCancelacionEntradaMezcla, AddressOf OnMovimientoAlmacenCancelacionEntradaMezclaPropertyChanged, "MovimientoAlmacenCancelacionEntradaMezcla", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, True, _alreadyFetchedMovimientoAlmacenCancelacionEntradaMezcla, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMovimientoAlmacenCancelacionEntradaMezclaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _movimientoAlmacenSalidaIngrediente</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMovimientoAlmacenSalidaIngrediente(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _movimientoAlmacenSalidaIngrediente, AddressOf OnMovimientoAlmacenSalidaIngredientePropertyChanged, "MovimientoAlmacenSalidaIngrediente", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, True, signalRelatedEntity, "CabPrepForm__", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveAlmacen), CInt(CabPrepFormFieldIndex.FolioMovimientoAlmacenSalidaIngredientes) } )
			_movimientoAlmacenSalidaIngrediente = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _movimientoAlmacenSalidaIngrediente</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMovimientoAlmacenSalidaIngrediente(relatedEntity As IEntity)
			DesetupSyncMovimientoAlmacenSalidaIngrediente(True, True)
			_movimientoAlmacenSalidaIngrediente = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _movimientoAlmacenSalidaIngrediente, AddressOf OnMovimientoAlmacenSalidaIngredientePropertyChanged, "MovimientoAlmacenSalidaIngrediente", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, True, _alreadyFetchedMovimientoAlmacenSalidaIngrediente, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMovimientoAlmacenSalidaIngredientePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _movimientoAlmacenCancelacionSalidaIngrediente</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _movimientoAlmacenCancelacionSalidaIngrediente, AddressOf OnMovimientoAlmacenCancelacionSalidaIngredientePropertyChanged, "MovimientoAlmacenCancelacionSalidaIngrediente", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, True, signalRelatedEntity, "CabPrepForm___", resetFKFields, New Integer() { CInt(CabPrepFormFieldIndex.CveAlmacen), CInt(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionSalidaIngredientes) } )
			_movimientoAlmacenCancelacionSalidaIngrediente = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _movimientoAlmacenCancelacionSalidaIngrediente</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(relatedEntity As IEntity)
			DesetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(True, True)
			_movimientoAlmacenCancelacionSalidaIngrediente = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _movimientoAlmacenCancelacionSalidaIngrediente, AddressOf OnMovimientoAlmacenCancelacionSalidaIngredientePropertyChanged, "MovimientoAlmacenCancelacionSalidaIngrediente", CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, True, _alreadyFetchedMovimientoAlmacenCancelacionSalidaIngrediente, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMovimientoAlmacenCancelacionSalidaIngredientePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folPrepForm">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="idPlaza">PK value for CabPrepForm which data should be fetched into this CabPrepForm Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folPrepForm As System.String, idPlaza As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabPrepFormFieldIndex.FolPrepForm)).ForcedCurrentValueWrite(folPrepForm)
				MyBase.Fields(CInt(CabPrepFormFieldIndex.IdPlaza)).ForcedCurrentValueWrite(idPlaza)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabPrepFormDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabPrepFormEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabPrepFormRelations
			Get	
				Return New CabPrepFormRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepForm() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepFormLote' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormLote() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormLoteEntity, Integer), 0, Nothing, Nothing, Nothing, "DetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.ProductoEntityUsingCveProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaDetPrepForm() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaDetPrepForm", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetPrepForm' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetPrepFormCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.DetPrepFormEntityUsingFolPrepFormCveProductoIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetPrepFormCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.DetPrepFormEntity, Integer), 0, Nothing, Nothing, relations, "DetPrepFormCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.ProductoEntityUsingCveProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaDetPrepFormLote() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, "__CabPrepFormEntity__", String.Empty, JoinHint.None)
				relations.Add(DetPrepFormLoteEntity.Relations.PlazaEntityUsingIdPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CabPrepFormEntity.Relations.DetPrepFormLoteEntityUsingFolPrepFormIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaDetPrepFormLote", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					CabPrepFormEntity.Relations.AlmacenEntityUsingCveAlmacen, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabPrepFormEntity.Relations.ProductoEntityUsingCveFormula, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathEnvase() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabPrepFormEntity.Relations.ProductoEntityUsingIdEnvase, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Envase", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					CabPrepFormEntity.Relations.PlazaEntityUsingIdPlaza, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMovimientoAlmacenEntradaMezcla() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenEntradaFormula, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "MovimientoAlmacenEntradaMezcla", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMovimientoAlmacenCancelacionEntradaMezcla() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionEntradaFormula, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "MovimientoAlmacenCancelacionEntradaMezcla", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMovimientoAlmacenSalidaIngrediente() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "MovimientoAlmacenSalidaIngrediente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMovimientoAlmacenCancelacionSalidaIngrediente() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabPrepFormEntity.Relations.InventarioMovimientoAlmacenEntityUsingCveAlmacenFolioMovimientoAlmacenCancelacionSalidaIngredientes, _
					CType(Integralab.ORM.EntityType.CabPrepFormEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "MovimientoAlmacenCancelacionSalidaIngrediente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabPrepFormEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabPrepFormEntity.CustomProperties
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
				Return CabPrepFormEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolPrepForm property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Fol_PrepForm"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolPrepForm]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FolPrepForm, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FolPrepForm, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPlaza property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."IdPlaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdPlaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.IdPlaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.IdPlaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecPrepForm property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Fec_PrepForm"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecPrepForm]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FecPrepForm, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FecPrepForm, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveAlmacen property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Cve_Almacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CveAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CveAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveFormula property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Cve_Formula"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveFormula]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CveFormula, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CveFormula, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantaPreparar property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."CantaPreparar"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantaPreparar]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CantaPreparar, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CantaPreparar, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantRealaPrep property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."CantRealaPrep"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantRealaPrep]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CantRealaPrep, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CantRealaPrep, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveMovAlm property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Cve_MovAlm"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 2<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CveMovAlm]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CveMovAlm, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CveMovAlm, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumPoliza property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."NumPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.NumPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.NumPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecCancela property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Fec_Cancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecCancela]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FecCancela, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FecCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The RefCancela property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."RefCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [RefCancela]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.RefCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.RefCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenEntradaFormula property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."FolioMovimientoAlmacenEntradaFormula"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenEntradaFormula]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenEntradaFormula, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenEntradaFormula, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenCancelacionEntradaFormula property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."FolioMovimientoAlmacenCancelacionEntradaFormula"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenCancelacionEntradaFormula]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionEntradaFormula, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionEntradaFormula, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEnvase property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."IdEnvase"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdEnvase]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.IdEnvase, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.IdEnvase, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenSalidaIngredientes property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."FolioMovimientoAlmacenSalidaIngredientes"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenSalidaIngredientes]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenSalidaIngredientes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenSalidaIngredientes, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenCancelacionSalidaIngredientes property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."FolioMovimientoAlmacenCancelacionSalidaIngredientes"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenCancelacionSalidaIngredientes]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionSalidaIngredientes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FolioMovimientoAlmacenCancelacionSalidaIngredientes, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadEnvase property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."CantidadEnvase"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CantidadEnvase]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.CantidadEnvase, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.CantidadEnvase, Integer), value)
			End Set
		End Property
	
		''' <summary>The Lote property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."Lote"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Lote]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.Lote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.Lote, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaducidad property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."FechaCaducidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCaducidad]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.FechaCaducidad, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.FechaCaducidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity CabPrepForm<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabPrepForm"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabPrepFormFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabPrepFormFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepForm]() As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Get
				Return GetMultiDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepForm. When set to true, DetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepForm As Boolean
			Get
				Return _alwaysFetchDetPrepForm
			End Get
			Set
				_alwaysFetchDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormLoteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepFormLote]() As Integralab.ORM.CollectionClasses.DetPrepFormLoteCollection
			Get
				Return GetMultiDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepFormLote. When set to true, DetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchDetPrepFormLote
			End Get
			Set
				_alwaysFetchDetPrepFormLote = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetPrepForm]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetPrepForm. When set to true, ProductoCollectionViaDetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetPrepForm As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetPrepForm
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaDetPrepForm()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaDetPrepForm]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaDetPrepForm(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaDetPrepForm. When set to true, PlazaCollectionViaDetPrepForm is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaDetPrepForm is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaDetPrepForm(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaDetPrepForm As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaDetPrepForm
			End Get
			Set
				_alwaysFetchPlazaCollectionViaDetPrepForm = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetPrepFormEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetPrepFormCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetPrepFormCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.DetPrepFormCollection
			Get
				Return GetMultiDetPrepFormCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetPrepFormCollectionViaDetPrepFormLote. When set to true, DetPrepFormCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetPrepFormCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetPrepFormCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetPrepFormCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchDetPrepFormCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchDetPrepFormCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetPrepFormLote. When set to true, ProductoCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetPrepFormLote = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaDetPrepFormLote()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaDetPrepFormLote]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaDetPrepFormLote(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaDetPrepFormLote. When set to true, PlazaCollectionViaDetPrepFormLote is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaDetPrepFormLote is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaDetPrepFormLote(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaDetPrepFormLote As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaDetPrepFormLote
			End Get
			Set
				_alwaysFetchPlazaCollectionViaDetPrepFormLote = value
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
							_almacen.UnsetRelatedEntity(Me, "CabPrepForm")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm")
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
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto]() As ProductoEntity
			Get
				Return GetSingleProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto(value)
				Else
					If value Is Nothing Then
						If Not _producto Is Nothing Then
							_producto.UnsetRelatedEntity(Me, "CabPrepForm")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto is not found
		''' in the database. When set to true, Producto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProductoReturnsNewIfNotFound As Boolean
			Get
				Return _productoReturnsNewIfNotFound
			End Get
			Set
				_productoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEnvase()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Envase]() As ProductoEntity
			Get
				Return GetSingleEnvase(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncEnvase(value)
				Else
					If value Is Nothing Then
						If Not _envase Is Nothing Then
							_envase.UnsetRelatedEntity(Me, "CabPrepForm_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Envase. When set to true, Envase is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Envase is accessed. You can always execute
		''' a forced fetch by calling GetSingleEnvase(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchEnvase As Boolean
			Get
				Return _alwaysFetchEnvase
			End Get
			Set
				_alwaysFetchEnvase = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Envase is not found
		''' in the database. When set to true, Envase will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property EnvaseReturnsNewIfNotFound As Boolean
			Get
				Return _envaseReturnsNewIfNotFound
			End Get
			Set
				_envaseReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PlazaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePlaza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Plaza]() As PlazaEntity
			Get
				Return GetSinglePlaza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPlaza(value)
				Else
					If value Is Nothing Then
						If Not _plaza Is Nothing Then
							_plaza.UnsetRelatedEntity(Me, "CabPrepForm")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Plaza. When set to true, Plaza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Plaza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePlaza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlaza As Boolean
			Get
				Return _alwaysFetchPlaza
			End Get
			Set
				_alwaysFetchPlaza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Plaza is not found
		''' in the database. When set to true, Plaza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PlazaReturnsNewIfNotFound As Boolean
			Get
				Return _plazaReturnsNewIfNotFound
			End Get
			Set
				_plazaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMovimientoAlmacenEntradaMezcla()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MovimientoAlmacenEntradaMezcla]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleMovimientoAlmacenEntradaMezcla(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMovimientoAlmacenEntradaMezcla(value)
				Else
					If value Is Nothing Then
						If Not _movimientoAlmacenEntradaMezcla Is Nothing Then
							_movimientoAlmacenEntradaMezcla.UnsetRelatedEntity(Me, "CabPrepForm")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MovimientoAlmacenEntradaMezcla. When set to true, MovimientoAlmacenEntradaMezcla is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MovimientoAlmacenEntradaMezcla is accessed. You can always execute
		''' a forced fetch by calling GetSingleMovimientoAlmacenEntradaMezcla(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMovimientoAlmacenEntradaMezcla As Boolean
			Get
				Return _alwaysFetchMovimientoAlmacenEntradaMezcla
			End Get
			Set
				_alwaysFetchMovimientoAlmacenEntradaMezcla = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MovimientoAlmacenEntradaMezcla is not found
		''' in the database. When set to true, MovimientoAlmacenEntradaMezcla will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MovimientoAlmacenEntradaMezclaReturnsNewIfNotFound As Boolean
			Get
				Return _movimientoAlmacenEntradaMezclaReturnsNewIfNotFound
			End Get
			Set
				_movimientoAlmacenEntradaMezclaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMovimientoAlmacenCancelacionEntradaMezcla()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MovimientoAlmacenCancelacionEntradaMezcla]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleMovimientoAlmacenCancelacionEntradaMezcla(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMovimientoAlmacenCancelacionEntradaMezcla(value)
				Else
					If value Is Nothing Then
						If Not _movimientoAlmacenCancelacionEntradaMezcla Is Nothing Then
							_movimientoAlmacenCancelacionEntradaMezcla.UnsetRelatedEntity(Me, "CabPrepForm_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MovimientoAlmacenCancelacionEntradaMezcla. When set to true, MovimientoAlmacenCancelacionEntradaMezcla is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MovimientoAlmacenCancelacionEntradaMezcla is accessed. You can always execute
		''' a forced fetch by calling GetSingleMovimientoAlmacenCancelacionEntradaMezcla(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMovimientoAlmacenCancelacionEntradaMezcla As Boolean
			Get
				Return _alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla
			End Get
			Set
				_alwaysFetchMovimientoAlmacenCancelacionEntradaMezcla = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MovimientoAlmacenCancelacionEntradaMezcla is not found
		''' in the database. When set to true, MovimientoAlmacenCancelacionEntradaMezcla will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MovimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound As Boolean
			Get
				Return _movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound
			End Get
			Set
				_movimientoAlmacenCancelacionEntradaMezclaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMovimientoAlmacenSalidaIngrediente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MovimientoAlmacenSalidaIngrediente]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleMovimientoAlmacenSalidaIngrediente(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMovimientoAlmacenSalidaIngrediente(value)
				Else
					If value Is Nothing Then
						If Not _movimientoAlmacenSalidaIngrediente Is Nothing Then
							_movimientoAlmacenSalidaIngrediente.UnsetRelatedEntity(Me, "CabPrepForm__")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm__")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MovimientoAlmacenSalidaIngrediente. When set to true, MovimientoAlmacenSalidaIngrediente is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MovimientoAlmacenSalidaIngrediente is accessed. You can always execute
		''' a forced fetch by calling GetSingleMovimientoAlmacenSalidaIngrediente(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMovimientoAlmacenSalidaIngrediente As Boolean
			Get
				Return _alwaysFetchMovimientoAlmacenSalidaIngrediente
			End Get
			Set
				_alwaysFetchMovimientoAlmacenSalidaIngrediente = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MovimientoAlmacenSalidaIngrediente is not found
		''' in the database. When set to true, MovimientoAlmacenSalidaIngrediente will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MovimientoAlmacenSalidaIngredienteReturnsNewIfNotFound As Boolean
			Get
				Return _movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound
			End Get
			Set
				_movimientoAlmacenSalidaIngredienteReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMovimientoAlmacenCancelacionSalidaIngrediente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MovimientoAlmacenCancelacionSalidaIngrediente]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleMovimientoAlmacenCancelacionSalidaIngrediente(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMovimientoAlmacenCancelacionSalidaIngrediente(value)
				Else
					If value Is Nothing Then
						If Not _movimientoAlmacenCancelacionSalidaIngrediente Is Nothing Then
							_movimientoAlmacenCancelacionSalidaIngrediente.UnsetRelatedEntity(Me, "CabPrepForm___")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabPrepForm___")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MovimientoAlmacenCancelacionSalidaIngrediente. When set to true, MovimientoAlmacenCancelacionSalidaIngrediente is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MovimientoAlmacenCancelacionSalidaIngrediente is accessed. You can always execute
		''' a forced fetch by calling GetSingleMovimientoAlmacenCancelacionSalidaIngrediente(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente As Boolean
			Get
				Return _alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente
			End Get
			Set
				_alwaysFetchMovimientoAlmacenCancelacionSalidaIngrediente = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MovimientoAlmacenCancelacionSalidaIngrediente is not found
		''' in the database. When set to true, MovimientoAlmacenCancelacionSalidaIngrediente will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MovimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound As Boolean
			Get
				Return _movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound
			End Get
			Set
				_movimientoAlmacenCancelacionSalidaIngredienteReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CabPrepFormEntity)
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
