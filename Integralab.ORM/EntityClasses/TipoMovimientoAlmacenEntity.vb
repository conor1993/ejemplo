' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:32
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
	''' <summary>Entity class which represents the entity 'TipoMovimientoAlmacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class TipoMovimientoAlmacenEntity 
#Else
	<Serializable()> _
	Public Class TipoMovimientoAlmacenEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _inventarioMovimientoAlmacen As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen As Boolean
		Private _mscmovtosAlmacenCab As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCab, _alreadyFetchedMscmovtosAlmacenCab As Boolean
		Private _almacenCollectionViaInventarioMovimientoAlmacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen, _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen As Boolean
		Private _almacenCollectionViaMscmovtosAlmacenCab As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab, _alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab As Boolean



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
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <param name="validator">The custom validator Object for this TipoMovimientoAlmacenEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_inventarioMovimientoAlmacen = CType(info.GetValue("_inventarioMovimientoAlmacen", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen")
			_alreadyFetchedInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen")
			_mscmovtosAlmacenCab = CType(info.GetValue("_mscmovtosAlmacenCab", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab")
			_alreadyFetchedMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab")
			_almacenCollectionViaInventarioMovimientoAlmacen = CType(info.GetValue("_almacenCollectionViaInventarioMovimientoAlmacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen")
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen")
			_almacenCollectionViaMscmovtosAlmacenCab = CType(info.GetValue("_almacenCollectionViaMscmovtosAlmacenCab", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab")
			_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedInventarioMovimientoAlmacen = (_inventarioMovimientoAlmacen.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCab = (_mscmovtosAlmacenCab.Count > 0)
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen = (_almacenCollectionViaInventarioMovimientoAlmacen.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab = (_almacenCollectionViaMscmovtosAlmacenCab.Count > 0)


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
			info.AddValue("_inventarioMovimientoAlmacen", _inventarioMovimientoAlmacen)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen", _alwaysFetchInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen", _alreadyFetchedInventarioMovimientoAlmacen)
			info.AddValue("_mscmovtosAlmacenCab", _mscmovtosAlmacenCab)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab", _alwaysFetchMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab", _alreadyFetchedMscmovtosAlmacenCab)
			info.AddValue("_almacenCollectionViaInventarioMovimientoAlmacen", _almacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen", _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen", _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen)
			info.AddValue("_almacenCollectionViaMscmovtosAlmacenCab", _almacenCollectionViaMscmovtosAlmacenCab)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab", _alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab", _alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab)


			
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

				Case "InventarioMovimientoAlmacen"
					_alreadyFetchedInventarioMovimientoAlmacen = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacen.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "MscmovtosAlmacenCab"
					_alreadyFetchedMscmovtosAlmacenCab = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCab.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "AlmacenCollectionViaInventarioMovimientoAlmacen"
					_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaInventarioMovimientoAlmacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMscmovtosAlmacenCab"
					_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMscmovtosAlmacenCab.Add(CType(entity, AlmacenEntity))
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

				Case "InventarioMovimientoAlmacen"
					_inventarioMovimientoAlmacen.Add(CType(relatedEntity, InventarioMovimientoAlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					_mscmovtosAlmacenCab.Add(CType(relatedEntity, MscmovtosAlmacenCabEntity))
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

				Case "InventarioMovimientoAlmacen"
					MyBase.PerformRelatedEntityRemoval(_inventarioMovimientoAlmacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					MyBase.PerformRelatedEntityRemoval(_mscmovtosAlmacenCab, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_inventarioMovimientoAlmacen)
			toReturn.Add(_mscmovtosAlmacenCab)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As TipoMovimientoAlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As TipoMovimientoAlmacenFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, _inventarioMovimientoAlmacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacen(forceFetch, _inventarioMovimientoAlmacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacen)
					End If
				End If
				_inventarioMovimientoAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacen.GetMultiManyToOne(Nothing, Me, Filter)
				_inventarioMovimientoAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacen = True
			End If
			Return _inventarioMovimientoAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacen'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacen is requested or GetMultiInventarioMovimientoAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacen.SortClauses=sortClauses
			_inventarioMovimientoAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, _mscmovtosAlmacenCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCab(forceFetch, _mscmovtosAlmacenCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCab)
					End If
				End If
				_mscmovtosAlmacenCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCab.GetMultiManyToOne(Nothing, Me, Filter)
				_mscmovtosAlmacenCab.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCab = True
			End If
			Return _mscmovtosAlmacenCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCab'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCab is requested or GetMultiMscmovtosAlmacenCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCab.SortClauses=sortClauses
			_mscmovtosAlmacenCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch, _almacenCollectionViaInventarioMovimientoAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaInventarioMovimientoAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaInventarioMovimientoAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingTipoMovimientoId, "__TipoMovimientoAlmacenEntity__", "InventarioMovimientoAlmacen_", JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, "InventarioMovimientoAlmacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMovimientoAlmacenFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaInventarioMovimientoAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaInventarioMovimientoAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaInventarioMovimientoAlmacen.GetMulti(Filter, relations)
				_almacenCollectionViaInventarioMovimientoAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen = True
			End If
			Return _almacenCollectionViaInventarioMovimientoAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaInventarioMovimientoAlmacen'. These settings will be taken into account
		''' when the property AlmacenCollectionViaInventarioMovimientoAlmacen is requested or GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaInventarioMovimientoAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaInventarioMovimientoAlmacen.SortClauses=sortClauses
			_almacenCollectionViaInventarioMovimientoAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch, _almacenCollectionViaMscmovtosAlmacenCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMscmovtosAlmacenCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMscmovtosAlmacenCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMscmovtosAlmacenCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoMovimientoAlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodMovimiento, "__TipoMovimientoAlmacenEntity__", "MscmovtosAlmacenCab_", JoinHint.None)
				relations.Add(MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen, "MscmovtosAlmacenCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoMovimientoAlmacenFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaMscmovtosAlmacenCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMscmovtosAlmacenCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMscmovtosAlmacenCab.GetMulti(Filter, relations)
				_almacenCollectionViaMscmovtosAlmacenCab.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab = True
			End If
			Return _almacenCollectionViaMscmovtosAlmacenCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMscmovtosAlmacenCab'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMscmovtosAlmacenCab is requested or GetMultiAlmacenCollectionViaMscmovtosAlmacenCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMscmovtosAlmacenCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMscmovtosAlmacenCab.SortClauses=sortClauses
			_almacenCollectionViaMscmovtosAlmacenCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(TipoMovimientoAlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, TipoMovimientoAlmacenFieldIndex)










					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_inventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaInventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As TipoMovimientoAlmacenDAO = CType(CreateDAOInstance(), TipoMovimientoAlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As TipoMovimientoAlmacenDAO = CType(CreateDAOInstance(), TipoMovimientoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As TipoMovimientoAlmacenDAO = CType(CreateDAOInstance(), TipoMovimientoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this TipoMovimientoAlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <param name="validator">The validator Object for this TipoMovimientoAlmacenEntity</param>
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
			_inventarioMovimientoAlmacen = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_inventarioMovimientoAlmacen.SetContainingEntityInfo(Me, "TipoMovimientoAlmacen")
			_alwaysFetchInventarioMovimientoAlmacen = False
			_alreadyFetchedInventarioMovimientoAlmacen = False
			_mscmovtosAlmacenCab = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_mscmovtosAlmacenCab.SetContainingEntityInfo(Me, "TipoMovimientoAlmacen")
			_alwaysFetchMscmovtosAlmacenCab = False
			_alreadyFetchedMscmovtosAlmacenCab = False
			_almacenCollectionViaInventarioMovimientoAlmacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen = False
			_alreadyFetchedAlmacenCollectionViaInventarioMovimientoAlmacen = False
			_almacenCollectionViaMscmovtosAlmacenCab = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab = False
			_alreadyFetchedAlmacenCollectionViaMscmovtosAlmacenCab = False


			
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

			_fieldsCustomProperties.Add("AfectaCosto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAltaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBajaId", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for TipoMovimientoAlmacen which data should be fetched into this TipoMovimientoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(TipoMovimientoAlmacenFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateTipoMovimientoAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New TipoMovimientoAlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As TipoMovimientoAlmacenRelations
			Get	
				Return New TipoMovimientoAlmacenRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					TipoMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingTipoMovimientoId, _
					CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					TipoMovimientoAlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodMovimiento, _
					CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingTipoMovimientoId, "__TipoMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(InventarioMovimientoAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					TipoMovimientoAlmacenEntity.Relations.InventarioMovimientoAlmacenEntityUsingTipoMovimientoId, _
					CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaInventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoMovimientoAlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodMovimiento, "__TipoMovimientoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(MscmovtosAlmacenCabEntity.Relations.AlmacenEntityUsingIdCodAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					TipoMovimientoAlmacenEntity.Relations.MscmovtosAlmacenCabEntityUsingIdCodMovimiento, _
					CType(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "TipoMovimientoAlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return TipoMovimientoAlmacenEntity.CustomProperties
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
				Return TipoMovimientoAlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."DescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The AfectaCosto property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."AfectaCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AfectaCosto]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.AfectaCosto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.AfectaCosto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Direccion property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."Direccion"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Direccion]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Direccion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Direccion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.FechaAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAltaId property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."UsuarioAltaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAltaId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.UsuarioAltaId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.UsuarioAltaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBajaId property of the Entity TipoMovimientoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTipoMovimiento"."UsuarioBajaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBajaId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoMovimientoAlmacenFieldIndex.UsuarioBajaId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoMovimientoAlmacenFieldIndex.UsuarioBajaId, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacen]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen. When set to true, InventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCab]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCab. When set to true, MscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCab = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaInventarioMovimientoAlmacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaInventarioMovimientoAlmacen. When set to true, AlmacenCollectionViaInventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaInventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaInventarioMovimientoAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMscmovtosAlmacenCab]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMscmovtosAlmacenCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMscmovtosAlmacenCab. When set to true, AlmacenCollectionViaMscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMscmovtosAlmacenCab = value
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
				Return CInt(Integralab.ORM.EntityType.TipoMovimientoAlmacenEntity)
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
