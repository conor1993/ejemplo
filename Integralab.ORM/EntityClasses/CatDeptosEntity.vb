' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:33
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
	''' <summary>Entity class which represents the entity 'CatDeptos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CatDeptosEntity 
#Else
	<Serializable()> _
	Public Class CatDeptosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _metodoDet As Integralab.ORM.CollectionClasses.MetodoDetCollection
		Private _alwaysFetchMetodoDet, _alreadyFetchedMetodoDet As Boolean
		Private _nomCatEmpleados As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
		Private _alwaysFetchNomCatEmpleados, _alreadyFetchedNomCatEmpleados As Boolean
		Private _metodoCabCollectionViaMetodoDet As Integralab.ORM.CollectionClasses.MetodoCabCollection
		Private _alwaysFetchMetodoCabCollectionViaMetodoDet, _alreadyFetchedMetodoCabCollectionViaMetodoDet As Boolean
		Private _nomCatPuestosCollectionViaNomCatEmpleados As Integralab.ORM.CollectionClasses.NomCatPuestosCollection
		Private _alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados, _alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados As Boolean



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
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		Public Sub New(cveDepto As System.Int32)

			InitClassFetch(cveDepto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(cveDepto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(cveDepto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="validator">The custom validator Object for this CatDeptosEntity</param>
		Public Sub New(cveDepto As System.Int32, validator As IValidator)

			InitClassFetch(cveDepto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_metodoDet = CType(info.GetValue("_metodoDet", GetType(Integralab.ORM.CollectionClasses.MetodoDetCollection)), Integralab.ORM.CollectionClasses.MetodoDetCollection)
			_alwaysFetchMetodoDet = info.GetBoolean("_alwaysFetchMetodoDet")
			_alreadyFetchedMetodoDet = info.GetBoolean("_alreadyFetchedMetodoDet")
			_nomCatEmpleados = CType(info.GetValue("_nomCatEmpleados", GetType(Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection)), Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection)
			_alwaysFetchNomCatEmpleados = info.GetBoolean("_alwaysFetchNomCatEmpleados")
			_alreadyFetchedNomCatEmpleados = info.GetBoolean("_alreadyFetchedNomCatEmpleados")
			_metodoCabCollectionViaMetodoDet = CType(info.GetValue("_metodoCabCollectionViaMetodoDet", GetType(Integralab.ORM.CollectionClasses.MetodoCabCollection)), Integralab.ORM.CollectionClasses.MetodoCabCollection)
			_alwaysFetchMetodoCabCollectionViaMetodoDet = info.GetBoolean("_alwaysFetchMetodoCabCollectionViaMetodoDet")
			_alreadyFetchedMetodoCabCollectionViaMetodoDet = info.GetBoolean("_alreadyFetchedMetodoCabCollectionViaMetodoDet")
			_nomCatPuestosCollectionViaNomCatEmpleados = CType(info.GetValue("_nomCatPuestosCollectionViaNomCatEmpleados", GetType(Integralab.ORM.CollectionClasses.NomCatPuestosCollection)), Integralab.ORM.CollectionClasses.NomCatPuestosCollection)
			_alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados = info.GetBoolean("_alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados")
			_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados = info.GetBoolean("_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMetodoDet = (_metodoDet.Count > 0)
			_alreadyFetchedNomCatEmpleados = (_nomCatEmpleados.Count > 0)
			_alreadyFetchedMetodoCabCollectionViaMetodoDet = (_metodoCabCollectionViaMetodoDet.Count > 0)
			_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados = (_nomCatPuestosCollectionViaNomCatEmpleados.Count > 0)


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
			info.AddValue("_metodoDet", _metodoDet)
			info.AddValue("_alwaysFetchMetodoDet", _alwaysFetchMetodoDet)
			info.AddValue("_alreadyFetchedMetodoDet", _alreadyFetchedMetodoDet)
			info.AddValue("_nomCatEmpleados", _nomCatEmpleados)
			info.AddValue("_alwaysFetchNomCatEmpleados", _alwaysFetchNomCatEmpleados)
			info.AddValue("_alreadyFetchedNomCatEmpleados", _alreadyFetchedNomCatEmpleados)
			info.AddValue("_metodoCabCollectionViaMetodoDet", _metodoCabCollectionViaMetodoDet)
			info.AddValue("_alwaysFetchMetodoCabCollectionViaMetodoDet", _alwaysFetchMetodoCabCollectionViaMetodoDet)
			info.AddValue("_alreadyFetchedMetodoCabCollectionViaMetodoDet", _alreadyFetchedMetodoCabCollectionViaMetodoDet)
			info.AddValue("_nomCatPuestosCollectionViaNomCatEmpleados", _nomCatPuestosCollectionViaNomCatEmpleados)
			info.AddValue("_alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados", _alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados)
			info.AddValue("_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados", _alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados)


			
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

				Case "MetodoDet"
					_alreadyFetchedMetodoDet = True
					If Not entity Is Nothing Then
						Me.MetodoDet.Add(CType(entity, MetodoDetEntity))
					End If
				Case "NomCatEmpleados"
					_alreadyFetchedNomCatEmpleados = True
					If Not entity Is Nothing Then
						Me.NomCatEmpleados.Add(CType(entity, NomCatEmpleadosEntity))
					End If
				Case "MetodoCabCollectionViaMetodoDet"
					_alreadyFetchedMetodoCabCollectionViaMetodoDet = True
					If Not entity Is Nothing Then
						Me.MetodoCabCollectionViaMetodoDet.Add(CType(entity, MetodoCabEntity))
					End If
				Case "NomCatPuestosCollectionViaNomCatEmpleados"
					_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados = True
					If Not entity Is Nothing Then
						Me.NomCatPuestosCollectionViaNomCatEmpleados.Add(CType(entity, NomCatPuestosEntity))
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

				Case "MetodoDet"
					_metodoDet.Add(CType(relatedEntity, MetodoDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NomCatEmpleados"
					_nomCatEmpleados.Add(CType(relatedEntity, NomCatEmpleadosEntity))
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

				Case "MetodoDet"
					MyBase.PerformRelatedEntityRemoval(_metodoDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NomCatEmpleados"
					MyBase.PerformRelatedEntityRemoval(_nomCatEmpleados, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_metodoDet)
			toReturn.Add(_nomCatEmpleados)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveDepto As System.Int32) As Boolean
			Return FetchUsingPK(cveDepto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveDepto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(cveDepto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveDepto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(cveDepto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CveDepto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CatDeptosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CatDeptosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_metodoDet.GetMultiManyToOne(Me, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'NomCatEmpleadosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NomCatEmpleadosEntity'</returns>
		Public Function GetMultiNomCatEmpleados(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
			Return GetMultiNomCatEmpleados(forceFetch, _nomCatEmpleados.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NomCatEmpleadosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNomCatEmpleados(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
			Return GetMultiNomCatEmpleados(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NomCatEmpleadosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NomCatEmpleadosEntity'</returns>
		Public Function GetMultiNomCatEmpleados(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
			Return GetMultiNomCatEmpleados(forceFetch, _nomCatEmpleados.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NomCatEmpleadosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNomCatEmpleados(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
			If ( Not _alreadyFetchedNomCatEmpleados Or forceFetch Or _alwaysFetchNomCatEmpleados) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _nomCatEmpleados.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_nomCatEmpleados)
					End If
				End If
				_nomCatEmpleados.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_nomCatEmpleados.EntityFactoryToUse = entityFactoryToUse
				End If
				_nomCatEmpleados.GetMultiManyToOne(Me, Nothing, Filter)
				_nomCatEmpleados.SuppressClearInGetMulti = False
				_alreadyFetchedNomCatEmpleados = True
			End If
			Return _nomCatEmpleados
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NomCatEmpleados'. These settings will be taken into account
		''' when the property NomCatEmpleados is requested or GetMultiNomCatEmpleados is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNomCatEmpleados(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_nomCatEmpleados.SortClauses=sortClauses
			_nomCatEmpleados.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MetodoCabEntity'</returns>
		Public Function GetMultiMetodoCabCollectionViaMetodoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MetodoCabCollection
			Return GetMultiMetodoCabCollectionViaMetodoDet(forceFetch, _metodoCabCollectionViaMetodoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMetodoCabCollectionViaMetodoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MetodoCabCollection
			If ( Not _alreadyFetchedMetodoCabCollectionViaMetodoDet Or forceFetch Or _alwaysFetchMetodoCabCollectionViaMetodoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _metodoCabCollectionViaMetodoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_metodoCabCollectionViaMetodoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatDeptosEntity.Relations.MetodoDetEntityUsingCodCentroCosto, "__CatDeptosEntity__", "MetodoDet_", JoinHint.None)
				relations.Add(MetodoDetEntity.Relations.MetodoCabEntityUsingCodMetodo, "MetodoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatDeptosFieldIndex.CveDepto), ComparisonOperator.Equal, Me.CveDepto))
				_metodoCabCollectionViaMetodoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_metodoCabCollectionViaMetodoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_metodoCabCollectionViaMetodoDet.GetMulti(Filter, relations)
				_metodoCabCollectionViaMetodoDet.SuppressClearInGetMulti = False
				_alreadyFetchedMetodoCabCollectionViaMetodoDet = True
			End If
			Return _metodoCabCollectionViaMetodoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MetodoCabCollectionViaMetodoDet'. These settings will be taken into account
		''' when the property MetodoCabCollectionViaMetodoDet is requested or GetMultiMetodoCabCollectionViaMetodoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMetodoCabCollectionViaMetodoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_metodoCabCollectionViaMetodoDet.SortClauses=sortClauses
			_metodoCabCollectionViaMetodoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'NomCatPuestosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NomCatPuestosEntity'</returns>
		Public Function GetMultiNomCatPuestosCollectionViaNomCatEmpleados(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NomCatPuestosCollection
			Return GetMultiNomCatPuestosCollectionViaNomCatEmpleados(forceFetch, _nomCatPuestosCollectionViaNomCatEmpleados.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'NomCatPuestosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNomCatPuestosCollectionViaNomCatEmpleados(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NomCatPuestosCollection
			If ( Not _alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados Or forceFetch Or _alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _nomCatPuestosCollectionViaNomCatEmpleados.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_nomCatPuestosCollectionViaNomCatEmpleados)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatDeptosEntity.Relations.NomCatEmpleadosEntityUsingIdDepartamento, "__CatDeptosEntity__", "NomCatEmpleados_", JoinHint.None)
				relations.Add(NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto, "NomCatEmpleados_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatDeptosFieldIndex.CveDepto), ComparisonOperator.Equal, Me.CveDepto))
				_nomCatPuestosCollectionViaNomCatEmpleados.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_nomCatPuestosCollectionViaNomCatEmpleados.EntityFactoryToUse = entityFactoryToUse
				End If
				_nomCatPuestosCollectionViaNomCatEmpleados.GetMulti(Filter, relations)
				_nomCatPuestosCollectionViaNomCatEmpleados.SuppressClearInGetMulti = False
				_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados = True
			End If
			Return _nomCatPuestosCollectionViaNomCatEmpleados
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NomCatPuestosCollectionViaNomCatEmpleados'. These settings will be taken into account
		''' when the property NomCatPuestosCollectionViaNomCatEmpleados is requested or GetMultiNomCatPuestosCollectionViaNomCatEmpleados is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNomCatPuestosCollectionViaNomCatEmpleados(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_nomCatPuestosCollectionViaNomCatEmpleados.SortClauses=sortClauses
			_nomCatPuestosCollectionViaNomCatEmpleados.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CatDeptosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CatDeptosFieldIndex)



					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_metodoDet.ActiveContext = MyBase.ActiveContext
			_nomCatEmpleados.ActiveContext = MyBase.ActiveContext
			_metodoCabCollectionViaMetodoDet.ActiveContext = MyBase.ActiveContext
			_nomCatPuestosCollectionViaNomCatEmpleados.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CatDeptosDAO = CType(CreateDAOInstance(), CatDeptosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CatDeptosDAO = CType(CreateDAOInstance(), CatDeptosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CatDeptosDAO = CType(CreateDAOInstance(), CatDeptosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CatDeptosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CatDeptosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="validator">The validator Object for this CatDeptosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(cveDepto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(cveDepto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_metodoDet = New Integralab.ORM.CollectionClasses.MetodoDetCollection(New MetodoDetEntityFactory())
			_metodoDet.SetContainingEntityInfo(Me, "CatDeptos")
			_alwaysFetchMetodoDet = False
			_alreadyFetchedMetodoDet = False
			_nomCatEmpleados = New Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection(New NomCatEmpleadosEntityFactory())
			_nomCatEmpleados.SetContainingEntityInfo(Me, "CatDeptos")
			_alwaysFetchNomCatEmpleados = False
			_alreadyFetchedNomCatEmpleados = False
			_metodoCabCollectionViaMetodoDet = New Integralab.ORM.CollectionClasses.MetodoCabCollection(New MetodoCabEntityFactory())
			_alwaysFetchMetodoCabCollectionViaMetodoDet = False
			_alreadyFetchedMetodoCabCollectionViaMetodoDet = False
			_nomCatPuestosCollectionViaNomCatEmpleados = New Integralab.ORM.CollectionClasses.NomCatPuestosCollection(New NomCatPuestosEntityFactory())
			_alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados = False
			_alreadyFetchedNomCatPuestosCollectionViaNomCatEmpleados = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveDepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomDepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="cveDepto">PK value for CatDeptos which data should be fetched into this CatDeptos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(cveDepto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CatDeptosFieldIndex.CveDepto)).ForcedCurrentValueWrite(cveDepto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCatDeptosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CatDeptosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CatDeptosRelations
			Get	
				Return New CatDeptosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MetodoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMetodoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MetodoDetCollection(), _
					CatDeptosEntity.Relations.MetodoDetEntityUsingCodCentroCosto, _
					CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), CType(Integralab.ORM.EntityType.MetodoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MetodoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NomCatEmpleados' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNomCatEmpleados() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection(), _
					CatDeptosEntity.Relations.NomCatEmpleadosEntityUsingIdDepartamento, _
					CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), CType(Integralab.ORM.EntityType.NomCatEmpleadosEntity, Integer), 0, Nothing, Nothing, Nothing, "NomCatEmpleados", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MetodoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMetodoCabCollectionViaMetodoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatDeptosEntity.Relations.MetodoDetEntityUsingCodCentroCosto, "__CatDeptosEntity__", String.Empty, JoinHint.None)
				relations.Add(MetodoDetEntity.Relations.MetodoCabEntityUsingCodMetodo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MetodoCabCollection(), _
					CatDeptosEntity.Relations.MetodoDetEntityUsingCodCentroCosto, _
					CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), CType(Integralab.ORM.EntityType.MetodoCabEntity, Integer), 0, Nothing, Nothing, relations, "MetodoCabCollectionViaMetodoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NomCatPuestos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNomCatPuestosCollectionViaNomCatEmpleados() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatDeptosEntity.Relations.NomCatEmpleadosEntityUsingIdDepartamento, "__CatDeptosEntity__", String.Empty, JoinHint.None)
				relations.Add(NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NomCatPuestosCollection(), _
					CatDeptosEntity.Relations.NomCatEmpleadosEntityUsingIdDepartamento, _
					CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), CType(Integralab.ORM.EntityType.NomCatPuestosEntity, Integer), 0, Nothing, Nothing, relations, "NomCatPuestosCollectionViaNomCatEmpleados", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CatDeptosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CatDeptosEntity.CustomProperties
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
				Return CatDeptosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CveDepto property of the Entity CatDeptos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatDeptos"."Cve_Depto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [CveDepto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatDeptosFieldIndex.CveDepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatDeptosFieldIndex.CveDepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomDepto property of the Entity CatDeptos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatDeptos"."Nom_Depto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomDepto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatDeptosFieldIndex.NomDepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CatDeptosFieldIndex.NomDepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CatDeptos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatDeptos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatDeptosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CatDeptosFieldIndex.Estatus, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'NomCatEmpleadosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNomCatEmpleados()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NomCatEmpleados]() As Integralab.ORM.CollectionClasses.NomCatEmpleadosCollection
			Get
				Return GetMultiNomCatEmpleados(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NomCatEmpleados. When set to true, NomCatEmpleados is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NomCatEmpleados is accessed. You can always execute
		''' a forced fetch by calling GetMultiNomCatEmpleados(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNomCatEmpleados As Boolean
			Get
				Return _alwaysFetchNomCatEmpleados
			End Get
			Set
				_alwaysFetchNomCatEmpleados = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MetodoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMetodoCabCollectionViaMetodoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MetodoCabCollectionViaMetodoDet]() As Integralab.ORM.CollectionClasses.MetodoCabCollection
			Get
				Return GetMultiMetodoCabCollectionViaMetodoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MetodoCabCollectionViaMetodoDet. When set to true, MetodoCabCollectionViaMetodoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MetodoCabCollectionViaMetodoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMetodoCabCollectionViaMetodoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMetodoCabCollectionViaMetodoDet As Boolean
			Get
				Return _alwaysFetchMetodoCabCollectionViaMetodoDet
			End Get
			Set
				_alwaysFetchMetodoCabCollectionViaMetodoDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NomCatPuestosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNomCatPuestosCollectionViaNomCatEmpleados()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NomCatPuestosCollectionViaNomCatEmpleados]() As Integralab.ORM.CollectionClasses.NomCatPuestosCollection
			Get
				Return GetMultiNomCatPuestosCollectionViaNomCatEmpleados(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NomCatPuestosCollectionViaNomCatEmpleados. When set to true, NomCatPuestosCollectionViaNomCatEmpleados is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NomCatPuestosCollectionViaNomCatEmpleados is accessed. You can always execute
		''' a forced fetch by calling GetMultiNomCatPuestosCollectionViaNomCatEmpleados(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNomCatPuestosCollectionViaNomCatEmpleados As Boolean
			Get
				Return _alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados
			End Get
			Set
				_alwaysFetchNomCatPuestosCollectionViaNomCatEmpleados = value
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
				Return CInt(Integralab.ORM.EntityType.CatDeptosEntity)
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
