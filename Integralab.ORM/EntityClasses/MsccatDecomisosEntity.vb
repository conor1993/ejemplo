' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:33
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
	''' <summary>Entity class which represents the entity 'MsccatDecomisos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MsccatDecomisosEntity 
#Else
	<Serializable()> _
	Public Class MsccatDecomisosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _msccatProductosDetalle As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
		Private _alwaysFetchMsccatProductosDetalle, _alreadyFetchedMsccatProductosDetalle As Boolean
		Private _usrProdRegistroSacrificiosDecomiso As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
		Private _alwaysFetchUsrProdRegistroSacrificiosDecomiso, _alreadyFetchedUsrProdRegistroSacrificiosDecomiso As Boolean
		Private _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso, _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso As Boolean
		Private _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_, _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Boolean



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
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		Public Sub New(idDecomiso As System.Int32)

			InitClassFetch(idDecomiso, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idDecomiso As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idDecomiso, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="validator">The custom validator Object for this MsccatDecomisosEntity</param>
		Public Sub New(idDecomiso As System.Int32, validator As IValidator)

			InitClassFetch(idDecomiso, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_msccatProductosDetalle = CType(info.GetValue("_msccatProductosDetalle", GetType(Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection)), Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection)
			_alwaysFetchMsccatProductosDetalle = info.GetBoolean("_alwaysFetchMsccatProductosDetalle")
			_alreadyFetchedMsccatProductosDetalle = info.GetBoolean("_alreadyFetchedMsccatProductosDetalle")
			_usrProdRegistroSacrificiosDecomiso = CType(info.GetValue("_usrProdRegistroSacrificiosDecomiso", GetType(Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)), Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection)
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alwaysFetchUsrProdRegistroSacrificiosDecomiso")
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso")
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso")
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMsccatProductosDetalle = (_msccatProductosDetalle.Count > 0)
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = (_usrProdRegistroSacrificiosDecomiso.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = (_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = (_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.Count > 0)


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
			info.AddValue("_msccatProductosDetalle", _msccatProductosDetalle)
			info.AddValue("_alwaysFetchMsccatProductosDetalle", _alwaysFetchMsccatProductosDetalle)
			info.AddValue("_alreadyFetchedMsccatProductosDetalle", _alreadyFetchedMsccatProductosDetalle)
			info.AddValue("_usrProdRegistroSacrificiosDecomiso", _usrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alwaysFetchUsrProdRegistroSacrificiosDecomiso", _alwaysFetchUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alreadyFetchedUsrProdRegistroSacrificiosDecomiso", _alreadyFetchedUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso", _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso", _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso", _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_", _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_", _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_", _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_)


			
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

				Case "MsccatProductosDetalle"
					_alreadyFetchedMsccatProductosDetalle = True
					If Not entity Is Nothing Then
						Me.MsccatProductosDetalle.Add(CType(entity, MsccatProductosDetalleEntity))
					End If
				Case "UsrProdRegistroSacrificiosDecomiso"
					_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = True
					If Not entity Is Nothing Then
						Me.UsrProdRegistroSacrificiosDecomiso.Add(CType(entity, UsrProdRegistroSacrificiosDecomisoEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.Add(CType(entity, MscmovtosAlmacenCabEntity))
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

				Case "MsccatProductosDetalle"
					_msccatProductosDetalle.Add(CType(relatedEntity, MsccatProductosDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					_usrProdRegistroSacrificiosDecomiso.Add(CType(relatedEntity, UsrProdRegistroSacrificiosDecomisoEntity))
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

				Case "MsccatProductosDetalle"
					MyBase.PerformRelatedEntityRemoval(_msccatProductosDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdRegistroSacrificiosDecomiso"
					MyBase.PerformRelatedEntityRemoval(_usrProdRegistroSacrificiosDecomiso, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_msccatProductosDetalle)
			toReturn.Add(_usrProdRegistroSacrificiosDecomiso)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDecomiso As System.Int32) As Boolean
			Return FetchUsingPK(idDecomiso, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDecomiso As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idDecomiso, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idDecomiso As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idDecomiso, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdDecomiso, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MsccatDecomisosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MsccatDecomisosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosDetalleEntity'</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, _msccatProductosDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosDetalleEntity'</returns>
		Public Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Return GetMultiMsccatProductosDetalle(forceFetch, _msccatProductosDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductosDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			If ( Not _alreadyFetchedMsccatProductosDetalle Or forceFetch Or _alwaysFetchMsccatProductosDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductosDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductosDetalle)
					End If
				End If
				_msccatProductosDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductosDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductosDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_msccatProductosDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductosDetalle = True
			End If
			Return _msccatProductosDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductosDetalle'. These settings will be taken into account
		''' when the property MsccatProductosDetalle is requested or GetMultiMsccatProductosDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductosDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductosDetalle.SortClauses=sortClauses
			_msccatProductosDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, _usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity'</returns>
		Public Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Return GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch, _usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			If ( Not _alreadyFetchedUsrProdRegistroSacrificiosDecomiso Or forceFetch Or _alwaysFetchUsrProdRegistroSacrificiosDecomiso) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdRegistroSacrificiosDecomiso.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdRegistroSacrificiosDecomiso)
					End If
				End If
				_usrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdRegistroSacrificiosDecomiso.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdRegistroSacrificiosDecomiso.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_usrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = True
			End If
			Return _usrProdRegistroSacrificiosDecomiso
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdRegistroSacrificiosDecomiso'. These settings will be taken into account
		''' when the property UsrProdRegistroSacrificiosDecomiso is requested or GetMultiUsrProdRegistroSacrificiosDecomiso is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdRegistroSacrificiosDecomiso(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdRegistroSacrificiosDecomiso.SortClauses=sortClauses
			_usrProdRegistroSacrificiosDecomiso.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch, _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, "__MsccatDecomisosEntity__", "UsrProdRegistroSacrificiosDecomiso_", JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, "UsrProdRegistroSacrificiosDecomiso_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatDecomisosFieldIndex.IdDecomiso), ComparisonOperator.Equal, Me.IdDecomiso))
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso is requested or GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch, _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, "__MsccatDecomisosEntity__", "UsrProdRegistroSacrificiosDecomiso_", JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, "UsrProdRegistroSacrificiosDecomiso_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MsccatDecomisosFieldIndex.IdDecomiso), ComparisonOperator.Equal, Me.IdDecomiso))
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ is requested or GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MsccatDecomisosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MsccatDecomisosFieldIndex)





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_msccatProductosDetalle.ActiveContext = MyBase.ActiveContext
			_usrProdRegistroSacrificiosDecomiso.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MsccatDecomisosDAO = CType(CreateDAOInstance(), MsccatDecomisosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MsccatDecomisosDAO = CType(CreateDAOInstance(), MsccatDecomisosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MsccatDecomisosDAO = CType(CreateDAOInstance(), MsccatDecomisosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MsccatDecomisosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MsccatDecomisosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="validator">The validator Object for this MsccatDecomisosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idDecomiso As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idDecomiso, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_msccatProductosDetalle = New Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection(New MsccatProductosDetalleEntityFactory())
			_msccatProductosDetalle.SetContainingEntityInfo(Me, "MsccatDecomisos")
			_alwaysFetchMsccatProductosDetalle = False
			_alreadyFetchedMsccatProductosDetalle = False
			_usrProdRegistroSacrificiosDecomiso = New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(New UsrProdRegistroSacrificiosDecomisoEntityFactory())
			_usrProdRegistroSacrificiosDecomiso.SetContainingEntityInfo(Me, "MsccatDecomisos")
			_alwaysFetchUsrProdRegistroSacrificiosDecomiso = False
			_alreadyFetchedUsrProdRegistroSacrificiosDecomiso = False
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = False
			_mscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idDecomiso">PK value for MsccatDecomisos which data should be fetched into this MsccatDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idDecomiso As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MsccatDecomisosFieldIndex.IdDecomiso)).ForcedCurrentValueWrite(idDecomiso)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMsccatDecomisosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MsccatDecomisosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MsccatDecomisosRelations
			Get	
				Return New MsccatDecomisosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductosDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection(), _
					MsccatDecomisosEntity.Relations.MsccatProductosDetalleEntityUsingIdDecomiso, _
					CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductosDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdRegistroSacrificiosDecomiso' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdRegistroSacrificiosDecomiso() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection(), _
					MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, _
					CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdRegistroSacrificiosDecomisoEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdRegistroSacrificiosDecomiso", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, "__MsccatDecomisosEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, _
					CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, "__MsccatDecomisosEntity__", String.Empty, JoinHint.None)
				relations.Add(UsrProdRegistroSacrificiosDecomisoEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MsccatDecomisosEntity.Relations.UsrProdRegistroSacrificiosDecomisoEntityUsingIdDecomiso, _
					CType(Integralab.ORM.EntityType.MsccatDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MsccatDecomisosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MsccatDecomisosEntity.CustomProperties
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
				Return MsccatDecomisosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdDecomiso property of the Entity MsccatDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatDecomisos"."IdDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdDecomiso]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatDecomisosFieldIndex.IdDecomiso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MsccatDecomisosFieldIndex.IdDecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity MsccatDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatDecomisos"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatDecomisosFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatDecomisosFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity MsccatDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatDecomisos"."DescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 6<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatDecomisosFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatDecomisosFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MsccatDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatDecomisos"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatDecomisosFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MsccatDecomisosFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MsccatDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCCatDecomisos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MsccatDecomisosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(MsccatDecomisosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductosDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductosDetalle]() As Integralab.ORM.CollectionClasses.MsccatProductosDetalleCollection
			Get
				Return GetMultiMsccatProductosDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosDetalle. When set to true, MsccatProductosDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductosDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosDetalle As Boolean
			Get
				Return _alwaysFetchMsccatProductosDetalle
			End Get
			Set
				_alwaysFetchMsccatProductosDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdRegistroSacrificiosDecomisoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdRegistroSacrificiosDecomiso()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdRegistroSacrificiosDecomiso]() As Integralab.ORM.CollectionClasses.UsrProdRegistroSacrificiosDecomisoCollection
			Get
				Return GetMultiUsrProdRegistroSacrificiosDecomiso(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdRegistroSacrificiosDecomiso. When set to true, UsrProdRegistroSacrificiosDecomiso is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdRegistroSacrificiosDecomiso is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdRegistroSacrificiosDecomiso(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdRegistroSacrificiosDecomiso As Boolean
			Get
				Return _alwaysFetchUsrProdRegistroSacrificiosDecomiso
			End Get
			Set
				_alwaysFetchUsrProdRegistroSacrificiosDecomiso = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso. When set to true, MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_. When set to true, MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaUsrProdRegistroSacrificiosDecomiso_ = value
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
				Return CInt(Integralab.ORM.EntityType.MsccatDecomisosEntity)
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
