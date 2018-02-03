' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 16:33:23
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
	''' <summary>Entity class which represents the entity 'ConfiguracionChequesImp'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ConfiguracionChequesImpEntity 
#Else
	<Serializable()> _
	Public Class ConfiguracionChequesImpEntity 
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
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		Public Sub New(codigo As System.Int32, idBanco As System.Int32)

			InitClassFetch(codigo, idBanco, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, idBanco As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, idBanco, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="validator">The custom validator Object for this ConfiguracionChequesImpEntity</param>
		Public Sub New(codigo As System.Int32, idBanco As System.Int32, validator As IValidator)

			InitClassFetch(codigo, idBanco, validator, Nothing)
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
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, idBanco As System.Int32) As Boolean
			Return FetchUsingPK(codigo, idBanco, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, idBanco As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, idBanco, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, idBanco As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codigo, idBanco, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Codigo, Me.IdBanco, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ConfiguracionChequesImpFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ConfiguracionChequesImpFieldIndex) As Boolean
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ConfiguracionChequesImpFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ConfiguracionChequesImpFieldIndex)






















































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
			Dim dao As ConfiguracionChequesImpDAO = CType(CreateDAOInstance(), ConfiguracionChequesImpDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ConfiguracionChequesImpDAO = CType(CreateDAOInstance(), ConfiguracionChequesImpDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ConfiguracionChequesImpDAO = CType(CreateDAOInstance(), ConfiguracionChequesImpDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ConfiguracionChequesImpEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ConfiguracionChequesImpEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="validator">The validator Object for this ConfiguracionChequesImpEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, idBanco As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codigo, idBanco, prefetchPathToUse, Nothing)
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

			_fieldsCustomProperties.Add("IdBanco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BeneficiarioImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BeneficiarioImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteConLetraImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteConLetraImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BeneficiarioCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BeneficiarioCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteConLetraCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteConLetraCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubCtaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubCtaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubSubCtaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubSubCtaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubSubSubCtaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubSubSubCtaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CargoImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CargoImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoAcuentaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoAcuentaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirCuentaConcentrada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImprimirCuentaDetallada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ConceptoImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ConceptoImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoAcuentaCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoAcuentaCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioChequeImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioChequeImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioChequeCopiaImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioChequeCopiaImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CargoTotalImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CargoTotalImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoTotalImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AbonoTotalImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BancoImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BancoImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaBancoImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaBancoImpRen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ChequeImpCol", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ChequeImpRen", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="idBanco">PK value for ConfiguracionChequesImp which data should be fetched into this ConfiguracionChequesImp Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, idBanco As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ConfiguracionChequesImpFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				MyBase.Fields(CInt(ConfiguracionChequesImpFieldIndex.IdBanco)).ForcedCurrentValueWrite(idBanco)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateConfiguracionChequesImpDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ConfiguracionChequesImpEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ConfiguracionChequesImpRelations
			Get	
				Return New ConfiguracionChequesImpRelations() 
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
				Return "ConfiguracionChequesImpEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ConfiguracionChequesImpEntity.CustomProperties
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
				Return ConfiguracionChequesImpEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdBanco property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."IdBanco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdBanco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.IdBanco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.IdBanco, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FechaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FechaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The BeneficiarioImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BeneficiarioImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BeneficiarioImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The BeneficiarioImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BeneficiarioImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BeneficiarioImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteConLetraImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteConLetraImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteConLetraImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteConLetraImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteConLetraImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteConLetraImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FechaCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FechaCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FechaCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The BeneficiarioCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BeneficiarioCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BeneficiarioCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The BeneficiarioCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BeneficiarioCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BeneficiarioCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BeneficiarioCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteConLetraCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteConLetraCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteConLetraCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteConLetraCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImporteConLetraCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteConLetraCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImporteConLetraCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CuentaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CuentaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CuentaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CuentaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubCtaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubCtaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubCtaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubCtaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubCtaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubCtaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubCtaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubCtaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubCtaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubCtaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubSubCtaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubSubCtaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubSubCtaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubCtaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubCtaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubSubCtaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubSubCtaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubSubCtaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubCtaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubCtaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubSubSubCtaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubSubSubCtaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubSubSubCtaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubSubCtaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubSubCtaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubSubSubCtaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."SubSubSubCtaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubSubSubCtaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubSubCtaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.SubSubSubCtaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."DescripcionImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.DescripcionImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.DescripcionImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."DescripcionImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.DescripcionImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.DescripcionImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The CargoImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CargoImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CargoImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The CargoImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CargoImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CargoImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoAcuentaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoACuentaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoAcuentaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoAcuentaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoACuentaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoAcuentaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirCuentaConcentrada property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImprimirCuentaConcentrada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirCuentaConcentrada]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImprimirCuentaConcentrada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImprimirCuentaConcentrada, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImprimirCuentaDetallada property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ImprimirCuentaDetallada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImprimirCuentaDetallada]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImprimirCuentaDetallada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ImprimirCuentaDetallada, Integer), value)
			End Set
		End Property
	
		''' <summary>The ConceptoImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ConceptoImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ConceptoImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ConceptoImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ConceptoImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ConceptoImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ConceptoImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ConceptoImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ConceptoImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ConceptoImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoAcuentaCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoACuentaCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoAcuentaCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoAcuentaCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoACuentaCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoAcuentaCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoAcuentaCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioChequeImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FolioChequeImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioChequeImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioChequeImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FolioChequeImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioChequeImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioChequeCopiaImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FolioChequeCopiaImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioChequeCopiaImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeCopiaImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeCopiaImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioChequeCopiaImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."FolioChequeCopiaImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioChequeCopiaImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeCopiaImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.FolioChequeCopiaImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The CargoTotalImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CargoTotalImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CargoTotalImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoTotalImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoTotalImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The CargoTotalImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CargoTotalImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CargoTotalImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoTotalImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CargoTotalImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoTotalImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoTotalImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoTotalImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoTotalImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoTotalImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The AbonoTotalImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."AbonoTotalImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AbonoTotalImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoTotalImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.AbonoTotalImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The BancoImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BancoImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BancoImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BancoImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BancoImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The BancoImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."BancoImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BancoImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.BancoImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.BancoImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaBancoImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CuentaBancoImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CuentaBancoImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaBancoImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaBancoImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaBancoImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."CuentaBancoImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CuentaBancoImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaBancoImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.CuentaBancoImpRen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ChequeImpCol property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ChequeImpCol"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ChequeImpCol]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ChequeImpCol, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ChequeImpCol, Integer), value)
			End Set
		End Property
	
		''' <summary>The ChequeImpRen property of the Entity ConfiguracionChequesImp<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ConfiguracionChequesImp"."ChequeImpRen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ChequeImpRen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ConfiguracionChequesImpFieldIndex.ChequeImpRen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ConfiguracionChequesImpFieldIndex.ChequeImpRen, Integer), value)
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
				Return CInt(Integralab.ORM.EntityType.ConfiguracionChequesImpEntity)
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
