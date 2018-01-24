' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:20
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
	''' <summary>Entity class which represents the entity 'NomImssinfonavit'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class NomImssinfonavitEntity 
#Else
	<Serializable()> _
	Public Class NomImssinfonavitEntity 
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
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <param name="validator">The custom validator Object for this NomImssinfonavitEntity</param>
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
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As NomImssinfonavitFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As NomImssinfonavitFieldIndex) As Boolean
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(NomImssinfonavitFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, NomImssinfonavitFieldIndex)





































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
			Dim dao As NomImssinfonavitDAO = CType(CreateDAOInstance(), NomImssinfonavitDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As NomImssinfonavitDAO = CType(CreateDAOInstance(), NomImssinfonavitDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As NomImssinfonavitDAO = CType(CreateDAOInstance(), NomImssinfonavitDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this NomImssinfonavitEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.NomImssinfonavitEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <param name="validator">The validator Object for this NomImssinfonavitEntity</param>
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

			_fieldsCustomProperties.Add("EnfyMatEnEspecieCuotaFijaObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatEnEspecieCuotaFijaPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatEnEspecieExcedenteObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatEnEspecieExcedentePatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatEnDineroObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatEnDineroPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatGastosMedicosObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnfyMatGastosMedicosPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("InvalidezyVidaObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("InvalidezyVidaPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Guarderias", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Retiro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RetCesantiayVejezObrero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RetCesantiayVejezPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Infonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Riesgotrabajo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcuotaFija", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculocuotaFija", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarexcedente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoexcedente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarendinero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoendinero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrargastosMedicos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculogastosMedicos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarinvalidezyvida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoinvalidezyvida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarguarderias", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoguarderias", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarretiro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoretiro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcesantiayvejez", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculocesantiayvejez", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarinfonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoinfonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarriesgodeTrabajo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopeVssmdfintegrarcalculoriesgodeTrabajo", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for NomImssinfonavit which data should be fetched into this NomImssinfonavit Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(NomImssinfonavitFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateNomImssinfonavitDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New NomImssinfonavitEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As NomImssinfonavitRelations
			Get	
				Return New NomImssinfonavitRelations() 
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
				Return "NomImssinfonavitEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return NomImssinfonavitEntity.CustomProperties
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
				Return NomImssinfonavitEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnEspecieCuotaFijaObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnEspecieCuotaFijaObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnEspecieCuotaFijaObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieCuotaFijaObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieCuotaFijaObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnEspecieCuotaFijaPatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnEspecieCuotaFijaPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnEspecieCuotaFijaPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieCuotaFijaPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieCuotaFijaPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnEspecieExcedenteObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnEspecieExcedenteObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnEspecieExcedenteObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieExcedenteObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieExcedenteObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnEspecieExcedentePatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnEspecieExcedentePatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnEspecieExcedentePatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieExcedentePatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnEspecieExcedentePatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnDineroObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnDineroObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnDineroObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnDineroObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnDineroObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatEnDineroPatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatEnDineroPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatEnDineroPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnDineroPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatEnDineroPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatGastosMedicosObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatGastosMedicosObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatGastosMedicosObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatGastosMedicosObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatGastosMedicosObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnfyMatGastosMedicosPatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."EnfyMatGastosMedicosPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnfyMatGastosMedicosPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatGastosMedicosPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.EnfyMatGastosMedicosPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The InvalidezyVidaObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."InvalidezyVidaObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [InvalidezyVidaObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.InvalidezyVidaObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.InvalidezyVidaObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The InvalidezyVidaPatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."InvalidezyVidaPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [InvalidezyVidaPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.InvalidezyVidaPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.InvalidezyVidaPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Guarderias property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."Guarderias"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Guarderias]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.Guarderias, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.Guarderias, Integer), value)
			End Set
		End Property
	
		''' <summary>The Retiro property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."Retiro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Retiro]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.Retiro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.Retiro, Integer), value)
			End Set
		End Property
	
		''' <summary>The RetCesantiayVejezObrero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."RetCesantiayVejezObrero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [RetCesantiayVejezObrero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.RetCesantiayVejezObrero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.RetCesantiayVejezObrero, Integer), value)
			End Set
		End Property
	
		''' <summary>The RetCesantiayVejezPatronal property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."RetCesantiayVejezPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [RetCesantiayVejezPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.RetCesantiayVejezPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.RetCesantiayVejezPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Infonavit property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."INFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Infonavit]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.Infonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.Infonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The Riesgotrabajo property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."RIESGOTRABAJO"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Riesgotrabajo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.Riesgotrabajo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.Riesgotrabajo, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcuotaFija property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCuotaFija"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcuotaFija]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcuotaFija, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcuotaFija, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculocuotaFija property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOCuotaFija"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculocuotaFija]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculocuotaFija, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculocuotaFija, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarexcedente property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARExcedente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarexcedente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarexcedente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarexcedente, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoexcedente property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOExcedente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoexcedente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoexcedente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoexcedente, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarendinero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRAREndinero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarendinero]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarendinero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarendinero, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoendinero property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOEndinero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoendinero]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoendinero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoendinero, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrargastosMedicos property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARGastosMedicos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrargastosMedicos]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrargastosMedicos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrargastosMedicos, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculogastosMedicos property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOGastosMedicos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculogastosMedicos]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculogastosMedicos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculogastosMedicos, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarinvalidezyvida property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARInvalidezyvida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarinvalidezyvida]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarinvalidezyvida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarinvalidezyvida, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoinvalidezyvida property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOInvalidezyvida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoinvalidezyvida]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoinvalidezyvida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoinvalidezyvida, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarguarderias property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARGuarderias"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarguarderias]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarguarderias, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarguarderias, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoguarderias property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOGuarderias"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoguarderias]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoguarderias, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoguarderias, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarretiro property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARRetiro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarretiro]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarretiro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarretiro, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoretiro property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULORetiro"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoretiro]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoretiro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoretiro, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcesantiayvejez property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCesantiayvejez"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcesantiayvejez]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcesantiayvejez, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcesantiayvejez, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculocesantiayvejez property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOCesantiayvejez"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculocesantiayvejez]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculocesantiayvejez, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculocesantiayvejez, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarinfonavit property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARINFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarinfonavit]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarinfonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarinfonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoinfonavit property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULOINFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoinfonavit]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoinfonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoinfonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarriesgodeTrabajo property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARRiesgodeTrabajo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarriesgodeTrabajo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarriesgodeTrabajo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarriesgodeTrabajo, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopeVssmdfintegrarcalculoriesgodeTrabajo property of the Entity NomImssinfonavit<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomIMSSINFONAVIT"."TopeVSSMDFINTEGRARCALCULORiesgodeTrabajo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TopeVssmdfintegrarcalculoriesgodeTrabajo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoriesgodeTrabajo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImssinfonavitFieldIndex.TopeVssmdfintegrarcalculoriesgodeTrabajo, Integer), value)
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
				Return CInt(Integralab.ORM.EntityType.NomImssinfonavitEntity)
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
