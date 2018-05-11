' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:34
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
	''' <summary>Entity class which represents the entity 'DocumentoTipo'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class DocumentoTipoEntity 
#Else
	<Serializable()> _
	Public Class DocumentoTipoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _documento As Integralab.ORM.CollectionClasses.DocumentoCollection
		Private _alwaysFetchDocumento, _alreadyFetchedDocumento As Boolean
		Private _documentoTipoCampo As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
		Private _alwaysFetchDocumentoTipoCampo, _alreadyFetchedDocumentoTipoCampo As Boolean




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
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		Public Sub New(idDocumentoTipo As System.Int32)

			InitClassFetch(idDocumentoTipo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idDocumentoTipo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idDocumentoTipo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="validator">The custom validator Object for this DocumentoTipoEntity</param>
		Public Sub New(idDocumentoTipo As System.Int32, validator As IValidator)

			InitClassFetch(idDocumentoTipo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_documento = CType(info.GetValue("_documento", GetType(Integralab.ORM.CollectionClasses.DocumentoCollection)), Integralab.ORM.CollectionClasses.DocumentoCollection)
			_alwaysFetchDocumento = info.GetBoolean("_alwaysFetchDocumento")
			_alreadyFetchedDocumento = info.GetBoolean("_alreadyFetchedDocumento")
			_documentoTipoCampo = CType(info.GetValue("_documentoTipoCampo", GetType(Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection)), Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection)
			_alwaysFetchDocumentoTipoCampo = info.GetBoolean("_alwaysFetchDocumentoTipoCampo")
			_alreadyFetchedDocumentoTipoCampo = info.GetBoolean("_alreadyFetchedDocumentoTipoCampo")



			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDocumento = (_documento.Count > 0)
			_alreadyFetchedDocumentoTipoCampo = (_documentoTipoCampo.Count > 0)



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
			info.AddValue("_documento", _documento)
			info.AddValue("_alwaysFetchDocumento", _alwaysFetchDocumento)
			info.AddValue("_alreadyFetchedDocumento", _alreadyFetchedDocumento)
			info.AddValue("_documentoTipoCampo", _documentoTipoCampo)
			info.AddValue("_alwaysFetchDocumentoTipoCampo", _alwaysFetchDocumentoTipoCampo)
			info.AddValue("_alreadyFetchedDocumentoTipoCampo", _alreadyFetchedDocumentoTipoCampo)



			
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

				Case "Documento"
					_alreadyFetchedDocumento = True
					If Not entity Is Nothing Then
						Me.Documento.Add(CType(entity, DocumentoEntity))
					End If
				Case "DocumentoTipoCampo"
					_alreadyFetchedDocumentoTipoCampo = True
					If Not entity Is Nothing Then
						Me.DocumentoTipoCampo.Add(CType(entity, DocumentoTipoCampoEntity))
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

				Case "Documento"
					_documento.Add(CType(relatedEntity, DocumentoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DocumentoTipoCampo"
					_documentoTipoCampo.Add(CType(relatedEntity, DocumentoTipoCampoEntity))
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

				Case "Documento"
					MyBase.PerformRelatedEntityRemoval(_documento, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DocumentoTipoCampo"
					MyBase.PerformRelatedEntityRemoval(_documentoTipoCampo, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_documento)
			toReturn.Add(_documentoTipoCampo)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDocumentoTipo As System.Int32) As Boolean
			Return FetchUsingPK(idDocumentoTipo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDocumentoTipo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idDocumentoTipo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDocumentoTipo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idDocumentoTipo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdDocumentoTipo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As DocumentoTipoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As DocumentoTipoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DocumentoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DocumentoEntity'</returns>
		Public Function GetMultiDocumento(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DocumentoCollection
			Return GetMultiDocumento(forceFetch, _documento.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDocumento(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DocumentoCollection
			Return GetMultiDocumento(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DocumentoEntity'</returns>
		Public Function GetMultiDocumento(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DocumentoCollection
			Return GetMultiDocumento(forceFetch, _documento.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDocumento(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DocumentoCollection
			If ( Not _alreadyFetchedDocumento Or forceFetch Or _alwaysFetchDocumento) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _documento.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_documento)
					End If
				End If
				_documento.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_documento.EntityFactoryToUse = entityFactoryToUse
				End If
				_documento.GetMultiManyToOne(Me, Filter)
				_documento.SuppressClearInGetMulti = False
				_alreadyFetchedDocumento = True
			End If
			Return _documento
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Documento'. These settings will be taken into account
		''' when the property Documento is requested or GetMultiDocumento is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDocumento(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_documento.SortClauses=sortClauses
			_documento.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DocumentoTipoCampoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DocumentoTipoCampoEntity'</returns>
		Public Function GetMultiDocumentoTipoCampo(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
			Return GetMultiDocumentoTipoCampo(forceFetch, _documentoTipoCampo.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoTipoCampoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDocumentoTipoCampo(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
			Return GetMultiDocumentoTipoCampo(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoTipoCampoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DocumentoTipoCampoEntity'</returns>
		Public Function GetMultiDocumentoTipoCampo(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
			Return GetMultiDocumentoTipoCampo(forceFetch, _documentoTipoCampo.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DocumentoTipoCampoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDocumentoTipoCampo(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
			If ( Not _alreadyFetchedDocumentoTipoCampo Or forceFetch Or _alwaysFetchDocumentoTipoCampo) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _documentoTipoCampo.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_documentoTipoCampo)
					End If
				End If
				_documentoTipoCampo.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_documentoTipoCampo.EntityFactoryToUse = entityFactoryToUse
				End If
				_documentoTipoCampo.GetMultiManyToOne(Me, Filter)
				_documentoTipoCampo.SuppressClearInGetMulti = False
				_alreadyFetchedDocumentoTipoCampo = True
			End If
			Return _documentoTipoCampo
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DocumentoTipoCampo'. These settings will be taken into account
		''' when the property DocumentoTipoCampo is requested or GetMultiDocumentoTipoCampo is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDocumentoTipoCampo(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_documentoTipoCampo.SortClauses=sortClauses
			_documentoTipoCampo.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(DocumentoTipoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, DocumentoTipoFieldIndex)


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_documento.ActiveContext = MyBase.ActiveContext
			_documentoTipoCampo.ActiveContext = MyBase.ActiveContext




		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As DocumentoTipoDAO = CType(CreateDAOInstance(), DocumentoTipoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As DocumentoTipoDAO = CType(CreateDAOInstance(), DocumentoTipoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As DocumentoTipoDAO = CType(CreateDAOInstance(), DocumentoTipoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this DocumentoTipoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.DocumentoTipoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="validator">The validator Object for this DocumentoTipoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idDocumentoTipo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idDocumentoTipo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_documento = New Integralab.ORM.CollectionClasses.DocumentoCollection(New DocumentoEntityFactory())
			_documento.SetContainingEntityInfo(Me, "DocumentoTipo")
			_alwaysFetchDocumento = False
			_alreadyFetchedDocumento = False
			_documentoTipoCampo = New Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection(New DocumentoTipoCampoEntityFactory())
			_documentoTipoCampo.SetContainingEntityInfo(Me, "DocumentoTipo")
			_alwaysFetchDocumentoTipoCampo = False
			_alreadyFetchedDocumentoTipoCampo = False



			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDocumentoTipo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idDocumentoTipo">PK value for DocumentoTipo which data should be fetched into this DocumentoTipo Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idDocumentoTipo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(DocumentoTipoFieldIndex.IdDocumentoTipo)).ForcedCurrentValueWrite(idDocumentoTipo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateDocumentoTipoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New DocumentoTipoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As DocumentoTipoRelations
			Get	
				Return New DocumentoTipoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Documento' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDocumento() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DocumentoCollection(), _
					DocumentoTipoEntity.Relations.DocumentoEntityUsingIdDocumentoTipo, _
					CType(Integralab.ORM.EntityType.DocumentoTipoEntity, Integer), CType(Integralab.ORM.EntityType.DocumentoEntity, Integer), 0, Nothing, Nothing, Nothing, "Documento", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DocumentoTipoCampo' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDocumentoTipoCampo() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection(), _
					DocumentoTipoEntity.Relations.DocumentoTipoCampoEntityUsingIdDocumentoTipo, _
					CType(Integralab.ORM.EntityType.DocumentoTipoEntity, Integer), CType(Integralab.ORM.EntityType.DocumentoTipoCampoEntity, Integer), 0, Nothing, Nothing, Nothing, "DocumentoTipoCampo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "DocumentoTipoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return DocumentoTipoEntity.CustomProperties
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
				Return DocumentoTipoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdDocumentoTipo property of the Entity DocumentoTipo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DocumentoTipo"."IdDocumentoTipo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdDocumentoTipo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DocumentoTipoFieldIndex.IdDocumentoTipo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DocumentoTipoFieldIndex.IdDocumentoTipo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity DocumentoTipo<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DocumentoTipo"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DocumentoTipoFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DocumentoTipoFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DocumentoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDocumento()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Documento]() As Integralab.ORM.CollectionClasses.DocumentoCollection
			Get
				Return GetMultiDocumento(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Documento. When set to true, Documento is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Documento is accessed. You can always execute
		''' a forced fetch by calling GetMultiDocumento(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDocumento As Boolean
			Get
				Return _alwaysFetchDocumento
			End Get
			Set
				_alwaysFetchDocumento = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DocumentoTipoCampoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDocumentoTipoCampo()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DocumentoTipoCampo]() As Integralab.ORM.CollectionClasses.DocumentoTipoCampoCollection
			Get
				Return GetMultiDocumentoTipoCampo(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DocumentoTipoCampo. When set to true, DocumentoTipoCampo is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DocumentoTipoCampo is accessed. You can always execute
		''' a forced fetch by calling GetMultiDocumentoTipoCampo(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDocumentoTipoCampo As Boolean
			Get
				Return _alwaysFetchDocumentoTipoCampo
			End Get
			Set
				_alwaysFetchDocumentoTipoCampo = value
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
				Return CInt(Integralab.ORM.EntityType.DocumentoTipoEntity)
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
