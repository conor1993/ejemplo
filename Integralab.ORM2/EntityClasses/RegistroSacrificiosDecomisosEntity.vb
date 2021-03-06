﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:29
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
	''' <summary>Entity class which represents the entity 'RegistroSacrificiosDecomisos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class RegistroSacrificiosDecomisosEntity 
#Else
	<Serializable()> _
	Public Class RegistroSacrificiosDecomisosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"
		Private _mfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
		Private _alwaysFetchMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesDet As Boolean
		Private _mfacEmbarquesCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet As Boolean
		Private _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet As Boolean
		Private _mscregistroSacrificioCab As MscregistroSacrificioCabEntity
		Private _alwaysFetchMscregistroSacrificioCab, _alreadyFetchedMscregistroSacrificioCab, _mscregistroSacrificioCabReturnsNewIfNotFound As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _msccatProductos As MsccatProductosEntity
		Private _alwaysFetchMsccatProductos, _alreadyFetchedMsccatProductos, _msccatProductosReturnsNewIfNotFound As Boolean
		Private _mscmovtosAlmacenCab As MscmovtosAlmacenCabEntity
		Private _alwaysFetchMscmovtosAlmacenCab, _alreadyFetchedMscmovtosAlmacenCab, _mscmovtosAlmacenCabReturnsNewIfNotFound As Boolean
		Private _mscmovtosAlmacenCab_ As MscmovtosAlmacenCabEntity
		Private _alwaysFetchMscmovtosAlmacenCab_, _alreadyFetchedMscmovtosAlmacenCab_, _mscmovtosAlmacenCab_ReturnsNewIfNotFound As Boolean


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
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		Public Sub New(loteSacrificio As System.String, idProducto As System.Int32)

			InitClassFetch(loteSacrificio, idProducto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(loteSacrificio As System.String, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(loteSacrificio, idProducto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="validator">The custom validator Object for this RegistroSacrificiosDecomisosEntity</param>
		Public Sub New(loteSacrificio As System.String, idProducto As System.Int32, validator As IValidator)

			InitClassFetch(loteSacrificio, idProducto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)
			_alwaysFetchMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesDet")
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet")
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet")
			_mscregistroSacrificioCab = CType(info.GetValue("_mscregistroSacrificioCab", GetType(MscregistroSacrificioCabEntity)), MscregistroSacrificioCabEntity)
			If Not _mscregistroSacrificioCab Is Nothing Then
				AddHandler _mscregistroSacrificioCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscregistroSacrificioCabReturnsNewIfNotFound = info.GetBoolean("_mscregistroSacrificioCabReturnsNewIfNotFound")
			_alwaysFetchMscregistroSacrificioCab = info.GetBoolean("_alwaysFetchMscregistroSacrificioCab")
			_alreadyFetchedMscregistroSacrificioCab = info.GetBoolean("_alreadyFetchedMscregistroSacrificioCab")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_msccatProductos = CType(info.GetValue("_msccatProductos", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductos Is Nothing Then
				AddHandler _msccatProductos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosReturnsNewIfNotFound = info.GetBoolean("_msccatProductosReturnsNewIfNotFound")
			_alwaysFetchMsccatProductos = info.GetBoolean("_alwaysFetchMsccatProductos")
			_alreadyFetchedMsccatProductos = info.GetBoolean("_alreadyFetchedMsccatProductos")
			_mscmovtosAlmacenCab = CType(info.GetValue("_mscmovtosAlmacenCab", GetType(MscmovtosAlmacenCabEntity)), MscmovtosAlmacenCabEntity)
			If Not _mscmovtosAlmacenCab Is Nothing Then
				AddHandler _mscmovtosAlmacenCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscmovtosAlmacenCabReturnsNewIfNotFound = info.GetBoolean("_mscmovtosAlmacenCabReturnsNewIfNotFound")
			_alwaysFetchMscmovtosAlmacenCab = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab")
			_alreadyFetchedMscmovtosAlmacenCab = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab")
			_mscmovtosAlmacenCab_ = CType(info.GetValue("_mscmovtosAlmacenCab_", GetType(MscmovtosAlmacenCabEntity)), MscmovtosAlmacenCabEntity)
			If Not _mscmovtosAlmacenCab_ Is Nothing Then
				AddHandler _mscmovtosAlmacenCab_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscmovtosAlmacenCab_ReturnsNewIfNotFound = info.GetBoolean("_mscmovtosAlmacenCab_ReturnsNewIfNotFound")
			_alwaysFetchMscmovtosAlmacenCab_ = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCab_")
			_alreadyFetchedMscmovtosAlmacenCab_ = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCab_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMfacEmbarquesDet = (_mfacEmbarquesDet.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = (_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = (_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMscregistroSacrificioCab = Not(_mscregistroSacrificioCab Is Nothing)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedMsccatProductos = Not(_msccatProductos Is Nothing)
			_alreadyFetchedMscmovtosAlmacenCab = Not(_mscmovtosAlmacenCab Is Nothing)
			_alreadyFetchedMscmovtosAlmacenCab_ = Not(_mscmovtosAlmacenCab_ Is Nothing)

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
			info.AddValue("_mfacEmbarquesDet", _mfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesDet", _alwaysFetchMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesDet)
			info.AddValue("_mfacEmbarquesCabCollectionViaMfacEmbarquesDet", _mfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_mscregistroSacrificioCab", _mscregistroSacrificioCab)
			info.AddValue("_mscregistroSacrificioCabReturnsNewIfNotFound", _mscregistroSacrificioCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscregistroSacrificioCab", _alwaysFetchMscregistroSacrificioCab)
			info.AddValue("_alreadyFetchedMscregistroSacrificioCab", _alreadyFetchedMscregistroSacrificioCab)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_msccatProductos", _msccatProductos)
			info.AddValue("_msccatProductosReturnsNewIfNotFound", _msccatProductosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductos", _alwaysFetchMsccatProductos)
			info.AddValue("_alreadyFetchedMsccatProductos", _alreadyFetchedMsccatProductos)
			info.AddValue("_mscmovtosAlmacenCab", _mscmovtosAlmacenCab)
			info.AddValue("_mscmovtosAlmacenCabReturnsNewIfNotFound", _mscmovtosAlmacenCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab", _alwaysFetchMscmovtosAlmacenCab)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab", _alreadyFetchedMscmovtosAlmacenCab)
			info.AddValue("_mscmovtosAlmacenCab_", _mscmovtosAlmacenCab_)
			info.AddValue("_mscmovtosAlmacenCab_ReturnsNewIfNotFound", _mscmovtosAlmacenCab_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCab_", _alwaysFetchMscmovtosAlmacenCab_)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCab_", _alreadyFetchedMscmovtosAlmacenCab_)

			
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
				Case "MscregistroSacrificioCab"
					_alreadyFetchedMscregistroSacrificioCab = True
					Me.MscregistroSacrificioCab = CType(entity, MscregistroSacrificioCabEntity)
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case "MsccatProductos"
					_alreadyFetchedMsccatProductos = True
					Me.MsccatProductos = CType(entity, MsccatProductosEntity)
				Case "MscmovtosAlmacenCab"
					_alreadyFetchedMscmovtosAlmacenCab = True
					Me.MscmovtosAlmacenCab = CType(entity, MscmovtosAlmacenCabEntity)
				Case "MscmovtosAlmacenCab_"
					_alreadyFetchedMscmovtosAlmacenCab_ = True
					Me.MscmovtosAlmacenCab_ = CType(entity, MscmovtosAlmacenCabEntity)
				Case "MfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesDet.Add(CType(entity, MfacEmbarquesDetEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MscmovtosAlmacenCabEntity))
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
				Case "MscregistroSacrificioCab"
					SetupSyncMscregistroSacrificioCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductos"
					SetupSyncMsccatProductos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					SetupSyncMscmovtosAlmacenCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab_"
					SetupSyncMscmovtosAlmacenCab_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					_mfacEmbarquesDet.Add(CType(relatedEntity, MfacEmbarquesDetEntity))
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
				Case "MscregistroSacrificioCab"
					DesetupSyncMscregistroSacrificioCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductos"
					DesetupSyncMsccatProductos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab"
					DesetupSyncMscmovtosAlmacenCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscmovtosAlmacenCab_"
					DesetupSyncMscmovtosAlmacenCab_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesDet"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _mscregistroSacrificioCab Is Nothing Then
				toReturn.Add(_mscregistroSacrificioCab)
			End If
			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
			End If
			If Not _msccatProductos Is Nothing Then
				toReturn.Add(_msccatProductos)
			End If
			If Not _mscmovtosAlmacenCab Is Nothing Then
				toReturn.Add(_mscmovtosAlmacenCab)
			End If
			If Not _mscmovtosAlmacenCab_ Is Nothing Then
				toReturn.Add(_mscmovtosAlmacenCab_)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mfacEmbarquesDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, idProducto As System.Int32) As Boolean
			Return FetchUsingPK(loteSacrificio, idProducto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(loteSacrificio, idProducto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(loteSacrificio, idProducto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.LoteSacrificio, Me.IdProducto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As RegistroSacrificiosDecomisosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As RegistroSacrificiosDecomisosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



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
				_mfacEmbarquesDet.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
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
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, "__RegistroSacrificiosDecomisosEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio), ComparisonOperator.Equal, Me.LoteSacrificio))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
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

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscmovtosAlmacenCabEntity'</returns>
		Public Function GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Return GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(forceFetch, _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			If ( Not _alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, "__RegistroSacrificiosDecomisosEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio), ComparisonOperator.Equal, Me.LoteSacrificio))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(RegistroSacrificiosDecomisosFieldIndex.IdProducto), ComparisonOperator.Equal, Me.IdProducto))
				_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = True
			End If
			Return _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet is requested or GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'MscregistroSacrificioCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscregistroSacrificioCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscregistroSacrificioCab() As MscregistroSacrificioCabEntity
			Return GetSingleMscregistroSacrificioCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscregistroSacrificioCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscregistroSacrificioCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscregistroSacrificioCab(forceFetch As Boolean) As MscregistroSacrificioCabEntity
			If ( Not _alreadyFetchedMscregistroSacrificioCab Or forceFetch Or _alwaysFetchMscregistroSacrificioCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscregistroSacrificioCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDecomisosEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio) Then
					fetchResult = newEntity.FetchUsingPK(Me.LoteSacrificio)
				End If
				If Not _mscregistroSacrificioCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscregistroSacrificioCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscregistroSacrificioCabEntity)
					End If
					Me.MscregistroSacrificioCab = newEntity
					_alreadyFetchedMscregistroSacrificioCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscregistroSacrificioCab
		End Function
	
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
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenProd.GetValueOrDefault())
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
	
		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos() As MsccatProductosEntity
			Return GetSingleMsccatProductos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductos Or forceFetch Or _alwaysFetchMsccatProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDecomisosEntity.Relations.MsccatProductosEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _msccatProductosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductos = newEntity
					_alreadyFetchedMsccatProductos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductos
		End Function
	
		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab() As MscmovtosAlmacenCabEntity
			Return GetSingleMscmovtosAlmacenCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab(forceFetch As Boolean) As MscmovtosAlmacenCabEntity
			If ( Not _alreadyFetchedMscmovtosAlmacenCab Or forceFetch Or _alwaysFetchMscmovtosAlmacenCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscmovtosAlmacenCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioMovAlmacen)
				End If
				If Not _mscmovtosAlmacenCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscmovtosAlmacenCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscmovtosAlmacenCabEntity)
					End If
					Me.MscmovtosAlmacenCab = newEntity
					_alreadyFetchedMscmovtosAlmacenCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscmovtosAlmacenCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab_() As MscmovtosAlmacenCabEntity
			Return GetSingleMscmovtosAlmacenCab_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscmovtosAlmacenCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscmovtosAlmacenCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscmovtosAlmacenCab_(forceFetch As Boolean) As MscmovtosAlmacenCabEntity
			If ( Not _alreadyFetchedMscmovtosAlmacenCab_ Or forceFetch Or _alwaysFetchMscmovtosAlmacenCab_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscmovtosAlmacenCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioCancelAlmacen)
				End If
				If Not _mscmovtosAlmacenCab_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscmovtosAlmacenCab_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscmovtosAlmacenCabEntity)
					End If
					Me.MscmovtosAlmacenCab_ = newEntity
					_alreadyFetchedMscmovtosAlmacenCab_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscmovtosAlmacenCab_
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(RegistroSacrificiosDecomisosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, RegistroSacrificiosDecomisosFieldIndex)
					Case RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio
						DesetupSyncMscregistroSacrificioCab(True, False)
						_alreadyFetchedMscregistroSacrificioCab = False
					Case RegistroSacrificiosDecomisosFieldIndex.IdProducto
						DesetupSyncMsccatProductos(True, False)
						_alreadyFetchedMsccatProductos = False




					Case RegistroSacrificiosDecomisosFieldIndex.IdAlmacenProd
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False


					Case RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen
						DesetupSyncMscmovtosAlmacenCab(True, False)
						_alreadyFetchedMscmovtosAlmacenCab = False
					Case RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen
						DesetupSyncMscmovtosAlmacenCab_(True, False)
						_alreadyFetchedMscmovtosAlmacenCab_ = False



					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
		If Not _mscregistroSacrificioCab Is Nothing Then
				_mscregistroSacrificioCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatProductos Is Nothing Then
				_msccatProductos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mscmovtosAlmacenCab Is Nothing Then
				_mscmovtosAlmacenCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mscmovtosAlmacenCab_ Is Nothing Then
				_mscmovtosAlmacenCab_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As RegistroSacrificiosDecomisosDAO = CType(CreateDAOInstance(), RegistroSacrificiosDecomisosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As RegistroSacrificiosDecomisosDAO = CType(CreateDAOInstance(), RegistroSacrificiosDecomisosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As RegistroSacrificiosDecomisosDAO = CType(CreateDAOInstance(), RegistroSacrificiosDecomisosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this RegistroSacrificiosDecomisosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="validator">The validator Object for this RegistroSacrificiosDecomisosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(loteSacrificio As System.String, idProducto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(loteSacrificio, idProducto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(New MfacEmbarquesDetEntityFactory())
			_mfacEmbarquesDet.SetContainingEntityInfo(Me, "RegistroSacrificiosDecomisos")
			_alwaysFetchMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesDet = False
			_mfacEmbarquesCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaMfacEmbarquesDet = False
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = False
			_mscregistroSacrificioCab = Nothing
			_mscregistroSacrificioCabReturnsNewIfNotFound = True
			_alwaysFetchMscregistroSacrificioCab = False
			_alreadyFetchedMscregistroSacrificioCab = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_msccatProductos = Nothing
			_msccatProductosReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductos = False
			_alreadyFetchedMsccatProductos = False
			_mscmovtosAlmacenCab = Nothing
			_mscmovtosAlmacenCabReturnsNewIfNotFound = True
			_alwaysFetchMscmovtosAlmacenCab = False
			_alreadyFetchedMscmovtosAlmacenCab = False
			_mscmovtosAlmacenCab_ = Nothing
			_mscmovtosAlmacenCab_ReturnsNewIfNotFound = True
			_alwaysFetchMscmovtosAlmacenCab_ = False
			_alreadyFetchedMscmovtosAlmacenCab_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Decomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDecomiso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenProd", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PiezasSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioCancelAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosEmbarcados", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PiezasEmbarcadas", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mscregistroSacrificioCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscregistroSacrificioCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscregistroSacrificioCab, AddressOf OnMscregistroSacrificioCabPropertyChanged, "MscregistroSacrificioCab", RegistroSacrificiosDecomisosEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio, True, signalRelatedEntity, "RegistroSacrificiosDecomisos", resetFKFields, New Integer() { CInt(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio) } )
			_mscregistroSacrificioCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscregistroSacrificioCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscregistroSacrificioCab(relatedEntity As IEntity)
			DesetupSyncMscregistroSacrificioCab(True, True)
			_mscregistroSacrificioCab = CType(relatedEntity, MscregistroSacrificioCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscregistroSacrificioCab, AddressOf OnMscregistroSacrificioCabPropertyChanged, "MscregistroSacrificioCab", RegistroSacrificiosDecomisosEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio, True, _alreadyFetchedMscregistroSacrificioCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscregistroSacrificioCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd, True, signalRelatedEntity, "RegistroSacrificiosDecomisos", resetFKFields, New Integer() { CInt(RegistroSacrificiosDecomisosFieldIndex.IdAlmacenProd) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd, True, _alreadyFetchedAlmacen, New String() {  } )
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
		''' <summary>Removes the sync logic for member _msccatProductos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", RegistroSacrificiosDecomisosEntity.Relations.MsccatProductosEntityUsingIdProducto, True, signalRelatedEntity, "RegistroSacrificiosDecomisos", resetFKFields, New Integer() { CInt(RegistroSacrificiosDecomisosFieldIndex.IdProducto) } )
			_msccatProductos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductos(relatedEntity As IEntity)
			DesetupSyncMsccatProductos(True, True)
			_msccatProductos = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", RegistroSacrificiosDecomisosEntity.Relations.MsccatProductosEntityUsingIdProducto, True, _alreadyFetchedMsccatProductos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscmovtosAlmacenCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, True, signalRelatedEntity, "RegistroSacrificiosDecomisos", resetFKFields, New Integer() { CInt(RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen) } )
			_mscmovtosAlmacenCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscmovtosAlmacenCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscmovtosAlmacenCab(relatedEntity As IEntity)
			DesetupSyncMscmovtosAlmacenCab(True, True)
			_mscmovtosAlmacenCab = CType(relatedEntity, MscmovtosAlmacenCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscmovtosAlmacenCab, AddressOf OnMscmovtosAlmacenCabPropertyChanged, "MscmovtosAlmacenCab", RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, True, _alreadyFetchedMscmovtosAlmacenCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscmovtosAlmacenCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mscmovtosAlmacenCab_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscmovtosAlmacenCab_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscmovtosAlmacenCab_, AddressOf OnMscmovtosAlmacenCab_PropertyChanged, "MscmovtosAlmacenCab_", RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, True, signalRelatedEntity, "RegistroSacrificiosDecomisos_", resetFKFields, New Integer() { CInt(RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen) } )
			_mscmovtosAlmacenCab_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscmovtosAlmacenCab_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscmovtosAlmacenCab_(relatedEntity As IEntity)
			DesetupSyncMscmovtosAlmacenCab_(True, True)
			_mscmovtosAlmacenCab_ = CType(relatedEntity, MscmovtosAlmacenCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscmovtosAlmacenCab_, AddressOf OnMscmovtosAlmacenCab_PropertyChanged, "MscmovtosAlmacenCab_", RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, True, _alreadyFetchedMscmovtosAlmacenCab_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscmovtosAlmacenCab_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="idProducto">PK value for RegistroSacrificiosDecomisos which data should be fetched into this RegistroSacrificiosDecomisos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(loteSacrificio As System.String, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio)).ForcedCurrentValueWrite(loteSacrificio)
				MyBase.Fields(CInt(RegistroSacrificiosDecomisosFieldIndex.IdProducto)).ForcedCurrentValueWrite(idProducto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateRegistroSacrificiosDecomisosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New RegistroSacrificiosDecomisosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As RegistroSacrificiosDecomisosRelations
			Get	
				Return New RegistroSacrificiosDecomisosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, "__RegistroSacrificiosDecomisosEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MfacEmbarquesCabEntityUsingIdFolioEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, "__RegistroSacrificiosDecomisosEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MfacEmbarquesDetEntityUsingFolioSacrificioIdProducto, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscregistroSacrificioCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscregistroSacrificioCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscregistroSacrificioCabCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MscregistroSacrificioCabEntityUsingLoteSacrificio, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscregistroSacrificioCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscregistroSacrificioCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.AlmacenEntityUsingIdAlmacenProd, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MsccatProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioMovAlmacen, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCab_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					RegistroSacrificiosDecomisosEntity.Relations.MscmovtosAlmacenCabEntityUsingFolioCancelAlmacen, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscmovtosAlmacenCab_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "RegistroSacrificiosDecomisosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return RegistroSacrificiosDecomisosEntity.CustomProperties
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
				Return RegistroSacrificiosDecomisosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The LoteSacrificio property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."FolioSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [LoteSacrificio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.LoteSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Piezas property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."Piezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Piezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Piezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Piezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Kilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Decomiso property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."Decomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Decomiso]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Decomiso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Decomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdDecomiso property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."IdDecomiso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdDecomiso]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdDecomiso, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdDecomiso, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenProd property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."IdAlmacenProd"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenProd]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdAlmacenProd, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.IdAlmacenProd, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosSalida property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."KilosSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosSalida]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.KilosSalida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.KilosSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The PiezasSalida property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."PiezasSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PiezasSalida]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.PiezasSalida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.PiezasSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovAlmacen property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."FolioMovAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.FolioMovAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioCancelAlmacen property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."FolioCancelAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioCancelAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.FolioCancelAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosEmbarcados property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."KilosEmbarcados"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosEmbarcados]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.KilosEmbarcados, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.KilosEmbarcados, Integer), value)
			End Set
		End Property
	
		''' <summary>The PiezasEmbarcadas property of the Entity RegistroSacrificiosDecomisos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrProdRegistroSacrificiosProductos"."PiezasEmbarcadas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PiezasEmbarcadas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.PiezasEmbarcadas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDecomisosFieldIndex.PiezasEmbarcadas, Integer), value)
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
	
		''' <summary>Retrieves all related entities of type 'MscmovtosAlmacenCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
			Get
				Return GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet. When set to true, MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'MscregistroSacrificioCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscregistroSacrificioCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscregistroSacrificioCab]() As MscregistroSacrificioCabEntity
			Get
				Return GetSingleMscregistroSacrificioCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscregistroSacrificioCab(value)
				Else
					If value Is Nothing Then
						If Not _mscregistroSacrificioCab Is Nothing Then
							_mscregistroSacrificioCab.UnsetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscregistroSacrificioCab. When set to true, MscregistroSacrificioCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscregistroSacrificioCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscregistroSacrificioCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscregistroSacrificioCab As Boolean
			Get
				Return _alwaysFetchMscregistroSacrificioCab
			End Get
			Set
				_alwaysFetchMscregistroSacrificioCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscregistroSacrificioCab is not found
		''' in the database. When set to true, MscregistroSacrificioCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscregistroSacrificioCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscregistroSacrificioCabReturnsNewIfNotFound
			End Get
			Set
				_mscregistroSacrificioCabReturnsNewIfNotFound = value
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
							_almacen.UnsetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
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
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductos]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductos(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductos Is Nothing Then
							_msccatProductos.UnsetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductos. When set to true, MsccatProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductos is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductos
			End Get
			Set
				_alwaysFetchMsccatProductos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductos is not found
		''' in the database. When set to true, MsccatProductos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MscmovtosAlmacenCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscmovtosAlmacenCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscmovtosAlmacenCab]() As MscmovtosAlmacenCabEntity
			Get
				Return GetSingleMscmovtosAlmacenCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscmovtosAlmacenCab(value)
				Else
					If value Is Nothing Then
						If Not _mscmovtosAlmacenCab Is Nothing Then
							_mscmovtosAlmacenCab.UnsetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDecomisos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCab. When set to true, MscmovtosAlmacenCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscmovtosAlmacenCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCab As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCab
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscmovtosAlmacenCab is not found
		''' in the database. When set to true, MscmovtosAlmacenCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscmovtosAlmacenCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscmovtosAlmacenCabReturnsNewIfNotFound
			End Get
			Set
				_mscmovtosAlmacenCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MscmovtosAlmacenCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscmovtosAlmacenCab_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscmovtosAlmacenCab_]() As MscmovtosAlmacenCabEntity
			Get
				Return GetSingleMscmovtosAlmacenCab_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscmovtosAlmacenCab_(value)
				Else
					If value Is Nothing Then
						If Not _mscmovtosAlmacenCab_ Is Nothing Then
							_mscmovtosAlmacenCab_.UnsetRelatedEntity(Me, "RegistroSacrificiosDecomisos_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDecomisos_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscmovtosAlmacenCab_. When set to true, MscmovtosAlmacenCab_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscmovtosAlmacenCab_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscmovtosAlmacenCab_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscmovtosAlmacenCab_ As Boolean
			Get
				Return _alwaysFetchMscmovtosAlmacenCab_
			End Get
			Set
				_alwaysFetchMscmovtosAlmacenCab_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscmovtosAlmacenCab_ is not found
		''' in the database. When set to true, MscmovtosAlmacenCab_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscmovtosAlmacenCab_ReturnsNewIfNotFound As Boolean
			Get
				Return _mscmovtosAlmacenCab_ReturnsNewIfNotFound
			End Get
			Set
				_mscmovtosAlmacenCab_ReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity)
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
