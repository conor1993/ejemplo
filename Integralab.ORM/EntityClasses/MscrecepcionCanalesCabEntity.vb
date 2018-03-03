' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:37
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
	''' <summary>Entity class which represents the entity 'MscrecepcionCanalesCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscrecepcionCanalesCabEntity 
#Else
	<Serializable()> _
	Public Class MscrecepcionCanalesCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mscrecepcionCanalesDet As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
		Private _alwaysFetchMscrecepcionCanalesDet, _alreadyFetchedMscrecepcionCanalesDet As Boolean
		Private _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet, _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet As Boolean
		Private _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_, _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ As Boolean
		Private _mscregistroSacrificioCab As MscregistroSacrificioCabEntity
		Private _alwaysFetchMscregistroSacrificioCab, _alreadyFetchedMscregistroSacrificioCab, _mscregistroSacrificioCabReturnsNewIfNotFound As Boolean


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
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		Public Sub New(folioMovimiento As System.String, folioSacrificio As System.String)

			InitClassFetch(folioMovimiento, folioSacrificio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioMovimiento As System.String, folioSacrificio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioMovimiento, folioSacrificio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="validator">The custom validator Object for this MscrecepcionCanalesCabEntity</param>
		Public Sub New(folioMovimiento As System.String, folioSacrificio As System.String, validator As IValidator)

			InitClassFetch(folioMovimiento, folioSacrificio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mscrecepcionCanalesDet = CType(info.GetValue("_mscrecepcionCanalesDet", GetType(Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)), Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection)
			_alwaysFetchMscrecepcionCanalesDet = info.GetBoolean("_alwaysFetchMscrecepcionCanalesDet")
			_alreadyFetchedMscrecepcionCanalesDet = info.GetBoolean("_alreadyFetchedMscrecepcionCanalesDet")
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet")
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_")
			_mscregistroSacrificioCab = CType(info.GetValue("_mscregistroSacrificioCab", GetType(MscregistroSacrificioCabEntity)), MscregistroSacrificioCabEntity)
			If Not _mscregistroSacrificioCab Is Nothing Then
				AddHandler _mscregistroSacrificioCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscregistroSacrificioCabReturnsNewIfNotFound = info.GetBoolean("_mscregistroSacrificioCabReturnsNewIfNotFound")
			_alwaysFetchMscregistroSacrificioCab = info.GetBoolean("_alwaysFetchMscregistroSacrificioCab")
			_alreadyFetchedMscregistroSacrificioCab = info.GetBoolean("_alreadyFetchedMscregistroSacrificioCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMscrecepcionCanalesDet = (_mscrecepcionCanalesDet.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = (_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = (_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.Count > 0)
			_alreadyFetchedMscregistroSacrificioCab = Not(_mscregistroSacrificioCab Is Nothing)

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
			info.AddValue("_mscrecepcionCanalesDet", _mscrecepcionCanalesDet)
			info.AddValue("_alwaysFetchMscrecepcionCanalesDet", _alwaysFetchMscrecepcionCanalesDet)
			info.AddValue("_alreadyFetchedMscrecepcionCanalesDet", _alreadyFetchedMscrecepcionCanalesDet)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet", _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet", _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet", _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_", _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_", _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_", _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_)
			info.AddValue("_mscregistroSacrificioCab", _mscregistroSacrificioCab)
			info.AddValue("_mscregistroSacrificioCabReturnsNewIfNotFound", _mscregistroSacrificioCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscregistroSacrificioCab", _alwaysFetchMscregistroSacrificioCab)
			info.AddValue("_alreadyFetchedMscregistroSacrificioCab", _alreadyFetchedMscregistroSacrificioCab)

			
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
				Case "MscregistroSacrificioCab"
					_alreadyFetchedMscregistroSacrificioCab = True
					Me.MscregistroSacrificioCab = CType(entity, MscregistroSacrificioCabEntity)
				Case "MscrecepcionCanalesDet"
					_alreadyFetchedMscrecepcionCanalesDet = True
					If Not entity Is Nothing Then
						Me.MscrecepcionCanalesDet.Add(CType(entity, MscrecepcionCanalesDetEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.Add(CType(entity, MscmovtosAlmacenCabEntity))
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
				Case "MscregistroSacrificioCab"
					SetupSyncMscregistroSacrificioCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet"
					_mscrecepcionCanalesDet.Add(CType(relatedEntity, MscrecepcionCanalesDetEntity))
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
				Case "MscregistroSacrificioCab"
					DesetupSyncMscregistroSacrificioCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrecepcionCanalesDet"
					MyBase.PerformRelatedEntityRemoval(_mscrecepcionCanalesDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _mscregistroSacrificioCab Is Nothing Then
				toReturn.Add(_mscregistroSacrificioCab)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mscrecepcionCanalesDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioMovimiento As System.String, folioSacrificio As System.String) As Boolean
			Return FetchUsingPK(folioMovimiento, folioSacrificio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioMovimiento As System.String, folioSacrificio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioMovimiento, folioSacrificio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioMovimiento As System.String, folioSacrificio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioMovimiento, folioSacrificio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioMovimiento, Me.FolioSacrificio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscrecepcionCanalesCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscrecepcionCanalesCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, _mscrecepcionCanalesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrecepcionCanalesDetEntity'</returns>
		Public Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Return GetMultiMscrecepcionCanalesDet(forceFetch, _mscrecepcionCanalesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			If ( Not _alreadyFetchedMscrecepcionCanalesDet Or forceFetch Or _alwaysFetchMscrecepcionCanalesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrecepcionCanalesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrecepcionCanalesDet)
					End If
				End If
				_mscrecepcionCanalesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrecepcionCanalesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrecepcionCanalesDet.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_mscrecepcionCanalesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscrecepcionCanalesDet = True
			End If
			Return _mscrecepcionCanalesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrecepcionCanalesDet'. These settings will be taken into account
		''' when the property MscrecepcionCanalesDet is requested or GetMultiMscrecepcionCanalesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrecepcionCanalesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrecepcionCanalesDet.SortClauses=sortClauses
			_mscrecepcionCanalesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(forceFetch, _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, "__MscrecepcionCanalesCabEntity__", "MscrecepcionCanalesDet_", JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento, "MscrecepcionCanalesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio), ComparisonOperator.Equal, Me.FolioSacrificio))
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet is requested or GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(forceFetch, _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, "__MscrecepcionCanalesCabEntity__", "MscrecepcionCanalesDet_", JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoCancela, "MscrecepcionCanalesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MscrecepcionCanalesCabFieldIndex.FolioSacrificio), ComparisonOperator.Equal, Me.FolioSacrificio))
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ is requested or GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'MscregistroSacrificioCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscregistroSacrificioCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscregistroSacrificioCab() As MscregistroSacrificioCabEntity
			Return GetSingleMscregistroSacrificioCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscregistroSacrificioCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscregistroSacrificioCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscregistroSacrificioCab(forceFetch As Boolean) As MscregistroSacrificioCabEntity
			If ( Not _alreadyFetchedMscregistroSacrificioCab Or forceFetch Or _alwaysFetchMscregistroSacrificioCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscregistroSacrificioCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscrecepcionCanalesCabEntity.Relations.MscregistroSacrificioCabEntityUsingFolioSacrificio) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioSacrificio)
				End If
				If Not _mscregistroSacrificioCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscregistroSacrificioCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscregistroSacrificioCabEntity)
					End If
					Me.MscregistroSacrificioCab = newEntity
					_alreadyFetchedMscregistroSacrificioCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscregistroSacrificioCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscrecepcionCanalesCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscrecepcionCanalesCabFieldIndex)

					Case MscrecepcionCanalesCabFieldIndex.FolioSacrificio
						DesetupSyncMscregistroSacrificioCab(True, False)
						_alreadyFetchedMscregistroSacrificioCab = False













					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mscrecepcionCanalesDet.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_.ActiveContext = MyBase.ActiveContext
		If Not _mscregistroSacrificioCab Is Nothing Then
				_mscregistroSacrificioCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MscrecepcionCanalesCabDAO = CType(CreateDAOInstance(), MscrecepcionCanalesCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscrecepcionCanalesCabDAO = CType(CreateDAOInstance(), MscrecepcionCanalesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscrecepcionCanalesCabDAO = CType(CreateDAOInstance(), MscrecepcionCanalesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscrecepcionCanalesCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="validator">The validator Object for this MscrecepcionCanalesCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioMovimiento As System.String, folioSacrificio As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioMovimiento, folioSacrificio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mscrecepcionCanalesDet = New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(New MscrecepcionCanalesDetEntityFactory())
			_mscrecepcionCanalesDet.SetContainingEntityInfo(Me, "MscrecepcionCanalesCab")
			_alwaysFetchMscrecepcionCanalesDet = False
			_alreadyFetchedMscrecepcionCanalesDet = False
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = False
			_mscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = False
			_mscregistroSacrificioCab = Nothing
			_mscregistroSacrificioCabReturnsNewIfNotFound = True
			_alwaysFetchMscregistroSacrificioCab = False
			_alreadyFetchedMscregistroSacrificioCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LotePropio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCanales", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KgrsRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KgrsBascula", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KgrsCalientes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancela", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mscregistroSacrificioCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscregistroSacrificioCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscregistroSacrificioCab, AddressOf OnMscregistroSacrificioCabPropertyChanged, "MscregistroSacrificioCab", MscrecepcionCanalesCabEntity.Relations.MscregistroSacrificioCabEntityUsingFolioSacrificio, True, signalRelatedEntity, "MscrecepcionCanalesCab", resetFKFields, New Integer() { CInt(MscrecepcionCanalesCabFieldIndex.FolioSacrificio) } )
			_mscregistroSacrificioCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscregistroSacrificioCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscregistroSacrificioCab(relatedEntity As IEntity)
			DesetupSyncMscregistroSacrificioCab(True, True)
			_mscregistroSacrificioCab = CType(relatedEntity, MscregistroSacrificioCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscregistroSacrificioCab, AddressOf OnMscregistroSacrificioCabPropertyChanged, "MscregistroSacrificioCab", MscrecepcionCanalesCabEntity.Relations.MscregistroSacrificioCabEntityUsingFolioSacrificio, True, _alreadyFetchedMscregistroSacrificioCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscregistroSacrificioCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioMovimiento">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="folioSacrificio">PK value for MscrecepcionCanalesCab which data should be fetched into this MscrecepcionCanalesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioMovimiento As System.String, folioSacrificio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscrecepcionCanalesCabFieldIndex.FolioMovimiento)).ForcedCurrentValueWrite(folioMovimiento)
				MyBase.Fields(CInt(MscrecepcionCanalesCabFieldIndex.FolioSacrificio)).ForcedCurrentValueWrite(folioSacrificio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscrecepcionCanalesCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscrecepcionCanalesCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscrecepcionCanalesCabRelations
			Get	
				Return New MscrecepcionCanalesCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrecepcionCanalesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrecepcionCanalesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection(), _
					MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, _
					CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), CType(Integralab.ORM.EntityType.MscrecepcionCanalesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrecepcionCanalesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, "__MscrecepcionCanalesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, _
					CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, "__MscrecepcionCanalesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MscrecepcionCanalesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoCancela)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MscrecepcionCanalesCabEntity.Relations.MscrecepcionCanalesDetEntityUsingFolioMovimientoFolioSacrificio, _
					CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscregistroSacrificioCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscregistroSacrificioCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection(), _
					MscrecepcionCanalesCabEntity.Relations.MscregistroSacrificioCabEntityUsingFolioSacrificio, _
					CType(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity, Integer), CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscregistroSacrificioCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MscrecepcionCanalesCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscrecepcionCanalesCabEntity.CustomProperties
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
				Return MscrecepcionCanalesCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioMovimiento property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."FolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioSacrificio property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."FolioSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioSacrificio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FolioSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FolioSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaSacrificio property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."FechaSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaSacrificio]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The LotePropio property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."LotePropio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LotePropio]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.LotePropio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.LotePropio, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodCliente property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."CodCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.CodCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.CodCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCanales property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."CantCanales"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCanales]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.CantCanales, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.CantCanales, Integer), value)
			End Set
		End Property
	
		''' <summary>The KgrsRastro property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."KgrsRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KgrsRastro]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsRastro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdRastro property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."IdRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdRastro]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.IdRastro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.IdRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The KgrsBascula property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."KgrsBascula"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KgrsBascula]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsBascula, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsBascula, Integer), value)
			End Set
		End Property
	
		''' <summary>The KgrsCalientes property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."KgrsCalientes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KgrsCalientes]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsCalientes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.KgrsCalientes, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancela property of the Entity MscrecepcionCanalesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCRecepcionCanalesCab"."IdUsuarioCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancela]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscrecepcionCanalesCabFieldIndex.IdUsuarioCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscrecepcionCanalesCabFieldIndex.IdUsuarioCancela, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MscrecepcionCanalesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrecepcionCanalesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrecepcionCanalesDet]() As Integralab.ORM.CollectionClasses.MscrecepcionCanalesDetCollection
			Get
				Return GetMultiMscrecepcionCanalesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrecepcionCanalesDet. When set to true, MscrecepcionCanalesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrecepcionCanalesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrecepcionCanalesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrecepcionCanalesDet As Boolean
			Get
				Return _alwaysFetchMscrecepcionCanalesDet
			End Get
			Set
				_alwaysFetchMscrecepcionCanalesDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet. When set to true, MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_. When set to true, MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaMscrecepcionCanalesDet_ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'MscregistroSacrificioCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscregistroSacrificioCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscregistroSacrificioCab]() As MscregistroSacrificioCabEntity
			Get
				Return GetSingleMscregistroSacrificioCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscregistroSacrificioCab(value)
				Else
					If value Is Nothing Then
						If Not _mscregistroSacrificioCab Is Nothing Then
							_mscregistroSacrificioCab.UnsetRelatedEntity(Me, "MscrecepcionCanalesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscrecepcionCanalesCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscregistroSacrificioCab. When set to true, MscregistroSacrificioCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscregistroSacrificioCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscregistroSacrificioCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscregistroSacrificioCab As Boolean
			Get
				Return _alwaysFetchMscregistroSacrificioCab
			End Get
			Set
				_alwaysFetchMscregistroSacrificioCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscregistroSacrificioCab is not found
		''' in the database. When set to true, MscregistroSacrificioCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscregistroSacrificioCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscregistroSacrificioCabReturnsNewIfNotFound
			End Get
			Set
				_mscregistroSacrificioCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MscrecepcionCanalesCabEntity)
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
