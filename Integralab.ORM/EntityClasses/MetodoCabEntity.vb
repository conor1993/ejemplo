' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:21
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
	''' <summary>Entity class which represents the entity 'MetodoCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MetodoCabEntity 
#Else
	<Serializable()> _
	Public Class MetodoCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _gastosDepartamentos As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
		Private _alwaysFetchGastosDepartamentos, _alreadyFetchedGastosDepartamentos As Boolean
		Private _metodoDet As Integralab.ORM.CollectionClasses.MetodoDetCollection
		Private _alwaysFetchMetodoDet, _alreadyFetchedMetodoDet As Boolean
		Private _cuentaContableCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaGastosDepartamentos, _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos As Boolean
		Private _polizaCollectionViaGastosDepartamentos As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaGastosDepartamentos, _alreadyFetchedPolizaCollectionViaGastosDepartamentos As Boolean
		Private _catDeptosCollectionViaMetodoDet As Integralab.ORM.CollectionClasses.CatDeptosCollection
		Private _alwaysFetchCatDeptosCollectionViaMetodoDet, _alreadyFetchedCatDeptosCollectionViaMetodoDet As Boolean



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
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <param name="validator">The custom validator Object for this MetodoCabEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_gastosDepartamentos = CType(info.GetValue("_gastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)), Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)
			_alwaysFetchGastosDepartamentos = info.GetBoolean("_alwaysFetchGastosDepartamentos")
			_alreadyFetchedGastosDepartamentos = info.GetBoolean("_alreadyFetchedGastosDepartamentos")
			_metodoDet = CType(info.GetValue("_metodoDet", GetType(Integralab.ORM.CollectionClasses.MetodoDetCollection)), Integralab.ORM.CollectionClasses.MetodoDetCollection)
			_alwaysFetchMetodoDet = info.GetBoolean("_alwaysFetchMetodoDet")
			_alreadyFetchedMetodoDet = info.GetBoolean("_alreadyFetchedMetodoDet")
			_cuentaContableCollectionViaGastosDepartamentos = CType(info.GetValue("_cuentaContableCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaGastosDepartamentos")
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos")
			_polizaCollectionViaGastosDepartamentos = CType(info.GetValue("_polizaCollectionViaGastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaGastosDepartamentos = info.GetBoolean("_alwaysFetchPolizaCollectionViaGastosDepartamentos")
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = info.GetBoolean("_alreadyFetchedPolizaCollectionViaGastosDepartamentos")
			_catDeptosCollectionViaMetodoDet = CType(info.GetValue("_catDeptosCollectionViaMetodoDet", GetType(Integralab.ORM.CollectionClasses.CatDeptosCollection)), Integralab.ORM.CollectionClasses.CatDeptosCollection)
			_alwaysFetchCatDeptosCollectionViaMetodoDet = info.GetBoolean("_alwaysFetchCatDeptosCollectionViaMetodoDet")
			_alreadyFetchedCatDeptosCollectionViaMetodoDet = info.GetBoolean("_alreadyFetchedCatDeptosCollectionViaMetodoDet")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedGastosDepartamentos = (_gastosDepartamentos.Count > 0)
			_alreadyFetchedMetodoDet = (_metodoDet.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = (_cuentaContableCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = (_polizaCollectionViaGastosDepartamentos.Count > 0)
			_alreadyFetchedCatDeptosCollectionViaMetodoDet = (_catDeptosCollectionViaMetodoDet.Count > 0)


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
			info.AddValue("_gastosDepartamentos", _gastosDepartamentos)
			info.AddValue("_alwaysFetchGastosDepartamentos", _alwaysFetchGastosDepartamentos)
			info.AddValue("_alreadyFetchedGastosDepartamentos", _alreadyFetchedGastosDepartamentos)
			info.AddValue("_metodoDet", _metodoDet)
			info.AddValue("_alwaysFetchMetodoDet", _alwaysFetchMetodoDet)
			info.AddValue("_alreadyFetchedMetodoDet", _alreadyFetchedMetodoDet)
			info.AddValue("_cuentaContableCollectionViaGastosDepartamentos", _cuentaContableCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaGastosDepartamentos", _alwaysFetchCuentaContableCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos", _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos)
			info.AddValue("_polizaCollectionViaGastosDepartamentos", _polizaCollectionViaGastosDepartamentos)
			info.AddValue("_alwaysFetchPolizaCollectionViaGastosDepartamentos", _alwaysFetchPolizaCollectionViaGastosDepartamentos)
			info.AddValue("_alreadyFetchedPolizaCollectionViaGastosDepartamentos", _alreadyFetchedPolizaCollectionViaGastosDepartamentos)
			info.AddValue("_catDeptosCollectionViaMetodoDet", _catDeptosCollectionViaMetodoDet)
			info.AddValue("_alwaysFetchCatDeptosCollectionViaMetodoDet", _alwaysFetchCatDeptosCollectionViaMetodoDet)
			info.AddValue("_alreadyFetchedCatDeptosCollectionViaMetodoDet", _alreadyFetchedCatDeptosCollectionViaMetodoDet)


			
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

				Case "GastosDepartamentos"
					_alreadyFetchedGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.GastosDepartamentos.Add(CType(entity, GastosDepartamentosEntity))
					End If
				Case "MetodoDet"
					_alreadyFetchedMetodoDet = True
					If Not entity Is Nothing Then
						Me.MetodoDet.Add(CType(entity, MetodoDetEntity))
					End If
				Case "CuentaContableCollectionViaGastosDepartamentos"
					_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaGastosDepartamentos.Add(CType(entity, CuentaContableEntity))
					End If
				Case "PolizaCollectionViaGastosDepartamentos"
					_alreadyFetchedPolizaCollectionViaGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaGastosDepartamentos.Add(CType(entity, PolizaEntity))
					End If
				Case "CatDeptosCollectionViaMetodoDet"
					_alreadyFetchedCatDeptosCollectionViaMetodoDet = True
					If Not entity Is Nothing Then
						Me.CatDeptosCollectionViaMetodoDet.Add(CType(entity, CatDeptosEntity))
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

				Case "GastosDepartamentos"
					_gastosDepartamentos.Add(CType(relatedEntity, GastosDepartamentosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MetodoDet"
					_metodoDet.Add(CType(relatedEntity, MetodoDetEntity))
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

				Case "GastosDepartamentos"
					MyBase.PerformRelatedEntityRemoval(_gastosDepartamentos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MetodoDet"
					MyBase.PerformRelatedEntityRemoval(_metodoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_gastosDepartamentos)
			toReturn.Add(_metodoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MetodoCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MetodoCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			If ( Not _alreadyFetchedGastosDepartamentos Or forceFetch Or _alwaysFetchGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _gastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_gastosDepartamentos)
					End If
				End If
				_gastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_gastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_gastosDepartamentos.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_gastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedGastosDepartamentos = True
			End If
			Return _gastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'GastosDepartamentos'. These settings will be taken into account
		''' when the property GastosDepartamentos is requested or GetMultiGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_gastosDepartamentos.SortClauses=sortClauses
			_gastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MetodoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MetodoDetEntity'</returns>
		Public Function GetMultiMetodoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MetodoDetCollection
			Return GetMultiMetodoDet(forceFetch, _metodoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MetodoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMetodoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MetodoDetCollection
			Return GetMultiMetodoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MetodoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MetodoDetEntity'</returns>
		Public Function GetMultiMetodoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MetodoDetCollection
			Return GetMultiMetodoDet(forceFetch, _metodoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MetodoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMetodoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MetodoDetCollection
			If ( Not _alreadyFetchedMetodoDet Or forceFetch Or _alwaysFetchMetodoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _metodoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_metodoDet)
					End If
				End If
				_metodoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_metodoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_metodoDet.GetMultiManyToOne(Nothing, Me, Filter)
				_metodoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMetodoDet = True
			End If
			Return _metodoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MetodoDet'. These settings will be taken into account
		''' when the property MetodoDet is requested or GetMultiMetodoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMetodoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_metodoDet.SortClauses=sortClauses
			_metodoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch, _cuentaContableCollectionViaGastosDepartamentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaGastosDepartamentos Or forceFetch Or _alwaysFetchCuentaContableCollectionViaGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaGastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaGastosDepartamentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, "__MetodoCabEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MetodoCabFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaGastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaGastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaGastosDepartamentos.GetMulti(Filter, relations)
				_cuentaContableCollectionViaGastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = True
			End If
			Return _cuentaContableCollectionViaGastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaGastosDepartamentos'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaGastosDepartamentos is requested or GetMultiCuentaContableCollectionViaGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaGastosDepartamentos.SortClauses=sortClauses
			_cuentaContableCollectionViaGastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch, _polizaCollectionViaGastosDepartamentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaGastosDepartamentos Or forceFetch Or _alwaysFetchPolizaCollectionViaGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaGastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaGastosDepartamentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, "__MetodoCabEntity__", "GastosDepartamentos_", JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza, "GastosDepartamentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MetodoCabFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_polizaCollectionViaGastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaGastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaGastosDepartamentos.GetMulti(Filter, relations)
				_polizaCollectionViaGastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaGastosDepartamentos = True
			End If
			Return _polizaCollectionViaGastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaGastosDepartamentos'. These settings will be taken into account
		''' when the property PolizaCollectionViaGastosDepartamentos is requested or GetMultiPolizaCollectionViaGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaGastosDepartamentos.SortClauses=sortClauses
			_polizaCollectionViaGastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatDeptosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatDeptosEntity'</returns>
		Public Function GetMultiCatDeptosCollectionViaMetodoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatDeptosCollection
			Return GetMultiCatDeptosCollectionViaMetodoDet(forceFetch, _catDeptosCollectionViaMetodoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatDeptosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatDeptosCollectionViaMetodoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatDeptosCollection
			If ( Not _alreadyFetchedCatDeptosCollectionViaMetodoDet Or forceFetch Or _alwaysFetchCatDeptosCollectionViaMetodoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catDeptosCollectionViaMetodoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catDeptosCollectionViaMetodoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MetodoCabEntity.Relations.MetodoDetEntityUsingCodMetodo, "__MetodoCabEntity__", "MetodoDet_", JoinHint.None)
				relations.Add(MetodoDetEntity.Relations.CatDeptosEntityUsingCodCentroCosto, "MetodoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MetodoCabFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_catDeptosCollectionViaMetodoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catDeptosCollectionViaMetodoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_catDeptosCollectionViaMetodoDet.GetMulti(Filter, relations)
				_catDeptosCollectionViaMetodoDet.SuppressClearInGetMulti = False
				_alreadyFetchedCatDeptosCollectionViaMetodoDet = True
			End If
			Return _catDeptosCollectionViaMetodoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatDeptosCollectionViaMetodoDet'. These settings will be taken into account
		''' when the property CatDeptosCollectionViaMetodoDet is requested or GetMultiCatDeptosCollectionViaMetodoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatDeptosCollectionViaMetodoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catDeptosCollectionViaMetodoDet.SortClauses=sortClauses
			_catDeptosCollectionViaMetodoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MetodoCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MetodoCabFieldIndex)


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_gastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_metodoDet.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaGastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_catDeptosCollectionViaMetodoDet.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MetodoCabDAO = CType(CreateDAOInstance(), MetodoCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MetodoCabDAO = CType(CreateDAOInstance(), MetodoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MetodoCabDAO = CType(CreateDAOInstance(), MetodoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MetodoCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MetodoCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <param name="validator">The validator Object for this MetodoCabEntity</param>
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
			_gastosDepartamentos = New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(New GastosDepartamentosEntityFactory())
			_gastosDepartamentos.SetContainingEntityInfo(Me, "MetodoCab")
			_alwaysFetchGastosDepartamentos = False
			_alreadyFetchedGastosDepartamentos = False
			_metodoDet = New Integralab.ORM.CollectionClasses.MetodoDetCollection(New MetodoDetEntityFactory())
			_metodoDet.SetContainingEntityInfo(Me, "MetodoCab")
			_alwaysFetchMetodoDet = False
			_alreadyFetchedMetodoDet = False
			_cuentaContableCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = False
			_alreadyFetchedCuentaContableCollectionViaGastosDepartamentos = False
			_polizaCollectionViaGastosDepartamentos = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaGastosDepartamentos = False
			_alreadyFetchedPolizaCollectionViaGastosDepartamentos = False
			_catDeptosCollectionViaMetodoDet = New Integralab.ORM.CollectionClasses.CatDeptosCollection(New CatDeptosEntityFactory())
			_alwaysFetchCatDeptosCollectionViaMetodoDet = False
			_alreadyFetchedCatDeptosCollectionViaMetodoDet = False


			
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
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for MetodoCab which data should be fetched into this MetodoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MetodoCabFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMetodoCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MetodoCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MetodoCabRelations
			Get	
				Return New MetodoCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GastosDepartamentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathGastosDepartamentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(), _
					MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, _
					CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), CType(Integralab.ORM.EntityType.GastosDepartamentosEntity, Integer), 0, Nothing, Nothing, Nothing, "GastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MetodoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMetodoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MetodoDetCollection(), _
					MetodoCabEntity.Relations.MetodoDetEntityUsingCodMetodo, _
					CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), CType(Integralab.ORM.EntityType.MetodoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MetodoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, "__MetodoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, _
					CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaGastosDepartamentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, "__MetodoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(GastosDepartamentosEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					MetodoCabEntity.Relations.GastosDepartamentosEntityUsingIdMetodoProrrateo, _
					CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaGastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatDeptos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatDeptosCollectionViaMetodoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MetodoCabEntity.Relations.MetodoDetEntityUsingCodMetodo, "__MetodoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MetodoDetEntity.Relations.CatDeptosEntityUsingCodCentroCosto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatDeptosCollection(), _
					MetodoCabEntity.Relations.MetodoDetEntityUsingCodMetodo, _
					CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), 0, Nothing, Nothing, relations, "CatDeptosCollectionViaMetodoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MetodoCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MetodoCabEntity.CustomProperties
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
				Return MetodoCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity MetodoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MetodoCab"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MetodoCabFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MetodoCabFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity MetodoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MetodoCab"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MetodoCabFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MetodoCabFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [GastosDepartamentos]() As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Get
				Return GetMultiGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for GastosDepartamentos. When set to true, GastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time GastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchGastosDepartamentos
			End Get
			Set
				_alwaysFetchGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MetodoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMetodoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MetodoDet]() As Integralab.ORM.CollectionClasses.MetodoDetCollection
			Get
				Return GetMultiMetodoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MetodoDet. When set to true, MetodoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MetodoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMetodoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMetodoDet As Boolean
			Get
				Return _alwaysFetchMetodoDet
			End Get
			Set
				_alwaysFetchMetodoDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaGastosDepartamentos]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaGastosDepartamentos. When set to true, CuentaContableCollectionViaGastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaGastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaGastosDepartamentos
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaGastosDepartamentos]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaGastosDepartamentos. When set to true, PolizaCollectionViaGastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaGastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaGastosDepartamentos
			End Get
			Set
				_alwaysFetchPolizaCollectionViaGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatDeptosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatDeptosCollectionViaMetodoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatDeptosCollectionViaMetodoDet]() As Integralab.ORM.CollectionClasses.CatDeptosCollection
			Get
				Return GetMultiCatDeptosCollectionViaMetodoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatDeptosCollectionViaMetodoDet. When set to true, CatDeptosCollectionViaMetodoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatDeptosCollectionViaMetodoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatDeptosCollectionViaMetodoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatDeptosCollectionViaMetodoDet As Boolean
			Get
				Return _alwaysFetchCatDeptosCollectionViaMetodoDet
			End Get
			Set
				_alwaysFetchCatDeptosCollectionViaMetodoDet = value
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
				Return CInt(Integralab.ORM.EntityType.MetodoCabEntity)
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
