' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:30
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
	''' <summary>Entity class which represents the entity 'ListaPrecio'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ListaPrecioEntity 
#Else
	<Serializable()> _
	Public Class ListaPrecioEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cliente As Integralab.ORM.CollectionClasses.ClienteCollection
		Private _alwaysFetchCliente, _alreadyFetchedCliente As Boolean
		Private _listasPrecio As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListasPrecio, _alreadyFetchedListasPrecio As Boolean
		Private _listaPreciosDetalle As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
		Private _alwaysFetchListaPreciosDetalle, _alreadyFetchedListaPreciosDetalle As Boolean
		Private _plazaCollectionViaCliente As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaCliente, _alreadyFetchedPlazaCollectionViaCliente As Boolean
		Private _plazaCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaListaPrecio, _alreadyFetchedPlazaCollectionViaListaPrecio As Boolean
		Private _tipoVentaCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.TipoVentaCollection
		Private _alwaysFetchTipoVentaCollectionViaListaPrecio, _alreadyFetchedTipoVentaCollectionViaListaPrecio As Boolean
		Private _productoCollectionViaListaPrecioDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaListaPrecioDetalle, _alreadyFetchedProductoCollectionViaListaPrecioDetalle As Boolean
		Private _plaza_ As PlazaEntity
		Private _alwaysFetchPlaza_, _alreadyFetchedPlaza_, _plaza_ReturnsNewIfNotFound As Boolean
		Private _tipoVenta As TipoVentaEntity
		Private _alwaysFetchTipoVenta, _alreadyFetchedTipoVenta, _tipoVentaReturnsNewIfNotFound As Boolean
		Private _listaPrecioBase As ListaPrecioEntity
		Private _alwaysFetchListaPrecioBase, _alreadyFetchedListaPrecioBase, _listaPrecioBaseReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <param name="validator">The custom validator Object for this ListaPrecioEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cliente = CType(info.GetValue("_cliente", GetType(Integralab.ORM.CollectionClasses.ClienteCollection)), Integralab.ORM.CollectionClasses.ClienteCollection)
			_alwaysFetchCliente = info.GetBoolean("_alwaysFetchCliente")
			_alreadyFetchedCliente = info.GetBoolean("_alreadyFetchedCliente")
			_listasPrecio = CType(info.GetValue("_listasPrecio", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListasPrecio = info.GetBoolean("_alwaysFetchListasPrecio")
			_alreadyFetchedListasPrecio = info.GetBoolean("_alreadyFetchedListasPrecio")
			_listaPreciosDetalle = CType(info.GetValue("_listaPreciosDetalle", GetType(Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection)), Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection)
			_alwaysFetchListaPreciosDetalle = info.GetBoolean("_alwaysFetchListaPreciosDetalle")
			_alreadyFetchedListaPreciosDetalle = info.GetBoolean("_alreadyFetchedListaPreciosDetalle")
			_plazaCollectionViaCliente = CType(info.GetValue("_plazaCollectionViaCliente", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaCliente = info.GetBoolean("_alwaysFetchPlazaCollectionViaCliente")
			_alreadyFetchedPlazaCollectionViaCliente = info.GetBoolean("_alreadyFetchedPlazaCollectionViaCliente")
			_plazaCollectionViaListaPrecio = CType(info.GetValue("_plazaCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchPlazaCollectionViaListaPrecio")
			_alreadyFetchedPlazaCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedPlazaCollectionViaListaPrecio")
			_tipoVentaCollectionViaListaPrecio = CType(info.GetValue("_tipoVentaCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.TipoVentaCollection)), Integralab.ORM.CollectionClasses.TipoVentaCollection)
			_alwaysFetchTipoVentaCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchTipoVentaCollectionViaListaPrecio")
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedTipoVentaCollectionViaListaPrecio")
			_productoCollectionViaListaPrecioDetalle = CType(info.GetValue("_productoCollectionViaListaPrecioDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaListaPrecioDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaListaPrecioDetalle")
			_alreadyFetchedProductoCollectionViaListaPrecioDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaListaPrecioDetalle")
			_plaza_ = CType(info.GetValue("_plaza_", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza_ Is Nothing Then
				AddHandler _plaza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plaza_ReturnsNewIfNotFound = info.GetBoolean("_plaza_ReturnsNewIfNotFound")
			_alwaysFetchPlaza_ = info.GetBoolean("_alwaysFetchPlaza_")
			_alreadyFetchedPlaza_ = info.GetBoolean("_alreadyFetchedPlaza_")
			_tipoVenta = CType(info.GetValue("_tipoVenta", GetType(TipoVentaEntity)), TipoVentaEntity)
			If Not _tipoVenta Is Nothing Then
				AddHandler _tipoVenta.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoVentaReturnsNewIfNotFound = info.GetBoolean("_tipoVentaReturnsNewIfNotFound")
			_alwaysFetchTipoVenta = info.GetBoolean("_alwaysFetchTipoVenta")
			_alreadyFetchedTipoVenta = info.GetBoolean("_alreadyFetchedTipoVenta")
			_listaPrecioBase = CType(info.GetValue("_listaPrecioBase", GetType(ListaPrecioEntity)), ListaPrecioEntity)
			If Not _listaPrecioBase Is Nothing Then
				AddHandler _listaPrecioBase.AfterSave, AddressOf OnEntityAfterSave
			End If
			_listaPrecioBaseReturnsNewIfNotFound = info.GetBoolean("_listaPrecioBaseReturnsNewIfNotFound")
			_alwaysFetchListaPrecioBase = info.GetBoolean("_alwaysFetchListaPrecioBase")
			_alreadyFetchedListaPrecioBase = info.GetBoolean("_alreadyFetchedListaPrecioBase")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCliente = (_cliente.Count > 0)
			_alreadyFetchedListasPrecio = (_listasPrecio.Count > 0)
			_alreadyFetchedListaPreciosDetalle = (_listaPreciosDetalle.Count > 0)
			_alreadyFetchedPlazaCollectionViaCliente = (_plazaCollectionViaCliente.Count > 0)
			_alreadyFetchedPlazaCollectionViaListaPrecio = (_plazaCollectionViaListaPrecio.Count > 0)
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = (_tipoVentaCollectionViaListaPrecio.Count > 0)
			_alreadyFetchedProductoCollectionViaListaPrecioDetalle = (_productoCollectionViaListaPrecioDetalle.Count > 0)
			_alreadyFetchedPlaza_ = Not(_plaza_ Is Nothing)
			_alreadyFetchedTipoVenta = Not(_tipoVenta Is Nothing)
			_alreadyFetchedListaPrecioBase = Not(_listaPrecioBase Is Nothing)

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
			info.AddValue("_cliente", _cliente)
			info.AddValue("_alwaysFetchCliente", _alwaysFetchCliente)
			info.AddValue("_alreadyFetchedCliente", _alreadyFetchedCliente)
			info.AddValue("_listasPrecio", _listasPrecio)
			info.AddValue("_alwaysFetchListasPrecio", _alwaysFetchListasPrecio)
			info.AddValue("_alreadyFetchedListasPrecio", _alreadyFetchedListasPrecio)
			info.AddValue("_listaPreciosDetalle", _listaPreciosDetalle)
			info.AddValue("_alwaysFetchListaPreciosDetalle", _alwaysFetchListaPreciosDetalle)
			info.AddValue("_alreadyFetchedListaPreciosDetalle", _alreadyFetchedListaPreciosDetalle)
			info.AddValue("_plazaCollectionViaCliente", _plazaCollectionViaCliente)
			info.AddValue("_alwaysFetchPlazaCollectionViaCliente", _alwaysFetchPlazaCollectionViaCliente)
			info.AddValue("_alreadyFetchedPlazaCollectionViaCliente", _alreadyFetchedPlazaCollectionViaCliente)
			info.AddValue("_plazaCollectionViaListaPrecio", _plazaCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchPlazaCollectionViaListaPrecio", _alwaysFetchPlazaCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedPlazaCollectionViaListaPrecio", _alreadyFetchedPlazaCollectionViaListaPrecio)
			info.AddValue("_tipoVentaCollectionViaListaPrecio", _tipoVentaCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchTipoVentaCollectionViaListaPrecio", _alwaysFetchTipoVentaCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedTipoVentaCollectionViaListaPrecio", _alreadyFetchedTipoVentaCollectionViaListaPrecio)
			info.AddValue("_productoCollectionViaListaPrecioDetalle", _productoCollectionViaListaPrecioDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaListaPrecioDetalle", _alwaysFetchProductoCollectionViaListaPrecioDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaListaPrecioDetalle", _alreadyFetchedProductoCollectionViaListaPrecioDetalle)
			info.AddValue("_plaza_", _plaza_)
			info.AddValue("_plaza_ReturnsNewIfNotFound", _plaza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza_", _alwaysFetchPlaza_)
			info.AddValue("_alreadyFetchedPlaza_", _alreadyFetchedPlaza_)
			info.AddValue("_tipoVenta", _tipoVenta)
			info.AddValue("_tipoVentaReturnsNewIfNotFound", _tipoVentaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoVenta", _alwaysFetchTipoVenta)
			info.AddValue("_alreadyFetchedTipoVenta", _alreadyFetchedTipoVenta)
			info.AddValue("_listaPrecioBase", _listaPrecioBase)
			info.AddValue("_listaPrecioBaseReturnsNewIfNotFound", _listaPrecioBaseReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchListaPrecioBase", _alwaysFetchListaPrecioBase)
			info.AddValue("_alreadyFetchedListaPrecioBase", _alreadyFetchedListaPrecioBase)

			
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
				Case "Plaza_"
					_alreadyFetchedPlaza_ = True
					Me.Plaza_ = CType(entity, PlazaEntity)
				Case "TipoVenta"
					_alreadyFetchedTipoVenta = True
					Me.TipoVenta = CType(entity, TipoVentaEntity)
				Case "ListaPrecioBase"
					_alreadyFetchedListaPrecioBase = True
					Me.ListaPrecioBase = CType(entity, ListaPrecioEntity)
				Case "Cliente"
					_alreadyFetchedCliente = True
					If Not entity Is Nothing Then
						Me.Cliente.Add(CType(entity, ClienteEntity))
					End If
				Case "ListasPrecio"
					_alreadyFetchedListasPrecio = True
					If Not entity Is Nothing Then
						Me.ListasPrecio.Add(CType(entity, ListaPrecioEntity))
					End If
				Case "ListaPreciosDetalle"
					_alreadyFetchedListaPreciosDetalle = True
					If Not entity Is Nothing Then
						Me.ListaPreciosDetalle.Add(CType(entity, ListaPrecioDetalleEntity))
					End If
				Case "PlazaCollectionViaCliente"
					_alreadyFetchedPlazaCollectionViaCliente = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaCliente.Add(CType(entity, PlazaEntity))
					End If
				Case "PlazaCollectionViaListaPrecio"
					_alreadyFetchedPlazaCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaListaPrecio.Add(CType(entity, PlazaEntity))
					End If
				Case "TipoVentaCollectionViaListaPrecio"
					_alreadyFetchedTipoVentaCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.TipoVentaCollectionViaListaPrecio.Add(CType(entity, TipoVentaEntity))
					End If
				Case "ProductoCollectionViaListaPrecioDetalle"
					_alreadyFetchedProductoCollectionViaListaPrecioDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaListaPrecioDetalle.Add(CType(entity, ProductoEntity))
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
				Case "Plaza_"
					SetupSyncPlaza_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoVenta"
					SetupSyncTipoVenta(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPrecioBase"
					SetupSyncListaPrecioBase(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cliente"
					_cliente.Add(CType(relatedEntity, ClienteEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListasPrecio"
					_listasPrecio.Add(CType(relatedEntity, ListaPrecioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPreciosDetalle"
					_listaPreciosDetalle.Add(CType(relatedEntity, ListaPrecioDetalleEntity))
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
				Case "Plaza_"
					DesetupSyncPlaza_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoVenta"
					DesetupSyncTipoVenta(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPrecioBase"
					DesetupSyncListaPrecioBase(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cliente"
					MyBase.PerformRelatedEntityRemoval(_cliente, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListasPrecio"
					MyBase.PerformRelatedEntityRemoval(_listasPrecio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPreciosDetalle"
					MyBase.PerformRelatedEntityRemoval(_listaPreciosDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _plaza_ Is Nothing Then
				toReturn.Add(_plaza_)
			End If
			If Not _tipoVenta Is Nothing Then
				toReturn.Add(_tipoVenta)
			End If
			If Not _listaPrecioBase Is Nothing Then
				toReturn.Add(_listaPrecioBase)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cliente)
			toReturn.Add(_listasPrecio)
			toReturn.Add(_listaPreciosDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ListaPrecioFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ListaPrecioFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ClienteEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ClienteEntity'</returns>
		Public Function GetMultiCliente(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ClienteCollection
			Return GetMultiCliente(forceFetch, _cliente.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ClienteCollection
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
				_cliente.GetMultiManyToOne(Nothing, Me, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListasPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListasPrecio(forceFetch, _listasPrecio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiListasPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListasPrecio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListasPrecio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListasPrecio(forceFetch, _listasPrecio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListasPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListasPrecio Or forceFetch Or _alwaysFetchListasPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listasPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listasPrecio)
					End If
				End If
				_listasPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listasPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_listasPrecio.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_listasPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedListasPrecio = True
			End If
			Return _listasPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListasPrecio'. These settings will be taken into account
		''' when the property ListasPrecio is requested or GetMultiListasPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListasPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listasPrecio.SortClauses=sortClauses
			_listasPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioDetalleEntity'</returns>
		Public Function GetMultiListaPreciosDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPreciosDetalle(forceFetch, _listaPreciosDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiListaPreciosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPreciosDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioDetalleEntity'</returns>
		Public Function GetMultiListaPreciosDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Return GetMultiListaPreciosDetalle(forceFetch, _listaPreciosDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPreciosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			If ( Not _alreadyFetchedListaPreciosDetalle Or forceFetch Or _alwaysFetchListaPreciosDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPreciosDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPreciosDetalle)
					End If
				End If
				_listaPreciosDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPreciosDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPreciosDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_listaPreciosDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedListaPreciosDetalle = True
			End If
			Return _listaPreciosDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPreciosDetalle'. These settings will be taken into account
		''' when the property ListaPreciosDetalle is requested or GetMultiListaPreciosDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPreciosDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPreciosDetalle.SortClauses=sortClauses
			_listaPreciosDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaCliente(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaCliente(forceFetch, _plazaCollectionViaCliente.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaCliente(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaCliente Or forceFetch Or _alwaysFetchPlazaCollectionViaCliente) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaCliente.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaCliente)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ListaPrecioEntity.Relations.ClienteEntityUsingListaPrecios, "__ListaPrecioEntity__", "Cliente_", JoinHint.None)
				relations.Add(ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza, "Cliente_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaCliente.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaCliente.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaCliente.GetMulti(Filter, relations)
				_plazaCollectionViaCliente.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaCliente = True
			End If
			Return _plazaCollectionViaCliente
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaCliente'. These settings will be taken into account
		''' when the property PlazaCollectionViaCliente is requested or GetMultiPlazaCollectionViaCliente is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaCliente(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaCliente.SortClauses=sortClauses
			_plazaCollectionViaCliente.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaListaPrecio(forceFetch, _plazaCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaListaPrecio Or forceFetch Or _alwaysFetchPlazaCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "__ListaPrecioEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.PlazaEntityUsingPlaza, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaListaPrecio.GetMulti(Filter, relations)
				_plazaCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaListaPrecio = True
			End If
			Return _plazaCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property PlazaCollectionViaListaPrecio is requested or GetMultiPlazaCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaListaPrecio.SortClauses=sortClauses
			_plazaCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoVentaEntity'</returns>
		Public Function GetMultiTipoVentaCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoVentaCollection
			Return GetMultiTipoVentaCollectionViaListaPrecio(forceFetch, _tipoVentaCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoVentaCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoVentaCollection
			If ( Not _alreadyFetchedTipoVentaCollectionViaListaPrecio Or forceFetch Or _alwaysFetchTipoVentaCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoVentaCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoVentaCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "__ListaPrecioEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoVentaCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoVentaCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoVentaCollectionViaListaPrecio.GetMulti(Filter, relations)
				_tipoVentaCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedTipoVentaCollectionViaListaPrecio = True
			End If
			Return _tipoVentaCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoVentaCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property TipoVentaCollectionViaListaPrecio is requested or GetMultiTipoVentaCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoVentaCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoVentaCollectionViaListaPrecio.SortClauses=sortClauses
			_tipoVentaCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaListaPrecioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaListaPrecioDetalle(forceFetch, _productoCollectionViaListaPrecioDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaListaPrecioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaListaPrecioDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaListaPrecioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaListaPrecioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaListaPrecioDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioDetalleEntityUsingListaPrecios, "__ListaPrecioEntity__", "ListaPrecioDetalle_", JoinHint.None)
				relations.Add(ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto, "ListaPrecioDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ListaPrecioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_productoCollectionViaListaPrecioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaListaPrecioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaListaPrecioDetalle.GetMulti(Filter, relations)
				_productoCollectionViaListaPrecioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaListaPrecioDetalle = True
			End If
			Return _productoCollectionViaListaPrecioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaListaPrecioDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaListaPrecioDetalle is requested or GetMultiProductoCollectionViaListaPrecioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaListaPrecioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaListaPrecioDetalle.SortClauses=sortClauses
			_productoCollectionViaListaPrecioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza_() As PlazaEntity
			Return GetSinglePlaza_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza_(forceFetch As Boolean) As PlazaEntity
			If ( Not _alreadyFetchedPlaza_ Or forceFetch Or _alwaysFetchPlaza_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PlazaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ListaPrecioEntity.Relations.PlazaEntityUsingPlaza) Then
					fetchResult = newEntity.FetchUsingPK(Me.Plaza)
				End If
				If Not _plaza_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Plaza_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PlazaEntity)
					End If
					Me.Plaza_ = newEntity
					_alreadyFetchedPlaza_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _plaza_
		End Function
	
		''' <summary>Retrieves the related entity of type 'TipoVentaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoVentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoVenta() As TipoVentaEntity
			Return GetSingleTipoVenta(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoVentaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoVentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoVenta(forceFetch As Boolean) As TipoVentaEntity
			If ( Not _alreadyFetchedTipoVenta Or forceFetch Or _alwaysFetchTipoVenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoVentaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta) Then
					fetchResult = newEntity.FetchUsingPK(Me.LpidTipoVenta)
				End If
				If Not _tipoVentaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoVenta = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoVentaEntity)
					End If
					Me.TipoVenta = newEntity
					_alreadyFetchedTipoVenta = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoVenta
		End Function
	
		''' <summary>Retrieves the related entity of type 'ListaPrecioEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ListaPrecioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleListaPrecioBase() As ListaPrecioEntity
			Return GetSingleListaPrecioBase(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ListaPrecioEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ListaPrecioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleListaPrecioBase(forceFetch As Boolean) As ListaPrecioEntity
			If ( Not _alreadyFetchedListaPrecioBase Or forceFetch Or _alwaysFetchListaPrecioBase) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ListaPrecioEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ListaPrecioEntity.Relations.ListaPrecioEntityUsingCodigoListaBase) Then
					fetchResult = newEntity.FetchUsingPK(Me.ListaBase.GetValueOrDefault())
				End If
				If Not _listaPrecioBaseReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.ListaPrecioBase = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ListaPrecioEntity)
					End If
					Me.ListaPrecioBase = newEntity
					_alreadyFetchedListaPrecioBase = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _listaPrecioBase
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ListaPrecioFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ListaPrecioFieldIndex)
					Case ListaPrecioFieldIndex.Plaza
						DesetupSyncPlaza_(True, False)
						_alreadyFetchedPlaza_ = False

















					Case ListaPrecioFieldIndex.ListaBase
						DesetupSyncListaPrecioBase(True, False)
						_alreadyFetchedListaPrecioBase = False
					Case ListaPrecioFieldIndex.LpidTipoVenta
						DesetupSyncTipoVenta(True, False)
						_alreadyFetchedTipoVenta = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cliente.ActiveContext = MyBase.ActiveContext
			_listasPrecio.ActiveContext = MyBase.ActiveContext
			_listaPreciosDetalle.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaCliente.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext
			_tipoVentaCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaListaPrecioDetalle.ActiveContext = MyBase.ActiveContext
		If Not _plaza_ Is Nothing Then
				_plaza_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoVenta Is Nothing Then
				_tipoVenta.ActiveContext = MyBase.ActiveContext
			End If
		If Not _listaPrecioBase Is Nothing Then
				_listaPrecioBase.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ListaPrecioDAO = CType(CreateDAOInstance(), ListaPrecioDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ListaPrecioDAO = CType(CreateDAOInstance(), ListaPrecioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ListaPrecioDAO = CType(CreateDAOInstance(), ListaPrecioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ListaPrecioEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ListaPrecioEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <param name="validator">The validator Object for this ListaPrecioEntity</param>
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
			_cliente = New Integralab.ORM.CollectionClasses.ClienteCollection(New ClienteEntityFactory())
			_cliente.SetContainingEntityInfo(Me, "ListaPrecio")
			_alwaysFetchCliente = False
			_alreadyFetchedCliente = False
			_listasPrecio = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_listasPrecio.SetContainingEntityInfo(Me, "ListaPrecioBase")
			_alwaysFetchListasPrecio = False
			_alreadyFetchedListasPrecio = False
			_listaPreciosDetalle = New Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection(New ListaPrecioDetalleEntityFactory())
			_listaPreciosDetalle.SetContainingEntityInfo(Me, "ListaPrecio")
			_alwaysFetchListaPreciosDetalle = False
			_alreadyFetchedListaPreciosDetalle = False
			_plazaCollectionViaCliente = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaCliente = False
			_alreadyFetchedPlazaCollectionViaCliente = False
			_plazaCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaListaPrecio = False
			_alreadyFetchedPlazaCollectionViaListaPrecio = False
			_tipoVentaCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.TipoVentaCollection(New TipoVentaEntityFactory())
			_alwaysFetchTipoVentaCollectionViaListaPrecio = False
			_alreadyFetchedTipoVentaCollectionViaListaPrecio = False
			_productoCollectionViaListaPrecioDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaListaPrecioDetalle = False
			_alreadyFetchedProductoCollectionViaListaPrecioDetalle = False
			_plaza_ = Nothing
			_plaza_ReturnsNewIfNotFound = True
			_alwaysFetchPlaza_ = False
			_alreadyFetchedPlaza_ = False
			_tipoVenta = Nothing
			_tipoVentaReturnsNewIfNotFound = True
			_alwaysFetchTipoVenta = False
			_alreadyFetchedTipoVenta = False
			_listaPrecioBase = Nothing
			_listaPrecioBaseReturnsNewIfNotFound = True
			_alwaysFetchListaPrecioBase = False
			_alreadyFetchedListaPrecioBase = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Vigencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasVigencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVigenciaDe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVigenciaA", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsListaBase", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ListaBase", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LpidTipoVenta", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _plaza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", ListaPrecioEntity.Relations.PlazaEntityUsingPlaza, True, signalRelatedEntity, "ListaPrecio", resetFKFields, New Integer() { CInt(ListaPrecioFieldIndex.Plaza) } )
			_plaza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza_(relatedEntity As IEntity)
			DesetupSyncPlaza_(True, True)
			_plaza_ = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", ListaPrecioEntity.Relations.PlazaEntityUsingPlaza, True, _alreadyFetchedPlaza_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPlaza_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _tipoVenta</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoVenta(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoVenta, AddressOf OnTipoVentaPropertyChanged, "TipoVenta", ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta, True, signalRelatedEntity, "ListaPrecio", resetFKFields, New Integer() { CInt(ListaPrecioFieldIndex.LpidTipoVenta) } )
			_tipoVenta = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoVenta</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoVenta(relatedEntity As IEntity)
			DesetupSyncTipoVenta(True, True)
			_tipoVenta = CType(relatedEntity, TipoVentaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoVenta, AddressOf OnTipoVentaPropertyChanged, "TipoVenta", ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta, True, _alreadyFetchedTipoVenta, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoVentaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _listaPrecioBase</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncListaPrecioBase(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _listaPrecioBase, AddressOf OnListaPrecioBasePropertyChanged, "ListaPrecioBase", ListaPrecioEntity.Relations.ListaPrecioEntityUsingCodigoListaBase, True, signalRelatedEntity, "ListasPrecio", resetFKFields, New Integer() { CInt(ListaPrecioFieldIndex.ListaBase) } )
			_listaPrecioBase = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _listaPrecioBase</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncListaPrecioBase(relatedEntity As IEntity)
			DesetupSyncListaPrecioBase(True, True)
			_listaPrecioBase = CType(relatedEntity, ListaPrecioEntity)
			MyBase.PerformSetupSyncRelatedEntity( _listaPrecioBase, AddressOf OnListaPrecioBasePropertyChanged, "ListaPrecioBase", ListaPrecioEntity.Relations.ListaPrecioEntityUsingCodigoListaBase, True, _alreadyFetchedListaPrecioBase, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnListaPrecioBasePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for ListaPrecio which data should be fetched into this ListaPrecio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ListaPrecioFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateListaPrecioDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ListaPrecioEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ListaPrecioRelations
			Get	
				Return New ListaPrecioRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cliente' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCliente() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ClienteCollection(), _
					ListaPrecioEntity.Relations.ClienteEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.ClienteEntity, Integer), 0, Nothing, Nothing, Nothing, "Cliente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListasPrecio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListasPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecioDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPreciosDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioDetalleEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPreciosDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaCliente() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ListaPrecioEntity.Relations.ClienteEntityUsingListaPrecios, "__ListaPrecioEntity__", String.Empty, JoinHint.None)
				relations.Add(ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ListaPrecioEntity.Relations.ClienteEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaCliente", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "__ListaPrecioEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoVentaCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "__ListaPrecioEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoVentaCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), 0, Nothing, Nothing, relations, "TipoVentaCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaListaPrecioDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioDetalleEntityUsingListaPrecios, "__ListaPrecioEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioDetalleEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaListaPrecioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ListaPrecioEntity.Relations.PlazaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoVenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoVentaCollection(), _
					ListaPrecioEntity.Relations.TipoVentaEntityUsingLpidTipoVenta, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoVenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioBase() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					ListaPrecioEntity.Relations.ListaPrecioEntityUsingCodigoListaBase, _
					CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecioBase", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ListaPrecioEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ListaPrecioEntity.CustomProperties
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
				Return ListaPrecioEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Plaza property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdPlaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Plaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Plaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Plaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Codigo property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdListaPrecios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPDescCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fecha property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPFecha"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Fecha]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Fecha, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Fecha, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Vigencia property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPVigencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Vigencia]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Vigencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Vigencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasVigencia property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPDiasVigencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasVigencia]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.DiasVigencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.DiasVigencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVigenciaDe property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPFechaVigencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVigenciaDe]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.FechaVigenciaDe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.FechaVigenciaDe, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVigenciaA property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPFechaVigenciaA"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVigenciaA]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.FechaVigenciaA, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.FechaVigenciaA, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsListaBase property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPEsListaBase"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsListaBase]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.EsListaBase, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.EsListaBase, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPFechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancela property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPFechaCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancela]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.FechaCancela, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.FechaCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancela property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPObservacionesCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancela]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.ObservacionesCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.ObservacionesCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioCancela property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdUsuarioCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioCancela]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.UsuarioCancela, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.UsuarioCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoCancelacion property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdMotivoCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.MotivoCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.MotivoCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ListaBase property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPListaBase"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ListaBase]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.ListaBase, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.ListaBase, Integer), value)
			End Set
		End Property
	
		''' <summary>The LpidTipoVenta property of the Entity ListaPrecio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosCab"."LPIdTipoVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LpidTipoVenta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioFieldIndex.LpidTipoVenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioFieldIndex.LpidTipoVenta, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ClienteEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCliente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cliente]() As Integralab.ORM.CollectionClasses.ClienteCollection
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
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListasPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListasPrecio]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListasPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListasPrecio. When set to true, ListasPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListasPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiListasPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListasPrecio As Boolean
			Get
				Return _alwaysFetchListasPrecio
			End Get
			Set
				_alwaysFetchListasPrecio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPreciosDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPreciosDetalle]() As Integralab.ORM.CollectionClasses.ListaPrecioDetalleCollection
			Get
				Return GetMultiListaPreciosDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPreciosDetalle. When set to true, ListaPreciosDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPreciosDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPreciosDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPreciosDetalle As Boolean
			Get
				Return _alwaysFetchListaPreciosDetalle
			End Get
			Set
				_alwaysFetchListaPreciosDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaCliente()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaCliente]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaCliente(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaCliente. When set to true, PlazaCollectionViaCliente is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaCliente is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaCliente(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaCliente As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaCliente
			End Get
			Set
				_alwaysFetchPlazaCollectionViaCliente = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaListaPrecio. When set to true, PlazaCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchPlazaCollectionViaListaPrecio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoVentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoVentaCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoVentaCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.TipoVentaCollection
			Get
				Return GetMultiTipoVentaCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoVentaCollectionViaListaPrecio. When set to true, TipoVentaCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoVentaCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoVentaCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoVentaCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchTipoVentaCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchTipoVentaCollectionViaListaPrecio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaListaPrecioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaListaPrecioDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaListaPrecioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaListaPrecioDetalle. When set to true, ProductoCollectionViaListaPrecioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaListaPrecioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaListaPrecioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaListaPrecioDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaListaPrecioDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaListaPrecioDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'PlazaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePlaza_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Plaza_]() As PlazaEntity
			Get
				Return GetSinglePlaza_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPlaza_(value)
				Else
					If value Is Nothing Then
						If Not _plaza_ Is Nothing Then
							_plaza_.UnsetRelatedEntity(Me, "ListaPrecio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ListaPrecio")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Plaza_. When set to true, Plaza_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Plaza_ is accessed. You can always execute
		''' a forced fetch by calling GetSinglePlaza_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlaza_ As Boolean
			Get
				Return _alwaysFetchPlaza_
			End Get
			Set
				_alwaysFetchPlaza_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Plaza_ is not found
		''' in the database. When set to true, Plaza_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Plaza_ReturnsNewIfNotFound As Boolean
			Get
				Return _plaza_ReturnsNewIfNotFound
			End Get
			Set
				_plaza_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'TipoVentaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoVenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoVenta]() As TipoVentaEntity
			Get
				Return GetSingleTipoVenta(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoVenta(value)
				Else
					If value Is Nothing Then
						If Not _tipoVenta Is Nothing Then
							_tipoVenta.UnsetRelatedEntity(Me, "ListaPrecio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ListaPrecio")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoVenta. When set to true, TipoVenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoVenta is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoVenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoVenta As Boolean
			Get
				Return _alwaysFetchTipoVenta
			End Get
			Set
				_alwaysFetchTipoVenta = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoVenta is not found
		''' in the database. When set to true, TipoVenta will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoVentaReturnsNewIfNotFound As Boolean
			Get
				Return _tipoVentaReturnsNewIfNotFound
			End Get
			Set
				_tipoVentaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ListaPrecioEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleListaPrecioBase()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [ListaPrecioBase]() As ListaPrecioEntity
			Get
				Return GetSingleListaPrecioBase(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncListaPrecioBase(value)
				Else
					If value Is Nothing Then
						If Not _listaPrecioBase Is Nothing Then
							_listaPrecioBase.UnsetRelatedEntity(Me, "ListasPrecio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ListasPrecio")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioBase. When set to true, ListaPrecioBase is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioBase is accessed. You can always execute
		''' a forced fetch by calling GetSingleListaPrecioBase(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioBase As Boolean
			Get
				Return _alwaysFetchListaPrecioBase
			End Get
			Set
				_alwaysFetchListaPrecioBase = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property ListaPrecioBase is not found
		''' in the database. When set to true, ListaPrecioBase will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ListaPrecioBaseReturnsNewIfNotFound As Boolean
			Get
				Return _listaPrecioBaseReturnsNewIfNotFound
			End Get
			Set
				_listaPrecioBaseReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ListaPrecioEntity)
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
