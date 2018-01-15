' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 11 de enero de 2018 10:37:34
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
	''' <summary>Entity class which represents the entity 'MfacEmbarquesDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MfacEmbarquesDetEntity 
#Else
	<Serializable()> _
	Public Class MfacEmbarquesDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _facturasClientesCab As FacturasClientesCabEntity
		Private _alwaysFetchFacturasClientesCab, _alreadyFetchedFacturasClientesCab, _facturasClientesCabReturnsNewIfNotFound As Boolean
		Private _mfacEmbarquesCab As MfacEmbarquesCabEntity
		Private _alwaysFetchMfacEmbarquesCab, _alreadyFetchedMfacEmbarquesCab, _mfacEmbarquesCabReturnsNewIfNotFound As Boolean
		Private _msccatProductos As MsccatProductosEntity
		Private _alwaysFetchMsccatProductos, _alreadyFetchedMsccatProductos, _msccatProductosReturnsNewIfNotFound As Boolean
		Private _mscmovtosAlmacenCab As MscmovtosAlmacenCabEntity
		Private _alwaysFetchMscmovtosAlmacenCab, _alreadyFetchedMscmovtosAlmacenCab, _mscmovtosAlmacenCabReturnsNewIfNotFound As Boolean
		Private _registroSacrificiosDecomisos As RegistroSacrificiosDecomisosEntity
		Private _alwaysFetchRegistroSacrificiosDecomisos, _alreadyFetchedRegistroSacrificiosDecomisos, _registroSacrificiosDecomisosReturnsNewIfNotFound As Boolean


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
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		Public Sub New(idFolioEmbarque As System.String, renglon As System.Int32)

			InitClassFetch(idFolioEmbarque, renglon, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idFolioEmbarque As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idFolioEmbarque, renglon, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="validator">The custom validator Object for this MfacEmbarquesDetEntity</param>
		Public Sub New(idFolioEmbarque As System.String, renglon As System.Int32, validator As IValidator)

			InitClassFetch(idFolioEmbarque, renglon, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_facturasClientesCab = CType(info.GetValue("_facturasClientesCab", GetType(FacturasClientesCabEntity)), FacturasClientesCabEntity)
			If Not _facturasClientesCab Is Nothing Then
				AddHandler _facturasClientesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_facturasClientesCabReturnsNewIfNotFound = info.GetBoolean("_facturasClientesCabReturnsNewIfNotFound")
			_alwaysFetchFacturasClientesCab = info.GetBoolean("_alwaysFetchFacturasClientesCab")
			_alreadyFetchedFacturasClientesCab = info.GetBoolean("_alreadyFetchedFacturasClientesCab")
			_mfacEmbarquesCab = CType(info.GetValue("_mfacEmbarquesCab", GetType(MfacEmbarquesCabEntity)), MfacEmbarquesCabEntity)
			If Not _mfacEmbarquesCab Is Nothing Then
				AddHandler _mfacEmbarquesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacEmbarquesCabReturnsNewIfNotFound = info.GetBoolean("_mfacEmbarquesCabReturnsNewIfNotFound")
			_alwaysFetchMfacEmbarquesCab = info.GetBoolean("_alwaysFetchMfacEmbarquesCab")
			_alreadyFetchedMfacEmbarquesCab = info.GetBoolean("_alreadyFetchedMfacEmbarquesCab")
			_msccatProductos = CType(info.GetValue("_msccatProductos", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductos Is Nothing Then
				AddHandler _msccatProductos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosReturnsNewIfNotFound = info.GetBoolean("_msccatProductosReturnsNewIfNotFound")
			_alwaysFetchMsccatProductos = info.GetBoolean("_alwaysFetchMsccatProductos")
			_alreadyFetchedMsccatProductos = info.GetBoolean("_alreadyFetchedMsccatProductos")
			_mscmovtosAlmacenCab = CType(info.GetValue("_mscmovtosAlmacenCab", GetType(MscmovtosAlmacenCabEntity)), MscmovtosAlmacenCabEntity)
			If Not _mscmovtosAlmacenCab Is Nothing Then
				AddHandler _mscmovtosAlmacenCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscmovtosAlmacenCabReturnsNewIfNotFound = info.GetBoolean("_mscmovtosAlmacenCabReturnsNewIfNotFound")
			_alwaysFetchMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab")
			_alreadyFetchedMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab")
			_registroSacrificiosDecomisos = CType(info.GetValue("_registroSacrificiosDecomisos", GetType(RegistroSacrificiosDecomisosEntity)), RegistroSacrificiosDecomisosEntity)
			If Not _registroSacrificiosDecomisos Is Nothing Then
				AddHandler _registroSacrificiosDecomisos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_registroSacrificiosDecomisosReturnsNewIfNotFound = info.GetBoolean("_registroSacrificiosDecomisosReturnsNewIfNotFound")
			_alwaysFetchRegistroSacrificiosDecomisos = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisos")
			_alreadyFetchedRegistroSacrificiosDecomisos = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisos")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedFacturasClientesCab = Not(_facturasClientesCab Is Nothing)
			_alreadyFetchedMfacEmbarquesCab = Not(_mfacEmbarquesCab Is Nothing)
			_alreadyFetchedMsccatProductos = Not(_msccatProductos Is Nothing)
			_alreadyFetchedMscmovtosAlmacenCab = Not(_mscmovtosAlmacenCab Is Nothing)
			_alreadyFetchedRegistroSacrificiosDecomisos = Not(_registroSacrificiosDecomisos Is Nothing)

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


			info.AddValue("_facturasClientesCab", _facturasClientesCab)
			info.AddValue("_facturasClientesCabReturnsNewIfNotFound", _facturasClientesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchFacturasClientesCab", _alwaysFetchFacturasClientesCab)
			info.AddValue("_alreadyFetchedFacturasClientesCab", _alreadyFetchedFacturasClientesCab)
			info.AddValue("_mfacEmbarquesCab", _mfacEmbarquesCab)
			info.AddValue("_mfacEmbarquesCabReturnsNewIfNotFound", _mfacEmbarquesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacEmbarquesCab", _alwaysFetchMfacEmbarquesCab)
			info.AddValue("_alreadyFetchedMfacEmbarquesCab", _alreadyFetchedMfacEmbarquesCab)
			info.AddValue("_msccatProductos", _msccatProductos)
			info.AddValue("_msccatProductosReturnsNewIfNotFound", _msccatProductosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductos", _alwaysFetchMsccatProductos)
			info.AddValue("_alreadyFetchedMsccatProductos", _alreadyFetchedMsccatProductos)
			info.AddValue("_mscmovtosAlmacenCab", _mscmovtosAlmacenCab)
			info.AddValue("_mscmovtosAlmacenCabReturnsNewIfNotFound", _mscmovtosAlmacenCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab", _alwaysFetchMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab", _alreadyFetchedMscmovtosAlmacenCab)
			info.AddValue("_registroSacrificiosDecomisos", _registroSacrificiosDecomisos)
			info.AddValue("_registroSacrificiosDecomisosReturnsNewIfNotFound", _registroSacrificiosDecomisosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisos", _alwaysFetchRegistroSacrificiosDecomisos)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisos", _alreadyFetchedRegistroSacrificiosDecomisos)

			
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
				Case "FacturasClientesCab"
					_alreadyFetchedFacturasClientesCab = True
					Me.FacturasClientesCab = CType(entity, FacturasClientesCabEntity)
				Case "MfacEmbarquesCab"
					_alreadyFetchedMfacEmbarquesCab = True
					Me.MfacEmbarquesCab = CType(entity, MfacEmbarquesCabEntity)
				Case "MsccatProductos"
					_alreadyFetchedMsccatProductos = True
					Me.MsccatProductos = CType(entity, MsccatProductosEntity)
				Case "MscmovtosAlmacenCab"
					_alreadyFetchedMscmovtosAlmacenCab = True
					Me.MscmovtosAlmacenCab = CType(entity, MscmovtosAlmacenCabEntity)
				Case "RegistroSacrificiosDecomisos"
					_alreadyFetchedRegistroSacrificiosDecomisos = True
					Me.RegistroSacrificiosDecomisos = CType(entity, RegistroSacrificiosDecomisosEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "FacturasClientesCab"
					SetupSyncFacturasClientesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					SetupSyncMfacEmbarquesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductos"
					SetupSyncMsccatProductos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					SetupSyncMscmovtosAlmacenCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					SetupSyncRegistroSacrificiosDecomisos(relatedEntity)
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
				Case "FacturasClientesCab"
					DesetupSyncFacturasClientesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					DesetupSyncMfacEmbarquesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductos"
					DesetupSyncMsccatProductos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					DesetupSyncMscmovtosAlmacenCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RegistroSacrificiosDecomisos"
					DesetupSyncRegistroSacrificiosDecomisos(False, True)
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
			If Not _facturasClientesCab Is Nothing Then
				toReturn.Add(_facturasClientesCab)
			End If
			If Not _mfacEmbarquesCab Is Nothing Then
				toReturn.Add(_mfacEmbarquesCab)
			End If
			If Not _msccatProductos Is Nothing Then
				toReturn.Add(_msccatProductos)
			End If
			If Not _mscmovtosAlmacenCab Is Nothing Then
				toReturn.Add(_mscmovtosAlmacenCab)
			End If
			If Not _registroSacrificiosDecomisos Is Nothing Then
				toReturn.Add(_registroSacrificiosDecomisos)
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
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String, renglon As System.Int32) As Boolean
			Return FetchUsingPK(idFolioEmbarque, renglon, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idFolioEmbarque, renglon, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idFolioEmbarque, renglon, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdFolioEmbarque, Me.Renglon, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MfacEmbarquesDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MfacEmbarquesDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'FacturasClientesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'FacturasClientesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturasClientesCab() As FacturasClientesCabEntity
			Return GetSingleFacturasClientesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'FacturasClientesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'FacturasClientesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturasClientesCab(forceFetch As Boolean) As FacturasClientesCabEntity
			If ( Not _alreadyFetchedFacturasClientesCab Or forceFetch Or _alwaysFetchFacturasClientesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New FacturasClientesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura) Then
					fetchResult = newEntity.FetchUsingPK(Me.NoFactura, Me.SerieFactura)
				End If
				If Not _facturasClientesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.FacturasClientesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), FacturasClientesCabEntity)
					End If
					Me.FacturasClientesCab = newEntity
					_alreadyFetchedFacturasClientesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _facturasClientesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'MfacEmbarquesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacEmbarquesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacEmbarquesCab() As MfacEmbarquesCabEntity
			Return GetSingleMfacEmbarquesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacEmbarquesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacEmbarquesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacEmbarquesCab(forceFetch As Boolean) As MfacEmbarquesCabEntity
			If ( Not _alreadyFetchedMfacEmbarquesCab Or forceFetch Or _alwaysFetchMfacEmbarquesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacEmbarquesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdFolioEmbarque)
				End If
				If Not _mfacEmbarquesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MfacEmbarquesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacEmbarquesCabEntity)
					End If
					Me.MfacEmbarquesCab = newEntity
					_alreadyFetchedMfacEmbarquesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacEmbarquesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos() As MsccatProductosEntity
			Return GetSingleMsccatProductos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductos Or forceFetch Or _alwaysFetchMsccatProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _msccatProductosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductos = newEntity
					_alreadyFetchedMsccatProductos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductos
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdFolioMovimientoAlmacen)
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
	
		''' <summary>Retrieves the related entity of type 'RegistroSacrificiosDecomisosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'RegistroSacrificiosDecomisosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRegistroSacrificiosDecomisos() As RegistroSacrificiosDecomisosEntity
			Return GetSingleRegistroSacrificiosDecomisos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'RegistroSacrificiosDecomisosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'RegistroSacrificiosDecomisosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRegistroSacrificiosDecomisos(forceFetch As Boolean) As RegistroSacrificiosDecomisosEntity
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisos Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New RegistroSacrificiosDecomisosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioSacrificio, Me.IdProducto)
				End If
				If Not _registroSacrificiosDecomisosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.RegistroSacrificiosDecomisos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), RegistroSacrificiosDecomisosEntity)
					End If
					Me.RegistroSacrificiosDecomisos = newEntity
					_alreadyFetchedRegistroSacrificiosDecomisos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _registroSacrificiosDecomisos
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MfacEmbarquesDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MfacEmbarquesDetFieldIndex)
					Case MfacEmbarquesDetFieldIndex.IdFolioEmbarque
						DesetupSyncMfacEmbarquesCab(True, False)
						_alreadyFetchedMfacEmbarquesCab = False


					Case MfacEmbarquesDetFieldIndex.IdProducto
						DesetupSyncMsccatProductos(True, False)
						_alreadyFetchedMsccatProductos = False
						DesetupSyncRegistroSacrificiosDecomisos(True, False)
						_alreadyFetchedRegistroSacrificiosDecomisos = False




					Case MfacEmbarquesDetFieldIndex.NoFactura
						DesetupSyncFacturasClientesCab(True, False)
						_alreadyFetchedFacturasClientesCab = False
					Case MfacEmbarquesDetFieldIndex.FolioSacrificio
						DesetupSyncRegistroSacrificiosDecomisos(True, False)
						_alreadyFetchedRegistroSacrificiosDecomisos = False
					Case MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen
						DesetupSyncMscmovtosAlmacenCab(True, False)
						_alreadyFetchedMscmovtosAlmacenCab = False

					Case MfacEmbarquesDetFieldIndex.SerieFactura
						DesetupSyncFacturasClientesCab(True, False)
						_alreadyFetchedFacturasClientesCab = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _facturasClientesCab Is Nothing Then
				_facturasClientesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacEmbarquesCab Is Nothing Then
				_mfacEmbarquesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatProductos Is Nothing Then
				_msccatProductos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mscmovtosAlmacenCab Is Nothing Then
				_mscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _registroSacrificiosDecomisos Is Nothing Then
				_registroSacrificiosDecomisos.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MfacEmbarquesDetDAO = CType(CreateDAOInstance(), MfacEmbarquesDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MfacEmbarquesDetDAO = CType(CreateDAOInstance(), MfacEmbarquesDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MfacEmbarquesDetDAO = CType(CreateDAOInstance(), MfacEmbarquesDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MfacEmbarquesDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MfacEmbarquesDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="validator">The validator Object for this MfacEmbarquesDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idFolioEmbarque As System.String, renglon As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idFolioEmbarque, renglon, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_facturasClientesCab = Nothing
			_facturasClientesCabReturnsNewIfNotFound = True
			_alwaysFetchFacturasClientesCab = False
			_alreadyFetchedFacturasClientesCab = False
			_mfacEmbarquesCab = Nothing
			_mfacEmbarquesCabReturnsNewIfNotFound = True
			_alwaysFetchMfacEmbarquesCab = False
			_alreadyFetchedMfacEmbarquesCab = False
			_msccatProductos = Nothing
			_msccatProductosReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductos = False
			_alreadyFetchedMsccatProductos = False
			_mscmovtosAlmacenCab = Nothing
			_mscmovtosAlmacenCabReturnsNewIfNotFound = True
			_alwaysFetchMscmovtosAlmacenCab = False
			_alreadyFetchedMscmovtosAlmacenCab = False
			_registroSacrificiosDecomisos = Nothing
			_registroSacrificiosDecomisosReturnsNewIfNotFound = True
			_alwaysFetchRegistroSacrificiosDecomisos = False
			_alreadyFetchedRegistroSacrificiosDecomisos = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Renglon", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantPzas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKgrs", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimientoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SerieFactura", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _facturasClientesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncFacturasClientesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura, True, signalRelatedEntity, "MfacEmbarquesDet", resetFKFields, New Integer() { CInt(MfacEmbarquesDetFieldIndex.SerieFactura), CInt(MfacEmbarquesDetFieldIndex.NoFactura) } )
			_facturasClientesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _facturasClientesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncFacturasClientesCab(relatedEntity As IEntity)
			DesetupSyncFacturasClientesCab(True, True)
			_facturasClientesCab = CType(relatedEntity, FacturasClientesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura, True, _alreadyFetchedFacturasClientesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnFacturasClientesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mfacEmbarquesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacEmbarquesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacEmbarquesCab, AddressOf OnMfacEmbarquesCabPropertyChanged, "MfacEmbarquesCab", MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, True, signalRelatedEntity, "EmbarquesDet", resetFKFields, New Integer() { CInt(MfacEmbarquesDetFieldIndex.IdFolioEmbarque) } )
			_mfacEmbarquesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacEmbarquesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacEmbarquesCab(relatedEntity As IEntity)
			DesetupSyncMfacEmbarquesCab(True, True)
			_mfacEmbarquesCab = CType(relatedEntity, MfacEmbarquesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacEmbarquesCab, AddressOf OnMfacEmbarquesCabPropertyChanged, "MfacEmbarquesCab", MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, True, _alreadyFetchedMfacEmbarquesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacEmbarquesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _msccatProductos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, True, signalRelatedEntity, "MfacEmbarquesDet", resetFKFields, New Integer() { CInt(MfacEmbarquesDetFieldIndex.IdProducto) } )
			_msccatProductos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductos(relatedEntity As IEntity)
			DesetupSyncMsccatProductos(True, True)
			_msccatProductos = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, True, _alreadyFetchedMsccatProductos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscmovtosAlmacenCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen, True, signalRelatedEntity, "MfacEmbarquesDet", resetFKFields, New Integer() { CInt(MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen) } )
			_mscmovtosAlmacenCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscmovtosAlmacenCab(relatedEntity As IEntity)
			DesetupSyncMscmovtosAlmacenCab(True, True)
			_mscmovtosAlmacenCab = CType(relatedEntity, MscmovtosAlmacenCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen, True, _alreadyFetchedMscmovtosAlmacenCab, New String() {  } )
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
		''' <summary>Removes the sync logic for member _registroSacrificiosDecomisos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncRegistroSacrificiosDecomisos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _registroSacrificiosDecomisos, AddressOf OnRegistroSacrificiosDecomisosPropertyChanged, "RegistroSacrificiosDecomisos", MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto, True, signalRelatedEntity, "MfacEmbarquesDet", resetFKFields, New Integer() { CInt(MfacEmbarquesDetFieldIndex.FolioSacrificio), CInt(MfacEmbarquesDetFieldIndex.IdProducto) } )
			_registroSacrificiosDecomisos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _registroSacrificiosDecomisos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncRegistroSacrificiosDecomisos(relatedEntity As IEntity)
			DesetupSyncRegistroSacrificiosDecomisos(True, True)
			_registroSacrificiosDecomisos = CType(relatedEntity, RegistroSacrificiosDecomisosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _registroSacrificiosDecomisos, AddressOf OnRegistroSacrificiosDecomisosPropertyChanged, "RegistroSacrificiosDecomisos", MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto, True, _alreadyFetchedRegistroSacrificiosDecomisos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnRegistroSacrificiosDecomisosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="renglon">PK value for MfacEmbarquesDet which data should be fetched into this MfacEmbarquesDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idFolioEmbarque As System.String, renglon As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MfacEmbarquesDetFieldIndex.IdFolioEmbarque)).ForcedCurrentValueWrite(idFolioEmbarque)
				MyBase.Fields(CInt(MfacEmbarquesDetFieldIndex.Renglon)).ForcedCurrentValueWrite(renglon)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMfacEmbarquesDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MfacEmbarquesDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MfacEmbarquesDetRelations
			Get	
				Return New MfacEmbarquesDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosDecomisos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MfacEmbarquesDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MfacEmbarquesDetEntity.CustomProperties
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
				Return MfacEmbarquesDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdFolioEmbarque property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."IdFolioEmbarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdFolioEmbarque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioEmbarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioEmbarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The Renglon property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."Renglon"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Renglon]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.Renglon, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.Renglon, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioEtiqueta property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."IdFolioEtiqueta"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdFolioEtiqueta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioEtiqueta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioEtiqueta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantPzas property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."CantPzas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantPzas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.CantPzas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.CantPzas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKgrs property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."CantKgrs"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKgrs]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.CantKgrs, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.CantKgrs, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoProducto property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."TipoProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoProducto]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.TipoProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.TipoProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoFactura property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioSacrificio property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."FolioSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioSacrificio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.FolioSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.FolioSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimientoAlmacen property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."IdFolioMovimientoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimientoAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.IdFolioMovimientoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Precio property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."Precio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Precio]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.Precio, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.Precio, Integer), value)
			End Set
		End Property
	
		''' <summary>The SerieFactura property of the Entity MfacEmbarquesDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesDet"."SerieFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SerieFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesDetFieldIndex.SerieFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesDetFieldIndex.SerieFactura, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'FacturasClientesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleFacturasClientesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [FacturasClientesCab]() As FacturasClientesCabEntity
			Get
				Return GetSingleFacturasClientesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncFacturasClientesCab(value)
				Else
					If value Is Nothing Then
						If Not _facturasClientesCab Is Nothing Then
							_facturasClientesCab.UnsetRelatedEntity(Me, "MfacEmbarquesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCab. When set to true, FacturasClientesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleFacturasClientesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCab As Boolean
			Get
				Return _alwaysFetchFacturasClientesCab
			End Get
			Set
				_alwaysFetchFacturasClientesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property FacturasClientesCab is not found
		''' in the database. When set to true, FacturasClientesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property FacturasClientesCabReturnsNewIfNotFound As Boolean
			Get
				Return _facturasClientesCabReturnsNewIfNotFound
			End Get
			Set
				_facturasClientesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MfacEmbarquesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacEmbarquesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacEmbarquesCab]() As MfacEmbarquesCabEntity
			Get
				Return GetSingleMfacEmbarquesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacEmbarquesCab(value)
				Else
					If value Is Nothing Then
						If Not _mfacEmbarquesCab Is Nothing Then
							_mfacEmbarquesCab.UnsetRelatedEntity(Me, "EmbarquesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "EmbarquesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCab. When set to true, MfacEmbarquesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacEmbarquesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCab As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCab
			End Get
			Set
				_alwaysFetchMfacEmbarquesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacEmbarquesCab is not found
		''' in the database. When set to true, MfacEmbarquesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacEmbarquesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mfacEmbarquesCabReturnsNewIfNotFound
			End Get
			Set
				_mfacEmbarquesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductos]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductos(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductos Is Nothing Then
							_msccatProductos.UnsetRelatedEntity(Me, "MfacEmbarquesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductos. When set to true, MsccatProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductos is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductos
			End Get
			Set
				_alwaysFetchMsccatProductos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductos is not found
		''' in the database. When set to true, MsccatProductos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosReturnsNewIfNotFound = value
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
							_mscmovtosAlmacenCab.UnsetRelatedEntity(Me, "MfacEmbarquesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesDet")
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
	
		''' <summary>Gets / sets related entity of type 'RegistroSacrificiosDecomisosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRegistroSacrificiosDecomisos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [RegistroSacrificiosDecomisos]() As RegistroSacrificiosDecomisosEntity
			Get
				Return GetSingleRegistroSacrificiosDecomisos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncRegistroSacrificiosDecomisos(value)
				Else
					If value Is Nothing Then
						If Not _registroSacrificiosDecomisos Is Nothing Then
							_registroSacrificiosDecomisos.UnsetRelatedEntity(Me, "MfacEmbarquesDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisos. When set to true, RegistroSacrificiosDecomisos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisos is accessed. You can always execute
		''' a forced fetch by calling GetSingleRegistroSacrificiosDecomisos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisos As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisos
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property RegistroSacrificiosDecomisos is not found
		''' in the database. When set to true, RegistroSacrificiosDecomisos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property RegistroSacrificiosDecomisosReturnsNewIfNotFound As Boolean
			Get
				Return _registroSacrificiosDecomisosReturnsNewIfNotFound
			End Get
			Set
				_registroSacrificiosDecomisosReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MfacEmbarquesDetEntity)
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
