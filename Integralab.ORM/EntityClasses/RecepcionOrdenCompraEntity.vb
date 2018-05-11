﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:30
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
	''' <summary>Entity class which represents the entity 'RecepcionOrdenCompra'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class RecepcionOrdenCompraEntity 
#Else
	<Serializable()> _
	Public Class RecepcionOrdenCompraEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mcomRecepcionOrdenCompraDet As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
		Private _alwaysFetchMcomRecepcionOrdenCompraDet, _alreadyFetchedMcomRecepcionOrdenCompraDet As Boolean
		Private _usrCxpfacturasDetRecepciones As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
		Private _alwaysFetchUsrCxpfacturasDetRecepciones, _alreadyFetchedUsrCxpfacturasDetRecepciones As Boolean

		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _motivoCancelacion As MotivoCancelacionEntity
		Private _alwaysFetchMotivoCancelacion, _alreadyFetchedMotivoCancelacion, _motivoCancelacionReturnsNewIfNotFound As Boolean
		Private _sucursal As SucursalEntity
		Private _alwaysFetchSucursal, _alreadyFetchedSucursal, _sucursalReturnsNewIfNotFound As Boolean
		Private _ordenCompra As OrdenCompraEntity
		Private _alwaysFetchOrdenCompra, _alreadyFetchedOrdenCompra, _ordenCompraReturnsNewIfNotFound As Boolean


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
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		Public Sub New(idRecepcionOrdenCompra As System.Int32)

			InitClassFetch(idRecepcionOrdenCompra, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idRecepcionOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idRecepcionOrdenCompra, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="validator">The custom validator Object for this RecepcionOrdenCompraEntity</param>
		Public Sub New(idRecepcionOrdenCompra As System.Int32, validator As IValidator)

			InitClassFetch(idRecepcionOrdenCompra, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mcomRecepcionOrdenCompraDet = CType(info.GetValue("_mcomRecepcionOrdenCompraDet", GetType(Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection)), Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection)
			_alwaysFetchMcomRecepcionOrdenCompraDet = info.GetBoolean("_alwaysFetchMcomRecepcionOrdenCompraDet")
			_alreadyFetchedMcomRecepcionOrdenCompraDet = info.GetBoolean("_alreadyFetchedMcomRecepcionOrdenCompraDet")
			_usrCxpfacturasDetRecepciones = CType(info.GetValue("_usrCxpfacturasDetRecepciones", GetType(Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection)), Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection)
			_alwaysFetchUsrCxpfacturasDetRecepciones = info.GetBoolean("_alwaysFetchUsrCxpfacturasDetRecepciones")
			_alreadyFetchedUsrCxpfacturasDetRecepciones = info.GetBoolean("_alreadyFetchedUsrCxpfacturasDetRecepciones")

			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_motivoCancelacion = CType(info.GetValue("_motivoCancelacion", GetType(MotivoCancelacionEntity)), MotivoCancelacionEntity)
			If Not _motivoCancelacion Is Nothing Then
				AddHandler _motivoCancelacion.AfterSave, AddressOf OnEntityAfterSave
			End If
			_motivoCancelacionReturnsNewIfNotFound = info.GetBoolean("_motivoCancelacionReturnsNewIfNotFound")
			_alwaysFetchMotivoCancelacion = info.GetBoolean("_alwaysFetchMotivoCancelacion")
			_alreadyFetchedMotivoCancelacion = info.GetBoolean("_alreadyFetchedMotivoCancelacion")
			_sucursal = CType(info.GetValue("_sucursal", GetType(SucursalEntity)), SucursalEntity)
			If Not _sucursal Is Nothing Then
				AddHandler _sucursal.AfterSave, AddressOf OnEntityAfterSave
			End If
			_sucursalReturnsNewIfNotFound = info.GetBoolean("_sucursalReturnsNewIfNotFound")
			_alwaysFetchSucursal = info.GetBoolean("_alwaysFetchSucursal")
			_alreadyFetchedSucursal = info.GetBoolean("_alreadyFetchedSucursal")
			_ordenCompra = CType(info.GetValue("_ordenCompra", GetType(OrdenCompraEntity)), OrdenCompraEntity)
			If Not _ordenCompra Is Nothing Then
				AddHandler _ordenCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_ordenCompraReturnsNewIfNotFound = info.GetBoolean("_ordenCompraReturnsNewIfNotFound")
			_alwaysFetchOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompra")
			_alreadyFetchedOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompra")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMcomRecepcionOrdenCompraDet = (_mcomRecepcionOrdenCompraDet.Count > 0)
			_alreadyFetchedUsrCxpfacturasDetRecepciones = (_usrCxpfacturasDetRecepciones.Count > 0)

			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedMotivoCancelacion = Not(_motivoCancelacion Is Nothing)
			_alreadyFetchedSucursal = Not(_sucursal Is Nothing)
			_alreadyFetchedOrdenCompra = Not(_ordenCompra Is Nothing)

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
			info.AddValue("_mcomRecepcionOrdenCompraDet", _mcomRecepcionOrdenCompraDet)
			info.AddValue("_alwaysFetchMcomRecepcionOrdenCompraDet", _alwaysFetchMcomRecepcionOrdenCompraDet)
			info.AddValue("_alreadyFetchedMcomRecepcionOrdenCompraDet", _alreadyFetchedMcomRecepcionOrdenCompraDet)
			info.AddValue("_usrCxpfacturasDetRecepciones", _usrCxpfacturasDetRecepciones)
			info.AddValue("_alwaysFetchUsrCxpfacturasDetRecepciones", _alwaysFetchUsrCxpfacturasDetRecepciones)
			info.AddValue("_alreadyFetchedUsrCxpfacturasDetRecepciones", _alreadyFetchedUsrCxpfacturasDetRecepciones)

			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_motivoCancelacion", _motivoCancelacion)
			info.AddValue("_motivoCancelacionReturnsNewIfNotFound", _motivoCancelacionReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMotivoCancelacion", _alwaysFetchMotivoCancelacion)
			info.AddValue("_alreadyFetchedMotivoCancelacion", _alreadyFetchedMotivoCancelacion)
			info.AddValue("_sucursal", _sucursal)
			info.AddValue("_sucursalReturnsNewIfNotFound", _sucursalReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSucursal", _alwaysFetchSucursal)
			info.AddValue("_alreadyFetchedSucursal", _alreadyFetchedSucursal)
			info.AddValue("_ordenCompra", _ordenCompra)
			info.AddValue("_ordenCompraReturnsNewIfNotFound", _ordenCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchOrdenCompra", _alwaysFetchOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompra", _alreadyFetchedOrdenCompra)

			
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
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case "MotivoCancelacion"
					_alreadyFetchedMotivoCancelacion = True
					Me.MotivoCancelacion = CType(entity, MotivoCancelacionEntity)
				Case "Sucursal"
					_alreadyFetchedSucursal = True
					Me.Sucursal = CType(entity, SucursalEntity)
				Case "OrdenCompra"
					_alreadyFetchedOrdenCompra = True
					Me.OrdenCompra = CType(entity, OrdenCompraEntity)
				Case "McomRecepcionOrdenCompraDet"
					_alreadyFetchedMcomRecepcionOrdenCompraDet = True
					If Not entity Is Nothing Then
						Me.McomRecepcionOrdenCompraDet.Add(CType(entity, McomRecepcionOrdenCompraDetEntity))
					End If
				Case "UsrCxpfacturasDetRecepciones"
					_alreadyFetchedUsrCxpfacturasDetRecepciones = True
					If Not entity Is Nothing Then
						Me.UsrCxpfacturasDetRecepciones.Add(CType(entity, UsrCxpfacturasDetRecepcionesEntity))
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
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MotivoCancelacion"
					SetupSyncMotivoCancelacion(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Sucursal"
					SetupSyncSucursal(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompra"
					SetupSyncOrdenCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomRecepcionOrdenCompraDet"
					_mcomRecepcionOrdenCompraDet.Add(CType(relatedEntity, McomRecepcionOrdenCompraDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCxpfacturasDetRecepciones"
					_usrCxpfacturasDetRecepciones.Add(CType(relatedEntity, UsrCxpfacturasDetRecepcionesEntity))
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
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MotivoCancelacion"
					DesetupSyncMotivoCancelacion(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Sucursal"
					DesetupSyncSucursal(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompra"
					DesetupSyncOrdenCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomRecepcionOrdenCompraDet"
					MyBase.PerformRelatedEntityRemoval(_mcomRecepcionOrdenCompraDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCxpfacturasDetRecepciones"
					MyBase.PerformRelatedEntityRemoval(_usrCxpfacturasDetRecepciones, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
			End If
			If Not _motivoCancelacion Is Nothing Then
				toReturn.Add(_motivoCancelacion)
			End If
			If Not _sucursal Is Nothing Then
				toReturn.Add(_sucursal)
			End If
			If Not _ordenCompra Is Nothing Then
				toReturn.Add(_ordenCompra)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mcomRecepcionOrdenCompraDet)
			toReturn.Add(_usrCxpfacturasDetRecepciones)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idRecepcionOrdenCompra As System.Int32) As Boolean
			Return FetchUsingPK(idRecepcionOrdenCompra, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idRecepcionOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idRecepcionOrdenCompra, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idRecepcionOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idRecepcionOrdenCompra, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdRecepcionOrdenCompra, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As RecepcionOrdenCompraFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As RecepcionOrdenCompraFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomRecepcionOrdenCompraDetEntity'</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, _mcomRecepcionOrdenCompraDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomRecepcionOrdenCompraDetEntity'</returns>
		Public Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Return GetMultiMcomRecepcionOrdenCompraDet(forceFetch, _mcomRecepcionOrdenCompraDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomRecepcionOrdenCompraDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			If ( Not _alreadyFetchedMcomRecepcionOrdenCompraDet Or forceFetch Or _alwaysFetchMcomRecepcionOrdenCompraDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomRecepcionOrdenCompraDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomRecepcionOrdenCompraDet)
					End If
				End If
				_mcomRecepcionOrdenCompraDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomRecepcionOrdenCompraDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomRecepcionOrdenCompraDet.GetMultiManyToOne(Nothing, Me, Filter)
				_mcomRecepcionOrdenCompraDet.SuppressClearInGetMulti = False
				_alreadyFetchedMcomRecepcionOrdenCompraDet = True
			End If
			Return _mcomRecepcionOrdenCompraDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomRecepcionOrdenCompraDet'. These settings will be taken into account
		''' when the property McomRecepcionOrdenCompraDet is requested or GetMultiMcomRecepcionOrdenCompraDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomRecepcionOrdenCompraDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomRecepcionOrdenCompraDet.SortClauses=sortClauses
			_mcomRecepcionOrdenCompraDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetRecepcionesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetRecepcionesEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDetRecepciones(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
			Return GetMultiUsrCxpfacturasDetRecepciones(forceFetch, _usrCxpfacturasDetRecepciones.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetRecepcionesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCxpfacturasDetRecepciones(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
			Return GetMultiUsrCxpfacturasDetRecepciones(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetRecepcionesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrCxpfacturasDetRecepcionesEntity'</returns>
		Public Function GetMultiUsrCxpfacturasDetRecepciones(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
			Return GetMultiUsrCxpfacturasDetRecepciones(forceFetch, _usrCxpfacturasDetRecepciones.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetRecepcionesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCxpfacturasDetRecepciones(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
			If ( Not _alreadyFetchedUsrCxpfacturasDetRecepciones Or forceFetch Or _alwaysFetchUsrCxpfacturasDetRecepciones) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCxpfacturasDetRecepciones.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCxpfacturasDetRecepciones)
					End If
				End If
				_usrCxpfacturasDetRecepciones.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCxpfacturasDetRecepciones.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCxpfacturasDetRecepciones.GetMultiManyToOne(Me, Nothing, Filter)
				_usrCxpfacturasDetRecepciones.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCxpfacturasDetRecepciones = True
			End If
			Return _usrCxpfacturasDetRecepciones
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCxpfacturasDetRecepciones'. These settings will be taken into account
		''' when the property UsrCxpfacturasDetRecepciones is requested or GetMultiUsrCxpfacturasDetRecepciones is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCxpfacturasDetRecepciones(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCxpfacturasDetRecepciones.SortClauses=sortClauses
			_usrCxpfacturasDetRecepciones.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen() As AlmacenEntity
			Return GetSingleAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId) Then
					fetchResult = newEntity.FetchUsingPK(Me.AlmacenId)
				End If
				If Not _almacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Almacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.Almacen = newEntity
					_alreadyFetchedAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacen
		End Function
	
		''' <summary>Retrieves the related entity of type 'MotivoCancelacionEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MotivoCancelacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoCancelacion() As MotivoCancelacionEntity
			Return GetSingleMotivoCancelacion(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MotivoCancelacionEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MotivoCancelacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoCancelacion(forceFetch As Boolean) As MotivoCancelacionEntity
			If ( Not _alreadyFetchedMotivoCancelacion Or forceFetch Or _alwaysFetchMotivoCancelacion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MotivoCancelacionEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId) Then
					fetchResult = newEntity.FetchUsingPK(Me.MotivoCancelacionId.GetValueOrDefault())
				End If
				If Not _motivoCancelacionReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MotivoCancelacion = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MotivoCancelacionEntity)
					End If
					Me.MotivoCancelacion = newEntity
					_alreadyFetchedMotivoCancelacion = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _motivoCancelacion
		End Function
	
		''' <summary>Retrieves the related entity of type 'SucursalEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SucursalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSucursal() As SucursalEntity
			Return GetSingleSucursal(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SucursalEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SucursalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSucursal(forceFetch As Boolean) As SucursalEntity
			If ( Not _alreadyFetchedSucursal Or forceFetch Or _alwaysFetchSucursal) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SucursalEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionOrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdSucursal)
				End If
				If Not _sucursalReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Sucursal = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SucursalEntity)
					End If
					Me.Sucursal = newEntity
					_alreadyFetchedSucursal = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _sucursal
		End Function
	
		''' <summary>Retrieves the related entity of type 'OrdenCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'OrdenCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleOrdenCompra() As OrdenCompraEntity
			Return GetSingleOrdenCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'OrdenCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'OrdenCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleOrdenCompra(forceFetch As Boolean) As OrdenCompraEntity
			If ( Not _alreadyFetchedOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New OrdenCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdOrdenCompra)
				End If
				If Not _ordenCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.OrdenCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), OrdenCompraEntity)
					End If
					Me.OrdenCompra = newEntity
					_alreadyFetchedOrdenCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _ordenCompra
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(RecepcionOrdenCompraFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, RecepcionOrdenCompraFieldIndex)

					Case RecepcionOrdenCompraFieldIndex.IdOrdenCompra
						DesetupSyncOrdenCompra(True, False)
						_alreadyFetchedOrdenCompra = False



					Case RecepcionOrdenCompraFieldIndex.AlmacenId
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False




					Case RecepcionOrdenCompraFieldIndex.MotivoCancelacionId
						DesetupSyncMotivoCancelacion(True, False)
						_alreadyFetchedMotivoCancelacion = False


					Case RecepcionOrdenCompraFieldIndex.IdSucursal
						DesetupSyncSucursal(True, False)
						_alreadyFetchedSucursal = False














					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mcomRecepcionOrdenCompraDet.ActiveContext = MyBase.ActiveContext
			_usrCxpfacturasDetRecepciones.ActiveContext = MyBase.ActiveContext

		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _motivoCancelacion Is Nothing Then
				_motivoCancelacion.ActiveContext = MyBase.ActiveContext
			End If
		If Not _sucursal Is Nothing Then
				_sucursal.ActiveContext = MyBase.ActiveContext
			End If
		If Not _ordenCompra Is Nothing Then
				_ordenCompra.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As RecepcionOrdenCompraDAO = CType(CreateDAOInstance(), RecepcionOrdenCompraDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As RecepcionOrdenCompraDAO = CType(CreateDAOInstance(), RecepcionOrdenCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As RecepcionOrdenCompraDAO = CType(CreateDAOInstance(), RecepcionOrdenCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this RecepcionOrdenCompraEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="validator">The validator Object for this RecepcionOrdenCompraEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idRecepcionOrdenCompra As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idRecepcionOrdenCompra, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mcomRecepcionOrdenCompraDet = New Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection(New McomRecepcionOrdenCompraDetEntityFactory())
			_mcomRecepcionOrdenCompraDet.SetContainingEntityInfo(Me, "RecepcionOrdenCompra")
			_alwaysFetchMcomRecepcionOrdenCompraDet = False
			_alreadyFetchedMcomRecepcionOrdenCompraDet = False
			_usrCxpfacturasDetRecepciones = New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection(New UsrCxpfacturasDetRecepcionesEntityFactory())
			_usrCxpfacturasDetRecepciones.SetContainingEntityInfo(Me, "RecepcionOrdenCompra_")
			_alwaysFetchUsrCxpfacturasDetRecepciones = False
			_alreadyFetchedUsrCxpfacturasDetRecepciones = False

			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_motivoCancelacion = Nothing
			_motivoCancelacionReturnsNewIfNotFound = True
			_alwaysFetchMotivoCancelacion = False
			_alreadyFetchedMotivoCancelacion = False
			_sucursal = Nothing
			_sucursalReturnsNewIfNotFound = True
			_alwaysFetchSucursal = False
			_alreadyFetchedSucursal = False
			_ordenCompra = Nothing
			_ordenCompraReturnsNewIfNotFound = True
			_alwaysFetchOrdenCompra = False
			_alreadyFetchedOrdenCompra = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdRecepcionOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAml", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaRecepcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmCan", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAltaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioCancelacionId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoCancelacionId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Facturada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioRecepcionOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsDirecta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("OrigenMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Ieps", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoRemision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Pagada", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId, True, signalRelatedEntity, "RecepcionOrdenCompra", resetFKFields, New Integer() { CInt(RecepcionOrdenCompraFieldIndex.AlmacenId) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId, True, _alreadyFetchedAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _motivoCancelacion</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMotivoCancelacion(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _motivoCancelacion, AddressOf OnMotivoCancelacionPropertyChanged, "MotivoCancelacion", RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, True, signalRelatedEntity, "RecepcionOrdenCompra", resetFKFields, New Integer() { CInt(RecepcionOrdenCompraFieldIndex.MotivoCancelacionId) } )
			_motivoCancelacion = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _motivoCancelacion</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMotivoCancelacion(relatedEntity As IEntity)
			DesetupSyncMotivoCancelacion(True, True)
			_motivoCancelacion = CType(relatedEntity, MotivoCancelacionEntity)
			MyBase.PerformSetupSyncRelatedEntity( _motivoCancelacion, AddressOf OnMotivoCancelacionPropertyChanged, "MotivoCancelacion", RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, True, _alreadyFetchedMotivoCancelacion, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMotivoCancelacionPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _sucursal</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSucursal(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", RecepcionOrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, signalRelatedEntity, "RecepcionOrdenCompra", resetFKFields, New Integer() { CInt(RecepcionOrdenCompraFieldIndex.IdSucursal) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", RecepcionOrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, _alreadyFetchedSucursal, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSucursalPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _ordenCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncOrdenCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _ordenCompra, AddressOf OnOrdenCompraPropertyChanged, "OrdenCompra", RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, True, signalRelatedEntity, "RecepcionOrdenCompra", resetFKFields, New Integer() { CInt(RecepcionOrdenCompraFieldIndex.IdOrdenCompra) } )
			_ordenCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _ordenCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncOrdenCompra(relatedEntity As IEntity)
			DesetupSyncOrdenCompra(True, True)
			_ordenCompra = CType(relatedEntity, OrdenCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _ordenCompra, AddressOf OnOrdenCompraPropertyChanged, "OrdenCompra", RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, True, _alreadyFetchedOrdenCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnOrdenCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idRecepcionOrdenCompra">PK value for RecepcionOrdenCompra which data should be fetched into this RecepcionOrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idRecepcionOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra)).ForcedCurrentValueWrite(idRecepcionOrdenCompra)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateRecepcionOrdenCompraDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New RecepcionOrdenCompraEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As RecepcionOrdenCompraRelations
			Get	
				Return New RecepcionOrdenCompraRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomRecepcionOrdenCompraDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomRecepcionOrdenCompraDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection(), _
					RecepcionOrdenCompraEntity.Relations.McomRecepcionOrdenCompraDetEntityUsingIdRecepcionOrdenCompra, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.McomRecepcionOrdenCompraDetEntity, Integer), 0, Nothing, Nothing, Nothing, "McomRecepcionOrdenCompraDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrCxpfacturasDetRecepciones' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCxpfacturasDetRecepciones() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection(), _
					RecepcionOrdenCompraEntity.Relations.UsrCxpfacturasDetRecepcionesEntityUsingIdRecepcionOrdenCompra, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.UsrCxpfacturasDetRecepcionesEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCxpfacturasDetRecepciones", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoCancelacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(), _
					RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivoCancelacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					RecepcionOrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "RecepcionOrdenCompraEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return RecepcionOrdenCompraEntity.CustomProperties
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
				Return RecepcionOrdenCompraEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdRecepcionOrdenCompra property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdRecepcionOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdRecepcionOrdenCompra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdRecepcionOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdOrdenCompra property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdOrdenCompra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAml property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FolioMovimientoAlm"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAml]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioMovimientoAml, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioMovimientoAml, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaRecepcion property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FechaRecepcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaRecepcion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaRecepcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaRecepcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmCan property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FolioMovimientoAlmCan"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmCan]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioMovimientoAlmCan, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioMovimientoAlmCan, Integer), value)
			End Set
		End Property
	
		''' <summary>The AlmacenId property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAltaId property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAltaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.UsuarioAltaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.UsuarioAltaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioCancelacionId property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioCancelacionId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.UsuarioCancelacionId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.UsuarioCancelacionId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoCancelacionId property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdMotivoCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoCancelacionId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.MotivoCancelacionId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.MotivoCancelacionId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdSucursal property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdSucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdSucursal]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdSucursal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdSucursal, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoFactura property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The Facturada property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Facturada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Facturada]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Facturada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Facturada, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Iva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioRecepcionOrdenCompra property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FolioRecepcionOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioRecepcionOrdenCompra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioRecepcionOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FolioRecepcionOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsDirecta property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."EsDirecta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsDirecta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.EsDirecta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.EsDirecta, Integer), value)
			End Set
		End Property
	
		''' <summary>The OrigenMovimiento property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."OrigenMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [OrigenMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.OrigenMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.OrigenMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ieps property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Ieps"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Ieps]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Ieps, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Ieps, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoRemision property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."NoRemision"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NoRemision]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.NoRemision, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.NoRemision, Integer), value)
			End Set
		End Property
	
		''' <summary>The Pagada property of the Entity RecepcionOrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComRecepcionOrdenCompra"."Pagada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Pagada]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RecepcionOrdenCompraFieldIndex.Pagada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RecepcionOrdenCompraFieldIndex.Pagada, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'McomRecepcionOrdenCompraDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomRecepcionOrdenCompraDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomRecepcionOrdenCompraDet]() As Integralab.ORM.CollectionClasses.McomRecepcionOrdenCompraDetCollection
			Get
				Return GetMultiMcomRecepcionOrdenCompraDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomRecepcionOrdenCompraDet. When set to true, McomRecepcionOrdenCompraDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomRecepcionOrdenCompraDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomRecepcionOrdenCompraDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomRecepcionOrdenCompraDet As Boolean
			Get
				Return _alwaysFetchMcomRecepcionOrdenCompraDet
			End Get
			Set
				_alwaysFetchMcomRecepcionOrdenCompraDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrCxpfacturasDetRecepcionesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCxpfacturasDetRecepciones()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCxpfacturasDetRecepciones]() As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection
			Get
				Return GetMultiUsrCxpfacturasDetRecepciones(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCxpfacturasDetRecepciones. When set to true, UsrCxpfacturasDetRecepciones is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCxpfacturasDetRecepciones is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCxpfacturasDetRecepciones(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCxpfacturasDetRecepciones As Boolean
			Get
				Return _alwaysFetchUsrCxpfacturasDetRecepciones
			End Get
			Set
				_alwaysFetchUsrCxpfacturasDetRecepciones = value
			End Set	
		End Property
	
	
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Almacen]() As AlmacenEntity
			Get
				Return GetSingleAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _almacen Is Nothing Then
							_almacen.UnsetRelatedEntity(Me, "RecepcionOrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionOrdenCompra")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen. When set to true, Almacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacen
			End Get
			Set
				_alwaysFetchAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Almacen is not found
		''' in the database. When set to true, Almacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _almacenReturnsNewIfNotFound
			End Get
			Set
				_almacenReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MotivoCancelacionEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMotivoCancelacion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MotivoCancelacion]() As MotivoCancelacionEntity
			Get
				Return GetSingleMotivoCancelacion(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMotivoCancelacion(value)
				Else
					If value Is Nothing Then
						If Not _motivoCancelacion Is Nothing Then
							_motivoCancelacion.UnsetRelatedEntity(Me, "RecepcionOrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionOrdenCompra")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivoCancelacion. When set to true, MotivoCancelacion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivoCancelacion is accessed. You can always execute
		''' a forced fetch by calling GetSingleMotivoCancelacion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivoCancelacion As Boolean
			Get
				Return _alwaysFetchMotivoCancelacion
			End Get
			Set
				_alwaysFetchMotivoCancelacion = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MotivoCancelacion is not found
		''' in the database. When set to true, MotivoCancelacion will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MotivoCancelacionReturnsNewIfNotFound As Boolean
			Get
				Return _motivoCancelacionReturnsNewIfNotFound
			End Get
			Set
				_motivoCancelacionReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'SucursalEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSucursal()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Sucursal]() As SucursalEntity
			Get
				Return GetSingleSucursal(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSucursal(value)
				Else
					If value Is Nothing Then
						If Not _sucursal Is Nothing Then
							_sucursal.UnsetRelatedEntity(Me, "RecepcionOrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionOrdenCompra")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Sucursal. When set to true, Sucursal is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Sucursal is accessed. You can always execute
		''' a forced fetch by calling GetSingleSucursal(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSucursal As Boolean
			Get
				Return _alwaysFetchSucursal
			End Get
			Set
				_alwaysFetchSucursal = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Sucursal is not found
		''' in the database. When set to true, Sucursal will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SucursalReturnsNewIfNotFound As Boolean
			Get
				Return _sucursalReturnsNewIfNotFound
			End Get
			Set
				_sucursalReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'OrdenCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [OrdenCompra]() As OrdenCompraEntity
			Get
				Return GetSingleOrdenCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncOrdenCompra(value)
				Else
					If value Is Nothing Then
						If Not _ordenCompra Is Nothing Then
							_ordenCompra.UnsetRelatedEntity(Me, "RecepcionOrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RecepcionOrdenCompra")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompra. When set to true, OrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property OrdenCompra is not found
		''' in the database. When set to true, OrdenCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property OrdenCompraReturnsNewIfNotFound As Boolean
			Get
				Return _ordenCompraReturnsNewIfNotFound
			End Get
			Set
				_ordenCompraReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity)
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
