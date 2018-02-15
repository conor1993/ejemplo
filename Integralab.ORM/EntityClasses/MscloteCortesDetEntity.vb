' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:09
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
	''' <summary>Entity class which represents the entity 'MscloteCortesDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscloteCortesDetEntity 
#Else
	<Serializable()> _
	Public Class MscloteCortesDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _msccatProductosPreCorte As MsccatProductosEntity
		Private _alwaysFetchMsccatProductosPreCorte, _alreadyFetchedMsccatProductosPreCorte, _msccatProductosPreCorteReturnsNewIfNotFound As Boolean
		Private _msccatProductosCorte As MsccatProductosEntity
		Private _alwaysFetchMsccatProductosCorte, _alreadyFetchedMsccatProductosCorte, _msccatProductosCorteReturnsNewIfNotFound As Boolean
		Private _mscloteCortesCab As MscloteCortesCabEntity
		Private _alwaysFetchMscloteCortesCab, _alreadyFetchedMscloteCortesCab, _mscloteCortesCabReturnsNewIfNotFound As Boolean
		Private _mscmovtosAlmacenCab As MscmovtosAlmacenCabEntity
		Private _alwaysFetchMscmovtosAlmacenCab, _alreadyFetchedMscmovtosAlmacenCab, _mscmovtosAlmacenCabReturnsNewIfNotFound As Boolean


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
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		Public Sub New(loteCorte As System.String, idFolioEtiqueta As System.String)

			InitClassFetch(loteCorte, idFolioEtiqueta, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(loteCorte As System.String, idFolioEtiqueta As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(loteCorte, idFolioEtiqueta, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="validator">The custom validator Object for this MscloteCortesDetEntity</param>
		Public Sub New(loteCorte As System.String, idFolioEtiqueta As System.String, validator As IValidator)

			InitClassFetch(loteCorte, idFolioEtiqueta, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_msccatProductosPreCorte = CType(info.GetValue("_msccatProductosPreCorte", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductosPreCorte Is Nothing Then
				AddHandler _msccatProductosPreCorte.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosPreCorteReturnsNewIfNotFound = info.GetBoolean("_msccatProductosPreCorteReturnsNewIfNotFound")
			_alwaysFetchMsccatProductosPreCorte = info.GetBoolean("_alwaysFetchMsccatProductosPreCorte")
			_alreadyFetchedMsccatProductosPreCorte = info.GetBoolean("_alreadyFetchedMsccatProductosPreCorte")
			_msccatProductosCorte = CType(info.GetValue("_msccatProductosCorte", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductosCorte Is Nothing Then
				AddHandler _msccatProductosCorte.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosCorteReturnsNewIfNotFound = info.GetBoolean("_msccatProductosCorteReturnsNewIfNotFound")
			_alwaysFetchMsccatProductosCorte = info.GetBoolean("_alwaysFetchMsccatProductosCorte")
			_alreadyFetchedMsccatProductosCorte = info.GetBoolean("_alreadyFetchedMsccatProductosCorte")
			_mscloteCortesCab = CType(info.GetValue("_mscloteCortesCab", GetType(MscloteCortesCabEntity)), MscloteCortesCabEntity)
			If Not _mscloteCortesCab Is Nothing Then
				AddHandler _mscloteCortesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscloteCortesCabReturnsNewIfNotFound = info.GetBoolean("_mscloteCortesCabReturnsNewIfNotFound")
			_alwaysFetchMscloteCortesCab = info.GetBoolean("_alwaysFetchMscloteCortesCab")
			_alreadyFetchedMscloteCortesCab = info.GetBoolean("_alreadyFetchedMscloteCortesCab")
			_mscmovtosAlmacenCab = CType(info.GetValue("_mscmovtosAlmacenCab", GetType(MscmovtosAlmacenCabEntity)), MscmovtosAlmacenCabEntity)
			If Not _mscmovtosAlmacenCab Is Nothing Then
				AddHandler _mscmovtosAlmacenCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscmovtosAlmacenCabReturnsNewIfNotFound = info.GetBoolean("_mscmovtosAlmacenCabReturnsNewIfNotFound")
			_alwaysFetchMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab")
			_alreadyFetchedMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedMsccatProductosPreCorte = Not(_msccatProductosPreCorte Is Nothing)
			_alreadyFetchedMsccatProductosCorte = Not(_msccatProductosCorte Is Nothing)
			_alreadyFetchedMscloteCortesCab = Not(_mscloteCortesCab Is Nothing)
			_alreadyFetchedMscmovtosAlmacenCab = Not(_mscmovtosAlmacenCab Is Nothing)

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


			info.AddValue("_msccatProductosPreCorte", _msccatProductosPreCorte)
			info.AddValue("_msccatProductosPreCorteReturnsNewIfNotFound", _msccatProductosPreCorteReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductosPreCorte", _alwaysFetchMsccatProductosPreCorte)
			info.AddValue("_alreadyFetchedMsccatProductosPreCorte", _alreadyFetchedMsccatProductosPreCorte)
			info.AddValue("_msccatProductosCorte", _msccatProductosCorte)
			info.AddValue("_msccatProductosCorteReturnsNewIfNotFound", _msccatProductosCorteReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductosCorte", _alwaysFetchMsccatProductosCorte)
			info.AddValue("_alreadyFetchedMsccatProductosCorte", _alreadyFetchedMsccatProductosCorte)
			info.AddValue("_mscloteCortesCab", _mscloteCortesCab)
			info.AddValue("_mscloteCortesCabReturnsNewIfNotFound", _mscloteCortesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscloteCortesCab", _alwaysFetchMscloteCortesCab)
			info.AddValue("_alreadyFetchedMscloteCortesCab", _alreadyFetchedMscloteCortesCab)
			info.AddValue("_mscmovtosAlmacenCab", _mscmovtosAlmacenCab)
			info.AddValue("_mscmovtosAlmacenCabReturnsNewIfNotFound", _mscmovtosAlmacenCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab", _alwaysFetchMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab", _alreadyFetchedMscmovtosAlmacenCab)

			
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
				Case "MsccatProductosPreCorte"
					_alreadyFetchedMsccatProductosPreCorte = True
					Me.MsccatProductosPreCorte = CType(entity, MsccatProductosEntity)
				Case "MsccatProductosCorte"
					_alreadyFetchedMsccatProductosCorte = True
					Me.MsccatProductosCorte = CType(entity, MsccatProductosEntity)
				Case "MscloteCortesCab"
					_alreadyFetchedMscloteCortesCab = True
					Me.MscloteCortesCab = CType(entity, MscloteCortesCabEntity)
				Case "MscmovtosAlmacenCab"
					_alreadyFetchedMscmovtosAlmacenCab = True
					Me.MscmovtosAlmacenCab = CType(entity, MscmovtosAlmacenCabEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "MsccatProductosPreCorte"
					SetupSyncMsccatProductosPreCorte(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductosCorte"
					SetupSyncMsccatProductosCorte(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscloteCortesCab"
					SetupSyncMscloteCortesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					SetupSyncMscmovtosAlmacenCab(relatedEntity)
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
				Case "MsccatProductosPreCorte"
					DesetupSyncMsccatProductosPreCorte(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductosCorte"
					DesetupSyncMsccatProductosCorte(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscloteCortesCab"
					DesetupSyncMscloteCortesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					DesetupSyncMscmovtosAlmacenCab(False, True)
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
			If Not _msccatProductosPreCorte Is Nothing Then
				toReturn.Add(_msccatProductosPreCorte)
			End If
			If Not _msccatProductosCorte Is Nothing Then
				toReturn.Add(_msccatProductosCorte)
			End If
			If Not _mscloteCortesCab Is Nothing Then
				toReturn.Add(_mscloteCortesCab)
			End If
			If Not _mscmovtosAlmacenCab Is Nothing Then
				toReturn.Add(_mscmovtosAlmacenCab)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()


			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteCorte As System.String, idFolioEtiqueta As System.String) As Boolean
			Return FetchUsingPK(loteCorte, idFolioEtiqueta, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteCorte As System.String, idFolioEtiqueta As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(loteCorte, idFolioEtiqueta, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteCorte As System.String, idFolioEtiqueta As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(loteCorte, idFolioEtiqueta, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.LoteCorte, Me.IdFolioEtiqueta, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscloteCortesDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscloteCortesDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductosPreCorte() As MsccatProductosEntity
			Return GetSingleMsccatProductosPreCorte(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductosPreCorte(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductosPreCorte Or forceFetch Or _alwaysFetchMsccatProductosPreCorte) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdCorte) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCorte)
				End If
				If Not _msccatProductosPreCorteReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductosPreCorte = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductosPreCorte = newEntity
					_alreadyFetchedMsccatProductosPreCorte = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductosPreCorte
		End Function
	
		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductosCorte() As MsccatProductosEntity
			Return GetSingleMsccatProductosCorte(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductosCorte(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductosCorte Or forceFetch Or _alwaysFetchMsccatProductosCorte) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _msccatProductosCorteReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductosCorte = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductosCorte = newEntity
					_alreadyFetchedMsccatProductosCorte = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductosCorte
		End Function
	
		''' <summary>Retrieves the related entity of type 'MscloteCortesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscloteCortesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscloteCortesCab() As MscloteCortesCabEntity
			Return GetSingleMscloteCortesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscloteCortesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscloteCortesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscloteCortesCab(forceFetch As Boolean) As MscloteCortesCabEntity
			If ( Not _alreadyFetchedMscloteCortesCab Or forceFetch Or _alwaysFetchMscloteCortesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscloteCortesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte) Then
					fetchResult = newEntity.FetchUsingPK(Me.LoteCorte)
				End If
				If Not _mscloteCortesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscloteCortesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscloteCortesCabEntity)
					End If
					Me.MscloteCortesCab = newEntity
					_alreadyFetchedMscloteCortesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscloteCortesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab() As MscmovtosAlmacenCabEntity
			Return GetSingleMscmovtosAlmacenCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab(forceFetch As Boolean) As MscmovtosAlmacenCabEntity
			If ( Not _alreadyFetchedMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscmovtosAlmacenCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscloteCortesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdFolioMovimiento)
				End If
				If Not _mscmovtosAlmacenCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscmovtosAlmacenCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscmovtosAlmacenCabEntity)
					End If
					Me.MscmovtosAlmacenCab = newEntity
					_alreadyFetchedMscmovtosAlmacenCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscmovtosAlmacenCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscloteCortesDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscloteCortesDetFieldIndex)
					Case MscloteCortesDetFieldIndex.LoteCorte
						DesetupSyncMscloteCortesCab(True, False)
						_alreadyFetchedMscloteCortesCab = False

					Case MscloteCortesDetFieldIndex.IdCorte
						DesetupSyncMsccatProductosPreCorte(True, False)
						_alreadyFetchedMsccatProductosPreCorte = False
					Case MscloteCortesDetFieldIndex.IdProducto
						DesetupSyncMsccatProductosCorte(True, False)
						_alreadyFetchedMsccatProductosCorte = False




					Case MscloteCortesDetFieldIndex.IdFolioMovimiento
						DesetupSyncMscmovtosAlmacenCab(True, False)
						_alreadyFetchedMscmovtosAlmacenCab = False



















					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _msccatProductosPreCorte Is Nothing Then
				_msccatProductosPreCorte.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatProductosCorte Is Nothing Then
				_msccatProductosCorte.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mscloteCortesCab Is Nothing Then
				_mscloteCortesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mscmovtosAlmacenCab Is Nothing Then
				_mscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MscloteCortesDetDAO = CType(CreateDAOInstance(), MscloteCortesDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscloteCortesDetDAO = CType(CreateDAOInstance(), MscloteCortesDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscloteCortesDetDAO = CType(CreateDAOInstance(), MscloteCortesDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscloteCortesDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscloteCortesDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="validator">The validator Object for this MscloteCortesDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(loteCorte As System.String, idFolioEtiqueta As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(loteCorte, idFolioEtiqueta, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_msccatProductosPreCorte = Nothing
			_msccatProductosPreCorteReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductosPreCorte = False
			_alreadyFetchedMsccatProductosPreCorte = False
			_msccatProductosCorte = Nothing
			_msccatProductosCorteReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductosCorte = False
			_alreadyFetchedMsccatProductosCorte = False
			_mscloteCortesCab = Nothing
			_mscloteCortesCabReturnsNewIfNotFound = True
			_alwaysFetchMscloteCortesCab = False
			_alreadyFetchedMscloteCortesCab = False
			_mscmovtosAlmacenCab = Nothing
			_mscmovtosAlmacenCabReturnsNewIfNotFound = True
			_alwaysFetchMscmovtosAlmacenCab = False
			_alreadyFetchedMscmovtosAlmacenCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKgrs", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoBarra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEtiquetaReferencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Grados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteCorteReproceso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenReproceso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenAjuste", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaducidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaducidadAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacenCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("GradosAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenActual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenOrigen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoProductoAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MasDe30Meses", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantLibras", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Farenheit", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _msccatProductosPreCorte</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductosPreCorte(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductosPreCorte, AddressOf OnMsccatProductosPreCortePropertyChanged, "MsccatProductosPreCorte", MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdCorte, True, signalRelatedEntity, "MscloteCortesDet", resetFKFields, New Integer() { CInt(MscloteCortesDetFieldIndex.IdCorte) } )
			_msccatProductosPreCorte = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductosPreCorte</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductosPreCorte(relatedEntity As IEntity)
			DesetupSyncMsccatProductosPreCorte(True, True)
			_msccatProductosPreCorte = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductosPreCorte, AddressOf OnMsccatProductosPreCortePropertyChanged, "MsccatProductosPreCorte", MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdCorte, True, _alreadyFetchedMsccatProductosPreCorte, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosPreCortePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _msccatProductosCorte</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductosCorte(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductosCorte, AddressOf OnMsccatProductosCortePropertyChanged, "MsccatProductosCorte", MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, True, signalRelatedEntity, "MscloteCortesDet_", resetFKFields, New Integer() { CInt(MscloteCortesDetFieldIndex.IdProducto) } )
			_msccatProductosCorte = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductosCorte</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductosCorte(relatedEntity As IEntity)
			DesetupSyncMsccatProductosCorte(True, True)
			_msccatProductosCorte = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductosCorte, AddressOf OnMsccatProductosCortePropertyChanged, "MsccatProductosCorte", MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, True, _alreadyFetchedMsccatProductosCorte, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosCortePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mscloteCortesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscloteCortesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscloteCortesCab, AddressOf OnMscloteCortesCabPropertyChanged, "MscloteCortesCab", MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte, True, signalRelatedEntity, "MscloteCortesDet", resetFKFields, New Integer() { CInt(MscloteCortesDetFieldIndex.LoteCorte) } )
			_mscloteCortesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscloteCortesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscloteCortesCab(relatedEntity As IEntity)
			DesetupSyncMscloteCortesCab(True, True)
			_mscloteCortesCab = CType(relatedEntity, MscloteCortesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscloteCortesCab, AddressOf OnMscloteCortesCabPropertyChanged, "MscloteCortesCab", MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte, True, _alreadyFetchedMscloteCortesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscloteCortesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscmovtosAlmacenCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", MscloteCortesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento, True, signalRelatedEntity, "MscloteCortesDet", resetFKFields, New Integer() { CInt(MscloteCortesDetFieldIndex.IdFolioMovimiento) } )
			_mscmovtosAlmacenCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscmovtosAlmacenCab(relatedEntity As IEntity)
			DesetupSyncMscmovtosAlmacenCab(True, True)
			_mscmovtosAlmacenCab = CType(relatedEntity, MscmovtosAlmacenCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", MscloteCortesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento, True, _alreadyFetchedMscmovtosAlmacenCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscmovtosAlmacenCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="loteCorte">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="idFolioEtiqueta">PK value for MscloteCortesDet which data should be fetched into this MscloteCortesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(loteCorte As System.String, idFolioEtiqueta As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscloteCortesDetFieldIndex.LoteCorte)).ForcedCurrentValueWrite(loteCorte)
				MyBase.Fields(CInt(MscloteCortesDetFieldIndex.IdFolioEtiqueta)).ForcedCurrentValueWrite(idFolioEtiqueta)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscloteCortesDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscloteCortesDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscloteCortesDetRelations
			Get	
				Return New MscloteCortesDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosPreCorte() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdCorte, _
					CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductosPreCorte", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosCorte() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					MscloteCortesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductosCorte", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscloteCortesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscloteCortesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscloteCortesCabCollection(), _
					MscloteCortesDetEntity.Relations.MscloteCortesCabEntityUsingLoteCorte, _
					CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), CType(Integralab.ORM.EntityType.MscloteCortesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscloteCortesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MscloteCortesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MscloteCortesDetEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MscloteCortesDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscloteCortesDetEntity.CustomProperties
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
				Return MscloteCortesDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The LoteCorte property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."LoteCorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [LoteCorte]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.LoteCorte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.LoteCorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioEtiqueta property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioEtiqueta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 14<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdFolioEtiqueta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEtiqueta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEtiqueta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCorte property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdCorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCorte]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdCorte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdCorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantPzas property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."CantPzas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantPzas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.CantPzas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.CantPzas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKgrs property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."CantKgrs"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKgrs]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.CantKgrs, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.CantKgrs, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioEmbarque property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioEmbarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdFolioEmbarque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEmbarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEmbarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimiento property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoBarra property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."CodigoBarra"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoBarra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.CodigoBarra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.CodigoBarra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioEtiquetaReferencia property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioEtiquetaReferencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 14<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioEtiquetaReferencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEtiquetaReferencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioEtiquetaReferencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The Grados property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."Grados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Grados]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.Grados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.Grados, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The LoteCorteReproceso property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."LoteCorteReproceso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LoteCorteReproceso]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.LoteCorteReproceso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.LoteCorteReproceso, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimientoAlmacenReproceso property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioMovimientoAlmacenReproceso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimientoAlmacenReproceso]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenReproceso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenReproceso, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimientoAlmacenAjuste property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioMovimientoAlmacenAjuste"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimientoAlmacenAjuste]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenAjuste, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenAjuste, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaducidad property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."FechaCaducidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCaducidad]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaducidad, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaducidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaducidadAnterior property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."FechaCaducidadAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCaducidadAnterior]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaducidadAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.FechaCaducidadAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimientoAlmacenCongelado property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdFolioMovimientoAlmacenCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimientoAlmacenCongelado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdFolioMovimientoAlmacenCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The GradosAnterior property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."GradosAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [GradosAnterior]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.GradosAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.GradosAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoProducto property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."TipoProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoProducto]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.TipoProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.TipoProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenActual property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdAlmacenActual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenActual]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdAlmacenActual, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdAlmacenActual, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenOrigen property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."IdAlmacenOrigen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenOrigen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.IdAlmacenOrigen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.IdAlmacenOrigen, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoProductoAnterior property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."TipoProductoAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoProductoAnterior]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.TipoProductoAnterior, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.TipoProductoAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The MasDe30Meses property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."MasDe30Meses"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MasDe30Meses]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.MasDe30Meses, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.MasDe30Meses, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantLibras property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."CantLibras"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 29, 12, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CantLibras]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.CantLibras, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.CantLibras, Integer), value)
			End Set
		End Property
	
		''' <summary>The Farenheit property of the Entity MscloteCortesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCLoteCortesDet"."Farenheit"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 14, 1, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Farenheit]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscloteCortesDetFieldIndex.Farenheit, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MscloteCortesDetFieldIndex.Farenheit, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductosPreCorte()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductosPreCorte]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductosPreCorte(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductosPreCorte(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductosPreCorte Is Nothing Then
							_msccatProductosPreCorte.UnsetRelatedEntity(Me, "MscloteCortesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscloteCortesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosPreCorte. When set to true, MsccatProductosPreCorte is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosPreCorte is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductosPreCorte(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosPreCorte As Boolean
			Get
				Return _alwaysFetchMsccatProductosPreCorte
			End Get
			Set
				_alwaysFetchMsccatProductosPreCorte = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductosPreCorte is not found
		''' in the database. When set to true, MsccatProductosPreCorte will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosPreCorteReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosPreCorteReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosPreCorteReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductosCorte()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductosCorte]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductosCorte(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductosCorte(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductosCorte Is Nothing Then
							_msccatProductosCorte.UnsetRelatedEntity(Me, "MscloteCortesDet_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscloteCortesDet_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosCorte. When set to true, MsccatProductosCorte is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosCorte is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductosCorte(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosCorte As Boolean
			Get
				Return _alwaysFetchMsccatProductosCorte
			End Get
			Set
				_alwaysFetchMsccatProductosCorte = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductosCorte is not found
		''' in the database. When set to true, MsccatProductosCorte will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosCorteReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosCorteReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosCorteReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MscloteCortesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscloteCortesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscloteCortesCab]() As MscloteCortesCabEntity
			Get
				Return GetSingleMscloteCortesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscloteCortesCab(value)
				Else
					If value Is Nothing Then
						If Not _mscloteCortesCab Is Nothing Then
							_mscloteCortesCab.UnsetRelatedEntity(Me, "MscloteCortesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscloteCortesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscloteCortesCab. When set to true, MscloteCortesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscloteCortesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscloteCortesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscloteCortesCab As Boolean
			Get
				Return _alwaysFetchMscloteCortesCab
			End Get
			Set
				_alwaysFetchMscloteCortesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscloteCortesCab is not found
		''' in the database. When set to true, MscloteCortesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscloteCortesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscloteCortesCabReturnsNewIfNotFound
			End Get
			Set
				_mscloteCortesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MscmovtosAlmacenCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscmovtosAlmacenCab]() As MscmovtosAlmacenCabEntity
			Get
				Return GetSingleMscmovtosAlmacenCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscmovtosAlmacenCab(value)
				Else
					If value Is Nothing Then
						If Not _mscmovtosAlmacenCab Is Nothing Then
							_mscmovtosAlmacenCab.UnsetRelatedEntity(Me, "MscloteCortesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscloteCortesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCab. When set to true, MscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscmovtosAlmacenCab is not found
		''' in the database. When set to true, MscmovtosAlmacenCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscmovtosAlmacenCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscmovtosAlmacenCabReturnsNewIfNotFound
			End Get
			Set
				_mscmovtosAlmacenCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MscloteCortesDetEntity)
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
