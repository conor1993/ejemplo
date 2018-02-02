' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:47
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
	''' <summary>Entity class which represents the entity 'SolicitudServiciosDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class SolicitudServiciosDetalleEntity 
#Else
	<Serializable()> _
	Public Class SolicitudServiciosDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cotizacionServicioDetalle As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
		Private _alwaysFetchCotizacionServicioDetalle, _alreadyFetchedCotizacionServicioDetalle As Boolean
		Private _usrCompOrdenServicioDetalle As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
		Private _alwaysFetchUsrCompOrdenServicioDetalle, _alreadyFetchedUsrCompOrdenServicioDetalle As Boolean
		Private _cotizacionServicioCollectionViaCotizacionServicioDetalle As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
		Private _alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle, _alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle As Boolean
		Private _usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle As Integralab.ORM.CollectionClasses.OrdenServicioCollection
		Private _alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle, _alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle As Boolean
		Private _solicitudServicios As SolicitudServiciosEntity
		Private _alwaysFetchSolicitudServicios, _alreadyFetchedSolicitudServicios, _solicitudServiciosReturnsNewIfNotFound As Boolean


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
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		Public Sub New(folio As System.String, indice As System.Int32)

			InitClassFetch(folio, indice, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folio As System.String, indice As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folio, indice, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="validator">The custom validator Object for this SolicitudServiciosDetalleEntity</param>
		Public Sub New(folio As System.String, indice As System.Int32, validator As IValidator)

			InitClassFetch(folio, indice, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cotizacionServicioDetalle = CType(info.GetValue("_cotizacionServicioDetalle", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection)
			_alwaysFetchCotizacionServicioDetalle = info.GetBoolean("_alwaysFetchCotizacionServicioDetalle")
			_alreadyFetchedCotizacionServicioDetalle = info.GetBoolean("_alreadyFetchedCotizacionServicioDetalle")
			_usrCompOrdenServicioDetalle = CType(info.GetValue("_usrCompOrdenServicioDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection)), Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection)
			_alwaysFetchUsrCompOrdenServicioDetalle = info.GetBoolean("_alwaysFetchUsrCompOrdenServicioDetalle")
			_alreadyFetchedUsrCompOrdenServicioDetalle = info.GetBoolean("_alreadyFetchedUsrCompOrdenServicioDetalle")
			_cotizacionServicioCollectionViaCotizacionServicioDetalle = CType(info.GetValue("_cotizacionServicioCollectionViaCotizacionServicioDetalle", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioCollection)
			_alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle = info.GetBoolean("_alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle")
			_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle = info.GetBoolean("_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle")
			_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = CType(info.GetValue("_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenServicioCollection)), Integralab.ORM.CollectionClasses.OrdenServicioCollection)
			_alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = info.GetBoolean("_alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle")
			_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = info.GetBoolean("_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle")
			_solicitudServicios = CType(info.GetValue("_solicitudServicios", GetType(SolicitudServiciosEntity)), SolicitudServiciosEntity)
			If Not _solicitudServicios Is Nothing Then
				AddHandler _solicitudServicios.AfterSave, AddressOf OnEntityAfterSave
			End If
			_solicitudServiciosReturnsNewIfNotFound = info.GetBoolean("_solicitudServiciosReturnsNewIfNotFound")
			_alwaysFetchSolicitudServicios = info.GetBoolean("_alwaysFetchSolicitudServicios")
			_alreadyFetchedSolicitudServicios = info.GetBoolean("_alreadyFetchedSolicitudServicios")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCotizacionServicioDetalle = (_cotizacionServicioDetalle.Count > 0)
			_alreadyFetchedUsrCompOrdenServicioDetalle = (_usrCompOrdenServicioDetalle.Count > 0)
			_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle = (_cotizacionServicioCollectionViaCotizacionServicioDetalle.Count > 0)
			_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = (_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.Count > 0)
			_alreadyFetchedSolicitudServicios = Not(_solicitudServicios Is Nothing)

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
			info.AddValue("_cotizacionServicioDetalle", _cotizacionServicioDetalle)
			info.AddValue("_alwaysFetchCotizacionServicioDetalle", _alwaysFetchCotizacionServicioDetalle)
			info.AddValue("_alreadyFetchedCotizacionServicioDetalle", _alreadyFetchedCotizacionServicioDetalle)
			info.AddValue("_usrCompOrdenServicioDetalle", _usrCompOrdenServicioDetalle)
			info.AddValue("_alwaysFetchUsrCompOrdenServicioDetalle", _alwaysFetchUsrCompOrdenServicioDetalle)
			info.AddValue("_alreadyFetchedUsrCompOrdenServicioDetalle", _alreadyFetchedUsrCompOrdenServicioDetalle)
			info.AddValue("_cotizacionServicioCollectionViaCotizacionServicioDetalle", _cotizacionServicioCollectionViaCotizacionServicioDetalle)
			info.AddValue("_alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle", _alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle)
			info.AddValue("_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle", _alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle)
			info.AddValue("_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle", _usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle)
			info.AddValue("_alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle", _alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle)
			info.AddValue("_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle", _alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle)
			info.AddValue("_solicitudServicios", _solicitudServicios)
			info.AddValue("_solicitudServiciosReturnsNewIfNotFound", _solicitudServiciosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSolicitudServicios", _alwaysFetchSolicitudServicios)
			info.AddValue("_alreadyFetchedSolicitudServicios", _alreadyFetchedSolicitudServicios)

			
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
				Case "SolicitudServicios"
					_alreadyFetchedSolicitudServicios = True
					Me.SolicitudServicios = CType(entity, SolicitudServiciosEntity)
				Case "CotizacionServicioDetalle"
					_alreadyFetchedCotizacionServicioDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionServicioDetalle.Add(CType(entity, CotizacionServicioDetalleEntity))
					End If
				Case "UsrCompOrdenServicioDetalle"
					_alreadyFetchedUsrCompOrdenServicioDetalle = True
					If Not entity Is Nothing Then
						Me.UsrCompOrdenServicioDetalle.Add(CType(entity, OrdenServicioDetalleEntity))
					End If
				Case "CotizacionServicioCollectionViaCotizacionServicioDetalle"
					_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionServicioCollectionViaCotizacionServicioDetalle.Add(CType(entity, CotizacionServicioEntity))
					End If
				Case "UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle"
					_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = True
					If Not entity Is Nothing Then
						Me.UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.Add(CType(entity, OrdenServicioEntity))
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
				Case "SolicitudServicios"
					SetupSyncSolicitudServicios(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionServicioDetalle"
					_cotizacionServicioDetalle.Add(CType(relatedEntity, CotizacionServicioDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCompOrdenServicioDetalle"
					_usrCompOrdenServicioDetalle.Add(CType(relatedEntity, OrdenServicioDetalleEntity))
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
				Case "SolicitudServicios"
					DesetupSyncSolicitudServicios(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionServicioDetalle"
					MyBase.PerformRelatedEntityRemoval(_cotizacionServicioDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCompOrdenServicioDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrCompOrdenServicioDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _solicitudServicios Is Nothing Then
				toReturn.Add(_solicitudServicios)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cotizacionServicioDetalle)
			toReturn.Add(_usrCompOrdenServicioDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, indice As System.Int32) As Boolean
			Return FetchUsingPK(folio, indice, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, indice As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folio, indice, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, indice As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folio, indice, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Folio, Me.Indice, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As SolicitudServiciosDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As SolicitudServiciosDetalleFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioDetalleEntity'</returns>
		Public Function GetMultiCotizacionServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiCotizacionServicioDetalle(forceFetch, _cotizacionServicioDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiCotizacionServicioDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioDetalleEntity'</returns>
		Public Function GetMultiCotizacionServicioDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiCotizacionServicioDetalle(forceFetch, _cotizacionServicioDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			If ( Not _alreadyFetchedCotizacionServicioDetalle Or forceFetch Or _alwaysFetchCotizacionServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionServicioDetalle)
					End If
				End If
				_cotizacionServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionServicioDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_cotizacionServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionServicioDetalle = True
			End If
			Return _cotizacionServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionServicioDetalle'. These settings will be taken into account
		''' when the property CotizacionServicioDetalle is requested or GetMultiCotizacionServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionServicioDetalle.SortClauses=sortClauses
			_cotizacionServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioDetalleEntity'</returns>
		Public Function GetMultiUsrCompOrdenServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
			Return GetMultiUsrCompOrdenServicioDetalle(forceFetch, _usrCompOrdenServicioDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCompOrdenServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
			Return GetMultiUsrCompOrdenServicioDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioDetalleEntity'</returns>
		Public Function GetMultiUsrCompOrdenServicioDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
			Return GetMultiUsrCompOrdenServicioDetalle(forceFetch, _usrCompOrdenServicioDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCompOrdenServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
			If ( Not _alreadyFetchedUsrCompOrdenServicioDetalle Or forceFetch Or _alwaysFetchUsrCompOrdenServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCompOrdenServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCompOrdenServicioDetalle)
					End If
				End If
				_usrCompOrdenServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCompOrdenServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCompOrdenServicioDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_usrCompOrdenServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCompOrdenServicioDetalle = True
			End If
			Return _usrCompOrdenServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCompOrdenServicioDetalle'. These settings will be taken into account
		''' when the property UsrCompOrdenServicioDetalle is requested or GetMultiUsrCompOrdenServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCompOrdenServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCompOrdenServicioDetalle.SortClauses=sortClauses
			_usrCompOrdenServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioEntity'</returns>
		Public Function GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle(forceFetch, _cotizacionServicioCollectionViaCotizacionServicioDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			If ( Not _alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle Or forceFetch Or _alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionServicioCollectionViaCotizacionServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionServicioCollectionViaCotizacionServicioDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(SolicitudServiciosDetalleEntity.Relations.CotizacionServicioDetalleEntityUsingFolioSolicitudIndice, "__SolicitudServiciosDetalleEntity__", "CotizacionServicioDetalle_", JoinHint.None)
				relations.Add(CotizacionServicioDetalleEntity.Relations.CotizacionServicioEntityUsingFolioCotizacion, "CotizacionServicioDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), ComparisonOperator.Equal, Me.Folio))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), ComparisonOperator.Equal, Me.Indice))
				_cotizacionServicioCollectionViaCotizacionServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionServicioCollectionViaCotizacionServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionServicioCollectionViaCotizacionServicioDetalle.GetMulti(Filter, relations)
				_cotizacionServicioCollectionViaCotizacionServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle = True
			End If
			Return _cotizacionServicioCollectionViaCotizacionServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionServicioCollectionViaCotizacionServicioDetalle'. These settings will be taken into account
		''' when the property CotizacionServicioCollectionViaCotizacionServicioDetalle is requested or GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionServicioCollectionViaCotizacionServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionServicioCollectionViaCotizacionServicioDetalle.SortClauses=sortClauses
			_cotizacionServicioCollectionViaCotizacionServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioEntity'</returns>
		Public Function GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(forceFetch, _usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			If ( Not _alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle Or forceFetch Or _alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(SolicitudServiciosDetalleEntity.Relations.OrdenServicioDetalleEntityUsingFolioDetalleSolicitudIndice, "__SolicitudServiciosDetalleEntity__", "OrdenServicioDetalle_", JoinHint.None)
				relations.Add(OrdenServicioDetalleEntity.Relations.OrdenServicioEntityUsingFolio, "OrdenServicioDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Folio), ComparisonOperator.Equal, Me.Folio))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(SolicitudServiciosDetalleFieldIndex.Indice), ComparisonOperator.Equal, Me.Indice))
				_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.GetMulti(Filter, relations)
				_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = True
			End If
			Return _usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle'. These settings will be taken into account
		''' when the property UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle is requested or GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.SortClauses=sortClauses
			_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'SolicitudServiciosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SolicitudServiciosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudServicios() As SolicitudServiciosEntity
			Return GetSingleSolicitudServicios(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SolicitudServiciosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SolicitudServiciosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudServicios(forceFetch As Boolean) As SolicitudServiciosEntity
			If ( Not _alreadyFetchedSolicitudServicios Or forceFetch Or _alwaysFetchSolicitudServicios) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SolicitudServiciosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SolicitudServiciosDetalleEntity.Relations.SolicitudServiciosEntityUsingFolio) Then
					fetchResult = newEntity.FetchUsingPK(Me.Folio)
				End If
				If Not _solicitudServiciosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.SolicitudServicios = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SolicitudServiciosEntity)
					End If
					Me.SolicitudServicios = newEntity
					_alreadyFetchedSolicitudServicios = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _solicitudServicios
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(SolicitudServiciosDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, SolicitudServiciosDetalleFieldIndex)
					Case SolicitudServiciosDetalleFieldIndex.Folio
						DesetupSyncSolicitudServicios(True, False)
						_alreadyFetchedSolicitudServicios = False








					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cotizacionServicioDetalle.ActiveContext = MyBase.ActiveContext
			_usrCompOrdenServicioDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionServicioCollectionViaCotizacionServicioDetalle.ActiveContext = MyBase.ActiveContext
			_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle.ActiveContext = MyBase.ActiveContext
		If Not _solicitudServicios Is Nothing Then
				_solicitudServicios.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As SolicitudServiciosDetalleDAO = CType(CreateDAOInstance(), SolicitudServiciosDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As SolicitudServiciosDetalleDAO = CType(CreateDAOInstance(), SolicitudServiciosDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As SolicitudServiciosDetalleDAO = CType(CreateDAOInstance(), SolicitudServiciosDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this SolicitudServiciosDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="validator">The validator Object for this SolicitudServiciosDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folio As System.String, indice As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folio, indice, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cotizacionServicioDetalle = New Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection(New CotizacionServicioDetalleEntityFactory())
			_cotizacionServicioDetalle.SetContainingEntityInfo(Me, "SolicitudServiciosDetalle")
			_alwaysFetchCotizacionServicioDetalle = False
			_alreadyFetchedCotizacionServicioDetalle = False
			_usrCompOrdenServicioDetalle = New Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection(New OrdenServicioDetalleEntityFactory())
			_usrCompOrdenServicioDetalle.SetContainingEntityInfo(Me, "SolicitudServiciosDetalle")
			_alwaysFetchUsrCompOrdenServicioDetalle = False
			_alreadyFetchedUsrCompOrdenServicioDetalle = False
			_cotizacionServicioCollectionViaCotizacionServicioDetalle = New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(New CotizacionServicioEntityFactory())
			_alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle = False
			_alreadyFetchedCotizacionServicioCollectionViaCotizacionServicioDetalle = False
			_usrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = New Integralab.ORM.CollectionClasses.OrdenServicioCollection(New OrdenServicioEntityFactory())
			_alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = False
			_alreadyFetchedUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = False
			_solicitudServicios = Nothing
			_solicitudServiciosReturnsNewIfNotFound = True
			_alwaysFetchSolicitudServicios = False
			_alreadyFetchedSolicitudServicios = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Indice", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Servicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Urgente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaServicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioPresupuesto", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _solicitudServicios</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSolicitudServicios(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _solicitudServicios, AddressOf OnSolicitudServiciosPropertyChanged, "SolicitudServicios", SolicitudServiciosDetalleEntity.Relations.SolicitudServiciosEntityUsingFolio, True, signalRelatedEntity, "SolicitudServiciosDetalle", resetFKFields, New Integer() { CInt(SolicitudServiciosDetalleFieldIndex.Folio) } )
			_solicitudServicios = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _solicitudServicios</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSolicitudServicios(relatedEntity As IEntity)
			DesetupSyncSolicitudServicios(True, True)
			_solicitudServicios = CType(relatedEntity, SolicitudServiciosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _solicitudServicios, AddressOf OnSolicitudServiciosPropertyChanged, "SolicitudServicios", SolicitudServiciosDetalleEntity.Relations.SolicitudServiciosEntityUsingFolio, True, _alreadyFetchedSolicitudServicios, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSolicitudServiciosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folio">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="indice">PK value for SolicitudServiciosDetalle which data should be fetched into this SolicitudServiciosDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folio As System.String, indice As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(SolicitudServiciosDetalleFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				MyBase.Fields(CInt(SolicitudServiciosDetalleFieldIndex.Indice)).ForcedCurrentValueWrite(indice)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateSolicitudServiciosDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New SolicitudServiciosDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As SolicitudServiciosDetalleRelations
			Get	
				Return New SolicitudServiciosDetalleRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicioDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionServicioDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection(), _
					SolicitudServiciosDetalleEntity.Relations.CotizacionServicioDetalleEntityUsingFolioSolicitudIndice, _
					CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenServicioDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCompOrdenServicioDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection(), _
					SolicitudServiciosDetalleEntity.Relations.OrdenServicioDetalleEntityUsingFolioDetalleSolicitudIndice, _
					CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), CType(Integralab.ORM.EntityType.OrdenServicioDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCompOrdenServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionServicioCollectionViaCotizacionServicioDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SolicitudServiciosDetalleEntity.Relations.CotizacionServicioDetalleEntityUsingFolioSolicitudIndice, "__SolicitudServiciosDetalleEntity__", String.Empty, JoinHint.None)
				relations.Add(CotizacionServicioDetalleEntity.Relations.CotizacionServicioEntityUsingFolioCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(), _
					SolicitudServiciosDetalleEntity.Relations.CotizacionServicioDetalleEntityUsingFolioSolicitudIndice, _
					CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionServicioCollectionViaCotizacionServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(SolicitudServiciosDetalleEntity.Relations.OrdenServicioDetalleEntityUsingFolioDetalleSolicitudIndice, "__SolicitudServiciosDetalleEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenServicioDetalleEntity.Relations.OrdenServicioEntityUsingFolio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenServicioCollection(), _
					SolicitudServiciosDetalleEntity.Relations.OrdenServicioDetalleEntityUsingFolioDetalleSolicitudIndice, _
					CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), CType(Integralab.ORM.EntityType.OrdenServicioEntity, Integer), 0, Nothing, Nothing, relations, "UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudServicios' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudServicios() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudServiciosCollection(), _
					SolicitudServiciosDetalleEntity.Relations.SolicitudServiciosEntityUsingFolio, _
					CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudServiciosEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudServicios", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "SolicitudServiciosDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return SolicitudServiciosDetalleEntity.CustomProperties
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
				Return SolicitudServiciosDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Folio property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Indice property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Indice"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Indice]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Indice, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Indice, Integer), value)
			End Set
		End Property
	
		''' <summary>The Servicio property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Servicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Servicio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Servicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Servicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Cantidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Cantidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Urgente property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Urgente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Urgente]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Urgente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Urgente, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaServicio property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."FechaServicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaServicio]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.FechaServicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.FechaServicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioPresupuesto property of the Entity SolicitudServiciosDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCompSolicitudServiciosDetalle"."FolioPresupuesto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioPresupuesto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SolicitudServiciosDetalleFieldIndex.FolioPresupuesto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SolicitudServiciosDetalleFieldIndex.FolioPresupuesto, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionServicioDetalle]() As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Get
				Return GetMultiCotizacionServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionServicioDetalle. When set to true, CotizacionServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionServicioDetalle As Boolean
			Get
				Return _alwaysFetchCotizacionServicioDetalle
			End Get
			Set
				_alwaysFetchCotizacionServicioDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCompOrdenServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCompOrdenServicioDetalle]() As Integralab.ORM.CollectionClasses.OrdenServicioDetalleCollection
			Get
				Return GetMultiUsrCompOrdenServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCompOrdenServicioDetalle. When set to true, UsrCompOrdenServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCompOrdenServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCompOrdenServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCompOrdenServicioDetalle As Boolean
			Get
				Return _alwaysFetchUsrCompOrdenServicioDetalle
			End Get
			Set
				_alwaysFetchUsrCompOrdenServicioDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionServicioCollectionViaCotizacionServicioDetalle]() As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Get
				Return GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionServicioCollectionViaCotizacionServicioDetalle. When set to true, CotizacionServicioCollectionViaCotizacionServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionServicioCollectionViaCotizacionServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionServicioCollectionViaCotizacionServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle As Boolean
			Get
				Return _alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle
			End Get
			Set
				_alwaysFetchCotizacionServicioCollectionViaCotizacionServicioDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle]() As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Get
				Return GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle. When set to true, UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle As Boolean
			Get
				Return _alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle
			End Get
			Set
				_alwaysFetchUsrCompOrdenServicioCollectionViaUsrCompOrdenServicioDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'SolicitudServiciosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSolicitudServicios()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [SolicitudServicios]() As SolicitudServiciosEntity
			Get
				Return GetSingleSolicitudServicios(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSolicitudServicios(value)
				Else
					If value Is Nothing Then
						If Not _solicitudServicios Is Nothing Then
							_solicitudServicios.UnsetRelatedEntity(Me, "SolicitudServiciosDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "SolicitudServiciosDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudServicios. When set to true, SolicitudServicios is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudServicios is accessed. You can always execute
		''' a forced fetch by calling GetSingleSolicitudServicios(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudServicios As Boolean
			Get
				Return _alwaysFetchSolicitudServicios
			End Get
			Set
				_alwaysFetchSolicitudServicios = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property SolicitudServicios is not found
		''' in the database. When set to true, SolicitudServicios will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SolicitudServiciosReturnsNewIfNotFound As Boolean
			Get
				Return _solicitudServiciosReturnsNewIfNotFound
			End Get
			Set
				_solicitudServiciosReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity)
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
