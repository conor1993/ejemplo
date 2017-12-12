' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:21
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
	''' <summary>Entity class which represents the entity 'DetRegCom'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class DetRegComEntity 
#Else
	<Serializable()> _
	Public Class DetRegComEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _cabRegCom As CabRegComEntity
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom, _cabRegComReturnsNewIfNotFound As Boolean
		Private _mcgcatTiposdeGanado As McgcatTiposdeGanadoEntity
		Private _alwaysFetchMcgcatTiposdeGanado, _alreadyFetchedMcgcatTiposdeGanado, _mcgcatTiposdeGanadoReturnsNewIfNotFound As Boolean


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
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		Public Sub New(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32)

			InitClassFetch(folRecep, cveRenglon, cveGanado, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folRecep, cveRenglon, cveGanado, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="validator">The custom validator Object for this DetRegComEntity</param>
		Public Sub New(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, validator As IValidator)

			InitClassFetch(folRecep, cveRenglon, cveGanado, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(CabRegComEntity)), CabRegComEntity)
			If Not _cabRegCom Is Nothing Then
				AddHandler _cabRegCom.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabRegComReturnsNewIfNotFound = info.GetBoolean("_cabRegComReturnsNewIfNotFound")
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_mcgcatTiposdeGanado = CType(info.GetValue("_mcgcatTiposdeGanado", GetType(McgcatTiposdeGanadoEntity)), McgcatTiposdeGanadoEntity)
			If Not _mcgcatTiposdeGanado Is Nothing Then
				AddHandler _mcgcatTiposdeGanado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = info.GetBoolean("_mcgcatTiposdeGanadoReturnsNewIfNotFound")
			_alwaysFetchMcgcatTiposdeGanado = info.GetBoolean("_alwaysFetchMcgcatTiposdeGanado")
			_alreadyFetchedMcgcatTiposdeGanado = info.GetBoolean("_alreadyFetchedMcgcatTiposdeGanado")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedCabRegCom = Not(_cabRegCom Is Nothing)
			_alreadyFetchedMcgcatTiposdeGanado = Not(_mcgcatTiposdeGanado Is Nothing)

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


			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_cabRegComReturnsNewIfNotFound", _cabRegComReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_mcgcatTiposdeGanado", _mcgcatTiposdeGanado)
			info.AddValue("_mcgcatTiposdeGanadoReturnsNewIfNotFound", _mcgcatTiposdeGanadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcgcatTiposdeGanado", _alwaysFetchMcgcatTiposdeGanado)
			info.AddValue("_alreadyFetchedMcgcatTiposdeGanado", _alreadyFetchedMcgcatTiposdeGanado)

			
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
				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					Me.CabRegCom = CType(entity, CabRegComEntity)
				Case "McgcatTiposdeGanado"
					_alreadyFetchedMcgcatTiposdeGanado = True
					Me.McgcatTiposdeGanado = CType(entity, McgcatTiposdeGanadoEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CabRegCom"
					SetupSyncCabRegCom(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McgcatTiposdeGanado"
					SetupSyncMcgcatTiposdeGanado(relatedEntity)
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
				Case "CabRegCom"
					DesetupSyncCabRegCom(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McgcatTiposdeGanado"
					DesetupSyncMcgcatTiposdeGanado(False, True)
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
			If Not _cabRegCom Is Nothing Then
				toReturn.Add(_cabRegCom)
			End If
			If Not _mcgcatTiposdeGanado Is Nothing Then
				toReturn.Add(_mcgcatTiposdeGanado)
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
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32) As Boolean
			Return FetchUsingPK(folRecep, cveRenglon, cveGanado, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folRecep, cveRenglon, cveGanado, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folRecep, cveRenglon, cveGanado, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolRecep, Me.CveRenglon, Me.CveGanado, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As DetRegComFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As DetRegComFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'CabRegComEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CabRegComEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabRegCom() As CabRegComEntity
			Return GetSingleCabRegCom(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabRegComEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabRegComEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabRegCom(forceFetch As Boolean) As CabRegComEntity
			If ( Not _alreadyFetchedCabRegCom Or forceFetch Or _alwaysFetchCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CabRegComEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DetRegComEntity.Relations.CabRegComEntityUsingFolRecep) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolRecep)
				End If
				If Not _cabRegComReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CabRegCom = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabRegComEntity)
					End If
					Me.CabRegCom = newEntity
					_alreadyFetchedCabRegCom = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabRegCom
		End Function
	
		''' <summary>Retrieves the related entity of type 'McgcatTiposdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McgcatTiposdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatTiposdeGanado() As McgcatTiposdeGanadoEntity
			Return GetSingleMcgcatTiposdeGanado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McgcatTiposdeGanadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McgcatTiposdeGanadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcgcatTiposdeGanado(forceFetch As Boolean) As McgcatTiposdeGanadoEntity
			If ( Not _alreadyFetchedMcgcatTiposdeGanado Or forceFetch Or _alwaysFetchMcgcatTiposdeGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McgcatTiposdeGanadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveGanado)
				End If
				If Not _mcgcatTiposdeGanadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McgcatTiposdeGanado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McgcatTiposdeGanadoEntity)
					End If
					Me.McgcatTiposdeGanado = newEntity
					_alreadyFetchedMcgcatTiposdeGanado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcgcatTiposdeGanado
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(DetRegComFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, DetRegComFieldIndex)
					Case DetRegComFieldIndex.FolRecep
						DesetupSyncCabRegCom(True, False)
						_alreadyFetchedCabRegCom = False

					Case DetRegComFieldIndex.CveGanado
						DesetupSyncMcgcatTiposdeGanado(True, False)
						_alreadyFetchedMcgcatTiposdeGanado = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _cabRegCom Is Nothing Then
				_cabRegCom.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcgcatTiposdeGanado Is Nothing Then
				_mcgcatTiposdeGanado.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As DetRegComDAO = CType(CreateDAOInstance(), DetRegComDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As DetRegComDAO = CType(CreateDAOInstance(), DetRegComDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As DetRegComDAO = CType(CreateDAOInstance(), DetRegComDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this DetRegComEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.DetRegComEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="validator">The validator Object for this DetRegComEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folRecep, cveRenglon, cveGanado, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_cabRegCom = Nothing
			_cabRegComReturnsNewIfNotFound = True
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_mcgcatTiposdeGanado = Nothing
			_mcgcatTiposdeGanadoReturnsNewIfNotFound = True
			_alwaysFetchMcgcatTiposdeGanado = False
			_alreadyFetchedMcgcatTiposdeGanado = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolRecep", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveRenglon", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrecioXkilo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKilosRecibidos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cabRegCom</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabRegCom(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabRegCom, AddressOf OnCabRegComPropertyChanged, "CabRegCom", DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, True, signalRelatedEntity, "DetRegCom", resetFKFields, New Integer() { CInt(DetRegComFieldIndex.FolRecep) } )
			_cabRegCom = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cabRegCom</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabRegCom(relatedEntity As IEntity)
			DesetupSyncCabRegCom(True, True)
			_cabRegCom = CType(relatedEntity, CabRegComEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabRegCom, AddressOf OnCabRegComPropertyChanged, "CabRegCom", DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, True, _alreadyFetchedCabRegCom, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabRegComPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcgcatTiposdeGanado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, True, signalRelatedEntity, "DetRegCom", resetFKFields, New Integer() { CInt(DetRegComFieldIndex.CveGanado) } )
			_mcgcatTiposdeGanado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcgcatTiposdeGanado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcgcatTiposdeGanado(relatedEntity As IEntity)
			DesetupSyncMcgcatTiposdeGanado(True, True)
			_mcgcatTiposdeGanado = CType(relatedEntity, McgcatTiposdeGanadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcgcatTiposdeGanado, AddressOf OnMcgcatTiposdeGanadoPropertyChanged, "McgcatTiposdeGanado", DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, True, _alreadyFetchedMcgcatTiposdeGanado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcgcatTiposdeGanadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folRecep">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveRenglon">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="cveGanado">PK value for DetRegCom which data should be fetched into this DetRegCom Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folRecep As System.String, cveRenglon As System.Int16, cveGanado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(DetRegComFieldIndex.FolRecep)).ForcedCurrentValueWrite(folRecep)
				MyBase.Fields(CInt(DetRegComFieldIndex.CveRenglon)).ForcedCurrentValueWrite(cveRenglon)
				MyBase.Fields(CInt(DetRegComFieldIndex.CveGanado)).ForcedCurrentValueWrite(cveGanado)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateDetRegComDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New DetRegComEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As DetRegComRelations
			Get	
				Return New DetRegComRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					DetRegComEntity.Relations.CabRegComEntityUsingFolRecep, _
					CType(Integralab.ORM.EntityType.DetRegComEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatTiposdeGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatTiposdeGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatTiposdeGanadoCollection(), _
					DetRegComEntity.Relations.McgcatTiposdeGanadoEntityUsingCveGanado, _
					CType(Integralab.ORM.EntityType.DetRegComEntity, Integer), CType(Integralab.ORM.EntityType.McgcatTiposdeGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "McgcatTiposdeGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "DetRegComEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return DetRegComEntity.CustomProperties
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
				Return DetRegComEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolRecep property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."Fol_Recep"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolRecep]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.FolRecep, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.FolRecep, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveRenglon property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."Cve_Renglon"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CveRenglon]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.CveRenglon, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.CveRenglon, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveGanado property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."Cve_Ganado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CveGanado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.CveGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.CveGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabezas property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."CantCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCabezas]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.CantCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.CantCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKilos property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."CantKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.CantKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.CantKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrecioXkilo property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."PrecioXKilo"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrecioXkilo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.PrecioXkilo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.PrecioXkilo, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKilosRecibidos property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."CantKilosRecibidos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 3, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKilosRecibidos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.CantKilosRecibidos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.CantKilosRecibidos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity DetRegCom<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetRegCom"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetRegComFieldIndex.Importe, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(DetRegComFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'CabRegComEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabRegCom]() As CabRegComEntity
			Get
				Return GetSingleCabRegCom(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabRegCom(value)
				Else
					If value Is Nothing Then
						If Not _cabRegCom Is Nothing Then
							_cabRegCom.UnsetRelatedEntity(Me, "DetRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DetRegCom")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegCom. When set to true, CabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegCom As Boolean
			Get
				Return _alwaysFetchCabRegCom
			End Get
			Set
				_alwaysFetchCabRegCom = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabRegCom is not found
		''' in the database. When set to true, CabRegCom will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabRegComReturnsNewIfNotFound As Boolean
			Get
				Return _cabRegComReturnsNewIfNotFound
			End Get
			Set
				_cabRegComReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McgcatTiposdeGanadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcgcatTiposdeGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McgcatTiposdeGanado]() As McgcatTiposdeGanadoEntity
			Get
				Return GetSingleMcgcatTiposdeGanado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcgcatTiposdeGanado(value)
				Else
					If value Is Nothing Then
						If Not _mcgcatTiposdeGanado Is Nothing Then
							_mcgcatTiposdeGanado.UnsetRelatedEntity(Me, "DetRegCom")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DetRegCom")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatTiposdeGanado. When set to true, McgcatTiposdeGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatTiposdeGanado is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcgcatTiposdeGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatTiposdeGanado As Boolean
			Get
				Return _alwaysFetchMcgcatTiposdeGanado
			End Get
			Set
				_alwaysFetchMcgcatTiposdeGanado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McgcatTiposdeGanado is not found
		''' in the database. When set to true, McgcatTiposdeGanado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McgcatTiposdeGanadoReturnsNewIfNotFound As Boolean
			Get
				Return _mcgcatTiposdeGanadoReturnsNewIfNotFound
			End Get
			Set
				_mcgcatTiposdeGanadoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.DetRegComEntity)
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
