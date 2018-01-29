' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 10:43:41
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
	''' <summary>Entity class which represents the entity 'Cheque'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ChequeEntity 
#Else
	<Serializable()> _
	Public Class ChequeEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _beneficiario As BeneficiarioEntity
		Private _alwaysFetchBeneficiario, _alreadyFetchedBeneficiario, _beneficiarioReturnsNewIfNotFound As Boolean
		Private _cuenta As CuentaEntity
		Private _alwaysFetchCuenta, _alreadyFetchedCuenta, _cuentaReturnsNewIfNotFound As Boolean
		Private _cuentaDestino As CuentaEntity
		Private _alwaysFetchCuentaDestino, _alreadyFetchedCuentaDestino, _cuentaDestinoReturnsNewIfNotFound As Boolean
		Private _poliza As PolizaEntity
		Private _alwaysFetchPoliza, _alreadyFetchedPoliza, _polizaReturnsNewIfNotFound As Boolean
		Private _poliza_ As PolizaEntity
		Private _alwaysFetchPoliza_, _alreadyFetchedPoliza_, _poliza_ReturnsNewIfNotFound As Boolean


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
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		Public Sub New(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32)

			InitClassFetch(cuentaId, folio, medio, codBanco, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(cuentaId, folio, medio, codBanco, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="validator">The custom validator Object for this ChequeEntity</param>
		Public Sub New(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, validator As IValidator)

			InitClassFetch(cuentaId, folio, medio, codBanco, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_beneficiario = CType(info.GetValue("_beneficiario", GetType(BeneficiarioEntity)), BeneficiarioEntity)
			If Not _beneficiario Is Nothing Then
				AddHandler _beneficiario.AfterSave, AddressOf OnEntityAfterSave
			End If
			_beneficiarioReturnsNewIfNotFound = info.GetBoolean("_beneficiarioReturnsNewIfNotFound")
			_alwaysFetchBeneficiario = info.GetBoolean("_alwaysFetchBeneficiario")
			_alreadyFetchedBeneficiario = info.GetBoolean("_alreadyFetchedBeneficiario")
			_cuenta = CType(info.GetValue("_cuenta", GetType(CuentaEntity)), CuentaEntity)
			If Not _cuenta Is Nothing Then
				AddHandler _cuenta.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaReturnsNewIfNotFound = info.GetBoolean("_cuentaReturnsNewIfNotFound")
			_alwaysFetchCuenta = info.GetBoolean("_alwaysFetchCuenta")
			_alreadyFetchedCuenta = info.GetBoolean("_alreadyFetchedCuenta")
			_cuentaDestino = CType(info.GetValue("_cuentaDestino", GetType(CuentaEntity)), CuentaEntity)
			If Not _cuentaDestino Is Nothing Then
				AddHandler _cuentaDestino.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaDestinoReturnsNewIfNotFound = info.GetBoolean("_cuentaDestinoReturnsNewIfNotFound")
			_alwaysFetchCuentaDestino = info.GetBoolean("_alwaysFetchCuentaDestino")
			_alreadyFetchedCuentaDestino = info.GetBoolean("_alreadyFetchedCuentaDestino")
			_poliza = CType(info.GetValue("_poliza", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza Is Nothing Then
				AddHandler _poliza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_polizaReturnsNewIfNotFound = info.GetBoolean("_polizaReturnsNewIfNotFound")
			_alwaysFetchPoliza = info.GetBoolean("_alwaysFetchPoliza")
			_alreadyFetchedPoliza = info.GetBoolean("_alreadyFetchedPoliza")
			_poliza_ = CType(info.GetValue("_poliza_", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza_ Is Nothing Then
				AddHandler _poliza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_poliza_ReturnsNewIfNotFound = info.GetBoolean("_poliza_ReturnsNewIfNotFound")
			_alwaysFetchPoliza_ = info.GetBoolean("_alwaysFetchPoliza_")
			_alreadyFetchedPoliza_ = info.GetBoolean("_alreadyFetchedPoliza_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedBeneficiario = Not(_beneficiario Is Nothing)
			_alreadyFetchedCuenta = Not(_cuenta Is Nothing)
			_alreadyFetchedCuentaDestino = Not(_cuentaDestino Is Nothing)
			_alreadyFetchedPoliza = Not(_poliza Is Nothing)
			_alreadyFetchedPoliza_ = Not(_poliza_ Is Nothing)

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


			info.AddValue("_beneficiario", _beneficiario)
			info.AddValue("_beneficiarioReturnsNewIfNotFound", _beneficiarioReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchBeneficiario", _alwaysFetchBeneficiario)
			info.AddValue("_alreadyFetchedBeneficiario", _alreadyFetchedBeneficiario)
			info.AddValue("_cuenta", _cuenta)
			info.AddValue("_cuentaReturnsNewIfNotFound", _cuentaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuenta", _alwaysFetchCuenta)
			info.AddValue("_alreadyFetchedCuenta", _alreadyFetchedCuenta)
			info.AddValue("_cuentaDestino", _cuentaDestino)
			info.AddValue("_cuentaDestinoReturnsNewIfNotFound", _cuentaDestinoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaDestino", _alwaysFetchCuentaDestino)
			info.AddValue("_alreadyFetchedCuentaDestino", _alreadyFetchedCuentaDestino)
			info.AddValue("_poliza", _poliza)
			info.AddValue("_polizaReturnsNewIfNotFound", _polizaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza", _alwaysFetchPoliza)
			info.AddValue("_alreadyFetchedPoliza", _alreadyFetchedPoliza)
			info.AddValue("_poliza_", _poliza_)
			info.AddValue("_poliza_ReturnsNewIfNotFound", _poliza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza_", _alwaysFetchPoliza_)
			info.AddValue("_alreadyFetchedPoliza_", _alreadyFetchedPoliza_)

			
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
				Case "Beneficiario"
					_alreadyFetchedBeneficiario = True
					Me.Beneficiario = CType(entity, BeneficiarioEntity)
				Case "Cuenta"
					_alreadyFetchedCuenta = True
					Me.Cuenta = CType(entity, CuentaEntity)
				Case "CuentaDestino"
					_alreadyFetchedCuentaDestino = True
					Me.CuentaDestino = CType(entity, CuentaEntity)
				Case "Poliza"
					_alreadyFetchedPoliza = True
					Me.Poliza = CType(entity, PolizaEntity)
				Case "Poliza_"
					_alreadyFetchedPoliza_ = True
					Me.Poliza_ = CType(entity, PolizaEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Beneficiario"
					SetupSyncBeneficiario(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Cuenta"
					SetupSyncCuenta(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaDestino"
					SetupSyncCuentaDestino(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza"
					SetupSyncPoliza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza_"
					SetupSyncPoliza_(relatedEntity)
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
				Case "Beneficiario"
					DesetupSyncBeneficiario(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Cuenta"
					DesetupSyncCuenta(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaDestino"
					DesetupSyncCuentaDestino(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza"
					DesetupSyncPoliza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza_"
					DesetupSyncPoliza_(False, True)
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
			If Not _beneficiario Is Nothing Then
				toReturn.Add(_beneficiario)
			End If
			If Not _cuenta Is Nothing Then
				toReturn.Add(_cuenta)
			End If
			If Not _cuentaDestino Is Nothing Then
				toReturn.Add(_cuentaDestino)
			End If
			If Not _poliza Is Nothing Then
				toReturn.Add(_poliza)
			End If
			If Not _poliza_ Is Nothing Then
				toReturn.Add(_poliza_)
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
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32) As Boolean
			Return FetchUsingPK(cuentaId, folio, medio, codBanco, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(cuentaId, folio, medio, codBanco, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(cuentaId, folio, medio, codBanco, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CuentaId, Me.Folio, Me.Medio, Me.CodBanco, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ChequeFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ChequeFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'BeneficiarioEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'BeneficiarioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBeneficiario() As BeneficiarioEntity
			Return GetSingleBeneficiario(False)
		End Function

		''' <summary>Retrieves the related entity of type 'BeneficiarioEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'BeneficiarioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBeneficiario(forceFetch As Boolean) As BeneficiarioEntity
			If ( Not _alreadyFetchedBeneficiario Or forceFetch Or _alwaysFetchBeneficiario) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New BeneficiarioEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId) Then
					fetchResult = newEntity.FetchUsingPK(Me.BeneficiarioId.GetValueOrDefault())
				End If
				If Not _beneficiarioReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Beneficiario = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), BeneficiarioEntity)
					End If
					Me.Beneficiario = newEntity
					_alreadyFetchedBeneficiario = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _beneficiario
		End Function
	
		''' <summary>Retrieves the related entity of type 'CuentaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuenta() As CuentaEntity
			Return GetSingleCuenta(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuenta(forceFetch As Boolean) As CuentaEntity
			If ( Not _alreadyFetchedCuenta Or forceFetch Or _alwaysFetchCuenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeEntity.Relations.CuentaEntityUsingCuentaId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentaId)
				End If
				If Not _cuentaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Cuenta = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaEntity)
					End If
					Me.Cuenta = newEntity
					_alreadyFetchedCuenta = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuenta
		End Function
	
		''' <summary>Retrieves the related entity of type 'CuentaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaDestino() As CuentaEntity
			Return GetSingleCuentaDestino(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaDestino(forceFetch As Boolean) As CuentaEntity
			If ( Not _alreadyFetchedCuentaDestino Or forceFetch Or _alwaysFetchCuentaDestino) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentaDestinoId.GetValueOrDefault())
				End If
				If Not _cuentaDestinoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaDestino = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaEntity)
					End If
					Me.CuentaDestino = newEntity
					_alreadyFetchedCuentaDestino = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaDestino
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza() As PolizaEntity
			Return GetSinglePoliza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza Or forceFetch Or _alwaysFetchPoliza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeEntity.Relations.PolizaEntityUsingPolizaId) Then
					fetchResult = newEntity.FetchUsingPK(Me.PolizaId)
				End If
				If Not _polizaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza = newEntity
					_alreadyFetchedPoliza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_() As PolizaEntity
			Return GetSinglePoliza_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza_ Or forceFetch Or _alwaysFetchPoliza_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.PolizaIdCancelacion.GetValueOrDefault())
				End If
				If Not _poliza_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza_ = newEntity
					_alreadyFetchedPoliza_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza_
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ChequeFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ChequeFieldIndex)
					Case ChequeFieldIndex.CuentaId
						DesetupSyncCuenta(True, False)
						_alreadyFetchedCuenta = False


					Case ChequeFieldIndex.BeneficiarioId
						DesetupSyncBeneficiario(True, False)
						_alreadyFetchedBeneficiario = False
					Case ChequeFieldIndex.PolizaId
						DesetupSyncPoliza(True, False)
						_alreadyFetchedPoliza = False
					Case ChequeFieldIndex.CuentaDestinoId
						DesetupSyncCuentaDestino(True, False)
						_alreadyFetchedCuentaDestino = False














					Case ChequeFieldIndex.PolizaIdCancelacion
						DesetupSyncPoliza_(True, False)
						_alreadyFetchedPoliza_ = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _beneficiario Is Nothing Then
				_beneficiario.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuenta Is Nothing Then
				_cuenta.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaDestino Is Nothing Then
				_cuentaDestino.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza Is Nothing Then
				_poliza.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza_ Is Nothing Then
				_poliza_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ChequeDAO = CType(CreateDAOInstance(), ChequeDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ChequeDAO = CType(CreateDAOInstance(), ChequeDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ChequeDAO = CType(CreateDAOInstance(), ChequeDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ChequeEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ChequeEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="validator">The validator Object for this ChequeEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(cuentaId, folio, medio, codBanco, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_beneficiario = Nothing
			_beneficiarioReturnsNewIfNotFound = True
			_alwaysFetchBeneficiario = False
			_alreadyFetchedBeneficiario = False
			_cuenta = Nothing
			_cuentaReturnsNewIfNotFound = True
			_alwaysFetchCuenta = False
			_alreadyFetchedCuenta = False
			_cuentaDestino = Nothing
			_cuentaDestinoReturnsNewIfNotFound = True
			_alwaysFetchCuentaDestino = False
			_alreadyFetchedCuentaDestino = False
			_poliza = Nothing
			_polizaReturnsNewIfNotFound = True
			_alwaysFetchPoliza = False
			_alreadyFetchedPoliza = False
			_poliza_ = Nothing
			_poliza_ReturnsNewIfNotFound = True
			_alwaysFetchPoliza_ = False
			_alreadyFetchedPoliza_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Medio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BeneficiarioId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PolizaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaDestinoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaDocumento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaEmision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Concepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Emitido", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Anticipo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Resguardo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PeriodoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PolizaIdCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Entregado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaEntrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodBanco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaDestinoReceptor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodBancoDestino", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _beneficiario</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncBeneficiario(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _beneficiario, AddressOf OnBeneficiarioPropertyChanged, "Beneficiario", ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, True, signalRelatedEntity, "Cheque", resetFKFields, New Integer() { CInt(ChequeFieldIndex.BeneficiarioId) } )
			_beneficiario = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _beneficiario</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncBeneficiario(relatedEntity As IEntity)
			DesetupSyncBeneficiario(True, True)
			_beneficiario = CType(relatedEntity, BeneficiarioEntity)
			MyBase.PerformSetupSyncRelatedEntity( _beneficiario, AddressOf OnBeneficiarioPropertyChanged, "Beneficiario", ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, True, _alreadyFetchedBeneficiario, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnBeneficiarioPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuenta</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuenta(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuenta, AddressOf OnCuentaPropertyChanged, "Cuenta", ChequeEntity.Relations.CuentaEntityUsingCuentaId, True, signalRelatedEntity, "Cheque", resetFKFields, New Integer() { CInt(ChequeFieldIndex.CuentaId) } )
			_cuenta = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuenta</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuenta(relatedEntity As IEntity)
			DesetupSyncCuenta(True, True)
			_cuenta = CType(relatedEntity, CuentaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuenta, AddressOf OnCuentaPropertyChanged, "Cuenta", ChequeEntity.Relations.CuentaEntityUsingCuentaId, True, _alreadyFetchedCuenta, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaDestino</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaDestino(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaDestino, AddressOf OnCuentaDestinoPropertyChanged, "CuentaDestino", ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, True, signalRelatedEntity, "Cheque_", resetFKFields, New Integer() { CInt(ChequeFieldIndex.CuentaDestinoId) } )
			_cuentaDestino = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaDestino</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaDestino(relatedEntity As IEntity)
			DesetupSyncCuentaDestino(True, True)
			_cuentaDestino = CType(relatedEntity, CuentaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaDestino, AddressOf OnCuentaDestinoPropertyChanged, "CuentaDestino", ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, True, _alreadyFetchedCuentaDestino, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaDestinoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", ChequeEntity.Relations.PolizaEntityUsingPolizaId, True, signalRelatedEntity, "Cheque", resetFKFields, New Integer() { CInt(ChequeFieldIndex.PolizaId) } )
			_poliza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza(relatedEntity As IEntity)
			DesetupSyncPoliza(True, True)
			_poliza = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", ChequeEntity.Relations.PolizaEntityUsingPolizaId, True, _alreadyFetchedPoliza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPolizaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, True, signalRelatedEntity, "Cheque_", resetFKFields, New Integer() { CInt(ChequeFieldIndex.PolizaIdCancelacion) } )
			_poliza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza_(relatedEntity As IEntity)
			DesetupSyncPoliza_(True, True)
			_poliza_ = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, True, _alreadyFetchedPoliza_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPoliza_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="cuentaId">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="folio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="medio">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="codBanco">PK value for Cheque which data should be fetched into this Cheque Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(cuentaId As System.Int32, folio As System.String, medio As System.String, codBanco As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ChequeFieldIndex.CuentaId)).ForcedCurrentValueWrite(cuentaId)
				MyBase.Fields(CInt(ChequeFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				MyBase.Fields(CInt(ChequeFieldIndex.Medio)).ForcedCurrentValueWrite(medio)
				MyBase.Fields(CInt(ChequeFieldIndex.CodBanco)).ForcedCurrentValueWrite(codBanco)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateChequeDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ChequeEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ChequeRelations
			Get	
				Return New ChequeRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Beneficiario' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBeneficiario() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BeneficiarioCollection(), _
					ChequeEntity.Relations.BeneficiarioEntityUsingBeneficiarioId, _
					CType(Integralab.ORM.EntityType.ChequeEntity, Integer), CType(Integralab.ORM.EntityType.BeneficiarioEntity, Integer), 0, Nothing, Nothing, Nothing, "Beneficiario", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					ChequeEntity.Relations.CuentaEntityUsingCuentaId, _
					CType(Integralab.ORM.EntityType.ChequeEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "Cuenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Cuenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaDestino() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaCollection(), _
					ChequeEntity.Relations.CuentaEntityUsingCuentaDestinoId, _
					CType(Integralab.ORM.EntityType.ChequeEntity, Integer), CType(Integralab.ORM.EntityType.CuentaEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaDestino", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					ChequeEntity.Relations.PolizaEntityUsingPolizaId, _
					CType(Integralab.ORM.EntityType.ChequeEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					ChequeEntity.Relations.PolizaEntityUsingPolizaIdCancelacion, _
					CType(Integralab.ORM.EntityType.ChequeEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ChequeEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ChequeEntity.CustomProperties
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
				Return ChequeEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CuentaId property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."CuentaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CuentaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.CuentaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.CuentaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Folio property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Medio property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Medio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Medio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Medio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Medio, Integer), value)
			End Set
		End Property
	
		''' <summary>The BeneficiarioId property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."BeneficiarioId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [BeneficiarioId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.BeneficiarioId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.BeneficiarioId, Integer), value)
			End Set
		End Property
	
		''' <summary>The PolizaId property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."PolizaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PolizaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.PolizaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.PolizaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaDestinoId property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."CuentaDestinoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CuentaDestinoId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.CuentaDestinoId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.CuentaDestinoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Origen property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Origen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Origen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Origen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Origen, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoMovimiento property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."TipoMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.TipoMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.TipoMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.FechaMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaDocumento property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."FechaDocumento"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaDocumento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.FechaDocumento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.FechaDocumento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaEmision property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."FechaEmision"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaEmision]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.FechaEmision, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.FechaEmision, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Concepto property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Concepto"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Concepto]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Concepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Concepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Emitido property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Emitido"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Emitido]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Emitido, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Emitido, Integer), value)
			End Set
		End Property
	
		''' <summary>The Anticipo property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Anticipo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Anticipo]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Anticipo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Anticipo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Resguardo property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Resguardo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Resguardo]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Resguardo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Resguardo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCambio property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."TipoCambio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCambio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.TipoCambio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.TipoCambio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The PeriodoId property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."PeriodoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PeriodoId]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.PeriodoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.PeriodoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The PolizaIdCancelacion property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."PolizaIdCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PolizaIdCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.PolizaIdCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.PolizaIdCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Entregado property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Entregado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Entregado]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Entregado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Entregado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaEntrega property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."FechaEntrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaEntrega]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.FechaEntrega, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.FechaEntrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.Referencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodBanco property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."CodBanco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CodBanco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.CodBanco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.CodBanco, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaDestinoReceptor property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."CuentaDestinoReceptor"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CuentaDestinoReceptor]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.CuentaDestinoReceptor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.CuentaDestinoReceptor, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodBancoDestino property of the Entity Cheque<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrBanCheques"."CodBancoDestino"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodBancoDestino]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeFieldIndex.CodBancoDestino, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ChequeFieldIndex.CodBancoDestino, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'BeneficiarioEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBeneficiario()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Beneficiario]() As BeneficiarioEntity
			Get
				Return GetSingleBeneficiario(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncBeneficiario(value)
				Else
					If value Is Nothing Then
						If Not _beneficiario Is Nothing Then
							_beneficiario.UnsetRelatedEntity(Me, "Cheque")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cheque")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Beneficiario. When set to true, Beneficiario is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Beneficiario is accessed. You can always execute
		''' a forced fetch by calling GetSingleBeneficiario(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBeneficiario As Boolean
			Get
				Return _alwaysFetchBeneficiario
			End Get
			Set
				_alwaysFetchBeneficiario = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Beneficiario is not found
		''' in the database. When set to true, Beneficiario will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property BeneficiarioReturnsNewIfNotFound As Boolean
			Get
				Return _beneficiarioReturnsNewIfNotFound
			End Get
			Set
				_beneficiarioReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CuentaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Cuenta]() As CuentaEntity
			Get
				Return GetSingleCuenta(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuenta(value)
				Else
					If value Is Nothing Then
						If Not _cuenta Is Nothing Then
							_cuenta.UnsetRelatedEntity(Me, "Cheque")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cheque")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Cuenta. When set to true, Cuenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Cuenta is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuenta As Boolean
			Get
				Return _alwaysFetchCuenta
			End Get
			Set
				_alwaysFetchCuenta = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Cuenta is not found
		''' in the database. When set to true, Cuenta will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaReturnsNewIfNotFound
			End Get
			Set
				_cuentaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CuentaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaDestino()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaDestino]() As CuentaEntity
			Get
				Return GetSingleCuentaDestino(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaDestino(value)
				Else
					If value Is Nothing Then
						If Not _cuentaDestino Is Nothing Then
							_cuentaDestino.UnsetRelatedEntity(Me, "Cheque_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cheque_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaDestino. When set to true, CuentaDestino is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaDestino is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaDestino(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaDestino As Boolean
			Get
				Return _alwaysFetchCuentaDestino
			End Get
			Set
				_alwaysFetchCuentaDestino = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaDestino is not found
		''' in the database. When set to true, CuentaDestino will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaDestinoReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaDestinoReturnsNewIfNotFound
			End Get
			Set
				_cuentaDestinoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza]() As PolizaEntity
			Get
				Return GetSinglePoliza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza(value)
				Else
					If value Is Nothing Then
						If Not _poliza Is Nothing Then
							_poliza.UnsetRelatedEntity(Me, "Cheque")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cheque")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza. When set to true, Poliza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza As Boolean
			Get
				Return _alwaysFetchPoliza
			End Get
			Set
				_alwaysFetchPoliza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza is not found
		''' in the database. When set to true, Poliza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PolizaReturnsNewIfNotFound As Boolean
			Get
				Return _polizaReturnsNewIfNotFound
			End Get
			Set
				_polizaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza_]() As PolizaEntity
			Get
				Return GetSinglePoliza_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza_(value)
				Else
					If value Is Nothing Then
						If Not _poliza_ Is Nothing Then
							_poliza_.UnsetRelatedEntity(Me, "Cheque_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cheque_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza_. When set to true, Poliza_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza_ is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza_ As Boolean
			Get
				Return _alwaysFetchPoliza_
			End Get
			Set
				_alwaysFetchPoliza_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza_ is not found
		''' in the database. When set to true, Poliza_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Poliza_ReturnsNewIfNotFound As Boolean
			Get
				Return _poliza_ReturnsNewIfNotFound
			End Get
			Set
				_poliza_ReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ChequeEntity)
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
