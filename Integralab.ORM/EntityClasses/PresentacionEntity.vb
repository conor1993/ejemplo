﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:02
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
	''' <summary>Entity class which represents the entity 'Presentacion'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PresentacionEntity 
#Else
	<Serializable()> _
	Public Class PresentacionEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _producto As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProducto, _alreadyFetchedProducto As Boolean
		Private _lineaCollectionViaProducto As Integralab.ORM.CollectionClasses.LineaCollection
		Private _alwaysFetchLineaCollectionViaProducto, _alreadyFetchedLineaCollectionViaProducto As Boolean
		Private _tipoProductoCollectionViaProducto As Integralab.ORM.CollectionClasses.TipoProductoCollection
		Private _alwaysFetchTipoProductoCollectionViaProducto, _alreadyFetchedTipoProductoCollectionViaProducto As Boolean
		Private _unidadMedidaCollectionViaProducto As Integralab.ORM.CollectionClasses.UnidadMedidaCollection
		Private _alwaysFetchUnidadMedidaCollectionViaProducto, _alreadyFetchedUnidadMedidaCollectionViaProducto As Boolean
		Private _marcaCollectionViaProducto As Integralab.ORM.CollectionClasses.MarcaCollection
		Private _alwaysFetchMarcaCollectionViaProducto, _alreadyFetchedMarcaCollectionViaProducto As Boolean
		Private _unidadMedida As UnidadMedidaEntity
		Private _alwaysFetchUnidadMedida, _alreadyFetchedUnidadMedida, _unidadMedidaReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <param name="validator">The custom validator Object for this PresentacionEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_producto = CType(info.GetValue("_producto", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_lineaCollectionViaProducto = CType(info.GetValue("_lineaCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.LineaCollection)), Integralab.ORM.CollectionClasses.LineaCollection)
			_alwaysFetchLineaCollectionViaProducto = info.GetBoolean("_alwaysFetchLineaCollectionViaProducto")
			_alreadyFetchedLineaCollectionViaProducto = info.GetBoolean("_alreadyFetchedLineaCollectionViaProducto")
			_tipoProductoCollectionViaProducto = CType(info.GetValue("_tipoProductoCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.TipoProductoCollection)), Integralab.ORM.CollectionClasses.TipoProductoCollection)
			_alwaysFetchTipoProductoCollectionViaProducto = info.GetBoolean("_alwaysFetchTipoProductoCollectionViaProducto")
			_alreadyFetchedTipoProductoCollectionViaProducto = info.GetBoolean("_alreadyFetchedTipoProductoCollectionViaProducto")
			_unidadMedidaCollectionViaProducto = CType(info.GetValue("_unidadMedidaCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.UnidadMedidaCollection)), Integralab.ORM.CollectionClasses.UnidadMedidaCollection)
			_alwaysFetchUnidadMedidaCollectionViaProducto = info.GetBoolean("_alwaysFetchUnidadMedidaCollectionViaProducto")
			_alreadyFetchedUnidadMedidaCollectionViaProducto = info.GetBoolean("_alreadyFetchedUnidadMedidaCollectionViaProducto")
			_marcaCollectionViaProducto = CType(info.GetValue("_marcaCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.MarcaCollection)), Integralab.ORM.CollectionClasses.MarcaCollection)
			_alwaysFetchMarcaCollectionViaProducto = info.GetBoolean("_alwaysFetchMarcaCollectionViaProducto")
			_alreadyFetchedMarcaCollectionViaProducto = info.GetBoolean("_alreadyFetchedMarcaCollectionViaProducto")
			_unidadMedida = CType(info.GetValue("_unidadMedida", GetType(UnidadMedidaEntity)), UnidadMedidaEntity)
			If Not _unidadMedida Is Nothing Then
				AddHandler _unidadMedida.AfterSave, AddressOf OnEntityAfterSave
			End If
			_unidadMedidaReturnsNewIfNotFound = info.GetBoolean("_unidadMedidaReturnsNewIfNotFound")
			_alwaysFetchUnidadMedida = info.GetBoolean("_alwaysFetchUnidadMedida")
			_alreadyFetchedUnidadMedida = info.GetBoolean("_alreadyFetchedUnidadMedida")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedProducto = (_producto.Count > 0)
			_alreadyFetchedLineaCollectionViaProducto = (_lineaCollectionViaProducto.Count > 0)
			_alreadyFetchedTipoProductoCollectionViaProducto = (_tipoProductoCollectionViaProducto.Count > 0)
			_alreadyFetchedUnidadMedidaCollectionViaProducto = (_unidadMedidaCollectionViaProducto.Count > 0)
			_alreadyFetchedMarcaCollectionViaProducto = (_marcaCollectionViaProducto.Count > 0)
			_alreadyFetchedUnidadMedida = Not(_unidadMedida Is Nothing)

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
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_lineaCollectionViaProducto", _lineaCollectionViaProducto)
			info.AddValue("_alwaysFetchLineaCollectionViaProducto", _alwaysFetchLineaCollectionViaProducto)
			info.AddValue("_alreadyFetchedLineaCollectionViaProducto", _alreadyFetchedLineaCollectionViaProducto)
			info.AddValue("_tipoProductoCollectionViaProducto", _tipoProductoCollectionViaProducto)
			info.AddValue("_alwaysFetchTipoProductoCollectionViaProducto", _alwaysFetchTipoProductoCollectionViaProducto)
			info.AddValue("_alreadyFetchedTipoProductoCollectionViaProducto", _alreadyFetchedTipoProductoCollectionViaProducto)
			info.AddValue("_unidadMedidaCollectionViaProducto", _unidadMedidaCollectionViaProducto)
			info.AddValue("_alwaysFetchUnidadMedidaCollectionViaProducto", _alwaysFetchUnidadMedidaCollectionViaProducto)
			info.AddValue("_alreadyFetchedUnidadMedidaCollectionViaProducto", _alreadyFetchedUnidadMedidaCollectionViaProducto)
			info.AddValue("_marcaCollectionViaProducto", _marcaCollectionViaProducto)
			info.AddValue("_alwaysFetchMarcaCollectionViaProducto", _alwaysFetchMarcaCollectionViaProducto)
			info.AddValue("_alreadyFetchedMarcaCollectionViaProducto", _alreadyFetchedMarcaCollectionViaProducto)
			info.AddValue("_unidadMedida", _unidadMedida)
			info.AddValue("_unidadMedidaReturnsNewIfNotFound", _unidadMedidaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchUnidadMedida", _alwaysFetchUnidadMedida)
			info.AddValue("_alreadyFetchedUnidadMedida", _alreadyFetchedUnidadMedida)

			
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
				Case "UnidadMedida"
					_alreadyFetchedUnidadMedida = True
					Me.UnidadMedida = CType(entity, UnidadMedidaEntity)
				Case "Producto"
					_alreadyFetchedProducto = True
					If Not entity Is Nothing Then
						Me.Producto.Add(CType(entity, ProductoEntity))
					End If
				Case "LineaCollectionViaProducto"
					_alreadyFetchedLineaCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.LineaCollectionViaProducto.Add(CType(entity, LineaEntity))
					End If
				Case "TipoProductoCollectionViaProducto"
					_alreadyFetchedTipoProductoCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.TipoProductoCollectionViaProducto.Add(CType(entity, TipoProductoEntity))
					End If
				Case "UnidadMedidaCollectionViaProducto"
					_alreadyFetchedUnidadMedidaCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.UnidadMedidaCollectionViaProducto.Add(CType(entity, UnidadMedidaEntity))
					End If
				Case "MarcaCollectionViaProducto"
					_alreadyFetchedMarcaCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.MarcaCollectionViaProducto.Add(CType(entity, MarcaEntity))
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
				Case "UnidadMedida"
					SetupSyncUnidadMedida(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Producto"
					_producto.Add(CType(relatedEntity, ProductoEntity))
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
				Case "UnidadMedida"
					DesetupSyncUnidadMedida(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Producto"
					MyBase.PerformRelatedEntityRemoval(_producto, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _unidadMedida Is Nothing Then
				toReturn.Add(_unidadMedida)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_producto)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PresentacionFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PresentacionFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProducto(forceFetch, _producto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProducto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProducto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProducto(forceFetch, _producto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _producto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_producto)
					End If
				End If
				_producto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_producto.EntityFactoryToUse = entityFactoryToUse
				End If
				_producto.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_producto.SuppressClearInGetMulti = False
				_alreadyFetchedProducto = True
			End If
			Return _producto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Producto'. These settings will be taken into account
		''' when the property Producto is requested or GetMultiProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_producto.SortClauses=sortClauses
			_producto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'LineaEntity'</returns>
		Public Function GetMultiLineaCollectionViaProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.LineaCollection
			Return GetMultiLineaCollectionViaProducto(forceFetch, _lineaCollectionViaProducto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiLineaCollectionViaProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.LineaCollection
			If ( Not _alreadyFetchedLineaCollectionViaProducto Or forceFetch Or _alwaysFetchLineaCollectionViaProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _lineaCollectionViaProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_lineaCollectionViaProducto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.LineaEntityUsingPdIdLinea, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PresentacionFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_lineaCollectionViaProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_lineaCollectionViaProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_lineaCollectionViaProducto.GetMulti(Filter, relations)
				_lineaCollectionViaProducto.SuppressClearInGetMulti = False
				_alreadyFetchedLineaCollectionViaProducto = True
			End If
			Return _lineaCollectionViaProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'LineaCollectionViaProducto'. These settings will be taken into account
		''' when the property LineaCollectionViaProducto is requested or GetMultiLineaCollectionViaProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersLineaCollectionViaProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_lineaCollectionViaProducto.SortClauses=sortClauses
			_lineaCollectionViaProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoProductoEntity'</returns>
		Public Function GetMultiTipoProductoCollectionViaProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoProductoCollection
			Return GetMultiTipoProductoCollectionViaProducto(forceFetch, _tipoProductoCollectionViaProducto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoProductoCollectionViaProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoProductoCollection
			If ( Not _alreadyFetchedTipoProductoCollectionViaProducto Or forceFetch Or _alwaysFetchTipoProductoCollectionViaProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoProductoCollectionViaProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoProductoCollectionViaProducto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PresentacionFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_tipoProductoCollectionViaProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoProductoCollectionViaProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoProductoCollectionViaProducto.GetMulti(Filter, relations)
				_tipoProductoCollectionViaProducto.SuppressClearInGetMulti = False
				_alreadyFetchedTipoProductoCollectionViaProducto = True
			End If
			Return _tipoProductoCollectionViaProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoProductoCollectionViaProducto'. These settings will be taken into account
		''' when the property TipoProductoCollectionViaProducto is requested or GetMultiTipoProductoCollectionViaProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoProductoCollectionViaProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoProductoCollectionViaProducto.SortClauses=sortClauses
			_tipoProductoCollectionViaProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'UnidadMedidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UnidadMedidaEntity'</returns>
		Public Function GetMultiUnidadMedidaCollectionViaProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UnidadMedidaCollection
			Return GetMultiUnidadMedidaCollectionViaProducto(forceFetch, _unidadMedidaCollectionViaProducto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'UnidadMedidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUnidadMedidaCollectionViaProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UnidadMedidaCollection
			If ( Not _alreadyFetchedUnidadMedidaCollectionViaProducto Or forceFetch Or _alwaysFetchUnidadMedidaCollectionViaProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _unidadMedidaCollectionViaProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_unidadMedidaCollectionViaProducto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PresentacionFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_unidadMedidaCollectionViaProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_unidadMedidaCollectionViaProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_unidadMedidaCollectionViaProducto.GetMulti(Filter, relations)
				_unidadMedidaCollectionViaProducto.SuppressClearInGetMulti = False
				_alreadyFetchedUnidadMedidaCollectionViaProducto = True
			End If
			Return _unidadMedidaCollectionViaProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UnidadMedidaCollectionViaProducto'. These settings will be taken into account
		''' when the property UnidadMedidaCollectionViaProducto is requested or GetMultiUnidadMedidaCollectionViaProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUnidadMedidaCollectionViaProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_unidadMedidaCollectionViaProducto.SortClauses=sortClauses
			_unidadMedidaCollectionViaProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MarcaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MarcaEntity'</returns>
		Public Function GetMultiMarcaCollectionViaProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MarcaCollection
			Return GetMultiMarcaCollectionViaProducto(forceFetch, _marcaCollectionViaProducto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MarcaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMarcaCollectionViaProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MarcaCollection
			If ( Not _alreadyFetchedMarcaCollectionViaProducto Or forceFetch Or _alwaysFetchMarcaCollectionViaProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _marcaCollectionViaProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_marcaCollectionViaProducto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.MarcaEntityUsingCodigoMarca, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PresentacionFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_marcaCollectionViaProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_marcaCollectionViaProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_marcaCollectionViaProducto.GetMulti(Filter, relations)
				_marcaCollectionViaProducto.SuppressClearInGetMulti = False
				_alreadyFetchedMarcaCollectionViaProducto = True
			End If
			Return _marcaCollectionViaProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MarcaCollectionViaProducto'. These settings will be taken into account
		''' when the property MarcaCollectionViaProducto is requested or GetMultiMarcaCollectionViaProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMarcaCollectionViaProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_marcaCollectionViaProducto.SortClauses=sortClauses
			_marcaCollectionViaProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida() As UnidadMedidaEntity
			Return GetSingleUnidadMedida(False)
		End Function

		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida(forceFetch As Boolean) As UnidadMedidaEntity
			If ( Not _alreadyFetchedUnidadMedida Or forceFetch Or _alwaysFetchUnidadMedida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New UnidadMedidaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PresentacionEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoUnidadMedida)
				End If
				If Not _unidadMedidaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.UnidadMedida = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), UnidadMedidaEntity)
					End If
					Me.UnidadMedida = newEntity
					_alreadyFetchedUnidadMedida = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _unidadMedida
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PresentacionFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PresentacionFieldIndex)




					Case PresentacionFieldIndex.CodigoUnidadMedida
						DesetupSyncUnidadMedida(True, False)
						_alreadyFetchedUnidadMedida = False








					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_producto.ActiveContext = MyBase.ActiveContext
			_lineaCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_tipoProductoCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_unidadMedidaCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_marcaCollectionViaProducto.ActiveContext = MyBase.ActiveContext
		If Not _unidadMedida Is Nothing Then
				_unidadMedida.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PresentacionDAO = CType(CreateDAOInstance(), PresentacionDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PresentacionDAO = CType(CreateDAOInstance(), PresentacionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PresentacionDAO = CType(CreateDAOInstance(), PresentacionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PresentacionEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PresentacionEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <param name="validator">The validator Object for this PresentacionEntity</param>
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
			_producto = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_producto.SetContainingEntityInfo(Me, "Presentacion")
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_lineaCollectionViaProducto = New Integralab.ORM.CollectionClasses.LineaCollection(New LineaEntityFactory())
			_alwaysFetchLineaCollectionViaProducto = False
			_alreadyFetchedLineaCollectionViaProducto = False
			_tipoProductoCollectionViaProducto = New Integralab.ORM.CollectionClasses.TipoProductoCollection(New TipoProductoEntityFactory())
			_alwaysFetchTipoProductoCollectionViaProducto = False
			_alreadyFetchedTipoProductoCollectionViaProducto = False
			_unidadMedidaCollectionViaProducto = New Integralab.ORM.CollectionClasses.UnidadMedidaCollection(New UnidadMedidaEntityFactory())
			_alwaysFetchUnidadMedidaCollectionViaProducto = False
			_alreadyFetchedUnidadMedidaCollectionViaProducto = False
			_marcaCollectionViaProducto = New Integralab.ORM.CollectionClasses.MarcaCollection(New MarcaEntityFactory())
			_alwaysFetchMarcaCollectionViaProducto = False
			_alreadyFetchedMarcaCollectionViaProducto = False
			_unidadMedida = Nothing
			_unidadMedidaReturnsNewIfNotFound = True
			_alwaysFetchUnidadMedida = False
			_alreadyFetchedUnidadMedida = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoUnidadMedida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionBaja", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _unidadMedida</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncUnidadMedida(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", PresentacionEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, True, signalRelatedEntity, "Presentacion", resetFKFields, New Integer() { CInt(PresentacionFieldIndex.CodigoUnidadMedida) } )
			_unidadMedida = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _unidadMedida</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncUnidadMedida(relatedEntity As IEntity)
			DesetupSyncUnidadMedida(True, True)
			_unidadMedida = CType(relatedEntity, UnidadMedidaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", PresentacionEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, True, _alreadyFetchedUnidadMedida, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnUnidadMedidaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Presentacion which data should be fetched into this Presentacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PresentacionFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePresentacionDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PresentacionEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PresentacionRelations
			Get	
				Return New PresentacionRelations() 
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
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Linea' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathLineaCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.LineaCollection(), _
					PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.LineaEntity, Integer), 0, Nothing, Nothing, relations, "LineaCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoProductoCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoProductoCollection(), _
					PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.TipoProductoEntity, Integer), 0, Nothing, Nothing, relations, "TipoProductoCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnidadMedida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUnidadMedidaCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UnidadMedidaCollection(), _
					PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), 0, Nothing, Nothing, relations, "UnidadMedidaCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Marca' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMarcaCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, "__PresentacionEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.MarcaEntityUsingCodigoMarca)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MarcaCollection(), _
					PresentacionEntity.Relations.ProductoEntityUsingCodigoPresentacion, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.MarcaEntity, Integer), 0, Nothing, Nothing, relations, "MarcaCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnidadMedida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUnidadMedida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UnidadMedidaCollection(), _
					PresentacionEntity.Relations.UnidadMedidaEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), 0, Nothing, Nothing, Nothing, "UnidadMedida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PresentacionEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PresentacionEntity.CustomProperties
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
				Return PresentacionEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrIdPresentacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrNombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrNombreC"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrCant"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.Cantidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoUnidadMedida property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrIdUniMed"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoUnidadMedida]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.CodigoUnidadMedida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.CodigoUnidadMedida, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observacion property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrObservacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 255<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.Observacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.Observacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionBaja property of the Entity Presentacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompPresentacion"."PrObservacionBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresentacionFieldIndex.ObservacionBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresentacionFieldIndex.ObservacionBaja, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Producto]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetMultiProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'LineaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLineaCollectionViaProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [LineaCollectionViaProducto]() As Integralab.ORM.CollectionClasses.LineaCollection
			Get
				Return GetMultiLineaCollectionViaProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for LineaCollectionViaProducto. When set to true, LineaCollectionViaProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time LineaCollectionViaProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiLineaCollectionViaProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchLineaCollectionViaProducto As Boolean
			Get
				Return _alwaysFetchLineaCollectionViaProducto
			End Get
			Set
				_alwaysFetchLineaCollectionViaProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoProductoCollectionViaProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoProductoCollectionViaProducto]() As Integralab.ORM.CollectionClasses.TipoProductoCollection
			Get
				Return GetMultiTipoProductoCollectionViaProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoProductoCollectionViaProducto. When set to true, TipoProductoCollectionViaProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoProductoCollectionViaProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoProductoCollectionViaProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoProductoCollectionViaProducto As Boolean
			Get
				Return _alwaysFetchTipoProductoCollectionViaProducto
			End Get
			Set
				_alwaysFetchTipoProductoCollectionViaProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UnidadMedidaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnidadMedidaCollectionViaProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UnidadMedidaCollectionViaProducto]() As Integralab.ORM.CollectionClasses.UnidadMedidaCollection
			Get
				Return GetMultiUnidadMedidaCollectionViaProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UnidadMedidaCollectionViaProducto. When set to true, UnidadMedidaCollectionViaProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UnidadMedidaCollectionViaProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiUnidadMedidaCollectionViaProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUnidadMedidaCollectionViaProducto As Boolean
			Get
				Return _alwaysFetchUnidadMedidaCollectionViaProducto
			End Get
			Set
				_alwaysFetchUnidadMedidaCollectionViaProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MarcaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMarcaCollectionViaProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MarcaCollectionViaProducto]() As Integralab.ORM.CollectionClasses.MarcaCollection
			Get
				Return GetMultiMarcaCollectionViaProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MarcaCollectionViaProducto. When set to true, MarcaCollectionViaProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MarcaCollectionViaProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiMarcaCollectionViaProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMarcaCollectionViaProducto As Boolean
			Get
				Return _alwaysFetchMarcaCollectionViaProducto
			End Get
			Set
				_alwaysFetchMarcaCollectionViaProducto = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'UnidadMedidaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnidadMedida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [UnidadMedida]() As UnidadMedidaEntity
			Get
				Return GetSingleUnidadMedida(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncUnidadMedida(value)
				Else
					If value Is Nothing Then
						If Not _unidadMedida Is Nothing Then
							_unidadMedida.UnsetRelatedEntity(Me, "Presentacion")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Presentacion")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for UnidadMedida. When set to true, UnidadMedida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UnidadMedida is accessed. You can always execute
		''' a forced fetch by calling GetSingleUnidadMedida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUnidadMedida As Boolean
			Get
				Return _alwaysFetchUnidadMedida
			End Get
			Set
				_alwaysFetchUnidadMedida = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property UnidadMedida is not found
		''' in the database. When set to true, UnidadMedida will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property UnidadMedidaReturnsNewIfNotFound As Boolean
			Get
				Return _unidadMedidaReturnsNewIfNotFound
			End Get
			Set
				_unidadMedidaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.PresentacionEntity)
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
