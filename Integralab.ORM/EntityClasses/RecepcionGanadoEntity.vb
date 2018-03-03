' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:38
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
	''' <summary>Entity class which represents the entity 'RecepcionGanado'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class RecepcionGanadoEntity 
#Else
	<Serializable()> _
	Public Class RecepcionGanadoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _usrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection
		Private _alwaysFetchUsrProdRecepcionDetalle, _alreadyFetchedUsrProdRecepcionDetalle As Boolean
		Private _usrProdRecepcionGanadoDet As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
		Private _alwaysFetchUsrProdRecepcionGanadoDet, _alreadyFetchedUsrProdRecepcionGanadoDet As Boolean
		Private _productoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle As Boolean
		Private _mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet As Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection
		Private _alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet, _alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet As Boolean
		Private _clientes As MfacCatClientesEntity
		Private _alwaysFetchClientes, _alreadyFetchedClientes, _clientesReturnsNewIfNotFound As Boolean
		Private _mcgcatTiposdeGanado As McgcatTiposdeGanadoEntity
		Private _alwaysFetchMcgcatTiposdeGanado, _alreadyFetchedMcgcatTiposdeGanado, _mcgcatTiposdeGanadoReturnsNewIfNotFound As Boolean


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
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		Public Sub New(loteRecepcion As System.String)

			InitClassFetch(loteRecepcion, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(loteRecepcion As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(loteRecepcion, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="validator">The custom validator Object for this RecepcionGanadoEntity</param>
		Public Sub New(loteRecepcion As System.String, validator As IValidator)

			InitClassFetch(loteRecepcion, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_usrProdRecepcionDetalle = CType(info.GetValue("_usrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection)
			_alwaysFetchUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchUsrProdRecepcionDetalle")
			_alreadyFetchedUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedUsrProdRecepcionDetalle")
			_usrProdRecepcionGanadoDet = CType(info.GetValue("_usrProdRecepcionGanadoDet", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection)
			_alwaysFetchUsrProdRecepcionGanadoDet = info.GetBoolean("_alwaysFetchUsrProdRecepcionGanadoDet")
			_alreadyFetchedUsrProdRecepcionGanadoDet = info.GetBoolean("_alreadyFetchedUsrProdRecepcionGanadoDet")
			_productoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_productoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle")
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle")
			_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = CType(info.GetValue("_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet", GetType(Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection)), Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection)
			_alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = info.GetBoolean("_alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet")
			_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = info.GetBoolean("_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet")
			_clientes = CType(info.GetValue("_clientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _clientes Is Nothing Then
				AddHandler _clientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_clientesReturnsNewIfNotFound = info.GetBoolean("_clientesReturnsNewIfNotFound")
			_alwaysFetchClientes = info.GetBoolean("_alwaysFetchClientes")
			_alreadyFetchedClientes = info.GetBoolean("_alreadyFetchedClientes")
			_mcgcatTiposdeGanado = CType(info.GetValue("_mcgcatTiposdeGanado", GetType(McgcatTiposdeGanadoEntity)), McgcatTiposdeGanadoEntity)
			If Not _mcgcatTiposdeGanado Is Nothing Then
				AddHandler _mcgcatTiposdeGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = info.GetBoolean("_mcgcatTiposdeGanadoReturnsNewIfNotFound")
			_alwaysFetchMcgcatTiposdeGanado = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanado")
			_alreadyFetchedMcgcatTiposdeGanado = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanado")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedUsrProdRecepcionDetalle = (_usrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedUsrProdRecepcionGanadoDet = (_usrProdRecepcionGanadoDet.Count > 0)
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = (_productoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = (_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Count > 0)
			_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = (_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.Count > 0)
			_alreadyFetchedClientes = Not(_clientes Is Nothing)
			_alreadyFetchedMcgcatTiposdeGanado = Not(_mcgcatTiposdeGanado Is Nothing)

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
			info.AddValue("_usrProdRecepcionDetalle", _usrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchUsrProdRecepcionDetalle", _alwaysFetchUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedUsrProdRecepcionDetalle", _alreadyFetchedUsrProdRecepcionDetalle)
			info.AddValue("_usrProdRecepcionGanadoDet", _usrProdRecepcionGanadoDet)
			info.AddValue("_alwaysFetchUsrProdRecepcionGanadoDet", _alwaysFetchUsrProdRecepcionGanadoDet)
			info.AddValue("_alreadyFetchedUsrProdRecepcionGanadoDet", _alreadyFetchedUsrProdRecepcionGanadoDet)
			info.AddValue("_productoCollectionViaUsrProdRecepcionDetalle", _productoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle)
			info.AddValue("_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet", _mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet)
			info.AddValue("_alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet", _alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet)
			info.AddValue("_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet", _alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet)
			info.AddValue("_clientes", _clientes)
			info.AddValue("_clientesReturnsNewIfNotFound", _clientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchClientes", _alwaysFetchClientes)
			info.AddValue("_alreadyFetchedClientes", _alreadyFetchedClientes)
			info.AddValue("_mcgcatTiposdeGanado", _mcgcatTiposdeGanado)
			info.AddValue("_mcgcatTiposdeGanadoReturnsNewIfNotFound", _mcgcatTiposdeGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanado", _alwaysFetchMcgcatTiposdeGanado)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanado", _alreadyFetchedMcgcatTiposdeGanado)

			
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
				Case "Clientes"
					_alreadyFetchedClientes = True
					Me.Clientes = CType(entity, MfacCatClientesEntity)
				Case "McgcatTiposdeGanado"
					_alreadyFetchedMcgcatTiposdeGanado = True
					Me.McgcatTiposdeGanado = CType(entity, McgcatTiposdeGanadoEntity)
				Case "UsrProdRecepcionDetalle"
					_alreadyFetchedUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionDetalle.Add(CType(entity, UsrProdRecepcionDetalleEntity))
					End If
				Case "UsrProdRecepcionGanadoDet"
					_alreadyFetchedUsrProdRecepcionGanadoDet = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionGanadoDet.Add(CType(entity, UsrProdRecepcionGanadoDetEntity))
					End If
				Case "ProductoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.Add(CType(entity, McgcatTiposdeGanadoEntity))
					End If
				Case "MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet"
					_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = True
					If Not entity Is Nothing Then
						Me.MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.Add(CType(entity, MscregistroSacrificioCabEntity))
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
				Case "Clientes"
					SetupSyncClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcatTiposdeGanado"
					SetupSyncMcgcatTiposdeGanado(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					_usrProdRecepcionDetalle.Add(CType(relatedEntity, UsrProdRecepcionDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionGanadoDet"
					_usrProdRecepcionGanadoDet.Add(CType(relatedEntity, UsrProdRecepcionGanadoDetEntity))
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
				Case "Clientes"
					DesetupSyncClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcatTiposdeGanado"
					DesetupSyncMcgcatTiposdeGanado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionGanadoDet"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionGanadoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _clientes Is Nothing Then
				toReturn.Add(_clientes)
			End If
			If Not _mcgcatTiposdeGanado Is Nothing Then
				toReturn.Add(_mcgcatTiposdeGanado)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_usrProdRecepcionDetalle)
			toReturn.Add(_usrProdRecepcionGanadoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String) As Boolean
			Return FetchUsingPK(loteRecepcion, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(loteRecepcion, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(loteRecepcion, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.LoteRecepcion, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As RecepcionGanadoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As RecepcionGanadoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_usrProdRecepcionDetalle.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionGanadoDetEntity'</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, _usrProdRecepcionGanadoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionGanadoDetEntity'</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, _usrProdRecepcionGanadoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			If ( Not _alreadyFetchedUsrProdRecepcionGanadoDet Or forceFetch Or _alwaysFetchUsrProdRecepcionGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRecepcionGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRecepcionGanadoDet)
					End If
				End If
				_usrProdRecepcionGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRecepcionGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRecepcionGanadoDet.GetMultiManyToOne(Nothing, Me, Filter)
				_usrProdRecepcionGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRecepcionGanadoDet = True
			End If
			Return _usrProdRecepcionGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRecepcionGanadoDet'. These settings will be taken into account
		''' when the property UsrProdRecepcionGanadoDet is requested or GetMultiUsrProdRecepcionGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRecepcionGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRecepcionGanadoDet.SortClauses=sortClauses
			_usrProdRecepcionGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RecepcionGanadoFieldIndex.LoteRecepcion), ComparisonOperator.Equal, Me.LoteRecepcion))
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
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", "UsrProdRecepcionDetalle_", JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, "UsrProdRecepcionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RecepcionGanadoFieldIndex.LoteRecepcion), ComparisonOperator.Equal, Me.LoteRecepcion))
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

		''' <summary>Retrieves all related entities of type 'MscregistroSacrificioCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscregistroSacrificioCabEntity'</returns>
		Public Function GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection
			Return GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(forceFetch, _mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscregistroSacrificioCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection
			If ( Not _alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet Or forceFetch Or _alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", "UsrProdRecepcionGanadoDet_", JoinHint.None)
				relations.Add(UsrProdRecepcionGanadoDetEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio, "UsrProdRecepcionGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RecepcionGanadoFieldIndex.LoteRecepcion), ComparisonOperator.Equal, Me.LoteRecepcion))
				_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.GetMulti(Filter, relations)
				_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = True
			End If
			Return _mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet'. These settings will be taken into account
		''' when the property MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet is requested or GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.SortClauses=sortClauses
			_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleClientes() As MfacCatClientesEntity
			Return GetSingleClientes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleClientes(forceFetch As Boolean) As MfacCatClientesEntity
			If ( Not _alreadyFetchedClientes Or forceFetch Or _alwaysFetchClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacCatClientesEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCliente)
				End If
				If Not _clientesReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Clientes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacCatClientesEntity)
					End If
					Me.Clientes = newEntity
					_alreadyFetchedClientes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _clientes
		End Function
	
		''' <summary>Retrieves the related entity of type 'McgcatTiposdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McgcatTiposdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatTiposdeGanado() As McgcatTiposdeGanadoEntity
			Return GetSingleMcgcatTiposdeGanado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McgcatTiposdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McgcatTiposdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatTiposdeGanado(forceFetch As Boolean) As McgcatTiposdeGanadoEntity
			If ( Not _alreadyFetchedMcgcatTiposdeGanado Or forceFetch Or _alwaysFetchMcgcatTiposdeGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McgcatTiposdeGanadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdTipoGanado)
				End If
				If Not _mcgcatTiposdeGanadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McgcatTiposdeGanado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McgcatTiposdeGanadoEntity)
					End If
					Me.McgcatTiposdeGanado = newEntity
					_alreadyFetchedMcgcatTiposdeGanado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcgcatTiposdeGanado
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(RecepcionGanadoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, RecepcionGanadoFieldIndex)

					Case RecepcionGanadoFieldIndex.IdCliente
						DesetupSyncClientes(True, False)
						_alreadyFetchedClientes = False

















					Case RecepcionGanadoFieldIndex.IdTipoGanado
						DesetupSyncMcgcatTiposdeGanado(True, False)
						_alreadyFetchedMcgcatTiposdeGanado = False

















					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_usrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_usrProdRecepcionGanadoDet.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle.ActiveContext = MyBase.ActiveContext
			_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet.ActiveContext = MyBase.ActiveContext
		If Not _clientes Is Nothing Then
				_clientes.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcgcatTiposdeGanado Is Nothing Then
				_mcgcatTiposdeGanado.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As RecepcionGanadoDAO = CType(CreateDAOInstance(), RecepcionGanadoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As RecepcionGanadoDAO = CType(CreateDAOInstance(), RecepcionGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As RecepcionGanadoDAO = CType(CreateDAOInstance(), RecepcionGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this RecepcionGanadoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.RecepcionGanadoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="validator">The validator Object for this RecepcionGanadoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(loteRecepcion As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(loteRecepcion, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_usrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(New UsrProdRecepcionDetalleEntityFactory())
			_usrProdRecepcionDetalle.SetContainingEntityInfo(Me, "RecepcionGanado")
			_alwaysFetchUsrProdRecepcionDetalle = False
			_alreadyFetchedUsrProdRecepcionDetalle = False
			_usrProdRecepcionGanadoDet = New Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection(New UsrProdRecepcionGanadoDetEntityFactory())
			_usrProdRecepcionGanadoDet.SetContainingEntityInfo(Me, "RecepcionGanado")
			_alwaysFetchUsrProdRecepcionGanadoDet = False
			_alreadyFetchedUsrProdRecepcionGanadoDet = False
			_productoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedProductoCollectionViaUsrProdRecepcionDetalle = False
			_mcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle = False
			_mscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = New Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection(New MscregistroSacrificioCabEntityFactory())
			_alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = False
			_alreadyFetchedMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = False
			_clientes = Nothing
			_clientesReturnsNewIfNotFound = True
			_alwaysFetchClientes = False
			_alreadyFetchedClientes = False
			_mcgcatTiposdeGanado = Nothing
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = True
			_alwaysFetchMcgcatTiposdeGanado = False
			_alreadyFetchedMcgcatTiposdeGanado = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteRecepcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaRecepcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteEngorda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosEnviados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosRecibidos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Unidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Conductor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Placas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosPrimerPesada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosSegundaPesada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MultiplesIntroductores", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CabezasMachos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CabezaHembra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoPesada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Maquila", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveLugCom", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveComiGan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasViaje", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosComp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteComp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumPoliza", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _clientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _clientes, AddressOf OnClientesPropertyChanged, "Clientes", RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "RecepcionGanado", resetFKFields, New Integer() { CInt(RecepcionGanadoFieldIndex.IdCliente) } )
			_clientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _clientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncClientes(relatedEntity As IEntity)
			DesetupSyncClientes(True, True)
			_clientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _clientes, AddressOf OnClientesPropertyChanged, "Clientes", RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedClientes, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnClientesPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatTiposdeGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, True, signalRelatedEntity, "RecepcionGanado", resetFKFields, New Integer() { CInt(RecepcionGanadoFieldIndex.IdTipoGanado) } )
			_mcgcatTiposdeGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatTiposdeGanado(relatedEntity As IEntity)
			DesetupSyncMcgcatTiposdeGanado(True, True)
			_mcgcatTiposdeGanado = CType(relatedEntity, McgcatTiposdeGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, True, _alreadyFetchedMcgcatTiposdeGanado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcgcatTiposdeGanadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="loteRecepcion">PK value for RecepcionGanado which data should be fetched into this RecepcionGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(loteRecepcion As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(RecepcionGanadoFieldIndex.LoteRecepcion)).ForcedCurrentValueWrite(loteRecepcion)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateRecepcionGanadoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New RecepcionGanadoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As RecepcionGanadoRelations
			Get	
				Return New RecepcionGanadoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionDetalleCollection(), _
					RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionGanadoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionGanadoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection(), _
					RecepcionGanadoEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionGanadoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					RecepcionGanadoEntity.Relations.UsrProdRecepcionDetalleEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaUsrProdRecepcionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscregistroSacrificioCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(RecepcionGanadoEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteRecepcion, "__RecepcionGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionGanadoDetEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection(), _
					RecepcionGanadoEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), 0, Nothing, Nothing, relations, "MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "Clientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					RecepcionGanadoEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatTiposdeGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "RecepcionGanadoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return RecepcionGanadoEntity.CustomProperties
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
				Return RecepcionGanadoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The LoteRecepcion property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."LoteRecepcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [LoteRecepcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.LoteRecepcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.LoteRecepcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaRecepcion property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."FechaRecepcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaRecepcion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FechaRecepcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FechaRecepcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The LoteEngorda property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."LoteEngorda"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LoteEngorda]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.LoteEngorda, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.LoteEngorda, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabezas property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."CantCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCabezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.CantCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.CantCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosEnviados property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."KilosEnviados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosEnviados]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.KilosEnviados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.KilosEnviados, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosRecibidos property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."KilosRecibidos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosRecibidos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.KilosRecibidos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.KilosRecibidos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Unidad property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Unidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Unidad]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Unidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Unidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Conductor property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Conductor"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Conductor]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Conductor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Conductor, Integer), value)
			End Set
		End Property
	
		''' <summary>The Placas property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Placas"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Placas]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Placas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Placas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuario property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."IdUsuario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuario]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.IdUsuario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.IdUsuario, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.IdUsuarioCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosPrimerPesada property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."KilosPrimerPesada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosPrimerPesada]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.KilosPrimerPesada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.KilosPrimerPesada, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosSegundaPesada property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."KilosSegundaPesada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosSegundaPesada]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.KilosSegundaPesada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.KilosSegundaPesada, Integer), value)
			End Set
		End Property
	
		''' <summary>The MultiplesIntroductores property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."MultiplesIntroductores"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MultiplesIntroductores]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.MultiplesIntroductores, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.MultiplesIntroductores, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdTipoGanado property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."IdTipoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdTipoGanado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.IdTipoGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.IdTipoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CabezasMachos property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."CabezasMachos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CabezasMachos]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.CabezasMachos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.CabezasMachos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CabezaHembra property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."CabezaHembra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CabezaHembra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.CabezaHembra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.CabezaHembra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.IdProveedor, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoPesada property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."TipoPesada"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoPesada]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.TipoPesada, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.TipoPesada, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FechaCaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaSalida property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."FechaSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaSalida]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FechaSalida, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FechaSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The Maquila property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Maquila"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Maquila]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.Maquila, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.Maquila, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveLugCom property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Cve_LugCom"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveLugCom]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.CveLugCom, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.CveLugCom, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveComiGan property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Cve_ComiGan"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveComiGan]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.CveComiGan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.CveComiGan, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasViaje property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."HorasViaje"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasViaje]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.HorasViaje, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.HorasViaje, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosComp property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."KilosComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosComp]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.KilosComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.KilosComp, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteComp property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."ImpteComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteComp]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.ImpteComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.ImpteComp, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."DiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecPago property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Fec_Pago"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecPago]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FecPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FecPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumFactura property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Num_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.NumFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.NumFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumPoliza property of the Entity RecepcionGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdRecepcionGanado"."NumPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionGanadoFieldIndex.NumPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionGanadoFieldIndex.NumPoliza, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRecepcionGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRecepcionGanadoDet]() As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Get
				Return GetMultiUsrProdRecepcionGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRecepcionGanadoDet. When set to true, UsrProdRecepcionGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRecepcionGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRecepcionGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRecepcionGanadoDet As Boolean
			Get
				Return _alwaysFetchUsrProdRecepcionGanadoDet
			End Get
			Set
				_alwaysFetchUsrProdRecepcionGanadoDet = value
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
	
		''' <summary>Retrieves all related entities of type 'MscregistroSacrificioCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet]() As Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection
			Get
				Return GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet. When set to true, MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet As Boolean
			Get
				Return _alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet
			End Get
			Set
				_alwaysFetchMscregistroSacrificioCabCollectionViaUsrProdRecepcionGanadoDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'MfacCatClientesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Clientes]() As MfacCatClientesEntity
			Get
				Return GetSingleClientes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncClientes(value)
				Else
					If value Is Nothing Then
						If Not _clientes Is Nothing Then
							_clientes.UnsetRelatedEntity(Me, "RecepcionGanado")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionGanado")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Clientes. When set to true, Clientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Clientes is accessed. You can always execute
		''' a forced fetch by calling GetSingleClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchClientes As Boolean
			Get
				Return _alwaysFetchClientes
			End Get
			Set
				_alwaysFetchClientes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Clientes is not found
		''' in the database. When set to true, Clientes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ClientesReturnsNewIfNotFound As Boolean
			Get
				Return _clientesReturnsNewIfNotFound
			End Get
			Set
				_clientesReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McgcatTiposdeGanadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcgcatTiposdeGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McgcatTiposdeGanado]() As McgcatTiposdeGanadoEntity
			Get
				Return GetSingleMcgcatTiposdeGanado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcgcatTiposdeGanado(value)
				Else
					If value Is Nothing Then
						If Not _mcgcatTiposdeGanado Is Nothing Then
							_mcgcatTiposdeGanado.UnsetRelatedEntity(Me, "RecepcionGanado")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionGanado")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanado. When set to true, McgcatTiposdeGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanado is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcgcatTiposdeGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanado As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanado
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McgcatTiposdeGanado is not found
		''' in the database. When set to true, McgcatTiposdeGanado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McgcatTiposdeGanadoReturnsNewIfNotFound As Boolean
			Get
				Return _mcgcatTiposdeGanadoReturnsNewIfNotFound
			End Get
			Set
				_mcgcatTiposdeGanadoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.RecepcionGanadoEntity)
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
