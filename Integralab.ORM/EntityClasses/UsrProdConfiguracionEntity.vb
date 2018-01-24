' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:19
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
	''' <summary>Entity class which represents the entity 'UsrProdConfiguracion'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class UsrProdConfiguracionEntity 
#Else
	<Serializable()> _
	Public Class UsrProdConfiguracionEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _tipoAlmacen As TipoAlmacenEntity
		Private _alwaysFetchTipoAlmacen, _alreadyFetchedTipoAlmacen, _tipoAlmacenReturnsNewIfNotFound As Boolean


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
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		Public Sub New(idConfiguracion As System.Int32)

			InitClassFetch(idConfiguracion, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idConfiguracion, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="validator">The custom validator Object for this UsrProdConfiguracionEntity</param>
		Public Sub New(idConfiguracion As System.Int32, validator As IValidator)

			InitClassFetch(idConfiguracion, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_tipoAlmacen = CType(info.GetValue("_tipoAlmacen", GetType(TipoAlmacenEntity)), TipoAlmacenEntity)
			If Not _tipoAlmacen Is Nothing Then
				AddHandler _tipoAlmacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoAlmacenReturnsNewIfNotFound = info.GetBoolean("_tipoAlmacenReturnsNewIfNotFound")
			_alwaysFetchTipoAlmacen = info.GetBoolean("_alwaysFetchTipoAlmacen")
			_alreadyFetchedTipoAlmacen = info.GetBoolean("_alreadyFetchedTipoAlmacen")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedTipoAlmacen = Not(_tipoAlmacen Is Nothing)

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


			info.AddValue("_tipoAlmacen", _tipoAlmacen)
			info.AddValue("_tipoAlmacenReturnsNewIfNotFound", _tipoAlmacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoAlmacen", _alwaysFetchTipoAlmacen)
			info.AddValue("_alreadyFetchedTipoAlmacen", _alreadyFetchedTipoAlmacen)

			
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
				Case "TipoAlmacen"
					_alreadyFetchedTipoAlmacen = True
					Me.TipoAlmacen = CType(entity, TipoAlmacenEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "TipoAlmacen"
					SetupSyncTipoAlmacen(relatedEntity)
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
				Case "TipoAlmacen"
					DesetupSyncTipoAlmacen(False, True)
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
			If Not _tipoAlmacen Is Nothing Then
				toReturn.Add(_tipoAlmacen)
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
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idConfiguracion As System.Int32) As Boolean
			Return FetchUsingPK(idConfiguracion, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idConfiguracion, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idConfiguracion, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdConfiguracion, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As UsrProdConfiguracionFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As UsrProdConfiguracionFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'TipoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoAlmacen() As TipoAlmacenEntity
			Return GetSingleTipoAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoAlmacen(forceFetch As Boolean) As TipoAlmacenEntity
			If ( Not _alreadyFetchedTipoAlmacen Or forceFetch Or _alwaysFetchTipoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrProdConfiguracionEntity.Relations.TipoAlmacenEntityUsingIdTipoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdTipoAlmacen.GetValueOrDefault())
				End If
				If Not _tipoAlmacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoAlmacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoAlmacenEntity)
					End If
					Me.TipoAlmacen = newEntity
					_alreadyFetchedTipoAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoAlmacen
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(UsrProdConfiguracionFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, UsrProdConfiguracionFieldIndex)


















					Case UsrProdConfiguracionFieldIndex.IdTipoAlmacen
						DesetupSyncTipoAlmacen(True, False)
						_alreadyFetchedTipoAlmacen = False



















					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _tipoAlmacen Is Nothing Then
				_tipoAlmacen.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As UsrProdConfiguracionDAO = CType(CreateDAOInstance(), UsrProdConfiguracionDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As UsrProdConfiguracionDAO = CType(CreateDAOInstance(), UsrProdConfiguracionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As UsrProdConfiguracionDAO = CType(CreateDAOInstance(), UsrProdConfiguracionDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this UsrProdConfiguracionEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.UsrProdConfiguracionEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="validator">The validator Object for this UsrProdConfiguracionEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idConfiguracion As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idConfiguracion, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_tipoAlmacen = Nothing
			_tipoAlmacenReturnsNewIfNotFound = True
			_alwaysFetchTipoAlmacen = False
			_alreadyFetchedTipoAlmacen = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdConfiguracion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObtenerPeso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RecibirCanales", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Embarcarmasdeuncliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EmbarcarDiferentesProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirEtiquetasCortes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirEtiquetasCanales", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirEtiquetasProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LlenarCajasDiferentesProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirEtiquetaDiferentesProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TrabajarLoteSacrificiosAbiertos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TrabajarLoteCortesAbiertos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenCanales", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenCortes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenDecomisos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteCorteAsociadoaLotesSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ContraseñaEmb", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdTipoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TiempoEsperaSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObtenerCanalEntradaCanalAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IncluirPrecioEmbarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TemperaturaProdFresco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TemperaturaProdCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadProdFresco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadProdCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenCorteCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenValorAgregado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TemperaturaValorAgregado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadValorAgregado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenValorAgregadoCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TemperaturaValorAgregadoCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadValorAgregadoCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadHuesoFresco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCaducidadHuesoCongelado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ProductosDerivados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ReferenciarPrecioEmbarqueEnFacturacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsTiflogo", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _tipoAlmacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoAlmacen, AddressOf OnTipoAlmacenPropertyChanged, "TipoAlmacen", UsrProdConfiguracionEntity.Relations.TipoAlmacenEntityUsingIdTipoAlmacen, True, signalRelatedEntity, "UsrProdConfiguracion", resetFKFields, New Integer() { CInt(UsrProdConfiguracionFieldIndex.IdTipoAlmacen) } )
			_tipoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoAlmacen(relatedEntity As IEntity)
			DesetupSyncTipoAlmacen(True, True)
			_tipoAlmacen = CType(relatedEntity, TipoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoAlmacen, AddressOf OnTipoAlmacenPropertyChanged, "TipoAlmacen", UsrProdConfiguracionEntity.Relations.TipoAlmacenEntityUsingIdTipoAlmacen, True, _alreadyFetchedTipoAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idConfiguracion">PK value for UsrProdConfiguracion which data should be fetched into this UsrProdConfiguracion Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(UsrProdConfiguracionFieldIndex.IdConfiguracion)).ForcedCurrentValueWrite(idConfiguracion)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateUsrProdConfiguracionDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New UsrProdConfiguracionEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As UsrProdConfiguracionRelations
			Get	
				Return New UsrProdConfiguracionRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoAlmacenCollection(), _
					UsrProdConfiguracionEntity.Relations.TipoAlmacenEntityUsingIdTipoAlmacen, _
					CType(Integralab.ORM.EntityType.UsrProdConfiguracionEntity, Integer), CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "UsrProdConfiguracionEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return UsrProdConfiguracionEntity.CustomProperties
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
				Return UsrProdConfiguracionEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdConfiguracion property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdConfiguracion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdConfiguracion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdConfiguracion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdConfiguracion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObtenerPeso property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ObtenerPeso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObtenerPeso]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ObtenerPeso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ObtenerPeso, Integer), value)
			End Set
		End Property
	
		''' <summary>The RecibirCanales property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."RecibirCanales"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [RecibirCanales]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.RecibirCanales, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.RecibirCanales, Integer), value)
			End Set
		End Property
	
		''' <summary>The Embarcarmasdeuncliente property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."Embarcarmasdeuncliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Embarcarmasdeuncliente]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.Embarcarmasdeuncliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.Embarcarmasdeuncliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The EmbarcarDiferentesProductos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."EmbarcarDiferentesProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EmbarcarDiferentesProductos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.EmbarcarDiferentesProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.EmbarcarDiferentesProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirEtiquetasCortes property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ImprimirEtiquetasCortes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirEtiquetasCortes]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasCortes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasCortes, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirEtiquetasCanales property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ImprimirEtiquetasCanales"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirEtiquetasCanales]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasCanales, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasCanales, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirEtiquetasProductos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ImprimirEtiquetasProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirEtiquetasProductos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetasProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The LlenarCajasDiferentesProductos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."LlenarCajasDiferentesProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LlenarCajasDiferentesProductos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.LlenarCajasDiferentesProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.LlenarCajasDiferentesProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirEtiquetaDiferentesProductos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ImprimirEtiquetaDiferentesProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirEtiquetaDiferentesProductos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetaDiferentesProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ImprimirEtiquetaDiferentesProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The TrabajarLoteSacrificiosAbiertos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TrabajarLoteSacrificiosAbiertos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TrabajarLoteSacrificiosAbiertos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TrabajarLoteSacrificiosAbiertos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TrabajarLoteSacrificiosAbiertos, Integer), value)
			End Set
		End Property
	
		''' <summary>The TrabajarLoteCortesAbiertos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TrabajarLoteCortesAbiertos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TrabajarLoteCortesAbiertos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TrabajarLoteCortesAbiertos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TrabajarLoteCortesAbiertos, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenCanales property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenCanales"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenCanales]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCanales, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCanales, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenCortes property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenCortes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenCortes]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCortes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCortes, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenProductos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenProductos]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenDecomisos property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenDecomisos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenDecomisos]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenDecomisos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenDecomisos, Integer), value)
			End Set
		End Property
	
		''' <summary>The LoteCorteAsociadoaLotesSacrificio property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."LoteCorteAsociadoaLotesSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LoteCorteAsociadoaLotesSacrificio]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.LoteCorteAsociadoaLotesSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.LoteCorteAsociadoaLotesSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The ContraseñaEmb property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ContraseñaEmb"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ContraseñaEmb]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ContraseñaEmb, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ContraseñaEmb, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdTipoAlmacen property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdTipoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdTipoAlmacen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdTipoAlmacen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdTipoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The TiempoEsperaSacrificio property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TiempoEsperaSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TiempoEsperaSacrificio]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TiempoEsperaSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TiempoEsperaSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObtenerCanalEntradaCanalAlmacen property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ObtenerCanalEntradaCanalAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObtenerCanalEntradaCanalAlmacen]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ObtenerCanalEntradaCanalAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ObtenerCanalEntradaCanalAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The IncluirPrecioEmbarque property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IncluirPrecioEmbarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IncluirPrecioEmbarque]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IncluirPrecioEmbarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IncluirPrecioEmbarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The TemperaturaProdFresco property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TemperaturaProdFresco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TemperaturaProdFresco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaProdFresco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaProdFresco, Integer), value)
			End Set
		End Property
	
		''' <summary>The TemperaturaProdCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TemperaturaProdCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TemperaturaProdCongelado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaProdCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaProdCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadProdFresco property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadProdFresco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadProdFresco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadProdFresco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadProdFresco, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadProdCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadProdCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadProdCongelado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadProdCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadProdCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenCorteCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenCorteCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenCorteCongelado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCorteCongelado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenCorteCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenValorAgregado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenValorAgregado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenValorAgregado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenValorAgregado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenValorAgregado, Integer), value)
			End Set
		End Property
	
		''' <summary>The TemperaturaValorAgregado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TemperaturaValorAgregado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TemperaturaValorAgregado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaValorAgregado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaValorAgregado, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadValorAgregado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadValorAgregado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadValorAgregado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadValorAgregado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadValorAgregado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenValorAgregadoCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."IdAlmacenValorAgregadoCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenValorAgregadoCongelado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenValorAgregadoCongelado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.IdAlmacenValorAgregadoCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The TemperaturaValorAgregadoCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."TemperaturaValorAgregadoCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TemperaturaValorAgregadoCongelado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaValorAgregadoCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.TemperaturaValorAgregadoCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadValorAgregadoCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadValorAgregadoCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadValorAgregadoCongelado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadValorAgregadoCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadValorAgregadoCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadHuesoFresco property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadHuesoFresco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadHuesoFresco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadHuesoFresco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadHuesoFresco, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCaducidadHuesoCongelado property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."DiasCaducidadHuesoCongelado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCaducidadHuesoCongelado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadHuesoCongelado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.DiasCaducidadHuesoCongelado, Integer), value)
			End Set
		End Property
	
		''' <summary>The ProductosDerivados property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ProductosDerivados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ProductosDerivados]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ProductosDerivados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ProductosDerivados, Integer), value)
			End Set
		End Property
	
		''' <summary>The ReferenciarPrecioEmbarqueEnFacturacion property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."ReferenciarPrecioEmbarqueEnFacturacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ReferenciarPrecioEmbarqueEnFacturacion]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.ReferenciarPrecioEmbarqueEnFacturacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.ReferenciarPrecioEmbarqueEnFacturacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsTiflogo property of the Entity UsrProdConfiguracion<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrProdConfiguracion"."EsTIFLogo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsTiflogo]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrProdConfiguracionFieldIndex.EsTiflogo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(UsrProdConfiguracionFieldIndex.EsTiflogo, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'TipoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoAlmacen]() As TipoAlmacenEntity
			Get
				Return GetSingleTipoAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _tipoAlmacen Is Nothing Then
							_tipoAlmacen.UnsetRelatedEntity(Me, "UsrProdConfiguracion")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrProdConfiguracion")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoAlmacen. When set to true, TipoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoAlmacen As Boolean
			Get
				Return _alwaysFetchTipoAlmacen
			End Get
			Set
				_alwaysFetchTipoAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoAlmacen is not found
		''' in the database. When set to true, TipoAlmacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoAlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _tipoAlmacenReturnsNewIfNotFound
			End Get
			Set
				_tipoAlmacenReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.UsrProdConfiguracionEntity)
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
