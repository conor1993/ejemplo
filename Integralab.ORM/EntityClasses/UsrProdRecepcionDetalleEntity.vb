﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:09
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
	''' <summary>Entity class which represents the entity 'UsrProdRecepcionDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class UsrProdRecepcionDetalleEntity 
#Else
	<Serializable()> _
	Public Class UsrProdRecepcionDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _mcgcatTiposdeGanado As McgcatTiposdeGanadoEntity
		Private _alwaysFetchMcgcatTiposdeGanado, _alreadyFetchedMcgcatTiposdeGanado, _mcgcatTiposdeGanadoReturnsNewIfNotFound As Boolean
		Private _msccatProductos As MsccatProductosEntity
		Private _alwaysFetchMsccatProductos, _alreadyFetchedMsccatProductos, _msccatProductosReturnsNewIfNotFound As Boolean
		Private _recepcionGanado As RecepcionGanadoEntity
		Private _alwaysFetchRecepcionGanado, _alreadyFetchedRecepcionGanado, _recepcionGanadoReturnsNewIfNotFound As Boolean


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
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		Public Sub New(loteRecepcion As System.String, renglon As System.Int32)

			InitClassFetch(loteRecepcion, renglon, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(loteRecepcion As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(loteRecepcion, renglon, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="validator">The custom validator Object for this UsrProdRecepcionDetalleEntity</param>
		Public Sub New(loteRecepcion As System.String, renglon As System.Int32, validator As IValidator)

			InitClassFetch(loteRecepcion, renglon, validator, Nothing)
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
			_mcgcatTiposdeGanado = CType(info.GetValue("_mcgcatTiposdeGanado", GetType(McgcatTiposdeGanadoEntity)), McgcatTiposdeGanadoEntity)
			If Not _mcgcatTiposdeGanado Is Nothing Then
				AddHandler _mcgcatTiposdeGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = info.GetBoolean("_mcgcatTiposdeGanadoReturnsNewIfNotFound")
			_alwaysFetchMcgcatTiposdeGanado = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanado")
			_alreadyFetchedMcgcatTiposdeGanado = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanado")
			_msccatProductos = CType(info.GetValue("_msccatProductos", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductos Is Nothing Then
				AddHandler _msccatProductos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosReturnsNewIfNotFound = info.GetBoolean("_msccatProductosReturnsNewIfNotFound")
			_alwaysFetchMsccatProductos = info.GetBoolean("_alwaysFetchMsccatProductos")
			_alreadyFetchedMsccatProductos = info.GetBoolean("_alreadyFetchedMsccatProductos")
			_recepcionGanado = CType(info.GetValue("_recepcionGanado", GetType(RecepcionGanadoEntity)), RecepcionGanadoEntity)
			If Not _recepcionGanado Is Nothing Then
				AddHandler _recepcionGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_recepcionGanadoReturnsNewIfNotFound = info.GetBoolean("_recepcionGanadoReturnsNewIfNotFound")
			_alwaysFetchRecepcionGanado = info.GetBoolean("_alwaysFetchRecepcionGanado")
			_alreadyFetchedRecepcionGanado = info.GetBoolean("_alreadyFetchedRecepcionGanado")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedMcgcatTiposdeGanado = Not(_mcgcatTiposdeGanado Is Nothing)
			_alreadyFetchedMsccatProductos = Not(_msccatProductos Is Nothing)
			_alreadyFetchedRecepcionGanado = Not(_recepcionGanado Is Nothing)

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
			info.AddValue("_mcgcatTiposdeGanado", _mcgcatTiposdeGanado)
			info.AddValue("_mcgcatTiposdeGanadoReturnsNewIfNotFound", _mcgcatTiposdeGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanado", _alwaysFetchMcgcatTiposdeGanado)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanado", _alreadyFetchedMcgcatTiposdeGanado)
			info.AddValue("_msccatProductos", _msccatProductos)
			info.AddValue("_msccatProductosReturnsNewIfNotFound", _msccatProductosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductos", _alwaysFetchMsccatProductos)
			info.AddValue("_alreadyFetchedMsccatProductos", _alreadyFetchedMsccatProductos)
			info.AddValue("_recepcionGanado", _recepcionGanado)
			info.AddValue("_recepcionGanadoReturnsNewIfNotFound", _recepcionGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchRecepcionGanado", _alwaysFetchRecepcionGanado)
			info.AddValue("_alreadyFetchedRecepcionGanado", _alreadyFetchedRecepcionGanado)

			
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
				Case "McgcatTiposdeGanado"
					_alreadyFetchedMcgcatTiposdeGanado = True
					Me.McgcatTiposdeGanado = CType(entity, McgcatTiposdeGanadoEntity)
				Case "MsccatProductos"
					_alreadyFetchedMsccatProductos = True
					Me.MsccatProductos = CType(entity, MsccatProductosEntity)
				Case "RecepcionGanado"
					_alreadyFetchedRecepcionGanado = True
					Me.RecepcionGanado = CType(entity, RecepcionGanadoEntity)



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
				Case "McgcatTiposdeGanado"
					SetupSyncMcgcatTiposdeGanado(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductos"
					SetupSyncMsccatProductos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionGanado"
					SetupSyncRecepcionGanado(relatedEntity)
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
				Case "McgcatTiposdeGanado"
					DesetupSyncMcgcatTiposdeGanado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductos"
					DesetupSyncMsccatProductos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionGanado"
					DesetupSyncRecepcionGanado(False, True)
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
			If Not _mcgcatTiposdeGanado Is Nothing Then
				toReturn.Add(_mcgcatTiposdeGanado)
			End If
			If Not _msccatProductos Is Nothing Then
				toReturn.Add(_msccatProductos)
			End If
			If Not _recepcionGanado Is Nothing Then
				toReturn.Add(_recepcionGanado)
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
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String, renglon As System.Int32) As Boolean
			Return FetchUsingPK(loteRecepcion, renglon, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(loteRecepcion, renglon, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteRecepcion As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(loteRecepcion, renglon, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.LoteRecepcion, Me.Renglon, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As UsrProdRecepcionDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As UsrProdRecepcionDetalleFieldIndex) As Boolean
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
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto.GetValueOrDefault())
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
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdTipoGanado.GetValueOrDefault())
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
	
		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos() As MsccatProductosEntity
			Return GetSingleMsccatProductos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductos Or forceFetch Or _alwaysFetchMsccatProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto.GetValueOrDefault())
				End If
				If Not _msccatProductosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductos = newEntity
					_alreadyFetchedMsccatProductos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductos
		End Function
	
		''' <summary>Retrieves the related entity of type 'RecepcionGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'RecepcionGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRecepcionGanado() As RecepcionGanadoEntity
			Return GetSingleRecepcionGanado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'RecepcionGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'RecepcionGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRecepcionGanado(forceFetch As Boolean) As RecepcionGanadoEntity
			If ( Not _alreadyFetchedRecepcionGanado Or forceFetch Or _alwaysFetchRecepcionGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New RecepcionGanadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion) Then
					fetchResult = newEntity.FetchUsingPK(Me.LoteRecepcion)
				End If
				If Not _recepcionGanadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.RecepcionGanado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), RecepcionGanadoEntity)
					End If
					Me.RecepcionGanado = newEntity
					_alreadyFetchedRecepcionGanado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _recepcionGanado
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(UsrProdRecepcionDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, UsrProdRecepcionDetalleFieldIndex)
					Case UsrProdRecepcionDetalleFieldIndex.LoteRecepcion
						DesetupSyncRecepcionGanado(True, False)
						_alreadyFetchedRecepcionGanado = False

					Case UsrProdRecepcionDetalleFieldIndex.IdTipoGanado
						DesetupSyncMcgcatTiposdeGanado(True, False)
						_alreadyFetchedMcgcatTiposdeGanado = False
					Case UsrProdRecepcionDetalleFieldIndex.IdProducto
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False
						DesetupSyncMsccatProductos(True, False)
						_alreadyFetchedMsccatProductos = False


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
		If Not _mcgcatTiposdeGanado Is Nothing Then
				_mcgcatTiposdeGanado.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatProductos Is Nothing Then
				_msccatProductos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _recepcionGanado Is Nothing Then
				_recepcionGanado.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As UsrProdRecepcionDetalleDAO = CType(CreateDAOInstance(), UsrProdRecepcionDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As UsrProdRecepcionDetalleDAO = CType(CreateDAOInstance(), UsrProdRecepcionDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As UsrProdRecepcionDetalleDAO = CType(CreateDAOInstance(), UsrProdRecepcionDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this UsrProdRecepcionDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="validator">The validator Object for this UsrProdRecepcionDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(loteRecepcion As System.String, renglon As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(loteRecepcion, renglon, prefetchPathToUse, Nothing)
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
			_mcgcatTiposdeGanado = Nothing
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = True
			_alwaysFetchMcgcatTiposdeGanado = False
			_alreadyFetchedMcgcatTiposdeGanado = False
			_msccatProductos = Nothing
			_msccatProductosReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductos = False
			_alreadyFetchedMsccatProductos = False
			_recepcionGanado = Nothing
			_recepcionGanadoReturnsNewIfNotFound = True
			_alwaysFetchRecepcionGanado = False
			_alreadyFetchedRecepcionGanado = False

			
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

			_fieldsCustomProperties.Add("Renglon", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionProducto", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, signalRelatedEntity, "UsrProdRecepcionDetalle", resetFKFields, New Integer() { CInt(UsrProdRecepcionDetalleFieldIndex.IdProducto) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, _alreadyFetchedProducto, New String() {  } )
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
		''' <summary>Removes the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatTiposdeGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, True, signalRelatedEntity, "UsrProdRecepcionDetalle", resetFKFields, New Integer() { CInt(UsrProdRecepcionDetalleFieldIndex.IdTipoGanado) } )
			_mcgcatTiposdeGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatTiposdeGanado(relatedEntity As IEntity)
			DesetupSyncMcgcatTiposdeGanado(True, True)
			_mcgcatTiposdeGanado = CType(relatedEntity, McgcatTiposdeGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, True, _alreadyFetchedMcgcatTiposdeGanado, New String() {  } )
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
		''' <summary>Removes the sync logic for member _msccatProductos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, True, signalRelatedEntity, "UsrProdRecepcionDetalle", resetFKFields, New Integer() { CInt(UsrProdRecepcionDetalleFieldIndex.IdProducto) } )
			_msccatProductos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductos(relatedEntity As IEntity)
			DesetupSyncMsccatProductos(True, True)
			_msccatProductos = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, True, _alreadyFetchedMsccatProductos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _recepcionGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncRecepcionGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _recepcionGanado, AddressOf OnRecepcionGanadoPropertyChanged, "RecepcionGanado", UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, True, signalRelatedEntity, "UsrProdRecepcionDetalle", resetFKFields, New Integer() { CInt(UsrProdRecepcionDetalleFieldIndex.LoteRecepcion) } )
			_recepcionGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _recepcionGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncRecepcionGanado(relatedEntity As IEntity)
			DesetupSyncRecepcionGanado(True, True)
			_recepcionGanado = CType(relatedEntity, RecepcionGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _recepcionGanado, AddressOf OnRecepcionGanadoPropertyChanged, "RecepcionGanado", UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, True, _alreadyFetchedRecepcionGanado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnRecepcionGanadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="loteRecepcion">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="renglon">PK value for UsrProdRecepcionDetalle which data should be fetched into this UsrProdRecepcionDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(loteRecepcion As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(UsrProdRecepcionDetalleFieldIndex.LoteRecepcion)).ForcedCurrentValueWrite(loteRecepcion)
				MyBase.Fields(CInt(UsrProdRecepcionDetalleFieldIndex.Renglon)).ForcedCurrentValueWrite(renglon)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateUsrProdRecepcionDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New UsrProdRecepcionDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As UsrProdRecepcionDetalleRelations
			Get	
				Return New UsrProdRecepcionDetalleRelations() 
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
					UsrProdRecepcionDetalleEntity.Relations.ProductoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					UsrProdRecepcionDetalleEntity.Relations.McgcatTiposdeGanadoEntityUsingIdTipoGanado, _
					CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatTiposdeGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					UsrProdRecepcionDetalleEntity.Relations.MsccatProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					UsrProdRecepcionDetalleEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, _
					CType(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "UsrProdRecepcionDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return UsrProdRecepcionDetalleEntity.CustomProperties
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
				Return UsrProdRecepcionDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The LoteRecepcion property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."LoteRecepcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [LoteRecepcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.LoteRecepcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.LoteRecepcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Renglon property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."Renglon"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Renglon]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.Renglon, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.Renglon, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdTipoGanado property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."IdTipoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdTipoGanado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.IdTipoGanado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.IdTipoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.IdProducto, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabezas property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."CantCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CantCabezas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.CantCabezas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.CantCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionProducto property of the Entity UsrProdRecepcionDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRecepcionDetalle"."DescripcionProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DescripcionProducto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.DescripcionProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdRecepcionDetalleFieldIndex.DescripcionProducto, Integer), value)
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
							_producto.UnsetRelatedEntity(Me, "UsrProdRecepcionDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrProdRecepcionDetalle")
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
							_mcgcatTiposdeGanado.UnsetRelatedEntity(Me, "UsrProdRecepcionDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrProdRecepcionDetalle")
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
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductos]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductos(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductos Is Nothing Then
							_msccatProductos.UnsetRelatedEntity(Me, "UsrProdRecepcionDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrProdRecepcionDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductos. When set to true, MsccatProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductos is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductos
			End Get
			Set
				_alwaysFetchMsccatProductos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductos is not found
		''' in the database. When set to true, MsccatProductos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'RecepcionGanadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRecepcionGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [RecepcionGanado]() As RecepcionGanadoEntity
			Get
				Return GetSingleRecepcionGanado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncRecepcionGanado(value)
				Else
					If value Is Nothing Then
						If Not _recepcionGanado Is Nothing Then
							_recepcionGanado.UnsetRelatedEntity(Me, "UsrProdRecepcionDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrProdRecepcionDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanado. When set to true, RecepcionGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanado is accessed. You can always execute
		''' a forced fetch by calling GetSingleRecepcionGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanado As Boolean
			Get
				Return _alwaysFetchRecepcionGanado
			End Get
			Set
				_alwaysFetchRecepcionGanado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property RecepcionGanado is not found
		''' in the database. When set to true, RecepcionGanado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property RecepcionGanadoReturnsNewIfNotFound As Boolean
			Get
				Return _recepcionGanadoReturnsNewIfNotFound
			End Get
			Set
				_recepcionGanadoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.UsrProdRecepcionDetalleEntity)
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
