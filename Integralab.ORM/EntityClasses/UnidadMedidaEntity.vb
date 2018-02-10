' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:07
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
	''' <summary>Entity class which represents the entity 'UnidadMedida'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class UnidadMedidaEntity 
#Else
	<Serializable()> _
	Public Class UnidadMedidaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _catNutrientes As Integralab.ORM.CollectionClasses.CatNutrientesCollection
		Private _alwaysFetchCatNutrientes, _alreadyFetchedCatNutrientes As Boolean
		Private _presentacion As Integralab.ORM.CollectionClasses.PresentacionCollection
		Private _alwaysFetchPresentacion, _alreadyFetchedPresentacion As Boolean
		Private _producto As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProducto, _alreadyFetchedProducto As Boolean
		Private _lineaCollectionViaProducto As Integralab.ORM.CollectionClasses.LineaCollection
		Private _alwaysFetchLineaCollectionViaProducto, _alreadyFetchedLineaCollectionViaProducto As Boolean
		Private _presentacionCollectionViaProducto As Integralab.ORM.CollectionClasses.PresentacionCollection
		Private _alwaysFetchPresentacionCollectionViaProducto, _alreadyFetchedPresentacionCollectionViaProducto As Boolean
		Private _tipoProductoCollectionViaProducto As Integralab.ORM.CollectionClasses.TipoProductoCollection
		Private _alwaysFetchTipoProductoCollectionViaProducto, _alreadyFetchedTipoProductoCollectionViaProducto As Boolean
		Private _marcaCollectionViaProducto As Integralab.ORM.CollectionClasses.MarcaCollection
		Private _alwaysFetchMarcaCollectionViaProducto, _alreadyFetchedMarcaCollectionViaProducto As Boolean



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
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <param name="validator">The custom validator Object for this UnidadMedidaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_catNutrientes = CType(info.GetValue("_catNutrientes", GetType(Integralab.ORM.CollectionClasses.CatNutrientesCollection)), Integralab.ORM.CollectionClasses.CatNutrientesCollection)
			_alwaysFetchCatNutrientes = info.GetBoolean("_alwaysFetchCatNutrientes")
			_alreadyFetchedCatNutrientes = info.GetBoolean("_alreadyFetchedCatNutrientes")
			_presentacion = CType(info.GetValue("_presentacion", GetType(Integralab.ORM.CollectionClasses.PresentacionCollection)), Integralab.ORM.CollectionClasses.PresentacionCollection)
			_alwaysFetchPresentacion = info.GetBoolean("_alwaysFetchPresentacion")
			_alreadyFetchedPresentacion = info.GetBoolean("_alreadyFetchedPresentacion")
			_producto = CType(info.GetValue("_producto", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_lineaCollectionViaProducto = CType(info.GetValue("_lineaCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.LineaCollection)), Integralab.ORM.CollectionClasses.LineaCollection)
			_alwaysFetchLineaCollectionViaProducto = info.GetBoolean("_alwaysFetchLineaCollectionViaProducto")
			_alreadyFetchedLineaCollectionViaProducto = info.GetBoolean("_alreadyFetchedLineaCollectionViaProducto")
			_presentacionCollectionViaProducto = CType(info.GetValue("_presentacionCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.PresentacionCollection)), Integralab.ORM.CollectionClasses.PresentacionCollection)
			_alwaysFetchPresentacionCollectionViaProducto = info.GetBoolean("_alwaysFetchPresentacionCollectionViaProducto")
			_alreadyFetchedPresentacionCollectionViaProducto = info.GetBoolean("_alreadyFetchedPresentacionCollectionViaProducto")
			_tipoProductoCollectionViaProducto = CType(info.GetValue("_tipoProductoCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.TipoProductoCollection)), Integralab.ORM.CollectionClasses.TipoProductoCollection)
			_alwaysFetchTipoProductoCollectionViaProducto = info.GetBoolean("_alwaysFetchTipoProductoCollectionViaProducto")
			_alreadyFetchedTipoProductoCollectionViaProducto = info.GetBoolean("_alreadyFetchedTipoProductoCollectionViaProducto")
			_marcaCollectionViaProducto = CType(info.GetValue("_marcaCollectionViaProducto", GetType(Integralab.ORM.CollectionClasses.MarcaCollection)), Integralab.ORM.CollectionClasses.MarcaCollection)
			_alwaysFetchMarcaCollectionViaProducto = info.GetBoolean("_alwaysFetchMarcaCollectionViaProducto")
			_alreadyFetchedMarcaCollectionViaProducto = info.GetBoolean("_alreadyFetchedMarcaCollectionViaProducto")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCatNutrientes = (_catNutrientes.Count > 0)
			_alreadyFetchedPresentacion = (_presentacion.Count > 0)
			_alreadyFetchedProducto = (_producto.Count > 0)
			_alreadyFetchedLineaCollectionViaProducto = (_lineaCollectionViaProducto.Count > 0)
			_alreadyFetchedPresentacionCollectionViaProducto = (_presentacionCollectionViaProducto.Count > 0)
			_alreadyFetchedTipoProductoCollectionViaProducto = (_tipoProductoCollectionViaProducto.Count > 0)
			_alreadyFetchedMarcaCollectionViaProducto = (_marcaCollectionViaProducto.Count > 0)


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
			info.AddValue("_catNutrientes", _catNutrientes)
			info.AddValue("_alwaysFetchCatNutrientes", _alwaysFetchCatNutrientes)
			info.AddValue("_alreadyFetchedCatNutrientes", _alreadyFetchedCatNutrientes)
			info.AddValue("_presentacion", _presentacion)
			info.AddValue("_alwaysFetchPresentacion", _alwaysFetchPresentacion)
			info.AddValue("_alreadyFetchedPresentacion", _alreadyFetchedPresentacion)
			info.AddValue("_producto", _producto)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_lineaCollectionViaProducto", _lineaCollectionViaProducto)
			info.AddValue("_alwaysFetchLineaCollectionViaProducto", _alwaysFetchLineaCollectionViaProducto)
			info.AddValue("_alreadyFetchedLineaCollectionViaProducto", _alreadyFetchedLineaCollectionViaProducto)
			info.AddValue("_presentacionCollectionViaProducto", _presentacionCollectionViaProducto)
			info.AddValue("_alwaysFetchPresentacionCollectionViaProducto", _alwaysFetchPresentacionCollectionViaProducto)
			info.AddValue("_alreadyFetchedPresentacionCollectionViaProducto", _alreadyFetchedPresentacionCollectionViaProducto)
			info.AddValue("_tipoProductoCollectionViaProducto", _tipoProductoCollectionViaProducto)
			info.AddValue("_alwaysFetchTipoProductoCollectionViaProducto", _alwaysFetchTipoProductoCollectionViaProducto)
			info.AddValue("_alreadyFetchedTipoProductoCollectionViaProducto", _alreadyFetchedTipoProductoCollectionViaProducto)
			info.AddValue("_marcaCollectionViaProducto", _marcaCollectionViaProducto)
			info.AddValue("_alwaysFetchMarcaCollectionViaProducto", _alwaysFetchMarcaCollectionViaProducto)
			info.AddValue("_alreadyFetchedMarcaCollectionViaProducto", _alreadyFetchedMarcaCollectionViaProducto)


			
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

				Case "CatNutrientes"
					_alreadyFetchedCatNutrientes = True
					If Not entity Is Nothing Then
						Me.CatNutrientes.Add(CType(entity, CatNutrientesEntity))
					End If
				Case "Presentacion"
					_alreadyFetchedPresentacion = True
					If Not entity Is Nothing Then
						Me.Presentacion.Add(CType(entity, PresentacionEntity))
					End If
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
				Case "PresentacionCollectionViaProducto"
					_alreadyFetchedPresentacionCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.PresentacionCollectionViaProducto.Add(CType(entity, PresentacionEntity))
					End If
				Case "TipoProductoCollectionViaProducto"
					_alreadyFetchedTipoProductoCollectionViaProducto = True
					If Not entity Is Nothing Then
						Me.TipoProductoCollectionViaProducto.Add(CType(entity, TipoProductoEntity))
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

				Case "CatNutrientes"
					_catNutrientes.Add(CType(relatedEntity, CatNutrientesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Presentacion"
					_presentacion.Add(CType(relatedEntity, PresentacionEntity))
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

				Case "CatNutrientes"
					MyBase.PerformRelatedEntityRemoval(_catNutrientes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Presentacion"
					MyBase.PerformRelatedEntityRemoval(_presentacion, relatedEntity, signalRelatedEntityManyToOne)
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



			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_catNutrientes)
			toReturn.Add(_presentacion)
			toReturn.Add(_producto)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As UnidadMedidaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As UnidadMedidaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatNutrientesEntity'</returns>
		Public Function GetMultiCatNutrientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Return GetMultiCatNutrientes(forceFetch, _catNutrientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCatNutrientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Return GetMultiCatNutrientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CatNutrientesEntity'</returns>
		Public Function GetMultiCatNutrientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Return GetMultiCatNutrientes(forceFetch, _catNutrientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatNutrientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			If ( Not _alreadyFetchedCatNutrientes Or forceFetch Or _alwaysFetchCatNutrientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catNutrientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catNutrientes)
					End If
				End If
				_catNutrientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catNutrientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_catNutrientes.GetMultiManyToOne(Me, Filter)
				_catNutrientes.SuppressClearInGetMulti = False
				_alreadyFetchedCatNutrientes = True
			End If
			Return _catNutrientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatNutrientes'. These settings will be taken into account
		''' when the property CatNutrientes is requested or GetMultiCatNutrientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatNutrientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catNutrientes.SortClauses=sortClauses
			_catNutrientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresentacionEntity'</returns>
		Public Function GetMultiPresentacion(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresentacionCollection
			Return GetMultiPresentacion(forceFetch, _presentacion.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPresentacion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresentacionCollection
			Return GetMultiPresentacion(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PresentacionEntity'</returns>
		Public Function GetMultiPresentacion(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresentacionCollection
			Return GetMultiPresentacion(forceFetch, _presentacion.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPresentacion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresentacionCollection
			If ( Not _alreadyFetchedPresentacion Or forceFetch Or _alwaysFetchPresentacion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _presentacion.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_presentacion)
					End If
				End If
				_presentacion.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_presentacion.EntityFactoryToUse = entityFactoryToUse
				End If
				_presentacion.GetMultiManyToOne(Me, Filter)
				_presentacion.SuppressClearInGetMulti = False
				_alreadyFetchedPresentacion = True
			End If
			Return _presentacion
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Presentacion'. These settings will be taken into account
		''' when the property Presentacion is requested or GetMultiPresentacion is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPresentacion(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_presentacion.SortClauses=sortClauses
			_presentacion.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
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
				_producto.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
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
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.LineaEntityUsingPdIdLinea, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UnidadMedidaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresentacionEntity'</returns>
		Public Function GetMultiPresentacionCollectionViaProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresentacionCollection
			Return GetMultiPresentacionCollectionViaProducto(forceFetch, _presentacionCollectionViaProducto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPresentacionCollectionViaProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresentacionCollection
			If ( Not _alreadyFetchedPresentacionCollectionViaProducto Or forceFetch Or _alwaysFetchPresentacionCollectionViaProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _presentacionCollectionViaProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_presentacionCollectionViaProducto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UnidadMedidaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_presentacionCollectionViaProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_presentacionCollectionViaProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_presentacionCollectionViaProducto.GetMulti(Filter, relations)
				_presentacionCollectionViaProducto.SuppressClearInGetMulti = False
				_alreadyFetchedPresentacionCollectionViaProducto = True
			End If
			Return _presentacionCollectionViaProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PresentacionCollectionViaProducto'. These settings will be taken into account
		''' when the property PresentacionCollectionViaProducto is requested or GetMultiPresentacionCollectionViaProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPresentacionCollectionViaProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_presentacionCollectionViaProducto.SortClauses=sortClauses
			_presentacionCollectionViaProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UnidadMedidaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", "Producto_", JoinHint.None)
				relations.Add(ProductoEntity.Relations.MarcaEntityUsingCodigoMarca, "Producto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(UnidadMedidaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
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

	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(UnidadMedidaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, UnidadMedidaFieldIndex)













					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_catNutrientes.ActiveContext = MyBase.ActiveContext
			_presentacion.ActiveContext = MyBase.ActiveContext
			_producto.ActiveContext = MyBase.ActiveContext
			_lineaCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_presentacionCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_tipoProductoCollectionViaProducto.ActiveContext = MyBase.ActiveContext
			_marcaCollectionViaProducto.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As UnidadMedidaDAO = CType(CreateDAOInstance(), UnidadMedidaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As UnidadMedidaDAO = CType(CreateDAOInstance(), UnidadMedidaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As UnidadMedidaDAO = CType(CreateDAOInstance(), UnidadMedidaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this UnidadMedidaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.UnidadMedidaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <param name="validator">The validator Object for this UnidadMedidaEntity</param>
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
			_catNutrientes = New Integralab.ORM.CollectionClasses.CatNutrientesCollection(New CatNutrientesEntityFactory())
			_catNutrientes.SetContainingEntityInfo(Me, "UnidadMedida")
			_alwaysFetchCatNutrientes = False
			_alreadyFetchedCatNutrientes = False
			_presentacion = New Integralab.ORM.CollectionClasses.PresentacionCollection(New PresentacionEntityFactory())
			_presentacion.SetContainingEntityInfo(Me, "UnidadMedida")
			_alwaysFetchPresentacion = False
			_alreadyFetchedPresentacion = False
			_producto = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_producto.SetContainingEntityInfo(Me, "UnidadMedida")
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_lineaCollectionViaProducto = New Integralab.ORM.CollectionClasses.LineaCollection(New LineaEntityFactory())
			_alwaysFetchLineaCollectionViaProducto = False
			_alreadyFetchedLineaCollectionViaProducto = False
			_presentacionCollectionViaProducto = New Integralab.ORM.CollectionClasses.PresentacionCollection(New PresentacionEntityFactory())
			_alwaysFetchPresentacionCollectionViaProducto = False
			_alreadyFetchedPresentacionCollectionViaProducto = False
			_tipoProductoCollectionViaProducto = New Integralab.ORM.CollectionClasses.TipoProductoCollection(New TipoProductoEntityFactory())
			_alwaysFetchTipoProductoCollectionViaProducto = False
			_alreadyFetchedTipoProductoCollectionViaProducto = False
			_marcaCollectionViaProducto = New Integralab.ORM.CollectionClasses.MarcaCollection(New MarcaEntityFactory())
			_alwaysFetchMarcaCollectionViaProducto = False
			_alreadyFetchedMarcaCollectionViaProducto = False


			
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

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Claveunidadsat", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Clavedemoneda", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for UnidadMedida which data should be fetched into this UnidadMedida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(UnidadMedidaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateUnidadMedidaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New UnidadMedidaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As UnidadMedidaRelations
			Get	
				Return New UnidadMedidaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatNutrientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatNutrientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatNutrientesCollection(), _
					UnidadMedidaEntity.Relations.CatNutrientesEntityUsingUnidad, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.CatNutrientesEntity, Integer), 0, Nothing, Nothing, Nothing, "CatNutrientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presentacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPresentacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresentacionCollection(), _
					UnidadMedidaEntity.Relations.PresentacionEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), 0, Nothing, Nothing, Nothing, "Presentacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Linea' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathLineaCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.LineaCollection(), _
					UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.LineaEntity, Integer), 0, Nothing, Nothing, relations, "LineaCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presentacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPresentacionCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.PresentacionEntityUsingCodigoPresentacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresentacionCollection(), _
					UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.PresentacionEntity, Integer), 0, Nothing, Nothing, relations, "PresentacionCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoProductoCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.TipoProductoEntityUsingCodigoTipoProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoProductoCollection(), _
					UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.TipoProductoEntity, Integer), 0, Nothing, Nothing, relations, "TipoProductoCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Marca' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMarcaCollectionViaProducto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, "__UnidadMedidaEntity__", String.Empty, JoinHint.None)
				relations.Add(ProductoEntity.Relations.MarcaEntityUsingCodigoMarca)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MarcaCollection(), _
					UnidadMedidaEntity.Relations.ProductoEntityUsingCodigoUnidadMedida, _
					CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), CType(Integralab.ORM.EntityType.MarcaEntity, Integer), 0, Nothing, Nothing, relations, "MarcaCollectionViaProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "UnidadMedidaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return UnidadMedidaEntity.CustomProperties
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
				Return UnidadMedidaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMIdUnidadMedida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMDescCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.FechaAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.UsuarioAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMidMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."UMObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Claveunidadsat property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."Claveunidadsat"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Claveunidadsat]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Claveunidadsat, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Claveunidadsat, Integer), value)
			End Set
		End Property
	
		''' <summary>The Clavedemoneda property of the Entity UnidadMedida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompUnidadMedida"."clavedemoneda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Clavedemoneda]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UnidadMedidaFieldIndex.Clavedemoneda, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UnidadMedidaFieldIndex.Clavedemoneda, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CatNutrientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatNutrientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatNutrientes]() As Integralab.ORM.CollectionClasses.CatNutrientesCollection
			Get
				Return GetMultiCatNutrientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatNutrientes. When set to true, CatNutrientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatNutrientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatNutrientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatNutrientes As Boolean
			Get
				Return _alwaysFetchCatNutrientes
			End Get
			Set
				_alwaysFetchCatNutrientes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPresentacion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Presentacion]() As Integralab.ORM.CollectionClasses.PresentacionCollection
			Get
				Return GetMultiPresentacion(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Presentacion. When set to true, Presentacion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Presentacion is accessed. You can always execute
		''' a forced fetch by calling GetMultiPresentacion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPresentacion As Boolean
			Get
				Return _alwaysFetchPresentacion
			End Get
			Set
				_alwaysFetchPresentacion = value
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
	
		''' <summary>Retrieves all related entities of type 'PresentacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPresentacionCollectionViaProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PresentacionCollectionViaProducto]() As Integralab.ORM.CollectionClasses.PresentacionCollection
			Get
				Return GetMultiPresentacionCollectionViaProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PresentacionCollectionViaProducto. When set to true, PresentacionCollectionViaProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PresentacionCollectionViaProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiPresentacionCollectionViaProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPresentacionCollectionViaProducto As Boolean
			Get
				Return _alwaysFetchPresentacionCollectionViaProducto
			End Get
			Set
				_alwaysFetchPresentacionCollectionViaProducto = value
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
				Return CInt(Integralab.ORM.EntityType.UnidadMedidaEntity)
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
