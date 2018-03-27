' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 26 de marzo de 2018 17:30:31
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
	''' <summary>Entity class which represents the entity 'ProveedorAvanzado'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ProveedorAvanzadoEntity 
#Else
	<Serializable()> _
	Public Class ProveedorAvanzadoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _banco As BancosEntity
		Private _alwaysFetchBanco, _alreadyFetchedBanco, _bancoReturnsNewIfNotFound As Boolean
		Private _tipoProveedor As TipoProveedorEntity
		Private _alwaysFetchTipoProveedor, _alreadyFetchedTipoProveedor, _tipoProveedorReturnsNewIfNotFound As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean

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
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="validator">The custom validator Object for this ProveedorAvanzadoEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_banco = CType(info.GetValue("_banco", GetType(BancosEntity)), BancosEntity)
			If Not _banco Is Nothing Then
				AddHandler _banco.AfterSave, AddressOf OnEntityAfterSave
			End If
			_bancoReturnsNewIfNotFound = info.GetBoolean("_bancoReturnsNewIfNotFound")
			_alwaysFetchBanco = info.GetBoolean("_alwaysFetchBanco")
			_alreadyFetchedBanco = info.GetBoolean("_alreadyFetchedBanco")
			_tipoProveedor = CType(info.GetValue("_tipoProveedor", GetType(TipoProveedorEntity)), TipoProveedorEntity)
			If Not _tipoProveedor Is Nothing Then
				AddHandler _tipoProveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoProveedorReturnsNewIfNotFound = info.GetBoolean("_tipoProveedorReturnsNewIfNotFound")
			_alwaysFetchTipoProveedor = info.GetBoolean("_alwaysFetchTipoProveedor")
			_alreadyFetchedTipoProveedor = info.GetBoolean("_alreadyFetchedTipoProveedor")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				' rewire event handler.
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedBanco = Not(_banco Is Nothing)
			_alreadyFetchedTipoProveedor = Not(_tipoProveedor Is Nothing)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)
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


			info.AddValue("_banco", _banco)
			info.AddValue("_bancoReturnsNewIfNotFound", _bancoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchBanco", _alwaysFetchBanco)
			info.AddValue("_alreadyFetchedBanco", _alreadyFetchedBanco)
			info.AddValue("_tipoProveedor", _tipoProveedor)
			info.AddValue("_tipoProveedorReturnsNewIfNotFound", _tipoProveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoProveedor", _alwaysFetchTipoProveedor)
			info.AddValue("_alreadyFetchedTipoProveedor", _alreadyFetchedTipoProveedor)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			
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
				Case "Banco"
					_alreadyFetchedBanco = True
					Me.Banco = CType(entity, BancosEntity)
				Case "TipoProveedor"
					_alreadyFetchedTipoProveedor = True
					Me.TipoProveedor = CType(entity, TipoProveedorEntity)


				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Banco"
					SetupSyncBanco(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoProveedor"
					SetupSyncTipoProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)

				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
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
				Case "Banco"
					DesetupSyncBanco(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoProveedor"
					DesetupSyncTipoProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)

				Case "Proveedor"
					DesetupSyncProveedor(False, True)
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
			If Not _banco Is Nothing Then
				toReturn.Add(_banco)
			End If
			If Not _tipoProveedor Is Nothing Then
				toReturn.Add(_tipoProveedor)
			End If

			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
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
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codigo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Codigo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ProveedorAvanzadoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ProveedorAvanzadoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBanco() As BancosEntity
			Return GetSingleBanco(False)
		End Function

		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBanco(forceFetch As Boolean) As BancosEntity
			If ( Not _alreadyFetchedBanco Or forceFetch Or _alwaysFetchBanco) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New BancosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProveedorAvanzadoEntity.Relations.BancosEntityUsingCodigoBanco) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoBanco.GetValueOrDefault())
				End If
				If Not _bancoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Banco = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), BancosEntity)
					End If
					Me.Banco = newEntity
					_alreadyFetchedBanco = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _banco
		End Function
	
		''' <summary>Retrieves the related entity of type 'TipoProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoProveedor() As TipoProveedorEntity
			Return GetSingleTipoProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoProveedor(forceFetch As Boolean) As TipoProveedorEntity
			If ( Not _alreadyFetchedTipoProveedor Or forceFetch Or _alwaysFetchTipoProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoTipoProveedor.GetValueOrDefault())
				End If
				If Not _tipoProveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoProveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoProveedorEntity)
					End If
					Me.TipoProveedor = newEntity
					_alreadyFetchedTipoProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoProveedor
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor() As ProveedorEntity
			Return GetSingleProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor(forceFetch As Boolean) As ProveedorEntity
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New ProveedorEntity()
				Dim relation As IEntityRelation = ProveedorAvanzadoEntity.Relations.ProveedorEntityUsingCodigo
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
				End If
				If Not _proveedorReturnsNewIfNotFound And Not fetchResult Then
					Me.Proveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorEntity)
					End If
					Me.Proveedor = newEntity
					_alreadyFetchedProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedor
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ProveedorAvanzadoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ProveedorAvanzadoFieldIndex)
					Case ProveedorAvanzadoFieldIndex.Codigo
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False


					Case ProveedorAvanzadoFieldIndex.CodigoTipoProveedor
						DesetupSyncTipoProveedor(True, False)
						_alreadyFetchedTipoProveedor = False








					Case ProveedorAvanzadoFieldIndex.CodigoBanco
						DesetupSyncBanco(True, False)
						_alreadyFetchedBanco = False









					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _banco Is Nothing Then
				_banco.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoProveedor Is Nothing Then
				_tipoProveedor.ActiveContext = MyBase.ActiveContext
			End If
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ProveedorAvanzadoDAO = CType(CreateDAOInstance(), ProveedorAvanzadoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ProveedorAvanzadoDAO = CType(CreateDAOInstance(), ProveedorAvanzadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ProveedorAvanzadoDAO = CType(CreateDAOInstance(), ProveedorAvanzadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ProveedorAvanzadoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ProveedorAvanzadoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="validator">The validator Object for this ProveedorAvanzadoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codigo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_banco = Nothing
			_bancoReturnsNewIfNotFound = True
			_alwaysFetchBanco = False
			_alreadyFetchedBanco = False
			_tipoProveedor = Nothing
			_tipoProveedorReturnsNewIfNotFound = True
			_alwaysFetchTipoProveedor = False
			_alreadyFetchedTipoProveedor = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Email", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Web", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoTipoProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiaRevision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiaPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono1", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono2", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fax", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PorcentajeDescuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ClaveBancaria", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoBanco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaTel1", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaTel2", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LadaFax", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrioridadPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PorcentajeFinanciero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AutoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrNoCuenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrClaveBancaria", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ClaveMonedas", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _banco</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncBanco(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _banco, AddressOf OnBancoPropertyChanged, "Banco", ProveedorAvanzadoEntity.Relations.BancosEntityUsingCodigoBanco, True, signalRelatedEntity, "ProveedorAvanzado", resetFKFields, New Integer() { CInt(ProveedorAvanzadoFieldIndex.CodigoBanco) } )
			_banco = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _banco</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncBanco(relatedEntity As IEntity)
			DesetupSyncBanco(True, True)
			_banco = CType(relatedEntity, BancosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _banco, AddressOf OnBancoPropertyChanged, "Banco", ProveedorAvanzadoEntity.Relations.BancosEntityUsingCodigoBanco, True, _alreadyFetchedBanco, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnBancoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _tipoProveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoProveedor, AddressOf OnTipoProveedorPropertyChanged, "TipoProveedor", ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor, True, signalRelatedEntity, "ProveedorAvanzado", resetFKFields, New Integer() { CInt(ProveedorAvanzadoFieldIndex.CodigoTipoProveedor) } )
			_tipoProveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoProveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoProveedor(relatedEntity As IEntity)
			DesetupSyncTipoProveedor(True, True)
			_tipoProveedor = CType(relatedEntity, TipoProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoProveedor, AddressOf OnTipoProveedorPropertyChanged, "TipoProveedor", ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor, True, _alreadyFetchedTipoProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", ProveedorAvanzadoEntity.Relations.ProveedorEntityUsingCodigo, True, signalRelatedEntity, "ProveedorAvanzado", False, New Integer() { CInt(ProveedorAvanzadoFieldIndex.Codigo) } )
			_proveedor = Nothing
		End Sub

		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", ProveedorAvanzadoEntity.Relations.ProveedorEntityUsingCodigo, True, _alreadyFetchedProveedor, New String() {  } )
		End Sub

		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for ProveedorAvanzado which data should be fetched into this ProveedorAvanzado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ProveedorAvanzadoFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateProveedorAvanzadoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ProveedorAvanzadoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ProveedorAvanzadoRelations
			Get	
				Return New ProveedorAvanzadoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBanco() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					ProveedorAvanzadoEntity.Relations.BancosEntityUsingCodigoBanco, _
					CType(Integralab.ORM.EntityType.ProveedorAvanzadoEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, Nothing, "Banco", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoProveedorCollection(), _
					ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor, _
					CType(Integralab.ORM.EntityType.ProveedorAvanzadoEntity, Integer), CType(Integralab.ORM.EntityType.TipoProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					ProveedorAvanzadoEntity.Relations.ProveedorEntityUsingCodigo, _
					CType(Integralab.ORM.EntityType.ProveedorAvanzadoEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ProveedorAvanzadoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ProveedorAvanzadoEntity.CustomProperties
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
				Return ProveedorAvanzadoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrIdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Email property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrEmail"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Email]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Email, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Email, Integer), value)
			End Set
		End Property
	
		''' <summary>The Web property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrWeb"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Web]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Web, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Web, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoTipoProveedor property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrIdTipoProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodigoTipoProveedor]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.CodigoTipoProveedor, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.CodigoTipoProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiaRevision property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrDiaRevision"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiaRevision]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.DiaRevision, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.DiaRevision, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiaPago property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrDiaPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiaPago]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.DiaPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.DiaPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono1 property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrTelefono1"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Telefono1]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Telefono1, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Telefono1, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono2 property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrTelefono2"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Telefono2]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Telefono2, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Telefono2, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fax property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrFax"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Fax]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.Fax, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.Fax, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrDiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The PorcentajeDescuento property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrPorcDescto"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PorcentajeDescuento]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.PorcentajeDescuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.PorcentajeDescuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The ClaveBancaria property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrClabe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 18<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ClaveBancaria]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.ClaveBancaria, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.ClaveBancaria, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoBanco property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrIdBanco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CodigoBanco]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.CodigoBanco, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.CodigoBanco, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaTel1 property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrLadaTel1"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaTel1]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaTel1, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaTel1, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaTel2 property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrLadaTel2"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaTel2]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaTel2, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaTel2, Integer), value)
			End Set
		End Property
	
		''' <summary>The LadaFax property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrLadaFax"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [LadaFax]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaFax, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.LadaFax, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrioridadPago property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrPrioridadPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrioridadPago]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.PrioridadPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.PrioridadPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The PorcentajeFinanciero property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PorcentajeFinanciero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PorcentajeFinanciero]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.PorcentajeFinanciero, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.PorcentajeFinanciero, Integer), value)
			End Set
		End Property
	
		''' <summary>The AutoFactura property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."AutoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [AutoFactura]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.AutoFactura, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.AutoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrNoCuenta property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrNoCuenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PrNoCuenta]() As Nullable(Of System.Int64)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.PrNoCuenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int64))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.PrNoCuenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrClaveBancaria property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."PrClaveBancaria"<br/>
		''' Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PrClaveBancaria]() As Nullable(Of System.Int64)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.PrClaveBancaria, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int64))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.PrClaveBancaria, Integer), value)
			End Set
		End Property
	
		''' <summary>The ClaveMonedas property of the Entity ProveedorAvanzado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatCompProveedoresAvanzados"."ClaveMonedas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ClaveMonedas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ProveedorAvanzadoFieldIndex.ClaveMonedas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ProveedorAvanzadoFieldIndex.ClaveMonedas, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'BancosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBanco()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Banco]() As BancosEntity
			Get
				Return GetSingleBanco(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncBanco(value)
				Else
					If value Is Nothing Then
						If Not _banco Is Nothing Then
							_banco.UnsetRelatedEntity(Me, "ProveedorAvanzado")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ProveedorAvanzado")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Banco. When set to true, Banco is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Banco is accessed. You can always execute
		''' a forced fetch by calling GetSingleBanco(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBanco As Boolean
			Get
				Return _alwaysFetchBanco
			End Get
			Set
				_alwaysFetchBanco = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Banco is not found
		''' in the database. When set to true, Banco will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property BancoReturnsNewIfNotFound As Boolean
			Get
				Return _bancoReturnsNewIfNotFound
			End Get
			Set
				_bancoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'TipoProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoProveedor]() As TipoProveedorEntity
			Get
				Return GetSingleTipoProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoProveedor(value)
				Else
					If value Is Nothing Then
						If Not _tipoProveedor Is Nothing Then
							_tipoProveedor.UnsetRelatedEntity(Me, "ProveedorAvanzado")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ProveedorAvanzado")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoProveedor. When set to true, TipoProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoProveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoProveedor As Boolean
			Get
				Return _alwaysFetchTipoProveedor
			End Get
			Set
				_alwaysFetchTipoProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoProveedor is not found
		''' in the database. When set to true, TipoProveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _tipoProveedorReturnsNewIfNotFound
			End Get
			Set
				_tipoProveedorReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'ProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Proveedor]() As ProveedorEntity
			Get
				Return GetSingleProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedor(value)
				Else
					If value Is Nothing Then
						DesetupSyncProveedor(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "ProveedorAvanzado")
						SetupSyncProveedor(relatedEntity)
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Proveedor is not found
		''' in the database. When set to true, Proveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorReturnsNewIfNotFound
			End Get
			Set
				_proveedorReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ProveedorAvanzadoEntity)
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
