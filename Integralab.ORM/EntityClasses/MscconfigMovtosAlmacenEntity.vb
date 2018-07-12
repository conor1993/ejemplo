' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 16:37:43
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
	''' <summary>Entity class which represents the entity 'MscconfigMovtosAlmacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscconfigMovtosAlmacenEntity 
#Else
	<Serializable()> _
	Public Class MscconfigMovtosAlmacenEntity 
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
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		Public Sub New(idConfiguracion As System.Int32)

			InitClassFetch(idConfiguracion, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idConfiguracion, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <param name="validator">The custom validator Object for this MscconfigMovtosAlmacenEntity</param>
		Public Sub New(idConfiguracion As System.Int32, validator As IValidator)

			InitClassFetch(idConfiguracion, validator, Nothing)
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
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idConfiguracion As System.Int32) As Boolean
			Return FetchUsingPK(idConfiguracion, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idConfiguracion, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscconfigMovtosAlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscconfigMovtosAlmacenFieldIndex) As Boolean
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscconfigMovtosAlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscconfigMovtosAlmacenFieldIndex)





















































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
			Dim dao As MscconfigMovtosAlmacenDAO = CType(CreateDAOInstance(), MscconfigMovtosAlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscconfigMovtosAlmacenDAO = CType(CreateDAOInstance(), MscconfigMovtosAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscconfigMovtosAlmacenDAO = CType(CreateDAOInstance(), MscconfigMovtosAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscconfigMovtosAlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscconfigMovtosAlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <param name="validator">The validator Object for this MscconfigMovtosAlmacenEntity</param>
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

			_fieldsCustomProperties.Add("EntradaCanalAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXcaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXcaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXdevolucionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXdevolucionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXdevolucionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXdecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXdecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXcompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXcompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXcompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXotrasEntradas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXotrasEntradas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXotrasEntradas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXcancelacionCanalAcorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXcancelacionCanalAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXcancelacionCapturaCorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXcancelacionProductoCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXventa", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXventa", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXventa", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXcancelacionDecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXcancelacionDecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXcancelacionCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXcancelacionCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXcancelacionCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXotrasSalidas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXotrasSalidas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXotrasSalidas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXcancelacionInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXcancelacionInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXcancelacionInventarioInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaProductoXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXajusteInventario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCanalXcanalAcorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCanalXcancelacionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXcancelacionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaProductoXcancelacionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXcancelacionReproceso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXreproceso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXcancelacionDevolucionVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXtraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXtraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EntradaCorteXcancelacionSalidaTraspaso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalidaCorteXcancelacionEntradaTraspaso", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idConfiguracion">PK value for MscconfigMovtosAlmacen which data should be fetched into this MscconfigMovtosAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idConfiguracion As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscconfigMovtosAlmacenFieldIndex.IdConfiguracion)).ForcedCurrentValueWrite(idConfiguracion)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscconfigMovtosAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscconfigMovtosAlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscconfigMovtosAlmacenRelations
			Get	
				Return New MscconfigMovtosAlmacenRelations() 
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
				Return "MscconfigMovtosAlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscconfigMovtosAlmacenEntity.CustomProperties
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
				Return MscconfigMovtosAlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdConfiguracion property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."IdConfiguracion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdConfiguracion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.IdConfiguracion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.IdConfiguracion, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalAlmacen property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalAlmacen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalAlmacen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXcaptura property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXcaptura]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXcaptura property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXcaptura]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXdevolucionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXDevolucionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXdevolucionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXdevolucionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXdevolucionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXdevolucionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXDevolucionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXdevolucionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXdevolucionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXdevolucionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXdevolucionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXDevolucionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXdevolucionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXdevolucionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXdevolucionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXdecomiso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXdecomiso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXdecomiso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXdecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXdecomiso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXdecomiso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXdecomiso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXdecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXcompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXcompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXcompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXcompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXcompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXcompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXotrasEntradas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXOtrasEntradas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXotrasEntradas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXotrasEntradas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXotrasEntradas, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXotrasEntradas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXOtrasEntradas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXotrasEntradas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXotrasEntradas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXotrasEntradas, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXotrasEntradas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXOtrasEntradas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXotrasEntradas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXotrasEntradas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXotrasEntradas, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXcancelacionCanalAcorte property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXCancelacionCanalACorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXcancelacionCanalAcorte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcancelacionCanalAcorte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcancelacionCanalAcorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXcancelacionCanalAlmacen property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXCancelacionCanalAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXcancelacionCanalAlmacen]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionCanalAlmacen, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionCanalAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXcancelacionCapturaCorte property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXCancelacionCapturaCorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXcancelacionCapturaCorte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionCapturaCorte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionCapturaCorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXcancelacionProductoCaptura property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXCancelacionProductoCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXcancelacionProductoCaptura]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionProductoCaptura, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionProductoCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXventa property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXventa]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXventa, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXventa, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXventa property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXventa]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXventa, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXventa, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXventa property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXventa]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXventa, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXventa, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXcancelacionDecomiso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXCancelacionDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXcancelacionDecomiso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionDecomiso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionDecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXcancelacionDecomiso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXCancelacionDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXcancelacionDecomiso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionDecomiso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionDecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXcancelacionCompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXCancelacionCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXcancelacionCompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXcancelacionCompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXCancelacionCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXcancelacionCompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXcancelacionCompra property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXCancelacionCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXcancelacionCompra]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionCompra, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXotrasSalidas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXOtrasSalidas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXotrasSalidas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXotrasSalidas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXotrasSalidas, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXotrasSalidas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXOtrasSalidas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXotrasSalidas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXotrasSalidas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXotrasSalidas, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXotrasSalidas property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXOtrasSalidas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXotrasSalidas]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXotrasSalidas, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXotrasSalidas, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXcancelacionInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXCancelacionInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXcancelacionInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXcancelacionInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXcancelacionInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXCancelacionInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXcancelacionInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcancelacionInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXcancelacionInventarioInicial property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXCancelacionInventarioInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXcancelacionInventarioInicial]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionInventarioInicial, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionInventarioInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaProductoXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaProductoXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaProductoXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaProductoXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXajusteInventario property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXAjusteInventario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXajusteInventario]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXajusteInventario, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXajusteInventario, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCanalXcanalAcorte property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCanalXCanalACorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCanalXcanalAcorte]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcanalAcorte, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCanalXcanalAcorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCanalXcancelacionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCanalXCancelacionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCanalXcancelacionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcancelacionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCanalXcancelacionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXcancelacionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXCancelacionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXcancelacionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaProductoXcancelacionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaProductoXCancelacionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaProductoXcancelacionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcancelacionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaProductoXcancelacionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXcancelacionReproceso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXCancelacionReproceso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXcancelacionReproceso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionReproceso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionReproceso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXreproceso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXReproceso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXreproceso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXreproceso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXreproceso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXcancelacionDevolucionVenta property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXCancelacionDevolucionVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXcancelacionDevolucionVenta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionDevolucionVenta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionDevolucionVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXtraspaso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXtraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXtraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXtraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXtraspaso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXtraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXtraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXtraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The EntradaCorteXcancelacionSalidaTraspaso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."EntradaCorteXCancelacionSalidaTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EntradaCorteXcancelacionSalidaTraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionSalidaTraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.EntradaCorteXcancelacionSalidaTraspaso, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalidaCorteXcancelacionEntradaTraspaso property of the Entity MscconfigMovtosAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCConfigMovtosAlmacen"."SalidaCorteXCancelacionEntradaTraspaso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [SalidaCorteXcancelacionEntradaTraspaso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionEntradaTraspaso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MscconfigMovtosAlmacenFieldIndex.SalidaCorteXcancelacionEntradaTraspaso, Integer), value)
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
				Return CInt(Integralab.ORM.EntityType.MscconfigMovtosAlmacenEntity)
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
