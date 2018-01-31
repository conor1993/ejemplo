' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:24
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
	''' <summary>Entity class which represents the entity 'FacturasClientesCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class FacturasClientesCabEntity 
#Else
	<Serializable()> _
	Public Class FacturasClientesCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _facturasClientesDet As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
		Private _alwaysFetchFacturasClientesDet, _alreadyFetchedFacturasClientesDet As Boolean
		Private _facturasClientesDetProductosTotales As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
		Private _alwaysFetchFacturasClientesDetProductosTotales, _alreadyFetchedFacturasClientesDetProductosTotales As Boolean
		Private _mfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
		Private _alwaysFetchMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesDet As Boolean
		Private _notaCreditoDet As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
		Private _alwaysFetchNotaCreditoDet, _alreadyFetchedNotaCreditoDet As Boolean
		Private _pagoDeCtes As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
		Private _alwaysFetchPagoDeCtes, _alreadyFetchedPagoDeCtes As Boolean
		Private _mfacEmbarquesCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean
		Private _mfacCatClientes_ As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes_, _alreadyFetchedMfacCatClientes_, _mfacCatClientes_ReturnsNewIfNotFound As Boolean
		Private _poliza As PolizaEntity
		Private _alwaysFetchPoliza, _alreadyFetchedPoliza, _polizaReturnsNewIfNotFound As Boolean


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
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		Public Sub New(noFactura As System.String, serie As System.String)

			InitClassFetch(noFactura, serie, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(noFactura As System.String, serie As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(noFactura, serie, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="validator">The custom validator Object for this FacturasClientesCabEntity</param>
		Public Sub New(noFactura As System.String, serie As System.String, validator As IValidator)

			InitClassFetch(noFactura, serie, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_facturasClientesDet = CType(info.GetValue("_facturasClientesDet", GetType(Integralab.ORM.CollectionClasses.FacturasClientesDetCollection)), Integralab.ORM.CollectionClasses.FacturasClientesDetCollection)
			_alwaysFetchFacturasClientesDet = info.GetBoolean("_alwaysFetchFacturasClientesDet")
			_alreadyFetchedFacturasClientesDet = info.GetBoolean("_alreadyFetchedFacturasClientesDet")
			_facturasClientesDetProductosTotales = CType(info.GetValue("_facturasClientesDetProductosTotales", GetType(Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection)), Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection)
			_alwaysFetchFacturasClientesDetProductosTotales = info.GetBoolean("_alwaysFetchFacturasClientesDetProductosTotales")
			_alreadyFetchedFacturasClientesDetProductosTotales = info.GetBoolean("_alreadyFetchedFacturasClientesDetProductosTotales")
			_mfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)
			_alwaysFetchMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesDet")
			_notaCreditoDet = CType(info.GetValue("_notaCreditoDet", GetType(Integralab.ORM.CollectionClasses.NotaCreditoDetCollection)), Integralab.ORM.CollectionClasses.NotaCreditoDetCollection)
			_alwaysFetchNotaCreditoDet = info.GetBoolean("_alwaysFetchNotaCreditoDet")
			_alreadyFetchedNotaCreditoDet = info.GetBoolean("_alreadyFetchedNotaCreditoDet")
			_pagoDeCtes = CType(info.GetValue("_pagoDeCtes", GetType(Integralab.ORM.CollectionClasses.PagoDeCtesCollection)), Integralab.ORM.CollectionClasses.PagoDeCtesCollection)
			_alwaysFetchPagoDeCtes = info.GetBoolean("_alwaysFetchPagoDeCtes")
			_alreadyFetchedPagoDeCtes = info.GetBoolean("_alreadyFetchedPagoDeCtes")
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes Is Nothing Then
				AddHandler _mfacCatClientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientesReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientesReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")
			_mfacCatClientes_ = CType(info.GetValue("_mfacCatClientes_", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes_ Is Nothing Then
				AddHandler _mfacCatClientes_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientes_ReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientes_ReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes_ = info.GetBoolean("_alwaysFetchMfacCatClientes_")
			_alreadyFetchedMfacCatClientes_ = info.GetBoolean("_alreadyFetchedMfacCatClientes_")
			_poliza = CType(info.GetValue("_poliza", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza Is Nothing Then
				AddHandler _poliza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_polizaReturnsNewIfNotFound = info.GetBoolean("_polizaReturnsNewIfNotFound")
			_alwaysFetchPoliza = info.GetBoolean("_alwaysFetchPoliza")
			_alreadyFetchedPoliza = info.GetBoolean("_alreadyFetchedPoliza")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedFacturasClientesDet = (_facturasClientesDet.Count > 0)
			_alreadyFetchedFacturasClientesDetProductosTotales = (_facturasClientesDetProductosTotales.Count > 0)
			_alreadyFetchedMfacEmbarquesDet = (_mfacEmbarquesDet.Count > 0)
			_alreadyFetchedNotaCreditoDet = (_notaCreditoDet.Count > 0)
			_alreadyFetchedPagoDeCtes = (_pagoDeCtes.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = (_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)
			_alreadyFetchedMfacCatClientes_ = Not(_mfacCatClientes_ Is Nothing)
			_alreadyFetchedPoliza = Not(_poliza Is Nothing)

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
			info.AddValue("_facturasClientesDet", _facturasClientesDet)
			info.AddValue("_alwaysFetchFacturasClientesDet", _alwaysFetchFacturasClientesDet)
			info.AddValue("_alreadyFetchedFacturasClientesDet", _alreadyFetchedFacturasClientesDet)
			info.AddValue("_facturasClientesDetProductosTotales", _facturasClientesDetProductosTotales)
			info.AddValue("_alwaysFetchFacturasClientesDetProductosTotales", _alwaysFetchFacturasClientesDetProductosTotales)
			info.AddValue("_alreadyFetchedFacturasClientesDetProductosTotales", _alreadyFetchedFacturasClientesDetProductosTotales)
			info.AddValue("_mfacEmbarquesDet", _mfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesDet", _alwaysFetchMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesDet)
			info.AddValue("_notaCreditoDet", _notaCreditoDet)
			info.AddValue("_alwaysFetchNotaCreditoDet", _alwaysFetchNotaCreditoDet)
			info.AddValue("_alreadyFetchedNotaCreditoDet", _alreadyFetchedNotaCreditoDet)
			info.AddValue("_pagoDeCtes", _pagoDeCtes)
			info.AddValue("_alwaysFetchPagoDeCtes", _alwaysFetchPagoDeCtes)
			info.AddValue("_alreadyFetchedPagoDeCtes", _alreadyFetchedPagoDeCtes)
			info.AddValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", _mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			info.AddValue("_mfacCatClientes_", _mfacCatClientes_)
			info.AddValue("_mfacCatClientes_ReturnsNewIfNotFound", _mfacCatClientes_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes_", _alwaysFetchMfacCatClientes_)
			info.AddValue("_alreadyFetchedMfacCatClientes_", _alreadyFetchedMfacCatClientes_)
			info.AddValue("_poliza", _poliza)
			info.AddValue("_polizaReturnsNewIfNotFound", _polizaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza", _alwaysFetchPoliza)
			info.AddValue("_alreadyFetchedPoliza", _alreadyFetchedPoliza)

			
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
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "MfacCatClientes_"
					_alreadyFetchedMfacCatClientes_ = True
					Me.MfacCatClientes_ = CType(entity, MfacCatClientesEntity)
				Case "Poliza"
					_alreadyFetchedPoliza = True
					Me.Poliza = CType(entity, PolizaEntity)
				Case "FacturasClientesDet"
					_alreadyFetchedFacturasClientesDet = True
					If Not entity Is Nothing Then
						Me.FacturasClientesDet.Add(CType(entity, FacturasClientesDetEntity))
					End If
				Case "FacturasClientesDetProductosTotales"
					_alreadyFetchedFacturasClientesDetProductosTotales = True
					If Not entity Is Nothing Then
						Me.FacturasClientesDetProductosTotales.Add(CType(entity, FacturasClientesDetProductosTotalesEntity))
					End If
				Case "MfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesDet.Add(CType(entity, MfacEmbarquesDetEntity))
					End If
				Case "NotaCreditoDet"
					_alreadyFetchedNotaCreditoDet = True
					If Not entity Is Nothing Then
						Me.NotaCreditoDet.Add(CType(entity, NotaCreditoDetEntity))
					End If
				Case "PagoDeCtes"
					_alreadyFetchedPagoDeCtes = True
					If Not entity Is Nothing Then
						Me.PagoDeCtes.Add(CType(entity, PagoDeCtesEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MfacEmbarquesCabEntity))
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
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes_"
					SetupSyncMfacCatClientes_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza"
					SetupSyncPoliza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "FacturasClientesDet"
					_facturasClientesDet.Add(CType(relatedEntity, FacturasClientesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "FacturasClientesDetProductosTotales"
					_facturasClientesDetProductosTotales.Add(CType(relatedEntity, FacturasClientesDetProductosTotalesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					_mfacEmbarquesDet.Add(CType(relatedEntity, MfacEmbarquesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NotaCreditoDet"
					_notaCreditoDet.Add(CType(relatedEntity, NotaCreditoDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoDeCtes"
					_pagoDeCtes.Add(CType(relatedEntity, PagoDeCtesEntity))
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
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes_"
					DesetupSyncMfacCatClientes_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza"
					DesetupSyncPoliza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "FacturasClientesDet"
					MyBase.PerformRelatedEntityRemoval(_facturasClientesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "FacturasClientesDetProductosTotales"
					MyBase.PerformRelatedEntityRemoval(_facturasClientesDetProductosTotales, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NotaCreditoDet"
					MyBase.PerformRelatedEntityRemoval(_notaCreditoDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoDeCtes"
					MyBase.PerformRelatedEntityRemoval(_pagoDeCtes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _mfacCatClientes Is Nothing Then
				toReturn.Add(_mfacCatClientes)
			End If
			If Not _mfacCatClientes_ Is Nothing Then
				toReturn.Add(_mfacCatClientes_)
			End If
			If Not _poliza Is Nothing Then
				toReturn.Add(_poliza)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_facturasClientesDet)
			toReturn.Add(_facturasClientesDetProductosTotales)
			toReturn.Add(_mfacEmbarquesDet)
			toReturn.Add(_notaCreditoDet)
			toReturn.Add(_pagoDeCtes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(noFactura As System.String, serie As System.String) As Boolean
			Return FetchUsingPK(noFactura, serie, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(noFactura As System.String, serie As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(noFactura, serie, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(noFactura As System.String, serie As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(noFactura, serie, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.NoFactura, Me.Serie, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As FacturasClientesCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As FacturasClientesCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'FacturasClientesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesDetEntity'</returns>
		Public Function GetMultiFacturasClientesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
			Return GetMultiFacturasClientesDet(forceFetch, _facturasClientesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiFacturasClientesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
			Return GetMultiFacturasClientesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesDetEntity'</returns>
		Public Function GetMultiFacturasClientesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
			Return GetMultiFacturasClientesDet(forceFetch, _facturasClientesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
			If ( Not _alreadyFetchedFacturasClientesDet Or forceFetch Or _alwaysFetchFacturasClientesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesDet)
					End If
				End If
				_facturasClientesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesDet.GetMultiManyToOne(Me, Filter)
				_facturasClientesDet.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesDet = True
			End If
			Return _facturasClientesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesDet'. These settings will be taken into account
		''' when the property FacturasClientesDet is requested or GetMultiFacturasClientesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesDet.SortClauses=sortClauses
			_facturasClientesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesDetProductosTotalesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesDetProductosTotalesEntity'</returns>
		Public Function GetMultiFacturasClientesDetProductosTotales(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
			Return GetMultiFacturasClientesDetProductosTotales(forceFetch, _facturasClientesDetProductosTotales.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetProductosTotalesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiFacturasClientesDetProductosTotales(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
			Return GetMultiFacturasClientesDetProductosTotales(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetProductosTotalesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesDetProductosTotalesEntity'</returns>
		Public Function GetMultiFacturasClientesDetProductosTotales(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
			Return GetMultiFacturasClientesDetProductosTotales(forceFetch, _facturasClientesDetProductosTotales.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesDetProductosTotalesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesDetProductosTotales(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
			If ( Not _alreadyFetchedFacturasClientesDetProductosTotales Or forceFetch Or _alwaysFetchFacturasClientesDetProductosTotales) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesDetProductosTotales.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesDetProductosTotales)
					End If
				End If
				_facturasClientesDetProductosTotales.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesDetProductosTotales.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesDetProductosTotales.GetMultiManyToOne(Me, Filter)
				_facturasClientesDetProductosTotales.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesDetProductosTotales = True
			End If
			Return _facturasClientesDetProductosTotales
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesDetProductosTotales'. These settings will be taken into account
		''' when the property FacturasClientesDetProductosTotales is requested or GetMultiFacturasClientesDetProductosTotales is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesDetProductosTotales(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesDetProductosTotales.SortClauses=sortClauses
			_facturasClientesDetProductosTotales.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, _mfacEmbarquesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiMfacEmbarquesDet(forceFetch, _mfacEmbarquesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			If ( Not _alreadyFetchedMfacEmbarquesDet Or forceFetch Or _alwaysFetchMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesDet)
					End If
				End If
				_mfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesDet.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Nothing, Filter)
				_mfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesDet = True
			End If
			Return _mfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesDet'. These settings will be taken into account
		''' when the property MfacEmbarquesDet is requested or GetMultiMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesDet.SortClauses=sortClauses
			_mfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoDetEntity'</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, _notaCreditoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoDetEntity'</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, _notaCreditoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNotaCreditoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			If ( Not _alreadyFetchedNotaCreditoDet Or forceFetch Or _alwaysFetchNotaCreditoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _notaCreditoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_notaCreditoDet)
					End If
				End If
				_notaCreditoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_notaCreditoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_notaCreditoDet.GetMultiManyToOne(Me, Nothing, Filter)
				_notaCreditoDet.SuppressClearInGetMulti = False
				_alreadyFetchedNotaCreditoDet = True
			End If
			Return _notaCreditoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NotaCreditoDet'. These settings will be taken into account
		''' when the property NotaCreditoDet is requested or GetMultiNotaCreditoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNotaCreditoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_notaCreditoDet.SortClauses=sortClauses
			_notaCreditoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, _pagoDeCtes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PagoDeCtesEntity'</returns>
		Public Function GetMultiPagoDeCtes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Return GetMultiPagoDeCtes(forceFetch, _pagoDeCtes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoDeCtes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			If ( Not _alreadyFetchedPagoDeCtes Or forceFetch Or _alwaysFetchPagoDeCtes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoDeCtes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoDeCtes)
					End If
				End If
				_pagoDeCtes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoDeCtes.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoDeCtes.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_pagoDeCtes.SuppressClearInGetMulti = False
				_alreadyFetchedPagoDeCtes = True
			End If
			Return _pagoDeCtes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoDeCtes'. These settings will be taken into account
		''' when the property PagoDeCtes is requested or GetMultiPagoDeCtes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoDeCtes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoDeCtes.SortClauses=sortClauses
			_pagoDeCtes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch, _mfacEmbarquesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(FacturasClientesCabEntity.Relations.MfacEmbarquesDetEntityUsingSerieFacturaNoFactura, "__FacturasClientesCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.NoFactura), ComparisonOperator.Equal, Me.NoFactura))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(FacturasClientesCabFieldIndex.Serie), ComparisonOperator.Equal, Me.Serie))
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
			End If
			Return _mfacEmbarquesCabCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCabCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property MfacEmbarquesCabCollectionViaMfacEmbarquesDet is requested or GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCabCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes() As MfacCatClientesEntity
			Return GetSingleMfacCatClientes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes(forceFetch As Boolean) As MfacCatClientesEntity
			If ( Not _alreadyFetchedMfacCatClientes Or forceFetch Or _alwaysFetchMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacCatClientesEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCliente)
				End If
				If Not _mfacCatClientesReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MfacCatClientes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacCatClientesEntity)
					End If
					Me.MfacCatClientes = newEntity
					_alreadyFetchedMfacCatClientes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacCatClientes
		End Function
	
		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes_() As MfacCatClientesEntity
			Return GetSingleMfacCatClientes_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes_(forceFetch As Boolean) As MfacCatClientesEntity
			If ( Not _alreadyFetchedMfacCatClientes_ Or forceFetch Or _alwaysFetchMfacCatClientes_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacCatClientesEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteCargo) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdClienteCargo)
				End If
				If Not _mfacCatClientes_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MfacCatClientes_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacCatClientesEntity)
					End If
					Me.MfacCatClientes_ = newEntity
					_alreadyFetchedMfacCatClientes_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacCatClientes_
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza() As PolizaEntity
			Return GetSinglePoliza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza Or forceFetch Or _alwaysFetchPoliza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(FacturasClientesCabEntity.Relations.PolizaEntityUsingIdPoliza) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPoliza)
				End If
				If Not _polizaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza = newEntity
					_alreadyFetchedPoliza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(FacturasClientesCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, FacturasClientesCabFieldIndex)

					Case FacturasClientesCabFieldIndex.IdCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False









					Case FacturasClientesCabFieldIndex.IdPoliza
						DesetupSyncPoliza(True, False)
						_alreadyFetchedPoliza = False





					Case FacturasClientesCabFieldIndex.IdClienteCargo
						DesetupSyncMfacCatClientes_(True, False)
						_alreadyFetchedMfacCatClientes_ = False











					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_facturasClientesDet.ActiveContext = MyBase.ActiveContext
			_facturasClientesDetProductosTotales.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_notaCreditoDet.ActiveContext = MyBase.ActiveContext
			_pagoDeCtes.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes_ Is Nothing Then
				_mfacCatClientes_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza Is Nothing Then
				_poliza.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As FacturasClientesCabDAO = CType(CreateDAOInstance(), FacturasClientesCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As FacturasClientesCabDAO = CType(CreateDAOInstance(), FacturasClientesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As FacturasClientesCabDAO = CType(CreateDAOInstance(), FacturasClientesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this FacturasClientesCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.FacturasClientesCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="validator">The validator Object for this FacturasClientesCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(noFactura As System.String, serie As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(noFactura, serie, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_facturasClientesDet = New Integralab.ORM.CollectionClasses.FacturasClientesDetCollection(New FacturasClientesDetEntityFactory())
			_facturasClientesDet.SetContainingEntityInfo(Me, "FacturasClientesCab")
			_alwaysFetchFacturasClientesDet = False
			_alreadyFetchedFacturasClientesDet = False
			_facturasClientesDetProductosTotales = New Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection(New FacturasClientesDetProductosTotalesEntityFactory())
			_facturasClientesDetProductosTotales.SetContainingEntityInfo(Me, "FacturasClientesCab")
			_alwaysFetchFacturasClientesDetProductosTotales = False
			_alreadyFetchedFacturasClientesDetProductosTotales = False
			_mfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(New MfacEmbarquesDetEntityFactory())
			_mfacEmbarquesDet.SetContainingEntityInfo(Me, "FacturasClientesCab")
			_alwaysFetchMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesDet = False
			_notaCreditoDet = New Integralab.ORM.CollectionClasses.NotaCreditoDetCollection(New NotaCreditoDetEntityFactory())
			_notaCreditoDet.SetContainingEntityInfo(Me, "FacturasClientesCab")
			_alwaysFetchNotaCreditoDet = False
			_alreadyFetchedNotaCreditoDet = False
			_pagoDeCtes = New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(New PagoDeCtesEntityFactory())
			_pagoDeCtes.SetContainingEntityInfo(Me, "FacturasClientesCab")
			_alwaysFetchPagoDeCtes = False
			_alreadyFetchedPagoDeCtes = False
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			_mfacCatClientes_ = Nothing
			_mfacCatClientes_ReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes_ = False
			_alreadyFetchedMfacCatClientes_ = False
			_poliza = Nothing
			_polizaReturnsNewIfNotFound = True
			_alwaysFetchPoliza = False
			_alreadyFetchedPoliza = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Credito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Contabilizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdClienteCargo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TopoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVencOriginal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Serie", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FormaDePago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CondicionesDePago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MetodoDePago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Uuid", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDomicilioFiscal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Ieps", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumCtaPago", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "FacturasClientesCab", resetFKFields, New Integer() { CInt(FacturasClientesCabFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacCatClientesPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mfacCatClientes_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes_, AddressOf OnMfacCatClientes_PropertyChanged, "MfacCatClientes_", FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteCargo, True, signalRelatedEntity, "FacturasClientesCab_", resetFKFields, New Integer() { CInt(FacturasClientesCabFieldIndex.IdClienteCargo) } )
			_mfacCatClientes_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes_(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes_(True, True)
			_mfacCatClientes_ = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes_, AddressOf OnMfacCatClientes_PropertyChanged, "MfacCatClientes_", FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteCargo, True, _alreadyFetchedMfacCatClientes_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacCatClientes_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", FacturasClientesCabEntity.Relations.PolizaEntityUsingIdPoliza, True, signalRelatedEntity, "FacturasClientesCab", resetFKFields, New Integer() { CInt(FacturasClientesCabFieldIndex.IdPoliza) } )
			_poliza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza(relatedEntity As IEntity)
			DesetupSyncPoliza(True, True)
			_poliza = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", FacturasClientesCabEntity.Relations.PolizaEntityUsingIdPoliza, True, _alreadyFetchedPoliza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPolizaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="noFactura">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="serie">PK value for FacturasClientesCab which data should be fetched into this FacturasClientesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(noFactura As System.String, serie As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(FacturasClientesCabFieldIndex.NoFactura)).ForcedCurrentValueWrite(noFactura)
				MyBase.Fields(CInt(FacturasClientesCabFieldIndex.Serie)).ForcedCurrentValueWrite(serie)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateFacturasClientesCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New FacturasClientesCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As FacturasClientesCabRelations
			Get	
				Return New FacturasClientesCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesDetCollection(), _
					FacturasClientesCabEntity.Relations.FacturasClientesDetEntityUsingSerieFacturaNoFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesDetProductosTotales' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesDetProductosTotales() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection(), _
					FacturasClientesCabEntity.Relations.FacturasClientesDetProductosTotalesEntityUsingSerieFacturaNoFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesDetProductosTotalesEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesDetProductosTotales", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(), _
					FacturasClientesCabEntity.Relations.MfacEmbarquesDetEntityUsingSerieFacturaNoFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaCreditoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotaCreditoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaCreditoDetCollection(), _
					FacturasClientesCabEntity.Relations.NotaCreditoDetEntityUsingSerieFacturaFolFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.NotaCreditoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "NotaCreditoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoDeCtes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoDeCtes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(), _
					FacturasClientesCabEntity.Relations.PagoDeCtesEntityUsingSerieFacturaFolFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoDeCtes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(FacturasClientesCabEntity.Relations.MfacEmbarquesDetEntityUsingSerieFacturaNoFactura, "__FacturasClientesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					FacturasClientesCabEntity.Relations.MfacEmbarquesDetEntityUsingSerieFacturaNoFactura, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					FacturasClientesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteCargo, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					FacturasClientesCabEntity.Relations.PolizaEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "FacturasClientesCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return FacturasClientesCabEntity.CustomProperties
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
				Return FacturasClientesCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The NoFactura property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaFactura property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaFactura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVencimiento property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaVencimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVencimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaVencimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaVencimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contado property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Contado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Contado]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Contado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Contado, Integer), value)
			End Set
		End Property
	
		''' <summary>The Credito property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Credito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Credito]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Credito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Credito, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Contabilizado property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Contabilizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Contabilizado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Contabilizado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Contabilizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.IdPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaContabilizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancela property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IdUsuarioCancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancela]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.IdUsuarioCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.IdUsuarioCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdClienteCargo property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IdClienteCargo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdClienteCargo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.IdClienteCargo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.IdClienteCargo, Integer), value)
			End Set
		End Property
	
		''' <summary>The TopoFactura property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."TopoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TopoFactura]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.TopoFactura, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.TopoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVencOriginal property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FechaVencOriginal"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaVencOriginal]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FechaVencOriginal, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FechaVencOriginal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Serie property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Serie"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Serie]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Serie, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Serie, Integer), value)
			End Set
		End Property
	
		''' <summary>The FormaDePago property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."FormaDePago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FormaDePago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.FormaDePago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.FormaDePago, Integer), value)
			End Set
		End Property
	
		''' <summary>The CondicionesDePago property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."CondicionesDePago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CondicionesDePago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.CondicionesDePago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.CondicionesDePago, Integer), value)
			End Set
		End Property
	
		''' <summary>The MetodoDePago property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."MetodoDePago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MetodoDePago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.MetodoDePago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.MetodoDePago, Integer), value)
			End Set
		End Property
	
		''' <summary>The Uuid property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."UUID"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 36<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Uuid]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Uuid, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Uuid, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdDomicilioFiscal property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IdDomicilioFiscal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdDomicilioFiscal]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.IdDomicilioFiscal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.IdDomicilioFiscal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ieps property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."IEPS"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Ieps]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Ieps, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Ieps, Integer), value)
			End Set
		End Property
	
		''' <summary>The Origen property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."Origen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Origen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.Origen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.Origen, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumCtaPago property of the Entity FacturasClientesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "FacturasClientesCab"."NumCtaPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumCtaPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(FacturasClientesCabFieldIndex.NumCtaPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(FacturasClientesCabFieldIndex.NumCtaPago, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesDet]() As Integralab.ORM.CollectionClasses.FacturasClientesDetCollection
			Get
				Return GetMultiFacturasClientesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesDet. When set to true, FacturasClientesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesDet As Boolean
			Get
				Return _alwaysFetchFacturasClientesDet
			End Get
			Set
				_alwaysFetchFacturasClientesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesDetProductosTotalesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesDetProductosTotales()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesDetProductosTotales]() As Integralab.ORM.CollectionClasses.FacturasClientesDetProductosTotalesCollection
			Get
				Return GetMultiFacturasClientesDetProductosTotales(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesDetProductosTotales. When set to true, FacturasClientesDetProductosTotales is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesDetProductosTotales is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesDetProductosTotales(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesDetProductosTotales As Boolean
			Get
				Return _alwaysFetchFacturasClientesDetProductosTotales
			End Get
			Set
				_alwaysFetchFacturasClientesDetProductosTotales = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Get
				Return GetMultiMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesDet. When set to true, MfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNotaCreditoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NotaCreditoDet]() As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Get
				Return GetMultiNotaCreditoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotaCreditoDet. When set to true, NotaCreditoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotaCreditoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiNotaCreditoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotaCreditoDet As Boolean
			Get
				Return _alwaysFetchNotaCreditoDet
			End Get
			Set
				_alwaysFetchNotaCreditoDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PagoDeCtesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoDeCtes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoDeCtes]() As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
			Get
				Return GetMultiPagoDeCtes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoDeCtes. When set to true, PagoDeCtes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoDeCtes is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoDeCtes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoDeCtes As Boolean
			Get
				Return _alwaysFetchPagoDeCtes
			End Get
			Set
				_alwaysFetchPagoDeCtes = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCabCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCabCollectionViaMfacEmbarquesDet. When set to true, MfacEmbarquesCabCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCabCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCabCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'MfacCatClientesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacCatClientes]() As MfacCatClientesEntity
			Get
				Return GetSingleMfacCatClientes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacCatClientes(value)
				Else
					If value Is Nothing Then
						If Not _mfacCatClientes Is Nothing Then
							_mfacCatClientes.UnsetRelatedEntity(Me, "FacturasClientesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "FacturasClientesCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacCatClientes. When set to true, MfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacCatClientes As Boolean
			Get
				Return _alwaysFetchMfacCatClientes
			End Get
			Set
				_alwaysFetchMfacCatClientes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacCatClientes is not found
		''' in the database. When set to true, MfacCatClientes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacCatClientesReturnsNewIfNotFound As Boolean
			Get
				Return _mfacCatClientesReturnsNewIfNotFound
			End Get
			Set
				_mfacCatClientesReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MfacCatClientesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacCatClientes_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacCatClientes_]() As MfacCatClientesEntity
			Get
				Return GetSingleMfacCatClientes_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacCatClientes_(value)
				Else
					If value Is Nothing Then
						If Not _mfacCatClientes_ Is Nothing Then
							_mfacCatClientes_.UnsetRelatedEntity(Me, "FacturasClientesCab_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "FacturasClientesCab_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacCatClientes_. When set to true, MfacCatClientes_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacCatClientes_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacCatClientes_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacCatClientes_ As Boolean
			Get
				Return _alwaysFetchMfacCatClientes_
			End Get
			Set
				_alwaysFetchMfacCatClientes_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacCatClientes_ is not found
		''' in the database. When set to true, MfacCatClientes_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacCatClientes_ReturnsNewIfNotFound As Boolean
			Get
				Return _mfacCatClientes_ReturnsNewIfNotFound
			End Get
			Set
				_mfacCatClientes_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza]() As PolizaEntity
			Get
				Return GetSinglePoliza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza(value)
				Else
					If value Is Nothing Then
						If Not _poliza Is Nothing Then
							_poliza.UnsetRelatedEntity(Me, "FacturasClientesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "FacturasClientesCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza. When set to true, Poliza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza As Boolean
			Get
				Return _alwaysFetchPoliza
			End Get
			Set
				_alwaysFetchPoliza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza is not found
		''' in the database. When set to true, Poliza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PolizaReturnsNewIfNotFound As Boolean
			Get
				Return _polizaReturnsNewIfNotFound
			End Get
			Set
				_polizaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.FacturasClientesCabEntity)
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
