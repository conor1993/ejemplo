' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:32
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
	''' <summary>Entity class which represents the entity 'McomCotizacionCompraProveedor'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McomCotizacionCompraProveedorEntity 
#Else
	<Serializable()> _
	Public Class McomCotizacionCompraProveedorEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
		Private _alwaysFetchMcomCotizacionCompraProveedorDetalle, _alreadyFetchedMcomCotizacionCompraProveedorDetalle As Boolean
		Private _productoCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
		Private _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.ProveedorCollection
		Private _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle, _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean
		Private _cotizacionCompra As McomCotizacionCompraEntity
		Private _alwaysFetchCotizacionCompra, _alreadyFetchedCotizacionCompra, _cotizacionCompraReturnsNewIfNotFound As Boolean


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
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32)

			InitClassFetch(idCotizacion, idProveedor, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCotizacion, idProveedor, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="validator">The custom validator Object for this McomCotizacionCompraProveedorEntity</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32, validator As IValidator)

			InitClassFetch(idCotizacion, idProveedor, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_mcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection)
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedorDetalle")
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle")
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection)
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.ProveedorCollection)), Integralab.ORM.CollectionClasses.ProveedorCollection)
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle")
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle")
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_cotizacionCompra = CType(info.GetValue("_cotizacionCompra", GetType(McomCotizacionCompraEntity)), McomCotizacionCompraEntity)
			If Not _cotizacionCompra Is Nothing Then
				AddHandler _cotizacionCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cotizacionCompraReturnsNewIfNotFound = info.GetBoolean("_cotizacionCompraReturnsNewIfNotFound")
			_alwaysFetchCotizacionCompra = info.GetBoolean("_alwaysFetchCotizacionCompra")
			_alreadyFetchedCotizacionCompra = info.GetBoolean("_alreadyFetchedCotizacionCompra")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = (_mcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = (_productoCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = (_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = (_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = (_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = (_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Count > 0)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)
			_alreadyFetchedCotizacionCompra = Not(_cotizacionCompra Is Nothing)

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
			info.AddValue("_mcomCotizacionCompraProveedorDetalle", _mcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedorDetalle", _alwaysFetchMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedorDetalle", _alreadyFetchedMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_productoCollectionViaMcomCotizacionCompraProveedorDetalle", _productoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_cotizacionCompra", _cotizacionCompra)
			info.AddValue("_cotizacionCompraReturnsNewIfNotFound", _cotizacionCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCotizacionCompra", _alwaysFetchCotizacionCompra)
			info.AddValue("_alreadyFetchedCotizacionCompra", _alreadyFetchedCotizacionCompra)

			
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
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)
				Case "CotizacionCompra"
					_alreadyFetchedCotizacionCompra = True
					Me.CotizacionCompra = CType(entity, McomCotizacionCompraEntity)
				Case "McomCotizacionCompraProveedorDetalle"
					_alreadyFetchedMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.McomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraProveedorDetalleEntity))
					End If
				Case "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, SolicitudProductoDetalleEntity))
					End If
				Case "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, ProveedorEntity))
					End If
				Case "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle"
					_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.Add(CType(entity, McomCotizacionCompraEntity))
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
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionCompra"
					SetupSyncCotizacionCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					_mcomCotizacionCompraProveedorDetalle.Add(CType(relatedEntity, McomCotizacionCompraProveedorDetalleEntity))
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
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionCompra"
					DesetupSyncCotizacionCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedorDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomCotizacionCompraProveedorDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
			End If
			If Not _cotizacionCompra Is Nothing Then
				toReturn.Add(_cotizacionCompra)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mcomCotizacionCompraProveedorDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32) As Boolean
			Return FetchUsingPK(idCotizacion, idProveedor, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCotizacion, idProveedor, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCotizacion, idProveedor, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCotizacion, Me.IdProveedor, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McomCotizacionCompraProveedorFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McomCotizacionCompraProveedorFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorDetalleEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraProveedorDetalleEntity'</returns>
		Public Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Return GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch, _mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			If ( Not _alreadyFetchedMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomCotizacionCompraProveedorDetalle)
					End If
				End If
				_mcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomCotizacionCompraProveedorDetalle.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_mcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _mcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property McomCotizacionCompraProveedorDetalle is requested or GetMultiMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_mcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _productoCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _productoCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoDetalleEntity'</returns>
		Public Function GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Return GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			If ( Not _alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProveedorEntity'</returns>
		Public Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProveedorCollection
			Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProveedorCollection
			If ( Not _alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _proveedorCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch, _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle Or forceFetch Or _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", "McomCotizacionCompraProveedorDetalle_", JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "McomCotizacionCompraProveedorDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdCotizacion), ComparisonOperator.Equal, Me.IdCotizacion))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McomCotizacionCompraProveedorFieldIndex.IdProveedor), ComparisonOperator.Equal, Me.IdProveedor))
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.GetMulti(Filter, relations)
				_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = True
			End If
			Return _cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle'. These settings will be taken into account
		''' when the property CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is requested or GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.SortClauses=sortClauses
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor() As ProveedorEntity
			Return GetSingleProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor(forceFetch As Boolean) As ProveedorEntity
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProveedor)
				End If
				If Not _proveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Proveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorEntity)
					End If
					Me.Proveedor = newEntity
					_alreadyFetchedProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedor
		End Function
	
		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra() As McomCotizacionCompraEntity
			Return GetSingleCotizacionCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra(forceFetch As Boolean) As McomCotizacionCompraEntity
			If ( Not _alreadyFetchedCotizacionCompra Or forceFetch Or _alwaysFetchCotizacionCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McomCotizacionCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCotizacion)
				End If
				If Not _cotizacionCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CotizacionCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McomCotizacionCompraEntity)
					End If
					Me.CotizacionCompra = newEntity
					_alreadyFetchedCotizacionCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cotizacionCompra
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McomCotizacionCompraProveedorFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McomCotizacionCompraProveedorFieldIndex)
					Case McomCotizacionCompraProveedorFieldIndex.IdCotizacion
						DesetupSyncCotizacionCompra(True, False)
						_alreadyFetchedCotizacionCompra = False
					Case McomCotizacionCompraProveedorFieldIndex.IdProveedor
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False











					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle.ActiveContext = MyBase.ActiveContext
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cotizacionCompra Is Nothing Then
				_cotizacionCompra.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McomCotizacionCompraProveedorDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McomCotizacionCompraProveedorDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McomCotizacionCompraProveedorDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McomCotizacionCompraProveedorEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="validator">The validator Object for this McomCotizacionCompraProveedorEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCotizacion As System.Int32, idProveedor As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCotizacion, idProveedor, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(New McomCotizacionCompraProveedorDetalleEntityFactory())
			_mcomCotizacionCompraProveedorDetalle.SetContainingEntityInfo(Me, "McomCotizacionCompraProveedor")
			_alwaysFetchMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedMcomCotizacionCompraProveedorDetalle = False
			_productoCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProductoCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_solicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(New SolicitudProductoDetalleEntityFactory())
			_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedorCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.ProveedorCollection(New ProveedorEntityFactory())
			_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_tipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_cotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_cotizacionCompra = Nothing
			_cotizacionCompraReturnsNewIfNotFound = True
			_alwaysFetchCotizacionCompra = False
			_alreadyFetchedCotizacionCompra = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVigencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor, True, signalRelatedEntity, "McomCotizacionCompraProveedor", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorFieldIndex.IdProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor, True, _alreadyFetchedProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cotizacionCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCotizacionCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, signalRelatedEntity, "McomCotizacionCompraProveedor", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorFieldIndex.IdCotizacion) } )
			_cotizacionCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cotizacionCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCotizacionCompra(relatedEntity As IEntity)
			DesetupSyncCotizacionCompra(True, True)
			_cotizacionCompra = CType(relatedEntity, McomCotizacionCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, _alreadyFetchedCotizacionCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCotizacionCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedor which data should be fetched into this McomCotizacionCompraProveedor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCotizacion As System.Int32, idProveedor As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdCotizacion)).ForcedCurrentValueWrite(idCotizacion)
				MyBase.Fields(CInt(McomCotizacionCompraProveedorFieldIndex.IdProveedor)).ForcedCurrentValueWrite(idProveedor)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcomCotizacionCompraProveedorDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McomCotizacionCompraProveedorEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McomCotizacionCompraProveedorRelations
			Get	
				Return New McomCotizacionCompraProveedorRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedorDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedorCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, relations, "ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, "__McomCotizacionCompraProveedorEntity__", String.Empty, JoinHint.None)
				relations.Add(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.ProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					McomCotizacionCompraProveedorEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McomCotizacionCompraProveedorEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McomCotizacionCompraProveedorEntity.CustomProperties
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
				Return McomCotizacionCompraProveedorEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCotizacion property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."IdCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdCotizacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdCotizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."DiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."Iva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCotizacion property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."FechaCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCotizacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaCotizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVigencia property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."FechaVigencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVigencia]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaVigencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.FechaVigencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity McomCotizacionCompraProveedor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedor"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraProveedorDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorDetalleCollection
			Get
				Return GetMultiMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraProveedorDetalle. When set to true, McomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection
			Get
				Return GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoDetalleCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProveedorEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.ProveedorCollection
			Get
				Return GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProveedorCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProveedorCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchProveedorCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle. When set to true, CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle As Boolean
			Get
				Return _alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle
			End Get
			Set
				_alwaysFetchCotizacionCompraCollectionViaMcomCotizacionCompraProveedorDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'ProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Proveedor]() As ProveedorEntity
			Get
				Return GetSingleProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedor(value)
				Else
					If value Is Nothing Then
						If Not _proveedor Is Nothing Then
							_proveedor.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedor")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Proveedor is not found
		''' in the database. When set to true, Proveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorReturnsNewIfNotFound
			End Get
			Set
				_proveedorReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McomCotizacionCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCotizacionCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CotizacionCompra]() As McomCotizacionCompraEntity
			Get
				Return GetSingleCotizacionCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCotizacionCompra(value)
				Else
					If value Is Nothing Then
						If Not _cotizacionCompra Is Nothing Then
							_cotizacionCompra.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedor")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompra. When set to true, CotizacionCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleCotizacionCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompra As Boolean
			Get
				Return _alwaysFetchCotizacionCompra
			End Get
			Set
				_alwaysFetchCotizacionCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CotizacionCompra is not found
		''' in the database. When set to true, CotizacionCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CotizacionCompraReturnsNewIfNotFound As Boolean
			Get
				Return _cotizacionCompraReturnsNewIfNotFound
			End Get
			Set
				_cotizacionCompraReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity)
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
