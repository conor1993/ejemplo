' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 10:43:41
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
	''' <summary>Entity class which represents the entity 'TipoAlmacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class TipoAlmacenEntity 
#Else
	<Serializable()> _
	Public Class TipoAlmacenEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _configGan As Integralab.ORM.CollectionClasses.ConfigGanCollection
		Private _alwaysFetchConfigGan, _alreadyFetchedConfigGan As Boolean
		Private _configGan_ As Integralab.ORM.CollectionClasses.ConfigGanCollection
		Private _alwaysFetchConfigGan_, _alreadyFetchedConfigGan_ As Boolean
		Private _configGan__ As Integralab.ORM.CollectionClasses.ConfigGanCollection
		Private _alwaysFetchConfigGan__, _alreadyFetchedConfigGan__ As Boolean
		Private _almacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen As Boolean
		Private _usrProdConfiguracion As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
		Private _alwaysFetchUsrProdConfiguracion, _alreadyFetchedUsrProdConfiguracion As Boolean
		Private _plazaCollectionViaAlmacen As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaAlmacen, _alreadyFetchedPlazaCollectionViaAlmacen As Boolean
		Private _almacenCollectionViaAlmacen As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaAlmacen, _alreadyFetchedAlmacenCollectionViaAlmacen As Boolean
		Private _cuentaContableCollectionViaAlmacen As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaAlmacen, _alreadyFetchedCuentaContableCollectionViaAlmacen As Boolean



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
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <param name="validator">The custom validator Object for this TipoAlmacenEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_configGan = CType(info.GetValue("_configGan", GetType(Integralab.ORM.CollectionClasses.ConfigGanCollection)), Integralab.ORM.CollectionClasses.ConfigGanCollection)
			_alwaysFetchConfigGan = info.GetBoolean("_alwaysFetchConfigGan")
			_alreadyFetchedConfigGan = info.GetBoolean("_alreadyFetchedConfigGan")
			_configGan_ = CType(info.GetValue("_configGan_", GetType(Integralab.ORM.CollectionClasses.ConfigGanCollection)), Integralab.ORM.CollectionClasses.ConfigGanCollection)
			_alwaysFetchConfigGan_ = info.GetBoolean("_alwaysFetchConfigGan_")
			_alreadyFetchedConfigGan_ = info.GetBoolean("_alreadyFetchedConfigGan_")
			_configGan__ = CType(info.GetValue("_configGan__", GetType(Integralab.ORM.CollectionClasses.ConfigGanCollection)), Integralab.ORM.CollectionClasses.ConfigGanCollection)
			_alwaysFetchConfigGan__ = info.GetBoolean("_alwaysFetchConfigGan__")
			_alreadyFetchedConfigGan__ = info.GetBoolean("_alreadyFetchedConfigGan__")
			_almacen = CType(info.GetValue("_almacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_usrProdConfiguracion = CType(info.GetValue("_usrProdConfiguracion", GetType(Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection)), Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection)
			_alwaysFetchUsrProdConfiguracion = info.GetBoolean("_alwaysFetchUsrProdConfiguracion")
			_alreadyFetchedUsrProdConfiguracion = info.GetBoolean("_alreadyFetchedUsrProdConfiguracion")
			_plazaCollectionViaAlmacen = CType(info.GetValue("_plazaCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaAlmacen = info.GetBoolean("_alwaysFetchPlazaCollectionViaAlmacen")
			_alreadyFetchedPlazaCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedPlazaCollectionViaAlmacen")
			_almacenCollectionViaAlmacen = CType(info.GetValue("_almacenCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaAlmacen = info.GetBoolean("_alwaysFetchAlmacenCollectionViaAlmacen")
			_alreadyFetchedAlmacenCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaAlmacen")
			_cuentaContableCollectionViaAlmacen = CType(info.GetValue("_cuentaContableCollectionViaAlmacen", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaAlmacen = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaAlmacen")
			_alreadyFetchedCuentaContableCollectionViaAlmacen = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaAlmacen")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedConfigGan = (_configGan.Count > 0)
			_alreadyFetchedConfigGan_ = (_configGan_.Count > 0)
			_alreadyFetchedConfigGan__ = (_configGan__.Count > 0)
			_alreadyFetchedAlmacen = (_almacen.Count > 0)
			_alreadyFetchedUsrProdConfiguracion = (_usrProdConfiguracion.Count > 0)
			_alreadyFetchedPlazaCollectionViaAlmacen = (_plazaCollectionViaAlmacen.Count > 0)
			_alreadyFetchedAlmacenCollectionViaAlmacen = (_almacenCollectionViaAlmacen.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaAlmacen = (_cuentaContableCollectionViaAlmacen.Count > 0)


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
			info.AddValue("_configGan", _configGan)
			info.AddValue("_alwaysFetchConfigGan", _alwaysFetchConfigGan)
			info.AddValue("_alreadyFetchedConfigGan", _alreadyFetchedConfigGan)
			info.AddValue("_configGan_", _configGan_)
			info.AddValue("_alwaysFetchConfigGan_", _alwaysFetchConfigGan_)
			info.AddValue("_alreadyFetchedConfigGan_", _alreadyFetchedConfigGan_)
			info.AddValue("_configGan__", _configGan__)
			info.AddValue("_alwaysFetchConfigGan__", _alwaysFetchConfigGan__)
			info.AddValue("_alreadyFetchedConfigGan__", _alreadyFetchedConfigGan__)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_usrProdConfiguracion", _usrProdConfiguracion)
			info.AddValue("_alwaysFetchUsrProdConfiguracion", _alwaysFetchUsrProdConfiguracion)
			info.AddValue("_alreadyFetchedUsrProdConfiguracion", _alreadyFetchedUsrProdConfiguracion)
			info.AddValue("_plazaCollectionViaAlmacen", _plazaCollectionViaAlmacen)
			info.AddValue("_alwaysFetchPlazaCollectionViaAlmacen", _alwaysFetchPlazaCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedPlazaCollectionViaAlmacen", _alreadyFetchedPlazaCollectionViaAlmacen)
			info.AddValue("_almacenCollectionViaAlmacen", _almacenCollectionViaAlmacen)
			info.AddValue("_alwaysFetchAlmacenCollectionViaAlmacen", _alwaysFetchAlmacenCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaAlmacen", _alreadyFetchedAlmacenCollectionViaAlmacen)
			info.AddValue("_cuentaContableCollectionViaAlmacen", _cuentaContableCollectionViaAlmacen)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaAlmacen", _alwaysFetchCuentaContableCollectionViaAlmacen)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaAlmacen", _alreadyFetchedCuentaContableCollectionViaAlmacen)


			
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

				Case "ConfigGan"
					_alreadyFetchedConfigGan = True
					If Not entity Is Nothing Then
						Me.ConfigGan.Add(CType(entity, ConfigGanEntity))
					End If
				Case "ConfigGan_"
					_alreadyFetchedConfigGan_ = True
					If Not entity Is Nothing Then
						Me.ConfigGan_.Add(CType(entity, ConfigGanEntity))
					End If
				Case "ConfigGan__"
					_alreadyFetchedConfigGan__ = True
					If Not entity Is Nothing Then
						Me.ConfigGan__.Add(CType(entity, ConfigGanEntity))
					End If
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					If Not entity Is Nothing Then
						Me.Almacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "UsrProdConfiguracion"
					_alreadyFetchedUsrProdConfiguracion = True
					If Not entity Is Nothing Then
						Me.UsrProdConfiguracion.Add(CType(entity, UsrProdConfiguracionEntity))
					End If
				Case "PlazaCollectionViaAlmacen"
					_alreadyFetchedPlazaCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaAlmacen.Add(CType(entity, PlazaEntity))
					End If
				Case "AlmacenCollectionViaAlmacen"
					_alreadyFetchedAlmacenCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaAlmacen.Add(CType(entity, AlmacenEntity))
					End If
				Case "CuentaContableCollectionViaAlmacen"
					_alreadyFetchedCuentaContableCollectionViaAlmacen = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaAlmacen.Add(CType(entity, CuentaContableEntity))
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

				Case "ConfigGan"
					_configGan.Add(CType(relatedEntity, ConfigGanEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ConfigGan_"
					_configGan_.Add(CType(relatedEntity, ConfigGanEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ConfigGan__"
					_configGan__.Add(CType(relatedEntity, ConfigGanEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen"
					_almacen.Add(CType(relatedEntity, AlmacenEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrProdConfiguracion"
					_usrProdConfiguracion.Add(CType(relatedEntity, UsrProdConfiguracionEntity))
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

				Case "ConfigGan"
					MyBase.PerformRelatedEntityRemoval(_configGan, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ConfigGan_"
					MyBase.PerformRelatedEntityRemoval(_configGan_, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ConfigGan__"
					MyBase.PerformRelatedEntityRemoval(_configGan__, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen"
					MyBase.PerformRelatedEntityRemoval(_almacen, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrProdConfiguracion"
					MyBase.PerformRelatedEntityRemoval(_usrProdConfiguracion, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_configGan)
			toReturn.Add(_configGan_)
			toReturn.Add(_configGan__)
			toReturn.Add(_almacen)
			toReturn.Add(_usrProdConfiguracion)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As TipoAlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As TipoAlmacenFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan(forceFetch, _configGan.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiConfigGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan(forceFetch, _configGan.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiConfigGan(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			If ( Not _alreadyFetchedConfigGan Or forceFetch Or _alwaysFetchConfigGan) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _configGan.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_configGan)
					End If
				End If
				_configGan.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_configGan.EntityFactoryToUse = entityFactoryToUse
				End If
				_configGan.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_configGan.SuppressClearInGetMulti = False
				_alreadyFetchedConfigGan = True
			End If
			Return _configGan
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ConfigGan'. These settings will be taken into account
		''' when the property ConfigGan is requested or GetMultiConfigGan is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersConfigGan(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_configGan.SortClauses=sortClauses
			_configGan.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan_(forceFetch, _configGan_.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiConfigGan_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan_(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan_(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan_(forceFetch, _configGan_.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiConfigGan_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			If ( Not _alreadyFetchedConfigGan_ Or forceFetch Or _alwaysFetchConfigGan_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _configGan_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_configGan_)
					End If
				End If
				_configGan_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_configGan_.EntityFactoryToUse = entityFactoryToUse
				End If
				_configGan_.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_configGan_.SuppressClearInGetMulti = False
				_alreadyFetchedConfigGan_ = True
			End If
			Return _configGan_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ConfigGan_'. These settings will be taken into account
		''' when the property ConfigGan_ is requested or GetMultiConfigGan_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersConfigGan_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_configGan_.SortClauses=sortClauses
			_configGan_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan__(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan__(forceFetch, _configGan__.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiConfigGan__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan__(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ConfigGanEntity'</returns>
		Public Function GetMultiConfigGan__(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Return GetMultiConfigGan__(forceFetch, _configGan__.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiConfigGan__(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ConfigGanCollection
			If ( Not _alreadyFetchedConfigGan__ Or forceFetch Or _alwaysFetchConfigGan__) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _configGan__.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_configGan__)
					End If
				End If
				_configGan__.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_configGan__.EntityFactoryToUse = entityFactoryToUse
				End If
				_configGan__.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_configGan__.SuppressClearInGetMulti = False
				_alreadyFetchedConfigGan__ = True
			End If
			Return _configGan__
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ConfigGan__'. These settings will be taken into account
		''' when the property ConfigGan__ is requested or GetMultiConfigGan__ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersConfigGan__(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_configGan__.SortClauses=sortClauses
			_configGan__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, _almacen.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacen(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacen(forceFetch, _almacen.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacen)
					End If
				End If
				_almacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacen.GetMultiManyToOne(Nothing, Nothing, Me, Nothing, Filter)
				_almacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacen = True
			End If
			Return _almacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'Almacen'. These settings will be taken into account
		''' when the property Almacen is requested or GetMultiAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacen.SortClauses=sortClauses
			_almacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'UsrProdConfiguracionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdConfiguracionEntity'</returns>
		Public Function GetMultiUsrProdConfiguracion(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
			Return GetMultiUsrProdConfiguracion(forceFetch, _usrProdConfiguracion.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdConfiguracionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrProdConfiguracion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
			Return GetMultiUsrProdConfiguracion(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdConfiguracionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'UsrProdConfiguracionEntity'</returns>
		Public Function GetMultiUsrProdConfiguracion(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
			Return GetMultiUsrProdConfiguracion(forceFetch, _usrProdConfiguracion.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'UsrProdConfiguracionEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrProdConfiguracion(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
			If ( Not _alreadyFetchedUsrProdConfiguracion Or forceFetch Or _alwaysFetchUsrProdConfiguracion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrProdConfiguracion.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrProdConfiguracion)
					End If
				End If
				_usrProdConfiguracion.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrProdConfiguracion.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrProdConfiguracion.GetMultiManyToOne(Me, Filter)
				_usrProdConfiguracion.SuppressClearInGetMulti = False
				_alreadyFetchedUsrProdConfiguracion = True
			End If
			Return _usrProdConfiguracion
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrProdConfiguracion'. These settings will be taken into account
		''' when the property UsrProdConfiguracion is requested or GetMultiUsrProdConfiguracion is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrProdConfiguracion(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrProdConfiguracion.SortClauses=sortClauses
			_usrProdConfiguracion.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaAlmacen(forceFetch, _plazaCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaAlmacen Or forceFetch Or _alwaysFetchPlazaCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaAlmacen.GetMulti(Filter, relations)
				_plazaCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaAlmacen = True
			End If
			Return _plazaCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaAlmacen'. These settings will be taken into account
		''' when the property PlazaCollectionViaAlmacen is requested or GetMultiPlazaCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaAlmacen.SortClauses=sortClauses
			_plazaCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaAlmacen(forceFetch, _almacenCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaAlmacen Or forceFetch Or _alwaysFetchAlmacenCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_almacenCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaAlmacen.GetMulti(Filter, relations)
				_almacenCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaAlmacen = True
			End If
			Return _almacenCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaAlmacen'. These settings will be taken into account
		''' when the property AlmacenCollectionViaAlmacen is requested or GetMultiAlmacenCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaAlmacen.SortClauses=sortClauses
			_almacenCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaAlmacen(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaAlmacen(forceFetch, _cuentaContableCollectionViaAlmacen.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaAlmacen(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaAlmacen Or forceFetch Or _alwaysFetchCuentaContableCollectionViaAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaAlmacen.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaAlmacen)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", "Almacen_", JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable, "Almacen_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoAlmacenFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_cuentaContableCollectionViaAlmacen.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaAlmacen.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaAlmacen.GetMulti(Filter, relations)
				_cuentaContableCollectionViaAlmacen.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaAlmacen = True
			End If
			Return _cuentaContableCollectionViaAlmacen
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaAlmacen'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaAlmacen is requested or GetMultiCuentaContableCollectionViaAlmacen is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaAlmacen(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaAlmacen.SortClauses=sortClauses
			_cuentaContableCollectionViaAlmacen.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(TipoAlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, TipoAlmacenFieldIndex)










					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_configGan.ActiveContext = MyBase.ActiveContext
			_configGan_.ActiveContext = MyBase.ActiveContext
			_configGan__.ActiveContext = MyBase.ActiveContext
			_almacen.ActiveContext = MyBase.ActiveContext
			_usrProdConfiguracion.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaAlmacen.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As TipoAlmacenDAO = CType(CreateDAOInstance(), TipoAlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As TipoAlmacenDAO = CType(CreateDAOInstance(), TipoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As TipoAlmacenDAO = CType(CreateDAOInstance(), TipoAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this TipoAlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.TipoAlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <param name="validator">The validator Object for this TipoAlmacenEntity</param>
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
			_configGan = New Integralab.ORM.CollectionClasses.ConfigGanCollection(New ConfigGanEntityFactory())
			_configGan.SetContainingEntityInfo(Me, "TipoAlmacenFormula")
			_alwaysFetchConfigGan = False
			_alreadyFetchedConfigGan = False
			_configGan_ = New Integralab.ORM.CollectionClasses.ConfigGanCollection(New ConfigGanEntityFactory())
			_configGan_.SetContainingEntityInfo(Me, "TipoAlmacenMedicamento")
			_alwaysFetchConfigGan_ = False
			_alreadyFetchedConfigGan_ = False
			_configGan__ = New Integralab.ORM.CollectionClasses.ConfigGanCollection(New ConfigGanEntityFactory())
			_configGan__.SetContainingEntityInfo(Me, "TipoAlmacenRolado")
			_alwaysFetchConfigGan__ = False
			_alreadyFetchedConfigGan__ = False
			_almacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_almacen.SetContainingEntityInfo(Me, "TipoAlmacen_")
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_usrProdConfiguracion = New Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection(New UsrProdConfiguracionEntityFactory())
			_usrProdConfiguracion.SetContainingEntityInfo(Me, "TipoAlmacen")
			_alwaysFetchUsrProdConfiguracion = False
			_alreadyFetchedUsrProdConfiguracion = False
			_plazaCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaAlmacen = False
			_alreadyFetchedPlazaCollectionViaAlmacen = False
			_almacenCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaAlmacen = False
			_alreadyFetchedAlmacenCollectionViaAlmacen = False
			_cuentaContableCollectionViaAlmacen = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaAlmacen = False
			_alreadyFetchedCuentaContableCollectionViaAlmacen = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
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

			_fieldsCustomProperties.Add("EsSubAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DeProduccion", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for TipoAlmacen which data should be fetched into this TipoAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(TipoAlmacenFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateTipoAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New TipoAlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As TipoAlmacenRelations
			Get	
				Return New TipoAlmacenRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConfigGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathConfigGan() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConfigGanCollection(), _
					TipoAlmacenEntity.Relations.ConfigGanEntityUsingIdTipoAlmacenFormula, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ConfigGanEntity, Integer), 0, Nothing, Nothing, Nothing, "ConfigGan", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConfigGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathConfigGan_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConfigGanCollection(), _
					TipoAlmacenEntity.Relations.ConfigGanEntityUsingIdTipoAlmacenMedicamento, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ConfigGanEntity, Integer), 0, Nothing, Nothing, Nothing, "ConfigGan_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ConfigGan' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathConfigGan__() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ConfigGanCollection(), _
					TipoAlmacenEntity.Relations.ConfigGanEntityUsingIdTipoAlmacenRolado, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ConfigGanEntity, Integer), 0, Nothing, Nothing, Nothing, "ConfigGan__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UsrProdConfiguracion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrProdConfiguracion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection(), _
					TipoAlmacenEntity.Relations.UsrProdConfiguracionEntityUsingIdTipoAlmacen, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.UsrProdConfiguracionEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrProdConfiguracion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.AlmacenEntityUsingAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaAlmacen() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, "__TipoAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(AlmacenEntity.Relations.CuentaContableEntityUsingIdCuentaContable)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					TipoAlmacenEntity.Relations.AlmacenEntityUsingTipoAlmacen, _
					CType(Integralab.ORM.EntityType.TipoAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "TipoAlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return TipoAlmacenEntity.CustomProperties
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
				Return TipoAlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."Nombre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."NombreCorto"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.FechaAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."UsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.UsuarioAlta, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."UsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsSubAlmacen property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."EsSubAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsSubAlmacen]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.EsSubAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.EsSubAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The DeProduccion property of the Entity TipoAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatTiposAlmacenes"."DeProduccion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DeProduccion]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoAlmacenFieldIndex.DeProduccion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoAlmacenFieldIndex.DeProduccion, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiConfigGan()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ConfigGan]() As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Get
				Return GetMultiConfigGan(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ConfigGan. When set to true, ConfigGan is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ConfigGan is accessed. You can always execute
		''' a forced fetch by calling GetMultiConfigGan(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchConfigGan As Boolean
			Get
				Return _alwaysFetchConfigGan
			End Get
			Set
				_alwaysFetchConfigGan = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiConfigGan_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ConfigGan_]() As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Get
				Return GetMultiConfigGan_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ConfigGan_. When set to true, ConfigGan_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ConfigGan_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiConfigGan_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchConfigGan_ As Boolean
			Get
				Return _alwaysFetchConfigGan_
			End Get
			Set
				_alwaysFetchConfigGan_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ConfigGanEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiConfigGan__()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ConfigGan__]() As Integralab.ORM.CollectionClasses.ConfigGanCollection
			Get
				Return GetMultiConfigGan__(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ConfigGan__. When set to true, ConfigGan__ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ConfigGan__ is accessed. You can always execute
		''' a forced fetch by calling GetMultiConfigGan__(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchConfigGan__ As Boolean
			Get
				Return _alwaysFetchConfigGan__
			End Get
			Set
				_alwaysFetchConfigGan__ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [Almacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen. When set to true, Almacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacen
			End Get
			Set
				_alwaysFetchAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'UsrProdConfiguracionEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrProdConfiguracion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrProdConfiguracion]() As Integralab.ORM.CollectionClasses.UsrProdConfiguracionCollection
			Get
				Return GetMultiUsrProdConfiguracion(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrProdConfiguracion. When set to true, UsrProdConfiguracion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrProdConfiguracion is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrProdConfiguracion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrProdConfiguracion As Boolean
			Get
				Return _alwaysFetchUsrProdConfiguracion
			End Get
			Set
				_alwaysFetchUsrProdConfiguracion = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaAlmacen. When set to true, PlazaCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchPlazaCollectionViaAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaAlmacen. When set to true, AlmacenCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaAlmacen = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaAlmacen]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaAlmacen(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaAlmacen. When set to true, CuentaContableCollectionViaAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaAlmacen As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaAlmacen
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaAlmacen = value
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
				Return CInt(Integralab.ORM.EntityType.TipoAlmacenEntity)
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
