' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 09:23:47
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
	''' <summary>Entity class which represents the entity 'MfacCatClientes'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MfacCatClientesEntity 
#Else
	<Serializable()> _
	Public Class MfacCatClientesEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _recepcionGanado As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
		Private _alwaysFetchRecepcionGanado, _alreadyFetchedRecepcionGanado As Boolean
		Private _chequeDevuelto As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
		Private _alwaysFetchChequeDevuelto, _alreadyFetchedChequeDevuelto As Boolean
		Private _chequesPos As Integralab.ORM.CollectionClasses.ChequesPosCollection
		Private _alwaysFetchChequesPos, _alreadyFetchedChequesPos As Boolean
		Private _facturasClientesCab As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
		Private _alwaysFetchFacturasClientesCab, _alreadyFetchedFacturasClientesCab As Boolean
		Private _facturasClientesCab_ As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
		Private _alwaysFetchFacturasClientesCab_, _alreadyFetchedFacturasClientesCab_ As Boolean
		Private _mfacEmbarquesCab As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCab, _alreadyFetchedMfacEmbarquesCab As Boolean
		Private _mfacEmbarquesCab_ As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCab_, _alreadyFetchedMfacEmbarquesCab_ As Boolean
		Private _mgralcatPuntosEntrega As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
		Private _alwaysFetchMgralcatPuntosEntrega, _alreadyFetchedMgralcatPuntosEntrega As Boolean
		Private _devolucionProductos As Integralab.ORM.CollectionClasses.DevolucionProductosCollection
		Private _alwaysFetchDevolucionProductos, _alreadyFetchedDevolucionProductos As Boolean
		Private _mscrelacionCortesClientes As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
		Private _alwaysFetchMscrelacionCortesClientes, _alreadyFetchedMscrelacionCortesClientes As Boolean
		Private _notaCreditoCab As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
		Private _alwaysFetchNotaCreditoCab, _alreadyFetchedNotaCreditoCab As Boolean
		Private _pagoDeCtes As Integralab.ORM.CollectionClasses.PagoDeCtesCollection
		Private _alwaysFetchPagoDeCtes, _alreadyFetchedPagoDeCtes As Boolean
		Private _serviciosXembarque As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
		Private _alwaysFetchServiciosXembarque, _alreadyFetchedServiciosXembarque As Boolean

		Private _comicionista As ComicionistaEntity
		Private _alwaysFetchComicionista, _alreadyFetchedComicionista, _comicionistaReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean
		Private _cuentaContable_ As CuentaContableEntity
		Private _alwaysFetchCuentaContable_, _alreadyFetchedCuentaContable_, _cuentaContable_ReturnsNewIfNotFound As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean

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
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		Public Sub New(idCliente As System.Int32)

			InitClassFetch(idCliente, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCliente As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCliente, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="validator">The custom validator Object for this MfacCatClientesEntity</param>
		Public Sub New(idCliente As System.Int32, validator As IValidator)

			InitClassFetch(idCliente, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_recepcionGanado = CType(info.GetValue("_recepcionGanado", GetType(Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)), Integralab.ORM.CollectionClasses.RecepcionGanadoCollection)
			_alwaysFetchRecepcionGanado = info.GetBoolean("_alwaysFetchRecepcionGanado")
			_alreadyFetchedRecepcionGanado = info.GetBoolean("_alreadyFetchedRecepcionGanado")
			_chequeDevuelto = CType(info.GetValue("_chequeDevuelto", GetType(Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)), Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)
			_alwaysFetchChequeDevuelto = info.GetBoolean("_alwaysFetchChequeDevuelto")
			_alreadyFetchedChequeDevuelto = info.GetBoolean("_alreadyFetchedChequeDevuelto")
			_chequesPos = CType(info.GetValue("_chequesPos", GetType(Integralab.ORM.CollectionClasses.ChequesPosCollection)), Integralab.ORM.CollectionClasses.ChequesPosCollection)
			_alwaysFetchChequesPos = info.GetBoolean("_alwaysFetchChequesPos")
			_alreadyFetchedChequesPos = info.GetBoolean("_alreadyFetchedChequesPos")
			_facturasClientesCab = CType(info.GetValue("_facturasClientesCab", GetType(Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)), Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)
			_alwaysFetchFacturasClientesCab = info.GetBoolean("_alwaysFetchFacturasClientesCab")
			_alreadyFetchedFacturasClientesCab = info.GetBoolean("_alreadyFetchedFacturasClientesCab")
			_facturasClientesCab_ = CType(info.GetValue("_facturasClientesCab_", GetType(Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)), Integralab.ORM.CollectionClasses.FacturasClientesCabCollection)
			_alwaysFetchFacturasClientesCab_ = info.GetBoolean("_alwaysFetchFacturasClientesCab_")
			_alreadyFetchedFacturasClientesCab_ = info.GetBoolean("_alreadyFetchedFacturasClientesCab_")
			_mfacEmbarquesCab = CType(info.GetValue("_mfacEmbarquesCab", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCab = info.GetBoolean("_alwaysFetchMfacEmbarquesCab")
			_alreadyFetchedMfacEmbarquesCab = info.GetBoolean("_alreadyFetchedMfacEmbarquesCab")
			_mfacEmbarquesCab_ = CType(info.GetValue("_mfacEmbarquesCab_", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCab_ = info.GetBoolean("_alwaysFetchMfacEmbarquesCab_")
			_alreadyFetchedMfacEmbarquesCab_ = info.GetBoolean("_alreadyFetchedMfacEmbarquesCab_")
			_mgralcatPuntosEntrega = CType(info.GetValue("_mgralcatPuntosEntrega", GetType(Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection)), Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection)
			_alwaysFetchMgralcatPuntosEntrega = info.GetBoolean("_alwaysFetchMgralcatPuntosEntrega")
			_alreadyFetchedMgralcatPuntosEntrega = info.GetBoolean("_alreadyFetchedMgralcatPuntosEntrega")
			_devolucionProductos = CType(info.GetValue("_devolucionProductos", GetType(Integralab.ORM.CollectionClasses.DevolucionProductosCollection)), Integralab.ORM.CollectionClasses.DevolucionProductosCollection)
			_alwaysFetchDevolucionProductos = info.GetBoolean("_alwaysFetchDevolucionProductos")
			_alreadyFetchedDevolucionProductos = info.GetBoolean("_alreadyFetchedDevolucionProductos")
			_mscrelacionCortesClientes = CType(info.GetValue("_mscrelacionCortesClientes", GetType(Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)), Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)
			_alwaysFetchMscrelacionCortesClientes = info.GetBoolean("_alwaysFetchMscrelacionCortesClientes")
			_alreadyFetchedMscrelacionCortesClientes = info.GetBoolean("_alreadyFetchedMscrelacionCortesClientes")
			_notaCreditoCab = CType(info.GetValue("_notaCreditoCab", GetType(Integralab.ORM.CollectionClasses.NotaCreditoCabCollection)), Integralab.ORM.CollectionClasses.NotaCreditoCabCollection)
			_alwaysFetchNotaCreditoCab = info.GetBoolean("_alwaysFetchNotaCreditoCab")
			_alreadyFetchedNotaCreditoCab = info.GetBoolean("_alreadyFetchedNotaCreditoCab")
			_pagoDeCtes = CType(info.GetValue("_pagoDeCtes", GetType(Integralab.ORM.CollectionClasses.PagoDeCtesCollection)), Integralab.ORM.CollectionClasses.PagoDeCtesCollection)
			_alwaysFetchPagoDeCtes = info.GetBoolean("_alwaysFetchPagoDeCtes")
			_alreadyFetchedPagoDeCtes = info.GetBoolean("_alreadyFetchedPagoDeCtes")
			_serviciosXembarque = CType(info.GetValue("_serviciosXembarque", GetType(Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)), Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)
			_alwaysFetchServiciosXembarque = info.GetBoolean("_alwaysFetchServiciosXembarque")
			_alreadyFetchedServiciosXembarque = info.GetBoolean("_alreadyFetchedServiciosXembarque")

			_comicionista = CType(info.GetValue("_comicionista", GetType(ComicionistaEntity)), ComicionistaEntity)
			If Not _comicionista Is Nothing Then
				AddHandler _comicionista.AfterSave, AddressOf OnEntityAfterSave
			End If
			_comicionistaReturnsNewIfNotFound = info.GetBoolean("_comicionistaReturnsNewIfNotFound")
			_alwaysFetchComicionista = info.GetBoolean("_alwaysFetchComicionista")
			_alreadyFetchedComicionista = info.GetBoolean("_alreadyFetchedComicionista")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_cuentaContable_ = CType(info.GetValue("_cuentaContable_", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable_ Is Nothing Then
				AddHandler _cuentaContable_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContable_ReturnsNewIfNotFound = info.GetBoolean("_cuentaContable_ReturnsNewIfNotFound")
			_alwaysFetchCuentaContable_ = info.GetBoolean("_alwaysFetchCuentaContable_")
			_alreadyFetchedCuentaContable_ = info.GetBoolean("_alreadyFetchedCuentaContable_")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				' rewire event handler.
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedRecepcionGanado = (_recepcionGanado.Count > 0)
			_alreadyFetchedChequeDevuelto = (_chequeDevuelto.Count > 0)
			_alreadyFetchedChequesPos = (_chequesPos.Count > 0)
			_alreadyFetchedFacturasClientesCab = (_facturasClientesCab.Count > 0)
			_alreadyFetchedFacturasClientesCab_ = (_facturasClientesCab_.Count > 0)
			_alreadyFetchedMfacEmbarquesCab = (_mfacEmbarquesCab.Count > 0)
			_alreadyFetchedMfacEmbarquesCab_ = (_mfacEmbarquesCab_.Count > 0)
			_alreadyFetchedMgralcatPuntosEntrega = (_mgralcatPuntosEntrega.Count > 0)
			_alreadyFetchedDevolucionProductos = (_devolucionProductos.Count > 0)
			_alreadyFetchedMscrelacionCortesClientes = (_mscrelacionCortesClientes.Count > 0)
			_alreadyFetchedNotaCreditoCab = (_notaCreditoCab.Count > 0)
			_alreadyFetchedPagoDeCtes = (_pagoDeCtes.Count > 0)
			_alreadyFetchedServiciosXembarque = (_serviciosXembarque.Count > 0)

			_alreadyFetchedComicionista = Not(_comicionista Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)
			_alreadyFetchedCuentaContable_ = Not(_cuentaContable_ Is Nothing)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
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
			info.AddValue("_recepcionGanado", _recepcionGanado)
			info.AddValue("_alwaysFetchRecepcionGanado", _alwaysFetchRecepcionGanado)
			info.AddValue("_alreadyFetchedRecepcionGanado", _alreadyFetchedRecepcionGanado)
			info.AddValue("_chequeDevuelto", _chequeDevuelto)
			info.AddValue("_alwaysFetchChequeDevuelto", _alwaysFetchChequeDevuelto)
			info.AddValue("_alreadyFetchedChequeDevuelto", _alreadyFetchedChequeDevuelto)
			info.AddValue("_chequesPos", _chequesPos)
			info.AddValue("_alwaysFetchChequesPos", _alwaysFetchChequesPos)
			info.AddValue("_alreadyFetchedChequesPos", _alreadyFetchedChequesPos)
			info.AddValue("_facturasClientesCab", _facturasClientesCab)
			info.AddValue("_alwaysFetchFacturasClientesCab", _alwaysFetchFacturasClientesCab)
			info.AddValue("_alreadyFetchedFacturasClientesCab", _alreadyFetchedFacturasClientesCab)
			info.AddValue("_facturasClientesCab_", _facturasClientesCab_)
			info.AddValue("_alwaysFetchFacturasClientesCab_", _alwaysFetchFacturasClientesCab_)
			info.AddValue("_alreadyFetchedFacturasClientesCab_", _alreadyFetchedFacturasClientesCab_)
			info.AddValue("_mfacEmbarquesCab", _mfacEmbarquesCab)
			info.AddValue("_alwaysFetchMfacEmbarquesCab", _alwaysFetchMfacEmbarquesCab)
			info.AddValue("_alreadyFetchedMfacEmbarquesCab", _alreadyFetchedMfacEmbarquesCab)
			info.AddValue("_mfacEmbarquesCab_", _mfacEmbarquesCab_)
			info.AddValue("_alwaysFetchMfacEmbarquesCab_", _alwaysFetchMfacEmbarquesCab_)
			info.AddValue("_alreadyFetchedMfacEmbarquesCab_", _alreadyFetchedMfacEmbarquesCab_)
			info.AddValue("_mgralcatPuntosEntrega", _mgralcatPuntosEntrega)
			info.AddValue("_alwaysFetchMgralcatPuntosEntrega", _alwaysFetchMgralcatPuntosEntrega)
			info.AddValue("_alreadyFetchedMgralcatPuntosEntrega", _alreadyFetchedMgralcatPuntosEntrega)
			info.AddValue("_devolucionProductos", _devolucionProductos)
			info.AddValue("_alwaysFetchDevolucionProductos", _alwaysFetchDevolucionProductos)
			info.AddValue("_alreadyFetchedDevolucionProductos", _alreadyFetchedDevolucionProductos)
			info.AddValue("_mscrelacionCortesClientes", _mscrelacionCortesClientes)
			info.AddValue("_alwaysFetchMscrelacionCortesClientes", _alwaysFetchMscrelacionCortesClientes)
			info.AddValue("_alreadyFetchedMscrelacionCortesClientes", _alreadyFetchedMscrelacionCortesClientes)
			info.AddValue("_notaCreditoCab", _notaCreditoCab)
			info.AddValue("_alwaysFetchNotaCreditoCab", _alwaysFetchNotaCreditoCab)
			info.AddValue("_alreadyFetchedNotaCreditoCab", _alreadyFetchedNotaCreditoCab)
			info.AddValue("_pagoDeCtes", _pagoDeCtes)
			info.AddValue("_alwaysFetchPagoDeCtes", _alwaysFetchPagoDeCtes)
			info.AddValue("_alreadyFetchedPagoDeCtes", _alreadyFetchedPagoDeCtes)
			info.AddValue("_serviciosXembarque", _serviciosXembarque)
			info.AddValue("_alwaysFetchServiciosXembarque", _alwaysFetchServiciosXembarque)
			info.AddValue("_alreadyFetchedServiciosXembarque", _alreadyFetchedServiciosXembarque)

			info.AddValue("_comicionista", _comicionista)
			info.AddValue("_comicionistaReturnsNewIfNotFound", _comicionistaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchComicionista", _alwaysFetchComicionista)
			info.AddValue("_alreadyFetchedComicionista", _alreadyFetchedComicionista)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_cuentaContable_", _cuentaContable_)
			info.AddValue("_cuentaContable_ReturnsNewIfNotFound", _cuentaContable_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable_", _alwaysFetchCuentaContable_)
			info.AddValue("_alreadyFetchedCuentaContable_", _alreadyFetchedCuentaContable_)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			
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
				Case "Comicionista"
					_alreadyFetchedComicionista = True
					Me.Comicionista = CType(entity, ComicionistaEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "CuentaContable_"
					_alreadyFetchedCuentaContable_ = True
					Me.CuentaContable_ = CType(entity, CuentaContableEntity)
				Case "RecepcionGanado"
					_alreadyFetchedRecepcionGanado = True
					If Not entity Is Nothing Then
						Me.RecepcionGanado.Add(CType(entity, RecepcionGanadoEntity))
					End If
				Case "ChequeDevuelto"
					_alreadyFetchedChequeDevuelto = True
					If Not entity Is Nothing Then
						Me.ChequeDevuelto.Add(CType(entity, ChequeDevueltoEntity))
					End If
				Case "ChequesPos"
					_alreadyFetchedChequesPos = True
					If Not entity Is Nothing Then
						Me.ChequesPos.Add(CType(entity, ChequesPosEntity))
					End If
				Case "FacturasClientesCab"
					_alreadyFetchedFacturasClientesCab = True
					If Not entity Is Nothing Then
						Me.FacturasClientesCab.Add(CType(entity, FacturasClientesCabEntity))
					End If
				Case "FacturasClientesCab_"
					_alreadyFetchedFacturasClientesCab_ = True
					If Not entity Is Nothing Then
						Me.FacturasClientesCab_.Add(CType(entity, FacturasClientesCabEntity))
					End If
				Case "MfacEmbarquesCab"
					_alreadyFetchedMfacEmbarquesCab = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCab.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "MfacEmbarquesCab_"
					_alreadyFetchedMfacEmbarquesCab_ = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCab_.Add(CType(entity, MfacEmbarquesCabEntity))
					End If
				Case "MgralcatPuntosEntrega"
					_alreadyFetchedMgralcatPuntosEntrega = True
					If Not entity Is Nothing Then
						Me.MgralcatPuntosEntrega.Add(CType(entity, MgralcatPuntosEntregaEntity))
					End If
				Case "DevolucionProductos"
					_alreadyFetchedDevolucionProductos = True
					If Not entity Is Nothing Then
						Me.DevolucionProductos.Add(CType(entity, DevolucionProductosEntity))
					End If
				Case "MscrelacionCortesClientes"
					_alreadyFetchedMscrelacionCortesClientes = True
					If Not entity Is Nothing Then
						Me.MscrelacionCortesClientes.Add(CType(entity, MscrelacionCortesClientesEntity))
					End If
				Case "NotaCreditoCab"
					_alreadyFetchedNotaCreditoCab = True
					If Not entity Is Nothing Then
						Me.NotaCreditoCab.Add(CType(entity, NotaCreditoCabEntity))
					End If
				Case "PagoDeCtes"
					_alreadyFetchedPagoDeCtes = True
					If Not entity Is Nothing Then
						Me.PagoDeCtes.Add(CType(entity, PagoDeCtesEntity))
					End If
				Case "ServiciosXembarque"
					_alreadyFetchedServiciosXembarque = True
					If Not entity Is Nothing Then
						Me.ServiciosXembarque.Add(CType(entity, ServiciosXembarqueEntity))
					End If

				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Comicionista"
					SetupSyncComicionista(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable_"
					SetupSyncCuentaContable_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionGanado"
					_recepcionGanado.Add(CType(relatedEntity, RecepcionGanadoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ChequeDevuelto"
					_chequeDevuelto.Add(CType(relatedEntity, ChequeDevueltoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ChequesPos"
					_chequesPos.Add(CType(relatedEntity, ChequesPosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "FacturasClientesCab"
					_facturasClientesCab.Add(CType(relatedEntity, FacturasClientesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "FacturasClientesCab_"
					_facturasClientesCab_.Add(CType(relatedEntity, FacturasClientesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					_mfacEmbarquesCab.Add(CType(relatedEntity, MfacEmbarquesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesCab_"
					_mfacEmbarquesCab_.Add(CType(relatedEntity, MfacEmbarquesCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MgralcatPuntosEntrega"
					_mgralcatPuntosEntrega.Add(CType(relatedEntity, MgralcatPuntosEntregaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DevolucionProductos"
					_devolucionProductos.Add(CType(relatedEntity, DevolucionProductosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					_mscrelacionCortesClientes.Add(CType(relatedEntity, MscrelacionCortesClientesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NotaCreditoCab"
					_notaCreditoCab.Add(CType(relatedEntity, NotaCreditoCabEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoDeCtes"
					_pagoDeCtes.Add(CType(relatedEntity, PagoDeCtesEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					_serviciosXembarque.Add(CType(relatedEntity, ServiciosXembarqueEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
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
				Case "Comicionista"
					DesetupSyncComicionista(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable_"
					DesetupSyncCuentaContable_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionGanado"
					MyBase.PerformRelatedEntityRemoval(_recepcionGanado, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ChequeDevuelto"
					MyBase.PerformRelatedEntityRemoval(_chequeDevuelto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ChequesPos"
					MyBase.PerformRelatedEntityRemoval(_chequesPos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "FacturasClientesCab"
					MyBase.PerformRelatedEntityRemoval(_facturasClientesCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "FacturasClientesCab_"
					MyBase.PerformRelatedEntityRemoval(_facturasClientesCab_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesCab_"
					MyBase.PerformRelatedEntityRemoval(_mfacEmbarquesCab_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MgralcatPuntosEntrega"
					MyBase.PerformRelatedEntityRemoval(_mgralcatPuntosEntrega, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DevolucionProductos"
					MyBase.PerformRelatedEntityRemoval(_devolucionProductos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					MyBase.PerformRelatedEntityRemoval(_mscrelacionCortesClientes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NotaCreditoCab"
					MyBase.PerformRelatedEntityRemoval(_notaCreditoCab, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoDeCtes"
					MyBase.PerformRelatedEntityRemoval(_pagoDeCtes, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					MyBase.PerformRelatedEntityRemoval(_serviciosXembarque, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()

			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
			End If


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _comicionista Is Nothing Then
				toReturn.Add(_comicionista)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If
			If Not _cuentaContable_ Is Nothing Then
				toReturn.Add(_cuentaContable_)
			End If




			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_recepcionGanado)
			toReturn.Add(_chequeDevuelto)
			toReturn.Add(_chequesPos)
			toReturn.Add(_facturasClientesCab)
			toReturn.Add(_facturasClientesCab_)
			toReturn.Add(_mfacEmbarquesCab)
			toReturn.Add(_mfacEmbarquesCab_)
			toReturn.Add(_mgralcatPuntosEntrega)
			toReturn.Add(_devolucionProductos)
			toReturn.Add(_mscrelacionCortesClientes)
			toReturn.Add(_notaCreditoCab)
			toReturn.Add(_pagoDeCtes)
			toReturn.Add(_serviciosXembarque)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCliente As System.Int32) As Boolean
			Return FetchUsingPK(idCliente, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCliente As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCliente, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCliente As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCliente, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCliente, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MfacCatClientesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MfacCatClientesFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, _recepcionGanado.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionGanadoEntity'</returns>
		Public Function GetMultiRecepcionGanado(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Return GetMultiRecepcionGanado(forceFetch, _recepcionGanado.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionGanado(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			If ( Not _alreadyFetchedRecepcionGanado Or forceFetch Or _alwaysFetchRecepcionGanado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionGanado.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionGanado)
					End If
				End If
				_recepcionGanado.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionGanado.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionGanado.GetMultiManyToOne(Me, Nothing, Filter)
				_recepcionGanado.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionGanado = True
			End If
			Return _recepcionGanado
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionGanado'. These settings will be taken into account
		''' when the property RecepcionGanado is requested or GetMultiRecepcionGanado is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionGanado(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionGanado.SortClauses=sortClauses
			_recepcionGanado.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeDevueltoEntity'</returns>
		Public Function GetMultiChequeDevuelto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Return GetMultiChequeDevuelto(forceFetch, _chequeDevuelto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiChequeDevuelto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Return GetMultiChequeDevuelto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequeDevueltoEntity'</returns>
		Public Function GetMultiChequeDevuelto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Return GetMultiChequeDevuelto(forceFetch, _chequeDevuelto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiChequeDevuelto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			If ( Not _alreadyFetchedChequeDevuelto Or forceFetch Or _alwaysFetchChequeDevuelto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _chequeDevuelto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_chequeDevuelto)
					End If
				End If
				_chequeDevuelto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_chequeDevuelto.EntityFactoryToUse = entityFactoryToUse
				End If
				_chequeDevuelto.GetMultiManyToOne(Nothing, Me, Filter)
				_chequeDevuelto.SuppressClearInGetMulti = False
				_alreadyFetchedChequeDevuelto = True
			End If
			Return _chequeDevuelto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ChequeDevuelto'. These settings will be taken into account
		''' when the property ChequeDevuelto is requested or GetMultiChequeDevuelto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersChequeDevuelto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_chequeDevuelto.SortClauses=sortClauses
			_chequeDevuelto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ChequesPosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequesPosEntity'</returns>
		Public Function GetMultiChequesPos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequesPosCollection
			Return GetMultiChequesPos(forceFetch, _chequesPos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequesPosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiChequesPos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequesPosCollection
			Return GetMultiChequesPos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequesPosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ChequesPosEntity'</returns>
		Public Function GetMultiChequesPos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequesPosCollection
			Return GetMultiChequesPos(forceFetch, _chequesPos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequesPosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiChequesPos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ChequesPosCollection
			If ( Not _alreadyFetchedChequesPos Or forceFetch Or _alwaysFetchChequesPos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _chequesPos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_chequesPos)
					End If
				End If
				_chequesPos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_chequesPos.EntityFactoryToUse = entityFactoryToUse
				End If
				_chequesPos.GetMultiManyToOne(Nothing, Me, Filter)
				_chequesPos.SuppressClearInGetMulti = False
				_alreadyFetchedChequesPos = True
			End If
			Return _chequesPos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ChequesPos'. These settings will be taken into account
		''' when the property ChequesPos is requested or GetMultiChequesPos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersChequesPos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_chequesPos.SortClauses=sortClauses
			_chequesPos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, _facturasClientesCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab(forceFetch, _facturasClientesCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			If ( Not _alreadyFetchedFacturasClientesCab Or forceFetch Or _alwaysFetchFacturasClientesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesCab)
					End If
				End If
				_facturasClientesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesCab.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_facturasClientesCab.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesCab = True
			End If
			Return _facturasClientesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesCab'. These settings will be taken into account
		''' when the property FacturasClientesCab is requested or GetMultiFacturasClientesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesCab.SortClauses=sortClauses
			_facturasClientesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab_(forceFetch, _facturasClientesCab_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiFacturasClientesCab_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'FacturasClientesCabEntity'</returns>
		Public Function GetMultiFacturasClientesCab_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Return GetMultiFacturasClientesCab_(forceFetch, _facturasClientesCab_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiFacturasClientesCab_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			If ( Not _alreadyFetchedFacturasClientesCab_ Or forceFetch Or _alwaysFetchFacturasClientesCab_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _facturasClientesCab_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_facturasClientesCab_)
					End If
				End If
				_facturasClientesCab_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_facturasClientesCab_.EntityFactoryToUse = entityFactoryToUse
				End If
				_facturasClientesCab_.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_facturasClientesCab_.SuppressClearInGetMulti = False
				_alreadyFetchedFacturasClientesCab_ = True
			End If
			Return _facturasClientesCab_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'FacturasClientesCab_'. These settings will be taken into account
		''' when the property FacturasClientesCab_ is requested or GetMultiFacturasClientesCab_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersFacturasClientesCab_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_facturasClientesCab_.SortClauses=sortClauses
			_facturasClientesCab_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab(forceFetch, _mfacEmbarquesCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMfacEmbarquesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab(forceFetch, _mfacEmbarquesCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCab Or forceFetch Or _alwaysFetchMfacEmbarquesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCab)
					End If
				End If
				_mfacEmbarquesCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCab.GetMultiManyToOne(Me, Nothing, Filter)
				_mfacEmbarquesCab.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCab = True
			End If
			Return _mfacEmbarquesCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCab'. These settings will be taken into account
		''' when the property MfacEmbarquesCab is requested or GetMultiMfacEmbarquesCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCab.SortClauses=sortClauses
			_mfacEmbarquesCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCab_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab_(forceFetch, _mfacEmbarquesCab_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMfacEmbarquesCab_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCab_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCab_(forceFetch, _mfacEmbarquesCab_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCab_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCab_ Or forceFetch Or _alwaysFetchMfacEmbarquesCab_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCab_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCab_)
					End If
				End If
				_mfacEmbarquesCab_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCab_.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCab_.GetMultiManyToOne(Nothing, Me, Filter)
				_mfacEmbarquesCab_.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCab_ = True
			End If
			Return _mfacEmbarquesCab_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCab_'. These settings will be taken into account
		''' when the property MfacEmbarquesCab_ is requested or GetMultiMfacEmbarquesCab_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCab_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCab_.SortClauses=sortClauses
			_mfacEmbarquesCab_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MgralcatPuntosEntregaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MgralcatPuntosEntregaEntity'</returns>
		Public Function GetMultiMgralcatPuntosEntrega(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
			Return GetMultiMgralcatPuntosEntrega(forceFetch, _mgralcatPuntosEntrega.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MgralcatPuntosEntregaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMgralcatPuntosEntrega(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
			Return GetMultiMgralcatPuntosEntrega(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MgralcatPuntosEntregaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MgralcatPuntosEntregaEntity'</returns>
		Public Function GetMultiMgralcatPuntosEntrega(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
			Return GetMultiMgralcatPuntosEntrega(forceFetch, _mgralcatPuntosEntrega.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MgralcatPuntosEntregaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMgralcatPuntosEntrega(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
			If ( Not _alreadyFetchedMgralcatPuntosEntrega Or forceFetch Or _alwaysFetchMgralcatPuntosEntrega) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mgralcatPuntosEntrega.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mgralcatPuntosEntrega)
					End If
				End If
				_mgralcatPuntosEntrega.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mgralcatPuntosEntrega.EntityFactoryToUse = entityFactoryToUse
				End If
				_mgralcatPuntosEntrega.GetMultiManyToOne(Nothing, Me, Filter)
				_mgralcatPuntosEntrega.SuppressClearInGetMulti = False
				_alreadyFetchedMgralcatPuntosEntrega = True
			End If
			Return _mgralcatPuntosEntrega
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MgralcatPuntosEntrega'. These settings will be taken into account
		''' when the property MgralcatPuntosEntrega is requested or GetMultiMgralcatPuntosEntrega is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMgralcatPuntosEntrega(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mgralcatPuntosEntrega.SortClauses=sortClauses
			_mgralcatPuntosEntrega.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_devolucionProductos.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
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
	
		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			If ( Not _alreadyFetchedMscrelacionCortesClientes Or forceFetch Or _alwaysFetchMscrelacionCortesClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrelacionCortesClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrelacionCortesClientes)
					End If
				End If
				_mscrelacionCortesClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrelacionCortesClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrelacionCortesClientes.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_mscrelacionCortesClientes.SuppressClearInGetMulti = False
				_alreadyFetchedMscrelacionCortesClientes = True
			End If
			Return _mscrelacionCortesClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrelacionCortesClientes'. These settings will be taken into account
		''' when the property MscrelacionCortesClientes is requested or GetMultiMscrelacionCortesClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrelacionCortesClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrelacionCortesClientes.SortClauses=sortClauses
			_mscrelacionCortesClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaCreditoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoCabEntity'</returns>
		Public Function GetMultiNotaCreditoCab(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
			Return GetMultiNotaCreditoCab(forceFetch, _notaCreditoCab.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNotaCreditoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
			Return GetMultiNotaCreditoCab(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoCabEntity'</returns>
		Public Function GetMultiNotaCreditoCab(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
			Return GetMultiNotaCreditoCab(forceFetch, _notaCreditoCab.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNotaCreditoCab(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
			If ( Not _alreadyFetchedNotaCreditoCab Or forceFetch Or _alwaysFetchNotaCreditoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _notaCreditoCab.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_notaCreditoCab)
					End If
				End If
				_notaCreditoCab.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_notaCreditoCab.EntityFactoryToUse = entityFactoryToUse
				End If
				_notaCreditoCab.GetMultiManyToOne(Nothing, Me, Filter)
				_notaCreditoCab.SuppressClearInGetMulti = False
				_alreadyFetchedNotaCreditoCab = True
			End If
			Return _notaCreditoCab
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NotaCreditoCab'. These settings will be taken into account
		''' when the property NotaCreditoCab is requested or GetMultiNotaCreditoCab is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNotaCreditoCab(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_notaCreditoCab.SortClauses=sortClauses
			_notaCreditoCab.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				_pagoDeCtes.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
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
				_serviciosXembarque.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
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
	
	

		''' <summary>Retrieves the related entity of type 'ComicionistaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ComicionistaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleComicionista() As ComicionistaEntity
			Return GetSingleComicionista(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ComicionistaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ComicionistaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleComicionista(forceFetch As Boolean) As ComicionistaEntity
			If ( Not _alreadyFetchedComicionista Or forceFetch Or _alwaysFetchComicionista) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ComicionistaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdVendedor.GetValueOrDefault())
				End If
				If Not _comicionistaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Comicionista = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ComicionistaEntity)
					End If
					Me.Comicionista = newEntity
					_alreadyFetchedComicionista = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _comicionista
		End Function
	
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentaContId.GetValueOrDefault())
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
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable_() As CuentaContableEntity
			Return GetSingleCuentaContable_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable_(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaContable_ Or forceFetch Or _alwaysFetchCuentaContable_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.CuentaAnticipoId.GetValueOrDefault())
				End If
				If Not _cuentaContable_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaContable_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaContable_ = newEntity
					_alreadyFetchedCuentaContable_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaContable_
		End Function
	
	
		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type '1:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen() As AlmacenEntity
			Return GetSingleAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type '1:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then
				Dim newEntity As New AlmacenEntity()
				Dim relation As IEntityRelation = MfacCatClientesEntity.Relations.AlmacenEntityUsingAlmacenId
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(relation) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCliente)
				End If
				If Not _almacenReturnsNewIfNotFound And Not fetchResult Then
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
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(MfacCatClientesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MfacCatClientesFieldIndex)






















					Case MfacCatClientesFieldIndex.CuentaContId
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False
					Case MfacCatClientesFieldIndex.CuentaAnticipoId
						DesetupSyncCuentaContable_(True, False)
						_alreadyFetchedCuentaContable_ = False


					Case MfacCatClientesFieldIndex.IdVendedor
						DesetupSyncComicionista(True, False)
						_alreadyFetchedComicionista = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_recepcionGanado.ActiveContext = MyBase.ActiveContext
			_chequeDevuelto.ActiveContext = MyBase.ActiveContext
			_chequesPos.ActiveContext = MyBase.ActiveContext
			_facturasClientesCab.ActiveContext = MyBase.ActiveContext
			_facturasClientesCab_.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCab.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCab_.ActiveContext = MyBase.ActiveContext
			_mgralcatPuntosEntrega.ActiveContext = MyBase.ActiveContext
			_devolucionProductos.ActiveContext = MyBase.ActiveContext
			_mscrelacionCortesClientes.ActiveContext = MyBase.ActiveContext
			_notaCreditoCab.ActiveContext = MyBase.ActiveContext
			_pagoDeCtes.ActiveContext = MyBase.ActiveContext
			_serviciosXembarque.ActiveContext = MyBase.ActiveContext

		If Not _comicionista Is Nothing Then
				_comicionista.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable_ Is Nothing Then
				_cuentaContable_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If

		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MfacCatClientesDAO = CType(CreateDAOInstance(), MfacCatClientesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MfacCatClientesDAO = CType(CreateDAOInstance(), MfacCatClientesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MfacCatClientesDAO = CType(CreateDAOInstance(), MfacCatClientesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MfacCatClientesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MfacCatClientesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="validator">The validator Object for this MfacCatClientesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCliente As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCliente, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_recepcionGanado = New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(New RecepcionGanadoEntityFactory())
			_recepcionGanado.SetContainingEntityInfo(Me, "Clientes")
			_alwaysFetchRecepcionGanado = False
			_alreadyFetchedRecepcionGanado = False
			_chequeDevuelto = New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(New ChequeDevueltoEntityFactory())
			_chequeDevuelto.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchChequeDevuelto = False
			_alreadyFetchedChequeDevuelto = False
			_chequesPos = New Integralab.ORM.CollectionClasses.ChequesPosCollection(New ChequesPosEntityFactory())
			_chequesPos.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchChequesPos = False
			_alreadyFetchedChequesPos = False
			_facturasClientesCab = New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(New FacturasClientesCabEntityFactory())
			_facturasClientesCab.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchFacturasClientesCab = False
			_alreadyFetchedFacturasClientesCab = False
			_facturasClientesCab_ = New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(New FacturasClientesCabEntityFactory())
			_facturasClientesCab_.SetContainingEntityInfo(Me, "MfacCatClientes_")
			_alwaysFetchFacturasClientesCab_ = False
			_alreadyFetchedFacturasClientesCab_ = False
			_mfacEmbarquesCab = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_mfacEmbarquesCab.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchMfacEmbarquesCab = False
			_alreadyFetchedMfacEmbarquesCab = False
			_mfacEmbarquesCab_ = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_mfacEmbarquesCab_.SetContainingEntityInfo(Me, "MfacCatClientes_")
			_alwaysFetchMfacEmbarquesCab_ = False
			_alreadyFetchedMfacEmbarquesCab_ = False
			_mgralcatPuntosEntrega = New Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection(New MgralcatPuntosEntregaEntityFactory())
			_mgralcatPuntosEntrega.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchMgralcatPuntosEntrega = False
			_alreadyFetchedMgralcatPuntosEntrega = False
			_devolucionProductos = New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(New DevolucionProductosEntityFactory())
			_devolucionProductos.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchDevolucionProductos = False
			_alreadyFetchedDevolucionProductos = False
			_mscrelacionCortesClientes = New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(New MscrelacionCortesClientesEntityFactory())
			_mscrelacionCortesClientes.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchMscrelacionCortesClientes = False
			_alreadyFetchedMscrelacionCortesClientes = False
			_notaCreditoCab = New Integralab.ORM.CollectionClasses.NotaCreditoCabCollection(New NotaCreditoCabEntityFactory())
			_notaCreditoCab.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchNotaCreditoCab = False
			_alreadyFetchedNotaCreditoCab = False
			_pagoDeCtes = New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(New PagoDeCtesEntityFactory())
			_pagoDeCtes.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchPagoDeCtes = False
			_alreadyFetchedPagoDeCtes = False
			_serviciosXembarque = New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(New ServiciosXembarqueEntityFactory())
			_serviciosXembarque.SetContainingEntityInfo(Me, "MfacCatClientes")
			_alwaysFetchServiciosXembarque = False
			_alreadyFetchedServiciosXembarque = False

			_comicionista = Nothing
			_comicionistaReturnsNewIfNotFound = True
			_alwaysFetchComicionista = False
			_alreadyFetchedComicionista = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_cuentaContable_ = Nothing
			_cuentaContable_ReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable_ = False
			_alreadyFetchedCuentaContable_ = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Nombre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("RazonSocial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasRevision", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LimiteCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoFacturacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteUltimaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesPalletizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaContId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CuentaAnticipoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Introductor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ClientesVarios", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdVendedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsPersonaFisica", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Logo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Idtipocliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Canaldistribucion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsoCfdi", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FormaPago", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _comicionista</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncComicionista(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _comicionista, AddressOf OnComicionistaPropertyChanged, "Comicionista", MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, True, signalRelatedEntity, "MfacCatClientes", resetFKFields, New Integer() { CInt(MfacCatClientesFieldIndex.IdVendedor) } )
			_comicionista = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _comicionista</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncComicionista(relatedEntity As IEntity)
			DesetupSyncComicionista(True, True)
			_comicionista = CType(relatedEntity, ComicionistaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _comicionista, AddressOf OnComicionistaPropertyChanged, "Comicionista", MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, True, _alreadyFetchedComicionista, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnComicionistaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId, True, signalRelatedEntity, "Cliente", resetFKFields, New Integer() { CInt(MfacCatClientesFieldIndex.CuentaContId) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId, True, _alreadyFetchedCuentaContable, New String() {  } )
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
		''' <summary>Removes the sync logic for member _cuentaContable_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable_, AddressOf OnCuentaContable_PropertyChanged, "CuentaContable_", MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId, True, signalRelatedEntity, "Cliente_", resetFKFields, New Integer() { CInt(MfacCatClientesFieldIndex.CuentaAnticipoId) } )
			_cuentaContable_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable_(relatedEntity As IEntity)
			DesetupSyncCuentaContable_(True, True)
			_cuentaContable_ = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable_, AddressOf OnCuentaContable_PropertyChanged, "CuentaContable_", MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId, True, _alreadyFetchedCuentaContable_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaContable_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub

		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MfacCatClientesEntity.Relations.AlmacenEntityUsingAlmacenId, False, signalRelatedEntity, "MfacCatClientes", False, New Integer() { CInt(MfacCatClientesFieldIndex.IdCliente) } )
			_almacen = Nothing
		End Sub

		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MfacCatClientesEntity.Relations.AlmacenEntityUsingAlmacenId, False, _alreadyFetchedAlmacen, New String() {  } )
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


		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idCliente">PK value for MfacCatClientes which data should be fetched into this MfacCatClientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCliente As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MfacCatClientesFieldIndex.IdCliente)).ForcedCurrentValueWrite(idCliente)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMfacCatClientesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MfacCatClientesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MfacCatClientesRelations
			Get	
				Return New MfacCatClientesRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionGanado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionGanado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionGanadoCollection(), _
					MfacCatClientesEntity.Relations.RecepcionGanadoEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionGanadoEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionGanado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChequeDevuelto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathChequeDevuelto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(), _
					MfacCatClientesEntity.Relations.ChequeDevueltoEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), 0, Nothing, Nothing, Nothing, "ChequeDevuelto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChequesPos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathChequesPos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequesPosCollection(), _
					MfacCatClientesEntity.Relations.ChequesPosEntityUsingCveCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.ChequesPosEntity, Integer), 0, Nothing, Nothing, Nothing, "ChequesPos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					MfacCatClientesEntity.Relations.FacturasClientesCabEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCab_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					MfacCatClientesEntity.Relations.FacturasClientesCabEntityUsingIdClienteCargo, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MfacCatClientesEntity.Relations.MfacEmbarquesCabEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCab_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					MfacCatClientesEntity.Relations.MfacEmbarquesCabEntityUsingIdClienteAsignado, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesCab_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MgralcatPuntosEntrega' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMgralcatPuntosEntrega() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection(), _
					MfacCatClientesEntity.Relations.MgralcatPuntosEntregaEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity, Integer), 0, Nothing, Nothing, Nothing, "MgralcatPuntosEntrega", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DevolucionProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDevolucionProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DevolucionProductosCollection(), _
					MfacCatClientesEntity.Relations.DevolucionProductosEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "DevolucionProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrelacionCortesClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrelacionCortesClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(), _
					MfacCatClientesEntity.Relations.MscrelacionCortesClientesEntityUsingCodCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.MscrelacionCortesClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrelacionCortesClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaCreditoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotaCreditoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaCreditoCabCollection(), _
					MfacCatClientesEntity.Relations.NotaCreditoCabEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.NotaCreditoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "NotaCreditoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoDeCtes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoDeCtes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoDeCtesCollection(), _
					MfacCatClientesEntity.Relations.PagoDeCtesEntityUsingCveCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoDeCtes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiciosXembarque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathServiciosXembarque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(), _
					MfacCatClientesEntity.Relations.ServiciosXembarqueEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.ServiciosXembarqueEntity, Integer), 0, Nothing, Nothing, Nothing, "ServiciosXembarque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Comicionista' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathComicionista() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ComicionistaCollection(), _
					MfacCatClientesEntity.Relations.ComicionistaEntityUsingIdVendedor, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.ComicionistaEntity, Integer), 0, Nothing, Nothing, Nothing, "Comicionista", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaContId, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					MfacCatClientesEntity.Relations.CuentaContableEntityUsingCuentaAnticipoId, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MfacCatClientesEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne)
			End Get
		End Property
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MfacCatClientesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MfacCatClientesEntity.CustomProperties
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
				Return MfacCatClientesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCliente property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombre property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Nombre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Nombre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Nombre, Integer), value)
			End Set
		End Property
	
		''' <summary>The RazonSocial property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."RazonSocial"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 160<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [RazonSocial]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.RazonSocial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.RazonSocial, Integer), value)
			End Set
		End Property
	
		''' <summary>The Domicilio property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Domicilio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 160<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Domicilio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Domicilio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Domicilio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Colonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEstado property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPostal property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."CodigoPostal"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPostal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.CodigoPostal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.CodigoPostal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."DiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasRevision property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."DiasRevision"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasRevision]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.DiasRevision, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.DiasRevision, Integer), value)
			End Set
		End Property
	
		''' <summary>The LimiteCredito property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."LimiteCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LimiteCredito]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.LimiteCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.LimiteCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasPago property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."DiasPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.DiasPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.DiasPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoFacturacion property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."TipoFacturacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoFacturacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.TipoFacturacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.TipoFacturacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaCompra property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."FechaUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaCompra]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.FechaUltimaCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.FechaUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteUltimaCompra property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."ImporteUltimaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteUltimaCompra]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.ImporteUltimaCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.ImporteUltimaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Telefono"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Telefono]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Telefono, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Telefono, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."RFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesPalletizado property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."ObservacionesPalletizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesPalletizado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.ObservacionesPalletizado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.ObservacionesPalletizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaContId property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."CuentaContId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CuentaContId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.CuentaContId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.CuentaContId, Integer), value)
			End Set
		End Property
	
		''' <summary>The CuentaAnticipoId property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."CuentaAnticipoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CuentaAnticipoId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.CuentaAnticipoId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.CuentaAnticipoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Introductor property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Introductor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Introductor]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Introductor, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Introductor, Integer), value)
			End Set
		End Property
	
		''' <summary>The ClientesVarios property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."ClientesVarios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ClientesVarios]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.ClientesVarios, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.ClientesVarios, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdVendedor property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."IdVendedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdVendedor]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.IdVendedor, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.IdVendedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsPersonaFisica property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."EsPersonaFisica"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsPersonaFisica]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.EsPersonaFisica, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.EsPersonaFisica, Integer), value)
			End Set
		End Property
	
		''' <summary>The Logo property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Logo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Image, 0, 0, 2147483647<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Logo]() As System.Byte()
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Logo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte()))
				End If
				Return CType(valueToReturn, System.Byte())
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Logo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Idtipocliente property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."idtipocliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Idtipocliente]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Idtipocliente, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Idtipocliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The Canaldistribucion property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."Canaldistribucion"<br/>
		''' Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Canaldistribucion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.Canaldistribucion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.Canaldistribucion, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsoCfdi property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."UsoCFDI"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsoCfdi]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.UsoCfdi, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.UsoCfdi, Integer), value)
			End Set
		End Property
	
		''' <summary>The FormaPago property of the Entity MfacCatClientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MFacCatClientes"."FormaPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FormaPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MfacCatClientesFieldIndex.FormaPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MfacCatClientesFieldIndex.FormaPago, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'RecepcionGanadoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionGanado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionGanado]() As Integralab.ORM.CollectionClasses.RecepcionGanadoCollection
			Get
				Return GetMultiRecepcionGanado(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionGanado. When set to true, RecepcionGanado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionGanado is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionGanado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionGanado As Boolean
			Get
				Return _alwaysFetchRecepcionGanado
			End Get
			Set
				_alwaysFetchRecepcionGanado = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChequeDevuelto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ChequeDevuelto]() As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Get
				Return GetMultiChequeDevuelto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ChequeDevuelto. When set to true, ChequeDevuelto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ChequeDevuelto is accessed. You can always execute
		''' a forced fetch by calling GetMultiChequeDevuelto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchChequeDevuelto As Boolean
			Get
				Return _alwaysFetchChequeDevuelto
			End Get
			Set
				_alwaysFetchChequeDevuelto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ChequesPosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChequesPos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ChequesPos]() As Integralab.ORM.CollectionClasses.ChequesPosCollection
			Get
				Return GetMultiChequesPos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ChequesPos. When set to true, ChequesPos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ChequesPos is accessed. You can always execute
		''' a forced fetch by calling GetMultiChequesPos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchChequesPos As Boolean
			Get
				Return _alwaysFetchChequesPos
			End Get
			Set
				_alwaysFetchChequesPos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesCab]() As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Get
				Return GetMultiFacturasClientesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCab. When set to true, FacturasClientesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCab As Boolean
			Get
				Return _alwaysFetchFacturasClientesCab
			End Get
			Set
				_alwaysFetchFacturasClientesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'FacturasClientesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiFacturasClientesCab_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [FacturasClientesCab_]() As Integralab.ORM.CollectionClasses.FacturasClientesCabCollection
			Get
				Return GetMultiFacturasClientesCab_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCab_. When set to true, FacturasClientesCab_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCab_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiFacturasClientesCab_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCab_ As Boolean
			Get
				Return _alwaysFetchFacturasClientesCab_
			End Get
			Set
				_alwaysFetchFacturasClientesCab_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCab]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCab. When set to true, MfacEmbarquesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCab As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCab
			End Get
			Set
				_alwaysFetchMfacEmbarquesCab = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCab_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCab_]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCab_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCab_. When set to true, MfacEmbarquesCab_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCab_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCab_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCab_ As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCab_
			End Get
			Set
				_alwaysFetchMfacEmbarquesCab_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MgralcatPuntosEntregaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMgralcatPuntosEntrega()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MgralcatPuntosEntrega]() As Integralab.ORM.CollectionClasses.MgralcatPuntosEntregaCollection
			Get
				Return GetMultiMgralcatPuntosEntrega(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MgralcatPuntosEntrega. When set to true, MgralcatPuntosEntrega is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MgralcatPuntosEntrega is accessed. You can always execute
		''' a forced fetch by calling GetMultiMgralcatPuntosEntrega(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMgralcatPuntosEntrega As Boolean
			Get
				Return _alwaysFetchMgralcatPuntosEntrega
			End Get
			Set
				_alwaysFetchMgralcatPuntosEntrega = value
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
	
		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrelacionCortesClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrelacionCortesClientes]() As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Get
				Return GetMultiMscrelacionCortesClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrelacionCortesClientes. When set to true, MscrelacionCortesClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrelacionCortesClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrelacionCortesClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrelacionCortesClientes As Boolean
			Get
				Return _alwaysFetchMscrelacionCortesClientes
			End Get
			Set
				_alwaysFetchMscrelacionCortesClientes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaCreditoCabEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNotaCreditoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NotaCreditoCab]() As Integralab.ORM.CollectionClasses.NotaCreditoCabCollection
			Get
				Return GetMultiNotaCreditoCab(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotaCreditoCab. When set to true, NotaCreditoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotaCreditoCab is accessed. You can always execute
		''' a forced fetch by calling GetMultiNotaCreditoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotaCreditoCab As Boolean
			Get
				Return _alwaysFetchNotaCreditoCab
			End Get
			Set
				_alwaysFetchNotaCreditoCab = value
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
	
	
	
		''' <summary>Gets / sets related entity of type 'ComicionistaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleComicionista()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Comicionista]() As ComicionistaEntity
			Get
				Return GetSingleComicionista(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncComicionista(value)
				Else
					If value Is Nothing Then
						If Not _comicionista Is Nothing Then
							_comicionista.UnsetRelatedEntity(Me, "MfacCatClientes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MfacCatClientes")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Comicionista. When set to true, Comicionista is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Comicionista is accessed. You can always execute
		''' a forced fetch by calling GetSingleComicionista(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchComicionista As Boolean
			Get
				Return _alwaysFetchComicionista
			End Get
			Set
				_alwaysFetchComicionista = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Comicionista is not found
		''' in the database. When set to true, Comicionista will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ComicionistaReturnsNewIfNotFound As Boolean
			Get
				Return _comicionistaReturnsNewIfNotFound
			End Get
			Set
				_comicionistaReturnsNewIfNotFound = value
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
							_cuentaContable.UnsetRelatedEntity(Me, "Cliente")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cliente")
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
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaContable_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaContable_]() As CuentaContableEntity
			Get
				Return GetSingleCuentaContable_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaContable_(value)
				Else
					If value Is Nothing Then
						If Not _cuentaContable_ Is Nothing Then
							_cuentaContable_.UnsetRelatedEntity(Me, "Cliente_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cliente_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable_. When set to true, CuentaContable_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaContable_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable_ As Boolean
			Get
				Return _alwaysFetchCuentaContable_
			End Get
			Set
				_alwaysFetchCuentaContable_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaContable_ is not found
		''' in the database. When set to true, CuentaContable_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaContable_ReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaContable_ReturnsNewIfNotFound
			End Get
			Set
				_cuentaContable_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
		''' <summary>Gets / Sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
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
						DesetupSyncAlmacen(True, True)
					Else
						Dim relatedEntity As IEntity = CType(value, IEntity)
						relatedEntity.SetRelatedEntity(Me, "MfacCatClientes")
						SetupSyncAlmacen(relatedEntity)
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
				Return CInt(Integralab.ORM.EntityType.MfacCatClientesEntity)
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
