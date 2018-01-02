' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:35
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
	''' <summary>Entity class which represents the entity 'CabFacturas'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabFacturasEntity 
#Else
	<Serializable()> _
	Public Class CabFacturasEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detFacturas As Integralab.ORM.CollectionClasses.DetFacturasCollection
		Private _alwaysFetchDetFacturas, _alreadyFetchedDetFacturas As Boolean
		Private _mcgcatTiposdeGanadoCollectionViaDetFacturas As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
		Private _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas, _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas As Boolean
		Private _salidaGanadoCab As SalidaGanadoCabEntity
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab, _salidaGanadoCabReturnsNewIfNotFound As Boolean
		Private _poliza As PolizaEntity
		Private _alwaysFetchPoliza, _alreadyFetchedPoliza, _polizaReturnsNewIfNotFound As Boolean
		Private _poliza_ As PolizaEntity
		Private _alwaysFetchPoliza_, _alreadyFetchedPoliza_, _poliza_ReturnsNewIfNotFound As Boolean


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
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		Public Sub New(folFactura As System.String)

			InitClassFetch(folFactura, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folFactura As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folFactura, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="validator">The custom validator Object for this CabFacturasEntity</param>
		Public Sub New(folFactura As System.String, validator As IValidator)

			InitClassFetch(folFactura, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detFacturas = CType(info.GetValue("_detFacturas", GetType(Integralab.ORM.CollectionClasses.DetFacturasCollection)), Integralab.ORM.CollectionClasses.DetFacturasCollection)
			_alwaysFetchDetFacturas = info.GetBoolean("_alwaysFetchDetFacturas")
			_alreadyFetchedDetFacturas = info.GetBoolean("_alreadyFetchedDetFacturas")
			_mcgcatTiposdeGanadoCollectionViaDetFacturas = CType(info.GetValue("_mcgcatTiposdeGanadoCollectionViaDetFacturas", GetType(Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)), Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection)
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas")
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas")
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(SalidaGanadoCabEntity)), SalidaGanadoCabEntity)
			If Not _salidaGanadoCab Is Nothing Then
				AddHandler _salidaGanadoCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_salidaGanadoCabReturnsNewIfNotFound = info.GetBoolean("_salidaGanadoCabReturnsNewIfNotFound")
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_poliza = CType(info.GetValue("_poliza", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza Is Nothing Then
				AddHandler _poliza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_polizaReturnsNewIfNotFound = info.GetBoolean("_polizaReturnsNewIfNotFound")
			_alwaysFetchPoliza = info.GetBoolean("_alwaysFetchPoliza")
			_alreadyFetchedPoliza = info.GetBoolean("_alreadyFetchedPoliza")
			_poliza_ = CType(info.GetValue("_poliza_", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza_ Is Nothing Then
				AddHandler _poliza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_poliza_ReturnsNewIfNotFound = info.GetBoolean("_poliza_ReturnsNewIfNotFound")
			_alwaysFetchPoliza_ = info.GetBoolean("_alwaysFetchPoliza_")
			_alreadyFetchedPoliza_ = info.GetBoolean("_alreadyFetchedPoliza_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetFacturas = (_detFacturas.Count > 0)
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas = (_mcgcatTiposdeGanadoCollectionViaDetFacturas.Count > 0)
			_alreadyFetchedSalidaGanadoCab = Not(_salidaGanadoCab Is Nothing)
			_alreadyFetchedPoliza = Not(_poliza Is Nothing)
			_alreadyFetchedPoliza_ = Not(_poliza_ Is Nothing)

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
			info.AddValue("_detFacturas", _detFacturas)
			info.AddValue("_alwaysFetchDetFacturas", _alwaysFetchDetFacturas)
			info.AddValue("_alreadyFetchedDetFacturas", _alreadyFetchedDetFacturas)
			info.AddValue("_mcgcatTiposdeGanadoCollectionViaDetFacturas", _mcgcatTiposdeGanadoCollectionViaDetFacturas)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas", _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas", _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas)
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_salidaGanadoCabReturnsNewIfNotFound", _salidaGanadoCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_poliza", _poliza)
			info.AddValue("_polizaReturnsNewIfNotFound", _polizaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza", _alwaysFetchPoliza)
			info.AddValue("_alreadyFetchedPoliza", _alreadyFetchedPoliza)
			info.AddValue("_poliza_", _poliza_)
			info.AddValue("_poliza_ReturnsNewIfNotFound", _poliza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza_", _alwaysFetchPoliza_)
			info.AddValue("_alreadyFetchedPoliza_", _alreadyFetchedPoliza_)

			
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
				Case "SalidaGanadoCab"
					_alreadyFetchedSalidaGanadoCab = True
					Me.SalidaGanadoCab = CType(entity, SalidaGanadoCabEntity)
				Case "Poliza"
					_alreadyFetchedPoliza = True
					Me.Poliza = CType(entity, PolizaEntity)
				Case "Poliza_"
					_alreadyFetchedPoliza_ = True
					Me.Poliza_ = CType(entity, PolizaEntity)
				Case "DetFacturas"
					_alreadyFetchedDetFacturas = True
					If Not entity Is Nothing Then
						Me.DetFacturas.Add(CType(entity, DetFacturasEntity))
					End If
				Case "McgcatTiposdeGanadoCollectionViaDetFacturas"
					_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas = True
					If Not entity Is Nothing Then
						Me.McgcatTiposdeGanadoCollectionViaDetFacturas.Add(CType(entity, McgcatTiposdeGanadoEntity))
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
				Case "SalidaGanadoCab"
					SetupSyncSalidaGanadoCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza"
					SetupSyncPoliza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza_"
					SetupSyncPoliza_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetFacturas"
					_detFacturas.Add(CType(relatedEntity, DetFacturasEntity))
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
				Case "SalidaGanadoCab"
					DesetupSyncSalidaGanadoCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza"
					DesetupSyncPoliza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza_"
					DesetupSyncPoliza_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetFacturas"
					MyBase.PerformRelatedEntityRemoval(_detFacturas, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _salidaGanadoCab Is Nothing Then
				toReturn.Add(_salidaGanadoCab)
			End If
			If Not _poliza Is Nothing Then
				toReturn.Add(_poliza)
			End If
			If Not _poliza_ Is Nothing Then
				toReturn.Add(_poliza_)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detFacturas)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folFactura As System.String) As Boolean
			Return FetchUsingPK(folFactura, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folFactura As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folFactura, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folFactura, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolFactura, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabFacturasFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabFacturasFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetFacturasEntity'</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, _detFacturas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetFacturasEntity'</returns>
		Public Function GetMultiDetFacturas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Return GetMultiDetFacturas(forceFetch, _detFacturas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetFacturasCollection
			If ( Not _alreadyFetchedDetFacturas Or forceFetch Or _alwaysFetchDetFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detFacturas)
					End If
				End If
				_detFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_detFacturas.GetMultiManyToOne(Me, Nothing, Filter)
				_detFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedDetFacturas = True
			End If
			Return _detFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetFacturas'. These settings will be taken into account
		''' when the property DetFacturas is requested or GetMultiDetFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detFacturas.SortClauses=sortClauses
			_detFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatTiposdeGanadoEntity'</returns>
		Public Function GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Return GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas(forceFetch, _mcgcatTiposdeGanadoCollectionViaDetFacturas.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			If ( Not _alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas Or forceFetch Or _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatTiposdeGanadoCollectionViaDetFacturas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatTiposdeGanadoCollectionViaDetFacturas)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabFacturasEntity.Relations.DetFacturasEntityUsingFolFactura, "__CabFacturasEntity__", "DetFacturas_", JoinHint.None)
				relations.Add(DetFacturasEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, "DetFacturas_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabFacturasFieldIndex.FolFactura), ComparisonOperator.Equal, Me.FolFactura))
				_mcgcatTiposdeGanadoCollectionViaDetFacturas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatTiposdeGanadoCollectionViaDetFacturas.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatTiposdeGanadoCollectionViaDetFacturas.GetMulti(Filter, relations)
				_mcgcatTiposdeGanadoCollectionViaDetFacturas.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas = True
			End If
			Return _mcgcatTiposdeGanadoCollectionViaDetFacturas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatTiposdeGanadoCollectionViaDetFacturas'. These settings will be taken into account
		''' when the property McgcatTiposdeGanadoCollectionViaDetFacturas is requested or GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatTiposdeGanadoCollectionViaDetFacturas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatTiposdeGanadoCollectionViaDetFacturas.SortClauses=sortClauses
			_mcgcatTiposdeGanadoCollectionViaDetFacturas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'SalidaGanadoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SalidaGanadoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSalidaGanadoCab() As SalidaGanadoCabEntity
			Return GetSingleSalidaGanadoCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SalidaGanadoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SalidaGanadoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSalidaGanadoCab(forceFetch As Boolean) As SalidaGanadoCabEntity
			If ( Not _alreadyFetchedSalidaGanadoCab Or forceFetch Or _alwaysFetchSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SalidaGanadoCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia) Then
					fetchResult = newEntity.FetchUsingPK(Me.Referencia.GetValueOrDefault())
				End If
				If Not _salidaGanadoCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.SalidaGanadoCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SalidaGanadoCabEntity)
					End If
					Me.SalidaGanadoCab = newEntity
					_alreadyFetchedSalidaGanadoCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _salidaGanadoCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza() As PolizaEntity
			Return GetSinglePoliza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza Or forceFetch Or _alwaysFetchPoliza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolPoliza.GetValueOrDefault())
				End If
				If Not _polizaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza = newEntity
					_alreadyFetchedPoliza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_() As PolizaEntity
			Return GetSinglePoliza_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza_ Or forceFetch Or _alwaysFetchPoliza_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolCanPoliza.GetValueOrDefault())
				End If
				If Not _poliza_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza_ = newEntity
					_alreadyFetchedPoliza_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza_
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabFacturasFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabFacturasFieldIndex)



					Case CabFacturasFieldIndex.Referencia
						DesetupSyncSalidaGanadoCab(True, False)
						_alreadyFetchedSalidaGanadoCab = False












					Case CabFacturasFieldIndex.FolPoliza
						DesetupSyncPoliza(True, False)
						_alreadyFetchedPoliza = False


					Case CabFacturasFieldIndex.FolCanPoliza
						DesetupSyncPoliza_(True, False)
						_alreadyFetchedPoliza_ = False











					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detFacturas.ActiveContext = MyBase.ActiveContext
			_mcgcatTiposdeGanadoCollectionViaDetFacturas.ActiveContext = MyBase.ActiveContext
		If Not _salidaGanadoCab Is Nothing Then
				_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza Is Nothing Then
				_poliza.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza_ Is Nothing Then
				_poliza_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabFacturasDAO = CType(CreateDAOInstance(), CabFacturasDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabFacturasDAO = CType(CreateDAOInstance(), CabFacturasDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabFacturasDAO = CType(CreateDAOInstance(), CabFacturasDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabFacturasEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabFacturasEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="validator">The validator Object for this CabFacturasEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folFactura As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folFactura, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detFacturas = New Integralab.ORM.CollectionClasses.DetFacturasCollection(New DetFacturasEntityFactory())
			_detFacturas.SetContainingEntityInfo(Me, "CabFacturas")
			_alwaysFetchDetFacturas = False
			_alreadyFetchedDetFacturas = False
			_mcgcatTiposdeGanadoCollectionViaDetFacturas = New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(New McgcatTiposdeGanadoEntityFactory())
			_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas = False
			_alreadyFetchedMcgcatTiposdeGanadoCollectionViaDetFacturas = False
			_salidaGanadoCab = Nothing
			_salidaGanadoCabReturnsNewIfNotFound = True
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_poliza = Nothing
			_polizaReturnsNewIfNotFound = True
			_alwaysFetchPoliza = False
			_alreadyFetchedPoliza = False
			_poliza_ = Nothing
			_poliza_ReturnsNewIfNotFound = True
			_alwaysFetchPoliza_ = False
			_alreadyFetchedPoliza_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveUs", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoFactu", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("StaFacturacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCred", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecVenci", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteDescto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Status", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoCancel", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecCanConta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolCanPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PtjIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Uuid", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LugarExpedicion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FormaPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MetodoPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsoCfdi", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _salidaGanadoCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSalidaGanadoCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _salidaGanadoCab, AddressOf OnSalidaGanadoCabPropertyChanged, "SalidaGanadoCab", CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia, True, signalRelatedEntity, "CabFacturas", resetFKFields, New Integer() { CInt(CabFacturasFieldIndex.Referencia) } )
			_salidaGanadoCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _salidaGanadoCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSalidaGanadoCab(relatedEntity As IEntity)
			DesetupSyncSalidaGanadoCab(True, True)
			_salidaGanadoCab = CType(relatedEntity, SalidaGanadoCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _salidaGanadoCab, AddressOf OnSalidaGanadoCabPropertyChanged, "SalidaGanadoCab", CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia, True, _alreadyFetchedSalidaGanadoCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSalidaGanadoCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza, True, signalRelatedEntity, "CabFacturas", resetFKFields, New Integer() { CInt(CabFacturasFieldIndex.FolPoliza) } )
			_poliza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza(relatedEntity As IEntity)
			DesetupSyncPoliza(True, True)
			_poliza = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza, True, _alreadyFetchedPoliza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPolizaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza, True, signalRelatedEntity, "CabFacturas_", resetFKFields, New Integer() { CInt(CabFacturasFieldIndex.FolCanPoliza) } )
			_poliza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza_(relatedEntity As IEntity)
			DesetupSyncPoliza_(True, True)
			_poliza_ = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza, True, _alreadyFetchedPoliza_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPoliza_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folFactura">PK value for CabFacturas which data should be fetched into this CabFacturas Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabFacturasFieldIndex.FolFactura)).ForcedCurrentValueWrite(folFactura)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabFacturasDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabFacturasEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabFacturasRelations
			Get	
				Return New CabFacturasRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetFacturas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetFacturas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetFacturasCollection(), _
					CabFacturasEntity.Relations.DetFacturasEntityUsingFolFactura, _
					CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), CType(Integralab.ORM.EntityType.DetFacturasEntity, Integer), 0, Nothing, Nothing, Nothing, "DetFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanadoCollectionViaDetFacturas() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabFacturasEntity.Relations.DetFacturasEntityUsingFolFactura, "__CabFacturasEntity__", String.Empty, JoinHint.None)
				relations.Add(DetFacturasEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					CabFacturasEntity.Relations.DetFacturasEntityUsingFolFactura, _
					CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, relations, "McgcatTiposdeGanadoCollectionViaDetFacturas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					CabFacturasEntity.Relations.SalidaGanadoCabEntityUsingReferencia, _
					CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CabFacturasEntity.Relations.PolizaEntityUsingFolPoliza, _
					CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					CabFacturasEntity.Relations.PolizaEntityUsingFolCanPoliza, _
					CType(Integralab.ORM.EntityType.CabFacturasEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabFacturasEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabFacturasEntity.CustomProperties
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
				Return CabFacturasEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolFactura property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fol_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FolFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FolFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecFactura property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecFactura]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecFactura, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecCaptura property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_Captura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecCaptura]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecCaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Referencia, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveUs property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."CveUs"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CveUs]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.CveUs, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.CveUs, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoFactu property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."TipoFactu"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoFactu]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.TipoFactu, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.TipoFactu, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveCliente property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Cve_Cliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CveCliente]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.CveCliente, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.CveCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The StaFacturacion property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Sta_Facturacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [StaFacturacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.StaFacturacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.StaFacturacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCred property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."DiasCred"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DiasCred]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.DiasCred, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.DiasCred, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecVenci property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_Venci"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecVenci]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecVenci, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecVenci, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.SubTotal, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteDescto property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."ImpteDescto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImpteDescto]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.ImpteDescto, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.ImpteDescto, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteIva property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."ImpteIVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImpteIva]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.ImpteIva, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.ImpteIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Status property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Status"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Status]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Status, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Status, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoCancel property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."MotivoCancel"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoCancel]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.MotivoCancel, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.MotivoCancel, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecConta property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_Conta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolPoliza property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fol_Poliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolPoliza]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FolPoliza, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FolPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecCancelacion property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_Cancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecCanConta property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fec_CanConta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecCanConta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FecCanConta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FecCanConta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolCanPoliza property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Fol_CanPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolCanPoliza]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FolCanPoliza, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FolCanPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cabezas property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Cabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Cabezas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Cabezas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Cabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Kilos, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The PtjIva property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Ptj_IVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PtjIva]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.PtjIva, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.PtjIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Uuid property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."UUID"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Uuid]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Uuid, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Uuid, Integer), value)
			End Set
		End Property
	
		''' <summary>The LugarExpedicion property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."LugarExpedicion"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LugarExpedicion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.LugarExpedicion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.LugarExpedicion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FormaPago property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."FormaPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FormaPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.FormaPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.FormaPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The MetodoPago property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."MetodoPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MetodoPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.MetodoPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.MetodoPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumCta property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."NumCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.NumCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.NumCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsoCfdi property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."UsoCFDI"<br/>
		''' Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsoCfdi]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.UsoCfdi, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.UsoCfdi, Integer), value)
			End Set
		End Property
	
		''' <summary>The Direccion property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Direccion"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Direccion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Direccion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Direccion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity CabFacturas<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabFacturas"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabFacturasFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabFacturasFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetFacturasEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetFacturas]() As Integralab.ORM.CollectionClasses.DetFacturasCollection
			Get
				Return GetMultiDetFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetFacturas. When set to true, DetFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetFacturas As Boolean
			Get
				Return _alwaysFetchDetFacturas
			End Get
			Set
				_alwaysFetchDetFacturas = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'McgcatTiposdeGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatTiposdeGanadoCollectionViaDetFacturas]() As Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection
			Get
				Return GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanadoCollectionViaDetFacturas. When set to true, McgcatTiposdeGanadoCollectionViaDetFacturas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanadoCollectionViaDetFacturas is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatTiposdeGanadoCollectionViaDetFacturas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanadoCollectionViaDetFacturas = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'SalidaGanadoCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [SalidaGanadoCab]() As SalidaGanadoCabEntity
			Get
				Return GetSingleSalidaGanadoCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSalidaGanadoCab(value)
				Else
					If value Is Nothing Then
						If Not _salidaGanadoCab Is Nothing Then
							_salidaGanadoCab.UnsetRelatedEntity(Me, "CabFacturas")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabFacturas")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCab. When set to true, SalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCab
			End Get
			Set
				_alwaysFetchSalidaGanadoCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property SalidaGanadoCab is not found
		''' in the database. When set to true, SalidaGanadoCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SalidaGanadoCabReturnsNewIfNotFound As Boolean
			Get
				Return _salidaGanadoCabReturnsNewIfNotFound
			End Get
			Set
				_salidaGanadoCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza]() As PolizaEntity
			Get
				Return GetSinglePoliza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza(value)
				Else
					If value Is Nothing Then
						If Not _poliza Is Nothing Then
							_poliza.UnsetRelatedEntity(Me, "CabFacturas")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabFacturas")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza. When set to true, Poliza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza As Boolean
			Get
				Return _alwaysFetchPoliza
			End Get
			Set
				_alwaysFetchPoliza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza is not found
		''' in the database. When set to true, Poliza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PolizaReturnsNewIfNotFound As Boolean
			Get
				Return _polizaReturnsNewIfNotFound
			End Get
			Set
				_polizaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza_]() As PolizaEntity
			Get
				Return GetSinglePoliza_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza_(value)
				Else
					If value Is Nothing Then
						If Not _poliza_ Is Nothing Then
							_poliza_.UnsetRelatedEntity(Me, "CabFacturas_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabFacturas_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza_. When set to true, Poliza_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza_ is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza_ As Boolean
			Get
				Return _alwaysFetchPoliza_
			End Get
			Set
				_alwaysFetchPoliza_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza_ is not found
		''' in the database. When set to true, Poliza_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Poliza_ReturnsNewIfNotFound As Boolean
			Get
				Return _poliza_ReturnsNewIfNotFound
			End Get
			Set
				_poliza_ReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CabFacturasEntity)
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
