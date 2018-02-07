' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:31
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
	''' <summary>Entity class which represents the entity 'McgconfiguracionMovimientoGanado'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McgconfiguracionMovimientoGanadoEntity 
#Else
	<Serializable()> _
	Public Class McgconfiguracionMovimientoGanadoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"





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
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <param name="validator">The custom validator Object for this McgconfiguracionMovimientoGanadoEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)




			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()




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




				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName



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


			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McgconfiguracionMovimientoGanadoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McgconfiguracionMovimientoGanadoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McgconfiguracionMovimientoGanadoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McgconfiguracionMovimientoGanadoFieldIndex)





























					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()





		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McgconfiguracionMovimientoGanadoDAO = CType(CreateDAOInstance(), McgconfiguracionMovimientoGanadoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McgconfiguracionMovimientoGanadoDAO = CType(CreateDAOInstance(), McgconfiguracionMovimientoGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McgconfiguracionMovimientoGanadoDAO = CType(CreateDAOInstance(), McgconfiguracionMovimientoGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McgconfiguracionMovimientoGanadoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgconfiguracionMovimientoGanadoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <param name="validator">The validator Object for this McgconfiguracionMovimientoGanadoEntity</param>
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

			_fieldsCustomProperties.Add("EntradaXcompraGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaXcancelacionCompraGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaRecibaVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaRecibaMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaRecibaRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaRecibaEnfermeria", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRecibaCancelacionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRecibaCancelacionMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRecibaCancelacionRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRecibaCancelacionEnfermeria", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorralVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorralMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorralRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorralTraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralCancelacionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralCancelacionMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralCancelacionRastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralCancelacionTraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralTraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRastroXsalidaReciba", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorralXtransferenciaReciba", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaRecibaXtransferenciaAcorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorralXcancelacionTransferenciaRecibaAcorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaRecibaXcancelacionTransferenciaRecibaAcorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaXcancelacionSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaXcancelacionEntradaRastroXsalidaRecibaArastro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaXsacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaReinicioReciba", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for McgconfiguracionMovimientoGanado which data should be fetched into this McgconfiguracionMovimientoGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McgconfiguracionMovimientoGanadoFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcgconfiguracionMovimientoGanadoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McgconfiguracionMovimientoGanadoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McgconfiguracionMovimientoGanadoRelations
			Get	
				Return New McgconfiguracionMovimientoGanadoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McgconfiguracionMovimientoGanadoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McgconfiguracionMovimientoGanadoEntity.CustomProperties
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
				Return McgconfiguracionMovimientoGanadoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaXcompraGanado property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaXCompraGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaXcompraGanado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaXcompraGanado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaXcompraGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaXcancelacionCompraGanado property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaXCancelacionCompraGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaXcancelacionCompraGanado]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXcancelacionCompraGanado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXcancelacionCompraGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaRecibaVenta property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaRecibaVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaRecibaVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaRecibaMuerte property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaRecibaMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaRecibaMuerte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaMuerte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaRecibaRastro property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaRecibaRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaRecibaRastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaRastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaRecibaEnfermeria property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaRecibaEnfermeria"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaRecibaEnfermeria]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaEnfermeria, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaEnfermeria, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRecibaCancelacionVenta property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRecibaCancelacionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRecibaCancelacionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRecibaCancelacionMuerte property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRecibaCancelacionMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRecibaCancelacionMuerte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionMuerte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRecibaCancelacionRastro property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRecibaCancelacionRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRecibaCancelacionRastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionRastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRecibaCancelacionEnfermeria property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRecibaCancelacionEnfermeria"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRecibaCancelacionEnfermeria]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionEnfermeria, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaCancelacionEnfermeria, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorralVenta property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaCorralVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorralVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorralMuerte property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaCorralMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorralMuerte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralMuerte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorralRastro property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaCorralRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorralRastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralRastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorralTraspaso property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaCorralTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorralTraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralTraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralTraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralCancelacionVenta property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralCancelacionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralCancelacionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralCancelacionMuerte property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralCancelacionMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralCancelacionMuerte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionMuerte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralCancelacionRastro property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralCancelacionRastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralCancelacionRastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionRastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionRastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralCancelacionTraspaso property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralCancelacionTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralCancelacionTraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionTraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralCancelacionTraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralTraspaso property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralTraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralTraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralTraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRastroXsalidaReciba property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRastroXSalidaReciba"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRastroXsalidaReciba]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRastroXsalidaReciba, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRastroXsalidaReciba, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorralXtransferenciaReciba property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaCorralXTransferenciaReciba"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorralXtransferenciaReciba]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralXtransferenciaReciba, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaCorralXtransferenciaReciba, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaRecibaXtransferenciaAcorral property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaRecibaXTransferenciaACorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaRecibaXtransferenciaAcorral]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaXtransferenciaAcorral, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaRecibaXtransferenciaAcorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorralXcancelacionTransferenciaRecibaAcorral property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaCorralXCancelacionTransferenciaRecibaACorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorralXcancelacionTransferenciaRecibaAcorral]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralXcancelacionTransferenciaRecibaAcorral, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaCorralXcancelacionTransferenciaRecibaAcorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaRecibaXcancelacionTransferenciaRecibaAcorral property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaRecibaXCancelacionTransferenciaRecibaACorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaRecibaXcancelacionTransferenciaRecibaAcorral]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaXcancelacionTransferenciaRecibaAcorral, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaRecibaXcancelacionTransferenciaRecibaAcorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaXcancelacionSacrificio property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaXCancelacionSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaXcancelacionSacrificio]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaXcancelacionSacrificio, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaXcancelacionSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaXcancelacionEntradaRastroXsalidaRecibaArastro property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaXCancelacionEntradaRastroXSalidaRecibaARastro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaXcancelacionEntradaRastroXsalidaRecibaArastro]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXcancelacionEntradaRastroXsalidaRecibaArastro, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXcancelacionEntradaRastroXsalidaRecibaArastro, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaXsacrificio property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."SalidaXSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaXsacrificio]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXsacrificio, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.SalidaXsacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaReinicioReciba property of the Entity McgconfiguracionMovimientoGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGConfiguracionMovimientoGanado"."EntradaxReinicioReciba"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaReinicioReciba]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaReinicioReciba, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(McgconfiguracionMovimientoGanadoFieldIndex.EntradaReinicioReciba, Integer), value)
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
				Return CInt(Integralab.ORM.EntityType.McgconfiguracionMovimientoGanadoEntity)
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
