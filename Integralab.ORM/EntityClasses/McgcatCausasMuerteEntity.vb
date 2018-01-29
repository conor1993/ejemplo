' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 16:36:34
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
	''' <summary>Entity class which represents the entity 'McgcatCausasMuerte'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McgcatCausasMuerteEntity 
#Else
	<Serializable()> _
	Public Class McgcatCausasMuerteEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _salidaGanadoCab As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
		Private _alwaysFetchSalidaGanadoCab, _alreadyFetchedSalidaGanadoCab As Boolean
		Private _cabMovGanCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab, _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatLotesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
		Private _catRastrosCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.CatRastrosCollection
		Private _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab, _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab As Boolean
		Private _mcecatCorralesCabCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab, _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
		Private _polizaCollectionViaSalidaGanadoCab As Integralab.ORM.CollectionClasses.PolizaCollection
		Private _alwaysFetchPolizaCollectionViaSalidaGanadoCab, _alreadyFetchedPolizaCollectionViaSalidaGanadoCab As Boolean



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
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		Public Sub New(idCausaMuerte As System.Int32)

			InitClassFetch(idCausaMuerte, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCausaMuerte As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCausaMuerte, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="validator">The custom validator Object for this McgcatCausasMuerteEntity</param>
		Public Sub New(idCausaMuerte As System.Int32, validator As IValidator)

			InitClassFetch(idCausaMuerte, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_salidaGanadoCab = CType(info.GetValue("_salidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)), Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection)
			_alwaysFetchSalidaGanadoCab = info.GetBoolean("_alwaysFetchSalidaGanadoCab")
			_alreadyFetchedSalidaGanadoCab = info.GetBoolean("_alreadyFetchedSalidaGanadoCab")
			_cabMovGanCollectionViaSalidaGanadoCab = CType(info.GetValue("_cabMovGanCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab")
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab")
			_mcecatLotesCabCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcecatLotesCabCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab")
			_catRastrosCollectionViaSalidaGanadoCab = CType(info.GetValue("_catRastrosCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.CatRastrosCollection)), Integralab.ORM.CollectionClasses.CatRastrosCollection)
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab")
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab")
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = CType(info.GetValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab")
			_polizaCollectionViaSalidaGanadoCab = CType(info.GetValue("_polizaCollectionViaSalidaGanadoCab", GetType(Integralab.ORM.CollectionClasses.PolizaCollection)), Integralab.ORM.CollectionClasses.PolizaCollection)
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alwaysFetchPolizaCollectionViaSalidaGanadoCab")
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = info.GetBoolean("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedSalidaGanadoCab = (_salidaGanadoCab.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = (_cabMovGanCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = (_mcecatLotesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = (_catRastrosCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = (_mcecatCorralesCabCollectionViaSalidaGanadoCab.Count > 0)
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = (_polizaCollectionViaSalidaGanadoCab.Count > 0)


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
			info.AddValue("_salidaGanadoCab", _salidaGanadoCab)
			info.AddValue("_alwaysFetchSalidaGanadoCab", _alwaysFetchSalidaGanadoCab)
			info.AddValue("_alreadyFetchedSalidaGanadoCab", _alreadyFetchedSalidaGanadoCab)
			info.AddValue("_cabMovGanCollectionViaSalidaGanadoCab", _cabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab", _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab", _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatLotesCabCollectionViaSalidaGanadoCab", _mcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab", _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab", _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_catRastrosCollectionViaSalidaGanadoCab", _catRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab", _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab", _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab)
			info.AddValue("_mcecatCorralesCabCollectionViaSalidaGanadoCab", _mcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab", _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab", _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab)
			info.AddValue("_polizaCollectionViaSalidaGanadoCab", _polizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alwaysFetchPolizaCollectionViaSalidaGanadoCab", _alwaysFetchPolizaCollectionViaSalidaGanadoCab)
			info.AddValue("_alreadyFetchedPolizaCollectionViaSalidaGanadoCab", _alreadyFetchedPolizaCollectionViaSalidaGanadoCab)


			
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

				Case "SalidaGanadoCab"
					_alreadyFetchedSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.SalidaGanadoCab.Add(CType(entity, SalidaGanadoCabEntity))
					End If
				Case "CabMovGanCollectionViaSalidaGanadoCab"
					_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaSalidaGanadoCab.Add(CType(entity, CabMovGanEntity))
					End If
				Case "McecatLotesCabCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaSalidaGanadoCab.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "CatRastrosCollectionViaSalidaGanadoCab"
					_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.CatRastrosCollectionViaSalidaGanadoCab.Add(CType(entity, CatRastrosEntity))
					End If
				Case "McecatCorralesCabCollectionViaSalidaGanadoCab"
					_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaSalidaGanadoCab.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "PolizaCollectionViaSalidaGanadoCab"
					_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = True
					If Not entity Is Nothing Then
						Me.PolizaCollectionViaSalidaGanadoCab.Add(CType(entity, PolizaEntity))
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

				Case "SalidaGanadoCab"
					_salidaGanadoCab.Add(CType(relatedEntity, SalidaGanadoCabEntity))
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

				Case "SalidaGanadoCab"
					MyBase.PerformRelatedEntityRemoval(_salidaGanadoCab, relatedEntity, signalRelatedEntityManyToOne)
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



			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_salidaGanadoCab)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCausaMuerte As System.Int32) As Boolean
			Return FetchUsingPK(idCausaMuerte, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCausaMuerte As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCausaMuerte, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCausaMuerte As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCausaMuerte, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCausaMuerte, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McgcatCausasMuerteFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McgcatCausasMuerteFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, _salidaGanadoCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SalidaGanadoCabEntity'</returns>
		Public Function GetMultiSalidaGanadoCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Return GetMultiSalidaGanadoCab(forceFetch, _salidaGanadoCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			If ( Not _alreadyFetchedSalidaGanadoCab Or forceFetch Or _alwaysFetchSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _salidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_salidaGanadoCab)
					End If
				End If
				_salidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_salidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_salidaGanadoCab.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_salidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedSalidaGanadoCab = True
			End If
			Return _salidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SalidaGanadoCab'. These settings will be taken into account
		''' when the property SalidaGanadoCab is requested or GetMultiSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_salidaGanadoCab.SortClauses=sortClauses
			_salidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch, _cabMovGanCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), ComparisonOperator.Equal, Me.IdCausaMuerte))
				_cabMovGanCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_cabMovGanCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = True
			End If
			Return _cabMovGanCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaSalidaGanadoCab is requested or GetMultiCabMovGanCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_cabMovGanCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch, _mcecatLotesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), ComparisonOperator.Equal, Me.IdCausaMuerte))
				_mcecatLotesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = True
			End If
			Return _mcecatLotesCabCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaSalidaGanadoCab is requested or GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatRastrosEntity'</returns>
		Public Function GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Return GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch, _catRastrosCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatRastrosCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatRastrosCollection
			If ( Not _alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catRastrosCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catRastrosCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), ComparisonOperator.Equal, Me.IdCausaMuerte))
				_catRastrosCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catRastrosCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_catRastrosCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_catRastrosCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = True
			End If
			Return _catRastrosCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatRastrosCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property CatRastrosCollectionViaSalidaGanadoCab is requested or GetMultiCatRastrosCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatRastrosCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catRastrosCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_catRastrosCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch, _mcecatCorralesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), ComparisonOperator.Equal, Me.IdCausaMuerte))
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = True
			End If
			Return _mcecatCorralesCabCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaSalidaGanadoCab is requested or GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PolizaEntity'</returns>
		Public Function GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PolizaCollection
			Return GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch, _polizaCollectionViaSalidaGanadoCab.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPolizaCollectionViaSalidaGanadoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PolizaCollection
			If ( Not _alreadyFetchedPolizaCollectionViaSalidaGanadoCab Or forceFetch Or _alwaysFetchPolizaCollectionViaSalidaGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _polizaCollectionViaSalidaGanadoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_polizaCollectionViaSalidaGanadoCab)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", "SalidaGanadoCab_", JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza, "SalidaGanadoCab_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCausasMuerteFieldIndex.IdCausaMuerte), ComparisonOperator.Equal, Me.IdCausaMuerte))
				_polizaCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_polizaCollectionViaSalidaGanadoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_polizaCollectionViaSalidaGanadoCab.GetMulti(Filter, relations)
				_polizaCollectionViaSalidaGanadoCab.SuppressClearInGetMulti = False
				_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = True
			End If
			Return _polizaCollectionViaSalidaGanadoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PolizaCollectionViaSalidaGanadoCab'. These settings will be taken into account
		''' when the property PolizaCollectionViaSalidaGanadoCab is requested or GetMultiPolizaCollectionViaSalidaGanadoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPolizaCollectionViaSalidaGanadoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_polizaCollectionViaSalidaGanadoCab.SortClauses=sortClauses
			_polizaCollectionViaSalidaGanadoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(McgcatCausasMuerteFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McgcatCausasMuerteFieldIndex)





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_salidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_catRastrosCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext
			_polizaCollectionViaSalidaGanadoCab.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McgcatCausasMuerteDAO = CType(CreateDAOInstance(), McgcatCausasMuerteDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McgcatCausasMuerteDAO = CType(CreateDAOInstance(), McgcatCausasMuerteDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McgcatCausasMuerteDAO = CType(CreateDAOInstance(), McgcatCausasMuerteDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McgcatCausasMuerteEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatCausasMuerteEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="validator">The validator Object for this McgcatCausasMuerteEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCausaMuerte As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCausaMuerte, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_salidaGanadoCab = New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(New SalidaGanadoCabEntityFactory())
			_salidaGanadoCab.SetContainingEntityInfo(Me, "McgcatCausasMuerte")
			_alwaysFetchSalidaGanadoCab = False
			_alreadyFetchedSalidaGanadoCab = False
			_cabMovGanCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCabMovGanCollectionViaSalidaGanadoCab = False
			_mcecatLotesCabCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcecatLotesCabCollectionViaSalidaGanadoCab = False
			_catRastrosCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.CatRastrosCollection(New CatRastrosEntityFactory())
			_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = False
			_alreadyFetchedCatRastrosCollectionViaSalidaGanadoCab = False
			_mcecatCorralesCabCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_alreadyFetchedMcecatCorralesCabCollectionViaSalidaGanadoCab = False
			_polizaCollectionViaSalidaGanadoCab = New Integralab.ORM.CollectionClasses.PolizaCollection(New PolizaEntityFactory())
			_alwaysFetchPolizaCollectionViaSalidaGanadoCab = False
			_alreadyFetchedPolizaCollectionViaSalidaGanadoCab = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCausaMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NombreCausaMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomCorCausaMuerte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idCausaMuerte">PK value for McgcatCausasMuerte which data should be fetched into this McgcatCausasMuerte Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCausaMuerte As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McgcatCausasMuerteFieldIndex.IdCausaMuerte)).ForcedCurrentValueWrite(idCausaMuerte)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcgcatCausasMuerteDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McgcatCausasMuerteEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McgcatCausasMuerteRelations
			Get	
				Return New McgcatCausasMuerteRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalidaGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSalidaGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.SalidaGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "SalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatLotesCabEntityUsingIdLoteDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatRastros' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatRastrosCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.CatRastrosEntityUsingIdRastro)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatRastrosCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.CatRastrosEntity, Integer), 0, Nothing, Nothing, relations, "CatRastrosCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPolizaCollectionViaSalidaGanadoCab() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, "__McgcatCausasMuerteEntity__", String.Empty, JoinHint.None)
				relations.Add(SalidaGanadoCabEntity.Relations.PolizaEntityUsingIdPoliza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					McgcatCausasMuerteEntity.Relations.SalidaGanadoCabEntityUsingIdCausaMuerte, _
					CType(Integralab.ORM.EntityType.McgcatCausasMuerteEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, relations, "PolizaCollectionViaSalidaGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McgcatCausasMuerteEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McgcatCausasMuerteEntity.CustomProperties
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
				Return McgcatCausasMuerteEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCausaMuerte property of the Entity McgcatCausasMuerte<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCausasMuerte"."IdCausaMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdCausaMuerte]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCausasMuerteFieldIndex.IdCausaMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCausasMuerteFieldIndex.IdCausaMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The NombreCausaMuerte property of the Entity McgcatCausasMuerte<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCausasMuerte"."NombreCausaMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NombreCausaMuerte]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCausasMuerteFieldIndex.NombreCausaMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCausasMuerteFieldIndex.NombreCausaMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomCorCausaMuerte property of the Entity McgcatCausasMuerte<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCausasMuerte"."NomCorCausaMuerte"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomCorCausaMuerte]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCausasMuerteFieldIndex.NomCorCausaMuerte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCausasMuerteFieldIndex.NomCorCausaMuerte, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McgcatCausasMuerte<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCausasMuerte"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCausasMuerteFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCausasMuerteFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McgcatCausasMuerte<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCausasMuerte"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCausasMuerteFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCausasMuerteFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'SalidaGanadoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SalidaGanadoCab]() As Integralab.ORM.CollectionClasses.SalidaGanadoCabCollection
			Get
				Return GetMultiSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SalidaGanadoCab. When set to true, SalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchSalidaGanadoCab
			End Get
			Set
				_alwaysFetchSalidaGanadoCab = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaSalidaGanadoCab. When set to true, CabMovGanCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaSalidaGanadoCab. When set to true, McecatLotesCabCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatRastrosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatRastrosCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatRastrosCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.CatRastrosCollection
			Get
				Return GetMultiCatRastrosCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatRastrosCollectionViaSalidaGanadoCab. When set to true, CatRastrosCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatRastrosCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatRastrosCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatRastrosCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchCatRastrosCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchCatRastrosCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaSalidaGanadoCab. When set to true, McecatCorralesCabCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaSalidaGanadoCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PolizaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPolizaCollectionViaSalidaGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PolizaCollectionViaSalidaGanadoCab]() As Integralab.ORM.CollectionClasses.PolizaCollection
			Get
				Return GetMultiPolizaCollectionViaSalidaGanadoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PolizaCollectionViaSalidaGanadoCab. When set to true, PolizaCollectionViaSalidaGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PolizaCollectionViaSalidaGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiPolizaCollectionViaSalidaGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPolizaCollectionViaSalidaGanadoCab As Boolean
			Get
				Return _alwaysFetchPolizaCollectionViaSalidaGanadoCab
			End Get
			Set
				_alwaysFetchPolizaCollectionViaSalidaGanadoCab = value
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
				Return CInt(Integralab.ORM.EntityType.McgcatCausasMuerteEntity)
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
