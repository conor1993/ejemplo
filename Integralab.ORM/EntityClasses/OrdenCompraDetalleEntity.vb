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
	''' <summary>Entity class which represents the entity 'OrdenCompraDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class OrdenCompraDetalleEntity 
#Else
	<Serializable()> _
	Public Class OrdenCompraDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _tipoMoneda As TipoMonedaEntity
		Private _alwaysFetchTipoMoneda, _alreadyFetchedTipoMoneda, _tipoMonedaReturnsNewIfNotFound As Boolean
		Private _cotizacionCompra As McomCotizacionCompraEntity
		Private _alwaysFetchCotizacionCompra, _alreadyFetchedCotizacionCompra, _cotizacionCompraReturnsNewIfNotFound As Boolean
		Private _ordenCompra As OrdenCompraEntity
		Private _alwaysFetchOrdenCompra, _alreadyFetchedOrdenCompra, _ordenCompraReturnsNewIfNotFound As Boolean
		Private _solicitudProducto As SolicitudProductoEntity
		Private _alwaysFetchSolicitudProducto, _alreadyFetchedSolicitudProducto, _solicitudProductoReturnsNewIfNotFound As Boolean


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
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		Public Sub New(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32)

			InitClassFetch(idOrdenCompra, idProducto, idDetalle, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idOrdenCompra, idProducto, idDetalle, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="validator">The custom validator Object for this OrdenCompraDetalleEntity</param>
		Public Sub New(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, validator As IValidator)

			InitClassFetch(idOrdenCompra, idProducto, idDetalle, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_tipoMoneda = CType(info.GetValue("_tipoMoneda", GetType(TipoMonedaEntity)), TipoMonedaEntity)
			If Not _tipoMoneda Is Nothing Then
				AddHandler _tipoMoneda.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoMonedaReturnsNewIfNotFound = info.GetBoolean("_tipoMonedaReturnsNewIfNotFound")
			_alwaysFetchTipoMoneda = info.GetBoolean("_alwaysFetchTipoMoneda")
			_alreadyFetchedTipoMoneda = info.GetBoolean("_alreadyFetchedTipoMoneda")
			_cotizacionCompra = CType(info.GetValue("_cotizacionCompra", GetType(McomCotizacionCompraEntity)), McomCotizacionCompraEntity)
			If Not _cotizacionCompra Is Nothing Then
				AddHandler _cotizacionCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cotizacionCompraReturnsNewIfNotFound = info.GetBoolean("_cotizacionCompraReturnsNewIfNotFound")
			_alwaysFetchCotizacionCompra = info.GetBoolean("_alwaysFetchCotizacionCompra")
			_alreadyFetchedCotizacionCompra = info.GetBoolean("_alreadyFetchedCotizacionCompra")
			_ordenCompra = CType(info.GetValue("_ordenCompra", GetType(OrdenCompraEntity)), OrdenCompraEntity)
			If Not _ordenCompra Is Nothing Then
				AddHandler _ordenCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_ordenCompraReturnsNewIfNotFound = info.GetBoolean("_ordenCompraReturnsNewIfNotFound")
			_alwaysFetchOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompra")
			_alreadyFetchedOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompra")
			_solicitudProducto = CType(info.GetValue("_solicitudProducto", GetType(SolicitudProductoEntity)), SolicitudProductoEntity)
			If Not _solicitudProducto Is Nothing Then
				AddHandler _solicitudProducto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_solicitudProductoReturnsNewIfNotFound = info.GetBoolean("_solicitudProductoReturnsNewIfNotFound")
			_alwaysFetchSolicitudProducto = info.GetBoolean("_alwaysFetchSolicitudProducto")
			_alreadyFetchedSolicitudProducto = info.GetBoolean("_alreadyFetchedSolicitudProducto")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedTipoMoneda = Not(_tipoMoneda Is Nothing)
			_alreadyFetchedCotizacionCompra = Not(_cotizacionCompra Is Nothing)
			_alreadyFetchedOrdenCompra = Not(_ordenCompra Is Nothing)
			_alreadyFetchedSolicitudProducto = Not(_solicitudProducto Is Nothing)

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


			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_tipoMoneda", _tipoMoneda)
			info.AddValue("_tipoMonedaReturnsNewIfNotFound", _tipoMonedaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoMoneda", _alwaysFetchTipoMoneda)
			info.AddValue("_alreadyFetchedTipoMoneda", _alreadyFetchedTipoMoneda)
			info.AddValue("_cotizacionCompra", _cotizacionCompra)
			info.AddValue("_cotizacionCompraReturnsNewIfNotFound", _cotizacionCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCotizacionCompra", _alwaysFetchCotizacionCompra)
			info.AddValue("_alreadyFetchedCotizacionCompra", _alreadyFetchedCotizacionCompra)
			info.AddValue("_ordenCompra", _ordenCompra)
			info.AddValue("_ordenCompraReturnsNewIfNotFound", _ordenCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchOrdenCompra", _alwaysFetchOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompra", _alreadyFetchedOrdenCompra)
			info.AddValue("_solicitudProducto", _solicitudProducto)
			info.AddValue("_solicitudProductoReturnsNewIfNotFound", _solicitudProductoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSolicitudProducto", _alwaysFetchSolicitudProducto)
			info.AddValue("_alreadyFetchedSolicitudProducto", _alreadyFetchedSolicitudProducto)

			
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
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "TipoMoneda"
					_alreadyFetchedTipoMoneda = True
					Me.TipoMoneda = CType(entity, TipoMonedaEntity)
				Case "CotizacionCompra"
					_alreadyFetchedCotizacionCompra = True
					Me.CotizacionCompra = CType(entity, McomCotizacionCompraEntity)
				Case "OrdenCompra"
					_alreadyFetchedOrdenCompra = True
					Me.OrdenCompra = CType(entity, OrdenCompraEntity)
				Case "SolicitudProducto"
					_alreadyFetchedSolicitudProducto = True
					Me.SolicitudProducto = CType(entity, SolicitudProductoEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoMoneda"
					SetupSyncTipoMoneda(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionCompra"
					SetupSyncCotizacionCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompra"
					SetupSyncOrdenCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SolicitudProducto"
					SetupSyncSolicitudProducto(relatedEntity)
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
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoMoneda"
					DesetupSyncTipoMoneda(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionCompra"
					DesetupSyncCotizacionCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompra"
					DesetupSyncOrdenCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SolicitudProducto"
					DesetupSyncSolicitudProducto(False, True)
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
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If
			If Not _tipoMoneda Is Nothing Then
				toReturn.Add(_tipoMoneda)
			End If
			If Not _cotizacionCompra Is Nothing Then
				toReturn.Add(_cotizacionCompra)
			End If
			If Not _ordenCompra Is Nothing Then
				toReturn.Add(_ordenCompra)
			End If
			If Not _solicitudProducto Is Nothing Then
				toReturn.Add(_solicitudProducto)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()


			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32) As Boolean
			Return FetchUsingPK(idOrdenCompra, idProducto, idDetalle, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idOrdenCompra, idProducto, idDetalle, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idOrdenCompra, idProducto, idDetalle, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdOrdenCompra, Me.IdProducto, Me.IdDetalle, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As OrdenCompraDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As OrdenCompraDetalleFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
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
	
		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda() As TipoMonedaEntity
			Return GetSingleTipoMoneda(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda(forceFetch As Boolean) As TipoMonedaEntity
			If ( Not _alreadyFetchedTipoMoneda Or forceFetch Or _alwaysFetchTipoMoneda) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoMonedaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdMoneda)
				End If
				If Not _tipoMonedaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoMoneda = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoMonedaEntity)
					End If
					Me.TipoMoneda = newEntity
					_alreadyFetchedTipoMoneda = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoMoneda
		End Function
	
		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra() As McomCotizacionCompraEntity
			Return GetSingleCotizacionCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra(forceFetch As Boolean) As McomCotizacionCompraEntity
			If ( Not _alreadyFetchedCotizacionCompra Or forceFetch Or _alwaysFetchCotizacionCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McomCotizacionCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCotizacion.GetValueOrDefault())
				End If
				If Not _cotizacionCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CotizacionCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McomCotizacionCompraEntity)
					End If
					Me.CotizacionCompra = newEntity
					_alreadyFetchedCotizacionCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cotizacionCompra
		End Function
	
		''' <summary>Retrieves the related entity of type 'OrdenCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'OrdenCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleOrdenCompra() As OrdenCompraEntity
			Return GetSingleOrdenCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'OrdenCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'OrdenCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleOrdenCompra(forceFetch As Boolean) As OrdenCompraEntity
			If ( Not _alreadyFetchedOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New OrdenCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdOrdenCompra)
				End If
				If Not _ordenCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.OrdenCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), OrdenCompraEntity)
					End If
					Me.OrdenCompra = newEntity
					_alreadyFetchedOrdenCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _ordenCompra
		End Function
	
		''' <summary>Retrieves the related entity of type 'SolicitudProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SolicitudProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudProducto() As SolicitudProductoEntity
			Return GetSingleSolicitudProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SolicitudProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SolicitudProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudProducto(forceFetch As Boolean) As SolicitudProductoEntity
			If ( Not _alreadyFetchedSolicitudProducto Or forceFetch Or _alwaysFetchSolicitudProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SolicitudProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdSolicitud.GetValueOrDefault())
				End If
				If Not _solicitudProductoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.SolicitudProducto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SolicitudProductoEntity)
					End If
					Me.SolicitudProducto = newEntity
					_alreadyFetchedSolicitudProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _solicitudProducto
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(OrdenCompraDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, OrdenCompraDetalleFieldIndex)
					Case OrdenCompraDetalleFieldIndex.IdOrdenCompra
						DesetupSyncOrdenCompra(True, False)
						_alreadyFetchedOrdenCompra = False
					Case OrdenCompraDetalleFieldIndex.IdProducto
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False

					Case OrdenCompraDetalleFieldIndex.IdCotizacion
						DesetupSyncCotizacionCompra(True, False)
						_alreadyFetchedCotizacionCompra = False


					Case OrdenCompraDetalleFieldIndex.IdMoneda
						DesetupSyncTipoMoneda(True, False)
						_alreadyFetchedTipoMoneda = False







					Case OrdenCompraDetalleFieldIndex.IdSolicitud
						DesetupSyncSolicitudProducto(True, False)
						_alreadyFetchedSolicitudProducto = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoMoneda Is Nothing Then
				_tipoMoneda.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cotizacionCompra Is Nothing Then
				_cotizacionCompra.ActiveContext = MyBase.ActiveContext
			End If
		If Not _ordenCompra Is Nothing Then
				_ordenCompra.ActiveContext = MyBase.ActiveContext
			End If
		If Not _solicitudProducto Is Nothing Then
				_solicitudProducto.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As OrdenCompraDetalleDAO = CType(CreateDAOInstance(), OrdenCompraDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As OrdenCompraDetalleDAO = CType(CreateDAOInstance(), OrdenCompraDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As OrdenCompraDetalleDAO = CType(CreateDAOInstance(), OrdenCompraDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this OrdenCompraDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.OrdenCompraDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="validator">The validator Object for this OrdenCompraDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idOrdenCompra, idProducto, idDetalle, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_tipoMoneda = Nothing
			_tipoMonedaReturnsNewIfNotFound = True
			_alwaysFetchTipoMoneda = False
			_alreadyFetchedTipoMoneda = False
			_cotizacionCompra = Nothing
			_cotizacionCompraReturnsNewIfNotFound = True
			_alwaysFetchCotizacionCompra = False
			_alreadyFetchedCotizacionCompra = False
			_ordenCompra = Nothing
			_ordenCompraReturnsNewIfNotFound = True
			_alwaysFetchOrdenCompra = False
			_alreadyFetchedOrdenCompra = False
			_solicitudProducto = Nothing
			_solicitudProductoReturnsNewIfNotFound = True
			_alwaysFetchSolicitudProducto = False
			_alreadyFetchedSolicitudProducto = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDetalle", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadSolicitada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadOrdenar", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMoneda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantPendientexRecibir", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantRecibida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSolicitud", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, signalRelatedEntity, "OrdenCompraDetalle", resetFKFields, New Integer() { CInt(OrdenCompraDetalleFieldIndex.IdProducto) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, _alreadyFetchedProducto, New String() {  } )
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
		''' <summary>Removes the sync logic for member _tipoMoneda</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoMoneda(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, signalRelatedEntity, "OrdenCompraDetalle", resetFKFields, New Integer() { CInt(OrdenCompraDetalleFieldIndex.IdMoneda) } )
			_tipoMoneda = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMoneda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMoneda(relatedEntity As IEntity)
			DesetupSyncTipoMoneda(True, True)
			_tipoMoneda = CType(relatedEntity, TipoMonedaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, _alreadyFetchedTipoMoneda, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoMonedaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cotizacionCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCotizacionCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, signalRelatedEntity, "OrdenCompraDetalle", resetFKFields, New Integer() { CInt(OrdenCompraDetalleFieldIndex.IdCotizacion) } )
			_cotizacionCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cotizacionCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCotizacionCompra(relatedEntity As IEntity)
			DesetupSyncCotizacionCompra(True, True)
			_cotizacionCompra = CType(relatedEntity, McomCotizacionCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, _alreadyFetchedCotizacionCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCotizacionCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _ordenCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncOrdenCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _ordenCompra, AddressOf OnOrdenCompraPropertyChanged, "OrdenCompra", OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, True, signalRelatedEntity, "OrdenCompraDetalle", resetFKFields, New Integer() { CInt(OrdenCompraDetalleFieldIndex.IdOrdenCompra) } )
			_ordenCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _ordenCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncOrdenCompra(relatedEntity As IEntity)
			DesetupSyncOrdenCompra(True, True)
			_ordenCompra = CType(relatedEntity, OrdenCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _ordenCompra, AddressOf OnOrdenCompraPropertyChanged, "OrdenCompra", OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, True, _alreadyFetchedOrdenCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnOrdenCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _solicitudProducto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSolicitudProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _solicitudProducto, AddressOf OnSolicitudProductoPropertyChanged, "SolicitudProducto", OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, True, signalRelatedEntity, "OrdenCompraDetalle", resetFKFields, New Integer() { CInt(OrdenCompraDetalleFieldIndex.IdSolicitud) } )
			_solicitudProducto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _solicitudProducto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSolicitudProducto(relatedEntity As IEntity)
			DesetupSyncSolicitudProducto(True, True)
			_solicitudProducto = CType(relatedEntity, SolicitudProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _solicitudProducto, AddressOf OnSolicitudProductoPropertyChanged, "SolicitudProducto", OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, True, _alreadyFetchedSolicitudProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSolicitudProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idProducto">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="idDetalle">PK value for OrdenCompraDetalle which data should be fetched into this OrdenCompraDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idOrdenCompra As System.Int32, idProducto As System.Int32, idDetalle As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(OrdenCompraDetalleFieldIndex.IdOrdenCompra)).ForcedCurrentValueWrite(idOrdenCompra)
				MyBase.Fields(CInt(OrdenCompraDetalleFieldIndex.IdProducto)).ForcedCurrentValueWrite(idProducto)
				MyBase.Fields(CInt(OrdenCompraDetalleFieldIndex.IdDetalle)).ForcedCurrentValueWrite(idDetalle)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateOrdenCompraDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New OrdenCompraDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As OrdenCompraDetalleRelations
			Get	
				Return New OrdenCompraDetalleRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMoneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, _
					CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "OrdenCompraDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return OrdenCompraDetalleEntity.CustomProperties
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
				Return OrdenCompraDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdOrdenCompra property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdOrdenCompra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdDetalle property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdDetalle"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdDetalle]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdDetalle, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdDetalle, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCotizacion property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCotizacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdCotizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadSolicitada property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."CantidadSolicitada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadSolicitada]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.CantidadSolicitada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.CantidadSolicitada, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadOrdenar property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."CantidadOrdenar"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadOrdenar]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.CantidadOrdenar, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.CantidadOrdenar, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMoneda property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdMoneda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdMoneda]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdMoneda, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdMoneda, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCambio property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."TipoCambio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCambio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.TipoCambio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.TipoCambio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Precio property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."Precio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Precio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.Precio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.Precio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantPendientexRecibir property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."CantPendientexRecibir"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantPendientexRecibir]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.CantPendientexRecibir, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.CantPendientexRecibir, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantRecibida property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."CantRecibida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantRecibida]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.CantRecibida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.CantRecibida, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdSolicitud property of the Entity OrdenCompraDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompraDetalle"."IdSolicitud"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdSolicitud]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraDetalleFieldIndex.IdSolicitud, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraDetalleFieldIndex.IdSolicitud, Integer), value)
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
							_producto.UnsetRelatedEntity(Me, "OrdenCompraDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompraDetalle")
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
	
		''' <summary>Gets / sets related entity of type 'TipoMonedaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoMoneda()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoMoneda]() As TipoMonedaEntity
			Get
				Return GetSingleTipoMoneda(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoMoneda(value)
				Else
					If value Is Nothing Then
						If Not _tipoMoneda Is Nothing Then
							_tipoMoneda.UnsetRelatedEntity(Me, "OrdenCompraDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompraDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMoneda. When set to true, TipoMoneda is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMoneda is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoMoneda(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMoneda As Boolean
			Get
				Return _alwaysFetchTipoMoneda
			End Get
			Set
				_alwaysFetchTipoMoneda = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoMoneda is not found
		''' in the database. When set to true, TipoMoneda will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoMonedaReturnsNewIfNotFound As Boolean
			Get
				Return _tipoMonedaReturnsNewIfNotFound
			End Get
			Set
				_tipoMonedaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McomCotizacionCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCotizacionCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CotizacionCompra]() As McomCotizacionCompraEntity
			Get
				Return GetSingleCotizacionCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCotizacionCompra(value)
				Else
					If value Is Nothing Then
						If Not _cotizacionCompra Is Nothing Then
							_cotizacionCompra.UnsetRelatedEntity(Me, "OrdenCompraDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompraDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompra. When set to true, CotizacionCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleCotizacionCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompra As Boolean
			Get
				Return _alwaysFetchCotizacionCompra
			End Get
			Set
				_alwaysFetchCotizacionCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CotizacionCompra is not found
		''' in the database. When set to true, CotizacionCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CotizacionCompraReturnsNewIfNotFound As Boolean
			Get
				Return _cotizacionCompraReturnsNewIfNotFound
			End Get
			Set
				_cotizacionCompraReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'OrdenCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [OrdenCompra]() As OrdenCompraEntity
			Get
				Return GetSingleOrdenCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncOrdenCompra(value)
				Else
					If value Is Nothing Then
						If Not _ordenCompra Is Nothing Then
							_ordenCompra.UnsetRelatedEntity(Me, "OrdenCompraDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompraDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompra. When set to true, OrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property OrdenCompra is not found
		''' in the database. When set to true, OrdenCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property OrdenCompraReturnsNewIfNotFound As Boolean
			Get
				Return _ordenCompraReturnsNewIfNotFound
			End Get
			Set
				_ordenCompraReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'SolicitudProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSolicitudProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [SolicitudProducto]() As SolicitudProductoEntity
			Get
				Return GetSingleSolicitudProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSolicitudProducto(value)
				Else
					If value Is Nothing Then
						If Not _solicitudProducto Is Nothing Then
							_solicitudProducto.UnsetRelatedEntity(Me, "OrdenCompraDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompraDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProducto. When set to true, SolicitudProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProducto is accessed. You can always execute
		''' a forced fetch by calling GetSingleSolicitudProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProducto As Boolean
			Get
				Return _alwaysFetchSolicitudProducto
			End Get
			Set
				_alwaysFetchSolicitudProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property SolicitudProducto is not found
		''' in the database. When set to true, SolicitudProducto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SolicitudProductoReturnsNewIfNotFound As Boolean
			Get
				Return _solicitudProductoReturnsNewIfNotFound
			End Get
			Set
				_solicitudProductoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.OrdenCompraDetalleEntity)
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
