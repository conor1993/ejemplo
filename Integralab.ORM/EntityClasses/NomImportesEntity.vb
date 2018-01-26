' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:29
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
	''' <summary>Entity class which represents the entity 'NomImportes'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class NomImportesEntity 
#Else
	<Serializable()> _
	Public Class NomImportesEntity 
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
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		Public Sub New(folio As System.String, idEmpleado As System.Int32)

			InitClassFetch(folio, idEmpleado, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folio As System.String, idEmpleado As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folio, idEmpleado, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="validator">The custom validator Object for this NomImportesEntity</param>
		Public Sub New(folio As System.String, idEmpleado As System.Int32, validator As IValidator)

			InitClassFetch(folio, idEmpleado, validator, Nothing)
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
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, idEmpleado As System.Int32) As Boolean
			Return FetchUsingPK(folio, idEmpleado, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, idEmpleado As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folio, idEmpleado, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, idEmpleado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folio, idEmpleado, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Folio, Me.IdEmpleado, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As NomImportesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As NomImportesFieldIndex) As Boolean
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(NomImportesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, NomImportesFieldIndex)




















































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
			Dim dao As NomImportesDAO = CType(CreateDAOInstance(), NomImportesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As NomImportesDAO = CType(CreateDAOInstance(), NomImportesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As NomImportesDAO = CType(CreateDAOInstance(), NomImportesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this NomImportesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.NomImportesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="validator">The validator Object for this NomImportesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folio As System.String, idEmpleado As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folio, idEmpleado, prefetchPathToUse, Nothing)
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

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEmpleado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Quincena", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fecha", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasTrabajados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SueldoDiario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteSueldo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Comisiones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasExtras", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteHorasExtras", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasExtrasTriples", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportesHorasExtrasTriples", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteHorasExtrasExentasIsr", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteHorasExtrasExentasImss", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotalPercepciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportePercepcionGravadaIsr", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportePercepcionGravadaImss", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteIsrsubsidioalEmpleo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteIsrsegunTarifa", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteSubsidioalEmpleo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteExcedente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportePrestacionesenDinero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteGastosMedicosPensionados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteInvalidezyVida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotalCuotaMensual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteCesantiayVejez", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotalCuotaBimestral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteCuotaFija", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteExcedentePatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportePrestacionesenDineroPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteGastosMedicosPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteInvalidezVidaPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteGuardariaPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteRiesgoTrabajoPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotalCuotaMensualPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteCesantiayVejezPatronal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteRetiroSar", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteInfonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotalaPercibir", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Pretamos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Infonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoHrsExtrasDobles", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoHrsExtrasTriples", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteNetoaPercibir", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteHorasExtrasDobles", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasExtrasDobles", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImportePensionAlimenticia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SmregionA", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SmregionC", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MesComercial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("HorasDiariasTrabajadas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasdeFalta", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folio">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="idEmpleado">PK value for NomImportes which data should be fetched into this NomImportes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folio As System.String, idEmpleado As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(NomImportesFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				MyBase.Fields(CInt(NomImportesFieldIndex.IdEmpleado)).ForcedCurrentValueWrite(idEmpleado)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateNomImportesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New NomImportesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As NomImportesRelations
			Get	
				Return New NomImportesRelations() 
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
				Return "NomImportesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return NomImportesEntity.CustomProperties
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
				Return NomImportesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Folio property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEmpleado property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."IdEmpleado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdEmpleado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.IdEmpleado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.IdEmpleado, Integer), value)
			End Set
		End Property
	
		''' <summary>The Quincena property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."Quincena"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Quincena]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Quincena, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Quincena, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fecha property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."Fecha"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Fecha]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Fecha, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Fecha, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasTrabajados property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."DiasTrabajados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasTrabajados]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.DiasTrabajados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.DiasTrabajados, Integer), value)
			End Set
		End Property
	
		''' <summary>The SueldoDiario property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."SueldoDiario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SueldoDiario]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.SueldoDiario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.SueldoDiario, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteSueldo property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteSueldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteSueldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteSueldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteSueldo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Comisiones property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."Comisiones"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Comisiones]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Comisiones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Comisiones, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasExtras property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."HorasExtras"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasExtras]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.HorasExtras, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.HorasExtras, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteHorasExtras property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteHorasExtras"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteHorasExtras]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtras, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtras, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasExtrasTriples property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."HorasExtrasTriples"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasExtrasTriples]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.HorasExtrasTriples, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.HorasExtrasTriples, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportesHorasExtrasTriples property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportesHorasExtrasTriples"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportesHorasExtrasTriples]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportesHorasExtrasTriples, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportesHorasExtrasTriples, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteHorasExtrasExentasIsr property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteHorasExtrasExentasISR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteHorasExtrasExentasIsr]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasExentasIsr, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasExentasIsr, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteHorasExtrasExentasImss property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteHorasExtrasExentasIMSS"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteHorasExtrasExentasImss]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasExentasImss, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasExentasImss, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotalPercepciones property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteTotalPercepciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotalPercepciones]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteTotalPercepciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteTotalPercepciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportePercepcionGravadaIsr property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportePercepcionGravadaISR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportePercepcionGravadaIsr]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportePercepcionGravadaIsr, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportePercepcionGravadaIsr, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportePercepcionGravadaImss property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportePercepcionGravadaIMSS"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportePercepcionGravadaImss]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportePercepcionGravadaImss, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportePercepcionGravadaImss, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteIsrsubsidioalEmpleo property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteISRSubsidioalEmpleo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteIsrsubsidioalEmpleo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteIsrsubsidioalEmpleo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteIsrsubsidioalEmpleo, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteIsrsegunTarifa property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteISRSegunTarifa"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteIsrsegunTarifa]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteIsrsegunTarifa, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteIsrsegunTarifa, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteSubsidioalEmpleo property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteSubsidioalEmpleo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteSubsidioalEmpleo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteSubsidioalEmpleo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteSubsidioalEmpleo, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteExcedente property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteExcedente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteExcedente]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteExcedente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteExcedente, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportePrestacionesenDinero property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportePrestacionesenDinero"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportePrestacionesenDinero]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportePrestacionesenDinero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportePrestacionesenDinero, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteGastosMedicosPensionados property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteGastosMedicosPensionados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteGastosMedicosPensionados]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteGastosMedicosPensionados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteGastosMedicosPensionados, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteInvalidezyVida property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteInvalidezyVida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteInvalidezyVida]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteInvalidezyVida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteInvalidezyVida, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotalCuotaMensual property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteTotalCuotaMensual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotalCuotaMensual]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaMensual, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaMensual, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteCesantiayVejez property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteCesantiayVejez"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteCesantiayVejez]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteCesantiayVejez, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteCesantiayVejez, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotalCuotaBimestral property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteTotalCuotaBimestral"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotalCuotaBimestral]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaBimestral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaBimestral, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteCuotaFija property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteCuotaFija"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteCuotaFija]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteCuotaFija, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteCuotaFija, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteExcedentePatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteExcedentePatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteExcedentePatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteExcedentePatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteExcedentePatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportePrestacionesenDineroPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportePrestacionesenDineroPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportePrestacionesenDineroPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportePrestacionesenDineroPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportePrestacionesenDineroPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteGastosMedicosPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteGastosMedicosPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteGastosMedicosPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteGastosMedicosPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteGastosMedicosPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteInvalidezVidaPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteInvalidezVidaPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteInvalidezVidaPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteInvalidezVidaPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteInvalidezVidaPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteGuardariaPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteGuardariaPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteGuardariaPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteGuardariaPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteGuardariaPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteRiesgoTrabajoPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteRiesgoTrabajoPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteRiesgoTrabajoPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteRiesgoTrabajoPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteRiesgoTrabajoPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotalCuotaMensualPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteTotalCuotaMensualPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotalCuotaMensualPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaMensualPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteTotalCuotaMensualPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteCesantiayVejezPatronal property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteCesantiayVejezPatronal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteCesantiayVejezPatronal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteCesantiayVejezPatronal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteCesantiayVejezPatronal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteRetiroSar property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteRetiroSAR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteRetiroSar]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteRetiroSar, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteRetiroSar, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteInfonavit property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteINFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteInfonavit]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteInfonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteInfonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotalaPercibir property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteTotalaPercibir"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotalaPercibir]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteTotalaPercibir, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteTotalaPercibir, Integer), value)
			End Set
		End Property
	
		''' <summary>The Pretamos property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."Pretamos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Pretamos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Pretamos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Pretamos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Infonavit property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."INFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Infonavit]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.Infonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.Infonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoHrsExtrasDobles property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."CostoHrsExtrasDobles"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoHrsExtrasDobles]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.CostoHrsExtrasDobles, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.CostoHrsExtrasDobles, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoHrsExtrasTriples property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."CostoHrsExtrasTriples"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoHrsExtrasTriples]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.CostoHrsExtrasTriples, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.CostoHrsExtrasTriples, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteNetoaPercibir property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteNetoaPercibir"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteNetoaPercibir]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteNetoaPercibir, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteNetoaPercibir, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteHorasExtrasDobles property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImporteHorasExtrasDobles"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteHorasExtrasDobles]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasDobles, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImporteHorasExtrasDobles, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasExtrasDobles property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."HorasExtrasDobles"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasExtrasDobles]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.HorasExtrasDobles, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.HorasExtrasDobles, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImportePensionAlimenticia property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."ImportePensionAlimenticia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImportePensionAlimenticia]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.ImportePensionAlimenticia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.ImportePensionAlimenticia, Integer), value)
			End Set
		End Property
	
		''' <summary>The SmregionA property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."SMRegionA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SmregionA]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.SmregionA, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.SmregionA, Integer), value)
			End Set
		End Property
	
		''' <summary>The SmregionC property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."SMRegionC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SmregionC]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.SmregionC, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.SmregionC, Integer), value)
			End Set
		End Property
	
		''' <summary>The MesComercial property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."MesComercial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MesComercial]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.MesComercial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.MesComercial, Integer), value)
			End Set
		End Property
	
		''' <summary>The HorasDiariasTrabajadas property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."HorasDiariasTrabajadas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [HorasDiariasTrabajadas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.HorasDiariasTrabajadas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.HorasDiariasTrabajadas, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasdeFalta property of the Entity NomImportes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomImportes"."DiasdeFalta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasdeFalta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomImportesFieldIndex.DiasdeFalta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomImportesFieldIndex.DiasdeFalta, Integer), value)
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
				Return CInt(Integralab.ORM.EntityType.NomImportesEntity)
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
