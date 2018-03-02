﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:32
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
	''' <summary>Entity class which represents the entity 'AplicMediDetDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AplicMediDetDetEntity 
#Else
	<Serializable()> _
	Public Class AplicMediDetDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _aplicMedi As AplicMediEntity
		Private _alwaysFetchAplicMedi, _alreadyFetchedAplicMedi, _aplicMediReturnsNewIfNotFound As Boolean
		Private _aplicMediDet As AplicMediDetEntity
		Private _alwaysFetchAplicMediDet, _alreadyFetchedAplicMediDet, _aplicMediDetReturnsNewIfNotFound As Boolean
		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _mcecatCorralesCab As McecatCorralesCabEntity
		Private _alwaysFetchMcecatCorralesCab, _alreadyFetchedMcecatCorralesCab, _mcecatCorralesCabReturnsNewIfNotFound As Boolean
		Private _mcecatLotesCab As McecatLotesCabEntity
		Private _alwaysFetchMcecatLotesCab, _alreadyFetchedMcecatLotesCab, _mcecatLotesCabReturnsNewIfNotFound As Boolean


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
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="validator">The custom validator Object for this AplicMediDetDetEntity</param>
		Public Sub New(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, validator As IValidator)

			InitClassFetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_aplicMedi = CType(info.GetValue("_aplicMedi", GetType(AplicMediEntity)), AplicMediEntity)
			If Not _aplicMedi Is Nothing Then
				AddHandler _aplicMedi.AfterSave, AddressOf OnEntityAfterSave
			End If
			_aplicMediReturnsNewIfNotFound = info.GetBoolean("_aplicMediReturnsNewIfNotFound")
			_alwaysFetchAplicMedi = info.GetBoolean("_alwaysFetchAplicMedi")
			_alreadyFetchedAplicMedi = info.GetBoolean("_alreadyFetchedAplicMedi")
			_aplicMediDet = CType(info.GetValue("_aplicMediDet", GetType(AplicMediDetEntity)), AplicMediDetEntity)
			If Not _aplicMediDet Is Nothing Then
				AddHandler _aplicMediDet.AfterSave, AddressOf OnEntityAfterSave
			End If
			_aplicMediDetReturnsNewIfNotFound = info.GetBoolean("_aplicMediDetReturnsNewIfNotFound")
			_alwaysFetchAplicMediDet = info.GetBoolean("_alwaysFetchAplicMediDet")
			_alreadyFetchedAplicMediDet = info.GetBoolean("_alreadyFetchedAplicMediDet")
			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_mcecatCorralesCab = CType(info.GetValue("_mcecatCorralesCab", GetType(McecatCorralesCabEntity)), McecatCorralesCabEntity)
			If Not _mcecatCorralesCab Is Nothing Then
				AddHandler _mcecatCorralesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatCorralesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatCorralesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatCorralesCab = info.GetBoolean("_alwaysFetchMcecatCorralesCab")
			_alreadyFetchedMcecatCorralesCab = info.GetBoolean("_alreadyFetchedMcecatCorralesCab")
			_mcecatLotesCab = CType(info.GetValue("_mcecatLotesCab", GetType(McecatLotesCabEntity)), McecatLotesCabEntity)
			If Not _mcecatLotesCab Is Nothing Then
				AddHandler _mcecatLotesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcecatLotesCabReturnsNewIfNotFound = info.GetBoolean("_mcecatLotesCabReturnsNewIfNotFound")
			_alwaysFetchMcecatLotesCab = info.GetBoolean("_alwaysFetchMcecatLotesCab")
			_alreadyFetchedMcecatLotesCab = info.GetBoolean("_alreadyFetchedMcecatLotesCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedAplicMedi = Not(_aplicMedi Is Nothing)
			_alreadyFetchedAplicMediDet = Not(_aplicMediDet Is Nothing)
			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedMcecatCorralesCab = Not(_mcecatCorralesCab Is Nothing)
			_alreadyFetchedMcecatLotesCab = Not(_mcecatLotesCab Is Nothing)

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


			info.AddValue("_aplicMedi", _aplicMedi)
			info.AddValue("_aplicMediReturnsNewIfNotFound", _aplicMediReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAplicMedi", _alwaysFetchAplicMedi)
			info.AddValue("_alreadyFetchedAplicMedi", _alreadyFetchedAplicMedi)
			info.AddValue("_aplicMediDet", _aplicMediDet)
			info.AddValue("_aplicMediDetReturnsNewIfNotFound", _aplicMediDetReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAplicMediDet", _alwaysFetchAplicMediDet)
			info.AddValue("_alreadyFetchedAplicMediDet", _alreadyFetchedAplicMediDet)
			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_mcecatCorralesCab", _mcecatCorralesCab)
			info.AddValue("_mcecatCorralesCabReturnsNewIfNotFound", _mcecatCorralesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatCorralesCab", _alwaysFetchMcecatCorralesCab)
			info.AddValue("_alreadyFetchedMcecatCorralesCab", _alreadyFetchedMcecatCorralesCab)
			info.AddValue("_mcecatLotesCab", _mcecatLotesCab)
			info.AddValue("_mcecatLotesCabReturnsNewIfNotFound", _mcecatLotesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcecatLotesCab", _alwaysFetchMcecatLotesCab)
			info.AddValue("_alreadyFetchedMcecatLotesCab", _alreadyFetchedMcecatLotesCab)

			
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
				Case "AplicMedi"
					_alreadyFetchedAplicMedi = True
					Me.AplicMedi = CType(entity, AplicMediEntity)
				Case "AplicMediDet"
					_alreadyFetchedAplicMediDet = True
					Me.AplicMediDet = CType(entity, AplicMediDetEntity)
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "McecatCorralesCab"
					_alreadyFetchedMcecatCorralesCab = True
					Me.McecatCorralesCab = CType(entity, McecatCorralesCabEntity)
				Case "McecatLotesCab"
					_alreadyFetchedMcecatLotesCab = True
					Me.McecatLotesCab = CType(entity, McecatLotesCabEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "AplicMedi"
					SetupSyncAplicMedi(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AplicMediDet"
					SetupSyncAplicMediDet(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					SetupSyncMcecatCorralesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McecatLotesCab"
					SetupSyncMcecatLotesCab(relatedEntity)
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
				Case "AplicMedi"
					DesetupSyncAplicMedi(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AplicMediDet"
					DesetupSyncAplicMediDet(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatCorralesCab"
					DesetupSyncMcecatCorralesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McecatLotesCab"
					DesetupSyncMcecatLotesCab(False, True)
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
			If Not _aplicMedi Is Nothing Then
				toReturn.Add(_aplicMedi)
			End If
			If Not _aplicMediDet Is Nothing Then
				toReturn.Add(_aplicMediDet)
			End If
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If
			If Not _mcecatCorralesCab Is Nothing Then
				toReturn.Add(_mcecatCorralesCab)
			End If
			If Not _mcecatLotesCab Is Nothing Then
				toReturn.Add(_mcecatLotesCab)
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
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String) As Boolean
			Return FetchUsingPK(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioAplicacionMedicamento, Me.IdLote, Me.IdMedicamento, Me.IdCorral, Me.AretePropio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As AplicMediDetDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As AplicMediDetDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'AplicMediEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AplicMediEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMedi() As AplicMediEntity
			Return GetSingleAplicMedi(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AplicMediEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AplicMediEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMedi(forceFetch As Boolean) As AplicMediEntity
			If ( Not _alreadyFetchedAplicMedi Or forceFetch Or _alwaysFetchAplicMedi) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AplicMediEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioAplicacionMedicamento)
				End If
				If Not _aplicMediReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.AplicMedi = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AplicMediEntity)
					End If
					Me.AplicMedi = newEntity
					_alreadyFetchedAplicMedi = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _aplicMedi
		End Function
	
		''' <summary>Retrieves the related entity of type 'AplicMediDetEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AplicMediDetEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMediDet() As AplicMediDetEntity
			Return GetSingleAplicMediDet(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AplicMediDetEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AplicMediDetEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAplicMediDet(forceFetch As Boolean) As AplicMediDetEntity
			If ( Not _alreadyFetchedAplicMediDet Or forceFetch Or _alwaysFetchAplicMediDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AplicMediDetEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioAplicacionMedicamento, Me.IdLote, Me.IdMedicamento, Me.IdCorral)
				End If
				If Not _aplicMediDetReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.AplicMediDet = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AplicMediDetEntity)
					End If
					Me.AplicMediDet = newEntity
					_alreadyFetchedAplicMediDet = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _aplicMediDet
		End Function
	
		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto() As ProductoEntity
			Return GetSingleProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdMedicamento)
				End If
				If Not _productoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto = newEntity
					_alreadyFetchedProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab() As McecatCorralesCabEntity
			Return GetSingleMcecatCorralesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatCorralesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatCorralesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatCorralesCab(forceFetch As Boolean) As McecatCorralesCabEntity
			If ( Not _alreadyFetchedMcecatCorralesCab Or forceFetch Or _alwaysFetchMcecatCorralesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatCorralesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCorral)
				End If
				If Not _mcecatCorralesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatCorralesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatCorralesCabEntity)
					End If
					Me.McecatCorralesCab = newEntity
					_alreadyFetchedMcecatCorralesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatCorralesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab() As McecatLotesCabEntity
			Return GetSingleMcecatLotesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McecatLotesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McecatLotesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcecatLotesCab(forceFetch As Boolean) As McecatLotesCabEntity
			If ( Not _alreadyFetchedMcecatLotesCab Or forceFetch Or _alwaysFetchMcecatLotesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McecatLotesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdLote)
				End If
				If Not _mcecatLotesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McecatLotesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McecatLotesCabEntity)
					End If
					Me.McecatLotesCab = newEntity
					_alreadyFetchedMcecatLotesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcecatLotesCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(AplicMediDetDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, AplicMediDetDetFieldIndex)
					Case AplicMediDetDetFieldIndex.FolioAplicacionMedicamento
						DesetupSyncAplicMedi(True, False)
						_alreadyFetchedAplicMedi = False
						DesetupSyncAplicMediDet(True, False)
						_alreadyFetchedAplicMediDet = False
					Case AplicMediDetDetFieldIndex.IdLote
						DesetupSyncAplicMediDet(True, False)
						_alreadyFetchedAplicMediDet = False
						DesetupSyncMcecatLotesCab(True, False)
						_alreadyFetchedMcecatLotesCab = False
					Case AplicMediDetDetFieldIndex.IdMedicamento
						DesetupSyncAplicMediDet(True, False)
						_alreadyFetchedAplicMediDet = False
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False
					Case AplicMediDetDetFieldIndex.IdCorral
						DesetupSyncAplicMediDet(True, False)
						_alreadyFetchedAplicMediDet = False
						DesetupSyncMcecatCorralesCab(True, False)
						_alreadyFetchedMcecatCorralesCab = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _aplicMedi Is Nothing Then
				_aplicMedi.ActiveContext = MyBase.ActiveContext
			End If
		If Not _aplicMediDet Is Nothing Then
				_aplicMediDet.ActiveContext = MyBase.ActiveContext
			End If
		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatCorralesCab Is Nothing Then
				_mcecatCorralesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcecatLotesCab Is Nothing Then
				_mcecatLotesCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As AplicMediDetDetDAO = CType(CreateDAOInstance(), AplicMediDetDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As AplicMediDetDetDAO = CType(CreateDAOInstance(), AplicMediDetDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As AplicMediDetDetDAO = CType(CreateDAOInstance(), AplicMediDetDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this AplicMediDetDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AplicMediDetDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="validator">The validator Object for this AplicMediDetDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_aplicMedi = Nothing
			_aplicMediReturnsNewIfNotFound = True
			_alwaysFetchAplicMedi = False
			_alreadyFetchedAplicMedi = False
			_aplicMediDet = Nothing
			_aplicMediDetReturnsNewIfNotFound = True
			_alwaysFetchAplicMediDet = False
			_alreadyFetchedAplicMediDet = False
			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_mcecatCorralesCab = Nothing
			_mcecatCorralesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatCorralesCab = False
			_alreadyFetchedMcecatCorralesCab = False
			_mcecatLotesCab = Nothing
			_mcecatLotesCabReturnsNewIfNotFound = True
			_alwaysFetchMcecatLotesCab = False
			_alreadyFetchedMcecatLotesCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioAplicacionMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdLote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCorral", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AretePropio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _aplicMedi</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAplicMedi(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _aplicMedi, AddressOf OnAplicMediPropertyChanged, "AplicMedi", AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, True, signalRelatedEntity, "AplicMediDetDet", resetFKFields, New Integer() { CInt(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento) } )
			_aplicMedi = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _aplicMedi</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAplicMedi(relatedEntity As IEntity)
			DesetupSyncAplicMedi(True, True)
			_aplicMedi = CType(relatedEntity, AplicMediEntity)
			MyBase.PerformSetupSyncRelatedEntity( _aplicMedi, AddressOf OnAplicMediPropertyChanged, "AplicMedi", AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, True, _alreadyFetchedAplicMedi, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAplicMediPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _aplicMediDet</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAplicMediDet(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _aplicMediDet, AddressOf OnAplicMediDetPropertyChanged, "AplicMediDet", AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, True, signalRelatedEntity, "AplicMediDetDet", resetFKFields, New Integer() { CInt(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento), CInt(AplicMediDetDetFieldIndex.IdLote), CInt(AplicMediDetDetFieldIndex.IdMedicamento), CInt(AplicMediDetDetFieldIndex.IdCorral) } )
			_aplicMediDet = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _aplicMediDet</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAplicMediDet(relatedEntity As IEntity)
			DesetupSyncAplicMediDet(True, True)
			_aplicMediDet = CType(relatedEntity, AplicMediDetEntity)
			MyBase.PerformSetupSyncRelatedEntity( _aplicMediDet, AddressOf OnAplicMediDetPropertyChanged, "AplicMediDet", AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, True, _alreadyFetchedAplicMediDet, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAplicMediDetPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, True, signalRelatedEntity, "AplicMediDetDet", resetFKFields, New Integer() { CInt(AplicMediDetDetFieldIndex.IdMedicamento) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, True, _alreadyFetchedProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatCorralesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, signalRelatedEntity, "AplicMediDetDet", resetFKFields, New Integer() { CInt(AplicMediDetDetFieldIndex.IdCorral) } )
			_mcecatCorralesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatCorralesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatCorralesCab(relatedEntity As IEntity)
			DesetupSyncMcecatCorralesCab(True, True)
			_mcecatCorralesCab = CType(relatedEntity, McecatCorralesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatCorralesCab, AddressOf OnMcecatCorralesCabPropertyChanged, "McecatCorralesCab", AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, True, _alreadyFetchedMcecatCorralesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatCorralesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcecatLotesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcecatLotesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, True, signalRelatedEntity, "AplicMediDetDet", resetFKFields, New Integer() { CInt(AplicMediDetDetFieldIndex.IdLote) } )
			_mcecatLotesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcecatLotesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcecatLotesCab(relatedEntity As IEntity)
			DesetupSyncMcecatLotesCab(True, True)
			_mcecatLotesCab = CType(relatedEntity, McecatLotesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcecatLotesCab, AddressOf OnMcecatLotesCabPropertyChanged, "McecatLotesCab", AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, True, _alreadyFetchedMcecatLotesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcecatLotesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioAplicacionMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idLote">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idMedicamento">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="idCorral">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="aretePropio">PK value for AplicMediDetDet which data should be fetched into this AplicMediDetDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioAplicacionMedicamento As System.String, idLote As System.Int32, idMedicamento As System.Int32, idCorral As System.String, aretePropio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento)).ForcedCurrentValueWrite(folioAplicacionMedicamento)
				MyBase.Fields(CInt(AplicMediDetDetFieldIndex.IdLote)).ForcedCurrentValueWrite(idLote)
				MyBase.Fields(CInt(AplicMediDetDetFieldIndex.IdMedicamento)).ForcedCurrentValueWrite(idMedicamento)
				MyBase.Fields(CInt(AplicMediDetDetFieldIndex.IdCorral)).ForcedCurrentValueWrite(idCorral)
				MyBase.Fields(CInt(AplicMediDetDetFieldIndex.AretePropio)).ForcedCurrentValueWrite(aretePropio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAplicMediDetDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New AplicMediDetDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As AplicMediDetDetRelations
			Get	
				Return New AplicMediDetDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMedi' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMedi() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediCollection(), _
					AplicMediDetDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMedi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AplicMediDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAplicMediDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AplicMediDetCollection(), _
					AplicMediDetDetEntity.Relations.AplicMediDetEntityUsingFolioAplicacionMedicamentoIdLoteIdMedicamentoIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), CType(Integralab.ORM.EntityType.AplicMediDetEntity, Integer), 0, Nothing, Nothing, Nothing, "AplicMediDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					AplicMediDetDetEntity.Relations.ProductoEntityUsingIdMedicamento, _
					CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					AplicMediDetDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral, _
					CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatCorralesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					AplicMediDetDetEntity.Relations.McecatLotesCabEntityUsingIdLote, _
					CType(Integralab.ORM.EntityType.AplicMediDetDetEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "McecatLotesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "AplicMediDetDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return AplicMediDetDetEntity.CustomProperties
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
				Return AplicMediDetDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioAplicacionMedicamento property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."FolioAplicacionMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioAplicacionMedicamento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.FolioAplicacionMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdLote property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."IdLote"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdLote]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.IdLote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.IdLote, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMedicamento property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."IdMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdMedicamento]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.IdMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.IdMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCorral property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."IdCorral"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdCorral]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.IdCorral, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.IdCorral, Integer), value)
			End Set
		End Property
	
		''' <summary>The AretePropio property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."AretePropio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [AretePropio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.AretePropio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.AretePropio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."Cantidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.Cantidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Costo property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."Costo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Costo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.Costo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.Costo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.Kilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity AplicMediDetDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AplicMediDetDet"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AplicMediDetDetFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AplicMediDetDetFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'AplicMediEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAplicMedi()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [AplicMedi]() As AplicMediEntity
			Get
				Return GetSingleAplicMedi(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAplicMedi(value)
				Else
					If value Is Nothing Then
						If Not _aplicMedi Is Nothing Then
							_aplicMedi.UnsetRelatedEntity(Me, "AplicMediDetDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDetDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMedi. When set to true, AplicMedi is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMedi is accessed. You can always execute
		''' a forced fetch by calling GetSingleAplicMedi(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMedi As Boolean
			Get
				Return _alwaysFetchAplicMedi
			End Get
			Set
				_alwaysFetchAplicMedi = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property AplicMedi is not found
		''' in the database. When set to true, AplicMedi will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AplicMediReturnsNewIfNotFound As Boolean
			Get
				Return _aplicMediReturnsNewIfNotFound
			End Get
			Set
				_aplicMediReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'AplicMediDetEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAplicMediDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [AplicMediDet]() As AplicMediDetEntity
			Get
				Return GetSingleAplicMediDet(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAplicMediDet(value)
				Else
					If value Is Nothing Then
						If Not _aplicMediDet Is Nothing Then
							_aplicMediDet.UnsetRelatedEntity(Me, "AplicMediDetDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDetDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for AplicMediDet. When set to true, AplicMediDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AplicMediDet is accessed. You can always execute
		''' a forced fetch by calling GetSingleAplicMediDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAplicMediDet As Boolean
			Get
				Return _alwaysFetchAplicMediDet
			End Get
			Set
				_alwaysFetchAplicMediDet = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property AplicMediDet is not found
		''' in the database. When set to true, AplicMediDet will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AplicMediDetReturnsNewIfNotFound As Boolean
			Get
				Return _aplicMediDetReturnsNewIfNotFound
			End Get
			Set
				_aplicMediDetReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto]() As ProductoEntity
			Get
				Return GetSingleProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto(value)
				Else
					If value Is Nothing Then
						If Not _producto Is Nothing Then
							_producto.UnsetRelatedEntity(Me, "AplicMediDetDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDetDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto is not found
		''' in the database. When set to true, Producto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProductoReturnsNewIfNotFound As Boolean
			Get
				Return _productoReturnsNewIfNotFound
			End Get
			Set
				_productoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatCorralesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatCorralesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatCorralesCab]() As McecatCorralesCabEntity
			Get
				Return GetSingleMcecatCorralesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatCorralesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatCorralesCab Is Nothing Then
							_mcecatCorralesCab.UnsetRelatedEntity(Me, "AplicMediDetDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDetDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCab. When set to true, McecatCorralesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatCorralesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCab As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCab
			End Get
			Set
				_alwaysFetchMcecatCorralesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatCorralesCab is not found
		''' in the database. When set to true, McecatCorralesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatCorralesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatCorralesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatCorralesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McecatLotesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcecatLotesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McecatLotesCab]() As McecatLotesCabEntity
			Get
				Return GetSingleMcecatLotesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcecatLotesCab(value)
				Else
					If value Is Nothing Then
						If Not _mcecatLotesCab Is Nothing Then
							_mcecatLotesCab.UnsetRelatedEntity(Me, "AplicMediDetDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AplicMediDetDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCab. When set to true, McecatLotesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcecatLotesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCab As Boolean
			Get
				Return _alwaysFetchMcecatLotesCab
			End Get
			Set
				_alwaysFetchMcecatLotesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McecatLotesCab is not found
		''' in the database. When set to true, McecatLotesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McecatLotesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mcecatLotesCabReturnsNewIfNotFound
			End Get
			Set
				_mcecatLotesCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.AplicMediDetDetEntity)
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
