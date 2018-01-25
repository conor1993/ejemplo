' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 09:23:45
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
	''' <summary>Entity class which represents the entity 'Sucursal'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class SucursalEntity 
#Else
	<Serializable()> _
	Public Class SucursalEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _gastosDepartamentos As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
		Private _alwaysFetchGastosDepartamentos, _alreadyFetchedGastosDepartamentos As Boolean
		Private _cotizacionCompra As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompra, _alreadyFetchedCotizacionCompra As Boolean
		Private _ordenCompra As Integralab.ORM.CollectionClasses.OrdenCompraCollection
		Private _alwaysFetchOrdenCompra, _alreadyFetchedOrdenCompra As Boolean
		Private _mcomPresupuesto As Integralab.ORM.CollectionClasses.PresupuestoCollection
		Private _alwaysFetchMcomPresupuesto, _alreadyFetchedMcomPresupuesto As Boolean
		Private _recepcionOrdenCompra As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
		Private _alwaysFetchRecepcionOrdenCompra, _alreadyFetchedRecepcionOrdenCompra As Boolean
		Private _solicitudProducto As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProducto, _alreadyFetchedSolicitudProducto As Boolean
		Private _controlTurno As Integralab.ORM.CollectionClasses.ControlTurnoCollection
		Private _alwaysFetchControlTurno, _alreadyFetchedControlTurno As Boolean
		Private _mventaNotasVenta As Integralab.ORM.CollectionClasses.NotaVentaCollection
		Private _alwaysFetchMventaNotasVenta, _alreadyFetchedMventaNotasVenta As Boolean
		Private _cotizacionServicio As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
		Private _alwaysFetchCotizacionServicio, _alreadyFetchedCotizacionServicio As Boolean
		Private _ordenServicio As Integralab.ORM.CollectionClasses.OrdenServicioCollection
		Private _alwaysFetchOrdenServicio, _alreadyFetchedOrdenServicio As Boolean
		Private _solicitudServicios As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
		Private _alwaysFetchSolicitudServicios, _alreadyFetchedSolicitudServicios As Boolean

		Private _facturaFolios As FacturaFoliosEntity
		Private _alwaysFetchFacturaFolios, _alreadyFetchedFacturaFolios, _facturaFoliosReturnsNewIfNotFound As Boolean
		Private _plaza As PlazaEntity
		Private _alwaysFetchPlaza, _alreadyFetchedPlaza, _plazaReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="validator">The custom validator Object for this SucursalEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_gastosDepartamentos = CType(info.GetValue("_gastosDepartamentos", GetType(Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)), Integralab.ORM.CollectionClasses.GastosDepartamentosCollection)
			_alwaysFetchGastosDepartamentos = info.GetBoolean("_alwaysFetchGastosDepartamentos")
			_alreadyFetchedGastosDepartamentos = info.GetBoolean("_alreadyFetchedGastosDepartamentos")
			_cotizacionCompra = CType(info.GetValue("_cotizacionCompra", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompra = info.GetBoolean("_alwaysFetchCotizacionCompra")
			_alreadyFetchedCotizacionCompra = info.GetBoolean("_alreadyFetchedCotizacionCompra")
			_ordenCompra = CType(info.GetValue("_ordenCompra", GetType(Integralab.ORM.CollectionClasses.OrdenCompraCollection)), Integralab.ORM.CollectionClasses.OrdenCompraCollection)
			_alwaysFetchOrdenCompra = info.GetBoolean("_alwaysFetchOrdenCompra")
			_alreadyFetchedOrdenCompra = info.GetBoolean("_alreadyFetchedOrdenCompra")
			_mcomPresupuesto = CType(info.GetValue("_mcomPresupuesto", GetType(Integralab.ORM.CollectionClasses.PresupuestoCollection)), Integralab.ORM.CollectionClasses.PresupuestoCollection)
			_alwaysFetchMcomPresupuesto = info.GetBoolean("_alwaysFetchMcomPresupuesto")
			_alreadyFetchedMcomPresupuesto = info.GetBoolean("_alreadyFetchedMcomPresupuesto")
			_recepcionOrdenCompra = CType(info.GetValue("_recepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)), Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)
			_alwaysFetchRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchRecepcionOrdenCompra")
			_alreadyFetchedRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedRecepcionOrdenCompra")
			_solicitudProducto = CType(info.GetValue("_solicitudProducto", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProducto = info.GetBoolean("_alwaysFetchSolicitudProducto")
			_alreadyFetchedSolicitudProducto = info.GetBoolean("_alreadyFetchedSolicitudProducto")
			_controlTurno = CType(info.GetValue("_controlTurno", GetType(Integralab.ORM.CollectionClasses.ControlTurnoCollection)), Integralab.ORM.CollectionClasses.ControlTurnoCollection)
			_alwaysFetchControlTurno = info.GetBoolean("_alwaysFetchControlTurno")
			_alreadyFetchedControlTurno = info.GetBoolean("_alreadyFetchedControlTurno")
			_mventaNotasVenta = CType(info.GetValue("_mventaNotasVenta", GetType(Integralab.ORM.CollectionClasses.NotaVentaCollection)), Integralab.ORM.CollectionClasses.NotaVentaCollection)
			_alwaysFetchMventaNotasVenta = info.GetBoolean("_alwaysFetchMventaNotasVenta")
			_alreadyFetchedMventaNotasVenta = info.GetBoolean("_alreadyFetchedMventaNotasVenta")
			_cotizacionServicio = CType(info.GetValue("_cotizacionServicio", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioCollection)
			_alwaysFetchCotizacionServicio = info.GetBoolean("_alwaysFetchCotizacionServicio")
			_alreadyFetchedCotizacionServicio = info.GetBoolean("_alreadyFetchedCotizacionServicio")
			_ordenServicio = CType(info.GetValue("_ordenServicio", GetType(Integralab.ORM.CollectionClasses.OrdenServicioCollection)), Integralab.ORM.CollectionClasses.OrdenServicioCollection)
			_alwaysFetchOrdenServicio = info.GetBoolean("_alwaysFetchOrdenServicio")
			_alreadyFetchedOrdenServicio = info.GetBoolean("_alreadyFetchedOrdenServicio")
			_solicitudServicios = CType(info.GetValue("_solicitudServicios", GetType(Integralab.ORM.CollectionClasses.SolicitudServiciosCollection)), Integralab.ORM.CollectionClasses.SolicitudServiciosCollection)
			_alwaysFetchSolicitudServicios = info.GetBoolean("_alwaysFetchSolicitudServicios")
			_alreadyFetchedSolicitudServicios = info.GetBoolean("_alreadyFetchedSolicitudServicios")

			_facturaFolios = CType(info.GetValue("_facturaFolios", GetType(FacturaFoliosEntity)), FacturaFoliosEntity)
			If Not _facturaFolios Is Nothing Then
				AddHandler _facturaFolios.AfterSave, AddressOf OnEntityAfterSave
			End If
			_facturaFoliosReturnsNewIfNotFound = info.GetBoolean("_facturaFoliosReturnsNewIfNotFound")
			_alwaysFetchFacturaFolios = info.GetBoolean("_alwaysFetchFacturaFolios")
			_alreadyFetchedFacturaFolios = info.GetBoolean("_alreadyFetchedFacturaFolios")
			_plaza = CType(info.GetValue("_plaza", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza Is Nothing Then
				AddHandler _plaza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plazaReturnsNewIfNotFound = info.GetBoolean("_plazaReturnsNewIfNotFound")
			_alwaysFetchPlaza = info.GetBoolean("_alwaysFetchPlaza")
			_alreadyFetchedPlaza = info.GetBoolean("_alreadyFetchedPlaza")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedGastosDepartamentos = (_gastosDepartamentos.Count > 0)
			_alreadyFetchedCotizacionCompra = (_cotizacionCompra.Count > 0)
			_alreadyFetchedOrdenCompra = (_ordenCompra.Count > 0)
			_alreadyFetchedMcomPresupuesto = (_mcomPresupuesto.Count > 0)
			_alreadyFetchedRecepcionOrdenCompra = (_recepcionOrdenCompra.Count > 0)
			_alreadyFetchedSolicitudProducto = (_solicitudProducto.Count > 0)
			_alreadyFetchedControlTurno = (_controlTurno.Count > 0)
			_alreadyFetchedMventaNotasVenta = (_mventaNotasVenta.Count > 0)
			_alreadyFetchedCotizacionServicio = (_cotizacionServicio.Count > 0)
			_alreadyFetchedOrdenServicio = (_ordenServicio.Count > 0)
			_alreadyFetchedSolicitudServicios = (_solicitudServicios.Count > 0)

			_alreadyFetchedFacturaFolios = Not(_facturaFolios Is Nothing)
			_alreadyFetchedPlaza = Not(_plaza Is Nothing)

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
			info.AddValue("_gastosDepartamentos", _gastosDepartamentos)
			info.AddValue("_alwaysFetchGastosDepartamentos", _alwaysFetchGastosDepartamentos)
			info.AddValue("_alreadyFetchedGastosDepartamentos", _alreadyFetchedGastosDepartamentos)
			info.AddValue("_cotizacionCompra", _cotizacionCompra)
			info.AddValue("_alwaysFetchCotizacionCompra", _alwaysFetchCotizacionCompra)
			info.AddValue("_alreadyFetchedCotizacionCompra", _alreadyFetchedCotizacionCompra)
			info.AddValue("_ordenCompra", _ordenCompra)
			info.AddValue("_alwaysFetchOrdenCompra", _alwaysFetchOrdenCompra)
			info.AddValue("_alreadyFetchedOrdenCompra", _alreadyFetchedOrdenCompra)
			info.AddValue("_mcomPresupuesto", _mcomPresupuesto)
			info.AddValue("_alwaysFetchMcomPresupuesto", _alwaysFetchMcomPresupuesto)
			info.AddValue("_alreadyFetchedMcomPresupuesto", _alreadyFetchedMcomPresupuesto)
			info.AddValue("_recepcionOrdenCompra", _recepcionOrdenCompra)
			info.AddValue("_alwaysFetchRecepcionOrdenCompra", _alwaysFetchRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedRecepcionOrdenCompra", _alreadyFetchedRecepcionOrdenCompra)
			info.AddValue("_solicitudProducto", _solicitudProducto)
			info.AddValue("_alwaysFetchSolicitudProducto", _alwaysFetchSolicitudProducto)
			info.AddValue("_alreadyFetchedSolicitudProducto", _alreadyFetchedSolicitudProducto)
			info.AddValue("_controlTurno", _controlTurno)
			info.AddValue("_alwaysFetchControlTurno", _alwaysFetchControlTurno)
			info.AddValue("_alreadyFetchedControlTurno", _alreadyFetchedControlTurno)
			info.AddValue("_mventaNotasVenta", _mventaNotasVenta)
			info.AddValue("_alwaysFetchMventaNotasVenta", _alwaysFetchMventaNotasVenta)
			info.AddValue("_alreadyFetchedMventaNotasVenta", _alreadyFetchedMventaNotasVenta)
			info.AddValue("_cotizacionServicio", _cotizacionServicio)
			info.AddValue("_alwaysFetchCotizacionServicio", _alwaysFetchCotizacionServicio)
			info.AddValue("_alreadyFetchedCotizacionServicio", _alreadyFetchedCotizacionServicio)
			info.AddValue("_ordenServicio", _ordenServicio)
			info.AddValue("_alwaysFetchOrdenServicio", _alwaysFetchOrdenServicio)
			info.AddValue("_alreadyFetchedOrdenServicio", _alreadyFetchedOrdenServicio)
			info.AddValue("_solicitudServicios", _solicitudServicios)
			info.AddValue("_alwaysFetchSolicitudServicios", _alwaysFetchSolicitudServicios)
			info.AddValue("_alreadyFetchedSolicitudServicios", _alreadyFetchedSolicitudServicios)

			info.AddValue("_facturaFolios", _facturaFolios)
			info.AddValue("_facturaFoliosReturnsNewIfNotFound", _facturaFoliosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchFacturaFolios", _alwaysFetchFacturaFolios)
			info.AddValue("_alreadyFetchedFacturaFolios", _alreadyFetchedFacturaFolios)
			info.AddValue("_plaza", _plaza)
			info.AddValue("_plazaReturnsNewIfNotFound", _plazaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza", _alwaysFetchPlaza)
			info.AddValue("_alreadyFetchedPlaza", _alreadyFetchedPlaza)

			
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
				Case "FacturaFolios"
					_alreadyFetchedFacturaFolios = True
					Me.FacturaFolios = CType(entity, FacturaFoliosEntity)
				Case "Plaza"
					_alreadyFetchedPlaza = True
					Me.Plaza = CType(entity, PlazaEntity)
				Case "GastosDepartamentos"
					_alreadyFetchedGastosDepartamentos = True
					If Not entity Is Nothing Then
						Me.GastosDepartamentos.Add(CType(entity, GastosDepartamentosEntity))
					End If
				Case "CotizacionCompra"
					_alreadyFetchedCotizacionCompra = True
					If Not entity Is Nothing Then
						Me.CotizacionCompra.Add(CType(entity, McomCotizacionCompraEntity))
					End If
				Case "OrdenCompra"
					_alreadyFetchedOrdenCompra = True
					If Not entity Is Nothing Then
						Me.OrdenCompra.Add(CType(entity, OrdenCompraEntity))
					End If
				Case "McomPresupuesto"
					_alreadyFetchedMcomPresupuesto = True
					If Not entity Is Nothing Then
						Me.McomPresupuesto.Add(CType(entity, PresupuestoEntity))
					End If
				Case "RecepcionOrdenCompra"
					_alreadyFetchedRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.RecepcionOrdenCompra.Add(CType(entity, RecepcionOrdenCompraEntity))
					End If
				Case "SolicitudProducto"
					_alreadyFetchedSolicitudProducto = True
					If Not entity Is Nothing Then
						Me.SolicitudProducto.Add(CType(entity, SolicitudProductoEntity))
					End If
				Case "ControlTurno"
					_alreadyFetchedControlTurno = True
					If Not entity Is Nothing Then
						Me.ControlTurno.Add(CType(entity, ControlTurnoEntity))
					End If
				Case "MventaNotasVenta"
					_alreadyFetchedMventaNotasVenta = True
					If Not entity Is Nothing Then
						Me.MventaNotasVenta.Add(CType(entity, NotaVentaEntity))
					End If
				Case "CotizacionServicio"
					_alreadyFetchedCotizacionServicio = True
					If Not entity Is Nothing Then
						Me.CotizacionServicio.Add(CType(entity, CotizacionServicioEntity))
					End If
				Case "OrdenServicio"
					_alreadyFetchedOrdenServicio = True
					If Not entity Is Nothing Then
						Me.OrdenServicio.Add(CType(entity, OrdenServicioEntity))
					End If
				Case "SolicitudServicios"
					_alreadyFetchedSolicitudServicios = True
					If Not entity Is Nothing Then
						Me.SolicitudServicios.Add(CType(entity, SolicitudServiciosEntity))
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
				Case "FacturaFolios"
					SetupSyncFacturaFolios(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Plaza"
					SetupSyncPlaza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					_gastosDepartamentos.Add(CType(relatedEntity, GastosDepartamentosEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionCompra"
					_cotizacionCompra.Add(CType(relatedEntity, McomCotizacionCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenCompra"
					_ordenCompra.Add(CType(relatedEntity, OrdenCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomPresupuesto"
					_mcomPresupuesto.Add(CType(relatedEntity, PresupuestoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					_recepcionOrdenCompra.Add(CType(relatedEntity, RecepcionOrdenCompraEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SolicitudProducto"
					_solicitudProducto.Add(CType(relatedEntity, SolicitudProductoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ControlTurno"
					_controlTurno.Add(CType(relatedEntity, ControlTurnoEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MventaNotasVenta"
					_mventaNotasVenta.Add(CType(relatedEntity, NotaVentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionServicio"
					_cotizacionServicio.Add(CType(relatedEntity, CotizacionServicioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "OrdenServicio"
					_ordenServicio.Add(CType(relatedEntity, OrdenServicioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SolicitudServicios"
					_solicitudServicios.Add(CType(relatedEntity, SolicitudServiciosEntity))
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
				Case "FacturaFolios"
					DesetupSyncFacturaFolios(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Plaza"
					DesetupSyncPlaza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "GastosDepartamentos"
					MyBase.PerformRelatedEntityRemoval(_gastosDepartamentos, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionCompra"
					MyBase.PerformRelatedEntityRemoval(_cotizacionCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_ordenCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomPresupuesto"
					MyBase.PerformRelatedEntityRemoval(_mcomPresupuesto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_recepcionOrdenCompra, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SolicitudProducto"
					MyBase.PerformRelatedEntityRemoval(_solicitudProducto, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ControlTurno"
					MyBase.PerformRelatedEntityRemoval(_controlTurno, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MventaNotasVenta"
					MyBase.PerformRelatedEntityRemoval(_mventaNotasVenta, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionServicio"
					MyBase.PerformRelatedEntityRemoval(_cotizacionServicio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "OrdenServicio"
					MyBase.PerformRelatedEntityRemoval(_ordenServicio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SolicitudServicios"
					MyBase.PerformRelatedEntityRemoval(_solicitudServicios, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _facturaFolios Is Nothing Then
				toReturn.Add(_facturaFolios)
			End If
			If Not _plaza Is Nothing Then
				toReturn.Add(_plaza)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_gastosDepartamentos)
			toReturn.Add(_cotizacionCompra)
			toReturn.Add(_ordenCompra)
			toReturn.Add(_mcomPresupuesto)
			toReturn.Add(_recepcionOrdenCompra)
			toReturn.Add(_solicitudProducto)
			toReturn.Add(_controlTurno)
			toReturn.Add(_mventaNotasVenta)
			toReturn.Add(_cotizacionServicio)
			toReturn.Add(_ordenServicio)
			toReturn.Add(_solicitudServicios)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codigo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Codigo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As SucursalFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As SucursalFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'GastosDepartamentosEntity'</returns>
		Public Function GetMultiGastosDepartamentos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Return GetMultiGastosDepartamentos(forceFetch, _gastosDepartamentos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiGastosDepartamentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			If ( Not _alreadyFetchedGastosDepartamentos Or forceFetch Or _alwaysFetchGastosDepartamentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _gastosDepartamentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_gastosDepartamentos)
					End If
				End If
				_gastosDepartamentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_gastosDepartamentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_gastosDepartamentos.GetMultiManyToOne(Nothing, Me, Nothing, Nothing, Filter)
				_gastosDepartamentos.SuppressClearInGetMulti = False
				_alreadyFetchedGastosDepartamentos = True
			End If
			Return _gastosDepartamentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'GastosDepartamentos'. These settings will be taken into account
		''' when the property GastosDepartamentos is requested or GetMultiGastosDepartamentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersGastosDepartamentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_gastosDepartamentos.SortClauses=sortClauses
			_gastosDepartamentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompra(forceFetch, _cotizacionCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCotizacionCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompra(forceFetch, _cotizacionCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedCotizacionCompra Or forceFetch Or _alwaysFetchCotizacionCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionCompra)
					End If
				End If
				_cotizacionCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionCompra.GetMultiManyToOne(Me, Filter)
				_cotizacionCompra.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionCompra = True
			End If
			Return _cotizacionCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionCompra'. These settings will be taken into account
		''' when the property CotizacionCompra is requested or GetMultiCotizacionCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionCompra.SortClauses=sortClauses
			_cotizacionCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, _ordenCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraEntity'</returns>
		Public Function GetMultiOrdenCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Return GetMultiOrdenCompra(forceFetch, _ordenCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			If ( Not _alreadyFetchedOrdenCompra Or forceFetch Or _alwaysFetchOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompra)
					End If
				End If
				_ordenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompra.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_ordenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompra = True
			End If
			Return _ordenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompra'. These settings will be taken into account
		''' when the property OrdenCompra is requested or GetMultiOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompra.SortClauses=sortClauses
			_ordenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoEntity'</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, _mcomPresupuesto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoEntity'</returns>
		Public Function GetMultiMcomPresupuesto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Return GetMultiMcomPresupuesto(forceFetch, _mcomPresupuesto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomPresupuesto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCollection
			If ( Not _alreadyFetchedMcomPresupuesto Or forceFetch Or _alwaysFetchMcomPresupuesto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomPresupuesto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomPresupuesto)
					End If
				End If
				_mcomPresupuesto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomPresupuesto.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomPresupuesto.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_mcomPresupuesto.SuppressClearInGetMulti = False
				_alreadyFetchedMcomPresupuesto = True
			End If
			Return _mcomPresupuesto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomPresupuesto'. These settings will be taken into account
		''' when the property McomPresupuesto is requested or GetMultiMcomPresupuesto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomPresupuesto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomPresupuesto.SortClauses=sortClauses
			_mcomPresupuesto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			If ( Not _alreadyFetchedRecepcionOrdenCompra Or forceFetch Or _alwaysFetchRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionOrdenCompra)
					End If
				End If
				_recepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionOrdenCompra.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_recepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionOrdenCompra = True
			End If
			Return _recepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionOrdenCompra'. These settings will be taken into account
		''' when the property RecepcionOrdenCompra is requested or GetMultiRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionOrdenCompra.SortClauses=sortClauses
			_recepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoEntity'</returns>
		Public Function GetMultiSolicitudProducto(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Return GetMultiSolicitudProducto(forceFetch, _solicitudProducto.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSolicitudProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Return GetMultiSolicitudProducto(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoEntity'</returns>
		Public Function GetMultiSolicitudProducto(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Return GetMultiSolicitudProducto(forceFetch, _solicitudProducto.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProducto(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			If ( Not _alreadyFetchedSolicitudProducto Or forceFetch Or _alwaysFetchSolicitudProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProducto.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProducto)
					End If
				End If
				_solicitudProducto.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProducto.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProducto.GetMultiManyToOne(Me, Filter)
				_solicitudProducto.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProducto = True
			End If
			Return _solicitudProducto
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProducto'. These settings will be taken into account
		''' when the property SolicitudProducto is requested or GetMultiSolicitudProducto is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProducto(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProducto.SortClauses=sortClauses
			_solicitudProducto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ControlTurnoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ControlTurnoEntity'</returns>
		Public Function GetMultiControlTurno(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ControlTurnoCollection
			Return GetMultiControlTurno(forceFetch, _controlTurno.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ControlTurnoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiControlTurno(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ControlTurnoCollection
			Return GetMultiControlTurno(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ControlTurnoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ControlTurnoEntity'</returns>
		Public Function GetMultiControlTurno(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ControlTurnoCollection
			Return GetMultiControlTurno(forceFetch, _controlTurno.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ControlTurnoEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiControlTurno(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ControlTurnoCollection
			If ( Not _alreadyFetchedControlTurno Or forceFetch Or _alwaysFetchControlTurno) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _controlTurno.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_controlTurno)
					End If
				End If
				_controlTurno.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_controlTurno.EntityFactoryToUse = entityFactoryToUse
				End If
				_controlTurno.GetMultiManyToOne(Me, Filter)
				_controlTurno.SuppressClearInGetMulti = False
				_alreadyFetchedControlTurno = True
			End If
			Return _controlTurno
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ControlTurno'. These settings will be taken into account
		''' when the property ControlTurno is requested or GetMultiControlTurno is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersControlTurno(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_controlTurno.SortClauses=sortClauses
			_controlTurno.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiMventaNotasVenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiMventaNotasVenta(forceFetch, _mventaNotasVenta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMventaNotasVenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiMventaNotasVenta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiMventaNotasVenta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiMventaNotasVenta(forceFetch, _mventaNotasVenta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMventaNotasVenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			If ( Not _alreadyFetchedMventaNotasVenta Or forceFetch Or _alwaysFetchMventaNotasVenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mventaNotasVenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mventaNotasVenta)
					End If
				End If
				_mventaNotasVenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mventaNotasVenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_mventaNotasVenta.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_mventaNotasVenta.SuppressClearInGetMulti = False
				_alreadyFetchedMventaNotasVenta = True
			End If
			Return _mventaNotasVenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MventaNotasVenta'. These settings will be taken into account
		''' when the property MventaNotasVenta is requested or GetMultiMventaNotasVenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMventaNotasVenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mventaNotasVenta.SortClauses=sortClauses
			_mventaNotasVenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioEntity'</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, _cotizacionServicio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioEntity'</returns>
		Public Function GetMultiCotizacionServicio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Return GetMultiCotizacionServicio(forceFetch, _cotizacionServicio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			If ( Not _alreadyFetchedCotizacionServicio Or forceFetch Or _alwaysFetchCotizacionServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionServicio)
					End If
				End If
				_cotizacionServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionServicio.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_cotizacionServicio.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionServicio = True
			End If
			Return _cotizacionServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionServicio'. These settings will be taken into account
		''' when the property CotizacionServicio is requested or GetMultiCotizacionServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionServicio.SortClauses=sortClauses
			_cotizacionServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioEntity'</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, _ordenServicio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenServicioEntity'</returns>
		Public Function GetMultiOrdenServicio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Return GetMultiOrdenServicio(forceFetch, _ordenServicio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenServicio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			If ( Not _alreadyFetchedOrdenServicio Or forceFetch Or _alwaysFetchOrdenServicio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenServicio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenServicio)
					End If
				End If
				_ordenServicio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenServicio.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenServicio.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_ordenServicio.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenServicio = True
			End If
			Return _ordenServicio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenServicio'. These settings will be taken into account
		''' when the property OrdenServicio is requested or GetMultiOrdenServicio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenServicio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenServicio.SortClauses=sortClauses
			_ordenServicio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'SolicitudServiciosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudServiciosEntity'</returns>
		Public Function GetMultiSolicitudServicios(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
			Return GetMultiSolicitudServicios(forceFetch, _solicitudServicios.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudServiciosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiSolicitudServicios(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
			Return GetMultiSolicitudServicios(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudServiciosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudServiciosEntity'</returns>
		Public Function GetMultiSolicitudServicios(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
			Return GetMultiSolicitudServicios(forceFetch, _solicitudServicios.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudServiciosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudServicios(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
			If ( Not _alreadyFetchedSolicitudServicios Or forceFetch Or _alwaysFetchSolicitudServicios) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudServicios.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudServicios)
					End If
				End If
				_solicitudServicios.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudServicios.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudServicios.GetMultiManyToOne(Me, Filter)
				_solicitudServicios.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudServicios = True
			End If
			Return _solicitudServicios
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudServicios'. These settings will be taken into account
		''' when the property SolicitudServicios is requested or GetMultiSolicitudServicios is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudServicios(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudServicios.SortClauses=sortClauses
			_solicitudServicios.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	

		''' <summary>Retrieves the related entity of type 'FacturaFoliosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'FacturaFoliosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturaFolios() As FacturaFoliosEntity
			Return GetSingleFacturaFolios(False)
		End Function

		''' <summary>Retrieves the related entity of type 'FacturaFoliosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'FacturaFoliosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturaFolios(forceFetch As Boolean) As FacturaFoliosEntity
			If ( Not _alreadyFetchedFacturaFolios Or forceFetch Or _alwaysFetchFacturaFolios) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New FacturaFoliosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SucursalEntity.Relations.FacturaFoliosEntityUsingScidFolioFactura) Then
					fetchResult = newEntity.FetchUsingPK(Me.ScidFolioFactura)
				End If
				If Not _facturaFoliosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.FacturaFolios = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), FacturaFoliosEntity)
					End If
					Me.FacturaFolios = newEntity
					_alreadyFetchedFacturaFolios = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _facturaFolios
		End Function
	
		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza() As PlazaEntity
			Return GetSinglePlaza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza(forceFetch As Boolean) As PlazaEntity
			If ( Not _alreadyFetchedPlaza Or forceFetch Or _alwaysFetchPlaza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PlazaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(SucursalEntity.Relations.PlazaEntityUsingCodigoPlaza) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoPlaza)
				End If
				If Not _plazaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Plaza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PlazaEntity)
					End If
					Me.Plaza = newEntity
					_alreadyFetchedPlaza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _plaza
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(SucursalFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, SucursalFieldIndex)
					Case SucursalFieldIndex.CodigoPlaza
						DesetupSyncPlaza(True, False)
						_alreadyFetchedPlaza = False













					Case SucursalFieldIndex.ScidFolioFactura
						DesetupSyncFacturaFolios(True, False)
						_alreadyFetchedFacturaFolios = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_gastosDepartamentos.ActiveContext = MyBase.ActiveContext
			_cotizacionCompra.ActiveContext = MyBase.ActiveContext
			_ordenCompra.ActiveContext = MyBase.ActiveContext
			_mcomPresupuesto.ActiveContext = MyBase.ActiveContext
			_recepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_solicitudProducto.ActiveContext = MyBase.ActiveContext
			_controlTurno.ActiveContext = MyBase.ActiveContext
			_mventaNotasVenta.ActiveContext = MyBase.ActiveContext
			_cotizacionServicio.ActiveContext = MyBase.ActiveContext
			_ordenServicio.ActiveContext = MyBase.ActiveContext
			_solicitudServicios.ActiveContext = MyBase.ActiveContext

		If Not _facturaFolios Is Nothing Then
				_facturaFolios.ActiveContext = MyBase.ActiveContext
			End If
		If Not _plaza Is Nothing Then
				_plaza.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As SucursalDAO = CType(CreateDAOInstance(), SucursalDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As SucursalDAO = CType(CreateDAOInstance(), SucursalDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As SucursalDAO = CType(CreateDAOInstance(), SucursalDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this SucursalEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.SucursalEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="validator">The validator Object for this SucursalEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codigo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_gastosDepartamentos = New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(New GastosDepartamentosEntityFactory())
			_gastosDepartamentos.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchGastosDepartamentos = False
			_alreadyFetchedGastosDepartamentos = False
			_cotizacionCompra = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_cotizacionCompra.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchCotizacionCompra = False
			_alreadyFetchedCotizacionCompra = False
			_ordenCompra = New Integralab.ORM.CollectionClasses.OrdenCompraCollection(New OrdenCompraEntityFactory())
			_ordenCompra.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchOrdenCompra = False
			_alreadyFetchedOrdenCompra = False
			_mcomPresupuesto = New Integralab.ORM.CollectionClasses.PresupuestoCollection(New PresupuestoEntityFactory())
			_mcomPresupuesto.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchMcomPresupuesto = False
			_alreadyFetchedMcomPresupuesto = False
			_recepcionOrdenCompra = New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(New RecepcionOrdenCompraEntityFactory())
			_recepcionOrdenCompra.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchRecepcionOrdenCompra = False
			_alreadyFetchedRecepcionOrdenCompra = False
			_solicitudProducto = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_solicitudProducto.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchSolicitudProducto = False
			_alreadyFetchedSolicitudProducto = False
			_controlTurno = New Integralab.ORM.CollectionClasses.ControlTurnoCollection(New ControlTurnoEntityFactory())
			_controlTurno.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchControlTurno = False
			_alreadyFetchedControlTurno = False
			_mventaNotasVenta = New Integralab.ORM.CollectionClasses.NotaVentaCollection(New NotaVentaEntityFactory())
			_mventaNotasVenta.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchMventaNotasVenta = False
			_alreadyFetchedMventaNotasVenta = False
			_cotizacionServicio = New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(New CotizacionServicioEntityFactory())
			_cotizacionServicio.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchCotizacionServicio = False
			_alreadyFetchedCotizacionServicio = False
			_ordenServicio = New Integralab.ORM.CollectionClasses.OrdenServicioCollection(New OrdenServicioEntityFactory())
			_ordenServicio.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchOrdenServicio = False
			_alreadyFetchedOrdenServicio = False
			_solicitudServicios = New Integralab.ORM.CollectionClasses.SolicitudServiciosCollection(New SolicitudServiciosEntityFactory())
			_solicitudServicios.SetContainingEntityInfo(Me, "Sucursal")
			_alwaysFetchSolicitudServicios = False
			_alreadyFetchedSolicitudServicios = False

			_facturaFolios = Nothing
			_facturaFoliosReturnsNewIfNotFound = True
			_alwaysFetchFacturaFolios = False
			_alreadyFetchedFacturaFolios = False
			_plaza = Nothing
			_plazaReturnsNewIfNotFound = True
			_alwaysFetchPlaza = False
			_alreadyFetchedPlaza = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPlaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Serie", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ScidAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ScidFolioFactura", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _facturaFolios</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncFacturaFolios(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _facturaFolios, AddressOf OnFacturaFoliosPropertyChanged, "FacturaFolios", SucursalEntity.Relations.FacturaFoliosEntityUsingScidFolioFactura, True, signalRelatedEntity, "Sucursal", resetFKFields, New Integer() { CInt(SucursalFieldIndex.ScidFolioFactura) } )
			_facturaFolios = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _facturaFolios</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncFacturaFolios(relatedEntity As IEntity)
			DesetupSyncFacturaFolios(True, True)
			_facturaFolios = CType(relatedEntity, FacturaFoliosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _facturaFolios, AddressOf OnFacturaFoliosPropertyChanged, "FacturaFolios", SucursalEntity.Relations.FacturaFoliosEntityUsingScidFolioFactura, True, _alreadyFetchedFacturaFolios, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnFacturaFoliosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _plaza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", SucursalEntity.Relations.PlazaEntityUsingCodigoPlaza, True, signalRelatedEntity, "Sucursal", resetFKFields, New Integer() { CInt(SucursalFieldIndex.CodigoPlaza) } )
			_plaza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza(relatedEntity As IEntity)
			DesetupSyncPlaza(True, True)
			_plaza = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", SucursalEntity.Relations.PlazaEntityUsingCodigoPlaza, True, _alreadyFetchedPlaza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPlazaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Sucursal which data should be fetched into this Sucursal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(SucursalFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateSucursalDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New SucursalEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As SucursalRelations
			Get	
				Return New SucursalRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GastosDepartamentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathGastosDepartamentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.GastosDepartamentosCollection(), _
					SucursalEntity.Relations.GastosDepartamentosEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.GastosDepartamentosEntity, Integer), 0, Nothing, Nothing, Nothing, "GastosDepartamentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					SucursalEntity.Relations.McomCotizacionCompraEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraCollection(), _
					SucursalEntity.Relations.OrdenCompraEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Presupuesto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomPresupuesto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresupuestoCollection(), _
					SucursalEntity.Relations.PresupuestoEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), 0, Nothing, Nothing, Nothing, "McomPresupuesto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionOrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(), _
					SucursalEntity.Relations.RecepcionOrdenCompraEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					SucursalEntity.Relations.SolicitudProductoEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudProducto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ControlTurno' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathControlTurno() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ControlTurnoCollection(), _
					SucursalEntity.Relations.ControlTurnoEntityUsingCodSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), 0, Nothing, Nothing, Nothing, "ControlTurno", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMventaNotasVenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaVentaCollection(), _
					SucursalEntity.Relations.NotaVentaEntityUsingCodSucursal, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.NotaVentaEntity, Integer), 0, Nothing, Nothing, Nothing, "MventaNotasVenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioCollection(), _
					SucursalEntity.Relations.CotizacionServicioEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenServicio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenServicio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenServicioCollection(), _
					SucursalEntity.Relations.OrdenServicioEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.OrdenServicioEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenServicio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudServicios' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudServicios() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudServiciosCollection(), _
					SucursalEntity.Relations.SolicitudServiciosEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudServiciosEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudServicios", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturaFolios' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturaFolios() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturaFoliosCollection(), _
					SucursalEntity.Relations.FacturaFoliosEntityUsingScidFolioFactura, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.FacturaFoliosEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturaFolios", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					SucursalEntity.Relations.PlazaEntityUsingCodigoPlaza, _
					CType(Integralab.ORM.EntityType.SucursalEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "SucursalEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return SucursalEntity.CustomProperties
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
				Return SucursalEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CodigoPlaza property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdPlaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPlaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.CodigoPlaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.CodigoPlaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Codigo property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdSucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCDescripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCDescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCObservaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.FechaBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.UsuarioBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.MotivoBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Serie property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCSerie"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Serie]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.Serie, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.Serie, Integer), value)
			End Set
		End Property
	
		''' <summary>The ScidAlmacen property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ScidAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.ScidAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.ScidAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The ScidFolioFactura property of the Entity Sucursal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenSucursales"."SCIdFolioFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ScidFolioFactura]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(SucursalFieldIndex.ScidFolioFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(SucursalFieldIndex.ScidFolioFactura, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'GastosDepartamentosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGastosDepartamentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [GastosDepartamentos]() As Integralab.ORM.CollectionClasses.GastosDepartamentosCollection
			Get
				Return GetMultiGastosDepartamentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for GastosDepartamentos. When set to true, GastosDepartamentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time GastosDepartamentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiGastosDepartamentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchGastosDepartamentos As Boolean
			Get
				Return _alwaysFetchGastosDepartamentos
			End Get
			Set
				_alwaysFetchGastosDepartamentos = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionCompra]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiCotizacionCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompra. When set to true, CotizacionCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompra As Boolean
			Get
				Return _alwaysFetchCotizacionCompra
			End Get
			Set
				_alwaysFetchCotizacionCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompra]() As Integralab.ORM.CollectionClasses.OrdenCompraCollection
			Get
				Return GetMultiOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompra. When set to true, OrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompra As Boolean
			Get
				Return _alwaysFetchOrdenCompra
			End Get
			Set
				_alwaysFetchOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'PresupuestoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomPresupuesto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomPresupuesto]() As Integralab.ORM.CollectionClasses.PresupuestoCollection
			Get
				Return GetMultiMcomPresupuesto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomPresupuesto. When set to true, McomPresupuesto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomPresupuesto is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomPresupuesto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomPresupuesto As Boolean
			Get
				Return _alwaysFetchMcomPresupuesto
			End Get
			Set
				_alwaysFetchMcomPresupuesto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Get
				Return GetMultiRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionOrdenCompra. When set to true, RecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchRecepcionOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProducto]() As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Get
				Return GetMultiSolicitudProducto(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProducto. When set to true, SolicitudProducto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProducto is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProducto As Boolean
			Get
				Return _alwaysFetchSolicitudProducto
			End Get
			Set
				_alwaysFetchSolicitudProducto = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ControlTurnoEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiControlTurno()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ControlTurno]() As Integralab.ORM.CollectionClasses.ControlTurnoCollection
			Get
				Return GetMultiControlTurno(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ControlTurno. When set to true, ControlTurno is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ControlTurno is accessed. You can always execute
		''' a forced fetch by calling GetMultiControlTurno(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchControlTurno As Boolean
			Get
				Return _alwaysFetchControlTurno
			End Get
			Set
				_alwaysFetchControlTurno = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMventaNotasVenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MventaNotasVenta]() As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Get
				Return GetMultiMventaNotasVenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MventaNotasVenta. When set to true, MventaNotasVenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MventaNotasVenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiMventaNotasVenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMventaNotasVenta As Boolean
			Get
				Return _alwaysFetchMventaNotasVenta
			End Get
			Set
				_alwaysFetchMventaNotasVenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionServicio]() As Integralab.ORM.CollectionClasses.CotizacionServicioCollection
			Get
				Return GetMultiCotizacionServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionServicio. When set to true, CotizacionServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionServicio As Boolean
			Get
				Return _alwaysFetchCotizacionServicio
			End Get
			Set
				_alwaysFetchCotizacionServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'OrdenServicioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenServicio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenServicio]() As Integralab.ORM.CollectionClasses.OrdenServicioCollection
			Get
				Return GetMultiOrdenServicio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenServicio. When set to true, OrdenServicio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenServicio is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenServicio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenServicio As Boolean
			Get
				Return _alwaysFetchOrdenServicio
			End Get
			Set
				_alwaysFetchOrdenServicio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudServiciosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudServicios()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudServicios]() As Integralab.ORM.CollectionClasses.SolicitudServiciosCollection
			Get
				Return GetMultiSolicitudServicios(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudServicios. When set to true, SolicitudServicios is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudServicios is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudServicios(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudServicios As Boolean
			Get
				Return _alwaysFetchSolicitudServicios
			End Get
			Set
				_alwaysFetchSolicitudServicios = value
			End Set	
		End Property
	
	
	
		''' <summary>Gets / sets related entity of type 'FacturaFoliosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleFacturaFolios()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [FacturaFolios]() As FacturaFoliosEntity
			Get
				Return GetSingleFacturaFolios(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncFacturaFolios(value)
				Else
					If value Is Nothing Then
						If Not _facturaFolios Is Nothing Then
							_facturaFolios.UnsetRelatedEntity(Me, "Sucursal")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Sucursal")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturaFolios. When set to true, FacturaFolios is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturaFolios is accessed. You can always execute
		''' a forced fetch by calling GetSingleFacturaFolios(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturaFolios As Boolean
			Get
				Return _alwaysFetchFacturaFolios
			End Get
			Set
				_alwaysFetchFacturaFolios = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property FacturaFolios is not found
		''' in the database. When set to true, FacturaFolios will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property FacturaFoliosReturnsNewIfNotFound As Boolean
			Get
				Return _facturaFoliosReturnsNewIfNotFound
			End Get
			Set
				_facturaFoliosReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PlazaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePlaza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Plaza]() As PlazaEntity
			Get
				Return GetSinglePlaza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPlaza(value)
				Else
					If value Is Nothing Then
						If Not _plaza Is Nothing Then
							_plaza.UnsetRelatedEntity(Me, "Sucursal")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Sucursal")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Plaza. When set to true, Plaza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Plaza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePlaza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlaza As Boolean
			Get
				Return _alwaysFetchPlaza
			End Get
			Set
				_alwaysFetchPlaza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Plaza is not found
		''' in the database. When set to true, Plaza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PlazaReturnsNewIfNotFound As Boolean
			Get
				Return _plazaReturnsNewIfNotFound
			End Get
			Set
				_plazaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.SucursalEntity)
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
