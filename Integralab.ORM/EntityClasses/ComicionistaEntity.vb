' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 12:00:02
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
	''' <summary>Entity class which represents the entity 'Comicionista'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ComicionistaEntity 
#Else
	<Serializable()> _
	Public Class ComicionistaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mfacCatClientes As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes As Boolean
		Private _cuentaContableCollectionViaMfacCatClientes As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaMfacCatClientes, _alreadyFetchedCuentaContableCollectionViaMfacCatClientes As Boolean
		Private _cuentaContableCollectionViaMfacCatClientes_ As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaMfacCatClientes_, _alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ As Boolean
		Private _tipoComicionista_ As TipoComicionistaEntity
		Private _alwaysFetchTipoComicionista_, _alreadyFetchedTipoComicionista_, _tipoComicionista_ReturnsNewIfNotFound As Boolean
		Private _plaza_ As PlazaEntity
		Private _alwaysFetchPlaza_, _alreadyFetchedPlaza_, _plaza_ReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <param name="validator">The custom validator Object for this ComicionistaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(Integralab.ORM.CollectionClasses.MfacCatClientesCollection)), Integralab.ORM.CollectionClasses.MfacCatClientesCollection)
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")
			_cuentaContableCollectionViaMfacCatClientes = CType(info.GetValue("_cuentaContableCollectionViaMfacCatClientes", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaMfacCatClientes = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaMfacCatClientes")
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaMfacCatClientes")
			_cuentaContableCollectionViaMfacCatClientes_ = CType(info.GetValue("_cuentaContableCollectionViaMfacCatClientes_", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaMfacCatClientes_ = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaMfacCatClientes_")
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_")
			_tipoComicionista_ = CType(info.GetValue("_tipoComicionista_", GetType(TipoComicionistaEntity)), TipoComicionistaEntity)
			If Not _tipoComicionista_ Is Nothing Then
				AddHandler _tipoComicionista_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoComicionista_ReturnsNewIfNotFound = info.GetBoolean("_tipoComicionista_ReturnsNewIfNotFound")
			_alwaysFetchTipoComicionista_ = info.GetBoolean("_alwaysFetchTipoComicionista_")
			_alreadyFetchedTipoComicionista_ = info.GetBoolean("_alreadyFetchedTipoComicionista_")
			_plaza_ = CType(info.GetValue("_plaza_", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza_ Is Nothing Then
				AddHandler _plaza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plaza_ReturnsNewIfNotFound = info.GetBoolean("_plaza_ReturnsNewIfNotFound")
			_alwaysFetchPlaza_ = info.GetBoolean("_alwaysFetchPlaza_")
			_alreadyFetchedPlaza_ = info.GetBoolean("_alreadyFetchedPlaza_")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMfacCatClientes = (_mfacCatClientes.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes = (_cuentaContableCollectionViaMfacCatClientes.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ = (_cuentaContableCollectionViaMfacCatClientes_.Count > 0)
			_alreadyFetchedTipoComicionista_ = Not(_tipoComicionista_ Is Nothing)
			_alreadyFetchedPlaza_ = Not(_plaza_ Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)

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
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			info.AddValue("_cuentaContableCollectionViaMfacCatClientes", _cuentaContableCollectionViaMfacCatClientes)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaMfacCatClientes", _alwaysFetchCuentaContableCollectionViaMfacCatClientes)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaMfacCatClientes", _alreadyFetchedCuentaContableCollectionViaMfacCatClientes)
			info.AddValue("_cuentaContableCollectionViaMfacCatClientes_", _cuentaContableCollectionViaMfacCatClientes_)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaMfacCatClientes_", _alwaysFetchCuentaContableCollectionViaMfacCatClientes_)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_", _alreadyFetchedCuentaContableCollectionViaMfacCatClientes_)
			info.AddValue("_tipoComicionista_", _tipoComicionista_)
			info.AddValue("_tipoComicionista_ReturnsNewIfNotFound", _tipoComicionista_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoComicionista_", _alwaysFetchTipoComicionista_)
			info.AddValue("_alreadyFetchedTipoComicionista_", _alreadyFetchedTipoComicionista_)
			info.AddValue("_plaza_", _plaza_)
			info.AddValue("_plaza_ReturnsNewIfNotFound", _plaza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza_", _alwaysFetchPlaza_)
			info.AddValue("_alreadyFetchedPlaza_", _alreadyFetchedPlaza_)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)

			
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
				Case "TipoComicionista_"
					_alreadyFetchedTipoComicionista_ = True
					Me.TipoComicionista_ = CType(entity, TipoComicionistaEntity)
				Case "Plaza_"
					_alreadyFetchedPlaza_ = True
					Me.Plaza_ = CType(entity, PlazaEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					If Not entity Is Nothing Then
						Me.MfacCatClientes.Add(CType(entity, MfacCatClientesEntity))
					End If
				Case "CuentaContableCollectionViaMfacCatClientes"
					_alreadyFetchedCuentaContableCollectionViaMfacCatClientes = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaMfacCatClientes.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaContableCollectionViaMfacCatClientes_"
					_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaMfacCatClientes_.Add(CType(entity, CuentaContableEntity))
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
				Case "TipoComicionista_"
					SetupSyncTipoComicionista_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Plaza_"
					SetupSyncPlaza_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes"
					_mfacCatClientes.Add(CType(relatedEntity, MfacCatClientesEntity))
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
				Case "TipoComicionista_"
					DesetupSyncTipoComicionista_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Plaza_"
					DesetupSyncPlaza_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes"
					MyBase.PerformRelatedEntityRemoval(_mfacCatClientes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _tipoComicionista_ Is Nothing Then
				toReturn.Add(_tipoComicionista_)
			End If
			If Not _plaza_ Is Nothing Then
				toReturn.Add(_plaza_)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mfacCatClientes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ComicionistaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ComicionistaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiMfacCatClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiMfacCatClientes(forceFetch, _mfacCatClientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMfacCatClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiMfacCatClientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacCatClientesEntity'</returns>
		Public Function GetMultiMfacCatClientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Return GetMultiMfacCatClientes(forceFetch, _mfacCatClientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacCatClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			If ( Not _alreadyFetchedMfacCatClientes Or forceFetch Or _alwaysFetchMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacCatClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacCatClientes)
					End If
				End If
				_mfacCatClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacCatClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacCatClientes.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_mfacCatClientes.SuppressClearInGetMulti = False
				_alreadyFetchedMfacCatClientes = True
			End If
			Return _mfacCatClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacCatClientes'. These settings will be taken into account
		''' when the property MfacCatClientes is requested or GetMultiMfacCatClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacCatClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacCatClientes.SortClauses=sortClauses
			_mfacCatClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaMfacCatClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaMfacCatClientes(forceFetch, _cuentaContableCollectionViaMfacCatClientes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaMfacCatClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaMfacCatClientes Or forceFetch Or _alwaysFetchCuentaContableCollectionViaMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaMfacCatClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaMfacCatClientes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, "__ComicionistaEntity__", "MfacCatClientes_", JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId, "MfacCatClientes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ComicionistaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaMfacCatClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaMfacCatClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaMfacCatClientes.GetMulti(Filter, relations)
				_cuentaContableCollectionViaMfacCatClientes.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaMfacCatClientes = True
			End If
			Return _cuentaContableCollectionViaMfacCatClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaMfacCatClientes'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaMfacCatClientes is requested or GetMultiCuentaContableCollectionViaMfacCatClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaMfacCatClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaMfacCatClientes.SortClauses=sortClauses
			_cuentaContableCollectionViaMfacCatClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaMfacCatClientes_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaMfacCatClientes_(forceFetch, _cuentaContableCollectionViaMfacCatClientes_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaMfacCatClientes_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ Or forceFetch Or _alwaysFetchCuentaContableCollectionViaMfacCatClientes_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaMfacCatClientes_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaMfacCatClientes_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, "__ComicionistaEntity__", "MfacCatClientes_", JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId, "MfacCatClientes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ComicionistaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaMfacCatClientes_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaMfacCatClientes_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaMfacCatClientes_.GetMulti(Filter, relations)
				_cuentaContableCollectionViaMfacCatClientes_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ = True
			End If
			Return _cuentaContableCollectionViaMfacCatClientes_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaMfacCatClientes_'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaMfacCatClientes_ is requested or GetMultiCuentaContableCollectionViaMfacCatClientes_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaMfacCatClientes_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaMfacCatClientes_.SortClauses=sortClauses
			_cuentaContableCollectionViaMfacCatClientes_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'TipoComicionistaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoComicionistaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoComicionista_() As TipoComicionistaEntity
			Return GetSingleTipoComicionista_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoComicionistaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoComicionistaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoComicionista_(forceFetch As Boolean) As TipoComicionistaEntity
			If ( Not _alreadyFetchedTipoComicionista_ Or forceFetch Or _alwaysFetchTipoComicionista_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoComicionistaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoComisionista)
				End If
				If Not _tipoComicionista_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoComicionista_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoComicionistaEntity)
					End If
					Me.TipoComicionista_ = newEntity
					_alreadyFetchedTipoComicionista_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoComicionista_
		End Function
	
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
				If MyBase.CheckIfLazyLoadingShouldOccur(ComicionistaEntity.Relations.PlazaEntityUsingPlaza) Then
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
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable() As CuentaContableEntity
			Return GetSingleCuentaContable(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaContable Or forceFetch Or _alwaysFetchCuentaContable) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCuentaContable)
				End If
				If Not _cuentaContableReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaContable = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaContable = newEntity
					_alreadyFetchedCuentaContable = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaContable
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ComicionistaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ComicionistaFieldIndex)




					Case ComicionistaFieldIndex.Plaza
						DesetupSyncPlaza_(True, False)
						_alreadyFetchedPlaza_ = False
					Case ComicionistaFieldIndex.TipoComisionista
						DesetupSyncTipoComicionista_(True, False)
						_alreadyFetchedTipoComicionista_ = False

















					Case ComicionistaFieldIndex.IdCuentaContable
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaMfacCatClientes.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaMfacCatClientes_.ActiveContext = MyBase.ActiveContext
		If Not _tipoComicionista_ Is Nothing Then
				_tipoComicionista_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _plaza_ Is Nothing Then
				_plaza_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ComicionistaDAO = CType(CreateDAOInstance(), ComicionistaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ComicionistaDAO = CType(CreateDAOInstance(), ComicionistaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ComicionistaDAO = CType(CreateDAOInstance(), ComicionistaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ComicionistaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ComicionistaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <param name="validator">The validator Object for this ComicionistaEntity</param>
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
			_mfacCatClientes = New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(New MfacCatClientesEntityFactory())
			_mfacCatClientes.SetContainingEntityInfo(Me, "Comicionista")
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			_cuentaContableCollectionViaMfacCatClientes = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaMfacCatClientes = False
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes = False
			_cuentaContableCollectionViaMfacCatClientes_ = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaMfacCatClientes_ = False
			_alreadyFetchedCuentaContableCollectionViaMfacCatClientes_ = False
			_tipoComicionista_ = Nothing
			_tipoComicionista_ReturnsNewIfNotFound = True
			_alwaysFetchTipoComicionista_ = False
			_alreadyFetchedTipoComicionista_ = False
			_plaza_ = Nothing
			_plaza_ReturnsNewIfNotFound = True
			_alwaysFetchPlaza_ = False
			_alreadyFetchedPlaza_ = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False

			
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

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Apaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Amaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Plaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoComisionista", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Ciudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Poblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Email", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Zona", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaTel1", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaTel2", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaFax", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono1", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono2", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fax", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCuentaContable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Porcentaje", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Sueldo", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _tipoComicionista_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoComicionista_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoComicionista_, AddressOf OnTipoComicionista_PropertyChanged, "TipoComicionista_", ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, True, signalRelatedEntity, "Comicionista", resetFKFields, New Integer() { CInt(ComicionistaFieldIndex.TipoComisionista) } )
			_tipoComicionista_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoComicionista_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoComicionista_(relatedEntity As IEntity)
			DesetupSyncTipoComicionista_(True, True)
			_tipoComicionista_ = CType(relatedEntity, TipoComicionistaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoComicionista_, AddressOf OnTipoComicionista_PropertyChanged, "TipoComicionista_", ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, True, _alreadyFetchedTipoComicionista_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoComicionista_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _plaza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", ComicionistaEntity.Relations.PlazaEntityUsingPlaza, True, signalRelatedEntity, "Comicionista", resetFKFields, New Integer() { CInt(ComicionistaFieldIndex.Plaza) } )
			_plaza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza_(relatedEntity As IEntity)
			DesetupSyncPlaza_(True, True)
			_plaza_ = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza_, AddressOf OnPlaza_PropertyChanged, "Plaza_", ComicionistaEntity.Relations.PlazaEntityUsingPlaza, True, _alreadyFetchedPlaza_, New String() {  } )
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
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, signalRelatedEntity, "Comicionista", resetFKFields, New Integer() { CInt(ComicionistaFieldIndex.IdCuentaContable) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, _alreadyFetchedCuentaContable, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaContablePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Comicionista which data should be fetched into this Comicionista Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ComicionistaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateComicionistaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ComicionistaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ComicionistaRelations
			Get	
				Return New ComicionistaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaMfacCatClientes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, "__ComicionistaEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaMfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaMfacCatClientes_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, "__ComicionistaEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ComicionistaEntity.Relations.MfacCatClientesEntityUsingIdVendedor, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaMfacCatClientes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoComicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoComicionista_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoComicionistaCollection(), _
					ComicionistaEntity.Relations.TipoComicionistaEntityUsingTipoComisionista, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.TipoComicionistaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoComicionista_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ComicionistaEntity.Relations.PlazaEntityUsingPlaza, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ComicionistaEntity.Relations.CuentaContableEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ComicionistaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ComicionistaEntity.CustomProperties
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
				Return ComicionistaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombre property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Nombre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Nombre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Nombre, Integer), value)
			End Set
		End Property
	
		''' <summary>The Apaterno property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."APaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Apaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Apaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Apaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The Amaterno property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."AMaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Amaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Amaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Amaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The Plaza property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Plaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Plaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Plaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Plaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoComisionista property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."TipoComicionista"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoComisionista]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.TipoComisionista, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.TipoComisionista, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Domicilio property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Domicilio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Domicilio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Domicilio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Domicilio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Colonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPostal property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."CodigoPostal"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPostal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.CodigoPostal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.CodigoPostal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estado property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Estado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Estado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Estado, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ciudad property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Ciudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Ciudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Ciudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Ciudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Poblacion property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Poblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Poblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Poblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Poblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Email property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Email"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Email]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Email, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Email, Integer), value)
			End Set
		End Property
	
		''' <summary>The Zona property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Zona"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Zona]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Zona, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Zona, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaTel1 property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."LadaTel1"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaTel1]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.LadaTel1, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.LadaTel1, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaTel2 property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."LadaTel2"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaTel2]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.LadaTel2, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.LadaTel2, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaFax property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."LadaFax"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaFax]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.LadaFax, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.LadaFax, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono1 property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Telefono1"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Telefono1]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Telefono1, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Telefono1, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono2 property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Telefono2"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Telefono2]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Telefono2, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Telefono2, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fax property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Fax"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Fax]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Fax, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Fax, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."RFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCuentaContable property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."IdCuentaContable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCuentaContable]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.IdCuentaContable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.IdCuentaContable, Integer), value)
			End Set
		End Property
	
		''' <summary>The Porcentaje property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Porcentaje"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Porcentaje]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Porcentaje, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Porcentaje, Integer), value)
			End Set
		End Property
	
		''' <summary>The Sueldo property of the Entity Comicionista<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompComicionista"."Sueldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Sueldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ComicionistaFieldIndex.Sueldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ComicionistaFieldIndex.Sueldo, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MfacCatClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacCatClientes]() As Integralab.ORM.CollectionClasses.MfacCatClientesCollection
			Get
				Return GetMultiMfacCatClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacCatClientes. When set to true, MfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacCatClientes As Boolean
			Get
				Return _alwaysFetchMfacCatClientes
			End Get
			Set
				_alwaysFetchMfacCatClientes = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaMfacCatClientes]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaMfacCatClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaMfacCatClientes. When set to true, CuentaContableCollectionViaMfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaMfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaMfacCatClientes As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaMfacCatClientes
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaMfacCatClientes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaMfacCatClientes_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaMfacCatClientes_]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaMfacCatClientes_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaMfacCatClientes_. When set to true, CuentaContableCollectionViaMfacCatClientes_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaMfacCatClientes_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaMfacCatClientes_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaMfacCatClientes_ As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaMfacCatClientes_
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaMfacCatClientes_ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'TipoComicionistaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoComicionista_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoComicionista_]() As TipoComicionistaEntity
			Get
				Return GetSingleTipoComicionista_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoComicionista_(value)
				Else
					If value Is Nothing Then
						If Not _tipoComicionista_ Is Nothing Then
							_tipoComicionista_.UnsetRelatedEntity(Me, "Comicionista")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Comicionista")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoComicionista_. When set to true, TipoComicionista_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoComicionista_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoComicionista_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoComicionista_ As Boolean
			Get
				Return _alwaysFetchTipoComicionista_
			End Get
			Set
				_alwaysFetchTipoComicionista_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoComicionista_ is not found
		''' in the database. When set to true, TipoComicionista_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoComicionista_ReturnsNewIfNotFound As Boolean
			Get
				Return _tipoComicionista_ReturnsNewIfNotFound
			End Get
			Set
				_tipoComicionista_ReturnsNewIfNotFound = value
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
							_plaza_.UnsetRelatedEntity(Me, "Comicionista")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Comicionista")
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
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaContable()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaContable]() As CuentaContableEntity
			Get
				Return GetSingleCuentaContable(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaContable(value)
				Else
					If value Is Nothing Then
						If Not _cuentaContable Is Nothing Then
							_cuentaContable.UnsetRelatedEntity(Me, "Comicionista")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Comicionista")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable. When set to true, CuentaContable is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaContable(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable As Boolean
			Get
				Return _alwaysFetchCuentaContable
			End Get
			Set
				_alwaysFetchCuentaContable = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaContable is not found
		''' in the database. When set to true, CuentaContable will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaContableReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaContableReturnsNewIfNotFound
			End Get
			Set
				_cuentaContableReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ComicionistaEntity)
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
