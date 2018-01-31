' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:24
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
	''' <summary>Entity class which represents the entity 'AplicMedi'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AplicMediEntity 
#Else
	<Serializable()> _
	Public Class AplicMediEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _aplicMediDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDet, _alreadyFetchedAplicMediDet As Boolean
		Private _aplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetDetCollection
		Private _alwaysFetchAplicMediDetDet, _alreadyFetchedAplicMediDetDet As Boolean
		Private _productoCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDet, _alreadyFetchedProductoCollectionViaAplicMediDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet As Boolean
		Private _aplicMediDetCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.AplicMediDetCollection
		Private _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet, _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet As Boolean
		Private _productoCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaAplicMediDetDet, _alreadyFetchedProductoCollectionViaAplicMediDetDet As Boolean
		Private _mcecatCorralesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
		Private _mcecatLotesCabCollectionViaAplicMediDetDet As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet, _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen, _inventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen_ As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen_, _alreadyFetchedInventarioMovimientoAlmacen_, _inventarioMovimientoAlmacen_ReturnsNewIfNotFound As Boolean


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
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		Public Sub New(folAplicMedi As System.String)

			InitClassFetch(folAplicMedi, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folAplicMedi As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folAplicMedi, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="validator">The custom validator Object for this AplicMediEntity</param>
		Public Sub New(folAplicMedi As System.String, validator As IValidator)

			InitClassFetch(folAplicMedi, validator, Nothing)
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
			_productoCollectionViaAplicMediDet = CType(info.GetValue("_productoCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDet")
			_alreadyFetchedProductoCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDet")
			_mcecatCorralesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet")
			_mcecatLotesCabCollectionViaAplicMediDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet")
			_aplicMediDetCollectionViaAplicMediDetDet = CType(info.GetValue("_aplicMediDetCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.AplicMediDetCollection)), Integralab.ORM.CollectionClasses.AplicMediDetCollection)
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet")
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet")
			_productoCollectionViaAplicMediDetDet = CType(info.GetValue("_productoCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchProductoCollectionViaAplicMediDetDet")
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedProductoCollectionViaAplicMediDetDet")
			_mcecatCorralesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet")
			_mcecatLotesCabCollectionViaAplicMediDetDet = CType(info.GetValue("_mcecatLotesCabCollectionViaAplicMediDetDet", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet")
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_inventarioMovimientoAlmacen = CType(info.GetValue("_inventarioMovimientoAlmacen", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _inventarioMovimientoAlmacen Is Nothing Then
				AddHandler _inventarioMovimientoAlmacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_inventarioMovimientoAlmacenReturnsNewIfNotFound = info.GetBoolean("_inventarioMovimientoAlmacenReturnsNewIfNotFound")
			_alwaysFetchInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen")
			_alreadyFetchedInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen")
			_inventarioMovimientoAlmacen_ = CType(info.GetValue("_inventarioMovimientoAlmacen_", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				AddHandler _inventarioMovimientoAlmacen_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = info.GetBoolean("_inventarioMovimientoAlmacen_ReturnsNewIfNotFound")
			_alwaysFetchInventarioMovimientoAlmacen_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen_")
			_alreadyFetchedInventarioMovimientoAlmacen_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAplicMediDet = (_aplicMediDet.Count > 0)
			_alreadyFetchedAplicMediDetDet = (_aplicMediDetDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDet = (_productoCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = (_mcecatCorralesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = (_mcecatLotesCabCollectionViaAplicMediDet.Count > 0)
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = (_aplicMediDetCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = (_productoCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = (_mcecatCorralesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = (_mcecatLotesCabCollectionViaAplicMediDetDet.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen = Not(_inventarioMovimientoAlmacen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen_ = Not(_inventarioMovimientoAlmacen_ Is Nothing)

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
			info.AddValue("_productoCollectionViaAplicMediDet", _productoCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDet", _alwaysFetchProductoCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDet", _alreadyFetchedProductoCollectionViaAplicMediDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDet", _mcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDet", _mcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet)
			info.AddValue("_aplicMediDetCollectionViaAplicMediDetDet", _aplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet", _alwaysFetchAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet", _alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet)
			info.AddValue("_productoCollectionViaAplicMediDetDet", _productoCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchProductoCollectionViaAplicMediDetDet", _alwaysFetchProductoCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedProductoCollectionViaAplicMediDetDet", _alreadyFetchedProductoCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatCorralesCabCollectionViaAplicMediDetDet", _mcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet)
			info.AddValue("_mcecatLotesCabCollectionViaAplicMediDetDet", _mcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet", _alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet", _alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_inventarioMovimientoAlmacen", _inventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacenReturnsNewIfNotFound", _inventarioMovimientoAlmacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen", _alwaysFetchInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen", _alreadyFetchedInventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacen_", _inventarioMovimientoAlmacen_)
			info.AddValue("_inventarioMovimientoAlmacen_ReturnsNewIfNotFound", _inventarioMovimientoAlmacen_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen_", _alwaysFetchInventarioMovimientoAlmacen_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen_", _alreadyFetchedInventarioMovimientoAlmacen_)

			
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
				Case "InventarioMovimientoAlmacen"
					_alreadyFetchedInventarioMovimientoAlmacen = True
					Me.InventarioMovimientoAlmacen = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "InventarioMovimientoAlmacen_"
					_alreadyFetchedInventarioMovimientoAlmacen_ = True
					Me.InventarioMovimientoAlmacen_ = CType(entity, InventarioMovimientoAlmacenEntity)
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
				Case "ProductoCollectionViaAplicMediDet"
					_alreadyFetchedProductoCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaAplicMediDet.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaAplicMediDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDet.Add(CType(entity, McecatLotesCabEntity))
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
				Case "McecatCorralesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaAplicMediDetDet"
					_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaAplicMediDetDet.Add(CType(entity, McecatLotesCabEntity))
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
				Case "InventarioMovimientoAlmacen"
					SetupSyncInventarioMovimientoAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					SetupSyncInventarioMovimientoAlmacen_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDet"
					_aplicMediDet.Add(CType(relatedEntity, AplicMediDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					_aplicMediDetDet.Add(CType(relatedEntity, AplicMediDetDetEntity))
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
				Case "InventarioMovimientoAlmacen"
					DesetupSyncInventarioMovimientoAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					DesetupSyncInventarioMovimientoAlmacen_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDetDet"
					MyBase.PerformRelatedEntityRemoval(_aplicMediDetDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _inventarioMovimientoAlmacen Is Nothing Then
				toReturn.Add(_inventarioMovimientoAlmacen)
			End If
			If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				toReturn.Add(_inventarioMovimientoAlmacen_)
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

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplicMedi As System.String) As Boolean
			Return FetchUsingPK(folAplicMedi, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplicMedi As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folAplicMedi, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplicMedi As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folAplicMedi, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolAplicMedi, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As AplicMediFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As AplicMediFieldIndex) As Boolean
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
				_aplicMediDet.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
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
				_aplicMediDetDet.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
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
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
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

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch, _mcecatCorralesCabCollectionViaAplicMediDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaAplicMediDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaAplicMediDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaAplicMediDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
				_mcecatCorralesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaAplicMediDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaAplicMediDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaAplicMediDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = True
			End If
			Return _mcecatCorralesCabCollectionViaAplicMediDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaAplicMediDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaAplicMediDet is requested or GetMultiMcecatCorralesCabCollectionViaAplicMediDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaAplicMediDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaAplicMediDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaAplicMediDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDet_", JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
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
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
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
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
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

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch, _mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaAplicMediDetDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaAplicMediDetDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaAplicMediDetDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaAplicMediDetDet.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaAplicMediDetDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = True
			End If
			Return _mcecatCorralesCabCollectionViaAplicMediDetDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaAplicMediDetDet'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaAplicMediDetDet is requested or GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaAplicMediDetDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaAplicMediDetDet.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaAplicMediDetDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", "AplicMediDetDet_", JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, "AplicMediDetDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(AplicMediFieldIndex.FolAplicMedi), ComparisonOperator.Equal, Me.FolAplicMedi))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen)
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
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen() As InventarioMovimientoAlmacenEntity
			Return GetSingleInventarioMovimientoAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen, Me.FolioMovimientoAlmacen)
				End If
				If Not _inventarioMovimientoAlmacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.InventarioMovimientoAlmacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.InventarioMovimientoAlmacen = newEntity
					_alreadyFetchedInventarioMovimientoAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _inventarioMovimientoAlmacen
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen_() As InventarioMovimientoAlmacenEntity
			Return GetSingleInventarioMovimientoAlmacen_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen_(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen, Me.FolioMovimientoAlmacenCancelacion)
				End If
				If Not _inventarioMovimientoAlmacen_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.InventarioMovimientoAlmacen_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.InventarioMovimientoAlmacen_ = newEntity
					_alreadyFetchedInventarioMovimientoAlmacen_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _inventarioMovimientoAlmacen_
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(AplicMediFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, AplicMediFieldIndex)

					Case AplicMediFieldIndex.IdAlmacen
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False


					Case AplicMediFieldIndex.FolioMovimientoAlmacen
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
					Case AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False









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
			_productoCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDet.ActiveContext = MyBase.ActiveContext
			_aplicMediDetCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaAplicMediDetDet.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _inventarioMovimientoAlmacen Is Nothing Then
				_inventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				_inventarioMovimientoAlmacen_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As AplicMediDAO = CType(CreateDAOInstance(), AplicMediDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As AplicMediDAO = CType(CreateDAOInstance(), AplicMediDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As AplicMediDAO = CType(CreateDAOInstance(), AplicMediDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this AplicMediEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AplicMediEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="validator">The validator Object for this AplicMediEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folAplicMedi As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folAplicMedi, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_aplicMediDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_aplicMediDet.SetContainingEntityInfo(Me, "AplicMedi")
			_alwaysFetchAplicMediDet = False
			_alreadyFetchedAplicMediDet = False
			_aplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(New AplicMediDetDetEntityFactory())
			_aplicMediDetDet.SetContainingEntityInfo(Me, "AplicMedi")
			_alwaysFetchAplicMediDetDet = False
			_alreadyFetchedAplicMediDetDet = False
			_productoCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDet = False
			_mcecatCorralesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDet = False
			_mcecatLotesCabCollectionViaAplicMediDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDet = False
			_aplicMediDetCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.AplicMediDetCollection(New AplicMediDetEntityFactory())
			_alwaysFetchAplicMediDetCollectionViaAplicMediDetDet = False
			_alreadyFetchedAplicMediDetCollectionViaAplicMediDetDet = False
			_productoCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaAplicMediDetDet = False
			_alreadyFetchedProductoCollectionViaAplicMediDetDet = False
			_mcecatCorralesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatCorralesCabCollectionViaAplicMediDetDet = False
			_mcecatLotesCabCollectionViaAplicMediDetDet = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaAplicMediDetDet = False
			_alreadyFetchedMcecatLotesCabCollectionViaAplicMediDetDet = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_inventarioMovimientoAlmacen = Nothing
			_inventarioMovimientoAlmacenReturnsNewIfNotFound = True
			_alwaysFetchInventarioMovimientoAlmacen = False
			_alreadyFetchedInventarioMovimientoAlmacen = False
			_inventarioMovimientoAlmacen_ = Nothing
			_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = True
			_alwaysFetchInventarioMovimientoAlmacen_ = False
			_alreadyFetchedInventarioMovimientoAlmacen_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolAplicMedi", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdusuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAplicacionMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen, True, signalRelatedEntity, "AplicMedi", resetFKFields, New Integer() { CInt(AplicMediFieldIndex.IdAlmacen) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen, True, _alreadyFetchedAlmacen, New String() {  } )
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
		''' <summary>Removes the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncInventarioMovimientoAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, True, signalRelatedEntity, "AplicMedi", resetFKFields, New Integer() { CInt(AplicMediFieldIndex.IdAlmacen), CInt(AplicMediFieldIndex.FolioMovimientoAlmacen) } )
			_inventarioMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen(True, True)
			_inventarioMovimientoAlmacen = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, True, _alreadyFetchedInventarioMovimientoAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnInventarioMovimientoAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncInventarioMovimientoAlmacen_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, True, signalRelatedEntity, "AplicMedi_", resetFKFields, New Integer() { CInt(AplicMediFieldIndex.IdAlmacen), CInt(AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion) } )
			_inventarioMovimientoAlmacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen_(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen_(True, True)
			_inventarioMovimientoAlmacen_ = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, True, _alreadyFetchedInventarioMovimientoAlmacen_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnInventarioMovimientoAlmacen_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folAplicMedi">PK value for AplicMedi which data should be fetched into this AplicMedi Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folAplicMedi As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(AplicMediFieldIndex.FolAplicMedi)).ForcedCurrentValueWrite(folAplicMedi)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAplicMediDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New AplicMediEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As AplicMediRelations
			Get	
				Return New AplicMediRelations() 
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
					AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDetDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetDetCollection(), _
					AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					AplicMediEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDetCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, relations, "AplicMediDetCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaAplicMediDetDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, "__AplicMediEntity__", String.Empty, JoinHint.None)
				relations.Add(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					AplicMediEntity.Relations.AplicMediDetDetEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaAplicMediDetDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					AplicMediEntity.Relations.AlmacenEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					AplicMediEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "AplicMediEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return AplicMediEntity.CustomProperties
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
				Return AplicMediEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolAplicMedi property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FolioAplicacionMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolAplicMedi]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FolAplicMedi, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FolAplicMedi, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacen property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."IdAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.IdAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.IdAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdusuarioCancelacion property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."IdusuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdusuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.IdusuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.IdusuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacen property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FolioMovimientoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FolioMovimientoAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FolioMovimientoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenCancelacion property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FolioMovimientoAlmacenCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FolioMovimientoAlmacenCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAplicacionMedicamento property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FechaAplicacionMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAplicacionMedicamento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FechaAplicacionMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FechaAplicacionMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalCabezas property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."TotalCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalCabezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.TotalCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.TotalCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalKilos property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."TotalKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.TotalKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.TotalKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumPoliza property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."NumPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.NumPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.NumPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity AplicMedi<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMedi"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediFieldIndex.Estatus, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaAplicMediDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaAplicMediDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaAplicMediDet. When set to true, McecatCorralesCabCollectionViaAplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaAplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaAplicMediDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDet = value
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
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaAplicMediDetDet]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaAplicMediDetDet. When set to true, McecatCorralesCabCollectionViaAplicMediDetDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaAplicMediDetDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaAplicMediDetDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaAplicMediDetDet = value
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
							_almacen.UnsetRelatedEntity(Me, "AplicMedi")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMedi")
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
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [InventarioMovimientoAlmacen]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleInventarioMovimientoAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncInventarioMovimientoAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _inventarioMovimientoAlmacen Is Nothing Then
							_inventarioMovimientoAlmacen.UnsetRelatedEntity(Me, "AplicMedi")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMedi")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen. When set to true, InventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property InventarioMovimientoAlmacen is not found
		''' in the database. When set to true, InventarioMovimientoAlmacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property InventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _inventarioMovimientoAlmacenReturnsNewIfNotFound
			End Get
			Set
				_inventarioMovimientoAlmacenReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleInventarioMovimientoAlmacen_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [InventarioMovimientoAlmacen_]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleInventarioMovimientoAlmacen_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncInventarioMovimientoAlmacen_(value)
				Else
					If value Is Nothing Then
						If Not _inventarioMovimientoAlmacen_ Is Nothing Then
							_inventarioMovimientoAlmacen_.UnsetRelatedEntity(Me, "AplicMedi_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMedi_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen_. When set to true, InventarioMovimientoAlmacen_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleInventarioMovimientoAlmacen_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property InventarioMovimientoAlmacen_ is not found
		''' in the database. When set to true, InventarioMovimientoAlmacen_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property InventarioMovimientoAlmacen_ReturnsNewIfNotFound As Boolean
			Get
				Return _inventarioMovimientoAlmacen_ReturnsNewIfNotFound
			End Get
			Set
				_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.AplicMediEntity)
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
