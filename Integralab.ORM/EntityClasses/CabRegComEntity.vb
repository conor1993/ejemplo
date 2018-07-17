' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:08
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
	''' <summary>Entity class which represents the entity 'CabRegCom'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabRegComEntity 
#Else
	<Serializable()> _
	Public Class CabRegComEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detRegCom As Integralab.ORM.CollectionClasses.DetRegComCollection
		Private _alwaysFetchDetRegCom, _alreadyFetchedDetRegCom As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaDetRegCom As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom As Boolean
		Private _cabMovGan As CabMovGanEntity
		Private _alwaysFetchCabMovGan, _alreadyFetchedCabMovGan, _cabMovGanReturnsNewIfNotFound As Boolean
		Private _cabMovGan_ As CabMovGanEntity
		Private _alwaysFetchCabMovGan_, _alreadyFetchedCabMovGan_, _cabMovGan_ReturnsNewIfNotFound As Boolean
		Private _catLugaresDeCompra As CatLugaresDeCompraEntity
		Private _alwaysFetchCatLugaresDeCompra, _alreadyFetchedCatLugaresDeCompra, _catLugaresDeCompraReturnsNewIfNotFound As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean
		Private _mcecatCorralesCab As McecatCorralesCabEntity
		Private _alwaysFetchMcecatCorralesCab, _alreadyFetchedMcecatCorralesCab, _mcecatCorralesCabReturnsNewIfNotFound As Boolean
		Private _mcgcatCompradoresdeGanado As McgcatCompradoresdeGanadoEntity
		Private _alwaysFetchMcgcatCompradoresdeGanado, _alreadyFetchedMcgcatCompradoresdeGanado, _mcgcatCompradoresdeGanadoReturnsNewIfNotFound As Boolean
		Private _cabGasTrans As CabGasTransEntity
		Private _alwaysFetchCabGasTrans, _alreadyFetchedCabGasTrans, _cabGasTransReturnsNewIfNotFound As Boolean

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
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		Public Sub New(folRecep As System.String)

			InitClassFetch(folRecep, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folRecep As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folRecep, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="validator">The custom validator Object for this CabRegComEntity</param>
		Public Sub New(folRecep As System.String, validator As IValidator)

			InitClassFetch(folRecep, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detRegCom = CType(info.GetValue("_detRegCom", GetType(Integralab.ORM.CollectionClasses.DetRegComCollection)), Integralab.ORM.CollectionClasses.DetRegComCollection)
			_alwaysFetchDetRegCom = info.GetBoolean("_alwaysFetchDetRegCom")
			_alreadyFetchedDetRegCom = info.GetBoolean("_alreadyFetchedDetRegCom")
			_mcgcatTiposdeGanadoCollectionViaDetRegCom = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaDetRegCom", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom")
			_cabMovGan = CType(info.GetValue("_cabMovGan", GetType(CabMovGanEntity)), CabMovGanEntity)
			If Not _cabMovGan Is Nothing Then
				AddHandler _cabMovGan.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabMovGanReturnsNewIfNotFound = info.GetBoolean("_cabMovGanReturnsNewIfNotFound")
			_alwaysFetchCabMovGan = info.GetBoolean("_alwaysFetchCabMovGan")
			_alreadyFetchedCabMovGan = info.GetBoolean("_alreadyFetchedCabMovGan")
			_cabMovGan_ = CType(info.GetValue("_cabMovGan_", GetType(CabMovGanEntity)), CabMovGanEntity)
			If Not _cabMovGan_ Is Nothing Then
				AddHandler _cabMovGan_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabMovGan_ReturnsNewIfNotFound = info.GetBoolean("_cabMovGan_ReturnsNewIfNotFound")
			_alwaysFetchCabMovGan_ = info.GetBoolean("_alwaysFetchCabMovGan_")
			_alreadyFetchedCabMovGan_ = info.GetBoolean("_alreadyFetchedCabMovGan_")
			_catLugaresDeCompra = CType(info.GetValue("_catLugaresDeCompra", GetType(CatLugaresDeCompraEntity)), CatLugaresDeCompraEntity)
			If Not _catLugaresDeCompra Is Nothing Then
				AddHandler _catLugaresDeCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catLugaresDeCompraReturnsNewIfNotFound = info.GetBoolean("_catLugaresDeCompraReturnsNewIfNotFound")
			_alwaysFetchCatLugaresDeCompra = info.GetBoolean("_alwaysFetchCatLugaresDeCompra")
			_alreadyFetchedCatLugaresDeCompra = info.GetBoolean("_alreadyFetchedCatLugaresDeCompra")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_mcecatCorralesCab = CType(info.GetValue("_mcecatCorralesCab", GetType(McecatCorralesCabEntity)), McecatCorralesCabEntity)
			If Not _mcecatCorralesCab Is Nothing Then
				AddHandler _mcecatCorralesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatCorralesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatCorralesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatCorralesCab = info.GetBoolean("_alwaysFetchMcecatCorralesCab")
			_alreadyFetchedMcecatCorralesCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCab")
			_mcgcatCompradoresdeGanado = CType(info.GetValue("_mcgcatCompradoresdeGanado", GetType(McgcatCompradoresdeGanadoEntity)), McgcatCompradoresdeGanadoEntity)
			If Not _mcgcatCompradoresdeGanado Is Nothing Then
				AddHandler _mcgcatCompradoresdeGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatCompradoresdeGanadoReturnsNewIfNotFound = info.GetBoolean("_mcgcatCompradoresdeGanadoReturnsNewIfNotFound")
			_alwaysFetchMcgcatCompradoresdeGanado = info.GetBoolean("_alwaysFetchMcgcatCompradoresdeGanado")
			_alreadyFetchedMcgcatCompradoresdeGanado = info.GetBoolean("_alreadyFetchedMcgcatCompradoresdeGanado")
			_cabGasTrans = CType(info.GetValue("_cabGasTrans", GetType(CabGasTransEntity)), CabGasTransEntity)
			If Not _cabGasTrans Is Nothing Then
				' rewire event handler.
				AddHandler _cabGasTrans.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabGasTransReturnsNewIfNotFound = info.GetBoolean("_cabGasTransReturnsNewIfNotFound")
			_alwaysFetchCabGasTrans = info.GetBoolean("_alwaysFetchCabGasTrans")
			_alreadyFetchedCabGasTrans = info.GetBoolean("_alreadyFetchedCabGasTrans")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetRegCom = (_detRegCom.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom = (_mcgcatTiposdeGanadoCollectionViaDetRegCom.Count > 0)
			_alreadyFetchedCabMovGan = Not(_cabMovGan Is Nothing)
			_alreadyFetchedCabMovGan_ = Not(_cabMovGan_ Is Nothing)
			_alreadyFetchedCatLugaresDeCompra = Not(_catLugaresDeCompra Is Nothing)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)
			_alreadyFetchedMcecatCorralesCab = Not(_mcecatCorralesCab Is Nothing)
			_alreadyFetchedMcgcatCompradoresdeGanado = Not(_mcgcatCompradoresdeGanado Is Nothing)
			_alreadyFetchedCabGasTrans = Not(_cabGasTrans Is Nothing)
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
			info.AddValue("_detRegCom", _detRegCom)
			info.AddValue("_alwaysFetchDetRegCom", _alwaysFetchDetRegCom)
			info.AddValue("_alreadyFetchedDetRegCom", _alreadyFetchedDetRegCom)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaDetRegCom", _mcgcatTiposdeGanadoCollectionViaDetRegCom)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom", _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom)
			info.AddValue("_cabMovGan", _cabMovGan)
			info.AddValue("_cabMovGanReturnsNewIfNotFound", _cabMovGanReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabMovGan", _alwaysFetchCabMovGan)
			info.AddValue("_alreadyFetchedCabMovGan", _alreadyFetchedCabMovGan)
			info.AddValue("_cabMovGan_", _cabMovGan_)
			info.AddValue("_cabMovGan_ReturnsNewIfNotFound", _cabMovGan_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabMovGan_", _alwaysFetchCabMovGan_)
			info.AddValue("_alreadyFetchedCabMovGan_", _alreadyFetchedCabMovGan_)
			info.AddValue("_catLugaresDeCompra", _catLugaresDeCompra)
			info.AddValue("_catLugaresDeCompraReturnsNewIfNotFound", _catLugaresDeCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatLugaresDeCompra", _alwaysFetchCatLugaresDeCompra)
			info.AddValue("_alreadyFetchedCatLugaresDeCompra", _alreadyFetchedCatLugaresDeCompra)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_mcecatCorralesCab", _mcecatCorralesCab)
			info.AddValue("_mcecatCorralesCabReturnsNewIfNotFound", _mcecatCorralesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatCorralesCab", _alwaysFetchMcecatCorralesCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCab", _alreadyFetchedMcecatCorralesCab)
			info.AddValue("_mcgcatCompradoresdeGanado", _mcgcatCompradoresdeGanado)
			info.AddValue("_mcgcatCompradoresdeGanadoReturnsNewIfNotFound", _mcgcatCompradoresdeGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatCompradoresdeGanado", _alwaysFetchMcgcatCompradoresdeGanado)
			info.AddValue("_alreadyFetchedMcgcatCompradoresdeGanado", _alreadyFetchedMcgcatCompradoresdeGanado)
			info.AddValue("_cabGasTrans", _cabGasTrans)
			info.AddValue("_cabGasTransReturnsNewIfNotFound", _cabGasTransReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabGasTrans", _alwaysFetchCabGasTrans)
			info.AddValue("_alreadyFetchedCabGasTrans", _alreadyFetchedCabGasTrans)
			
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
				Case "CabMovGan_"
					_alreadyFetchedCabMovGan_ = True
					Me.CabMovGan_ = CType(entity, CabMovGanEntity)
				Case "CatLugaresDeCompra"
					_alreadyFetchedCatLugaresDeCompra = True
					Me.CatLugaresDeCompra = CType(entity, CatLugaresDeCompraEntity)
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)
				Case "McecatCorralesCab"
					_alreadyFetchedMcecatCorralesCab = True
					Me.McecatCorralesCab = CType(entity, McecatCorralesCabEntity)
				Case "McgcatCompradoresdeGanado"
					_alreadyFetchedMcgcatCompradoresdeGanado = True
					Me.McgcatCompradoresdeGanado = CType(entity, McgcatCompradoresdeGanadoEntity)
				Case "DetRegCom"
					_alreadyFetchedDetRegCom = True
					If Not entity Is Nothing Then
						Me.DetRegCom.Add(CType(entity, DetRegComEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaDetRegCom"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaDetRegCom.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "CabGasTrans"
					_alreadyFetchedCabGasTrans = True
					Me.CabGasTrans = CType(entity, CabGasTransEntity)
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
				Case "CabMovGan_"
					SetupSyncCabMovGan_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CatLugaresDeCompra"
					SetupSyncCatLugaresDeCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					SetupSyncMcecatCorralesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcatCompradoresdeGanado"
					SetupSyncMcgcatCompradoresdeGanado(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetRegCom"
					_detRegCom.Add(CType(relatedEntity, DetRegComEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabGasTrans"
					SetupSyncCabGasTrans(relatedEntity)
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
				Case "CabMovGan_"
					DesetupSyncCabMovGan_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CatLugaresDeCompra"
					DesetupSyncCatLugaresDeCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					DesetupSyncMcecatCorralesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcatCompradoresdeGanado"
					DesetupSyncMcgcatCompradoresdeGanado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetRegCom"
					MyBase.PerformRelatedEntityRemoval(_detRegCom, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabGasTrans"
					DesetupSyncCabGasTrans(False, True)
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
			If Not _cabMovGan_ Is Nothing Then
				toReturn.Add(_cabMovGan_)
			End If
			If Not _catLugaresDeCompra Is Nothing Then
				toReturn.Add(_catLugaresDeCompra)
			End If
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
			End If
			If Not _mcecatCorralesCab Is Nothing Then
				toReturn.Add(_mcecatCorralesCab)
			End If
			If Not _mcgcatCompradoresdeGanado Is Nothing Then
				toReturn.Add(_mcgcatCompradoresdeGanado)
			End If

			If Not _cabGasTrans Is Nothing Then
				toReturn.Add(_cabGasTrans)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detRegCom)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String) As Boolean
			Return FetchUsingPK(folRecep, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folRecep, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folRecep, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolRecep, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabRegComFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabRegComFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_detRegCom.GetMultiManyToOne(Me, Nothing, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom(forceFetch, _mcgcatTiposdeGanadoCollectionViaDetRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaDetRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaDetRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, "__CabRegComEntity__", "DetRegCom_", JoinHint.None)
				relations.Add(DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, "DetRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabRegComFieldIndex.FolRecep), ComparisonOperator.Equal, Me.FolRecep))
				_mcgcatTiposdeGanadoCollectionViaDetRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaDetRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaDetRegCom.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaDetRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaDetRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaDetRegCom'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaDetRegCom is requested or GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaDetRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaDetRegCom.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaDetRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado) Then
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
	
		''' <summary>Retrieves the related entity of type 'CabMovGanEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CabMovGanEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMovGan_() As CabMovGanEntity
			Return GetSingleCabMovGan_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabMovGanEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabMovGanEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabMovGan_(forceFetch As Boolean) As CabMovGanEntity
			If ( Not _alreadyFetchedCabMovGan_ Or forceFetch Or _alwaysFetchCabMovGan_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CabMovGanEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioMovimientoGanadoCancelacion)
				End If
				If Not _cabMovGan_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CabMovGan_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabMovGanEntity)
					End If
					Me.CabMovGan_ = newEntity
					_alreadyFetchedCabMovGan_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabMovGan_
		End Function
	
		''' <summary>Retrieves the related entity of type 'CatLugaresDeCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatLugaresDeCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatLugaresDeCompra() As CatLugaresDeCompraEntity
			Return GetSingleCatLugaresDeCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatLugaresDeCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatLugaresDeCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatLugaresDeCompra(forceFetch As Boolean) As CatLugaresDeCompraEntity
			If ( Not _alreadyFetchedCatLugaresDeCompra Or forceFetch Or _alwaysFetchCatLugaresDeCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatLugaresDeCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveLugCom)
				End If
				If Not _catLugaresDeCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatLugaresDeCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatLugaresDeCompraEntity)
					End If
					Me.CatLugaresDeCompra = newEntity
					_alreadyFetchedCatLugaresDeCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catLugaresDeCompra
		End Function
	
		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor() As ProveedorEntity
			Return GetSingleProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor(forceFetch As Boolean) As ProveedorEntity
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveProveGan)
				End If
				If Not _proveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Proveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorEntity)
					End If
					Me.Proveedor = newEntity
					_alreadyFetchedProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedor
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveCorral)
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
	
		''' <summary>Retrieves the related entity of type 'McgcatCompradoresdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McgcatCompradoresdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatCompradoresdeGanado() As McgcatCompradoresdeGanadoEntity
			Return GetSingleMcgcatCompradoresdeGanado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McgcatCompradoresdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McgcatCompradoresdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatCompradoresdeGanado(forceFetch As Boolean) As McgcatCompradoresdeGanadoEntity
			If ( Not _alreadyFetchedMcgcatCompradoresdeGanado Or forceFetch Or _alwaysFetchMcgcatCompradoresdeGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McgcatCompradoresdeGanadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveComiGan)
				End If
				If Not _mcgcatCompradoresdeGanadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McgcatCompradoresdeGanado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McgcatCompradoresdeGanadoEntity)
					End If
					Me.McgcatCompradoresdeGanado = newEntity
					_alreadyFetchedMcgcatCompradoresdeGanado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcgcatCompradoresdeGanado
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'CabGasTransEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'CabGasTransEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabGasTrans() As CabGasTransEntity
			Return GetSingleCabGasTrans(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabGasTransEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabGasTransEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabGasTrans(forceFetch As Boolean) As CabGasTransEntity
			If ( Not _alreadyFetchedCabGasTrans Or forceFetch Or _alwaysFetchCabGasTrans) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New CabGasTransEntity()
				Dim relation As IEntityRelation = CabRegComEntity.Relations.CabGasTransEntityUsingFolRecep
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolRecep)
				End If
				If Not _cabGasTransReturnsNewIfNotFound And Not fetchResult Then
					Me.CabGasTrans = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabGasTransEntity)
					End If
					Me.CabGasTrans = newEntity
					_alreadyFetchedCabGasTrans = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabGasTrans
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabRegComFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabRegComFieldIndex)
					Case CabRegComFieldIndex.FolRecep
						DesetupSyncCabGasTrans(True, False)
						_alreadyFetchedCabGasTrans = False

					Case CabRegComFieldIndex.CveProveGan
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False
					Case CabRegComFieldIndex.CveLugCom
						DesetupSyncCatLugaresDeCompra(True, False)
						_alreadyFetchedCatLugaresDeCompra = False
					Case CabRegComFieldIndex.CveComiGan
						DesetupSyncMcgcatCompradoresdeGanado(True, False)
						_alreadyFetchedMcgcatCompradoresdeGanado = False













					Case CabRegComFieldIndex.CveCorral
						DesetupSyncMcecatCorralesCab(True, False)
						_alreadyFetchedMcecatCorralesCab = False














					Case CabRegComFieldIndex.FolioMovimientoGanado
						DesetupSyncCabMovGan(True, False)
						_alreadyFetchedCabMovGan = False
					Case CabRegComFieldIndex.FolioMovimientoGanadoCancelacion
						DesetupSyncCabMovGan_(True, False)
						_alreadyFetchedCabMovGan_ = False




					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detRegCom.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaDetRegCom.ActiveContext = MyBase.ActiveContext
		If Not _cabMovGan Is Nothing Then
				_cabMovGan.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cabMovGan_ Is Nothing Then
				_cabMovGan_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _catLugaresDeCompra Is Nothing Then
				_catLugaresDeCompra.ActiveContext = MyBase.ActiveContext
			End If
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatCorralesCab Is Nothing Then
				_mcecatCorralesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcgcatCompradoresdeGanado Is Nothing Then
				_mcgcatCompradoresdeGanado.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cabGasTrans Is Nothing Then
				_cabGasTrans.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabRegComDAO = CType(CreateDAOInstance(), CabRegComDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabRegComDAO = CType(CreateDAOInstance(), CabRegComDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabRegComDAO = CType(CreateDAOInstance(), CabRegComDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabRegComEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabRegComEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="validator">The validator Object for this CabRegComEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folRecep As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folRecep, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detRegCom = New Integralab.ORM.CollectionClasses.DetRegComCollection(New DetRegComEntityFactory())
			_detRegCom.SetContainingEntityInfo(Me, "CabRegCom")
			_alwaysFetchDetRegCom = False
			_alreadyFetchedDetRegCom = False
			_mcgcatTiposdeGanadoCollectionViaDetRegCom = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetRegCom = False
			_cabMovGan = Nothing
			_cabMovGanReturnsNewIfNotFound = True
			_alwaysFetchCabMovGan = False
			_alreadyFetchedCabMovGan = False
			_cabMovGan_ = Nothing
			_cabMovGan_ReturnsNewIfNotFound = True
			_alwaysFetchCabMovGan_ = False
			_alreadyFetchedCabMovGan_ = False
			_catLugaresDeCompra = Nothing
			_catLugaresDeCompraReturnsNewIfNotFound = True
			_alwaysFetchCatLugaresDeCompra = False
			_alreadyFetchedCatLugaresDeCompra = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_mcecatCorralesCab = Nothing
			_mcecatCorralesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatCorralesCab = False
			_alreadyFetchedMcecatCorralesCab = False
			_mcgcatCompradoresdeGanado = Nothing
			_mcgcatCompradoresdeGanadoReturnsNewIfNotFound = True
			_alwaysFetchMcgcatCompradoresdeGanado = False
			_alreadyFetchedMcgcatCompradoresdeGanado = False
			_cabGasTrans = Nothing
			_cabGasTransReturnsNewIfNotFound = True
			_alwaysFetchCabGasTrans = False
			_alreadyFetchedCabGasTrans = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolRecep", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecRecep", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveProveGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveLugCom", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveComiGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumGuias", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteXguia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasViaje", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImptePredial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooPredial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteEduc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooEduc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PesoEntReal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CabezasComp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosComp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteComp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("StaCerrado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomBanco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomSucursal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumCuenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComiXcab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Status", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostosIndi", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioRecepcionPesada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoGanadoCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoComision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cabMovGan</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabMovGan(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabMovGan, AddressOf OnCabMovGanPropertyChanged, "CabMovGan", CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, True, signalRelatedEntity, "CabRegCom", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.FolioMovimientoGanado) } )
			_cabMovGan = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cabMovGan</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabMovGan(relatedEntity As IEntity)
			DesetupSyncCabMovGan(True, True)
			_cabMovGan = CType(relatedEntity, CabMovGanEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabMovGan, AddressOf OnCabMovGanPropertyChanged, "CabMovGan", CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, True, _alreadyFetchedCabMovGan, New String() {  } )
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
		''' <summary>Removes the sync logic for member _cabMovGan_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabMovGan_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabMovGan_, AddressOf OnCabMovGan_PropertyChanged, "CabMovGan_", CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, True, signalRelatedEntity, "CabRegCom_", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion) } )
			_cabMovGan_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cabMovGan_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabMovGan_(relatedEntity As IEntity)
			DesetupSyncCabMovGan_(True, True)
			_cabMovGan_ = CType(relatedEntity, CabMovGanEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabMovGan_, AddressOf OnCabMovGan_PropertyChanged, "CabMovGan_", CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, True, _alreadyFetchedCabMovGan_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabMovGan_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _catLugaresDeCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatLugaresDeCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catLugaresDeCompra, AddressOf OnCatLugaresDeCompraPropertyChanged, "CatLugaresDeCompra", CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, True, signalRelatedEntity, "CabRegCom", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.CveLugCom) } )
			_catLugaresDeCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catLugaresDeCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatLugaresDeCompra(relatedEntity As IEntity)
			DesetupSyncCatLugaresDeCompra(True, True)
			_catLugaresDeCompra = CType(relatedEntity, CatLugaresDeCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catLugaresDeCompra, AddressOf OnCatLugaresDeCompraPropertyChanged, "CatLugaresDeCompra", CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, True, _alreadyFetchedCatLugaresDeCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatLugaresDeCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, True, signalRelatedEntity, "CabRegCom", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.CveProveGan) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, True, _alreadyFetchedProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatCorralesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, True, signalRelatedEntity, "CabRegCom", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.CveCorral) } )
			_mcecatCorralesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatCorralesCab(relatedEntity As IEntity)
			DesetupSyncMcecatCorralesCab(True, True)
			_mcecatCorralesCab = CType(relatedEntity, McecatCorralesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, True, _alreadyFetchedMcecatCorralesCab, New String() {  } )
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
		''' <summary>Removes the sync logic for member _mcgcatCompradoresdeGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatCompradoresdeGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatCompradoresdeGanado, AddressOf OnMcgcatCompradoresdeGanadoPropertyChanged, "McgcatCompradoresdeGanado", CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, True, signalRelatedEntity, "CabRegCom", resetFKFields, New Integer() { CInt(CabRegComFieldIndex.CveComiGan) } )
			_mcgcatCompradoresdeGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatCompradoresdeGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatCompradoresdeGanado(relatedEntity As IEntity)
			DesetupSyncMcgcatCompradoresdeGanado(True, True)
			_mcgcatCompradoresdeGanado = CType(relatedEntity, McgcatCompradoresdeGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatCompradoresdeGanado, AddressOf OnMcgcatCompradoresdeGanadoPropertyChanged, "McgcatCompradoresdeGanado", CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, True, _alreadyFetchedMcgcatCompradoresdeGanado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcgcatCompradoresdeGanadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _cabGasTrans</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabGasTrans(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabGasTrans, AddressOf OnCabGasTransPropertyChanged, "CabGasTrans", CabRegComEntity.Relations.CabGasTransEntityUsingFolRecep, True, signalRelatedEntity, "CabRegCom", False, New Integer() { CInt(CabRegComFieldIndex.FolRecep) } )
			_cabGasTrans = Nothing
		End Sub

		''' <summary>setups the sync logic for member _cabGasTrans</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabGasTrans(relatedEntity As IEntity)
			DesetupSyncCabGasTrans(True, True)
			_cabGasTrans = CType(relatedEntity, CabGasTransEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabGasTrans, AddressOf OnCabGasTransPropertyChanged, "CabGasTrans", CabRegComEntity.Relations.CabGasTransEntityUsingFolRecep, True, _alreadyFetchedCabGasTrans, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabGasTransPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folRecep">PK value for CabRegCom which data should be fetched into this CabRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folRecep As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabRegComFieldIndex.FolRecep)).ForcedCurrentValueWrite(folRecep)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabRegComDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabRegComEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabRegComRelations
			Get	
				Return New CabRegComRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetRegComCollection(), _
					CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.DetRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "DetRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaDetRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, "__CabRegComEntity__", String.Empty, JoinHint.None)
				relations.Add(DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					CabRegComEntity.Relations.DetRegComEntityUsingFolRecep, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaDetRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGan() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, Nothing, "CabMovGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGan_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, Nothing, "CabMovGan_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CatLugaresDeCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatCompradoresdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatCompradoresdeGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatCompradoresdeGanadoCollection(), _
					CabRegComEntity.Relations.McgcatCompradoresdeGanadoEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatCompradoresdeGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabGasTrans' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabGasTrans() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabGasTransCollection(), _
					CabRegComEntity.Relations.CabGasTransEntityUsingFolRecep, _
					CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), CType(Integralab.ORM.EntityType.CabGasTransEntity, Integer), 0, Nothing, Nothing, Nothing, "CabGasTrans", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabRegComEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabRegComEntity.CustomProperties
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
				Return CabRegComEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolRecep property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Fol_Recep"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolRecep]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FolRecep, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FolRecep, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecRecep property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Fec_Recep"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecRecep]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FecRecep, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FecRecep, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveProveGan property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Cve_ProveGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveProveGan]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CveProveGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CveProveGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveLugCom property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Cve_LugCom"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveLugCom]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CveLugCom, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CveLugCom, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveComiGan property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Cve_ComiGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveComiGan]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CveComiGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CveComiGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumGuias property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."NumGuias"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumGuias]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NumGuias, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NumGuias, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteXguia property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."ImpteXGuia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteXguia]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.ImpteXguia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.ImpteXguia, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasViaje property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."HorasViaje"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasViaje]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.HorasViaje, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.HorasViaje, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImptePredial property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."ImptePredial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImptePredial]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.ImptePredial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.ImptePredial, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooPredial property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Boo_Predial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooPredial]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.BooPredial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.BooPredial, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteEduc property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."ImpteEduc"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteEduc]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.ImpteEduc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.ImpteEduc, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooEduc property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Boo_Educ"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooEduc]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.BooEduc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.BooEduc, Integer), value)
			End Set
		End Property
	
		''' <summary>The PesoEntReal property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."PesoEntReal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PesoEntReal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.PesoEntReal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.PesoEntReal, Integer), value)
			End Set
		End Property
	
		''' <summary>The CabezasComp property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."CabezasComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CabezasComp]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CabezasComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CabezasComp, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosComp property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."KilosComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosComp]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.KilosComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.KilosComp, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteComp property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."ImpteComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteComp]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.ImpteComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.ImpteComp, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The StaCerrado property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Sta_Cerrado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [StaCerrado]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.StaCerrado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.StaCerrado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveCorral property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Cve_Corral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CveCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CveCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."DiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecPago property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Fec_Pago"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecPago]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FecPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FecPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumFactura property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Num_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NumFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NumFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomBanco property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Nom_Banco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NomBanco]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NomBanco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NomBanco, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomSucursal property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Nom_Sucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NomSucursal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NomSucursal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NomSucursal, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumCuenta property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Num_Cuenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumCuenta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NumCuenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NumCuenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumPoliza property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."NumPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.NumPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.NumPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComiXcab property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."ComiXCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ComiXcab]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.ComiXcab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.ComiXcab, Integer), value)
			End Set
		End Property
	
		''' <summary>The Status property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Status"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Status]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.Status, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.Status, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostosIndi property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."CostosIndi"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostosIndi]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.CostosIndi, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.CostosIndi, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolFactura property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."Fol_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FolFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FolFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioRecepcionPesada property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."FolioRecepcionPesada"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioRecepcionPesada]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FolioRecepcionPesada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FolioRecepcionPesada, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoGanado property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."FolioMovimientoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoGanado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FolioMovimientoGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FolioMovimientoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoGanadoCancelacion property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."FolioMovimientoGanadoCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoGanadoCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FolioMovimientoGanadoCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoComision property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."TipoComision"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoComision]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.TipoComision, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.TipoComision, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity CabRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabRegCom"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabRegComFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabRegComFieldIndex.IdUsuarioAlta, Integer), value)
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
	
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaDetRegCom]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaDetRegCom. When set to true, McgcatTiposdeGanadoCollectionViaDetRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaDetRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaDetRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetRegCom = value
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
							_cabMovGan.UnsetRelatedEntity(Me, "CabRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom")
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
	
		''' <summary>Gets / sets related entity of type 'CabMovGanEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabMovGan_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabMovGan_]() As CabMovGanEntity
			Get
				Return GetSingleCabMovGan_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabMovGan_(value)
				Else
					If value Is Nothing Then
						If Not _cabMovGan_ Is Nothing Then
							_cabMovGan_.UnsetRelatedEntity(Me, "CabRegCom_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGan_. When set to true, CabMovGan_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGan_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabMovGan_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGan_ As Boolean
			Get
				Return _alwaysFetchCabMovGan_
			End Get
			Set
				_alwaysFetchCabMovGan_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabMovGan_ is not found
		''' in the database. When set to true, CabMovGan_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabMovGan_ReturnsNewIfNotFound As Boolean
			Get
				Return _cabMovGan_ReturnsNewIfNotFound
			End Get
			Set
				_cabMovGan_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CatLugaresDeCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatLugaresDeCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatLugaresDeCompra]() As CatLugaresDeCompraEntity
			Get
				Return GetSingleCatLugaresDeCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatLugaresDeCompra(value)
				Else
					If value Is Nothing Then
						If Not _catLugaresDeCompra Is Nothing Then
							_catLugaresDeCompra.UnsetRelatedEntity(Me, "CabRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompra. When set to true, CatLugaresDeCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatLugaresDeCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompra As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompra
			End Get
			Set
				_alwaysFetchCatLugaresDeCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatLugaresDeCompra is not found
		''' in the database. When set to true, CatLugaresDeCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatLugaresDeCompraReturnsNewIfNotFound As Boolean
			Get
				Return _catLugaresDeCompraReturnsNewIfNotFound
			End Get
			Set
				_catLugaresDeCompraReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Proveedor]() As ProveedorEntity
			Get
				Return GetSingleProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedor(value)
				Else
					If value Is Nothing Then
						If Not _proveedor Is Nothing Then
							_proveedor.UnsetRelatedEntity(Me, "CabRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Proveedor is not found
		''' in the database. When set to true, Proveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorReturnsNewIfNotFound
			End Get
			Set
				_proveedorReturnsNewIfNotFound = value
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
							_mcecatCorralesCab.UnsetRelatedEntity(Me, "CabRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom")
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
	
		''' <summary>Gets / sets related entity of type 'McgcatCompradoresdeGanadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcgcatCompradoresdeGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McgcatCompradoresdeGanado]() As McgcatCompradoresdeGanadoEntity
			Get
				Return GetSingleMcgcatCompradoresdeGanado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcgcatCompradoresdeGanado(value)
				Else
					If value Is Nothing Then
						If Not _mcgcatCompradoresdeGanado Is Nothing Then
							_mcgcatCompradoresdeGanado.UnsetRelatedEntity(Me, "CabRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabRegCom")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatCompradoresdeGanado. When set to true, McgcatCompradoresdeGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatCompradoresdeGanado is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcgcatCompradoresdeGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatCompradoresdeGanado As Boolean
			Get
				Return _alwaysFetchMcgcatCompradoresdeGanado
			End Get
			Set
				_alwaysFetchMcgcatCompradoresdeGanado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McgcatCompradoresdeGanado is not found
		''' in the database. When set to true, McgcatCompradoresdeGanado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McgcatCompradoresdeGanadoReturnsNewIfNotFound As Boolean
			Get
				Return _mcgcatCompradoresdeGanadoReturnsNewIfNotFound
			End Get
			Set
				_mcgcatCompradoresdeGanadoReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'CabGasTransEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabGasTrans()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabGasTrans]() As CabGasTransEntity
			Get
				Return GetSingleCabGasTrans(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabGasTrans(value)
				Else
					If value Is Nothing Then
						DesetupSyncCabGasTrans(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "CabRegCom")
						SetupSyncCabGasTrans(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabGasTrans. When set to true, CabGasTrans is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabGasTrans is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabGasTrans(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabGasTrans As Boolean
			Get
				Return _alwaysFetchCabGasTrans
			End Get
			Set
				_alwaysFetchCabGasTrans = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabGasTrans is not found
		''' in the database. When set to true, CabGasTrans will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabGasTransReturnsNewIfNotFound As Boolean
			Get
				Return _cabGasTransReturnsNewIfNotFound
			End Get
			Set
				_cabGasTransReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CabRegComEntity)
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
