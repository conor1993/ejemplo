' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 16:37:48
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
	''' <summary>Entity class which represents the entity 'ContDiotTiposTerceros'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ContDiotTiposTercerosEntity 
#Else
	<Serializable()> _
	Public Class ContDiotTiposTercerosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _proveedor As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor As Boolean
		Private _catLugaresDeCompraCollectionViaProveedor As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaProveedor, _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor As Boolean
		Private _contDiotTiposOperacionCollectionViaProveedor As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
		Private _alwaysFetchContDiotTiposOperacionCollectionViaProveedor, _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor As Boolean
		Private _cuentaContableCollectionViaProveedor As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaProveedor, _alreadyFetchedCuentaContableCollectionViaProveedor As Boolean
		Private _cuentaContableCollectionViaProveedor_ As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaProveedor_, _alreadyFetchedCuentaContableCollectionViaProveedor_ As Boolean



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
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		Public Sub New(codDiot As System.Int32)

			InitClassFetch(codDiot, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codDiot As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codDiot, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="validator">The custom validator Object for this ContDiotTiposTercerosEntity</param>
		Public Sub New(codDiot As System.Int32, validator As IValidator)

			InitClassFetch(codDiot, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_proveedor = CType(info.GetValue("_proveedor", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_catLugaresDeCompraCollectionViaProveedor = CType(info.GetValue("_catLugaresDeCompraCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor")
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor")
			_contDiotTiposOperacionCollectionViaProveedor = CType(info.GetValue("_contDiotTiposOperacionCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)), Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection)
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor")
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = info.GetBoolean("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor")
			_cuentaContableCollectionViaProveedor = CType(info.GetValue("_cuentaContableCollectionViaProveedor", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaProveedor = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaProveedor")
			_alreadyFetchedCuentaContableCollectionViaProveedor = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaProveedor")
			_cuentaContableCollectionViaProveedor_ = CType(info.GetValue("_cuentaContableCollectionViaProveedor_", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaProveedor_ = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaProveedor_")
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaProveedor_")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedProveedor = (_proveedor.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = (_catLugaresDeCompraCollectionViaProveedor.Count > 0)
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = (_contDiotTiposOperacionCollectionViaProveedor.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaProveedor = (_cuentaContableCollectionViaProveedor.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = (_cuentaContableCollectionViaProveedor_.Count > 0)


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
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_catLugaresDeCompraCollectionViaProveedor", _catLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaProveedor", _alwaysFetchCatLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor", _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor)
			info.AddValue("_contDiotTiposOperacionCollectionViaProveedor", _contDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alwaysFetchContDiotTiposOperacionCollectionViaProveedor", _alwaysFetchContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor", _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor)
			info.AddValue("_cuentaContableCollectionViaProveedor", _cuentaContableCollectionViaProveedor)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaProveedor", _alwaysFetchCuentaContableCollectionViaProveedor)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaProveedor", _alreadyFetchedCuentaContableCollectionViaProveedor)
			info.AddValue("_cuentaContableCollectionViaProveedor_", _cuentaContableCollectionViaProveedor_)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaProveedor_", _alwaysFetchCuentaContableCollectionViaProveedor_)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaProveedor_", _alreadyFetchedCuentaContableCollectionViaProveedor_)


			
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
					If Not entity Is Nothing Then
						Me.Proveedor.Add(CType(entity, ProveedorEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaProveedor"
					_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaProveedor.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "ContDiotTiposOperacionCollectionViaProveedor"
					_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.ContDiotTiposOperacionCollectionViaProveedor.Add(CType(entity, ContDiotTiposOperacionEntity))
					End If
				Case "CuentaContableCollectionViaProveedor"
					_alreadyFetchedCuentaContableCollectionViaProveedor = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaProveedor.Add(CType(entity, CuentaContableEntity))
					End If
				Case "CuentaContableCollectionViaProveedor_"
					_alreadyFetchedCuentaContableCollectionViaProveedor_ = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaProveedor_.Add(CType(entity, CuentaContableEntity))
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
					_proveedor.Add(CType(relatedEntity, ProveedorEntity))
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
					MyBase.PerformRelatedEntityRemoval(_proveedor, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_proveedor)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codDiot As System.Int32) As Boolean
			Return FetchUsingPK(codDiot, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codDiot As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codDiot, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codDiot As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codDiot, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CodDiot, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ContDiotTiposTercerosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ContDiotTiposTercerosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedor(forceFetch, _proveedor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedor)
					End If
				End If
				_proveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedor.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Filter)
				_proveedor.SuppressClearInGetMulti = False
				_alreadyFetchedProveedor = True
			End If
			Return _proveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Proveedor'. These settings will be taken into account
		''' when the property Proveedor is requested or GetMultiProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedor.SortClauses=sortClauses
			_proveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch, _catLugaresDeCompraCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaProveedor Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ContDiotTiposTercerosFieldIndex.CodDiot), ComparisonOperator.Equal, Me.CodDiot))
				_catLugaresDeCompraCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaProveedor.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = True
			End If
			Return _catLugaresDeCompraCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaProveedor'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaProveedor is requested or GetMultiCatLugaresDeCompraCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaProveedor.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ContDiotTiposOperacionEntity'</returns>
		Public Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Return GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch, _contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiContDiotTiposOperacionCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			If ( Not _alreadyFetchedContDiotTiposOperacionCollectionViaProveedor Or forceFetch Or _alwaysFetchContDiotTiposOperacionCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _contDiotTiposOperacionCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_contDiotTiposOperacionCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ContDiotTiposTercerosFieldIndex.CodDiot), ComparisonOperator.Equal, Me.CodDiot))
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_contDiotTiposOperacionCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_contDiotTiposOperacionCollectionViaProveedor.GetMulti(Filter, relations)
				_contDiotTiposOperacionCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = True
			End If
			Return _contDiotTiposOperacionCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ContDiotTiposOperacionCollectionViaProveedor'. These settings will be taken into account
		''' when the property ContDiotTiposOperacionCollectionViaProveedor is requested or GetMultiContDiotTiposOperacionCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersContDiotTiposOperacionCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_contDiotTiposOperacionCollectionViaProveedor.SortClauses=sortClauses
			_contDiotTiposOperacionCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaProveedor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaProveedor(forceFetch, _cuentaContableCollectionViaProveedor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaProveedor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaProveedor Or forceFetch Or _alwaysFetchCuentaContableCollectionViaProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaProveedor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaProveedor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ContDiotTiposTercerosFieldIndex.CodDiot), ComparisonOperator.Equal, Me.CodDiot))
				_cuentaContableCollectionViaProveedor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaProveedor.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaProveedor.GetMulti(Filter, relations)
				_cuentaContableCollectionViaProveedor.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaProveedor = True
			End If
			Return _cuentaContableCollectionViaProveedor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaProveedor'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaProveedor is requested or GetMultiCuentaContableCollectionViaProveedor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaProveedor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaProveedor.SortClauses=sortClauses
			_cuentaContableCollectionViaProveedor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaProveedor_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaProveedor_(forceFetch, _cuentaContableCollectionViaProveedor_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaProveedor_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaProveedor_ Or forceFetch Or _alwaysFetchCuentaContableCollectionViaProveedor_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaProveedor_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaProveedor_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", "Proveedor_", JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt, "Proveedor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ContDiotTiposTercerosFieldIndex.CodDiot), ComparisonOperator.Equal, Me.CodDiot))
				_cuentaContableCollectionViaProveedor_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaProveedor_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaProveedor_.GetMulti(Filter, relations)
				_cuentaContableCollectionViaProveedor_.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaProveedor_ = True
			End If
			Return _cuentaContableCollectionViaProveedor_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaProveedor_'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaProveedor_ is requested or GetMultiCuentaContableCollectionViaProveedor_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaProveedor_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaProveedor_.SortClauses=sortClauses
			_cuentaContableCollectionViaProveedor_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ContDiotTiposTercerosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ContDiotTiposTercerosFieldIndex)



					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_proveedor.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_contDiotTiposOperacionCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaProveedor.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaProveedor_.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ContDiotTiposTercerosDAO = CType(CreateDAOInstance(), ContDiotTiposTercerosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ContDiotTiposTercerosDAO = CType(CreateDAOInstance(), ContDiotTiposTercerosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ContDiotTiposTercerosDAO = CType(CreateDAOInstance(), ContDiotTiposTercerosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ContDiotTiposTercerosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="validator">The validator Object for this ContDiotTiposTercerosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codDiot As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codDiot, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_proveedor = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_proveedor.SetContainingEntityInfo(Me, "ContDiotTiposTerceros")
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_catLugaresDeCompraCollectionViaProveedor = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaProveedor = False
			_contDiotTiposOperacionCollectionViaProveedor = New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(New ContDiotTiposOperacionEntityFactory())
			_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = False
			_alreadyFetchedContDiotTiposOperacionCollectionViaProveedor = False
			_cuentaContableCollectionViaProveedor = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaProveedor = False
			_alreadyFetchedCuentaContableCollectionViaProveedor = False
			_cuentaContableCollectionViaProveedor_ = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaProveedor_ = False
			_alreadyFetchedCuentaContableCollectionViaProveedor_ = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodDiot", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ClaveHacienda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codDiot">PK value for ContDiotTiposTerceros which data should be fetched into this ContDiotTiposTerceros Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codDiot As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ContDiotTiposTercerosFieldIndex.CodDiot)).ForcedCurrentValueWrite(codDiot)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateContDiotTiposTercerosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ContDiotTiposTercerosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ContDiotTiposTercerosRelations
			Get	
				Return New ContDiotTiposTercerosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, _
					CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CatLugaresDeCompraEntityUsingIdLugarCompra)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, _
					CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContDiotTiposOperacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathContDiotTiposOperacionCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.ContDiotTiposOperacionEntityUsingIdcontdiottiposoperacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection(), _
					ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, _
					CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), CType(Integralab.ORM.EntityType.ContDiotTiposOperacionEntity, Integer), 0, Nothing, Nothing, relations, "ContDiotTiposOperacionCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaProveedor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingCuentaContId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, _
					CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaProveedor_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, "__ContDiotTiposTercerosEntity__", String.Empty, JoinHint.None)
				relations.Add(ProveedorEntity.Relations.CuentaContableEntityUsingPrCuentaAnt)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					ContDiotTiposTercerosEntity.Relations.ProveedorEntityUsingIdcontdiottiposterceros, _
					CType(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaProveedor_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ContDiotTiposTercerosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ContDiotTiposTercerosEntity.CustomProperties
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
				Return ContDiotTiposTercerosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CodDiot property of the Entity ContDiotTiposTerceros<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ContDiotTiposTerceros"."CodDiot"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [CodDiot]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ContDiotTiposTercerosFieldIndex.CodDiot, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ContDiotTiposTercerosFieldIndex.CodDiot, Integer), value)
			End Set
		End Property
	
		''' <summary>The ClaveHacienda property of the Entity ContDiotTiposTerceros<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ContDiotTiposTerceros"."ClaveHacienda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ClaveHacienda]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ContDiotTiposTercerosFieldIndex.ClaveHacienda, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ContDiotTiposTercerosFieldIndex.ClaveHacienda, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity ContDiotTiposTerceros<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ContDiotTiposTerceros"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ContDiotTiposTercerosFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ContDiotTiposTercerosFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Proveedor]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaProveedor. When set to true, CatLugaresDeCompraCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaProveedor
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ContDiotTiposOperacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContDiotTiposOperacionCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ContDiotTiposOperacionCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.ContDiotTiposOperacionCollection
			Get
				Return GetMultiContDiotTiposOperacionCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ContDiotTiposOperacionCollectionViaProveedor. When set to true, ContDiotTiposOperacionCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ContDiotTiposOperacionCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiContDiotTiposOperacionCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchContDiotTiposOperacionCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchContDiotTiposOperacionCollectionViaProveedor
			End Get
			Set
				_alwaysFetchContDiotTiposOperacionCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaProveedor]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaProveedor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaProveedor. When set to true, CuentaContableCollectionViaProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaProveedor is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaProveedor As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaProveedor
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaProveedor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaProveedor_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaProveedor_]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaProveedor_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaProveedor_. When set to true, CuentaContableCollectionViaProveedor_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaProveedor_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaProveedor_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaProveedor_ As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaProveedor_
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaProveedor_ = value
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
				Return CInt(Integralab.ORM.EntityType.ContDiotTiposTercerosEntity)
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
