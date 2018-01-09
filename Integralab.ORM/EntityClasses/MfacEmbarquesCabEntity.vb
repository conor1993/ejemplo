' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:20
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
	''' <summary>Entity class which represents the entity 'MfacEmbarquesCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MfacEmbarquesCabEntity 
#Else
	<Serializable()> _
	Public Class MfacEmbarquesCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _autCreditoEmb As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
		Private _alwaysFetchAutCreditoEmb, _alreadyFetchedAutCreditoEmb As Boolean
		Private _embarquesDet As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
		Private _alwaysFetchEmbarquesDet, _alreadyFetchedEmbarquesDet As Boolean
		Private _devolucionProductos As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
		Private _alwaysFetchDevolucionProductos, _alreadyFetchedDevolucionProductos As Boolean
		Private _serviciosXembarque As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
		Private _alwaysFetchServiciosXembarque, _alreadyFetchedServiciosXembarque As Boolean
		Private _facturasClientesCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
		Private _alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet, _alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet As Boolean
		Private _msccatProductosCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MsccatProductosCollection
		Private _alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet, _alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet As Boolean
		Private _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection
		Private _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet, _alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet As Boolean
		Private _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
		Private _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet, _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Boolean
		Private _msccatMotivoDevolucionCollectionViaDevolucionProductos As Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection
		Private _alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos, _alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos As Boolean
		Private _msccatProductosCollectionViaDevolucionProductos As Integralab.ORM.CollectionClasses.MsccatProductosCollection
		Private _alwaysFetchMsccatProductosCollectionViaDevolucionProductos, _alreadyFetchedMsccatProductosCollectionViaDevolucionProductos As Boolean
		Private _serviciosCollectionViaServiciosXembarque As Integralab.ORM.CollectionClasses.ServiciosCollection
		Private _alwaysFetchServiciosCollectionViaServiciosXembarque, _alreadyFetchedServiciosCollectionViaServiciosXembarque As Boolean
		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean
		Private _mfacCatClientes_ As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes_, _alreadyFetchedMfacCatClientes_, _mfacCatClientes_ReturnsNewIfNotFound As Boolean


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
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		Public Sub New(idFolioEmbarque As System.String)

			InitClassFetch(idFolioEmbarque, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idFolioEmbarque As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idFolioEmbarque, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="validator">The custom validator Object for this MfacEmbarquesCabEntity</param>
		Public Sub New(idFolioEmbarque As System.String, validator As IValidator)

			InitClassFetch(idFolioEmbarque, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_autCreditoEmb = CType(info.GetValue("_autCreditoEmb", GetType(Integralab.ORM.CollectionClasses.AutCreditoEmbCollection)), Integralab.ORM.CollectionClasses.AutCreditoEmbCollection)
			_alwaysFetchAutCreditoEmb = info.GetBoolean("_alwaysFetchAutCreditoEmb")
			_alreadyFetchedAutCreditoEmb = info.GetBoolean("_alreadyFetchedAutCreditoEmb")
			_embarquesDet = CType(info.GetValue("_embarquesDet", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection)
			_alwaysFetchEmbarquesDet = info.GetBoolean("_alwaysFetchEmbarquesDet")
			_alreadyFetchedEmbarquesDet = info.GetBoolean("_alreadyFetchedEmbarquesDet")
			_devolucionProductos = CType(info.GetValue("_devolucionProductos", GetType(Integralab.ORM.CollectionClasses.DevolucionProductosCollection)), Integralab.ORM.CollectionClasses.DevolucionProductosCollection)
			_alwaysFetchDevolucionProductos = info.GetBoolean("_alwaysFetchDevolucionProductos")
			_alreadyFetchedDevolucionProductos = info.GetBoolean("_alreadyFetchedDevolucionProductos")
			_serviciosXembarque = CType(info.GetValue("_serviciosXembarque", GetType(Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)), Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)
			_alwaysFetchServiciosXembarque = info.GetBoolean("_alwaysFetchServiciosXembarque")
			_alreadyFetchedServiciosXembarque = info.GetBoolean("_alreadyFetchedServiciosXembarque")
			_facturasClientesCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_facturasClientesCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)), Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)
			_alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet")
			_msccatProductosCollectionViaMfacEmbarquesDet = CType(info.GetValue("_msccatProductosCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MsccatProductosCollection)), Integralab.ORM.CollectionClasses.MsccatProductosCollection)
			_alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet")
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = CType(info.GetValue("_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)), Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection)
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet")
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet")
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = CType(info.GetValue("_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", GetType(Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)), Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection)
			_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet")
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = info.GetBoolean("_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet")
			_msccatMotivoDevolucionCollectionViaDevolucionProductos = CType(info.GetValue("_msccatMotivoDevolucionCollectionViaDevolucionProductos", GetType(Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection)), Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection)
			_alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos = info.GetBoolean("_alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos")
			_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos = info.GetBoolean("_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos")
			_msccatProductosCollectionViaDevolucionProductos = CType(info.GetValue("_msccatProductosCollectionViaDevolucionProductos", GetType(Integralab.ORM.CollectionClasses.MsccatProductosCollection)), Integralab.ORM.CollectionClasses.MsccatProductosCollection)
			_alwaysFetchMsccatProductosCollectionViaDevolucionProductos = info.GetBoolean("_alwaysFetchMsccatProductosCollectionViaDevolucionProductos")
			_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos = info.GetBoolean("_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos")
			_serviciosCollectionViaServiciosXembarque = CType(info.GetValue("_serviciosCollectionViaServiciosXembarque", GetType(Integralab.ORM.CollectionClasses.ServiciosCollection)), Integralab.ORM.CollectionClasses.ServiciosCollection)
			_alwaysFetchServiciosCollectionViaServiciosXembarque = info.GetBoolean("_alwaysFetchServiciosCollectionViaServiciosXembarque")
			_alreadyFetchedServiciosCollectionViaServiciosXembarque = info.GetBoolean("_alreadyFetchedServiciosCollectionViaServiciosXembarque")
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

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedAutCreditoEmb = (_autCreditoEmb.Count > 0)
			_alreadyFetchedEmbarquesDet = (_embarquesDet.Count > 0)
			_alreadyFetchedDevolucionProductos = (_devolucionProductos.Count > 0)
			_alreadyFetchedServiciosXembarque = (_serviciosXembarque.Count > 0)
			_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet = (_facturasClientesCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet = (_msccatProductosCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = (_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = (_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.Count > 0)
			_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos = (_msccatMotivoDevolucionCollectionViaDevolucionProductos.Count > 0)
			_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos = (_msccatProductosCollectionViaDevolucionProductos.Count > 0)
			_alreadyFetchedServiciosCollectionViaServiciosXembarque = (_serviciosCollectionViaServiciosXembarque.Count > 0)
			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)
			_alreadyFetchedMfacCatClientes_ = Not(_mfacCatClientes_ Is Nothing)

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
			info.AddValue("_autCreditoEmb", _autCreditoEmb)
			info.AddValue("_alwaysFetchAutCreditoEmb", _alwaysFetchAutCreditoEmb)
			info.AddValue("_alreadyFetchedAutCreditoEmb", _alreadyFetchedAutCreditoEmb)
			info.AddValue("_embarquesDet", _embarquesDet)
			info.AddValue("_alwaysFetchEmbarquesDet", _alwaysFetchEmbarquesDet)
			info.AddValue("_alreadyFetchedEmbarquesDet", _alreadyFetchedEmbarquesDet)
			info.AddValue("_devolucionProductos", _devolucionProductos)
			info.AddValue("_alwaysFetchDevolucionProductos", _alwaysFetchDevolucionProductos)
			info.AddValue("_alreadyFetchedDevolucionProductos", _alreadyFetchedDevolucionProductos)
			info.AddValue("_serviciosXembarque", _serviciosXembarque)
			info.AddValue("_alwaysFetchServiciosXembarque", _alwaysFetchServiciosXembarque)
			info.AddValue("_alreadyFetchedServiciosXembarque", _alreadyFetchedServiciosXembarque)
			info.AddValue("_facturasClientesCabCollectionViaMfacEmbarquesDet", _facturasClientesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet", _alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet", _alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_msccatProductosCollectionViaMfacEmbarquesDet", _msccatProductosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet", _alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet", _alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet)
			info.AddValue("_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", _alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet)
			info.AddValue("_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
			info.AddValue("_msccatMotivoDevolucionCollectionViaDevolucionProductos", _msccatMotivoDevolucionCollectionViaDevolucionProductos)
			info.AddValue("_alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos", _alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos)
			info.AddValue("_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos", _alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos)
			info.AddValue("_msccatProductosCollectionViaDevolucionProductos", _msccatProductosCollectionViaDevolucionProductos)
			info.AddValue("_alwaysFetchMsccatProductosCollectionViaDevolucionProductos", _alwaysFetchMsccatProductosCollectionViaDevolucionProductos)
			info.AddValue("_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos", _alreadyFetchedMsccatProductosCollectionViaDevolucionProductos)
			info.AddValue("_serviciosCollectionViaServiciosXembarque", _serviciosCollectionViaServiciosXembarque)
			info.AddValue("_alwaysFetchServiciosCollectionViaServiciosXembarque", _alwaysFetchServiciosCollectionViaServiciosXembarque)
			info.AddValue("_alreadyFetchedServiciosCollectionViaServiciosXembarque", _alreadyFetchedServiciosCollectionViaServiciosXembarque)
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			info.AddValue("_mfacCatClientes_", _mfacCatClientes_)
			info.AddValue("_mfacCatClientes_ReturnsNewIfNotFound", _mfacCatClientes_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes_", _alwaysFetchMfacCatClientes_)
			info.AddValue("_alreadyFetchedMfacCatClientes_", _alreadyFetchedMfacCatClientes_)

			
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
				Case "AutCreditoEmb"
					_alreadyFetchedAutCreditoEmb = True
					If Not entity Is Nothing Then
						Me.AutCreditoEmb.Add(CType(entity, AutCreditoEmbEntity))
					End If
				Case "EmbarquesDet"
					_alreadyFetchedEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.EmbarquesDet.Add(CType(entity, MfacEmbarquesDetEntity))
					End If
				Case "DevolucionProductos"
					_alreadyFetchedDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.DevolucionProductos.Add(CType(entity, DevolucionProductosEntity))
					End If
				Case "ServiciosXembarque"
					_alreadyFetchedServiciosXembarque = True
					If Not entity Is Nothing Then
						Me.ServiciosXembarque.Add(CType(entity, ServiciosXembarqueEntity))
					End If
				Case "FacturasClientesCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.FacturasClientesCabCollectionViaMfacEmbarquesDet.Add(CType(entity, FacturasClientesCabEntity))
					End If
				Case "MsccatProductosCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MsccatProductosCollectionViaMfacEmbarquesDet.Add(CType(entity, MsccatProductosEntity))
					End If
				Case "MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet"
					_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.Add(CType(entity, MscmovtosAlmacenCabEntity))
					End If
				Case "RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet"
					_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = True
					If Not entity Is Nothing Then
						Me.RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.Add(CType(entity, RegistroSacrificiosDecomisosEntity))
					End If
				Case "MsccatMotivoDevolucionCollectionViaDevolucionProductos"
					_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.MsccatMotivoDevolucionCollectionViaDevolucionProductos.Add(CType(entity, MsccatMotivoDevolucionEntity))
					End If
				Case "MsccatProductosCollectionViaDevolucionProductos"
					_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.MsccatProductosCollectionViaDevolucionProductos.Add(CType(entity, MsccatProductosEntity))
					End If
				Case "ServiciosCollectionViaServiciosXembarque"
					_alreadyFetchedServiciosCollectionViaServiciosXembarque = True
					If Not entity Is Nothing Then
						Me.ServiciosCollectionViaServiciosXembarque.Add(CType(entity, ServiciosEntity))
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
				Case "AutCreditoEmb"
					_autCreditoEmb.Add(CType(relatedEntity, AutCreditoEmbEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "EmbarquesDet"
					_embarquesDet.Add(CType(relatedEntity, MfacEmbarquesDetEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DevolucionProductos"
					_devolucionProductos.Add(CType(relatedEntity, DevolucionProductosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					_serviciosXembarque.Add(CType(relatedEntity, ServiciosXembarqueEntity))
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
				Case "AutCreditoEmb"
					MyBase.PerformRelatedEntityRemoval(_autCreditoEmb, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "EmbarquesDet"
					MyBase.PerformRelatedEntityRemoval(_embarquesDet, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DevolucionProductos"
					MyBase.PerformRelatedEntityRemoval(_devolucionProductos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					MyBase.PerformRelatedEntityRemoval(_serviciosXembarque, relatedEntity, signalRelatedEntityManyToOne)
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


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_autCreditoEmb)
			toReturn.Add(_embarquesDet)
			toReturn.Add(_devolucionProductos)
			toReturn.Add(_serviciosXembarque)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String) As Boolean
			Return FetchUsingPK(idFolioEmbarque, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idFolioEmbarque, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idFolioEmbarque As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idFolioEmbarque, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdFolioEmbarque, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MfacEmbarquesCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MfacEmbarquesCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'AutCreditoEmbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AutCreditoEmbEntity'</returns>
		Public Function GetMultiAutCreditoEmb(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
			Return GetMultiAutCreditoEmb(forceFetch, _autCreditoEmb.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AutCreditoEmbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAutCreditoEmb(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
			Return GetMultiAutCreditoEmb(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AutCreditoEmbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AutCreditoEmbEntity'</returns>
		Public Function GetMultiAutCreditoEmb(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
			Return GetMultiAutCreditoEmb(forceFetch, _autCreditoEmb.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AutCreditoEmbEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAutCreditoEmb(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
			If ( Not _alreadyFetchedAutCreditoEmb Or forceFetch Or _alwaysFetchAutCreditoEmb) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _autCreditoEmb.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_autCreditoEmb)
					End If
				End If
				_autCreditoEmb.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_autCreditoEmb.EntityFactoryToUse = entityFactoryToUse
				End If
				_autCreditoEmb.GetMultiManyToOne(Me, Filter)
				_autCreditoEmb.SuppressClearInGetMulti = False
				_alreadyFetchedAutCreditoEmb = True
			End If
			Return _autCreditoEmb
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AutCreditoEmb'. These settings will be taken into account
		''' when the property AutCreditoEmb is requested or GetMultiAutCreditoEmb is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAutCreditoEmb(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_autCreditoEmb.SortClauses=sortClauses
			_autCreditoEmb.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiEmbarquesDet(forceFetch, _embarquesDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiEmbarquesDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesDetEntity'</returns>
		Public Function GetMultiEmbarquesDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Return GetMultiEmbarquesDet(forceFetch, _embarquesDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			If ( Not _alreadyFetchedEmbarquesDet Or forceFetch Or _alwaysFetchEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _embarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_embarquesDet)
					End If
				End If
				_embarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_embarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_embarquesDet.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Nothing, Filter)
				_embarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedEmbarquesDet = True
			End If
			Return _embarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'EmbarquesDet'. These settings will be taken into account
		''' when the property EmbarquesDet is requested or GetMultiEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_embarquesDet.SortClauses=sortClauses
			_embarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DevolucionProductosEntity'</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, _devolucionProductos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DevolucionProductosEntity'</returns>
		Public Function GetMultiDevolucionProductos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Return GetMultiDevolucionProductos(forceFetch, _devolucionProductos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			If ( Not _alreadyFetchedDevolucionProductos Or forceFetch Or _alwaysFetchDevolucionProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _devolucionProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_devolucionProductos)
					End If
				End If
				_devolucionProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_devolucionProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_devolucionProductos.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_devolucionProductos.SuppressClearInGetMulti = False
				_alreadyFetchedDevolucionProductos = True
			End If
			Return _devolucionProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DevolucionProductos'. These settings will be taken into account
		''' when the property DevolucionProductos is requested or GetMultiDevolucionProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDevolucionProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_devolucionProductos.SortClauses=sortClauses
			_devolucionProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosXembarqueEntity'</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, _serviciosXembarque.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosXembarqueEntity'</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, _serviciosXembarque.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			If ( Not _alreadyFetchedServiciosXembarque Or forceFetch Or _alwaysFetchServiciosXembarque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _serviciosXembarque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_serviciosXembarque)
					End If
				End If
				_serviciosXembarque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_serviciosXembarque.EntityFactoryToUse = entityFactoryToUse
				End If
				_serviciosXembarque.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_serviciosXembarque.SuppressClearInGetMulti = False
				_alreadyFetchedServiciosXembarque = True
			End If
			Return _serviciosXembarque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ServiciosXembarque'. These settings will be taken into account
		''' when the property ServiciosXembarque is requested or GetMultiServiciosXembarque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersServiciosXembarque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_serviciosXembarque.SortClauses=sortClauses
			_serviciosXembarque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet(forceFetch, _facturasClientesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			If ( Not _alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesCabCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesCabCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_facturasClientesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesCabCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesCabCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_facturasClientesCabCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet = True
			End If
			Return _facturasClientesCabCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesCabCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property FacturasClientesCabCollectionViaMfacEmbarquesDet is requested or GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesCabCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesCabCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_facturasClientesCabCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosEntity'</returns>
		Public Function GetMultiMsccatProductosCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductosCollectionViaMfacEmbarquesDet(forceFetch, _msccatProductosCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductosCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			If ( Not _alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductosCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductosCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_msccatProductosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductosCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductosCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_msccatProductosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet = True
			End If
			Return _msccatProductosCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductosCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property MsccatProductosCollectionViaMfacEmbarquesDet is requested or GetMultiMsccatProductosCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductosCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductosCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_msccatProductosCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
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

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RegistroSacrificiosDecomisosEntity'</returns>
		Public Function GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Return GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch, _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			If ( Not _alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet Or forceFetch Or _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", "MfacEmbarquesDet_", JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto, "MfacEmbarquesDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.GetMulti(Filter, relations)
				_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SuppressClearInGetMulti = False
				_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = True
			End If
			Return _registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet'. These settings will be taken into account
		''' when the property RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is requested or GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.SortClauses=sortClauses
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatMotivoDevolucionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatMotivoDevolucionEntity'</returns>
		Public Function GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection
			Return GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos(forceFetch, _msccatMotivoDevolucionCollectionViaDevolucionProductos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatMotivoDevolucionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection
			If ( Not _alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos Or forceFetch Or _alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatMotivoDevolucionCollectionViaDevolucionProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatMotivoDevolucionCollectionViaDevolucionProductos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, "__MfacEmbarquesCabEntity__", "DevolucionProductos_", JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion, "DevolucionProductos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_msccatMotivoDevolucionCollectionViaDevolucionProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatMotivoDevolucionCollectionViaDevolucionProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatMotivoDevolucionCollectionViaDevolucionProductos.GetMulti(Filter, relations)
				_msccatMotivoDevolucionCollectionViaDevolucionProductos.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos = True
			End If
			Return _msccatMotivoDevolucionCollectionViaDevolucionProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatMotivoDevolucionCollectionViaDevolucionProductos'. These settings will be taken into account
		''' when the property MsccatMotivoDevolucionCollectionViaDevolucionProductos is requested or GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatMotivoDevolucionCollectionViaDevolucionProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatMotivoDevolucionCollectionViaDevolucionProductos.SortClauses=sortClauses
			_msccatMotivoDevolucionCollectionViaDevolucionProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MsccatProductosEntity'</returns>
		Public Function GetMultiMsccatProductosCollectionViaDevolucionProductos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Return GetMultiMsccatProductosCollectionViaDevolucionProductos(forceFetch, _msccatProductosCollectionViaDevolucionProductos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMsccatProductosCollectionViaDevolucionProductos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			If ( Not _alreadyFetchedMsccatProductosCollectionViaDevolucionProductos Or forceFetch Or _alwaysFetchMsccatProductosCollectionViaDevolucionProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _msccatProductosCollectionViaDevolucionProductos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_msccatProductosCollectionViaDevolucionProductos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, "__MfacEmbarquesCabEntity__", "DevolucionProductos_", JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto, "DevolucionProductos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_msccatProductosCollectionViaDevolucionProductos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_msccatProductosCollectionViaDevolucionProductos.EntityFactoryToUse = entityFactoryToUse
				End If
				_msccatProductosCollectionViaDevolucionProductos.GetMulti(Filter, relations)
				_msccatProductosCollectionViaDevolucionProductos.SuppressClearInGetMulti = False
				_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos = True
			End If
			Return _msccatProductosCollectionViaDevolucionProductos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MsccatProductosCollectionViaDevolucionProductos'. These settings will be taken into account
		''' when the property MsccatProductosCollectionViaDevolucionProductos is requested or GetMultiMsccatProductosCollectionViaDevolucionProductos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMsccatProductosCollectionViaDevolucionProductos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_msccatProductosCollectionViaDevolucionProductos.SortClauses=sortClauses
			_msccatProductosCollectionViaDevolucionProductos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ServiciosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosEntity'</returns>
		Public Function GetMultiServiciosCollectionViaServiciosXembarque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ServiciosCollection
			Return GetMultiServiciosCollectionViaServiciosXembarque(forceFetch, _serviciosCollectionViaServiciosXembarque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiServiciosCollectionViaServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ServiciosCollection
			If ( Not _alreadyFetchedServiciosCollectionViaServiciosXembarque Or forceFetch Or _alwaysFetchServiciosCollectionViaServiciosXembarque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _serviciosCollectionViaServiciosXembarque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_serviciosCollectionViaServiciosXembarque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MfacEmbarquesCabEntity.Relations.ServiciosXembarqueEntityUsingFoloEmbarque, "__MfacEmbarquesCabEntity__", "ServiciosXembarque_", JoinHint.None)
				relations.Add(ServiciosXembarqueEntity.Relations.ServiciosEntityUsingIdServicio, "ServiciosXembarque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MfacEmbarquesCabFieldIndex.IdFolioEmbarque), ComparisonOperator.Equal, Me.IdFolioEmbarque))
				_serviciosCollectionViaServiciosXembarque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_serviciosCollectionViaServiciosXembarque.EntityFactoryToUse = entityFactoryToUse
				End If
				_serviciosCollectionViaServiciosXembarque.GetMulti(Filter, relations)
				_serviciosCollectionViaServiciosXembarque.SuppressClearInGetMulti = False
				_alreadyFetchedServiciosCollectionViaServiciosXembarque = True
			End If
			Return _serviciosCollectionViaServiciosXembarque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ServiciosCollectionViaServiciosXembarque'. These settings will be taken into account
		''' when the property ServiciosCollectionViaServiciosXembarque is requested or GetMultiServiciosCollectionViaServiciosXembarque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersServiciosCollectionViaServiciosXembarque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_serviciosCollectionViaServiciosXembarque.SortClauses=sortClauses
			_serviciosCollectionViaServiciosXembarque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteAsignado) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdClienteAsignado)
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(MfacEmbarquesCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MfacEmbarquesCabFieldIndex)




					Case MfacEmbarquesCabFieldIndex.IdCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False















					Case MfacEmbarquesCabFieldIndex.IdClienteAsignado
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
			_autCreditoEmb.ActiveContext = MyBase.ActiveContext
			_embarquesDet.ActiveContext = MyBase.ActiveContext
			_devolucionProductos.ActiveContext = MyBase.ActiveContext
			_serviciosXembarque.ActiveContext = MyBase.ActiveContext
			_facturasClientesCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_msccatProductosCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet.ActiveContext = MyBase.ActiveContext
			_msccatMotivoDevolucionCollectionViaDevolucionProductos.ActiveContext = MyBase.ActiveContext
			_msccatProductosCollectionViaDevolucionProductos.ActiveContext = MyBase.ActiveContext
			_serviciosCollectionViaServiciosXembarque.ActiveContext = MyBase.ActiveContext
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes_ Is Nothing Then
				_mfacCatClientes_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MfacEmbarquesCabDAO = CType(CreateDAOInstance(), MfacEmbarquesCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MfacEmbarquesCabDAO = CType(CreateDAOInstance(), MfacEmbarquesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MfacEmbarquesCabDAO = CType(CreateDAOInstance(), MfacEmbarquesCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MfacEmbarquesCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MfacEmbarquesCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="validator">The validator Object for this MfacEmbarquesCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idFolioEmbarque As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idFolioEmbarque, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_autCreditoEmb = New Integralab.ORM.CollectionClasses.AutCreditoEmbCollection(New AutCreditoEmbEntityFactory())
			_autCreditoEmb.SetContainingEntityInfo(Me, "MfacEmbarquesCab")
			_alwaysFetchAutCreditoEmb = False
			_alreadyFetchedAutCreditoEmb = False
			_embarquesDet = New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(New MfacEmbarquesDetEntityFactory())
			_embarquesDet.SetContainingEntityInfo(Me, "MfacEmbarquesCab")
			_alwaysFetchEmbarquesDet = False
			_alreadyFetchedEmbarquesDet = False
			_devolucionProductos = New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(New DevolucionProductosEntityFactory())
			_devolucionProductos.SetContainingEntityInfo(Me, "MfacEmbarquesCab")
			_alwaysFetchDevolucionProductos = False
			_alreadyFetchedDevolucionProductos = False
			_serviciosXembarque = New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(New ServiciosXembarqueEntityFactory())
			_serviciosXembarque.SetContainingEntityInfo(Me, "MfacEmbarquesCab")
			_alwaysFetchServiciosXembarque = False
			_alreadyFetchedServiciosXembarque = False
			_facturasClientesCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(New FacturasClientesCabEntityFactory())
			_alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedFacturasClientesCabCollectionViaMfacEmbarquesDet = False
			_msccatProductosCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MsccatProductosCollection(New MsccatProductosEntityFactory())
			_alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMsccatProductosCollectionViaMfacEmbarquesDet = False
			_mscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(New MscmovtosAlmacenCabEntityFactory())
			_alwaysFetchMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet = False
			_registroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(New RegistroSacrificiosDecomisosEntityFactory())
			_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = False
			_alreadyFetchedRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = False
			_msccatMotivoDevolucionCollectionViaDevolucionProductos = New Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection(New MsccatMotivoDevolucionEntityFactory())
			_alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos = False
			_alreadyFetchedMsccatMotivoDevolucionCollectionViaDevolucionProductos = False
			_msccatProductosCollectionViaDevolucionProductos = New Integralab.ORM.CollectionClasses.MsccatProductosCollection(New MsccatProductosEntityFactory())
			_alwaysFetchMsccatProductosCollectionViaDevolucionProductos = False
			_alreadyFetchedMsccatProductosCollectionViaDevolucionProductos = False
			_serviciosCollectionViaServiciosXembarque = New Integralab.ORM.CollectionClasses.ServiciosCollection(New ServiciosEntityFactory())
			_alwaysFetchServiciosCollectionViaServiciosXembarque = False
			_alreadyFetchedServiciosCollectionViaServiciosXembarque = False
			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			_mfacCatClientes_ = Nothing
			_mfacCatClientes_ReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes_ = False
			_alreadyFetchedMfacCatClientes_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEmbarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaEmbarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdVehiculo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdChofer", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalPiezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalKgrs", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPuntoEntrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalCajas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioEmbarqueEmp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAutorizo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Exportacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdClienteAsignado", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "MfacEmbarquesCab", resetFKFields, New Integer() { CInt(MfacEmbarquesCabFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes_, AddressOf OnMfacCatClientes_PropertyChanged, "MfacCatClientes_", MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteAsignado, True, signalRelatedEntity, "MfacEmbarquesCab_", resetFKFields, New Integer() { CInt(MfacEmbarquesCabFieldIndex.IdClienteAsignado) } )
			_mfacCatClientes_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes_(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes_(True, True)
			_mfacCatClientes_ = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes_, AddressOf OnMfacCatClientes_PropertyChanged, "MfacCatClientes_", MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteAsignado, True, _alreadyFetchedMfacCatClientes_, New String() {  } )
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



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idFolioEmbarque">PK value for MfacEmbarquesCab which data should be fetched into this MfacEmbarquesCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idFolioEmbarque As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MfacEmbarquesCabFieldIndex.IdFolioEmbarque)).ForcedCurrentValueWrite(idFolioEmbarque)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMfacEmbarquesCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MfacEmbarquesCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MfacEmbarquesCabRelations
			Get	
				Return New MfacEmbarquesCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AutCreditoEmb' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAutCreditoEmb() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AutCreditoEmbCollection(), _
					MfacEmbarquesCabEntity.Relations.AutCreditoEmbEntityUsingFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.AutCreditoEmbEntity, Integer), 0, Nothing, Nothing, Nothing, "AutCreditoEmb", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathEmbarquesDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesDetEntity, Integer), 0, Nothing, Nothing, Nothing, "EmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DevolucionProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDevolucionProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(), _
					MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "DevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiciosXembarque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathServiciosXembarque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(), _
					MfacEmbarquesCabEntity.Relations.ServiciosXembarqueEntityUsingFoloEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.ServiciosXembarqueEntity, Integer), 0, Nothing, Nothing, Nothing, "ServiciosXembarque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaNoFactura)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, relations, "FacturasClientesCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MsccatProductosEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, relations, "MsccatProductosCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscmovtosAlmacenCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscmovtosAlmacenCabCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.MscmovtosAlmacenCabEntityUsingIdFolioMovimientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscmovtosAlmacenCabCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MscmovtosAlmacenCabEntity, Integer), 0, Nothing, Nothing, relations, "MscmovtosAlmacenCabCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosDecomisos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(MfacEmbarquesDetEntity.Relations.RegistroSacrificiosDecomisosEntityUsingFolioSacrificioIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacEmbarquesDetEntityUsingIdFolioEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosDecomisosEntity, Integer), 0, Nothing, Nothing, relations, "RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatMotivoDevolucion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatMotivoDevolucionCollectionViaDevolucionProductos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection(), _
					MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MsccatMotivoDevolucionEntity, Integer), 0, Nothing, Nothing, relations, "MsccatMotivoDevolucionCollectionViaDevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductosCollectionViaDevolucionProductos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					MfacEmbarquesCabEntity.Relations.DevolucionProductosEntityUsingEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, relations, "MsccatProductosCollectionViaDevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Servicios' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathServiciosCollectionViaServiciosXembarque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MfacEmbarquesCabEntity.Relations.ServiciosXembarqueEntityUsingFoloEmbarque, "__MfacEmbarquesCabEntity__", String.Empty, JoinHint.None)
				relations.Add(ServiciosXembarqueEntity.Relations.ServiciosEntityUsingIdServicio)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ServiciosCollection(), _
					MfacEmbarquesCabEntity.Relations.ServiciosXembarqueEntityUsingFoloEmbarque, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.ServiciosEntity, Integer), 0, Nothing, Nothing, relations, "ServiciosCollectionViaServiciosXembarque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					MfacEmbarquesCabEntity.Relations.MfacCatClientesEntityUsingIdClienteAsignado, _
					CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MfacEmbarquesCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MfacEmbarquesCabEntity.CustomProperties
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
				Return MfacEmbarquesCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdFolioEmbarque property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdFolioEmbarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdFolioEmbarque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdFolioEmbarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdFolioEmbarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaEmbarque property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."FechaEmbarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaEmbarque]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaEmbarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaEmbarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdVehiculo property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdVehiculo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdVehiculo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdVehiculo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdVehiculo, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdChofer property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdChofer"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdChofer]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdChofer, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdChofer, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalPiezas property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."TotalPiezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalPiezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalPiezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalPiezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalKgrs property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."TotalKgrs"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalKgrs]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalKgrs, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalKgrs, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEstado property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPuntoEntrega property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdPuntoEntrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPuntoEntrega]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdPuntoEntrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdPuntoEntrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalCajas property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."TotalCajas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalCajas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalCajas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.TotalCajas, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioMovimiento property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdFolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdFolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdFolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdFolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoFactura property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioEmbarqueEmp property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."FolioEmbarqueEmp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioEmbarqueEmp]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.FolioEmbarqueEmp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.FolioEmbarqueEmp, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAutorizo property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdUsuarioAutorizo"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAutorizo]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdUsuarioAutorizo, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdUsuarioAutorizo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Exportacion property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."Exportacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Exportacion]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.Exportacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.Exportacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdClienteAsignado property of the Entity MfacEmbarquesCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacEmbarquesCab"."IdClienteAsignado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdClienteAsignado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacEmbarquesCabFieldIndex.IdClienteAsignado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacEmbarquesCabFieldIndex.IdClienteAsignado, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AutCreditoEmbEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAutCreditoEmb()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AutCreditoEmb]() As Integralab.ORM.CollectionClasses.AutCreditoEmbCollection
			Get
				Return GetMultiAutCreditoEmb(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AutCreditoEmb. When set to true, AutCreditoEmb is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AutCreditoEmb is accessed. You can always execute
		''' a forced fetch by calling GetMultiAutCreditoEmb(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAutCreditoEmb As Boolean
			Get
				Return _alwaysFetchAutCreditoEmb
			End Get
			Set
				_alwaysFetchAutCreditoEmb = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [EmbarquesDet]() As Integralab.ORM.CollectionClasses.MfacEmbarquesDetCollection
			Get
				Return GetMultiEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for EmbarquesDet. When set to true, EmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time EmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchEmbarquesDet As Boolean
			Get
				Return _alwaysFetchEmbarquesDet
			End Get
			Set
				_alwaysFetchEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DevolucionProductosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDevolucionProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DevolucionProductos]() As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
			Get
				Return GetMultiDevolucionProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DevolucionProductos. When set to true, DevolucionProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DevolucionProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiDevolucionProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDevolucionProductos As Boolean
			Get
				Return _alwaysFetchDevolucionProductos
			End Get
			Set
				_alwaysFetchDevolucionProductos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiciosXembarque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ServiciosXembarque]() As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Get
				Return GetMultiServiciosXembarque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ServiciosXembarque. When set to true, ServiciosXembarque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ServiciosXembarque is accessed. You can always execute
		''' a forced fetch by calling GetMultiServiciosXembarque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchServiciosXembarque As Boolean
			Get
				Return _alwaysFetchServiciosXembarque
			End Get
			Set
				_alwaysFetchServiciosXembarque = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesCabCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Get
				Return GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCabCollectionViaMfacEmbarquesDet. When set to true, FacturasClientesCabCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCabCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesCabCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchFacturasClientesCabCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductosCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductosCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Get
				Return GetMultiMsccatProductosCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosCollectionViaMfacEmbarquesDet. When set to true, MsccatProductosCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductosCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchMsccatProductosCollectionViaMfacEmbarquesDet = value
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
	
		''' <summary>Retrieves all related entities of type 'RegistroSacrificiosDecomisosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet]() As Integralab.ORM.CollectionClasses.RegistroSacrificiosDecomisosCollection
			Get
				Return GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet. When set to true, RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet
			End Get
			Set
				_alwaysFetchRegistroSacrificiosDecomisosCollectionViaMfacEmbarquesDet = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatMotivoDevolucionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatMotivoDevolucionCollectionViaDevolucionProductos]() As Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection
			Get
				Return GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatMotivoDevolucionCollectionViaDevolucionProductos. When set to true, MsccatMotivoDevolucionCollectionViaDevolucionProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatMotivoDevolucionCollectionViaDevolucionProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatMotivoDevolucionCollectionViaDevolucionProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos As Boolean
			Get
				Return _alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos
			End Get
			Set
				_alwaysFetchMsccatMotivoDevolucionCollectionViaDevolucionProductos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MsccatProductosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMsccatProductosCollectionViaDevolucionProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MsccatProductosCollectionViaDevolucionProductos]() As Integralab.ORM.CollectionClasses.MsccatProductosCollection
			Get
				Return GetMultiMsccatProductosCollectionViaDevolucionProductos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductosCollectionViaDevolucionProductos. When set to true, MsccatProductosCollectionViaDevolucionProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductosCollectionViaDevolucionProductos is accessed. You can always execute
		''' a forced fetch by calling GetMultiMsccatProductosCollectionViaDevolucionProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductosCollectionViaDevolucionProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductosCollectionViaDevolucionProductos
			End Get
			Set
				_alwaysFetchMsccatProductosCollectionViaDevolucionProductos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ServiciosEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiciosCollectionViaServiciosXembarque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ServiciosCollectionViaServiciosXembarque]() As Integralab.ORM.CollectionClasses.ServiciosCollection
			Get
				Return GetMultiServiciosCollectionViaServiciosXembarque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ServiciosCollectionViaServiciosXembarque. When set to true, ServiciosCollectionViaServiciosXembarque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ServiciosCollectionViaServiciosXembarque is accessed. You can always execute
		''' a forced fetch by calling GetMultiServiciosCollectionViaServiciosXembarque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchServiciosCollectionViaServiciosXembarque As Boolean
			Get
				Return _alwaysFetchServiciosCollectionViaServiciosXembarque
			End Get
			Set
				_alwaysFetchServiciosCollectionViaServiciosXembarque = value
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
							_mfacCatClientes.UnsetRelatedEntity(Me, "MfacEmbarquesCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesCab")
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
							_mfacCatClientes_.UnsetRelatedEntity(Me, "MfacEmbarquesCab_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacEmbarquesCab_")
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
				Return CInt(Integralab.ORM.EntityType.MfacEmbarquesCabEntity)
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
