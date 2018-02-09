' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 12:25:19
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
	''' <summary>Entity class which represents the entity 'MotivoCancelacion'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MotivoCancelacionEntity 
#Else
	<Serializable()> _
	Public Class MotivoCancelacionEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _motivosCancelacionDetalle As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
		Private _alwaysFetchMotivosCancelacionDetalle, _alreadyFetchedMotivosCancelacionDetalle As Boolean
		Private _moneda As Integralab.ORM.CollectionClasses.MonedaCollection
		Private _alwaysFetchMoneda, _alreadyFetchedMoneda As Boolean
		Private _mcomPresupuesto As Integralab.ORM.CollectionClasses.PresupuestoCollection
		Private _alwaysFetchMcomPresupuesto, _alreadyFetchedMcomPresupuesto As Boolean
		Private _recepcionOrdenCompra As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
		Private _alwaysFetchRecepcionOrdenCompra, _alreadyFetchedRecepcionOrdenCompra As Boolean
		Private _moduloCollectionViaMotivosCancelacionDetalle As Integralab.ORM.CollectionClasses.ModuloCollection
		Private _alwaysFetchModuloCollectionViaMotivosCancelacionDetalle, _alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle As Boolean
		Private _tipoPresupuestoCollectionViaMcomPresupuesto As Integralab.ORM.CollectionClasses.TipoPresupuestoCollection
		Private _alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto, _alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto As Boolean
		Private _almacenCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra, _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra As Boolean
		Private _ordenCompraCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra, _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra As Boolean



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
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		Public Sub New(idMotivo As System.Int32)

			InitClassFetch(idMotivo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idMotivo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idMotivo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="validator">The custom validator Object for this MotivoCancelacionEntity</param>
		Public Sub New(idMotivo As System.Int32, validator As IValidator)

			InitClassFetch(idMotivo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_motivosCancelacionDetalle = CType(info.GetValue("_motivosCancelacionDetalle", GetType(Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection)), Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection)
			_alwaysFetchMotivosCancelacionDetalle = info.GetBoolean("_alwaysFetchMotivosCancelacionDetalle")
			_alreadyFetchedMotivosCancelacionDetalle = info.GetBoolean("_alreadyFetchedMotivosCancelacionDetalle")
			_moneda = CType(info.GetValue("_moneda", GetType(Integralab.ORM.CollectionClasses.MonedaCollection)), Integralab.ORM.CollectionClasses.MonedaCollection)
			_alwaysFetchMoneda = info.GetBoolean("_alwaysFetchMoneda")
			_alreadyFetchedMoneda = info.GetBoolean("_alreadyFetchedMoneda")
			_mcomPresupuesto = CType(info.GetValue("_mcomPresupuesto", GetType(Integralab.ORM.CollectionClasses.PresupuestoCollection)), Integralab.ORM.CollectionClasses.PresupuestoCollection)
			_alwaysFetchMcomPresupuesto = info.GetBoolean("_alwaysFetchMcomPresupuesto")
			_alreadyFetchedMcomPresupuesto = info.GetBoolean("_alreadyFetchedMcomPresupuesto")
			_recepcionOrdenCompra = CType(info.GetValue("_recepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)), Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)
			_alwaysFetchRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchRecepcionOrdenCompra")
			_alreadyFetchedRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedRecepcionOrdenCompra")
			_moduloCollectionViaMotivosCancelacionDetalle = CType(info.GetValue("_moduloCollectionViaMotivosCancelacionDetalle", GetType(Integralab.ORM.CollectionClasses.ModuloCollection)), Integralab.ORM.CollectionClasses.ModuloCollection)
			_alwaysFetchModuloCollectionViaMotivosCancelacionDetalle = info.GetBoolean("_alwaysFetchModuloCollectionViaMotivosCancelacionDetalle")
			_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle = info.GetBoolean("_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle")
			_tipoPresupuestoCollectionViaMcomPresupuesto = CType(info.GetValue("_tipoPresupuestoCollectionViaMcomPresupuesto", GetType(Integralab.ORM.CollectionClasses.TipoPresupuestoCollection)), Integralab.ORM.CollectionClasses.TipoPresupuestoCollection)
			_alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto = info.GetBoolean("_alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto")
			_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto = info.GetBoolean("_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto")
			_almacenCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_almacenCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra")
			_ordenCompraCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_ordenCompraCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMotivosCancelacionDetalle = (_motivosCancelacionDetalle.Count > 0)
			_alreadyFetchedMoneda = (_moneda.Count > 0)
			_alreadyFetchedMcomPresupuesto = (_mcomPresupuesto.Count > 0)
			_alreadyFetchedRecepcionOrdenCompra = (_recepcionOrdenCompra.Count > 0)
			_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle = (_moduloCollectionViaMotivosCancelacionDetalle.Count > 0)
			_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto = (_tipoPresupuestoCollectionViaMcomPresupuesto.Count > 0)
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = (_almacenCollectionViaRecepcionOrdenCompra.Count > 0)
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = (_ordenCompraCollectionViaRecepcionOrdenCompra.Count > 0)


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
			info.AddValue("_motivosCancelacionDetalle", _motivosCancelacionDetalle)
			info.AddValue("_alwaysFetchMotivosCancelacionDetalle", _alwaysFetchMotivosCancelacionDetalle)
			info.AddValue("_alreadyFetchedMotivosCancelacionDetalle", _alreadyFetchedMotivosCancelacionDetalle)
			info.AddValue("_moneda", _moneda)
			info.AddValue("_alwaysFetchMoneda", _alwaysFetchMoneda)
			info.AddValue("_alreadyFetchedMoneda", _alreadyFetchedMoneda)
			info.AddValue("_mcomPresupuesto", _mcomPresupuesto)
			info.AddValue("_alwaysFetchMcomPresupuesto", _alwaysFetchMcomPresupuesto)
			info.AddValue("_alreadyFetchedMcomPresupuesto", _alreadyFetchedMcomPresupuesto)
			info.AddValue("_recepcionOrdenCompra", _recepcionOrdenCompra)
			info.AddValue("_alwaysFetchRecepcionOrdenCompra", _alwaysFetchRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedRecepcionOrdenCompra", _alreadyFetchedRecepcionOrdenCompra)
			info.AddValue("_moduloCollectionViaMotivosCancelacionDetalle", _moduloCollectionViaMotivosCancelacionDetalle)
			info.AddValue("_alwaysFetchModuloCollectionViaMotivosCancelacionDetalle", _alwaysFetchModuloCollectionViaMotivosCancelacionDetalle)
			info.AddValue("_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle", _alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle)
			info.AddValue("_tipoPresupuestoCollectionViaMcomPresupuesto", _tipoPresupuestoCollectionViaMcomPresupuesto)
			info.AddValue("_alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto", _alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto)
			info.AddValue("_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto", _alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto)
			info.AddValue("_almacenCollectionViaRecepcionOrdenCompra", _almacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra", _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra", _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_ordenCompraCollectionViaRecepcionOrdenCompra", _ordenCompraCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra", _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra", _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra)


			
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

				Case "MotivosCancelacionDetalle"
					_alreadyFetchedMotivosCancelacionDetalle = True
					If Not entity Is Nothing Then
						Me.MotivosCancelacionDetalle.Add(CType(entity, MotivoCancelacionDetalleEntity))
					End If
				Case "Moneda"
					_alreadyFetchedMoneda = True
					If Not entity Is Nothing Then
						Me.Moneda.Add(CType(entity, MonedaEntity))
					End If
				Case "McomPresupuesto"
					_alreadyFetchedMcomPresupuesto = True
					If Not entity Is Nothing Then
						Me.McomPresupuesto.Add(CType(entity, PresupuestoEntity))
					End If
				Case "RecepcionOrdenCompra"
					_alreadyFetchedRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.RecepcionOrdenCompra.Add(CType(entity, RecepcionOrdenCompraEntity))
					End If
				Case "ModuloCollectionViaMotivosCancelacionDetalle"
					_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle = True
					If Not entity Is Nothing Then
						Me.ModuloCollectionViaMotivosCancelacionDetalle.Add(CType(entity, ModuloEntity))
					End If
				Case "TipoPresupuestoCollectionViaMcomPresupuesto"
					_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto = True
					If Not entity Is Nothing Then
						Me.TipoPresupuestoCollectionViaMcomPresupuesto.Add(CType(entity, TipoPresupuestoEntity))
					End If
				Case "AlmacenCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaRecepcionOrdenCompra.Add(CType(entity, AlmacenEntity))
					End If
				Case "OrdenCompraCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.OrdenCompraCollectionViaRecepcionOrdenCompra.Add(CType(entity, OrdenCompraEntity))
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

				Case "MotivosCancelacionDetalle"
					_motivosCancelacionDetalle.Add(CType(relatedEntity, MotivoCancelacionDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Moneda"
					_moneda.Add(CType(relatedEntity, MonedaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomPresupuesto"
					_mcomPresupuesto.Add(CType(relatedEntity, PresupuestoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					_recepcionOrdenCompra.Add(CType(relatedEntity, RecepcionOrdenCompraEntity))
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

				Case "MotivosCancelacionDetalle"
					MyBase.PerformRelatedEntityRemoval(_motivosCancelacionDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Moneda"
					MyBase.PerformRelatedEntityRemoval(_moneda, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomPresupuesto"
					MyBase.PerformRelatedEntityRemoval(_mcomPresupuesto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_recepcionOrdenCompra, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_motivosCancelacionDetalle)
			toReturn.Add(_moneda)
			toReturn.Add(_mcomPresupuesto)
			toReturn.Add(_recepcionOrdenCompra)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idMotivo As System.Int32) As Boolean
			Return FetchUsingPK(idMotivo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idMotivo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idMotivo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idMotivo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idMotivo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdMotivo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MotivoCancelacionFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MotivoCancelacionFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionDetalleEntity'</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, _motivosCancelacionDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionDetalleEntity'</returns>
		Public Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Return GetMultiMotivosCancelacionDetalle(forceFetch, _motivosCancelacionDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			If ( Not _alreadyFetchedMotivosCancelacionDetalle Or forceFetch Or _alwaysFetchMotivosCancelacionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivosCancelacionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivosCancelacionDetalle)
					End If
				End If
				_motivosCancelacionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivosCancelacionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivosCancelacionDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_motivosCancelacionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMotivosCancelacionDetalle = True
			End If
			Return _motivosCancelacionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivosCancelacionDetalle'. These settings will be taken into account
		''' when the property MotivosCancelacionDetalle is requested or GetMultiMotivosCancelacionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivosCancelacionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivosCancelacionDetalle.SortClauses=sortClauses
			_motivosCancelacionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MonedaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MonedaEntity'</returns>
		Public Function GetMultiMoneda(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MonedaCollection
			Return GetMultiMoneda(forceFetch, _moneda.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MonedaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMoneda(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MonedaCollection
			Return GetMultiMoneda(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MonedaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MonedaEntity'</returns>
		Public Function GetMultiMoneda(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MonedaCollection
			Return GetMultiMoneda(forceFetch, _moneda.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MonedaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMoneda(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MonedaCollection
			If ( Not _alreadyFetchedMoneda Or forceFetch Or _alwaysFetchMoneda) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _moneda.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_moneda)
					End If
				End If
				_moneda.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_moneda.EntityFactoryToUse = entityFactoryToUse
				End If
				_moneda.GetMultiManyToOne(Me, Filter)
				_moneda.SuppressClearInGetMulti = False
				_alreadyFetchedMoneda = True
			End If
			Return _moneda
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Moneda'. These settings will be taken into account
		''' when the property Moneda is requested or GetMultiMoneda is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMoneda(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_moneda.SortClauses=sortClauses
			_moneda.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoEntity'</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, _mcomPresupuesto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoEntity'</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, _mcomPresupuesto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomPresupuesto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			If ( Not _alreadyFetchedMcomPresupuesto Or forceFetch Or _alwaysFetchMcomPresupuesto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomPresupuesto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomPresupuesto)
					End If
				End If
				_mcomPresupuesto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomPresupuesto.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomPresupuesto.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_mcomPresupuesto.SuppressClearInGetMulti = False
				_alreadyFetchedMcomPresupuesto = True
			End If
			Return _mcomPresupuesto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomPresupuesto'. These settings will be taken into account
		''' when the property McomPresupuesto is requested or GetMultiMcomPresupuesto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomPresupuesto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomPresupuesto.SortClauses=sortClauses
			_mcomPresupuesto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			If ( Not _alreadyFetchedRecepcionOrdenCompra Or forceFetch Or _alwaysFetchRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionOrdenCompra)
					End If
				End If
				_recepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionOrdenCompra.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_recepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionOrdenCompra = True
			End If
			Return _recepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionOrdenCompra'. These settings will be taken into account
		''' when the property RecepcionOrdenCompra is requested or GetMultiRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionOrdenCompra.SortClauses=sortClauses
			_recepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ModuloEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ModuloEntity'</returns>
		Public Function GetMultiModuloCollectionViaMotivosCancelacionDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ModuloCollection
			Return GetMultiModuloCollectionViaMotivosCancelacionDetalle(forceFetch, _moduloCollectionViaMotivosCancelacionDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ModuloEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiModuloCollectionViaMotivosCancelacionDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ModuloCollection
			If ( Not _alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle Or forceFetch Or _alwaysFetchModuloCollectionViaMotivosCancelacionDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _moduloCollectionViaMotivosCancelacionDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_moduloCollectionViaMotivosCancelacionDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MotivoCancelacionEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmotivo, "__MotivoCancelacionEntity__", "MotivoCancelacionDetalle_", JoinHint.None)
				relations.Add(MotivoCancelacionDetalleEntity.Relations.ModuloEntityUsingIdmodulo, "MotivoCancelacionDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), ComparisonOperator.Equal, Me.IdMotivo))
				_moduloCollectionViaMotivosCancelacionDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_moduloCollectionViaMotivosCancelacionDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_moduloCollectionViaMotivosCancelacionDetalle.GetMulti(Filter, relations)
				_moduloCollectionViaMotivosCancelacionDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle = True
			End If
			Return _moduloCollectionViaMotivosCancelacionDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ModuloCollectionViaMotivosCancelacionDetalle'. These settings will be taken into account
		''' when the property ModuloCollectionViaMotivosCancelacionDetalle is requested or GetMultiModuloCollectionViaMotivosCancelacionDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersModuloCollectionViaMotivosCancelacionDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_moduloCollectionViaMotivosCancelacionDetalle.SortClauses=sortClauses
			_moduloCollectionViaMotivosCancelacionDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoPresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoPresupuestoEntity'</returns>
		Public Function GetMultiTipoPresupuestoCollectionViaMcomPresupuesto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoPresupuestoCollection
			Return GetMultiTipoPresupuestoCollectionViaMcomPresupuesto(forceFetch, _tipoPresupuestoCollectionViaMcomPresupuesto.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoPresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoPresupuestoCollectionViaMcomPresupuesto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoPresupuestoCollection
			If ( Not _alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto Or forceFetch Or _alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoPresupuestoCollectionViaMcomPresupuesto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoPresupuestoCollectionViaMcomPresupuesto)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MotivoCancelacionEntity.Relations.PresupuestoEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", "Presupuesto_", JoinHint.None)
				relations.Add(PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId, "Presupuesto_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), ComparisonOperator.Equal, Me.IdMotivo))
				_tipoPresupuestoCollectionViaMcomPresupuesto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoPresupuestoCollectionViaMcomPresupuesto.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoPresupuestoCollectionViaMcomPresupuesto.GetMulti(Filter, relations)
				_tipoPresupuestoCollectionViaMcomPresupuesto.SuppressClearInGetMulti = False
				_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto = True
			End If
			Return _tipoPresupuestoCollectionViaMcomPresupuesto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoPresupuestoCollectionViaMcomPresupuesto'. These settings will be taken into account
		''' when the property TipoPresupuestoCollectionViaMcomPresupuesto is requested or GetMultiTipoPresupuestoCollectionViaMcomPresupuesto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoPresupuestoCollectionViaMcomPresupuesto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoPresupuestoCollectionViaMcomPresupuesto.SortClauses=sortClauses
			_tipoPresupuestoCollectionViaMcomPresupuesto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch, _almacenCollectionViaRecepcionOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra Or forceFetch Or _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaRecepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaRecepcionOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), ComparisonOperator.Equal, Me.IdMotivo))
				_almacenCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaRecepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaRecepcionOrdenCompra.GetMulti(Filter, relations)
				_almacenCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = True
			End If
			Return _almacenCollectionViaRecepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaRecepcionOrdenCompra'. These settings will be taken into account
		''' when the property AlmacenCollectionViaRecepcionOrdenCompra is requested or GetMultiAlmacenCollectionViaRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaRecepcionOrdenCompra.SortClauses=sortClauses
			_almacenCollectionViaRecepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch, _ordenCompraCollectionViaRecepcionOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			If ( Not _alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompraCollectionViaRecepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompraCollectionViaRecepcionOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MotivoCancelacionFieldIndex.IdMotivo), ComparisonOperator.Equal, Me.IdMotivo))
				_ordenCompraCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompraCollectionViaRecepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompraCollectionViaRecepcionOrdenCompra.GetMulti(Filter, relations)
				_ordenCompraCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = True
			End If
			Return _ordenCompraCollectionViaRecepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompraCollectionViaRecepcionOrdenCompra'. These settings will be taken into account
		''' when the property OrdenCompraCollectionViaRecepcionOrdenCompra is requested or GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompraCollectionViaRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompraCollectionViaRecepcionOrdenCompra.SortClauses=sortClauses
			_ordenCompraCollectionViaRecepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MotivoCancelacionFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MotivoCancelacionFieldIndex)






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_motivosCancelacionDetalle.ActiveContext = MyBase.ActiveContext
			_moneda.ActiveContext = MyBase.ActiveContext
			_mcomPresupuesto.ActiveContext = MyBase.ActiveContext
			_recepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_moduloCollectionViaMotivosCancelacionDetalle.ActiveContext = MyBase.ActiveContext
			_tipoPresupuestoCollectionViaMcomPresupuesto.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_ordenCompraCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MotivoCancelacionDAO = CType(CreateDAOInstance(), MotivoCancelacionDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MotivoCancelacionDAO = CType(CreateDAOInstance(), MotivoCancelacionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MotivoCancelacionDAO = CType(CreateDAOInstance(), MotivoCancelacionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MotivoCancelacionEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MotivoCancelacionEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="validator">The validator Object for this MotivoCancelacionEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idMotivo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idMotivo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_motivosCancelacionDetalle = New Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection(New MotivoCancelacionDetalleEntityFactory())
			_motivosCancelacionDetalle.SetContainingEntityInfo(Me, "MotivosCancelacion")
			_alwaysFetchMotivosCancelacionDetalle = False
			_alreadyFetchedMotivosCancelacionDetalle = False
			_moneda = New Integralab.ORM.CollectionClasses.MonedaCollection(New MonedaEntityFactory())
			_moneda.SetContainingEntityInfo(Me, "MotivosCancelacion")
			_alwaysFetchMoneda = False
			_alreadyFetchedMoneda = False
			_mcomPresupuesto = New Integralab.ORM.CollectionClasses.PresupuestoCollection(New PresupuestoEntityFactory())
			_mcomPresupuesto.SetContainingEntityInfo(Me, "MotivoCancelacion")
			_alwaysFetchMcomPresupuesto = False
			_alreadyFetchedMcomPresupuesto = False
			_recepcionOrdenCompra = New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(New RecepcionOrdenCompraEntityFactory())
			_recepcionOrdenCompra.SetContainingEntityInfo(Me, "MotivoCancelacion")
			_alwaysFetchRecepcionOrdenCompra = False
			_alreadyFetchedRecepcionOrdenCompra = False
			_moduloCollectionViaMotivosCancelacionDetalle = New Integralab.ORM.CollectionClasses.ModuloCollection(New ModuloEntityFactory())
			_alwaysFetchModuloCollectionViaMotivosCancelacionDetalle = False
			_alreadyFetchedModuloCollectionViaMotivosCancelacionDetalle = False
			_tipoPresupuestoCollectionViaMcomPresupuesto = New Integralab.ORM.CollectionClasses.TipoPresupuestoCollection(New TipoPresupuestoEntityFactory())
			_alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto = False
			_alreadyFetchedTipoPresupuestoCollectionViaMcomPresupuesto = False
			_almacenCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = False
			_ordenCompraCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedOrdenCompraCollectionViaRecepcionOrdenCompra = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMotivo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idMotivo">PK value for MotivoCancelacion which data should be fetched into this MotivoCancelacion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idMotivo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MotivoCancelacionFieldIndex.IdMotivo)).ForcedCurrentValueWrite(idMotivo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMotivoCancelacionDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MotivoCancelacionEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MotivoCancelacionRelations
			Get	
				Return New MotivoCancelacionRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacionDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivosCancelacionDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection(), _
					MotivoCancelacionEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmotivo, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivosCancelacionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Moneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MonedaCollection(), _
					MotivoCancelacionEntity.Relations.MonedaEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.MonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "Moneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presupuesto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomPresupuesto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresupuestoCollection(), _
					MotivoCancelacionEntity.Relations.PresupuestoEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), 0, Nothing, Nothing, Nothing, "McomPresupuesto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionOrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(), _
					MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Modulo' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathModuloCollectionViaMotivosCancelacionDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MotivoCancelacionEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmotivo, "__MotivoCancelacionEntity__", String.Empty, JoinHint.None)
				relations.Add(MotivoCancelacionDetalleEntity.Relations.ModuloEntityUsingIdmodulo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ModuloCollection(), _
					MotivoCancelacionEntity.Relations.MotivoCancelacionDetalleEntityUsingIdmotivo, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.ModuloEntity, Integer), 0, Nothing, Nothing, relations, "ModuloCollectionViaMotivosCancelacionDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoPresupuesto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoPresupuestoCollectionViaMcomPresupuesto() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MotivoCancelacionEntity.Relations.PresupuestoEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", String.Empty, JoinHint.None)
				relations.Add(PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoPresupuestoCollection(), _
					MotivoCancelacionEntity.Relations.PresupuestoEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.TipoPresupuestoEntity, Integer), 0, Nothing, Nothing, relations, "TipoPresupuestoCollectionViaMcomPresupuesto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, "__MotivoCancelacionEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					MotivoCancelacionEntity.Relations.RecepcionOrdenCompraEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, relations, "OrdenCompraCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MotivoCancelacionEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MotivoCancelacionEntity.CustomProperties
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
				Return MotivoCancelacionEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdMotivo property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."IdMotivo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdMotivo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.IdMotivo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.IdMotivo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."DescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MotivoCancelacion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosCancelacion"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoCancelacionFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MotivoCancelacionFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MotivoCancelacionDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivosCancelacionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivosCancelacionDetalle]() As Integralab.ORM.CollectionClasses.MotivoCancelacionDetalleCollection
			Get
				Return GetMultiMotivosCancelacionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivosCancelacionDetalle. When set to true, MotivosCancelacionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivosCancelacionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivosCancelacionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivosCancelacionDetalle As Boolean
			Get
				Return _alwaysFetchMotivosCancelacionDetalle
			End Get
			Set
				_alwaysFetchMotivosCancelacionDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MonedaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMoneda()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Moneda]() As Integralab.ORM.CollectionClasses.MonedaCollection
			Get
				Return GetMultiMoneda(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Moneda. When set to true, Moneda is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Moneda is accessed. You can always execute
		''' a forced fetch by calling GetMultiMoneda(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMoneda As Boolean
			Get
				Return _alwaysFetchMoneda
			End Get
			Set
				_alwaysFetchMoneda = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomPresupuesto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomPresupuesto]() As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Get
				Return GetMultiMcomPresupuesto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomPresupuesto. When set to true, McomPresupuesto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomPresupuesto is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomPresupuesto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomPresupuesto As Boolean
			Get
				Return _alwaysFetchMcomPresupuesto
			End Get
			Set
				_alwaysFetchMcomPresupuesto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Get
				Return GetMultiRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionOrdenCompra. When set to true, RecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchRecepcionOrdenCompra = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ModuloEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiModuloCollectionViaMotivosCancelacionDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ModuloCollectionViaMotivosCancelacionDetalle]() As Integralab.ORM.CollectionClasses.ModuloCollection
			Get
				Return GetMultiModuloCollectionViaMotivosCancelacionDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ModuloCollectionViaMotivosCancelacionDetalle. When set to true, ModuloCollectionViaMotivosCancelacionDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ModuloCollectionViaMotivosCancelacionDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiModuloCollectionViaMotivosCancelacionDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchModuloCollectionViaMotivosCancelacionDetalle As Boolean
			Get
				Return _alwaysFetchModuloCollectionViaMotivosCancelacionDetalle
			End Get
			Set
				_alwaysFetchModuloCollectionViaMotivosCancelacionDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoPresupuestoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoPresupuestoCollectionViaMcomPresupuesto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoPresupuestoCollectionViaMcomPresupuesto]() As Integralab.ORM.CollectionClasses.TipoPresupuestoCollection
			Get
				Return GetMultiTipoPresupuestoCollectionViaMcomPresupuesto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoPresupuestoCollectionViaMcomPresupuesto. When set to true, TipoPresupuestoCollectionViaMcomPresupuesto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoPresupuestoCollectionViaMcomPresupuesto is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoPresupuestoCollectionViaMcomPresupuesto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto As Boolean
			Get
				Return _alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto
			End Get
			Set
				_alwaysFetchTipoPresupuestoCollectionViaMcomPresupuesto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaRecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaRecepcionOrdenCompra. When set to true, AlmacenCollectionViaRecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaRecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompraCollectionViaRecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Get
				Return GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompraCollectionViaRecepcionOrdenCompra. When set to true, OrdenCompraCollectionViaRecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompraCollectionViaRecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompraCollectionViaRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompraCollectionViaRecepcionOrdenCompra = value
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
				Return CInt(Integralab.ORM.EntityType.MotivoCancelacionEntity)
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
