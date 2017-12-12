' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 1 de diciembre de 2017 15:44:19
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
	''' <summary>Entity class which represents the entity 'McgcatCompradoresdeGanado'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McgcatCompradoresdeGanadoEntity 
#Else
	<Serializable()> _
	Public Class McgcatCompradoresdeGanadoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cabRegCom As Integralab.ORM.CollectionClasses.CabRegComCollection
		Private _alwaysFetchCabRegCom, _alreadyFetchedCabRegCom As Boolean
		Private _cabMovGanCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom, _alreadyFetchedCabMovGanCollectionViaCabRegCom As Boolean
		Private _cabMovGanCollectionViaCabRegCom_ As Integralab.ORM.CollectionClasses.CabMovGanCollection
		Private _alwaysFetchCabMovGanCollectionViaCabRegCom_, _alreadyFetchedCabMovGanCollectionViaCabRegCom_ As Boolean
		Private _catLugaresDeCompraCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
		Private _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom, _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom As Boolean
		Private _proveedorCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaCabRegCom, _alreadyFetchedProveedorCollectionViaCabRegCom As Boolean
		Private _mcecatCorralesCabCollectionViaCabRegCom As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom, _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean


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
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		Public Sub New(idComprador As System.Int32)

			InitClassFetch(idComprador, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idComprador As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idComprador, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="validator">The custom validator Object for this McgcatCompradoresdeGanadoEntity</param>
		Public Sub New(idComprador As System.Int32, validator As IValidator)

			InitClassFetch(idComprador, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabRegCom = CType(info.GetValue("_cabRegCom", GetType(Integralab.ORM.CollectionClasses.CabRegComCollection)), Integralab.ORM.CollectionClasses.CabRegComCollection)
			_alwaysFetchCabRegCom = info.GetBoolean("_alwaysFetchCabRegCom")
			_alreadyFetchedCabRegCom = info.GetBoolean("_alreadyFetchedCabRegCom")
			_cabMovGanCollectionViaCabRegCom = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom")
			_cabMovGanCollectionViaCabRegCom_ = CType(info.GetValue("_cabMovGanCollectionViaCabRegCom_", GetType(Integralab.ORM.CollectionClasses.CabMovGanCollection)), Integralab.ORM.CollectionClasses.CabMovGanCollection)
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alwaysFetchCabMovGanCollectionViaCabRegCom_")
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = info.GetBoolean("_alreadyFetchedCabMovGanCollectionViaCabRegCom_")
			_catLugaresDeCompraCollectionViaCabRegCom = CType(info.GetValue("_catLugaresDeCompraCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)), Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection)
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom")
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom")
			_proveedorCollectionViaCabRegCom = CType(info.GetValue("_proveedorCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchProveedorCollectionViaCabRegCom")
			_alreadyFetchedProveedorCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedProveedorCollectionViaCabRegCom")
			_mcecatCorralesCabCollectionViaCabRegCom = CType(info.GetValue("_mcecatCorralesCabCollectionViaCabRegCom", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom")
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabRegCom = (_cabRegCom.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = (_cabMovGanCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = (_cabMovGanCollectionViaCabRegCom_.Count > 0)
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = (_catLugaresDeCompraCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedProveedorCollectionViaCabRegCom = (_proveedorCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = (_mcecatCorralesCabCollectionViaCabRegCom.Count > 0)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)

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
			info.AddValue("_cabRegCom", _cabRegCom)
			info.AddValue("_alwaysFetchCabRegCom", _alwaysFetchCabRegCom)
			info.AddValue("_alreadyFetchedCabRegCom", _alreadyFetchedCabRegCom)
			info.AddValue("_cabMovGanCollectionViaCabRegCom", _cabMovGanCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom", _alwaysFetchCabMovGanCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom", _alreadyFetchedCabMovGanCollectionViaCabRegCom)
			info.AddValue("_cabMovGanCollectionViaCabRegCom_", _cabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alwaysFetchCabMovGanCollectionViaCabRegCom_", _alwaysFetchCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_alreadyFetchedCabMovGanCollectionViaCabRegCom_", _alreadyFetchedCabMovGanCollectionViaCabRegCom_)
			info.AddValue("_catLugaresDeCompraCollectionViaCabRegCom", _catLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom", _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom", _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom)
			info.AddValue("_proveedorCollectionViaCabRegCom", _proveedorCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchProveedorCollectionViaCabRegCom", _alwaysFetchProveedorCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedProveedorCollectionViaCabRegCom", _alreadyFetchedProveedorCollectionViaCabRegCom)
			info.AddValue("_mcecatCorralesCabCollectionViaCabRegCom", _mcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom", _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom", _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)

			
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
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "CabRegCom"
					_alreadyFetchedCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabRegCom.Add(CType(entity, CabRegComEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CabMovGanCollectionViaCabRegCom_"
					_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
					If Not entity Is Nothing Then
						Me.CabMovGanCollectionViaCabRegCom_.Add(CType(entity, CabMovGanEntity))
					End If
				Case "CatLugaresDeCompraCollectionViaCabRegCom"
					_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.CatLugaresDeCompraCollectionViaCabRegCom.Add(CType(entity, CatLugaresDeCompraEntity))
					End If
				Case "ProveedorCollectionViaCabRegCom"
					_alreadyFetchedProveedorCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaCabRegCom.Add(CType(entity, ProveedorEntity))
					End If
				Case "McecatCorralesCabCollectionViaCabRegCom"
					_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaCabRegCom.Add(CType(entity, McecatCorralesCabEntity))
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
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CabRegCom"
					_cabRegCom.Add(CType(relatedEntity, CabRegComEntity))
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
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CabRegCom"
					MyBase.PerformRelatedEntityRemoval(_cabRegCom, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cabRegCom)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idComprador As System.Int32) As Boolean
			Return FetchUsingPK(idComprador, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idComprador As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idComprador, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idComprador As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idComprador, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdComprador, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McgcatCompradoresdeGanadoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McgcatCompradoresdeGanadoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabRegComEntity'</returns>
		Public Function GetMultiCabRegCom(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			Return GetMultiCabRegCom(forceFetch, _cabRegCom.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabRegComCollection
			If ( Not _alreadyFetchedCabRegCom Or forceFetch Or _alwaysFetchCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabRegCom)
					End If
				End If
				_cabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabRegCom.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_cabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabRegCom = True
			End If
			Return _cabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabRegCom'. These settings will be taken into account
		''' when the property CabRegCom is requested or GetMultiCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabRegCom.SortClauses=sortClauses
			_cabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom(forceFetch, _cabMovGanCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), ComparisonOperator.Equal, Me.IdComprador))
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom = True
			End If
			Return _cabMovGanCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom is requested or GetMultiCabMovGanCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabMovGanEntity'</returns>
		Public Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Return GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch, _cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabMovGanCollectionViaCabRegCom_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabMovGanCollection
			If ( Not _alreadyFetchedCabMovGanCollectionViaCabRegCom_ Or forceFetch Or _alwaysFetchCabMovGanCollectionViaCabRegCom_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabMovGanCollectionViaCabRegCom_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabMovGanCollectionViaCabRegCom_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), ComparisonOperator.Equal, Me.IdComprador))
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabMovGanCollectionViaCabRegCom_.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabMovGanCollectionViaCabRegCom_.GetMulti(Filter, relations)
				_cabMovGanCollectionViaCabRegCom_.SuppressClearInGetMulti = False
				_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = True
			End If
			Return _cabMovGanCollectionViaCabRegCom_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabMovGanCollectionViaCabRegCom_'. These settings will be taken into account
		''' when the property CabMovGanCollectionViaCabRegCom_ is requested or GetMultiCabMovGanCollectionViaCabRegCom_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabMovGanCollectionViaCabRegCom_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabMovGanCollectionViaCabRegCom_.SortClauses=sortClauses
			_cabMovGanCollectionViaCabRegCom_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CatLugaresDeCompraEntity'</returns>
		Public Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch, _catLugaresDeCompraCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCatLugaresDeCompraCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			If ( Not _alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom Or forceFetch Or _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _catLugaresDeCompraCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_catLugaresDeCompraCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), ComparisonOperator.Equal, Me.IdComprador))
				_catLugaresDeCompraCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_catLugaresDeCompraCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_catLugaresDeCompraCollectionViaCabRegCom.GetMulti(Filter, relations)
				_catLugaresDeCompraCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = True
			End If
			Return _catLugaresDeCompraCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CatLugaresDeCompraCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property CatLugaresDeCompraCollectionViaCabRegCom is requested or GetMultiCatLugaresDeCompraCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCatLugaresDeCompraCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_catLugaresDeCompraCollectionViaCabRegCom.SortClauses=sortClauses
			_catLugaresDeCompraCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaCabRegCom(forceFetch, _proveedorCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaCabRegCom Or forceFetch Or _alwaysFetchProveedorCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), ComparisonOperator.Equal, Me.IdComprador))
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaCabRegCom.GetMulti(Filter, relations)
				_proveedorCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaCabRegCom = True
			End If
			Return _proveedorCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property ProveedorCollectionViaCabRegCom is requested or GetMultiProveedorCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaCabRegCom.SortClauses=sortClauses
			_proveedorCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch, _mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaCabRegCom(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaCabRegCom.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaCabRegCom)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", "CabRegCom_", JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "CabRegCom_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatCompradoresdeGanadoFieldIndex.IdComprador), ComparisonOperator.Equal, Me.IdComprador))
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaCabRegCom.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaCabRegCom.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaCabRegCom.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = True
			End If
			Return _mcecatCorralesCabCollectionViaCabRegCom
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaCabRegCom'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaCabRegCom is requested or GetMultiMcecatCorralesCabCollectionViaCabRegCom is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaCabRegCom(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaCabRegCom.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaCabRegCom.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable() As CuentaContableEntity
			Return GetSingleCuentaContable(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaContable Or forceFetch Or _alwaysFetchCuentaContable) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McgcatCompradoresdeGanadoEntity.Relations.CuentaContableEntityUsingIdCuentaContable) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCuentaContable)
				End If
				If Not _cuentaContableReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaContable = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaContable = newEntity
					_alreadyFetchedCuentaContable = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaContable
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McgcatCompradoresdeGanadoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McgcatCompradoresdeGanadoFieldIndex)















					Case McgcatCompradoresdeGanadoFieldIndex.IdCuentaContable
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False

					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabRegCom.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_cabMovGanCollectionViaCabRegCom_.ActiveContext = MyBase.ActiveContext
			_catLugaresDeCompraCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaCabRegCom.ActiveContext = MyBase.ActiveContext
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McgcatCompradoresdeGanadoDAO = CType(CreateDAOInstance(), McgcatCompradoresdeGanadoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McgcatCompradoresdeGanadoDAO = CType(CreateDAOInstance(), McgcatCompradoresdeGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McgcatCompradoresdeGanadoDAO = CType(CreateDAOInstance(), McgcatCompradoresdeGanadoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McgcatCompradoresdeGanadoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="validator">The validator Object for this McgcatCompradoresdeGanadoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idComprador As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idComprador, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cabRegCom = New Integralab.ORM.CollectionClasses.CabRegComCollection(New CabRegComEntityFactory())
			_cabRegCom.SetContainingEntityInfo(Me, "McgcatCompradoresdeGanado")
			_alwaysFetchCabRegCom = False
			_alreadyFetchedCabRegCom = False
			_cabMovGanCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom = False
			_cabMovGanCollectionViaCabRegCom_ = New Integralab.ORM.CollectionClasses.CabMovGanCollection(New CabMovGanEntityFactory())
			_alwaysFetchCabMovGanCollectionViaCabRegCom_ = False
			_alreadyFetchedCabMovGanCollectionViaCabRegCom_ = False
			_catLugaresDeCompraCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(New CatLugaresDeCompraEntityFactory())
			_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = False
			_alreadyFetchedCatLugaresDeCompraCollectionViaCabRegCom = False
			_proveedorCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaCabRegCom = False
			_alreadyFetchedProveedorCollectionViaCabRegCom = False
			_mcecatCorralesCabCollectionViaCabRegCom = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = False
			_alreadyFetchedMcecatCorralesCabCollectionViaCabRegCom = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdComprador", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoPaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoMaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CalleyNumero", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PagarComision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComisionxCabeza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCuentaContable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComisionXkilo", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", McgcatCompradoresdeGanadoEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, signalRelatedEntity, "McgcatCompradoresdeGanado", resetFKFields, New Integer() { CInt(McgcatCompradoresdeGanadoFieldIndex.IdCuentaContable) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", McgcatCompradoresdeGanadoEntity.Relations.CuentaContableEntityUsingIdCuentaContable, True, _alreadyFetchedCuentaContable, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaContablePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idComprador">PK value for McgcatCompradoresdeGanado which data should be fetched into this McgcatCompradoresdeGanado Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idComprador As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McgcatCompradoresdeGanadoFieldIndex.IdComprador)).ForcedCurrentValueWrite(idComprador)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcgcatCompradoresdeGanadoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McgcatCompradoresdeGanadoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McgcatCompradoresdeGanadoRelations
			Get	
				Return New McgcatCompradoresdeGanadoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabRegCom' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabRegCom() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabRegComCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabRegComEntity, Integer), 0, Nothing, Nothing, Nothing, "CabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanado)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabMovGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabMovGanCollectionViaCabRegCom_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CabMovGanEntityUsingFolioMovimientoGanadoCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabMovGanCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CabMovGanEntity, Integer), 0, Nothing, Nothing, relations, "CabMovGanCollectionViaCabRegCom_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatLugaresDeCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatLugaresDeCompraCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.CatLugaresDeCompraEntityUsingCveLugCom)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CatLugaresDeCompraEntity, Integer), 0, Nothing, Nothing, relations, "CatLugaresDeCompraCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.ProveedorEntityUsingCveProveGan)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaCabRegCom() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, "__McgcatCompradoresdeGanadoEntity__", String.Empty, JoinHint.None)
				relations.Add(CabRegComEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CabRegComEntityUsingCveComiGan, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaCabRegCom", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					McgcatCompradoresdeGanadoEntity.Relations.CuentaContableEntityUsingIdCuentaContable, _
					CType(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McgcatCompradoresdeGanadoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McgcatCompradoresdeGanadoEntity.CustomProperties
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
				Return McgcatCompradoresdeGanadoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdComprador property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."IdComprador"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdComprador]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdComprador, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdComprador, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombre property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Nombre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Nombre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Nombre, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoPaterno property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."ApellidoPaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoPaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ApellidoPaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ApellidoPaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoMaterno property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."ApellidoMaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoMaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ApellidoMaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ApellidoMaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."RFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The CalleyNumero property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."CalleyNumero"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CalleyNumero]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.CalleyNumero, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.CalleyNumero, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."Colonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEstado property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The PagarComision property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."PagarComision"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PagarComision]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.PagarComision, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.PagarComision, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComisionxCabeza property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."ComisionxCabeza"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ComisionxCabeza]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ComisionxCabeza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ComisionxCabeza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.FechaBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCuentaContable property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."IdCuentaContable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCuentaContable]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdCuentaContable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.IdCuentaContable, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComisionXkilo property of the Entity McgcatCompradoresdeGanado<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatCompradoresdeGanado"."ComisionXKilo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 3, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ComisionXkilo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ComisionXkilo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McgcatCompradoresdeGanadoFieldIndex.ComisionXkilo, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabRegComEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabRegCom]() As Integralab.ORM.CollectionClasses.CabRegComCollection
			Get
				Return GetMultiCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabRegCom. When set to true, CabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabRegCom As Boolean
			Get
				Return _alwaysFetchCabRegCom
			End Get
			Set
				_alwaysFetchCabRegCom = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom. When set to true, CabMovGanCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CabMovGanEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabMovGanCollectionViaCabRegCom_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabMovGanCollectionViaCabRegCom_]() As Integralab.ORM.CollectionClasses.CabMovGanCollection
			Get
				Return GetMultiCabMovGanCollectionViaCabRegCom_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabMovGanCollectionViaCabRegCom_. When set to true, CabMovGanCollectionViaCabRegCom_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabMovGanCollectionViaCabRegCom_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabMovGanCollectionViaCabRegCom_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabMovGanCollectionViaCabRegCom_ As Boolean
			Get
				Return _alwaysFetchCabMovGanCollectionViaCabRegCom_
			End Get
			Set
				_alwaysFetchCabMovGanCollectionViaCabRegCom_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CatLugaresDeCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCatLugaresDeCompraCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CatLugaresDeCompraCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.CatLugaresDeCompraCollection
			Get
				Return GetMultiCatLugaresDeCompraCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatLugaresDeCompraCollectionViaCabRegCom. When set to true, CatLugaresDeCompraCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatLugaresDeCompraCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiCatLugaresDeCompraCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatLugaresDeCompraCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchCatLugaresDeCompraCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaCabRegCom. When set to true, ProveedorCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchProveedorCollectionViaCabRegCom = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaCabRegCom()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaCabRegCom]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaCabRegCom(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaCabRegCom. When set to true, McecatCorralesCabCollectionViaCabRegCom is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaCabRegCom is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaCabRegCom(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaCabRegCom As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaCabRegCom
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaCabRegCom = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaContable()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaContable]() As CuentaContableEntity
			Get
				Return GetSingleCuentaContable(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaContable(value)
				Else
					If value Is Nothing Then
						If Not _cuentaContable Is Nothing Then
							_cuentaContable.UnsetRelatedEntity(Me, "McgcatCompradoresdeGanado")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McgcatCompradoresdeGanado")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable. When set to true, CuentaContable is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaContable(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable As Boolean
			Get
				Return _alwaysFetchCuentaContable
			End Get
			Set
				_alwaysFetchCuentaContable = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaContable is not found
		''' in the database. When set to true, CuentaContable will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaContableReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaContableReturnsNewIfNotFound
			End Get
			Set
				_cuentaContableReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.McgcatCompradoresdeGanadoEntity)
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
