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
	''' <summary>Entity class which represents the entity 'Beneficiario'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class BeneficiarioEntity 
#Else
	<Serializable()> _
	Public Class BeneficiarioEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cheque As Integralab.ORM.CollectionClasses.ChequeCollection
		Private _alwaysFetchCheque, _alreadyFetchedCheque As Boolean
		Private _cuentaCollectionViaCheque As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque, _alreadyFetchedCuentaCollectionViaCheque As Boolean
		Private _cuentaCollectionViaCheque_ As Integralab.ORM.CollectionClasses.CuentaCollection
		Private _alwaysFetchCuentaCollectionViaCheque_, _alreadyFetchedCuentaCollectionViaCheque_ As Boolean
		Private _polizaCollectionViaCheque As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque, _alreadyFetchedPolizaCollectionViaCheque As Boolean
		Private _polizaCollectionViaCheque_ As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaCheque_, _alreadyFetchedPolizaCollectionViaCheque_ As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <param name="validator">The custom validator Object for this BeneficiarioEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cheque = CType(info.GetValue("_cheque", GetType(Integralab.ORM.CollectionClasses.ChequeCollection)), Integralab.ORM.CollectionClasses.ChequeCollection)
			_alwaysFetchCheque = info.GetBoolean("_alwaysFetchCheque")
			_alreadyFetchedCheque = info.GetBoolean("_alreadyFetchedCheque")
			_cuentaCollectionViaCheque = CType(info.GetValue("_cuentaCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque")
			_alreadyFetchedCuentaCollectionViaCheque = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque")
			_cuentaCollectionViaCheque_ = CType(info.GetValue("_cuentaCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.CuentaCollection)), Integralab.ORM.CollectionClasses.CuentaCollection)
			_alwaysFetchCuentaCollectionViaCheque_ = info.GetBoolean("_alwaysFetchCuentaCollectionViaCheque_")
			_alreadyFetchedCuentaCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedCuentaCollectionViaCheque_")
			_polizaCollectionViaCheque = CType(info.GetValue("_polizaCollectionViaCheque", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque")
			_alreadyFetchedPolizaCollectionViaCheque = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque")
			_polizaCollectionViaCheque_ = CType(info.GetValue("_polizaCollectionViaCheque_", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaCheque_ = info.GetBoolean("_alwaysFetchPolizaCollectionViaCheque_")
			_alreadyFetchedPolizaCollectionViaCheque_ = info.GetBoolean("_alreadyFetchedPolizaCollectionViaCheque_")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCheque = (_cheque.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque = (_cuentaCollectionViaCheque.Count > 0)
			_alreadyFetchedCuentaCollectionViaCheque_ = (_cuentaCollectionViaCheque_.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque = (_polizaCollectionViaCheque.Count > 0)
			_alreadyFetchedPolizaCollectionViaCheque_ = (_polizaCollectionViaCheque_.Count > 0)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)

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
			info.AddValue("_cheque", _cheque)
			info.AddValue("_alwaysFetchCheque", _alwaysFetchCheque)
			info.AddValue("_alreadyFetchedCheque", _alreadyFetchedCheque)
			info.AddValue("_cuentaCollectionViaCheque", _cuentaCollectionViaCheque)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque", _alwaysFetchCuentaCollectionViaCheque)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque", _alreadyFetchedCuentaCollectionViaCheque)
			info.AddValue("_cuentaCollectionViaCheque_", _cuentaCollectionViaCheque_)
			info.AddValue("_alwaysFetchCuentaCollectionViaCheque_", _alwaysFetchCuentaCollectionViaCheque_)
			info.AddValue("_alreadyFetchedCuentaCollectionViaCheque_", _alreadyFetchedCuentaCollectionViaCheque_)
			info.AddValue("_polizaCollectionViaCheque", _polizaCollectionViaCheque)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque", _alwaysFetchPolizaCollectionViaCheque)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque", _alreadyFetchedPolizaCollectionViaCheque)
			info.AddValue("_polizaCollectionViaCheque_", _polizaCollectionViaCheque_)
			info.AddValue("_alwaysFetchPolizaCollectionViaCheque_", _alwaysFetchPolizaCollectionViaCheque_)
			info.AddValue("_alreadyFetchedPolizaCollectionViaCheque_", _alreadyFetchedPolizaCollectionViaCheque_)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)

			
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
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)
				Case "Cheque"
					_alreadyFetchedCheque = True
					If Not entity Is Nothing Then
						Me.Cheque.Add(CType(entity, ChequeEntity))
					End If
				Case "CuentaCollectionViaCheque"
					_alreadyFetchedCuentaCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque.Add(CType(entity, CuentaEntity))
					End If
				Case "CuentaCollectionViaCheque_"
					_alreadyFetchedCuentaCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.CuentaCollectionViaCheque_.Add(CType(entity, CuentaEntity))
					End If
				Case "PolizaCollectionViaCheque"
					_alreadyFetchedPolizaCollectionViaCheque = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque.Add(CType(entity, PolizaEntity))
					End If
				Case "PolizaCollectionViaCheque_"
					_alreadyFetchedPolizaCollectionViaCheque_ = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaCheque_.Add(CType(entity, PolizaEntity))
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
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cheque"
					_cheque.Add(CType(relatedEntity, ChequeEntity))
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
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cheque"
					MyBase.PerformRelatedEntityRemoval(_cheque, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cheque)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As BeneficiarioFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As BeneficiarioFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeEntity'</returns>
		Public Function GetMultiCheque(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			Return GetMultiCheque(forceFetch, _cheque.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeCollection
			If ( Not _alreadyFetchedCheque Or forceFetch Or _alwaysFetchCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cheque)
					End If
				End If
				_cheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_cheque.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_cheque.SuppressClearInGetMulti = False
				_alreadyFetchedCheque = True
			End If
			Return _cheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Cheque'. These settings will be taken into account
		''' when the property Cheque is requested or GetMultiCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cheque.SortClauses=sortClauses
			_cheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque(forceFetch, _cuentaCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BeneficiarioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque = True
			End If
			Return _cuentaCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque is requested or GetMultiCuentaCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque.SortClauses=sortClauses
			_cuentaCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaEntity'</returns>
		Public Function GetMultiCuentaCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaCollection
			Return GetMultiCuentaCollectionViaCheque_(forceFetch, _cuentaCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaCollection
			If ( Not _alreadyFetchedCuentaCollectionViaCheque_ Or forceFetch Or _alwaysFetchCuentaCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BeneficiarioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaCollectionViaCheque_.GetMulti(Filter, relations)
				_cuentaCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaCollectionViaCheque_ = True
			End If
			Return _cuentaCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaCollectionViaCheque_'. These settings will be taken into account
		''' when the property CuentaCollectionViaCheque_ is requested or GetMultiCuentaCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaCollectionViaCheque_.SortClauses=sortClauses
			_cuentaCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque(forceFetch, _polizaCollectionViaCheque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BeneficiarioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque.GetMulti(Filter, relations)
				_polizaCollectionViaCheque.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque = True
			End If
			Return _polizaCollectionViaCheque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque is requested or GetMultiPolizaCollectionViaCheque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque.SortClauses=sortClauses
			_polizaCollectionViaCheque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaCheque_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaCheque_(forceFetch, _polizaCollectionViaCheque_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaCheque_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaCheque_ Or forceFetch Or _alwaysFetchPolizaCollectionViaCheque_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaCheque_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaCheque_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", "Cheque_", JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, "Cheque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(BeneficiarioFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaCheque_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaCheque_.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaCheque_.GetMulti(Filter, relations)
				_polizaCollectionViaCheque_.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaCheque_ = True
			End If
			Return _polizaCollectionViaCheque_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaCheque_'. These settings will be taken into account
		''' when the property PolizaCollectionViaCheque_ is requested or GetMultiPolizaCollectionViaCheque_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaCheque_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaCheque_.SortClauses=sortClauses
			_polizaCollectionViaCheque_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor() As ProveedorEntity
			Return GetSingleProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor(forceFetch As Boolean) As ProveedorEntity
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(BeneficiarioEntity.Relations.ProveedorEntityUsingCodigoProveedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoProveedor.GetValueOrDefault())
				End If
				If Not _proveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Proveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorEntity)
					End If
					Me.Proveedor = newEntity
					_alreadyFetchedProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedor
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(BeneficiarioFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, BeneficiarioFieldIndex)

					Case BeneficiarioFieldIndex.CodigoProveedor
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False



					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cheque.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_cuentaCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaCheque_.ActiveContext = MyBase.ActiveContext
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As BeneficiarioDAO = CType(CreateDAOInstance(), BeneficiarioDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As BeneficiarioDAO = CType(CreateDAOInstance(), BeneficiarioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As BeneficiarioDAO = CType(CreateDAOInstance(), BeneficiarioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this BeneficiarioEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.BeneficiarioEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <param name="validator">The validator Object for this BeneficiarioEntity</param>
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
			_cheque = New Integralab.ORM.CollectionClasses.ChequeCollection(New ChequeEntityFactory())
			_cheque.SetContainingEntityInfo(Me, "Beneficiario")
			_alwaysFetchCheque = False
			_alreadyFetchedCheque = False
			_cuentaCollectionViaCheque = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque = False
			_alreadyFetchedCuentaCollectionViaCheque = False
			_cuentaCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.CuentaCollection(New CuentaEntityFactory())
			_alwaysFetchCuentaCollectionViaCheque_ = False
			_alreadyFetchedCuentaCollectionViaCheque_ = False
			_polizaCollectionViaCheque = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque = False
			_alreadyFetchedPolizaCollectionViaCheque = False
			_polizaCollectionViaCheque_ = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaCheque_ = False
			_alreadyFetchedPolizaCollectionViaCheque_ = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False

			
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

			_fieldsCustomProperties.Add("CodigoProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Beneficiario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsProveedor", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", BeneficiarioEntity.Relations.ProveedorEntityUsingCodigoProveedor, True, signalRelatedEntity, "Beneficiario_", resetFKFields, New Integer() { CInt(BeneficiarioFieldIndex.CodigoProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", BeneficiarioEntity.Relations.ProveedorEntityUsingCodigoProveedor, True, _alreadyFetchedProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Beneficiario which data should be fetched into this Beneficiario Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(BeneficiarioFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateBeneficiarioDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New BeneficiarioEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As BeneficiarioRelations
			Get	
				Return New BeneficiarioRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cheque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCheque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeCollection(), _
					BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.ChequeEntity, Integer), 0, Nothing, Nothing, Nothing, "Cheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, relations, "CuentaCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaCheque_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, "__BeneficiarioEntity__", String.Empty, JoinHint.None)
				relations.Add(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					BeneficiarioEntity.Relations.ChequeEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaCheque_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					BeneficiarioEntity.Relations.ProveedorEntityUsingCodigoProveedor, _
					CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "BeneficiarioEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return BeneficiarioEntity.CustomProperties
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
				Return BeneficiarioEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Beneficiario<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanBeneficiarios"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BeneficiarioFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(BeneficiarioFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoProveedor property of the Entity Beneficiario<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanBeneficiarios"."CodigoProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodigoProveedor]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BeneficiarioFieldIndex.CodigoProveedor, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(BeneficiarioFieldIndex.CodigoProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The Beneficiario property of the Entity Beneficiario<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanBeneficiarios"."Beneficiario"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Beneficiario]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BeneficiarioFieldIndex.Beneficiario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(BeneficiarioFieldIndex.Beneficiario, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Beneficiario<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanBeneficiarios"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BeneficiarioFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(BeneficiarioFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsProveedor property of the Entity Beneficiario<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrBanBeneficiarios"."EsProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(BeneficiarioFieldIndex.EsProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(BeneficiarioFieldIndex.EsProveedor, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ChequeEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Cheque]() As Integralab.ORM.CollectionClasses.ChequeCollection
			Get
				Return GetMultiCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cheque. When set to true, Cheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCheque As Boolean
			Get
				Return _alwaysFetchCheque
			End Get
			Set
				_alwaysFetchCheque = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque. When set to true, CuentaCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.CuentaCollection
			Get
				Return GetMultiCuentaCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaCollectionViaCheque_. When set to true, CuentaCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchCuentaCollectionViaCheque_
			End Get
			Set
				_alwaysFetchCuentaCollectionViaCheque_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque. When set to true, PolizaCollectionViaCheque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaCheque_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaCheque_]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaCheque_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaCheque_. When set to true, PolizaCollectionViaCheque_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaCheque_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaCheque_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaCheque_ As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaCheque_
			End Get
			Set
				_alwaysFetchPolizaCollectionViaCheque_ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'ProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Proveedor]() As ProveedorEntity
			Get
				Return GetSingleProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedor(value)
				Else
					If value Is Nothing Then
						If Not _proveedor Is Nothing Then
							_proveedor.UnsetRelatedEntity(Me, "Beneficiario_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Beneficiario_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Proveedor is not found
		''' in the database. When set to true, Proveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorReturnsNewIfNotFound
			End Get
			Set
				_proveedorReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.BeneficiarioEntity)
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
