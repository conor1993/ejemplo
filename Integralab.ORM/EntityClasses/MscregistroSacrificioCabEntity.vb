' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:30
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
	''' <summary>Entity class which represents the entity 'MscregistroSacrificioCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscregistroSacrificioCabEntity 
#Else
	<Serializable()> _
	Public Class MscregistroSacrificioCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _registroSacrificiosDecomisos As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisos, _alreadyFetchedRegistroSacrificiosDecomisos As Boolean
		Private _mscrecepcionCanalesCab As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
		Private _alwaysFetchMscrecepcionCanalesCab, _alreadyFetchedMscrecepcionCanalesCab As Boolean
		Private _usrProdRecepcionGanadoDet As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
		Private _alwaysFetchUsrProdRecepcionGanadoDet, _alreadyFetchedUsrProdRecepcionGanadoDet As Boolean
		Private _recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
		Private _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet, _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet As Boolean



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
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		Public Sub New(idFolioSacrificio As System.String)

			InitClassFetch(idFolioSacrificio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idFolioSacrificio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idFolioSacrificio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="validator">The custom validator Object for this MscregistroSacrificioCabEntity</param>
		Public Sub New(idFolioSacrificio As System.String, validator As IValidator)

			InitClassFetch(idFolioSacrificio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_registroSacrificiosDecomisos = CType(info.GetValue("_registroSacrificiosDecomisos", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos")
			_alreadyFetchedRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos")
			_mscrecepcionCanalesCab = CType(info.GetValue("_mscrecepcionCanalesCab", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection)
			_alwaysFetchMscrecepcionCanalesCab = info.GetBoolean("_alwaysFetchMscrecepcionCanalesCab")
			_alreadyFetchedMscrecepcionCanalesCab = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesCab")
			_usrProdRecepcionGanadoDet = CType(info.GetValue("_usrProdRecepcionGanadoDet", GetType(Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection)), Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection)
			_alwaysFetchUsrProdRecepcionGanadoDet = info.GetBoolean("_alwaysFetchUsrProdRecepcionGanadoDet")
			_alreadyFetchedUsrProdRecepcionGanadoDet = info.GetBoolean("_alreadyFetchedUsrProdRecepcionGanadoDet")
			_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = CType(info.GetValue("_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet", GetType(Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)), Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = info.GetBoolean("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet")
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = info.GetBoolean("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedRegistroSacrificiosDecomisos = (_registroSacrificiosDecomisos.Count > 0)
			_alreadyFetchedMscrecepcionCanalesCab = (_mscrecepcionCanalesCab.Count > 0)
			_alreadyFetchedUsrProdRecepcionGanadoDet = (_usrProdRecepcionGanadoDet.Count > 0)
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = (_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.Count > 0)


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
			info.AddValue("_registroSacrificiosDecomisos", _registroSacrificiosDecomisos)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos", _alwaysFetchRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos", _alreadyFetchedRegistroSacrificiosDecomisos)
			info.AddValue("_mscrecepcionCanalesCab", _mscrecepcionCanalesCab)
			info.AddValue("_alwaysFetchMscrecepcionCanalesCab", _alwaysFetchMscrecepcionCanalesCab)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesCab", _alreadyFetchedMscrecepcionCanalesCab)
			info.AddValue("_usrProdRecepcionGanadoDet", _usrProdRecepcionGanadoDet)
			info.AddValue("_alwaysFetchUsrProdRecepcionGanadoDet", _alwaysFetchUsrProdRecepcionGanadoDet)
			info.AddValue("_alreadyFetchedUsrProdRecepcionGanadoDet", _alreadyFetchedUsrProdRecepcionGanadoDet)
			info.AddValue("_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet", _recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet)
			info.AddValue("_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet", _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet)
			info.AddValue("_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet", _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet)


			
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

				Case "RegistroSacrificiosDecomisos"
					_alreadyFetchedRegistroSacrificiosDecomisos = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisos.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "MscrecepcionCanalesCab"
					_alreadyFetchedMscrecepcionCanalesCab = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesCab.Add(CType(entity, MscrecepcionCanalesCabEntity))
					End If
				Case "UsrProdRecepcionGanadoDet"
					_alreadyFetchedUsrProdRecepcionGanadoDet = True
					If Not entity Is Nothing Then
						Me.UsrProdRecepcionGanadoDet.Add(CType(entity, UsrProdRecepcionGanadoDetEntity))
					End If
				Case "RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet"
					_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = True
					If Not entity Is Nothing Then
						Me.RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.Add(CType(entity, RecepcionGanadoEntity))
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

				Case "RegistroSacrificiosDecomisos"
					_registroSacrificiosDecomisos.Add(CType(relatedEntity, RegistroSacrificiosDecomisosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrecepcionCanalesCab"
					_mscrecepcionCanalesCab.Add(CType(relatedEntity, MscrecepcionCanalesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRecepcionGanadoDet"
					_usrProdRecepcionGanadoDet.Add(CType(relatedEntity, UsrProdRecepcionGanadoDetEntity))
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

				Case "RegistroSacrificiosDecomisos"
					MyBase.PerformRelatedEntityRemoval(_registroSacrificiosDecomisos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrecepcionCanalesCab"
					MyBase.PerformRelatedEntityRemoval(_mscrecepcionCanalesCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRecepcionGanadoDet"
					MyBase.PerformRelatedEntityRemoval(_usrProdRecepcionGanadoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_registroSacrificiosDecomisos)
			toReturn.Add(_mscrecepcionCanalesCab)
			toReturn.Add(_usrProdRecepcionGanadoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioSacrificio As System.String) As Boolean
			Return FetchUsingPK(idFolioSacrificio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioSacrificio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idFolioSacrificio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioSacrificio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idFolioSacrificio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdFolioSacrificio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscregistroSacrificioCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscregistroSacrificioCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, _registroSacrificiosDecomisos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisos(forceFetch, _registroSacrificiosDecomisos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRegistroSacrificiosDecomisos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisos Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _registroSacrificiosDecomisos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_registroSacrificiosDecomisos)
					End If
				End If
				_registroSacrificiosDecomisos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_registroSacrificiosDecomisos.EntityFactoryToUse = entityFactoryToUse
				End If
				_registroSacrificiosDecomisos.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_registroSacrificiosDecomisos.SuppressClearInGetMulti = False
				_alreadyFetchedRegistroSacrificiosDecomisos = True
			End If
			Return _registroSacrificiosDecomisos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RegistroSacrificiosDecomisos'. These settings will be taken into account
		''' when the property RegistroSacrificiosDecomisos is requested or GetMultiRegistroSacrificiosDecomisos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRegistroSacrificiosDecomisos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_registroSacrificiosDecomisos.SortClauses=sortClauses
			_registroSacrificiosDecomisos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesCabEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Return GetMultiMscrecepcionCanalesCab(forceFetch, _mscrecepcionCanalesCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrecepcionCanalesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Return GetMultiMscrecepcionCanalesCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesCabEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Return GetMultiMscrecepcionCanalesCab(forceFetch, _mscrecepcionCanalesCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesCab Or forceFetch Or _alwaysFetchMscrecepcionCanalesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesCab)
					End If
				End If
				_mscrecepcionCanalesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesCab.GetMultiManyToOne(Me, Filter)
				_mscrecepcionCanalesCab.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesCab = True
			End If
			Return _mscrecepcionCanalesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesCab'. These settings will be taken into account
		''' when the property MscrecepcionCanalesCab is requested or GetMultiMscrecepcionCanalesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesCab.SortClauses=sortClauses
			_mscrecepcionCanalesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionGanadoDetEntity'</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, _usrProdRecepcionGanadoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRecepcionGanadoDetEntity'</returns>
		Public Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Return GetMultiUsrProdRecepcionGanadoDet(forceFetch, _usrProdRecepcionGanadoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			If ( Not _alreadyFetchedUsrProdRecepcionGanadoDet Or forceFetch Or _alwaysFetchUsrProdRecepcionGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRecepcionGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRecepcionGanadoDet)
					End If
				End If
				_usrProdRecepcionGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRecepcionGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRecepcionGanadoDet.GetMultiManyToOne(Me, Nothing, Filter)
				_usrProdRecepcionGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRecepcionGanadoDet = True
			End If
			Return _usrProdRecepcionGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRecepcionGanadoDet'. These settings will be taken into account
		''' when the property UsrProdRecepcionGanadoDet is requested or GetMultiUsrProdRecepcionGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRecepcionGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRecepcionGanadoDet.SortClauses=sortClauses
			_usrProdRecepcionGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(forceFetch, _recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			If ( Not _alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet Or forceFetch Or _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscregistroSacrificioCabEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteSacrificio, "__MscregistroSacrificioCabEntity__", "UsrProdRecepcionGanadoDet_", JoinHint.None)
				relations.Add(UsrProdRecepcionGanadoDetEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion, "UsrProdRecepcionGanadoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio), ComparisonOperator.Equal, Me.IdFolioSacrificio))
				_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.GetMulti(Filter, relations)
				_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = True
			End If
			Return _recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet'. These settings will be taken into account
		''' when the property RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet is requested or GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.SortClauses=sortClauses
			_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscregistroSacrificioCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscregistroSacrificioCabFieldIndex)






















					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_registroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			_mscrecepcionCanalesCab.ActiveContext = MyBase.ActiveContext
			_usrProdRecepcionGanadoDet.ActiveContext = MyBase.ActiveContext
			_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MscregistroSacrificioCabDAO = CType(CreateDAOInstance(), MscregistroSacrificioCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscregistroSacrificioCabDAO = CType(CreateDAOInstance(), MscregistroSacrificioCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscregistroSacrificioCabDAO = CType(CreateDAOInstance(), MscregistroSacrificioCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscregistroSacrificioCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="validator">The validator Object for this MscregistroSacrificioCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idFolioSacrificio As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idFolioSacrificio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_registroSacrificiosDecomisos = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_registroSacrificiosDecomisos.SetContainingEntityInfo(Me, "MscregistroSacrificioCab")
			_alwaysFetchRegistroSacrificiosDecomisos = False
			_alreadyFetchedRegistroSacrificiosDecomisos = False
			_mscrecepcionCanalesCab = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(New MscrecepcionCanalesCabEntityFactory())
			_mscrecepcionCanalesCab.SetContainingEntityInfo(Me, "MscregistroSacrificioCab")
			_alwaysFetchMscrecepcionCanalesCab = False
			_alreadyFetchedMscrecepcionCanalesCab = False
			_usrProdRecepcionGanadoDet = New Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection(New UsrProdRecepcionGanadoDetEntityFactory())
			_usrProdRecepcionGanadoDet.SetContainingEntityInfo(Me, "MscregistroSacrificioCab")
			_alwaysFetchUsrProdRecepcionGanadoDet = False
			_alreadyFetchedUsrProdRecepcionGanadoDet = False
			_recepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(New RecepcionGanadoEntityFactory())
			_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = False
			_alreadyFetchedRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCodCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabMuertas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCanales", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KgsEnPie", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KgsCanal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contabilizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PorcientoRendimiento", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idFolioSacrificio">PK value for MscregistroSacrificioCab which data should be fetched into this MscregistroSacrificioCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idFolioSacrificio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio)).ForcedCurrentValueWrite(idFolioSacrificio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscregistroSacrificioCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscregistroSacrificioCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscregistroSacrificioCabRelations
			Get	
				Return New MscregistroSacrificioCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MscregistroSacrificioCabEntity.Relations.RegistroSacrificiosDecomisosEntityUsingLoteSacrificio, _
					CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection(), _
					MscregistroSacrificioCabEntity.Relations.MscrecepcionCanalesCabEntityUsingFolioSacrificio, _
					CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrecepcionCanalesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRecepcionGanadoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRecepcionGanadoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection(), _
					MscregistroSacrificioCabEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteSacrificio, _
					CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRecepcionGanadoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRecepcionGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscregistroSacrificioCabEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteSacrificio, "__MscregistroSacrificioCabEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRecepcionGanadoDetEntity.Relations.RecepcionGanadoEntityUsingLoteRecepcion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					MscregistroSacrificioCabEntity.Relations.UsrProdRecepcionGanadoDetEntityUsingLoteSacrificio, _
					CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, relations, "RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MscregistroSacrificioCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscregistroSacrificioCabEntity.CustomProperties
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
				Return MscregistroSacrificioCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdFolioSacrificio property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FolioSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdFolioSacrificio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdFolioSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioRastro property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."LoteRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdFolioRastro]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdFolioRastro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdFolioRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCodCliente property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."IdCodCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCodCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdCodCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdCodCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaSacrificio property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FechaSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaSacrificio]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabSacrificio property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."CantCabSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCabSacrificio]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCabSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCabSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabMuertas property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."CantCabMuertas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCabMuertas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCabMuertas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCabMuertas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCanales property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."CantCanales"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCanales]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCanales, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.CantCanales, Integer), value)
			End Set
		End Property
	
		''' <summary>The KgsEnPie property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."KgsEnPie"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KgsEnPie]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.KgsEnPie, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.KgsEnPie, Integer), value)
			End Set
		End Property
	
		''' <summary>The KgsCanal property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."KgsCanal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KgsCanal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.KgsCanal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.KgsCanal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteSacrificio property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."ImporteSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteSacrificio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.ImporteSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.ImporteSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovAlmacen property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FolioMovAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.FolioMovAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.FolioMovAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuario property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."IdUsuario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuario]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdUsuario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdUsuario, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancela property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."IdUsuarioCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancela]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdUsuarioCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdUsuarioCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contabilizado property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."Contabilizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Contabilizado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.Contabilizado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.Contabilizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaContabilizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The PorcientoRendimiento property of the Entity MscregistroSacrificioCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRegistroSacrificioCab"."PorcientoRendimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PorcientoRendimiento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscregistroSacrificioCabFieldIndex.PorcientoRendimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscregistroSacrificioCabFieldIndex.PorcientoRendimiento, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRegistroSacrificiosDecomisos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RegistroSacrificiosDecomisos]() As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Get
				Return GetMultiRegistroSacrificiosDecomisos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisos. When set to true, RegistroSacrificiosDecomisos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisos is accessed. You can always execute
		''' a forced fetch by calling GetMultiRegistroSacrificiosDecomisos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisos As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisos
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesCab]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesCabCollection
			Get
				Return GetMultiMscrecepcionCanalesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesCab. When set to true, MscrecepcionCanalesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesCab As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesCab
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdRecepcionGanadoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRecepcionGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRecepcionGanadoDet]() As Integralab.ORM.CollectionClasses.UsrProdRecepcionGanadoDetCollection
			Get
				Return GetMultiUsrProdRecepcionGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRecepcionGanadoDet. When set to true, UsrProdRecepcionGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRecepcionGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRecepcionGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRecepcionGanadoDet As Boolean
			Get
				Return _alwaysFetchUsrProdRecepcionGanadoDet
			End Get
			Set
				_alwaysFetchUsrProdRecepcionGanadoDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet]() As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Get
				Return GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet. When set to true, RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet As Boolean
			Get
				Return _alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet
			End Get
			Set
				_alwaysFetchRecepcionGanadoCollectionViaUsrProdRecepcionGanadoDet = value
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
				Return CInt(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity)
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
